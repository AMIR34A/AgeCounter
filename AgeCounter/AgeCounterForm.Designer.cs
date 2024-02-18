namespace AgeCounter
{
    partial class AgeCounterForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgeCounterForm));
            AgeCounterLabel = new Label();
            NotifyIcon = new NotifyIcon(components);
            ProgressBar = new ProgressBar();
            SuspendLayout();
            // 
            // AgeCounterLabel
            // 
            AgeCounterLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AgeCounterLabel.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AgeCounterLabel.Location = new Point(12, 9);
            AgeCounterLabel.Name = "AgeCounterLabel";
            AgeCounterLabel.Size = new Size(342, 65);
            AgeCounterLabel.TabIndex = 0;
            AgeCounterLabel.Text = "00:00:00";
            AgeCounterLabel.TextAlign = ContentAlignment.MiddleCenter;
            AgeCounterLabel.DoubleClick += AgeCounterLabel_DoubleClick;
            // 
            // NotifyIcon
            // 
            NotifyIcon.Text = "Age Counter";
            NotifyIcon.Visible = true;
            NotifyIcon.Click += NotifyIcon_Click;
            // 
            // ProgressBar
            // 
            ProgressBar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ProgressBar.Location = new Point(12, 84);
            ProgressBar.Maximum = 36500;
            ProgressBar.Name = "ProgressBar";
            ProgressBar.Size = new Size(342, 30);
            ProgressBar.TabIndex = 1;
            // 
            // AgeCounterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(366, 126);
            Controls.Add(ProgressBar);
            Controls.Add(AgeCounterLabel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AgeCounterForm";
            Text = "Age Counter";
            FormClosing += AgeCounterForm_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Label AgeCounterLabel;
        private NotifyIcon NotifyIcon;
        private ProgressBar ProgressBar;
    }
}