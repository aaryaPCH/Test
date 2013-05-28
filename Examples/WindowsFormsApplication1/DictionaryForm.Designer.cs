namespace WindowsFormsApplication1
{
    partial class DictionaryForm
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
            this.KeyTextBox = new System.Windows.Forms.TextBox();
            this.ValueTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.DictionaryTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FindByKeyTextBox = new System.Windows.Forms.TextBox();
            this.FindButton = new System.Windows.Forms.Button();
            this.SearchResultTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Key";
            // 
            // KeyTextBox
            // 
            this.KeyTextBox.Location = new System.Drawing.Point(65, 10);
            this.KeyTextBox.Name = "KeyTextBox";
            this.KeyTextBox.Size = new System.Drawing.Size(207, 20);
            this.KeyTextBox.TabIndex = 1;
            // 
            // ValueTextBox
            // 
            this.ValueTextBox.Location = new System.Drawing.Point(65, 36);
            this.ValueTextBox.Name = "ValueTextBox";
            this.ValueTextBox.Size = new System.Drawing.Size(207, 20);
            this.ValueTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Value";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(16, 71);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DictionaryTextBox
            // 
            this.DictionaryTextBox.Location = new System.Drawing.Point(16, 101);
            this.DictionaryTextBox.Multiline = true;
            this.DictionaryTextBox.Name = "DictionaryTextBox";
            this.DictionaryTextBox.ReadOnly = true;
            this.DictionaryTextBox.Size = new System.Drawing.Size(256, 74);
            this.DictionaryTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Find by key";
            // 
            // FindByKeyTextBox
            // 
            this.FindByKeyTextBox.Location = new System.Drawing.Point(84, 182);
            this.FindByKeyTextBox.Name = "FindByKeyTextBox";
            this.FindByKeyTextBox.Size = new System.Drawing.Size(188, 20);
            this.FindByKeyTextBox.TabIndex = 7;
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(20, 208);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(75, 23);
            this.FindButton.TabIndex = 8;
            this.FindButton.Text = "Find";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // SearchResultTextBox
            // 
            this.SearchResultTextBox.Location = new System.Drawing.Point(16, 250);
            this.SearchResultTextBox.Multiline = true;
            this.SearchResultTextBox.Name = "SearchResultTextBox";
            this.SearchResultTextBox.ReadOnly = true;
            this.SearchResultTextBox.Size = new System.Drawing.Size(256, 74);
            this.SearchResultTextBox.TabIndex = 9;
            // 
            // DictionaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 336);
            this.Controls.Add(this.SearchResultTextBox);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.FindByKeyTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DictionaryTextBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ValueTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.KeyTextBox);
            this.Controls.Add(this.label1);
            this.Name = "DictionaryForm";
            this.Text = "DictionaryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox KeyTextBox;
        private System.Windows.Forms.TextBox ValueTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox DictionaryTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FindByKeyTextBox;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.TextBox SearchResultTextBox;
    }
}