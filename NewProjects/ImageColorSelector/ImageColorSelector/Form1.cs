using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageColorSelector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Clearing previously selected image from picture box
                ImagePathLbl.Text = "";
                pictureBox1.Image = null;

                //Showing the File Chooser Dialog Box for Image File selection
                DialogResult IsFileChosen = openFileDialog1.ShowDialog();

                if (IsFileChosen == System.Windows.Forms.DialogResult.OK)
                {
                    //Get the File name
                    ImagePathLbl.Text = openFileDialog1.FileName;

                    //Load the image into a picture box
                    if (openFileDialog1.ValidateNames == true)
                    {
                        pictureBox1.Image = Image.FromFile(ImagePathLbl.Text);
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ColorDetection clr = new ColorDetection();
            //clr.getPixl();
            try
            {
                // Clean previously selected color
                imageColorLbl.Text = "";
                panelSelectedColor.BackColor = DefaultBackColor;

                //Showing color choice
                DialogResult IsColorChosen = colorDialogbox.ShowDialog();

                if (IsColorChosen == System.Windows.Forms.DialogResult.OK)
                {
                    panelSelectedColor.BackColor = colorDialogbox.Color;

                    //If it is know color, display the color name  
                    if (colorDialogbox.Color.IsKnownColor == true)
                    {
                        imageColorLbl.Text = colorDialogbox.Color.ToKnownColor().ToString()+" Color Selected";
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
             try
            {
                //Form1 frm = new Form1();
                Boolean IsColorFound = false;
                if (pictureBox1.Image != null)
                {
                    
                    Bitmap bmp = new Bitmap(pictureBox1.Image);

                    //Iterate whole bitmap to findout the picked color
                    for (int i = 0; i < pictureBox1.Image.Height; i++)
                    {
                        for (int j = 0; j < pictureBox1.Image.Width; j++)
                        {
                            
                            //Get the color at each pixel
                            Color now_color = bmp.GetPixel(j, i);

                            //Compare Pixel's Color ARGB property with the picked color's ARGB property 
                            if (now_color.ToArgb() == panelSelectedColor.BackColor.ToArgb())
                            {
                                IsColorFound = true;
                                string colorr = now_color.ToKnownColor().ToString();    
                                MessageBox.Show(colorr+" Color Found!");
                                break;
                            }
                        }
                        if (IsColorFound == true)
                        {
                            break;
                        }
                    }
                    if (IsColorFound == false)
                    {
                        MessageBox.Show("Selected Color Not Found.");
                    }
                }
                else
                {
                    MessageBox.Show("Image is not loaded");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void ImagePathLbl_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void imageColorLbl_Click(object sender, EventArgs e)
        {

        }
        }
    }

