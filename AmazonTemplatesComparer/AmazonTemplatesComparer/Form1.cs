using System;
using System.IO;
using System.Windows.Forms;
using static System.String;

namespace AmazonTemplatesComparer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FirstFIleSearchButton_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
                                  {
                                      InitialDirectory = "c:\\",
                                      Filter = "Xls files (*.xls)|*.xls",
                                      RestoreDirectory = true
                                  };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FirstFileTextBox.Text = openFileDialog.FileName;
            }
        }

        private void SecondFileSearchButton_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                InitialDirectory = "c:\\",
                Filter = "Xls files (*.xls)|*.xls",
                RestoreDirectory = true
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                SecondFileTextBox.Text = openFileDialog.FileName;
            }
        }

        private void FirstFileTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateFile(FirstFileTextBox.Text);
        }

        private void ValidateFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                ValidateCompareButton();
            }
        }

        private void SecondFileTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateFile(SecondFileTextBox.Text);
        }

        private void ValidateCompareButton()
        {
            var isValid = FirstFileTextBox.Text.Trim() != "" && SecondFileTextBox.Text.Trim() != "";
            CompareButton.Enabled = isValid;
        }

        private void CompareButton_Click(object sender, EventArgs e)
        {
            var comparer = new Comparer(FirstFileTextBox.Text, SecondFileTextBox.Text);
            comparer.Run();
        }
    }
}