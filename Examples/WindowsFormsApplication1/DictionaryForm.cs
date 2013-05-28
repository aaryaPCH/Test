using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class DictionaryForm : Form
    {
        Dictionary<string, string> _dictionary = new Dictionary<string, string>();

        public DictionaryForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            _dictionary[KeyTextBox.Text] = ValueTextBox.Text;
            RefreshDictonaryTextBox();
        }

        private void RefreshDictonaryTextBox()
        {
            var pairs = new StringBuilder();
            foreach (var kvp in _dictionary)
            {
                pairs.AppendFormat("[{0} = {1}]", kvp.Key, kvp.Value);
                pairs.AppendLine();
            }
            DictionaryTextBox.Text = pairs.ToString();
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            var key = FindByKeyTextBox.Text;
            if (string.IsNullOrEmpty(key))
            {
                MessageBox.Show("You must enter a key");
                return;
            }

            var value = _dictionary.ContainsKey(key) ? _dictionary[key] : null;
            if (value == null)
            {
                MessageBox.Show("Cannot find the given key");
                return;
            }

            SearchResultTextBox.Text = value;
        }
    }
}
