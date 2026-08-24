# 新人動手練習

這個專案中的 Panel、Text、Fake Output 是完成版參考；`ListBoxTrafficLightOutput` 刻意只留下可編譯的骨架。

## 第一關：先追蹤，不改架構

1. 在 `MainForm.StartButton_Click` 設中斷點。
2. 依序追蹤 `TrafficLightController.Start`、`Update`、`MoveNext`。
3. 用自己的話說明：按下 Start 後，誰改變主狀態、誰計時、誰切換燈號？
4. 將 Green 預設秒數從 5 改成 3，執行並驗證結果。

## 第二關：完成新的 Interface 實作

目標：完成 `ListBoxTrafficLightOutput`，在畫面上保留每一次燈號切換紀錄，並讓使用者可以從下拉選單選到它。

1. 使用 WinForms Designer 在畫面加入一個 `ListBox`，命名為 `historyListBox`。
2. 完成 `ListBoxTrafficLightOutput.Show` 的 TODO，將目前時間及狀態加入 ListBox。
3. 在 Designer 的 Output 下拉選單加入 `ListBoxTrafficLightOutput`。
4. 在 `MainForm.CreateControllerWithSelectedOutput` 建立物件，將 `historyListBox` 傳入建構式，再注入 Controller。
5. 啟動 FSM，確認畫面依序保留 Green、Yellow、Red 紀錄。

限制：不得修改 `TrafficLightController`。

驗收時請回答：

- 新實作遵守哪個 Interface？
- 是誰建立 `ListBoxTrafficLightOutput`？
- `historyListBox` 是透過什麼方式交給它的？
- 是誰把它傳給 `TrafficLightController`？
- 為什麼新增輸出方式時，FSM 不需要修改？

## 第三關：修改狀態機

完成第二關後，再新增 Emergency Stop：

1. 新增 Emergency 主狀態。
2. 在 Controller 新增緊急停止方法。
3. 在 Designer 加入 Emergency Stop 按鈕。
4. 緊急停止時固定顯示紅燈，Reset 後才能重新 Start。

這一關用來區分「新增輸出實作」和「修改 FSM 規則」影響的檔案為何不同。
