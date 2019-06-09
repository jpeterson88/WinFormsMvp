using System;
using System.Windows.Forms;

namespace cutebutton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog { Multiselect = false, ValidateNames = true, Filter = "JPEG|*.jpg" })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    txtFileName.Text = dialog.FileName;
                    myCustomControl1.ImageFile = dialog.FileName;
                }
            }
        }

        private void btnOpenAudio_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog { Multiselect = false, ValidateNames = true, Filter = "WAVE|*.wav" })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    txtFileName.Text = dialog.FileName;
                    myCustomControl1.ClickFilePath = dialog.FileName;
                }
            }
        }
    }
}
