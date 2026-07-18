namespace TrafficLightDemo.FSM
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.plGreenLight = new System.Windows.Forms.Panel();
            this.plRedLight = new System.Windows.Forms.Panel();
            this.plYellowLight = new System.Windows.Forms.Panel();
            this.gbDurationSettings = new System.Windows.Forms.GroupBox();
            this.btnApplyDurations = new System.Windows.Forms.Button();
            this.tbRedDuration = new System.Windows.Forms.TextBox();
            this.tbYellowDuration = new System.Windows.Forms.TextBox();
            this.tbGreenDuration = new System.Windows.Forms.TextBox();
            this.lbRedDuration = new System.Windows.Forms.Label();
            this.lbYellowDuration = new System.Windows.Forms.Label();
            this.lbGreenDuration = new System.Windows.Forms.Label();
            this.gbTrafficLights = new System.Windows.Forms.GroupBox();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lbElapsedTime = new System.Windows.Forms.Label();
            this.gbDurationSettings.SuspendLayout();
            this.gbTrafficLights.SuspendLayout();
            this.SuspendLayout();
            // 
            // plGreenLight
            // 
            this.plGreenLight.BackColor = System.Drawing.Color.Black;
            this.plGreenLight.Location = new System.Drawing.Point(6, 37);
            this.plGreenLight.Name = "plGreenLight";
            this.plGreenLight.Size = new System.Drawing.Size(100, 100);
            this.plGreenLight.TabIndex = 0;
            // 
            // plRedLight
            // 
            this.plRedLight.BackColor = System.Drawing.Color.Black;
            this.plRedLight.Location = new System.Drawing.Point(218, 37);
            this.plRedLight.Name = "plRedLight";
            this.plRedLight.Size = new System.Drawing.Size(100, 100);
            this.plRedLight.TabIndex = 2;
            // 
            // plYellowLight
            // 
            this.plYellowLight.BackColor = System.Drawing.Color.Black;
            this.plYellowLight.Location = new System.Drawing.Point(112, 37);
            this.plYellowLight.Name = "plYellowLight";
            this.plYellowLight.Size = new System.Drawing.Size(100, 100);
            this.plYellowLight.TabIndex = 1;
            // 
            // gbDurationSettings
            // 
            this.gbDurationSettings.Controls.Add(this.btnApplyDurations);
            this.gbDurationSettings.Controls.Add(this.tbRedDuration);
            this.gbDurationSettings.Controls.Add(this.tbYellowDuration);
            this.gbDurationSettings.Controls.Add(this.tbGreenDuration);
            this.gbDurationSettings.Controls.Add(this.lbRedDuration);
            this.gbDurationSettings.Controls.Add(this.lbYellowDuration);
            this.gbDurationSettings.Controls.Add(this.lbGreenDuration);
            this.gbDurationSettings.Location = new System.Drawing.Point(346, 12);
            this.gbDurationSettings.Name = "gbDurationSettings";
            this.gbDurationSettings.Size = new System.Drawing.Size(328, 213);
            this.gbDurationSettings.TabIndex = 14;
            this.gbDurationSettings.TabStop = false;
            this.gbDurationSettings.Text = "Duration Settings (s)";
            // 
            // btnApplyDurations
            // 
            this.btnApplyDurations.Location = new System.Drawing.Point(197, 163);
            this.btnApplyDurations.Name = "btnApplyDurations";
            this.btnApplyDurations.Size = new System.Drawing.Size(121, 41);
            this.btnApplyDurations.TabIndex = 6;
            this.btnApplyDurations.Text = "Apply";
            this.btnApplyDurations.UseVisualStyleBackColor = true;
            // 
            // tbRedDuration
            // 
            this.tbRedDuration.Location = new System.Drawing.Point(158, 119);
            this.tbRedDuration.Name = "tbRedDuration";
            this.tbRedDuration.Size = new System.Drawing.Size(160, 38);
            this.tbRedDuration.TabIndex = 5;
            this.tbRedDuration.Text = "5";
            // 
            // tbYellowDuration
            // 
            this.tbYellowDuration.Location = new System.Drawing.Point(158, 75);
            this.tbYellowDuration.Name = "tbYellowDuration";
            this.tbYellowDuration.Size = new System.Drawing.Size(160, 38);
            this.tbYellowDuration.TabIndex = 4;
            this.tbYellowDuration.Text = "2";
            // 
            // tbGreenDuration
            // 
            this.tbGreenDuration.Location = new System.Drawing.Point(158, 31);
            this.tbGreenDuration.Name = "tbGreenDuration";
            this.tbGreenDuration.Size = new System.Drawing.Size(160, 38);
            this.tbGreenDuration.TabIndex = 3;
            this.tbGreenDuration.Text = "5";
            // 
            // lbRedDuration
            // 
            this.lbRedDuration.AutoSize = true;
            this.lbRedDuration.Location = new System.Drawing.Point(35, 122);
            this.lbRedDuration.Name = "lbRedDuration";
            this.lbRedDuration.Size = new System.Drawing.Size(117, 29);
            this.lbRedDuration.TabIndex = 2;
            this.lbRedDuration.Text = "Red Light";
            // 
            // lbYellowDuration
            // 
            this.lbYellowDuration.AutoSize = true;
            this.lbYellowDuration.Location = new System.Drawing.Point(6, 78);
            this.lbYellowDuration.Name = "lbYellowDuration";
            this.lbYellowDuration.Size = new System.Drawing.Size(146, 29);
            this.lbYellowDuration.TabIndex = 1;
            this.lbYellowDuration.Text = "Yellow Light";
            // 
            // lbGreenDuration
            // 
            this.lbGreenDuration.AutoSize = true;
            this.lbGreenDuration.Location = new System.Drawing.Point(6, 34);
            this.lbGreenDuration.Name = "lbGreenDuration";
            this.lbGreenDuration.Size = new System.Drawing.Size(140, 29);
            this.lbGreenDuration.TabIndex = 0;
            this.lbGreenDuration.Text = "Green Light";
            // 
            // gbTrafficLights
            // 
            this.gbTrafficLights.Controls.Add(this.plGreenLight);
            this.gbTrafficLights.Controls.Add(this.plRedLight);
            this.gbTrafficLights.Controls.Add(this.plYellowLight);
            this.gbTrafficLights.Location = new System.Drawing.Point(12, 12);
            this.gbTrafficLights.Name = "gbTrafficLights";
            this.gbTrafficLights.Size = new System.Drawing.Size(328, 153);
            this.gbTrafficLights.TabIndex = 13;
            this.gbTrafficLights.TabStop = false;
            this.gbTrafficLights.Text = "Traffic Lights";
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(248, 175);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(92, 41);
            this.btnPause.TabIndex = 17;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(150, 175);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(92, 41);
            this.btnStart.TabIndex = 16;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // lbElapsedTime
            // 
            this.lbElapsedTime.AutoSize = true;
            this.lbElapsedTime.Location = new System.Drawing.Point(13, 181);
            this.lbElapsedTime.Name = "lbElapsedTime";
            this.lbElapsedTime.Size = new System.Drawing.Size(112, 29);
            this.lbElapsedTime.TabIndex = 15;
            this.lbElapsedTime.Text = "Timer : --";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 253);
            this.Controls.Add(this.gbDurationSettings);
            this.Controls.Add(this.gbTrafficLights);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lbElapsedTime);
            this.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.gbDurationSettings.ResumeLayout(false);
            this.gbDurationSettings.PerformLayout();
            this.gbTrafficLights.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel plGreenLight;
        private System.Windows.Forms.Panel plRedLight;
        private System.Windows.Forms.Panel plYellowLight;
        private System.Windows.Forms.GroupBox gbDurationSettings;
        private System.Windows.Forms.Button btnApplyDurations;
        private System.Windows.Forms.TextBox tbRedDuration;
        private System.Windows.Forms.TextBox tbYellowDuration;
        private System.Windows.Forms.TextBox tbGreenDuration;
        private System.Windows.Forms.Label lbRedDuration;
        private System.Windows.Forms.Label lbYellowDuration;
        private System.Windows.Forms.Label lbGreenDuration;
        private System.Windows.Forms.GroupBox gbTrafficLights;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lbElapsedTime;
    }
}

