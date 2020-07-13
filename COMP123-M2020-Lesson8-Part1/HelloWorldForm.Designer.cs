namespace COMP123_M2020_Lesson8_Part1
{
    partial class HelloWorldForm
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
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.ClickMeButton = new System.Windows.Forms.Button();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.BackColor = System.Drawing.SystemColors.Control;
            this.WelcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.WelcomeLabel.Location = new System.Drawing.Point(12, 190);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(607, 47);
            this.WelcomeLabel.TabIndex = 0;
            this.WelcomeLabel.Text = "Hello, World!";
            this.WelcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClickMeButton
            // 
            this.ClickMeButton.AutoSize = true;
            this.ClickMeButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClickMeButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.ClickMeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClickMeButton.Location = new System.Drawing.Point(252, 251);
            this.ClickMeButton.Name = "ClickMeButton";
            this.ClickMeButton.Size = new System.Drawing.Size(136, 47);
            this.ClickMeButton.TabIndex = 2;
            this.ClickMeButton.Text = "Click Me!";
            this.ClickMeButton.UseVisualStyleBackColor = false;
            this.ClickMeButton.Click += new System.EventHandler(this.ClickMeButton_Click);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTextBox.Location = new System.Drawing.Point(212, 111);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(217, 38);
            this.NameTextBox.TabIndex = 1;
            // 
            // NameLabel
            // 
            this.NameLabel.BackColor = System.Drawing.SystemColors.Control;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NameLabel.Location = new System.Drawing.Point(187, 50);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(267, 47);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Enter Your Name";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HelloWorldForm
            // 
            this.AcceptButton = this.ClickMeButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.ClickMeButton);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.WelcomeLabel);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "HelloWorldForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hello World!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Button ClickMeButton;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label NameLabel;
    }
}

