namespace ImageColorSelector
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSelectColor = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ImagePathLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.imageColorLbl = new System.Windows.Forms.Label();
            this.panelSelectedColor = new System.Windows.Forms.Panel();
            this.colorDialogbox = new System.Windows.Forms.ColorDialog();
            this.btnMatchColor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(277, 261);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(308, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Browse Image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSelectColor
            // 
            this.btnSelectColor.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectColor.Location = new System.Drawing.Point(308, 72);
            this.btnSelectColor.Name = "btnSelectColor";
            this.btnSelectColor.Size = new System.Drawing.Size(143, 23);
            this.btnSelectColor.TabIndex = 2;
            this.btnSelectColor.Text = "Select Color";
            this.btnSelectColor.UseVisualStyleBackColor = true;
            this.btnSelectColor.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ImagePathLbl
            // 
            this.ImagePathLbl.AutoSize = true;
            this.ImagePathLbl.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImagePathLbl.ForeColor = System.Drawing.Color.White;
            this.ImagePathLbl.Location = new System.Drawing.Point(391, 38);
            this.ImagePathLbl.Name = "ImagePathLbl";
            this.ImagePathLbl.Size = new System.Drawing.Size(84, 16);
            this.ImagePathLbl.TabIndex = 3;
            this.ImagePathLbl.Text = "ImagePathLbl";
            this.ImagePathLbl.Click += new System.EventHandler(this.ImagePathLbl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(310, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Image Path:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // imageColorLbl
            // 
            this.imageColorLbl.AutoSize = true;
            this.imageColorLbl.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageColorLbl.ForeColor = System.Drawing.Color.White;
            this.imageColorLbl.Location = new System.Drawing.Point(308, 98);
            this.imageColorLbl.Name = "imageColorLbl";
            this.imageColorLbl.Size = new System.Drawing.Size(74, 16);
            this.imageColorLbl.TabIndex = 5;
            this.imageColorLbl.Text = "Image Color";
            this.imageColorLbl.Click += new System.EventHandler(this.imageColorLbl_Click);
            // 
            // panelSelectedColor
            // 
            this.panelSelectedColor.Location = new System.Drawing.Point(311, 223);
            this.panelSelectedColor.Name = "panelSelectedColor";
            this.panelSelectedColor.Size = new System.Drawing.Size(139, 49);
            this.panelSelectedColor.TabIndex = 6;
            // 
            // btnMatchColor
            // 
            this.btnMatchColor.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMatchColor.Location = new System.Drawing.Point(308, 147);
            this.btnMatchColor.Name = "btnMatchColor";
            this.btnMatchColor.Size = new System.Drawing.Size(143, 23);
            this.btnMatchColor.TabIndex = 7;
            this.btnMatchColor.Text = "Match Color";
            this.btnMatchColor.UseVisualStyleBackColor = true;
            this.btnMatchColor.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(743, 313);
            this.Controls.Add(this.btnMatchColor);
            this.Controls.Add(this.panelSelectedColor);
            this.Controls.Add(this.imageColorLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ImagePathLbl);
            this.Controls.Add(this.btnSelectColor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSelectColor;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label ImagePathLbl;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label imageColorLbl;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelSelectedColor;
        private System.Windows.Forms.ColorDialog colorDialogbox;
        private System.Windows.Forms.Button btnMatchColor;
    }
}

