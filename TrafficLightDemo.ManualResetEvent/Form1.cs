
using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;


namespace TrafficLightDemo.ManualResetEvent
{
    public enum ETrafficLightState {  Green, Yellow, Red, }

    public partial class Mainform : Form
    {
        #region 參數宣告 Fields
        Thread thread;
        System.Threading.ManualResetEvent mre;
        public delegate void SetTextCallback(Control cntr, string text);
        public delegate void SetColorCallback(Control cntr, Color c);

        ETrafficLightState state;
        Timer timer;
        bool isFirstStart = false;
        int greenTime = 5;
        int yellowTime = 2;
        int redTime = 5;
        #endregion

        public Mainform()
        {
            InitializeComponent();

            InitializeTrafficLight();

            btnSet.Click += btnSet_Click;
            btnStart.Click += btnStart_Click;
            btnPause.Click += btnPause_Click;
            ButtonEnabled(true, false);
        }

        private void InitializeTrafficLight()
        {
            state = ETrafficLightState.Green;
            timer = new Timer();

            thread = new Thread(RunTrafficLight); // 建立執行緒
            thread.IsBackground = true; // 設定為背景執行緒，程式結束時會自動結束
            mre = new System.Threading.ManualResetEvent(false); // 初始為暫停狀態
            thread.Start(); // 啟動執行緒
        }

        #region UI Event
        private void btnSet_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tbGreenLightDuration.Text, out greenTime))
            {
                MessageBox.Show("請輸入正確的綠燈時間(秒)!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(tbYellowLightDuration.Text, out yellowTime))
            {
                MessageBox.Show("請輸入正確的黃燈時間(秒)!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(tbRedLightDuration.Text, out redTime))
            {
                MessageBox.Show("請輸入正確的紅燈時間(秒)!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            mre.Set();
            timer.Start();
            ButtonEnabled(false, true);
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            mre.Reset();
            timer.Stop();
            ButtonEnabled(true, false);
        }
        #endregion

        #region Helper
        private void ButtonEnabled(bool start, bool pause)
        {
            btnStart.Enabled = start;
            btnPause.Enabled = pause;
        }
        #endregion

        #region UI Helper - Delegate
        public void SetText(Control cntr, string text)
        {
            if (cntr.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                cntr.Invoke(d, new object[] { cntr, text });
            }
            else
            {
                cntr.Text = text;
            }
        }

        public void SetColor(Control cntr, Color c)
        {
            if (cntr.InvokeRequired)
            {
                SetColorCallback d = new SetColorCallback(SetColor);
                cntr.Invoke(d, new object[] { cntr, c });
            }
            else
            {
                cntr.BackColor = c;
            }
        }
        #endregion  

        #region TrafficLight State Machine

        void RunTrafficLight()
        {
            while (true)
            {
                Thread.Sleep(10); // ms, 避免 CPU 過度使用
                mre.WaitOne();
                SetText(lbTimer, $"Timer : {timer.ElapsedSeconds}");

                switch (state)
                {
                    case ETrafficLightState.Green:
                        {
                            SetColor(plGreenLight, Color.Green);
                            SetColor(plYellowLight, Color.Black);
                            SetColor(plRedLight, Color.Black);

                            if (timer.IsTimeUp(greenTime))
                            {
                                state = ETrafficLightState.Yellow;
                                timer.Start();
                            }
                        }
                        break;

                    case ETrafficLightState.Yellow:
                        {
                            SetColor(plGreenLight, Color.Black);
                            SetColor(plYellowLight, Color.Yellow);
                            SetColor(plRedLight, Color.Black);

                            if (timer.IsTimeUp(yellowTime))
                            {
                                state = ETrafficLightState.Red;
                                timer.Start();
                            }
                        }
                        break;

                    case ETrafficLightState.Red:
                        {
                            SetColor(plGreenLight, Color.Black);
                            SetColor(plYellowLight, Color.Black);
                            SetColor(plRedLight, Color.Red);
                            if (timer.IsTimeUp(redTime))
                            {
                                state = ETrafficLightState.Green;
                                timer.Start();
                            }
                        }
                        break;
                }
            }
        }
        #endregion
    }

    public class Timer
    {
        Stopwatch stopwatch;

        public Timer()
        {
            stopwatch = new Stopwatch();
        }
        
        public void Start()
        {
            stopwatch.Restart();
        }

        public void Stop()
        {
            stopwatch.Stop();
        }

        /// <summary>
        /// 判斷是否已經超過指定的秒數
        /// </summary>
        /// <param name="seconds"></param>
        /// <returns></returns>
        public bool IsTimeUp(int seconds)
        {
            return stopwatch.Elapsed.TotalSeconds >= seconds;
        }

        public int ElapsedSeconds
        {
            get { return (int)stopwatch.Elapsed.TotalSeconds; }
        }
    }
}
