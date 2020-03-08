namespace RegexStreetAddressMatch
{
    partial class MainForm
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
            this.SourceTextBox = new System.Windows.Forms.TextBox();
            this.FindStreetAddressButton = new System.Windows.Forms.Button();
            this.URLTextBox = new System.Windows.Forms.TextBox();
            this.GetHTMLButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ClearSourceButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SourceTextBox
            // 
            this.SourceTextBox.Location = new System.Drawing.Point(12, 47);
            this.SourceTextBox.MaxLength = 1991632767;
            this.SourceTextBox.Multiline = true;
            this.SourceTextBox.Name = "SourceTextBox";
            this.SourceTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SourceTextBox.Size = new System.Drawing.Size(775, 381);
            this.SourceTextBox.TabIndex = 0;
            // 
            // FindStreetAddressButton
            // 
            this.FindStreetAddressButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindStreetAddressButton.Location = new System.Drawing.Point(93, 447);
            this.FindStreetAddressButton.Name = "FindStreetAddressButton";
            this.FindStreetAddressButton.Size = new System.Drawing.Size(694, 28);
            this.FindStreetAddressButton.TabIndex = 1;
            this.FindStreetAddressButton.Text = "Find Street Address";
            this.FindStreetAddressButton.UseVisualStyleBackColor = true;
            this.FindStreetAddressButton.Click += new System.EventHandler(this.FindStreetAddressButton_Click);
            // 
            // URLTextBox
            // 
            this.URLTextBox.Location = new System.Drawing.Point(50, 11);
            this.URLTextBox.Name = "URLTextBox";
            this.URLTextBox.Size = new System.Drawing.Size(576, 20);
            this.URLTextBox.TabIndex = 2;
            this.URLTextBox.Text = "https://www.ktb.gov.tr/TR-106961/bakanlik-birimleri-iletisim-bilgileri.html";
            // 
            // GetHTMLButton
            // 
            this.GetHTMLButton.Location = new System.Drawing.Point(641, 9);
            this.GetHTMLButton.Name = "GetHTMLButton";
            this.GetHTMLButton.Size = new System.Drawing.Size(146, 23);
            this.GetHTMLButton.TabIndex = 3;
            this.GetHTMLButton.Text = "Get HTML Code From Url";
            this.GetHTMLButton.UseVisualStyleBackColor = true;
            this.GetHTMLButton.Click += new System.EventHandler(this.GetHTMLButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "URL:";
            // 
            // ClearSourceButton
            // 
            this.ClearSourceButton.Location = new System.Drawing.Point(12, 447);
            this.ClearSourceButton.Name = "ClearSourceButton";
            this.ClearSourceButton.Size = new System.Drawing.Size(75, 28);
            this.ClearSourceButton.TabIndex = 5;
            this.ClearSourceButton.Text = "Clear";
            this.ClearSourceButton.UseVisualStyleBackColor = true;
            this.ClearSourceButton.Click += new System.EventHandler(this.ClearSourceButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 490);
            this.Controls.Add(this.ClearSourceButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GetHTMLButton);
            this.Controls.Add(this.URLTextBox);
            this.Controls.Add(this.FindStreetAddressButton);
            this.Controls.Add(this.SourceTextBox);
            this.Name = "MainForm";
            this.Text = "Regex Street Address Match";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SourceTextBox;
        private System.Windows.Forms.Button FindStreetAddressButton;
        private System.Windows.Forms.TextBox URLTextBox;
        private System.Windows.Forms.Button GetHTMLButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ClearSourceButton;
    }
}

