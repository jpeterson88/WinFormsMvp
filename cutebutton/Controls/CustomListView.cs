﻿using System.Drawing;
using System.Windows.Forms;

namespace cutebutton.Controls
{
    public partial class CustomListView : UserControl
    {
        ListView listView1;

        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            //This makes an elipse around our control
            //System.Drawing.Drawing2D.GraphicsPath shape = new System.Drawing.Drawing2D.GraphicsPath();
            //shape.AddEllipse(0, 0, this.Width, this.Height);
            //this.Region = new System.Drawing.Region(shape);

            //Get graphics object
            var graphics = e.Graphics;

            //Create pen and set color
            System.Drawing.Pen myPen;
            myPen = new System.Drawing.Pen(System.Drawing.Color.Tomato);
            myPen.Color = System.Drawing.Color.PeachPuff;

            graphics.DrawLine(myPen, 20, 10, 300, 100);
        }

        public void Setup()
        {
            listView1 = new ListView();


            listView1.Bounds = new Rectangle(new Point(10, 10), new Size(300, 200));

            // Set the view to show details.
            listView1.View = View.Details;
            // Allow the user to edit item text.
            listView1.LabelEdit = true;
            // Allow the user to rearrange columns.
            listView1.AllowColumnReorder = true;
            // Display check boxes.
            listView1.CheckBoxes = true;
            // Select the item and subitems when selection is made.
            listView1.FullRowSelect = true;
            // Display grid lines.
            listView1.GridLines = true;
            // Sort the items in the list in ascending order.
            listView1.Sorting = SortOrder.Ascending;

            // Create three items and three sets of subitems for each item.
            ListViewItem item1 = new ListViewItem("item1", 0);
            // Place a check mark next to the item.
            item1.Checked = true;
            item1.SubItems.Add("1");
            item1.SubItems.Add("2");
            item1.SubItems.Add("3");
            ListViewItem item2 = new ListViewItem("item2", 1);
            item2.SubItems.Add("4");
            item2.SubItems.Add("5");
            item2.SubItems.Add("6");
            ListViewItem item3 = new ListViewItem("item3", 2);
            // Place a check mark next to the item.
            item3.Checked = true;
            item3.SubItems.Add("7");
            item3.SubItems.Add("8");
            item3.SubItems.Add("9");

            ListViewItem item4 = new ListViewItem("item4", 3);
            item1.Checked = true;
            item4.SubItems.Add("10");
            item4.SubItems.Add("11");
            item4.SubItems.Add("12");

            // Create columns for the items and subitems.
            // Width of -2 indicates auto-size.
            listView1.Columns.Add("Item Column", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Column 2", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Column 3", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Column 4", -2, HorizontalAlignment.Center);

            //Add the items to the ListView.
            listView1.Items.AddRange(new ListViewItem[] { item1, item2, item3, item4 });

            // Create two ImageList objects.
            ImageList imageListSmall = new ImageList();
            ImageList imageListLarge = new ImageList();

            // Initialize the ImageList objects with bitmaps.
            imageListSmall.Images.Add(Bitmap.FromFile("C:\\small1.png"));
            imageListSmall.Images.Add(Bitmap.FromFile("C:\\small2.png"));
            imageListSmall.Images.Add(Bitmap.FromFile("C:\\large1.png"));
            imageListSmall.Images.Add(Bitmap.FromFile("C:\\large2.jpg"));

            //Assign the ImageList objects to the ListView.
            listView1.LargeImageList = imageListLarge;
            listView1.SmallImageList = imageListSmall;

            // Add the ListView to the control collection.
            this.Controls.Add(listView1);
        }
    }
}
