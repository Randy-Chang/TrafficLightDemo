namespace TrafficLightDemo.FSM.Interface
{
    /// <summary>
    /// 定義「顯示交通燈狀態」的能力。
    /// Controller 只依賴這個能力，不知道實際使用 Panel、文字或測試替身。
    /// </summary>
    public interface ITrafficLightOutput
    {
        void Show(TrafficLightState state);
    }
}
