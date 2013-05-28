namespace WindowsFormsApplication1
{
    partial class ExtensionMethodForm
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
            this.InputStringTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CleanupStringButton = new System.Windows.Forms.Button();
            this.ResultsTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // InputStringTextBox
            // 
            this.InputStringTextBox.Location = new System.Drawing.Point(13, 39);
            this.InputStringTextBox.Name = "InputStringTextBox";
            this.InputStringTextBox.Size = new System.Drawing.Size(259, 20);
            this.InputStringTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter a string and pad it with spaces";
            // 
            // CleanupStringButton
            // 
            this.CleanupStringButton.Location = new System.Drawing.Point(16, 66);
            this.CleanupStringButton.Name = "CleanupStringButton";
            this.CleanupStringButton.Size = new System.Drawing.Size(113, 23);
            this.CleanupStringButton.TabIndex = 2;
            this.CleanupStringButton.Text = "Cleanup String";
            this.CleanupStringButton.UseVisualStyleBackColor = true;
            this.CleanupStringButton.Click += new System.EventHandler(this.CleanupStringButton_Click);
            // 
            // ResultsTextBox
            // 
            this.ResultsTextBox.Location = new System.Drawing.Point(16, 96);
            this.ResultsTextBox.Multiline = true;
            this.ResultsTextBox.Name = "ResultsTextBox";
            this.ResultsTextBox.ReadOnly = true;
            this.ResultsTextBox.Size = new System.Drawing.Size(256, 143);
            this.ResultsTextBox.TabIndex = 3;
            // 
            // ExtensionMethodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.ResultsTextBox);
            this.Controls.Add(this.CleanupStringButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InputStringTextBox);
            this.Name = "ExtensionMethodForm";
            this.Text = "ExtensionMethodForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputStringTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CleanupStringButton;
        private System.Windows.Forms.TextBox ResultsTextBox;
    }
}