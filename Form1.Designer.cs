namespace link_to_html
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
            button1 = new Button();
            lblStatus = new Label();
            textBoxLinkPageTitle = new TextBox();
            labelLinkPageTitle = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(152, 37);
            button1.Name = "button1";
            button1.Size = new Size(111, 23);
            button1.TabIndex = 0;
            button1.Text = "Convert Links";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(12, 83);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(81, 27);
            lblStatus.TabIndex = 1;
            lblStatus.Text = "Status";
            // 
            // textBoxLinkPageTitle
            // 
            textBoxLinkPageTitle.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxLinkPageTitle.Location = new Point(152, 5);
            textBoxLinkPageTitle.Name = "textBoxLinkPageTitle";
            textBoxLinkPageTitle.Size = new Size(184, 26);
            textBoxLinkPageTitle.TabIndex = 2;
            textBoxLinkPageTitle.TextChanged += textBox1_TextChanged;
            // 
            // labelLinkPageTitle
            // 
            labelLinkPageTitle.AutoSize = true;
            labelLinkPageTitle.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelLinkPageTitle.Location = new Point(12, 9);
            labelLinkPageTitle.Name = "labelLinkPageTitle";
            labelLinkPageTitle.Size = new Size(134, 22);
            labelLinkPageTitle.TabIndex = 3;
            labelLinkPageTitle.Text = "Link Page Title";
            labelLinkPageTitle.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(360, 133);
            Controls.Add(labelLinkPageTitle);
            Controls.Add(textBoxLinkPageTitle);
            Controls.Add(lblStatus);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Convert Link Page File to HTML Page";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label lblStatus;
        private TextBox textBoxLinkPageTitle;
        private Label labelLinkPageTitle;
    }
}
