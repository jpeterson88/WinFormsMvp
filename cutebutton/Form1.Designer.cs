namespace cutebutton
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOpen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.myCustomControl1 = new cutebutton.MyCustomControl();
            this.imageFilePath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOpenAudio = new System.Windows.Forms.Button();
            this.myCustomerInfoUserControl1 = new cutebutton.MyCustomerInfoUserControl();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(614, 12);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "&Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Image File";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(219, 12);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(389, 20);
            this.txtFileName.TabIndex = 2;
            // 
            // myCustomControl1
            // 
            this.myCustomControl1.AutoScroll = true;
            this.myCustomControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.myCustomControl1.ClickFilePath = null;
            this.myCustomControl1.Location = new System.Drawing.Point(12, 89);
            this.myCustomControl1.Name = "myCustomControl1";
            this.myCustomControl1.Size = new System.Drawing.Size(307, 321);
            this.myCustomControl1.TabIndex = 3;
            // 
            // imageFilePath
            // 
            this.imageFilePath.Location = new System.Drawing.Point(219, 38);
            this.imageFilePath.Name = "imageFilePath";
            this.imageFilePath.Size = new System.Drawing.Size(389, 20);
            this.imageFilePath.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Audio File";
            // 
            // btnOpenAudio
            // 
            this.btnOpenAudio.Location = new System.Drawing.Point(614, 38);
            this.btnOpenAudio.Name = "btnOpenAudio";
            this.btnOpenAudio.Size = new System.Drawing.Size(75, 23);
            this.btnOpenAudio.TabIndex = 4;
            this.btnOpenAudio.Text = "&Open";
            this.btnOpenAudio.UseVisualStyleBackColor = true;
            this.btnOpenAudio.Click += new System.EventHandler(this.btnOpenAudio_Click);
            // 
            // myCustomerInfoUserControl1
            // 
            this.myCustomerInfoUserControl1.Location = new System.Drawing.Point(397, 89);
            this.myCustomerInfoUserControl1.Name = "myCustomerInfoUserControl1";
            this.myCustomerInfoUserControl1.Size = new System.Drawing.Size(375, 150);
            this.myCustomerInfoUserControl1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 730);
            this.Controls.Add(this.myCustomerInfoUserControl1);
            this.Controls.Add(this.imageFilePath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOpenAudio);
            this.Controls.Add(this.myCustomControl1);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOpen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFileName;
        private MyCustomControl myCustomControl1;
        private System.Windows.Forms.TextBox imageFilePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOpenAudio;
        private MyCustomerInfoUserControl myCustomerInfoUserControl1;
    }
}

