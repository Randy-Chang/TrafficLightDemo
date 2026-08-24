using System.Drawing;
using System.Windows.Forms;

namespace TrafficLightDemo.FSM.Interface
{
    /// <summary>
    /// 同一個 Interface 的文字實作。狀態機不需因顯示方式不同而修改。
    /// </summary>
    public sealed class TextTrafficLightOutput : ITrafficLightOutput
    {
        private readonly Label statusLabel;

        public TextTrafficLightOutput(Label statusLabel)
        {
            this.statusLabel = statusLabel;
        }

        public void Show(TrafficLightState state)
        {
            statusLabel.Text = $"TEXT OUTPUT : {state}";
            statusLabel.ForeColor = GetStateColor(state);
        }

        private static Color GetStateColor(TrafficLightState state)
        {
            switch (state)
            {
                case TrafficLightState.Green:
                    return Color.Green;
                case TrafficLightState.Yellow:
                    return Color.DarkGoldenrod;
                case TrafficLightState.Red:
                    return Color.Red;
                default:
                    return Color.Black;
            }
        }
    }
}
