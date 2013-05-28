namespace WindowsFormsApplication1
{
    partial class ExtensionMethodForm2
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
            this.label1 = new System.Windows.Forms.Label();
            this.InputStringTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.StringsListBox = new System.Windows.Forms.ComboBox();
            this.ResultsTextbox = new System.Windows.Forms.TextBox();
            this.DoAnalysisButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter many strings here using the Add button";
            // 
            // InputStringTextBox
            // 
            this.InputStringTextBox.Location = new System.Drawing.Point(16, 30);
            this.InputStringTextBox.Name = "InputStringTextBox";
            this.InputStringTextBox.Size = new System.Drawing.Size(256, 20);
            this.InputStringTextBox.TabIndex = 1;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(16, 66);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // StringsListBox
            // 
            this.StringsListBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.StringsListBox.FormattingEnabled = true;
            this.StringsListBox.Location = new System.Drawing.Point(16, 96);
            this.StringsListBox.Name = "StringsListBox";
            this.StringsListBox.Size = new System.Drawing.Size(256, 150);
            this.StringsListBox.TabIndex = 3;
            // 
            // ResultsTextbox
            // 
            this.ResultsTextbox.Location = new System.Drawing.Point(16, 282);
            this.ResultsTextbox.Multiline = true;
            this.ResultsTextbox.Name = "ResultsTextbox";
            this.ResultsTextbox.ReadOnly = true;
            this.ResultsTextbox.Size = new System.Drawing.Size(256, 112);
            this.ResultsTextbox.TabIndex = 5;
            // 
            // DoAnalysisButton
            // 
            this.DoAnalysisButton.Location = new System.Drawing.Point(16, 252);
            this.DoAnalysisButton.Name = "DoAnalysisButton";
            this.DoAnalysisButton.Size = new System.Drawing.Size(75, 23);
            this.DoAnalysisButton.TabIndex = 4;
            this.DoAnalysisButton.Text = "Do Analysis";
            this.DoAnalysisButton.UseVisualStyleBackColor = true;
            this.DoAnalysisButton.Click += new System.EventHandler(this.DoAnalysisButton_Click);
            // 
            // EnumerationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 406);
            this.Controls.Add(this.ResultsTextbox);
            this.Controls.Add(this.DoAnalysisButton);
            this.Controls.Add(this.StringsListBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.InputStringTextBox);
            this.Controls.Add(this.label1);
            this.Name = "EnumerationForm";
            this.Text = "EnumerationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InputStringTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ComboBox StringsListBox;
        private System.Windows.Forms.TextBox ResultsTextbox;
        private System.Windows.Forms.Button DoAnalysisButton;
    }
}