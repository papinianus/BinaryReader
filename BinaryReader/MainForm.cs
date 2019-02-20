using System;
using System.Windows.Forms;
using System.IO;

namespace BinaryReader
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void SelectFileButtonClick(object sender, EventArgs e)
        {
            var filePath = SelectFileDialog();
            if(string.IsNullOrEmpty(filePath)) { return; }
            SelectedFile.Text = filePath;
            DataBox.ResetText();
            DataBox.Text = string.Join(string.Empty, Format.Lines(File.ReadAllBytes(filePath)));
        }
        private string SelectFileDialog()
        {
            var result = FileDialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                return FileDialog.FileName;
            }
            return string.Empty;
        }
    }
}
