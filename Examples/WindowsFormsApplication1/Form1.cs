using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

// ReSharper disable InconsistentNaming
        private void inputNumTextBox_TextChanged(object sender, EventArgs e)
// ReSharper restore InconsistentNaming
        {
            var input = inputNumTextBox.Text;
            inputNumTextBox.Text = CleanupInteger(input);
            inputNumTextBox.SelectionStart = inputNumTextBox.Text.Length;
        }

        private static string CleanupInteger(string input)
        {
            var output = new char[input.Length];
            int index = 0;
            foreach (var character in input)
            {
                if (!IsNumber(character)) continue;

                output[index] = character;
                index++;
            }

            return new string(output);
        }

        private static bool IsNumber(char character)
        {
            return character >= '0' && character <= '9';
        }

        private void calcFactorialButton_Click(object sender, EventArgs e)
        {
            var inputNum = int.Parse(inputNumTextBox.Text);
            var outputNum = 1;
            if (inputNum < 0 || inputNum > 15)
            {
                MessageBox.Show("Please enter a number between 0 and 15");
                return;
            }
            for (int i = inputNum; i > 0; i--)
            {
                outputNum *= i;
            }

            resultsTextBox.Text = outputNum.ToString();


        }
    }
}
