using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace cutebutton
{
    public partial class MyCustomControl : Panel
    {
        PictureBox pictureBox;
        public MyCustomControl()
        {
            InitializeComponent();
            pictureBox = new PictureBox();
            this.Controls.Add(pictureBox);
        }

        [Category("Custom")]
        [Browsable(true)]
        [Description("Set path to image file")]
        [Editor(typeof(WindowsFormsComponentEditor), typeof(UITypeEditor))]

        public string ImageFile
        {
            set
            {
                Image img = Image.FromFile(value);
                pictureBox.Image = img;
                pictureBox.Size = img.Size;
            }
        }

        public string ClickFilePath { get; set; }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            pictureBox.BackColorChanged += new System.EventHandler(DerpEventHandler);
        }

        private void DerpEventHandler(object sender, EventArgs e)
        {
            MessageBox.Show("Derp");
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(ClickFilePath))
            {
                using (System.Media.SoundPlayer player = new System.Media.SoundPlayer())
                {
                    player.SoundLocation = ClickFilePath;
                    player.Play();
                }
            }
        }
    }
}
