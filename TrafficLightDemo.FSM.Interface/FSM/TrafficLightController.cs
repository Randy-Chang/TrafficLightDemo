using System;

namespace TrafficLightDemo.FSM.Interface
{
    /// <summary>
    /// 純粹管理交通燈狀態與切換規則，不依賴 Form、Panel 或 Label。
    /// </summary>
    public sealed class TrafficLightController
    {
        private readonly ITrafficLightOutput output;
        private readonly StateTimer stateTimer;

        private int greenDurationSeconds = 5;
        private int yellowDurationSeconds = 2;
        private int redDurationSeconds = 5;

        public MainState MainState { get; private set; }
        public TrafficLightState CurrentState { get; private set; }
        public int ElapsedSeconds => stateTimer.ElapsedSeconds;

        public TrafficLightController(ITrafficLightOutput output)
        {
            this.output = output ?? throw new ArgumentNullException(nameof(output));
            stateTimer = new StateTimer();
            MainState = MainState.Idle;
            CurrentState = TrafficLightState.Green;
            output.Show(CurrentState);
        }

        public void SetDurations(int greenSeconds, int yellowSeconds, int redSeconds)
        {
            if (greenSeconds <= 0) throw new ArgumentOutOfRangeException(nameof(greenSeconds));
            if (yellowSeconds <= 0) throw new ArgumentOutOfRangeException(nameof(yellowSeconds));
            if (redSeconds <= 0) throw new ArgumentOutOfRangeException(nameof(redSeconds));

            greenDurationSeconds = greenSeconds;
            yellowDurationSeconds = yellowSeconds;
            redDurationSeconds = redSeconds;
            Reset();
        }

        public void Start()
        {
            MainState = MainState.Active;
            stateTimer.Resume();
        }

        public void Pause()
        {
            MainState = MainState.Pause;
            stateTimer.Stop();
        }

        public void Reset()
        {
            MainState = MainState.Idle;
            CurrentState = TrafficLightState.Green;
            stateTimer.Reset();
            output.Show(CurrentState);
        }

        /// <summary>
        /// 每次呼叫只處理目前狀態，不阻塞 UI Thread。
        /// </summary>
        public void Update()
        {
            switch (MainState)
            {
                case MainState.Idle:
                    break;

                case MainState.Active:
                    UpdateActiveState();
                    break;

                case MainState.Pause:
                    break;
            }
        }

        private void UpdateActiveState()
        {
            output.Show(CurrentState);

            switch (CurrentState)
            {
                case TrafficLightState.Green:
                    if (stateTimer.HasElapsed(greenDurationSeconds))
                    {
                        MoveTo(TrafficLightState.Yellow);
                    }
                    break;

                case TrafficLightState.Yellow:
                    if (stateTimer.HasElapsed(yellowDurationSeconds))
                    {
                        MoveTo(TrafficLightState.Red);
                    }
                    break;

                case TrafficLightState.Red:
                    if (stateTimer.HasElapsed(redDurationSeconds))
                    {
                        MoveTo(TrafficLightState.Green);
                    }
                    break;
            }
        }

        private void MoveTo(TrafficLightState nextState)
        {
            CurrentState = nextState;
            stateTimer.Restart();
        }
    }
}
