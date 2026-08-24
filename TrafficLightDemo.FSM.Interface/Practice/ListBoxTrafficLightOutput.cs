using System.Windows.Forms;

namespace TrafficLightDemo.FSM.Interface
{
    /// <summary>
    /// 新人練習用骨架。這個類別目前可以編譯，但尚未完成，也尚未接到畫面。
    /// 請依照 PRACTICE.md 完成，不要修改 TrafficLightController。
    /// </summary>
    public sealed class ListBoxTrafficLightOutput : ITrafficLightOutput
    {
        private readonly ListBox historyListBox;

        public ListBoxTrafficLightOutput(ListBox historyListBox)
        {
            this.historyListBox = historyListBox;
        }

        public void Show(TrafficLightState state)
        {
            // TODO 1：把目前時間與 state 加入 historyListBox。
            // 完成後，畫面應該依序留下 Green、Yellow、Red 的切換紀錄。
        }
    }
}
