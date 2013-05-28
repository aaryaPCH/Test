using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class ExtensionMethodForm : Form
    {
        public ExtensionMethodForm()
        {
            InitializeComponent();
        }

        private void CleanupStringButton_Click(object sender, EventArgs e)
        {
            var input = InputStringTextBox.Text;
            if (input.IsNullOrEmptyAfterTrim())
            {
                MessageBox.Show("Hey you entered a blank string!");
            }
            else
            {
                ResultsTextBox.Text = input.Trim();
            }
        }
    }
}
