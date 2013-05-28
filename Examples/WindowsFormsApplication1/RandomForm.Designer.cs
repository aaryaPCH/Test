namespace WindowsFormsApplication1
{
    partial class RandomForm
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
            this.GenerateButton = new System.Windows.Forms.Button();
            this.StringRadio = new System.Windows.Forms.RadioButton();
            this.IntRadio = new System.Windows.Forms.RadioButton();
            this.GuidRadio = new System.Windows.Forms.RadioButton();
            this.ResultsTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(13, 13);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(147, 23);
            this.GenerateButton.TabIndex = 0;
            this.GenerateButton.Text = "Generate Randomness";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // StringRadio
            // 
            this.StringRadio.AutoSize = true;
            this.StringRadio.Checked = true;
            this.StringRadio.Location = new System.Drawing.Point(13, 43);
            this.StringRadio.Name = "StringRadio";
            this.StringRadio.Size = new System.Drawing.Size(52, 17);
            this.StringRadio.TabIndex = 1;
            this.StringRadio.TabStop = true;
            this.StringRadio.Text = "String";
            this.StringRadio.UseVisualStyleBackColor = true;
            // 
            // IntRadio
            // 
            this.IntRadio.AutoSize = true;
            this.IntRadio.Location = new System.Drawing.Point(13, 66);
            this.IntRadio.Name = "IntRadio";
            this.IntRadio.Size = new System.Drawing.Size(58, 17);
            this.IntRadio.TabIndex = 2;
            this.IntRadio.Text = "Integer";
            this.IntRadio.UseVisualStyleBackColor = true;
            // 
            // GuidRadio
            // 
            this.GuidRadio.AutoSize = true;
            this.GuidRadio.Location = new System.Drawing.Point(13, 89);
            this.GuidRadio.Name = "GuidRadio";
            this.GuidRadio.Size = new System.Drawing.Size(52, 17);
            this.GuidRadio.TabIndex = 3;
            this.GuidRadio.Text = "GUID";
            this.GuidRadio.UseVisualStyleBackColor = true;
            // 
            // ResultsTextBox
            // 
            this.ResultsTextBox.Location = new System.Drawing.Point(13, 113);
            this.ResultsTextBox.Multiline = true;
            this.ResultsTextBox.Name = "ResultsTextBox";
            this.ResultsTextBox.ReadOnly = true;
            this.ResultsTextBox.Size = new System.Drawing.Size(259, 137);
            this.ResultsTextBox.TabIndex = 4;
            // 
            // RandomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.ResultsTextBox);
            this.Controls.Add(this.GuidRadio);
            this.Controls.Add(this.IntRadio);
            this.Controls.Add(this.StringRadio);
            this.Controls.Add(this.GenerateButton);
            this.Name = "RandomForm";
            this.Text = "RandomForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.RadioButton StringRadio;
        private System.Windows.Forms.RadioButton IntRadio;
        private System.Windows.Forms.RadioButton GuidRadio;
        private System.Windows.Forms.TextBox ResultsTextBox;
    }
}