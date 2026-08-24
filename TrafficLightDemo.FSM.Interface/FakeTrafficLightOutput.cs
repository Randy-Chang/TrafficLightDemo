using System.Collections.Generic;

namespace TrafficLightDemo.FSM.Interface
{
    /// <summary>
    /// 不操作 UI 或硬體，只記錄狀態。可用於模擬與測試。
    /// </summary>
    public sealed class FakeTrafficLightOutput : ITrafficLightOutput
    {
        public List<TrafficLightState> History { get; } = new List<TrafficLightState>();

        public void Show(TrafficLightState state)
        {
            if (History.Count == 0 || History[History.Count - 1] != state)
            {
                History.Add(state);
            }
        }
    }
}
