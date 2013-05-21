namespace WindowsFormsApplication1
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
            this.label1 = new System.Windows.Forms.Label();
            this.inputNumTextBox = new System.Windows.Forms.TextBox();
            this.calcFactorialButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.resultsTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter number:";
            // 
            // inputNumTextBox
            // 
            this.inputNumTextBox.Location = new System.Drawing.Point(93, 13);
            this.inputNumTextBox.Name = "inputNumTextBox";
            this.inputNumTextBox.Size = new System.Drawing.Size(179, 20);
            this.inputNumTextBox.TabIndex = 1;
            this.inputNumTextBox.TextChanged += new System.EventHandler(this.inputNumTextBox_TextChanged);
            // 
            // calcFactorialButton
            // 
            this.calcFactorialButton.Location = new System.Drawing.Point(16, 46);
            this.calcFactorialButton.Name = "calcFactorialButton";
            this.calcFactorialButton.Size = new System.Drawing.Size(132, 23);
            this.calcFactorialButton.TabIndex = 2;
            this.calcFactorialButton.Text = "Calculate Factorial";
            this.calcFactorialButton.UseVisualStyleBackColor = true;
            this.calcFactorialButton.Click += new System.EventHandler(this.calcFactorialButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Results:";
            // 
            // resultsTextBox
            // 
            this.resultsTextBox.Location = new System.Drawing.Point(19, 114);
            this.resultsTextBox.Multiline = true;
            this.resultsTextBox.Name = "resultsTextBox";
            this.resultsTextBox.ReadOnly = true;
            this.resultsTextBox.Size = new System.Drawing.Size(253, 114);
            this.resultsTextBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.resultsTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.calcFactorialButton);
            this.Controls.Add(this.inputNumTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputNumTextBox;
        private System.Windows.Forms.Button calcFactorialButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox resultsTextBox;

    }
}

