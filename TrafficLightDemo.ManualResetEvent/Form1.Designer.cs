namespace TrafficLightDemo.ManualResetEvent
{
    partial class Mainform
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
            this.plYellowLight = new System.Windows.Forms.Panel();
            this.plRedLight = new System.Windows.Forms.Panel();
            this.gbLightRegion = new System.Windows.Forms.GroupBox();
            this.gbSetttingDuration = new System.Windows.Forms.GroupBox();
            this.btnSet = new System.Windows.Forms.Button();
            this.tbRedLightDuration = new System.Windows.Forms.TextBox();
            this.tbYellowLightDuration = new System.Windows.Forms.TextBox();
            this.tbGreenLightDuration = new System.Windows.Forms.TextBox();
            this.lbRedLightDuration = new System.Windows.Forms.Label();
            this.lbYellowLightDuration = new System.Windows.Forms.Label();
            this.lbGreenLightDuration = new System.Windows.Forms.Label();
            this.lbTimer = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.gbLightRegion.SuspendLayout();
            this.gbSetttingDuration.SuspendLayout();
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
            // plYellowLight
            // 
            this.plYellowLight.BackColor = System.Drawing.Color.Black;
            this.plYellowLight.Location = new System.Drawing.Point(112, 37);
            this.plYellowLight.Name = "plYellowLight";
            this.plYellowLight.Size = new System.Drawing.Size(100, 100);
            this.plYellowLight.TabIndex = 1;
            // 
            // plRedLight
            // 
            this.plRedLight.BackColor = System.Drawing.Color.Black;
            this.plRedLight.Location = new System.Drawing.Point(218, 37);
            this.plRedLight.Name = "plRedLight";
            this.plRedLight.Size = new System.Drawing.Size(100, 100);
            this.plRedLight.TabIndex = 2;
            // 
            // gbLightRegion
            // 
            this.gbLightRegion.Controls.Add(this.plGreenLight);
            this.gbLightRegion.Controls.Add(this.plRedLight);
            this.gbLightRegion.Controls.Add(this.plYellowLight);
            this.gbLightRegion.Location = new System.Drawing.Point(12, 12);
            this.gbLightRegion.Name = "gbLightRegion";
            this.gbLightRegion.Size = new System.Drawing.Size(328, 153);
            this.gbLightRegion.TabIndex = 3;
            this.gbLightRegion.TabStop = false;
            this.gbLightRegion.Text = "Light Region";
            // 
            // gbSetttingDuration
            // 
            this.gbSetttingDuration.Controls.Add(this.btnSet);
            this.gbSetttingDuration.Controls.Add(this.tbRedLightDuration);
            this.gbSetttingDuration.Controls.Add(this.tbYellowLightDuration);
            this.gbSetttingDuration.Controls.Add(this.tbGreenLightDuration);
            this.gbSetttingDuration.Controls.Add(this.lbRedLightDuration);
            this.gbSetttingDuration.Controls.Add(this.lbYellowLightDuration);
            this.gbSetttingDuration.Controls.Add(this.lbGreenLightDuration);
            this.gbSetttingDuration.Location = new System.Drawing.Point(346, 12);
            this.gbSetttingDuration.Name = "gbSetttingDuration";
            this.gbSetttingDuration.Size = new System.Drawing.Size(328, 213);
            this.gbSetttingDuration.TabIndex = 4;
            this.gbSetttingDuration.TabStop = false;
            this.gbSetttingDuration.Text = "Settting Duration (s)";
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(197, 163);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(121, 41);
            this.btnSet.TabIndex = 6;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            // 
            // tbRedLightDuration
            // 
            this.tbRedLightDuration.Location = new System.Drawing.Point(158, 119);
            this.tbRedLightDuration.Name = "tbRedLightDuration";
            this.tbRedLightDuration.Size = new System.Drawing.Size(160, 38);
            this.tbRedLightDuration.TabIndex = 5;
            this.tbRedLightDuration.Text = "5";
            // 
            // tbYellowLightDuration
            // 
            this.tbYellowLightDuration.Location = new System.Drawing.Point(158, 75);
            this.tbYellowLightDuration.Name = "tbYellowLightDuration";
            this.tbYellowLightDuration.Size = new System.Drawing.Size(160, 38);
            this.tbYellowLightDuration.TabIndex = 4;
            this.tbYellowLightDuration.Text = "2";
            // 
            // tbGreenLightDuration
            // 
            this.tbGreenLightDuration.Location = new System.Drawing.Point(158, 31);
            this.tbGreenLightDuration.Name = "tbGreenLightDuration";
            this.tbGreenLightDuration.Size = new System.Drawing.Size(160, 38);
            this.tbGreenLightDuration.TabIndex = 3;
            this.tbGreenLightDuration.Text = "5";
            // 
            // lbRedLightDuration
            // 
            this.lbRedLightDuration.AutoSize = true;
            this.lbRedLightDuration.Location = new System.Drawing.Point(35, 122);
            this.lbRedLightDuration.Name = "lbRedLightDuration";
            this.lbRedLightDuration.Size = new System.Drawing.Size(117, 29);
            this.lbRedLightDuration.TabIndex = 2;
            this.lbRedLightDuration.Text = "Red Light";
            // 
            // lbYellowLightDuration
            // 
            this.lbYellowLightDuration.AutoSize = true;
            this.lbYellowLightDuration.Location = new System.Drawing.Point(6, 78);
            this.lbYellowLightDuration.Name = "lbYellowLightDuration";
            this.lbYellowLightDuration.Size = new System.Drawing.Size(146, 29);
            this.lbYellowLightDuration.TabIndex = 1;
            this.lbYellowLightDuration.Text = "Yellow Light";
            // 
            // lbGreenLightDuration
            // 
            this.lbGreenLightDuration.AutoSize = true;
            this.lbGreenLightDuration.Location = new System.Drawing.Point(6, 34);
            this.lbGreenLightDuration.Name = "lbGreenLightDuration";
            this.lbGreenLightDuration.Size = new System.Drawing.Size(140, 29);
            this.lbGreenLightDuration.TabIndex = 0;
            this.lbGreenLightDuration.Text = "Green Light";
            // 
            // lbTimer
            // 
            this.lbTimer.AutoSize = true;
            this.lbTimer.Location = new System.Drawing.Point(13, 181);
            this.lbTimer.Name = "lbTimer";
            this.lbTimer.Size = new System.Drawing.Size(112, 29);
            this.lbTimer.TabIndex = 5;
            this.lbTimer.Text = "Timer : --";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(150, 175);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(92, 41);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(248, 175);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(92, 41);
            this.btnPause.TabIndex = 12;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 273);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lbTimer);
            this.Controls.Add(this.gbSetttingDuration);
            this.Controls.Add(this.gbLightRegion);
            this.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Mainform";
            this.Text = "Form1";
            this.gbLightRegion.ResumeLayout(false);
            this.gbSetttingDuration.ResumeLayout(false);
            this.gbSetttingDuration.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel plGreenLight;
        private System.Windows.Forms.Panel plYellowLight;
        private System.Windows.Forms.Panel plRedLight;
        private System.Windows.Forms.GroupBox gbLightRegion;
        private System.Windows.Forms.GroupBox gbSetttingDuration;
        private System.Windows.Forms.Label lbRedLightDuration;
        private System.Windows.Forms.Label lbYellowLightDuration;
        private System.Windows.Forms.Label lbGreenLightDuration;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.TextBox tbRedLightDuration;
        private System.Windows.Forms.TextBox tbYellowLightDuration;
        private System.Windows.Forms.TextBox tbGreenLightDuration;
        private System.Windows.Forms.Label lbTimer;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnPause;
    }
}

