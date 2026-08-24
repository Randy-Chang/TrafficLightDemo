# TrafficLightDemo.FSM.Interface 教學指南

## 專案定位

- `TrafficLightDemo.FSM`：主要基礎版，理解 FSM、Thread、Idle／Active／Pause。
- `TrafficLightDemo.FSM.Interface`：在相同 FSM 上示範職責分離、Interface、實作抽換及手動依賴注入。
- `TrafficLightDemo.ManualResetEvent`：補充長時間簡易工具如何使用 ManualResetEvent 暫停執行緒。

建議教學順序：`FSM` → `FSM.Interface` → `ManualResetEvent`。

## 職責分離

| 類別 | 責任 |
|---|---|
| `MainForm.cs` | UI 事件、使用者輸入與物件組裝 |
| `MainForm.Designer.cs` | WinForms 控制項宣告與畫面配置 |
| `MainForm.resx` | WinForms Designer 使用的表單資源 |
| `TrafficLightController` | FSM、燈號切換與時間規則 |
| `ITrafficLightOutput` | 定義顯示燈號狀態的能力 |
| `PanelTrafficLightOutput` | 用 Panel 顯示 |
| `TextTrafficLightOutput` | 用 Label 顯示 |
| `FakeTrafficLightOutput` | 不操作 UI，只記錄狀態供測試 |
| `StateTimer` | 計算目前狀態經過時間 |

## 教學重點

```text
MainForm（Composition Root）
    ↓ 建立實作
ITrafficLightOutput output = new PanelTrafficLightOutput(...)
    ↓ Constructor Injection
TrafficLightController(output)
    ↓ 只呼叫 Interface
output.Show(CurrentState)
```

Controller 不知道輸出是 Panel、Label 或 Fake。切換 ComboBox 時只重新組裝物件，不修改狀態機。

## 建議提問

1. 為什麼 `TrafficLightController` 裡沒有 `Panel`？
2. 三個 Output 為什麼都能放進 `ITrafficLightOutput` 變數？
3. 實際使用哪一個實作，是在哪裡決定的？
4. 若改成實體 IO，哪些類別需要修改？
5. 為什麼不是每一個 Class 都需要 Interface？

## 新人作業

新增 `DebugTrafficLightOutput`，將狀態寫到 `Debug.WriteLine`，並加入下拉選單。限制：不得修改 `TrafficLightController`。

完成後請說明：

- 新增了哪一個實作？
- 哪裡選擇該實作？
- Controller 為什麼不需要修改？

## 與 LBT4500 的對照

| 交通燈範例 | LBT4500 |
|---|---|
| `MainForm` 的組裝區 | `Scope`／Composition Root |
| `TrafficLightController` | `MTask`／SubTask |
| `ITrafficLightOutput` | Hardware Interface／Task Pack |
| Panel Output | 真實設備實作 |
| Text Output | Demo／模擬實作 |
| Fake Output | 測試替身 |
