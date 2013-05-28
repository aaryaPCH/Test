using System;
using System.Globalization;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class RandomForm : Form
    {
        public RandomForm()
        {
            InitializeComponent();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            if (StringRadio.Checked)
            {
                var randomGenerator = new RandomGenerator<string>();
                ResultsTextBox.Text = randomGenerator.Generate();
            }
            else if (IntRadio.Checked)
            {
                var randomGenerator = new RandomGenerator<int>();
                ResultsTextBox.Text = randomGenerator.Generate().ToString(CultureInfo.InvariantCulture);
            }
            else if (GuidRadio.Checked)
            {
                var randomGenerator = new RandomGenerator<Guid>();
                ResultsTextBox.Text = randomGenerator.Generate().ToString();
            }
        }
    }
}
