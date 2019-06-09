using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace cutebutton
{
    public partial class GDIForm : Form
    {
        private string texturePath = "C:\\Users\\jpete\\Pictures\\texture1.jpg";
        public GDIForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {


            drawLinearGradient(e.Graphics);
            //drawCompositedAlphaBlendingEllipse(e.Graphics);

        }

        //Linear gradient exammple
        private void drawLinearGradient(Graphics graphics)
        {
            LinearGradientBrush linGrBrush = new LinearGradientBrush(
               new Point(0, 10),
               new Point(200, 10),
               Color.FromArgb(255, 255, 0, 0),   // Opaque red
               Color.FromArgb(128, 0, 0, 255));  // semi transparent blue

            Pen pen = new Pen(linGrBrush);

            graphics.DrawLine(pen, 0, 10, 200, 10);
            graphics.FillEllipse(linGrBrush, 0, 30, 200, 100);
            graphics.FillRectangle(linGrBrush, 0, 155, 500, 30);
        }


        //Use Compositing Mode to Control Alpha Blending
        private void drawCompositedAlphaBlendingEllipse(Graphics graphics)
        {
            // Create a blank bitmap.
            Bitmap myBitmap = new Bitmap(180, 100);

            // Create a Graphics object that we can use to draw on the bitmap.
            Graphics bitmapGraphics = Graphics.FromImage(myBitmap);

            // Create a red brush and a green brush, each with an alpha value of 160.
            SolidBrush redBrush = new SolidBrush(Color.FromArgb(160, 255, 0, 0));
            SolidBrush greenBrush = new SolidBrush(Color.FromArgb(160, 0, 255, 0));

            // Set the compositing mode so that when we draw overlapping ellipses,
            // the colors of the ellipses are not blended.
            bitmapGraphics.CompositingMode = CompositingMode.SourceCopy;

            // Fill an ellipse using a red brush that has an alpha value of 160.
            bitmapGraphics.FillEllipse(redBrush, 0, 0, 150, 70);

            // Fill a second ellipse using a green brush that has an alpha value of 160. 
            // The green ellipse overlaps the red ellipse, but the green is not 
            // blended with the red.
            bitmapGraphics.FillEllipse(greenBrush, 30, 30, 150, 70);

            // Set the compositing quality of the form's Graphics object. 
            graphics.CompositingQuality = CompositingQuality.GammaCorrected;

            // Draw a multicolored background.
            SolidBrush colorBrush = new SolidBrush(Color.Aqua);
            graphics.FillRectangle(colorBrush, 200, 0, 60, 100);
            colorBrush.Color = Color.Yellow;
            graphics.FillRectangle(colorBrush, 260, 0, 60, 100);
            colorBrush.Color = Color.Fuchsia;
            graphics.FillRectangle(colorBrush, 320, 0, 60, 100);

            // Display the bitmap on a white background.
            graphics.DrawImage(myBitmap, 0, 0);

            // Display the bitmap on a multicolored background.
            graphics.DrawImage(myBitmap, 200, 0);
        }
    }
}
