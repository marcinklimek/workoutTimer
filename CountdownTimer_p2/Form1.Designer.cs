﻿namespace CountdownTimer_p2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.workLabel = new System.Windows.Forms.Label();
            this.restLabel = new System.Windows.Forms.Label();
            this.roundLabel = new System.Windows.Forms.Label();
            this.sixXsix = new System.Windows.Forms.Button();
            this.fiveXfive = new System.Windows.Forms.Button();
            this.TimerLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.workBox = new System.Windows.Forms.ComboBox();
            this.restBox = new System.Windows.Forms.ComboBox();
            this.roundBox = new System.Windows.Forms.ComboBox();
            this.workTimer = new System.Windows.Forms.Timer(this.components);
            this.restTimer = new System.Windows.Forms.Timer(this.components);
            this.roundDisplayLabelxx = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // workLabel
            // 
            this.workLabel.AutoSize = true;
            this.workLabel.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.workLabel.ForeColor = System.Drawing.Color.Red;
            this.workLabel.Location = new System.Drawing.Point(495, 35);
            this.workLabel.Name = "workLabel";
            this.workLabel.Size = new System.Drawing.Size(164, 58);
            this.workLabel.TabIndex = 3;
            this.workLabel.Text = "CLIMB";
            // 
            // restLabel
            // 
            this.restLabel.AutoSize = true;
            this.restLabel.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.restLabel.ForeColor = System.Drawing.Color.YellowGreen;
            this.restLabel.Location = new System.Drawing.Point(752, 35);
            this.restLabel.Name = "restLabel";
            this.restLabel.Size = new System.Drawing.Size(138, 58);
            this.restLabel.TabIndex = 4;
            this.restLabel.Text = "REST";
            // 
            // roundLabel
            // 
            this.roundLabel.AutoSize = true;
            this.roundLabel.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.roundLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.roundLabel.Location = new System.Drawing.Point(972, 35);
            this.roundLabel.Name = "roundLabel";
            this.roundLabel.Size = new System.Drawing.Size(159, 58);
            this.roundLabel.TabIndex = 5;
            this.roundLabel.Text = "SERIA";
            // 
            // sixXsix
            // 
            this.sixXsix.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sixXsix.Location = new System.Drawing.Point(824, 664);
            this.sixXsix.Name = "sixXsix";
            this.sixXsix.Size = new System.Drawing.Size(318, 132);
            this.sixXsix.TabIndex = 18;
            this.sixXsix.Text = "6x6x6";
            this.sixXsix.UseVisualStyleBackColor = true;
            // 
            // fiveXfive
            // 
            this.fiveXfive.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fiveXfive.Location = new System.Drawing.Point(486, 664);
            this.fiveXfive.Name = "fiveXfive";
            this.fiveXfive.Size = new System.Drawing.Size(318, 132);
            this.fiveXfive.TabIndex = 17;
            this.fiveXfive.Text = "5x5x5";
            this.fiveXfive.UseVisualStyleBackColor = true;
            // 
            // TimerLabel
            // 
            this.TimerLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TimerLabel.Font = new System.Drawing.Font("Tahoma", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TimerLabel.ForeColor = System.Drawing.Color.Black;
            this.TimerLabel.Location = new System.Drawing.Point(-10, 223);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(1658, 159);
            this.TimerLabel.TabIndex = 16;
            this.TimerLabel.Text = "00:00";
            this.TimerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Segoe UI Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.startButton.Location = new System.Drawing.Point(486, 553);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(656, 94);
            this.startButton.TabIndex = 15;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pauseButton.Location = new System.Drawing.Point(824, 444);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(318, 94);
            this.pauseButton.TabIndex = 14;
            this.pauseButton.Text = "Pause";
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resetButton.Location = new System.Drawing.Point(486, 444);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(318, 94);
            this.resetButton.TabIndex = 13;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            // 
            // workBox
            // 
            this.workBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.workBox.FormattingEnabled = true;
            this.workBox.Location = new System.Drawing.Point(486, 118);
            this.workBox.Name = "workBox";
            this.workBox.Size = new System.Drawing.Size(182, 46);
            this.workBox.TabIndex = 20;
            // 
            // restBox
            // 
            this.restBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.restBox.FormattingEnabled = true;
            this.restBox.Location = new System.Drawing.Point(727, 118);
            this.restBox.Name = "restBox";
            this.restBox.Size = new System.Drawing.Size(182, 46);
            this.restBox.TabIndex = 21;
            // 
            // roundBox
            // 
            this.roundBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.roundBox.FormattingEnabled = true;
            this.roundBox.Location = new System.Drawing.Point(960, 118);
            this.roundBox.Name = "roundBox";
            this.roundBox.Size = new System.Drawing.Size(182, 46);
            this.roundBox.TabIndex = 22;
            // 
            // workTimer
            // 
            this.workTimer.Tick += new System.EventHandler(this.workTimer_Tick);
            // 
            // restTimer
            // 
            this.restTimer.Tick += new System.EventHandler(this.restTimer_Tick);
            // 
            // roundDisplayLabelxx
            // 
            this.roundDisplayLabelxx.BackColor = System.Drawing.SystemColors.ControlLight;
            this.roundDisplayLabelxx.Font = new System.Drawing.Font("Tahoma", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.roundDisplayLabelxx.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.roundDisplayLabelxx.Location = new System.Drawing.Point(-10, 814);
            this.roundDisplayLabelxx.Name = "roundDisplayLabelxx";
            this.roundDisplayLabelxx.Size = new System.Drawing.Size(1658, 159);
            this.roundDisplayLabelxx.TabIndex = 24;
            this.roundDisplayLabelxx.Text = "1 z 5";
            this.roundDisplayLabelxx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.roundDisplayLabelxx.Click += new System.EventHandler(this.roundDisplayLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1633, 992);
            this.Controls.Add(this.roundDisplayLabelxx);
            this.Controls.Add(this.roundBox);
            this.Controls.Add(this.restBox);
            this.Controls.Add(this.workBox);
            this.Controls.Add(this.sixXsix);
            this.Controls.Add(this.fiveXfive);
            this.Controls.Add(this.TimerLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.roundLabel);
            this.Controls.Add(this.restLabel);
            this.Controls.Add(this.workLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label workLabel;
        private Label restLabel;
        private Label roundLabel;
        private Button sixXsix;
        private Button fiveXfive;
        private Label TimerLabel;
        private Button startButton;
        private Button pauseButton;
        private Button resetButton;
        private ComboBox workBox;
        private ComboBox restBox;
        private ComboBox roundBox;
        private System.Windows.Forms.Timer workTimer;
        private System.Windows.Forms.Timer restTimer;
        private Label roundDisplayLabelxx;
    }
}