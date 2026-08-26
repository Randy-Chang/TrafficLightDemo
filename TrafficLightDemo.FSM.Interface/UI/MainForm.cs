using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace TrafficLightDemo.FSM.Interface
{
    /// <summary>
    /// MainForm 只負責 UI 事件、使用者輸入與物件組裝。
    /// 控制項和畫面配置位於 MainForm.Designer.cs，狀態切換規則位於 TrafficLightController。
    /// </summary>
    public sealed partial class MainForm : Form
    {
        #region Fields

        private TrafficLightController controller;
        private FakeTrafficLightOutput fakeOutput;
        private Thread trafficLightWorkerThread;
        private volatile bool isClosing;

        #endregion

        #region Constructor and form lifecycle

        public MainForm()
        {
            InitializeComponent();
            InitializeOutputComboBox();

            btnApplyDurations.Click += btnApplyDurations_Click;
            btnStart.Click += btnStart_Click;
            btnPause.Click += btnPause_Click;
            btnReset.Click += btnReset_Click;
            cbOutput.SelectedIndexChanged += cbOutput_SelectedIndexChanged;

            CreateControllerWithSelectedOutput();
            StartTrafficLightWorker();
            SetRunButtons(isRunning: false);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            isClosing = true;
            base.OnFormClosing(e);
        }

        #endregion

        #region Composition root

        /// <summary>
        /// 這裡是本範例的 Composition Root：選擇實作並注入 Controller。
        /// </summary>
        private void CreateControllerWithSelectedOutput()
        {
            ClearVisibleOutputs();
            fakeOutput = null;

            ITrafficLightOutput output;
            switch (cbOutput.SelectedIndex)
            {
                case 1:
                    output = new TextTrafficLightOutput(lbOutputStatus);
                    lbExplanation.Text = "TextTrafficLightOutput：使用 Label 顯示，同一個 Controller 不需要修改。";
                    break;

                case 2:
                    fakeOutput = new FakeTrafficLightOutput();
                    output = fakeOutput;
                    lbExplanation.Text = "FakeTrafficLightOutput：不操作 UI 或硬體，只記錄收到的狀態，可供測試使用。";
                    break;

                default:
                    output = new PanelTrafficLightOutput(plGreenLight, plYellowLight, plRedLight);
                    lbExplanation.Text = "PanelTrafficLightOutput：使用三個 WinForms Panel 顯示燈號。";
                    break;
            }

            // Constructor Injection：Controller 需要輸出能力，但不負責建立輸出物件。
            controller = new TrafficLightController(output);
            ApplyDurations(showValidationMessage: false);
            UpdateStatusLabels();
        }

        #endregion

        #region Traffic-light state machine

        private void StartTrafficLightWorker()
        {
            trafficLightWorkerThread = new Thread(RunTrafficLightStateMachine);
            trafficLightWorkerThread.IsBackground = true;
            trafficLightWorkerThread.Start();
        }

        private void RunTrafficLightStateMachine()
        {
            while (!isClosing)
            {
                Thread.Sleep(20);
                UpdateTrafficLight();
            }
        }

        private void UpdateTrafficLight()
        {
            if (InvokeRequired)
            {
                if (IsDisposed || !IsHandleCreated)
                {
                    return;
                }

                BeginInvoke(new Action(UpdateTrafficLight));
                return;
            }

            controller.Update();

            if (fakeOutput != null)
            {
                string history = string.Join(" -> ", fakeOutput.History);
                lbOutputStatus.Text = $"FAKE HISTORY : {history}";
                lbOutputStatus.ForeColor = Color.DarkSlateBlue;
            }

            UpdateStatusLabels();
        }

        #endregion

        #region UI events

        private void btnApplyDurations_Click(object sender, EventArgs e)
        {
            ApplyDurations(showValidationMessage: true);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            controller.Start();
            SetRunButtons(isRunning: true);
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            controller.Pause();
            SetRunButtons(isRunning: false);
        }

        private void btnReset_Click(object sender, EventArgs e)
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

        private void cbOutput_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbOutput.SelectedIndex >= 0)
            {
                CreateControllerWithSelectedOutput();
                SetRunButtons(isRunning: false);
            }
        }

        #endregion

        #region UI helpers

        private void InitializeOutputComboBox()
        {
            cbOutput.Items.Add("PanelTrafficLightOutput");
            cbOutput.Items.Add("TextTrafficLightOutput");
            cbOutput.Items.Add("FakeTrafficLightOutput");
            cbOutput.SelectedIndex = 0;
        }

        private bool ApplyDurations(bool showValidationMessage)
        {
            if (!TryReadPositiveSeconds(tbGreenDuration, "綠燈", out int greenSeconds) ||
                !TryReadPositiveSeconds(tbYellowDuration, "黃燈", out int yellowSeconds) ||
                !TryReadPositiveSeconds(tbRedDuration, "紅燈", out int redSeconds))
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
            lbElapsedTime.Text = $"Timer : {controller.ElapsedSeconds}";
            lbMainState.Text = $"MainState : {controller.MainState}";
            lbLightState.Text = $"LightState : {controller.CurrentState}";
        }

        private void SetRunButtons(bool isRunning)
        {
            btnStart.Enabled = !isRunning;
            btnPause.Enabled = isRunning;
            cbOutput.Enabled = !isRunning;
            btnApplyDurations.Enabled = !isRunning;
            tbGreenDuration.Enabled = !isRunning;
            tbYellowDuration.Enabled = !isRunning;
            tbRedDuration.Enabled = !isRunning;
        }

        private void ClearVisibleOutputs()
        {
            plGreenLight.BackColor = Color.Black;
            plYellowLight.BackColor = Color.Black;
            plRedLight.BackColor = Color.Black;
            lbOutputStatus.Text = string.Empty;
            lbOutputStatus.ForeColor = Color.Black;
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

        #endregion
    }
}
