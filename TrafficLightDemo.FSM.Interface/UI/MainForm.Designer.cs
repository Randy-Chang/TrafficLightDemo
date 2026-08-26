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
            this.gbTrafficLights = new System.Windows.Forms.GroupBox();
            this.lbOutputStatus = new System.Windows.Forms.Label();
            this.lbCurrentStateTitle = new System.Windows.Forms.Label();
            this.plRedLight = new System.Windows.Forms.Panel();
            this.plYellowLight = new System.Windows.Forms.Panel();
            this.plGreenLight = new System.Windows.Forms.Panel();
            this.lbRedLight = new System.Windows.Forms.Label();
            this.lbYellowLight = new System.Windows.Forms.Label();
            this.lbGreenLight = new System.Windows.Forms.Label();
            this.gbControl = new System.Windows.Forms.GroupBox();
            this.lbLightState = new System.Windows.Forms.Label();
            this.lbMainState = new System.Windows.Forms.Label();
            this.lbElapsedTime = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lbOperationTitle = new System.Windows.Forms.Label();
            this.btnApplyDurations = new System.Windows.Forms.Button();
            this.tbRedDuration = new System.Windows.Forms.TextBox();
            this.tbYellowDuration = new System.Windows.Forms.TextBox();
            this.tbGreenDuration = new System.Windows.Forms.TextBox();
            this.lbRedDuration = new System.Windows.Forms.Label();
            this.lbYellowDuration = new System.Windows.Forms.Label();
            this.lbGreenDuration = new System.Windows.Forms.Label();
            this.lbDurationTitle = new System.Windows.Forms.Label();
            this.lbExplanation = new System.Windows.Forms.Label();
            this.cbOutput = new System.Windows.Forms.ComboBox();
            this.lbOutputTitle = new System.Windows.Forms.Label();
            this.gbTrafficLights.SuspendLayout();
            this.gbControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTrafficLights
            // 
            this.gbTrafficLights.Controls.Add(this.lbOutputStatus);
            this.gbTrafficLights.Controls.Add(this.lbCurrentStateTitle);
            this.gbTrafficLights.Controls.Add(this.plRedLight);
            this.gbTrafficLights.Controls.Add(this.plYellowLight);
            this.gbTrafficLights.Controls.Add(this.plGreenLight);
            this.gbTrafficLights.Controls.Add(this.lbRedLight);
            this.gbTrafficLights.Controls.Add(this.lbYellowLight);
            this.gbTrafficLights.Controls.Add(this.lbGreenLight);
            this.gbTrafficLights.Location = new System.Drawing.Point(18, 18);
            this.gbTrafficLights.Name = "gbTrafficLights";
            this.gbTrafficLights.Size = new System.Drawing.Size(330, 514);
            this.gbTrafficLights.TabIndex = 0;
            this.gbTrafficLights.TabStop = false;
            this.gbTrafficLights.Text = "Traffic Lights";
            // 
            // lbOutputStatus
            // 
            this.lbOutputStatus.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold);
            this.lbOutputStatus.ForeColor = System.Drawing.Color.Green;
            this.lbOutputStatus.Location = new System.Drawing.Point(23, 421);
            this.lbOutputStatus.Name = "lbOutputStatus";
            this.lbOutputStatus.Size = new System.Drawing.Size(283, 70);
            this.lbOutputStatus.TabIndex = 7;
            this.lbOutputStatus.Text = "GREEN";
            this.lbOutputStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbCurrentStateTitle
            // 
            this.lbCurrentStateTitle.AutoSize = true;
            this.lbCurrentStateTitle.Font = new System.Drawing.Font("Microsoft JhengHei", 11F, System.Drawing.FontStyle.Bold);
            this.lbCurrentStateTitle.Location = new System.Drawing.Point(19, 390);
            this.lbCurrentStateTitle.Name = "lbCurrentStateTitle";
            this.lbCurrentStateTitle.Size = new System.Drawing.Size(80, 19);
            this.lbCurrentStateTitle.TabIndex = 6;
            this.lbCurrentStateTitle.Text = "目前狀態";
            // 
            // light panels
            // 
            this.plGreenLight.BackColor = System.Drawing.Color.Green;
            this.plGreenLight.Location = new System.Drawing.Point(139, 42);
            this.plGreenLight.Name = "plGreenLight";
            this.plGreenLight.Size = new System.Drawing.Size(86, 86);
            this.plGreenLight.TabIndex = 1;
            this.plYellowLight.BackColor = System.Drawing.Color.Black;
            this.plYellowLight.Location = new System.Drawing.Point(139, 151);
            this.plYellowLight.Name = "plYellowLight";
            this.plYellowLight.Size = new System.Drawing.Size(86, 86);
            this.plYellowLight.TabIndex = 3;
            this.plRedLight.BackColor = System.Drawing.Color.Black;
            this.plRedLight.Location = new System.Drawing.Point(139, 260);
            this.plRedLight.Name = "plRedLight";
            this.plRedLight.Size = new System.Drawing.Size(86, 86);
            this.plRedLight.TabIndex = 5;
            // 
            // light labels
            // 
            this.lbGreenLight.Location = new System.Drawing.Point(40, 42);
            this.lbGreenLight.Name = "lbGreenLight";
            this.lbGreenLight.Size = new System.Drawing.Size(85, 86);
            this.lbGreenLight.TabIndex = 0;
            this.lbGreenLight.Text = "Green";
            this.lbGreenLight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbYellowLight.Location = new System.Drawing.Point(40, 151);
            this.lbYellowLight.Name = "lbYellowLight";
            this.lbYellowLight.Size = new System.Drawing.Size(85, 86);
            this.lbYellowLight.TabIndex = 2;
            this.lbYellowLight.Text = "Yellow";
            this.lbYellowLight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbRedLight.Location = new System.Drawing.Point(40, 260);
            this.lbRedLight.Name = "lbRedLight";
            this.lbRedLight.Size = new System.Drawing.Size(85, 86);
            this.lbRedLight.TabIndex = 4;
            this.lbRedLight.Text = "Red";
            this.lbRedLight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbControl
            // 
            this.gbControl.Controls.Add(this.lbLightState);
            this.gbControl.Controls.Add(this.lbMainState);
            this.gbControl.Controls.Add(this.lbElapsedTime);
            this.gbControl.Controls.Add(this.btnReset);
            this.gbControl.Controls.Add(this.btnPause);
            this.gbControl.Controls.Add(this.btnStart);
            this.gbControl.Controls.Add(this.lbOperationTitle);
            this.gbControl.Controls.Add(this.btnApplyDurations);
            this.gbControl.Controls.Add(this.tbRedDuration);
            this.gbControl.Controls.Add(this.tbYellowDuration);
            this.gbControl.Controls.Add(this.tbGreenDuration);
            this.gbControl.Controls.Add(this.lbRedDuration);
            this.gbControl.Controls.Add(this.lbYellowDuration);
            this.gbControl.Controls.Add(this.lbGreenDuration);
            this.gbControl.Controls.Add(this.lbDurationTitle);
            this.gbControl.Controls.Add(this.lbExplanation);
            this.gbControl.Controls.Add(this.cbOutput);
            this.gbControl.Controls.Add(this.lbOutputTitle);
            this.gbControl.Location = new System.Drawing.Point(366, 18);
            this.gbControl.Name = "gbControl";
            this.gbControl.Size = new System.Drawing.Size(536, 514);
            this.gbControl.TabIndex = 1;
            this.gbControl.TabStop = false;
            this.gbControl.Text = "Interface / Dependency Injection";
            // 
            // output section
            // 
            this.lbOutputTitle.AutoSize = true;
            this.lbOutputTitle.Font = new System.Drawing.Font("Microsoft JhengHei", 11F, System.Drawing.FontStyle.Bold);
            this.lbOutputTitle.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbOutputTitle.Location = new System.Drawing.Point(20, 36);
            this.lbOutputTitle.Name = "lbOutputTitle";
            this.lbOutputTitle.Size = new System.Drawing.Size(248, 19);
            this.lbOutputTitle.TabIndex = 0;
            this.lbOutputTitle.Text = "1. 選擇 ITrafficLightOutput 實作";
            this.cbOutput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOutput.FormattingEnabled = true;
            this.cbOutput.Location = new System.Drawing.Point(24, 68);
            this.cbOutput.Name = "cbOutput";
            this.cbOutput.Size = new System.Drawing.Size(250, 27);
            this.cbOutput.TabIndex = 1;
            this.lbExplanation.ForeColor = System.Drawing.Color.DimGray;
            this.lbExplanation.Location = new System.Drawing.Point(20, 108);
            this.lbExplanation.Name = "lbExplanation";
            this.lbExplanation.Size = new System.Drawing.Size(490, 48);
            this.lbExplanation.TabIndex = 2;
            this.lbExplanation.Text = "PanelTrafficLightOutput：使用三個 WinForms Panel 顯示燈號。";
            // 
            // duration section
            // 
            this.lbDurationTitle.AutoSize = true;
            this.lbDurationTitle.Font = new System.Drawing.Font("Microsoft JhengHei", 11F, System.Drawing.FontStyle.Bold);
            this.lbDurationTitle.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbDurationTitle.Location = new System.Drawing.Point(20, 169);
            this.lbDurationTitle.Name = "lbDurationTitle";
            this.lbDurationTitle.Size = new System.Drawing.Size(182, 19);
            this.lbDurationTitle.TabIndex = 3;
            this.lbDurationTitle.Text = "2. 設定各狀態持續時間";
            this.lbGreenDuration.AutoSize = true;
            this.lbGreenDuration.Location = new System.Drawing.Point(24, 207);
            this.lbGreenDuration.Name = "lbGreenDuration";
            this.lbGreenDuration.Size = new System.Drawing.Size(72, 19);
            this.lbGreenDuration.TabIndex = 4;
            this.lbGreenDuration.Text = "Green (s)";
            this.lbYellowDuration.AutoSize = true;
            this.lbYellowDuration.Location = new System.Drawing.Point(24, 244);
            this.lbYellowDuration.Name = "lbYellowDuration";
            this.lbYellowDuration.Size = new System.Drawing.Size(76, 19);
            this.lbYellowDuration.TabIndex = 6;
            this.lbYellowDuration.Text = "Yellow (s)";
            this.lbRedDuration.AutoSize = true;
            this.lbRedDuration.Location = new System.Drawing.Point(24, 281);
            this.lbRedDuration.Name = "lbRedDuration";
            this.lbRedDuration.Size = new System.Drawing.Size(57, 19);
            this.lbRedDuration.TabIndex = 8;
            this.lbRedDuration.Text = "Red (s)";
            this.tbGreenDuration.Location = new System.Drawing.Point(153, 204);
            this.tbGreenDuration.Name = "tbGreenDuration";
            this.tbGreenDuration.Size = new System.Drawing.Size(100, 27);
            this.tbGreenDuration.TabIndex = 5;
            this.tbGreenDuration.Text = "5";
            this.tbYellowDuration.Location = new System.Drawing.Point(153, 241);
            this.tbYellowDuration.Name = "tbYellowDuration";
            this.tbYellowDuration.Size = new System.Drawing.Size(100, 27);
            this.tbYellowDuration.TabIndex = 7;
            this.tbYellowDuration.Text = "2";
            this.tbRedDuration.Location = new System.Drawing.Point(153, 278);
            this.tbRedDuration.Name = "tbRedDuration";
            this.tbRedDuration.Size = new System.Drawing.Size(100, 27);
            this.tbRedDuration.TabIndex = 9;
            this.tbRedDuration.Text = "5";
            this.btnApplyDurations.Location = new System.Drawing.Point(286, 241);
            this.btnApplyDurations.Name = "btnApplyDurations";
            this.btnApplyDurations.Size = new System.Drawing.Size(105, 36);
            this.btnApplyDurations.TabIndex = 10;
            this.btnApplyDurations.Text = "Apply";
            this.btnApplyDurations.UseVisualStyleBackColor = true;
            // 
            // operation section
            // 
            this.lbOperationTitle.AutoSize = true;
            this.lbOperationTitle.Font = new System.Drawing.Font("Microsoft JhengHei", 11F, System.Drawing.FontStyle.Bold);
            this.lbOperationTitle.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbOperationTitle.Location = new System.Drawing.Point(20, 329);
            this.lbOperationTitle.Name = "lbOperationTitle";
            this.lbOperationTitle.Size = new System.Drawing.Size(122, 19);
            this.lbOperationTitle.TabIndex = 11;
            this.lbOperationTitle.Text = "3. 操作狀態機";
            this.btnStart.Location = new System.Drawing.Point(24, 363);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(105, 36);
            this.btnStart.TabIndex = 12;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnPause.Location = new System.Drawing.Point(135, 363);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(105, 36);
            this.btnPause.TabIndex = 13;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnReset.Location = new System.Drawing.Point(246, 363);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(105, 36);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // state labels
            // 
            this.lbElapsedTime.AutoSize = true;
            this.lbElapsedTime.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold);
            this.lbElapsedTime.Location = new System.Drawing.Point(24, 419);
            this.lbElapsedTime.Name = "lbElapsedTime";
            this.lbElapsedTime.Size = new System.Drawing.Size(76, 21);
            this.lbElapsedTime.TabIndex = 15;
            this.lbElapsedTime.Text = "Timer : 0";
            this.lbMainState.AutoSize = true;
            this.lbMainState.Location = new System.Drawing.Point(24, 451);
            this.lbMainState.Name = "lbMainState";
            this.lbMainState.Size = new System.Drawing.Size(121, 19);
            this.lbMainState.TabIndex = 16;
            this.lbMainState.Text = "MainState : Idle";
            this.lbLightState.AutoSize = true;
            this.lbLightState.Location = new System.Drawing.Point(222, 451);
            this.lbLightState.Name = "lbLightState";
            this.lbLightState.Size = new System.Drawing.Size(135, 19);
            this.lbLightState.TabIndex = 17;
            this.lbLightState.Text = "LightState : Green";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 550);
            this.Controls.Add(this.gbControl);
            this.Controls.Add(this.gbTrafficLights);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 11F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrafficLightDemo.FSM.Interface - Responsibility Separation & DI";
            this.gbTrafficLights.ResumeLayout(false);
            this.gbTrafficLights.PerformLayout();
            this.gbControl.ResumeLayout(false);
            this.gbControl.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox gbTrafficLights;
        private System.Windows.Forms.Label lbOutputStatus;
        private System.Windows.Forms.Label lbCurrentStateTitle;
        private System.Windows.Forms.Panel plRedLight;
        private System.Windows.Forms.Panel plYellowLight;
        private System.Windows.Forms.Panel plGreenLight;
        private System.Windows.Forms.Label lbRedLight;
        private System.Windows.Forms.Label lbYellowLight;
        private System.Windows.Forms.Label lbGreenLight;
        private System.Windows.Forms.GroupBox gbControl;
        private System.Windows.Forms.Label lbLightState;
        private System.Windows.Forms.Label lbMainState;
        private System.Windows.Forms.Label lbElapsedTime;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lbOperationTitle;
        private System.Windows.Forms.Button btnApplyDurations;
        private System.Windows.Forms.TextBox tbRedDuration;
        private System.Windows.Forms.TextBox tbYellowDuration;
        private System.Windows.Forms.TextBox tbGreenDuration;
        private System.Windows.Forms.Label lbRedDuration;
        private System.Windows.Forms.Label lbYellowDuration;
        private System.Windows.Forms.Label lbGreenDuration;
        private System.Windows.Forms.Label lbDurationTitle;
        private System.Windows.Forms.Label lbExplanation;
        private System.Windows.Forms.ComboBox cbOutput;
        private System.Windows.Forms.Label lbOutputTitle;
    }
}
