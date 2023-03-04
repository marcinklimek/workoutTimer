namespace WorkoutTimer
{
    partial class MainScreen
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
            this.roundDisplayLabelxx = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.timer = new System.Windows.Forms.TabPage();
            this.tabPageTimerConfig = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.timer.SuspendLayout();
            this.tabPageTimerConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // workLabel
            // 
            this.workLabel.AutoSize = true;
            this.workLabel.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.workLabel.ForeColor = System.Drawing.Color.Red;
            this.workLabel.Location = new System.Drawing.Point(16, 19);
            this.workLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.workLabel.Name = "workLabel";
            this.workLabel.Size = new System.Drawing.Size(190, 68);
            this.workLabel.TabIndex = 3;
            this.workLabel.Text = "CLIMB";
            // 
            // restLabel
            // 
            this.restLabel.AutoSize = true;
            this.restLabel.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.restLabel.ForeColor = System.Drawing.Color.YellowGreen;
            this.restLabel.Location = new System.Drawing.Point(322, 28);
            this.restLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.restLabel.Name = "restLabel";
            this.restLabel.Size = new System.Drawing.Size(160, 68);
            this.restLabel.TabIndex = 4;
            this.restLabel.Text = "REST";
            // 
            // roundLabel
            // 
            this.roundLabel.AutoSize = true;
            this.roundLabel.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.roundLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.roundLabel.Location = new System.Drawing.Point(578, 19);
            this.roundLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.roundLabel.Name = "roundLabel";
            this.roundLabel.Size = new System.Drawing.Size(182, 68);
            this.roundLabel.TabIndex = 5;
            this.roundLabel.Text = "SERIA";
            // 
            // sixXsix
            // 
            this.sixXsix.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sixXsix.Location = new System.Drawing.Point(55, 938);
            this.sixXsix.Margin = new System.Windows.Forms.Padding(4);
            this.sixXsix.Name = "sixXsix";
            this.sixXsix.Size = new System.Drawing.Size(382, 158);
            this.sixXsix.TabIndex = 18;
            this.sixXsix.Text = "6x6x6";
            this.sixXsix.UseVisualStyleBackColor = true;
            // 
            // fiveXfive
            // 
            this.fiveXfive.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fiveXfive.Location = new System.Drawing.Point(65, 750);
            this.fiveXfive.Margin = new System.Windows.Forms.Padding(4);
            this.fiveXfive.Name = "fiveXfive";
            this.fiveXfive.Size = new System.Drawing.Size(382, 158);
            this.fiveXfive.TabIndex = 17;
            this.fiveXfive.Text = "5x5x5";
            this.fiveXfive.UseVisualStyleBackColor = true;
            // 
            // TimerLabel
            // 
            this.TimerLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TimerLabel.Font = new System.Drawing.Font("Tahoma", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TimerLabel.ForeColor = System.Drawing.Color.Black;
            this.TimerLabel.Location = new System.Drawing.Point(4, 17);
            this.TimerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(1899, 424);
            this.TimerLabel.TabIndex = 16;
            this.TimerLabel.Text = "00:00";
            this.TimerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Segoe UI Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.startButton.Location = new System.Drawing.Point(37, 614);
            this.startButton.Margin = new System.Windows.Forms.Padding(4);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(787, 113);
            this.startButton.TabIndex = 15;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pauseButton.Location = new System.Drawing.Point(81, 493);
            this.pauseButton.Margin = new System.Windows.Forms.Padding(4);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(382, 113);
            this.pauseButton.TabIndex = 14;
            this.pauseButton.Text = "Pause";
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resetButton.Location = new System.Drawing.Point(28, 359);
            this.resetButton.Margin = new System.Windows.Forms.Padding(4);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(382, 113);
            this.resetButton.TabIndex = 13;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // workBox
            // 
            this.workBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.workBox.FormattingEnabled = true;
            this.workBox.Location = new System.Drawing.Point(37, 91);
            this.workBox.Margin = new System.Windows.Forms.Padding(4);
            this.workBox.Name = "workBox";
            this.workBox.Size = new System.Drawing.Size(218, 53);
            this.workBox.TabIndex = 20;
            // 
            // restBox
            // 
            this.restBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.restBox.FormattingEnabled = true;
            this.restBox.Location = new System.Drawing.Point(299, 100);
            this.restBox.Margin = new System.Windows.Forms.Padding(4);
            this.restBox.Name = "restBox";
            this.restBox.Size = new System.Drawing.Size(218, 53);
            this.restBox.TabIndex = 21;
            // 
            // roundBox
            // 
            this.roundBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.roundBox.FormattingEnabled = true;
            this.roundBox.Location = new System.Drawing.Point(578, 91);
            this.roundBox.Margin = new System.Windows.Forms.Padding(4);
            this.roundBox.Name = "roundBox";
            this.roundBox.Size = new System.Drawing.Size(218, 53);
            this.roundBox.TabIndex = 22;
            // 
            // roundDisplayLabelxx
            // 
            this.roundDisplayLabelxx.BackColor = System.Drawing.SystemColors.ControlLight;
            this.roundDisplayLabelxx.Font = new System.Drawing.Font("Tahoma", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.roundDisplayLabelxx.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.roundDisplayLabelxx.Location = new System.Drawing.Point(4, 592);
            this.roundDisplayLabelxx.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.roundDisplayLabelxx.Name = "roundDisplayLabelxx";
            this.roundDisplayLabelxx.Size = new System.Drawing.Size(1906, 271);
            this.roundDisplayLabelxx.TabIndex = 24;
            this.roundDisplayLabelxx.Text = "1 z 5";
            this.roundDisplayLabelxx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.timer);
            this.tabControl.Controls.Add(this.tabPageTimerConfig);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1918, 1143);
            this.tabControl.TabIndex = 25;
            // 
            // timer
            // 
            this.timer.Controls.Add(this.TimerLabel);
            this.timer.Controls.Add(this.roundDisplayLabelxx);
            this.timer.Location = new System.Drawing.Point(4, 39);
            this.timer.Name = "timer";
            this.timer.Padding = new System.Windows.Forms.Padding(3);
            this.timer.Size = new System.Drawing.Size(1910, 1100);
            this.timer.TabIndex = 0;
            this.timer.Text = "timer";
            this.timer.UseVisualStyleBackColor = true;
            // 
            // tabPageTimerConfig
            // 
            this.tabPageTimerConfig.Controls.Add(this.resetButton);
            this.tabPageTimerConfig.Controls.Add(this.pauseButton);
            this.tabPageTimerConfig.Controls.Add(this.roundBox);
            this.tabPageTimerConfig.Controls.Add(this.startButton);
            this.tabPageTimerConfig.Controls.Add(this.restBox);
            this.tabPageTimerConfig.Controls.Add(this.roundLabel);
            this.tabPageTimerConfig.Controls.Add(this.fiveXfive);
            this.tabPageTimerConfig.Controls.Add(this.workBox);
            this.tabPageTimerConfig.Controls.Add(this.sixXsix);
            this.tabPageTimerConfig.Controls.Add(this.restLabel);
            this.tabPageTimerConfig.Controls.Add(this.workLabel);
            this.tabPageTimerConfig.Location = new System.Drawing.Point(4, 39);
            this.tabPageTimerConfig.Name = "tabPageTimerConfig";
            this.tabPageTimerConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTimerConfig.Size = new System.Drawing.Size(1910, 1100);
            this.tabPageTimerConfig.TabIndex = 1;
            this.tabPageTimerConfig.Text = "config";
            this.tabPageTimerConfig.UseVisualStyleBackColor = true;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1960, 1190);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainScreen";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.tabControl.ResumeLayout(false);
            this.timer.ResumeLayout(false);
            this.tabPageTimerConfig.ResumeLayout(false);
            this.tabPageTimerConfig.PerformLayout();
            this.ResumeLayout(false);

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

        private Label roundDisplayLabelxx;
        private TabControl tabControl;
        private TabPage timer;
        private TabPage tabPageTimerConfig;
    }
}