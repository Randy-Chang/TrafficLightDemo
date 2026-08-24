using System.Diagnostics;

namespace TrafficLightDemo.FSM.Interface
{
    public sealed class StateTimer
    {
        private readonly Stopwatch stopwatch = new Stopwatch();

        public int ElapsedSeconds => (int)stopwatch.Elapsed.TotalSeconds;

        public void Reset() => stopwatch.Reset();
        public void Resume() => stopwatch.Start();
        public void Stop() => stopwatch.Stop();
        public void Restart() => stopwatch.Restart();

        public bool HasElapsed(int seconds)
        {
            return stopwatch.Elapsed.TotalSeconds >= seconds;
        }
    }
}
