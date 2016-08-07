namespace casowe_zamykanie_systemu
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.hoursSlider = new System.Windows.Forms.TrackBar();
            this.hoursTextBox = new System.Windows.Forms.TextBox();
            this.minutesTextBox = new System.Windows.Forms.TextBox();
            this.minutesSlider = new System.Windows.Forms.TrackBar();
            this.secondsSlider = new System.Windows.Forms.TrackBar();
            this.secondsTextBox = new System.Windows.Forms.TextBox();
            this.finalTimeProgressBar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.hoursSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondsSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // hoursSlider
            // 
            this.hoursSlider.LargeChange = 1;
            this.hoursSlider.Location = new System.Drawing.Point(168, 95);
            this.hoursSlider.Maximum = 23;
            this.hoursSlider.Name = "hoursSlider";
            this.hoursSlider.Size = new System.Drawing.Size(349, 45);
            this.hoursSlider.TabIndex = 0;
            this.hoursSlider.Scroll += new System.EventHandler(this.hoursSlider_Scroll);
            // 
            // hoursTextBox
            // 
            this.hoursTextBox.Location = new System.Drawing.Point(524, 95);
            this.hoursTextBox.Name = "hoursTextBox";
            this.hoursTextBox.Size = new System.Drawing.Size(30, 20);
            this.hoursTextBox.TabIndex = 2;
            this.hoursTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.hoursTextBox_KeyUp);
            // 
            // minutesTextBox
            // 
            this.minutesTextBox.Location = new System.Drawing.Point(524, 135);
            this.minutesTextBox.Name = "minutesTextBox";
            this.minutesTextBox.Size = new System.Drawing.Size(30, 20);
            this.minutesTextBox.TabIndex = 3;
            this.minutesTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.minutesTextBox_KeyUp);
            // 
            // minutesSlider
            // 
            this.minutesSlider.LargeChange = 1;
            this.minutesSlider.Location = new System.Drawing.Point(168, 135);
            this.minutesSlider.Maximum = 59;
            this.minutesSlider.Name = "minutesSlider";
            this.minutesSlider.Size = new System.Drawing.Size(349, 45);
            this.minutesSlider.TabIndex = 4;
            this.minutesSlider.Scroll += new System.EventHandler(this.minutesSlider_Scroll);
            // 
            // secondsSlider
            // 
            this.secondsSlider.LargeChange = 1;
            this.secondsSlider.Location = new System.Drawing.Point(168, 173);
            this.secondsSlider.Maximum = 60;
            this.secondsSlider.Name = "secondsSlider";
            this.secondsSlider.Size = new System.Drawing.Size(349, 45);
            this.secondsSlider.TabIndex = 5;
            this.secondsSlider.Scroll += new System.EventHandler(this.secondsSlider_Scroll);
            // 
            // secondsTextBox
            // 
            this.secondsTextBox.Location = new System.Drawing.Point(524, 173);
            this.secondsTextBox.Name = "secondsTextBox";
            this.secondsTextBox.Size = new System.Drawing.Size(30, 20);
            this.secondsTextBox.TabIndex = 6;
            this.secondsTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.secondsTextBox_KeyUp);
            // 
            // finalTimeProgressBar
            // 
            this.finalTimeProgressBar.Location = new System.Drawing.Point(158, 240);
            this.finalTimeProgressBar.Maximum = 86400;
            this.finalTimeProgressBar.Name = "finalTimeProgressBar";
            this.finalTimeProgressBar.Size = new System.Drawing.Size(386, 23);
            this.finalTimeProgressBar.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Godziny";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Minuty";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Sekundy";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(158, 12);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(173, 61);
            this.startButton.TabIndex = 11;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(381, 12);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(173, 61);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "ANULUJ";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 307);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.finalTimeProgressBar);
            this.Controls.Add(this.secondsTextBox);
            this.Controls.Add(this.secondsSlider);
            this.Controls.Add(this.minutesSlider);
            this.Controls.Add(this.minutesTextBox);
            this.Controls.Add(this.hoursTextBox);
            this.Controls.Add(this.hoursSlider);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Czasowe zamykanie systemu";
            ((System.ComponentModel.ISupportInitialize)(this.hoursSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondsSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar hoursSlider;
        private System.Windows.Forms.TextBox hoursTextBox;
        private System.Windows.Forms.TextBox minutesTextBox;
        private System.Windows.Forms.TrackBar minutesSlider;
        private System.Windows.Forms.TrackBar secondsSlider;
        private System.Windows.Forms.TextBox secondsTextBox;
        private System.Windows.Forms.ProgressBar finalTimeProgressBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button cancelButton;
    }
}

