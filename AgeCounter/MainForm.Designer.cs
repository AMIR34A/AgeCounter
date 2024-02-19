namespace AgeCounter
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            BirthDateLabel = new Label();
            BirthDateTimePicker = new DateTimePicker();
            StartButton = new Button();
            TimeMaskedTextBox = new MaskedTextBox();
            TimeLabel = new Label();
            SaveCheckBox = new CheckBox();
            ResetButton = new Button();
            SuspendLayout();
            // 
            // BirthDateLabel
            // 
            BirthDateLabel.AutoSize = true;
            BirthDateLabel.Location = new Point(11, 17);
            BirthDateLabel.Name = "BirthDateLabel";
            BirthDateLabel.Size = new Size(79, 20);
            BirthDateLabel.TabIndex = 0;
            BirthDateLabel.Text = "BirthDate :";
            // 
            // BirthDateTimePicker
            // 
            BirthDateTimePicker.Location = new Point(96, 12);
            BirthDateTimePicker.Name = "BirthDateTimePicker";
            BirthDateTimePicker.Size = new Size(250, 27);
            BirthDateTimePicker.TabIndex = 2;
            // 
            // StartButton
            // 
            StartButton.Location = new Point(252, 80);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(94, 29);
            StartButton.TabIndex = 3;
            StartButton.Text = "Start";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += StartButton_Click;
            // 
            // TimeMaskedTextBox
            // 
            TimeMaskedTextBox.Location = new Point(96, 45);
            TimeMaskedTextBox.Mask = "00:00";
            TimeMaskedTextBox.Name = "TimeMaskedTextBox";
            TimeMaskedTextBox.Size = new Size(250, 27);
            TimeMaskedTextBox.TabIndex = 4;
            TimeMaskedTextBox.Text = "0000";
            TimeMaskedTextBox.ValidatingType = typeof(DateTime);
            // 
            // TimeLabel
            // 
            TimeLabel.AutoSize = true;
            TimeLabel.Location = new Point(12, 48);
            TimeLabel.Name = "TimeLabel";
            TimeLabel.Size = new Size(49, 20);
            TimeLabel.TabIndex = 0;
            TimeLabel.Text = "Time :";
            // 
            // SaveCheckBox
            // 
            SaveCheckBox.AutoSize = true;
            SaveCheckBox.Location = new Point(12, 83);
            SaveCheckBox.Name = "SaveCheckBox";
            SaveCheckBox.Size = new Size(129, 24);
            SaveCheckBox.TabIndex = 5;
            SaveCheckBox.Text = "Save BirthDate";
            SaveCheckBox.UseVisualStyleBackColor = true;
            // 
            // ResetButton
            // 
            ResetButton.Location = new Point(152, 80);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(94, 29);
            ResetButton.TabIndex = 3;
            ResetButton.Text = "Reset";
            ResetButton.UseVisualStyleBackColor = true;
            ResetButton.Click += StartButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 115);
            Controls.Add(SaveCheckBox);
            Controls.Add(TimeMaskedTextBox);
            Controls.Add(ResetButton);
            Controls.Add(StartButton);
            Controls.Add(BirthDateTimePicker);
            Controls.Add(TimeLabel);
            Controls.Add(BirthDateLabel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label BirthDateLabel;
        private DateTimePicker BirthDateTimePicker;
        private Button StartButton;
        private MaskedTextBox TimeMaskedTextBox;
        private Label TimeLabel;
        private CheckBox SaveCheckBox;
        private Button ResetButton;
    }
}
