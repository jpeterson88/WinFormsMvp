using System.Windows.Forms;

namespace cutebutton
{
    public partial class MyCustomerInfoUserControl : UserControl
    {
        private System.ComponentModel.IContainer components;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        public MyCustomerInfoUserControl()
        {
            InitializeComponent();
        }
    }
}
