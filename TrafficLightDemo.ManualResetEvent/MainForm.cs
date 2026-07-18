using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace TrafficLightDemo.ManualResetEvent
{
    public enum TrafficLightState
    {
        Green,
        Yellow,
        Red
    }

    public partial class MainForm : Form
    {
        #region Fields

        private Thread trafficLightWorkerThread;
        private System.Threading.ManualResetEvent mre;
        private StateTimer stateTimer;

        private TrafficLightState currentState;
        private int greenDurationSeconds = 5;
        private int yellowDurationSeconds = 2;
        private int redDurationSeconds = 5;

        #endregion

        public MainForm()
        {
            InitializeComponent();
            InitializeTrafficLight();

            btnApplyDurations.Click += btnApplyDurations_Click;
            btnStart.Click += btnStart_Click;
            btnPause.Click += btnPause_Click;

            SetRunButtons(isRunning: false);
        }

        private void InitializeTrafficLight()
        {
            currentState = TrafficLightState.Green;
            stateTimer = new StateTimer();
            mre = new System.Threading.ManualResetEvent(initialState: false);

            trafficLightWorkerThread = new Thread(RunTrafficLightStateMachine);
            trafficLightWorkerThread.IsBackground = true;
            trafficLightWorkerThread.Start();
        }

        #region UI events

        private void btnApplyDurations_Click(object sender, EventArgs e)
        {
            if (!TryReadPositiveSeconds(tbGreenDuration, "綠燈", out int newGreenDurationSeconds) ||
                !TryReadPositiveSeconds(tbYellowDuration, "黃燈", out int newYellowDurationSeconds) ||
                !TryReadPositiveSeconds(tbRedDuration, "紅燈", out int newRedDurationSeconds))
            {
                return;
            }

            greenDurationSeconds = newGreenDurationSeconds;
            yellowDurationSeconds = newYellowDurationSeconds;
            redDurationSeconds = newRedDurationSeconds;
            stateTimer.Reset();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            stateTimer.Resume();
            mre.Set();
            SetRunButtons(isRunning: true);
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            mre.Reset();
            stateTimer.Stop();
            SetRunButtons(isRunning: false);
        }

        #endregion

        #region Traffic-light state machine

        private void RunTrafficLightStateMachine()
        {
            while (true)
            {
                Thread.Sleep(10); // 避免 CPU 過度使用。
                mre.WaitOne();
                SetControlText(lbElapsedTime, $"Timer : {stateTimer.ElapsedSeconds}");


                switch (currentState)
                {
                        case TrafficLightState.Green:
                            SetControlBackColor(plGreenLight, Color.Green);
                            SetControlBackColor(plYellowLight, Color.Black);
                            SetControlBackColor(plRedLight, Color.Black);

                            if (stateTimer.HasElapsed(greenDurationSeconds))
                            {
                                currentState = TrafficLightState.Yellow;
                                stateTimer.Restart();
                            }
                            break;

                        case TrafficLightState.Yellow:
                            SetControlBackColor(plGreenLight, Color.Black);
                            SetControlBackColor(plYellowLight, Color.Yellow);
                            SetControlBackColor(plRedLight, Color.Black);

                            if (stateTimer.HasElapsed(yellowDurationSeconds))
                            {
                                currentState = TrafficLightState.Red;
                                stateTimer.Restart();
                            }
                            break;

                        case TrafficLightState.Red:
                            SetControlBackColor(plGreenLight, Color.Black);
                            SetControlBackColor(plYellowLight, Color.Black);
                            SetControlBackColor(plRedLight, Color.Red);

                            if (stateTimer.HasElapsed(redDurationSeconds))
                            {
                                currentState = TrafficLightState.Green;
                                stateTimer.Restart();
                            }
                            break;
                }

                Thread.Sleep(10);
            }
        }

        #endregion

        #region UI helpers

        private bool TryReadPositiveSeconds(TextBox textBox, string lightName, out int seconds)
        {
            if (int.TryParse(textBox.Text, out seconds) && seconds > 0)
            {
                return true;
            }

            MessageBox.Show(
                $"請輸入大於 0 的{lightName}時間（秒）。",
                "輸入錯誤",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

            textBox.Focus();
            textBox.SelectAll();
            return false;
        }

        private void SetRunButtons(bool isRunning)
        {
            btnStart.Enabled = !isRunning;
            btnPause.Enabled = isRunning;
            gbDurationSettings.Enabled = !isRunning;
        }

        private static void SetControlText(Control control, string text)
        {
            if (control.InvokeRequired)
            {
                control.BeginInvoke(new Action<Control, string>(SetControlText), control, text);
            }
            else
            {
                control.Text = text;
            }
        }

        private static void SetControlBackColor(Control control, Color color)
        {
            if (control.InvokeRequired)
            {
                control.BeginInvoke(new Action<Control, Color>(SetControlBackColor), control, color);
            }
            else
            {
                control.BackColor = color;
            }
            
        }

        #endregion
    }

    public sealed class StateTimer
    {
        private readonly Stopwatch stopwatch = new Stopwatch();

        public void Reset()
        {
            stopwatch.Reset();
        }

        public void Resume()
        {
            stopwatch.Start();
        }

        public void Stop()
        {
            stopwatch.Stop();
        }

        public void Restart()

        {
            stopwatch.Restart();
        }

        public bool HasElapsed(int seconds)
        {
            return stopwatch.Elapsed.TotalSeconds >= seconds;
        }

        public int ElapsedSeconds
        {
            get
            {
                return (int)stopwatch.Elapsed.TotalSeconds;
            }
        }
    }
}
