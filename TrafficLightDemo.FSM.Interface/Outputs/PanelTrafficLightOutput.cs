using System.Drawing;
using System.Windows.Forms;

namespace TrafficLightDemo.FSM.Interface
{
    /// <summary>
    /// ITrafficLightOutput 的 WinForms Panel 實作。
    /// </summary>
    public sealed class PanelTrafficLightOutput : ITrafficLightOutput
    {
        private readonly Panel greenPanel;
        private readonly Panel yellowPanel;
        private readonly Panel redPanel;

        public PanelTrafficLightOutput(Panel greenPanel, Panel yellowPanel, Panel redPanel)
        {
            this.greenPanel = greenPanel;
            this.yellowPanel = yellowPanel;
            this.redPanel = redPanel;
        }

        public void Show(TrafficLightState state)
        {
            greenPanel.BackColor = state == TrafficLightState.Green ? Color.Green : Color.Black;
            yellowPanel.BackColor = state == TrafficLightState.Yellow ? Color.Gold : Color.Black;
            redPanel.BackColor = state == TrafficLightState.Red ? Color.Red : Color.Black;
        }
    }
}
