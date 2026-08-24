namespace TrafficLightDemo.FSM.Interface
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.trafficLightGroupBox = new System.Windows.Forms.GroupBox();
            this.outputStatusLabel = new System.Windows.Forms.Label();
            this.currentStateTitleLabel = new System.Windows.Forms.Label();
            this.redPanel = new System.Windows.Forms.Panel();
            this.yellowPanel = new System.Windows.Forms.Panel();
            this.greenPanel = new System.Windows.Forms.Panel();
            this.redLabel = new System.Windows.Forms.Label();
            this.yellowLabel = new System.Windows.Forms.Label();
            this.greenLabel = new System.Windows.Forms.Label();
            this.controlGroupBox = new System.Windows.Forms.GroupBox();
            this.lightStateLabel = new System.Windows.Forms.Label();
            this.mainStateLabel = new System.Windows.Forms.Label();
            this.elapsedTimeLabel = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.operationTitleLabel = new System.Windows.Forms.Label();
            this.applyButton = new System.Windows.Forms.Button();
            this.redDurationTextBox = new System.Windows.Forms.TextBox();
            this.yellowDurationTextBox = new System.Windows.Forms.TextBox();
            this.greenDurationTextBox = new System.Windows.Forms.TextBox();
            this.redDurationLabel = new System.Windows.Forms.Label();
            this.yellowDurationLabel = new System.Windows.Forms.Label();
            this.greenDurationLabel = new System.Windows.Forms.Label();
            this.durationTitleLabel = new System.Windows.Forms.Label();
            this.explanationLabel = new System.Windows.Forms.Label();
            this.outputComboBox = new System.Windows.Forms.ComboBox();
            this.outputTitleLabel = new System.Windows.Forms.Label();
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.trafficLightGroupBox.SuspendLayout();
            this.controlGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // trafficLightGroupBox
            // 
            this.trafficLightGroupBox.Controls.Add(this.outputStatusLabel);
            this.trafficLightGroupBox.Controls.Add(this.currentStateTitleLabel);
            this.trafficLightGroupBox.Controls.Add(this.redPanel);
            this.trafficLightGroupBox.Controls.Add(this.yellowPanel);
            this.trafficLightGroupBox.Controls.Add(this.greenPanel);
            this.trafficLightGroupBox.Controls.Add(this.redLabel);
            this.trafficLightGroupBox.Controls.Add(this.yellowLabel);
            this.trafficLightGroupBox.Controls.Add(this.greenLabel);
            this.trafficLightGroupBox.Location = new System.Drawing.Point(18, 18);
            this.trafficLightGroupBox.Name = "trafficLightGroupBox";
            this.trafficLightGroupBox.Size = new System.Drawing.Size(330, 514);
            this.trafficLightGroupBox.TabIndex = 0;
            this.trafficLightGroupBox.TabStop = false;
            this.trafficLightGroupBox.Text = "Traffic Lights";
            // 
            // outputStatusLabel
            // 
            this.outputStatusLabel.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold);
            this.outputStatusLabel.ForeColor = System.Drawing.Color.Green;
            this.outputStatusLabel.Location = new System.Drawing.Point(23, 421);
            this.outputStatusLabel.Name = "outputStatusLabel";
            this.outputStatusLabel.Size = new System.Drawing.Size(283, 70);
            this.outputStatusLabel.TabIndex = 7;
            this.outputStatusLabel.Text = "GREEN";
            this.outputStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // currentStateTitleLabel
            // 
            this.currentStateTitleLabel.AutoSize = true;
            this.currentStateTitleLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 11F, System.Drawing.FontStyle.Bold);
            this.currentStateTitleLabel.Location = new System.Drawing.Point(19, 390);
            this.currentStateTitleLabel.Name = "currentStateTitleLabel";
            this.currentStateTitleLabel.Size = new System.Drawing.Size(80, 19);
            this.currentStateTitleLabel.TabIndex = 6;
            this.currentStateTitleLabel.Text = "目前狀態";
            // 
            // light panels
            // 
            this.greenPanel.BackColor = System.Drawing.Color.Green;
            this.greenPanel.Location = new System.Drawing.Point(139, 42);
            this.greenPanel.Name = "greenPanel";
            this.greenPanel.Size = new System.Drawing.Size(86, 86);
            this.greenPanel.TabIndex = 1;
            this.yellowPanel.BackColor = System.Drawing.Color.Black;
            this.yellowPanel.Location = new System.Drawing.Point(139, 151);
            this.yellowPanel.Name = "yellowPanel";
            this.yellowPanel.Size = new System.Drawing.Size(86, 86);
            this.yellowPanel.TabIndex = 3;
            this.redPanel.BackColor = System.Drawing.Color.Black;
            this.redPanel.Location = new System.Drawing.Point(139, 260);
            this.redPanel.Name = "redPanel";
            this.redPanel.Size = new System.Drawing.Size(86, 86);
            this.redPanel.TabIndex = 5;
            // 
            // light labels
            // 
            this.greenLabel.Location = new System.Drawing.Point(40, 42);
            this.greenLabel.Name = "greenLabel";
            this.greenLabel.Size = new System.Drawing.Size(85, 86);
            this.greenLabel.TabIndex = 0;
            this.greenLabel.Text = "Green";
            this.greenLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.yellowLabel.Location = new System.Drawing.Point(40, 151);
            this.yellowLabel.Name = "yellowLabel";
            this.yellowLabel.Size = new System.Drawing.Size(85, 86);
            this.yellowLabel.TabIndex = 2;
            this.yellowLabel.Text = "Yellow";
            this.yellowLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.redLabel.Location = new System.Drawing.Point(40, 260);
            this.redLabel.Name = "redLabel";
            this.redLabel.Size = new System.Drawing.Size(85, 86);
            this.redLabel.TabIndex = 4;
            this.redLabel.Text = "Red";
            this.redLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // controlGroupBox
            // 
            this.controlGroupBox.Controls.Add(this.lightStateLabel);
            this.controlGroupBox.Controls.Add(this.mainStateLabel);
            this.controlGroupBox.Controls.Add(this.elapsedTimeLabel);
            this.controlGroupBox.Controls.Add(this.resetButton);
            this.controlGroupBox.Controls.Add(this.pauseButton);
            this.controlGroupBox.Controls.Add(this.startButton);
            this.controlGroupBox.Controls.Add(this.operationTitleLabel);
            this.controlGroupBox.Controls.Add(this.applyButton);
            this.controlGroupBox.Controls.Add(this.redDurationTextBox);
            this.controlGroupBox.Controls.Add(this.yellowDurationTextBox);
            this.controlGroupBox.Controls.Add(this.greenDurationTextBox);
            this.controlGroupBox.Controls.Add(this.redDurationLabel);
            this.controlGroupBox.Controls.Add(this.yellowDurationLabel);
            this.controlGroupBox.Controls.Add(this.greenDurationLabel);
            this.controlGroupBox.Controls.Add(this.durationTitleLabel);
            this.controlGroupBox.Controls.Add(this.explanationLabel);
            this.controlGroupBox.Controls.Add(this.outputComboBox);
            this.controlGroupBox.Controls.Add(this.outputTitleLabel);
            this.controlGroupBox.Location = new System.Drawing.Point(366, 18);
            this.controlGroupBox.Name = "controlGroupBox";
            this.controlGroupBox.Size = new System.Drawing.Size(536, 514);
            this.controlGroupBox.TabIndex = 1;
            this.controlGroupBox.TabStop = false;
            this.controlGroupBox.Text = "Interface / Dependency Injection";
            // 
            // output section
            // 
            this.outputTitleLabel.AutoSize = true;
            this.outputTitleLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 11F, System.Drawing.FontStyle.Bold);
            this.outputTitleLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.outputTitleLabel.Location = new System.Drawing.Point(20, 36);
            this.outputTitleLabel.Name = "outputTitleLabel";
            this.outputTitleLabel.Size = new System.Drawing.Size(248, 19);
            this.outputTitleLabel.TabIndex = 0;
            this.outputTitleLabel.Text = "1. 選擇 ITrafficLightOutput 實作";
            this.outputComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.outputComboBox.FormattingEnabled = true;
            this.outputComboBox.Items.AddRange(new object[] {
            "PanelTrafficLightOutput",
            "TextTrafficLightOutput",
            "FakeTrafficLightOutput"});
            this.outputComboBox.Location = new System.Drawing.Point(24, 68);
            this.outputComboBox.Name = "outputComboBox";
            this.outputComboBox.SelectedIndex = 0;
            this.outputComboBox.Size = new System.Drawing.Size(250, 27);
            this.outputComboBox.TabIndex = 1;
            this.outputComboBox.SelectedIndexChanged += new System.EventHandler(this.OutputComboBox_SelectedIndexChanged);
            this.explanationLabel.ForeColor = System.Drawing.Color.DimGray;
            this.explanationLabel.Location = new System.Drawing.Point(20, 108);
            this.explanationLabel.Name = "explanationLabel";
            this.explanationLabel.Size = new System.Drawing.Size(490, 48);
            this.explanationLabel.TabIndex = 2;
            this.explanationLabel.Text = "PanelTrafficLightOutput：使用三個 WinForms Panel 顯示燈號。";
            // 
            // duration section
            // 
            this.durationTitleLabel.AutoSize = true;
            this.durationTitleLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 11F, System.Drawing.FontStyle.Bold);
            this.durationTitleLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.durationTitleLabel.Location = new System.Drawing.Point(20, 169);
            this.durationTitleLabel.Name = "durationTitleLabel";
            this.durationTitleLabel.Size = new System.Drawing.Size(182, 19);
            this.durationTitleLabel.TabIndex = 3;
            this.durationTitleLabel.Text = "2. 設定各狀態持續時間";
            this.greenDurationLabel.AutoSize = true;
            this.greenDurationLabel.Location = new System.Drawing.Point(24, 207);
            this.greenDurationLabel.Text = "Green (s)";
            this.yellowDurationLabel.AutoSize = true;
            this.yellowDurationLabel.Location = new System.Drawing.Point(24, 244);
            this.yellowDurationLabel.Text = "Yellow (s)";
            this.redDurationLabel.AutoSize = true;
            this.redDurationLabel.Location = new System.Drawing.Point(24, 281);
            this.redDurationLabel.Text = "Red (s)";
            this.greenDurationTextBox.Location = new System.Drawing.Point(153, 204);
            this.greenDurationTextBox.Name = "greenDurationTextBox";
            this.greenDurationTextBox.Size = new System.Drawing.Size(100, 27);
            this.greenDurationTextBox.TabIndex = 5;
            this.greenDurationTextBox.Text = "5";
            this.yellowDurationTextBox.Location = new System.Drawing.Point(153, 241);
            this.yellowDurationTextBox.Name = "yellowDurationTextBox";
            this.yellowDurationTextBox.Size = new System.Drawing.Size(100, 27);
            this.yellowDurationTextBox.TabIndex = 7;
            this.yellowDurationTextBox.Text = "2";
            this.redDurationTextBox.Location = new System.Drawing.Point(153, 278);
            this.redDurationTextBox.Name = "redDurationTextBox";
            this.redDurationTextBox.Size = new System.Drawing.Size(100, 27);
            this.redDurationTextBox.TabIndex = 9;
            this.redDurationTextBox.Text = "5";
            this.applyButton.Location = new System.Drawing.Point(286, 241);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(105, 36);
            this.applyButton.TabIndex = 10;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // operation section
            // 
            this.operationTitleLabel.AutoSize = true;
            this.operationTitleLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 11F, System.Drawing.FontStyle.Bold);
            this.operationTitleLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.operationTitleLabel.Location = new System.Drawing.Point(20, 329);
            this.operationTitleLabel.Name = "operationTitleLabel";
            this.operationTitleLabel.Size = new System.Drawing.Size(122, 19);
            this.operationTitleLabel.TabIndex = 11;
            this.operationTitleLabel.Text = "3. 操作狀態機";
            this.startButton.Location = new System.Drawing.Point(24, 363);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(105, 36);
            this.startButton.TabIndex = 12;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            this.pauseButton.Location = new System.Drawing.Point(135, 363);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(105, 36);
            this.pauseButton.TabIndex = 13;
            this.pauseButton.Text = "Pause";
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            this.resetButton.Location = new System.Drawing.Point(246, 363);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(105, 36);
            this.resetButton.TabIndex = 14;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // state labels
            // 
            this.elapsedTimeLabel.AutoSize = true;
            this.elapsedTimeLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold);
            this.elapsedTimeLabel.Location = new System.Drawing.Point(24, 419);
            this.elapsedTimeLabel.Text = "Timer : 0";
            this.mainStateLabel.AutoSize = true;
            this.mainStateLabel.Location = new System.Drawing.Point(24, 451);
            this.mainStateLabel.Text = "MainState : Idle";
            this.lightStateLabel.AutoSize = true;
            this.lightStateLabel.Location = new System.Drawing.Point(222, 451);
            this.lightStateLabel.Text = "LightState : Green";
            // 
            // updateTimer
            // 
            this.updateTimer.Interval = 20;
            this.updateTimer.Tick += new System.EventHandler(this.UpdateTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 550);
            this.Controls.Add(this.controlGroupBox);
            this.Controls.Add(this.trafficLightGroupBox);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 11F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrafficLightDemo.FSM.Interface - Responsibility Separation & DI";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.trafficLightGroupBox.ResumeLayout(false);
            this.trafficLightGroupBox.PerformLayout();
            this.controlGroupBox.ResumeLayout(false);
            this.controlGroupBox.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox trafficLightGroupBox;
        private System.Windows.Forms.Label outputStatusLabel;
        private System.Windows.Forms.Label currentStateTitleLabel;
        private System.Windows.Forms.Panel redPanel;
        private System.Windows.Forms.Panel yellowPanel;
        private System.Windows.Forms.Panel greenPanel;
        private System.Windows.Forms.Label redLabel;
        private System.Windows.Forms.Label yellowLabel;
        private System.Windows.Forms.Label greenLabel;
        private System.Windows.Forms.GroupBox controlGroupBox;
        private System.Windows.Forms.Label lightStateLabel;
        private System.Windows.Forms.Label mainStateLabel;
        private System.Windows.Forms.Label elapsedTimeLabel;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label operationTitleLabel;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.TextBox redDurationTextBox;
        private System.Windows.Forms.TextBox yellowDurationTextBox;
        private System.Windows.Forms.TextBox greenDurationTextBox;
        private System.Windows.Forms.Label redDurationLabel;
        private System.Windows.Forms.Label yellowDurationLabel;
        private System.Windows.Forms.Label greenDurationLabel;
        private System.Windows.Forms.Label durationTitleLabel;
        private System.Windows.Forms.Label explanationLabel;
        private System.Windows.Forms.ComboBox outputComboBox;
        private System.Windows.Forms.Label outputTitleLabel;
        private System.Windows.Forms.Timer updateTimer;
    }
}
