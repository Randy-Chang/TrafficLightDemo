using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TrafficLightDemo.FSM.Interface
{
    /// <summary>
    /// MainForm 只負責 UI 事件、使用者輸入與物件組裝。
    /// 控制項和畫面配置位於 MainForm.Designer.cs，狀態切換規則位於 TrafficLightController。
    /// </summary>
    public sealed partial class MainForm : Form
    {
        private TrafficLightController controller;
        private FakeTrafficLightOutput fakeOutput;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // 執行期初始化放在 Load，避免 Visual Studio Designer 載入時啟動狀態機。
            CreateControllerWithSelectedOutput();
            updateTimer.Start();
            SetRunButtons(isRunning: false);
        }

        /// <summary>
        /// 這裡是本範例的 Composition Root：選擇實作並注入 Controller。
        /// </summary>
        private void CreateControllerWithSelectedOutput()
        {
            ClearVisibleOutputs();
            fakeOutput = null;

            ITrafficLightOutput output;
            switch (outputComboBox.SelectedIndex)
            {
                case 1:
                    output = new TextTrafficLightOutput(outputStatusLabel);
                    explanationLabel.Text = "TextTrafficLightOutput：使用 Label 顯示，同一個 Controller 不需要修改。";
                    break;

                case 2:
                    fakeOutput = new FakeTrafficLightOutput();
                    output = fakeOutput;
                    explanationLabel.Text = "FakeTrafficLightOutput：不操作 UI 或硬體，只記錄收到的狀態，可供測試使用。";
                    break;

                default:
                    output = new PanelTrafficLightOutput(greenPanel, yellowPanel, redPanel);
                    explanationLabel.Text = "PanelTrafficLightOutput：使用三個 WinForms Panel 顯示燈號。";
                    break;
            }

            // Constructor Injection：Controller 需要輸出能力，但不負責建立輸出物件。
            controller = new TrafficLightController(output);
            ApplyDurations(showValidationMessage: false);
            UpdateStatusLabels();
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            controller.Update();

            if (fakeOutput != null)
            {
                string history = string.Join(" → ", fakeOutput.History.Select(state => state.ToString()));
                outputStatusLabel.Text = $"FAKE HISTORY : {history}";
                outputStatusLabel.ForeColor = Color.DarkSlateBlue;
            }

            UpdateStatusLabels();
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            ApplyDurations(showValidationMessage: true);
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            controller.Start();
            SetRunButtons(isRunning: true);
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            controller.Pause();
            SetRunButtons(isRunning: false);
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            controller.Reset();
            if (fakeOutput != null)
            {
                fakeOutput.History.Clear();
                fakeOutput.Show(controller.CurrentState);
            }

            SetRunButtons(isRunning: false);
            UpdateStatusLabels();
        }

        private void OutputComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (outputComboBox.SelectedIndex >= 0)
            {
                CreateControllerWithSelectedOutput();
                SetRunButtons(isRunning: false);
            }
        }

        private bool ApplyDurations(bool showValidationMessage)
        {
            if (!TryReadPositiveSeconds(greenDurationTextBox, "綠燈", out int greenSeconds) ||
                !TryReadPositiveSeconds(yellowDurationTextBox, "黃燈", out int yellowSeconds) ||
                !TryReadPositiveSeconds(redDurationTextBox, "紅燈", out int redSeconds))
            {
                if (showValidationMessage)
                {
                    MessageBox.Show("請為三個燈號輸入大於 0 的秒數。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                return false;
            }

            controller.SetDurations(greenSeconds, yellowSeconds, redSeconds);
            SetRunButtons(isRunning: false);
            return true;
        }

        private void UpdateStatusLabels()
        {
            elapsedTimeLabel.Text = $"Timer : {controller.ElapsedSeconds}";
            mainStateLabel.Text = $"MainState : {controller.MainState}";
            lightStateLabel.Text = $"LightState : {controller.CurrentState}";
        }

        private void SetRunButtons(bool isRunning)
        {
            startButton.Enabled = !isRunning;
            pauseButton.Enabled = isRunning;
            outputComboBox.Enabled = !isRunning;
            applyButton.Enabled = !isRunning;
            greenDurationTextBox.Enabled = !isRunning;
            yellowDurationTextBox.Enabled = !isRunning;
            redDurationTextBox.Enabled = !isRunning;
        }

        private void ClearVisibleOutputs()
        {
            greenPanel.BackColor = Color.Black;
            yellowPanel.BackColor = Color.Black;
            redPanel.BackColor = Color.Black;
            outputStatusLabel.Text = string.Empty;
            outputStatusLabel.ForeColor = Color.Black;
        }

        private static bool TryReadPositiveSeconds(TextBox textBox, string name, out int seconds)
        {
            if (int.TryParse(textBox.Text, out seconds) && seconds > 0)
            {
                return true;
            }

            textBox.Focus();
            textBox.SelectAll();
            textBox.AccessibleDescription = $"{name}時間必須大於 0";
            return false;
        }
    }
}
