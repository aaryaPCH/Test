using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class ExtensionMethodForm2 : Form
    {
        public ExtensionMethodForm2()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            StringsListBox.Items.Add(InputStringTextBox.Text);
        }

        private void DoAnalysisButton_Click(object sender, EventArgs e)
        {
            ResultsTextbox.Text = DoAnalysis(StringsListBox.Items);
        }

        private string DoAnalysis(ComboBox.ObjectCollection items)
        {
            var stringList = new List<string>();
            foreach (var item in items)
            {
                stringList.Add((string)item);
            }

            // Get all the data
            string largestString = null;
            string smallestString = null;
            string heaviestString = null;

            foreach (var str in stringList)
            {
                // Check if this string exceeds the largest string
                if (largestString == null || str.GetLength() >= largestString.GetLength())
                {
                    largestString = str;
                }
            }

            foreach (var str in stringList)
            {
                // Check if this string is smaller than the smallest string
                if (smallestString == null || str.GetLength() <= smallestString.GetLength())
                {
                    smallestString = str;
                }
            }

            foreach (var str in stringList)
            {
                // Check if the total of all ASCII values in the current string is greater than the largest ascii values so far
                if (heaviestString == null || str.GetSumOfAsciiCodes() >= heaviestString.GetSumOfAsciiCodes())
                {
                    heaviestString = str;
                }
            }

            return string.Format("Longest string: {0}\r\nSmallest String: {1}\r\nHeaviest String: {2}",
                largestString, smallestString, heaviestString);
        }
    }
}
