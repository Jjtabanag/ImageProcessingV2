using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HNUDIP;
using WebCamLib;

namespace ImageProcessing
{
    public partial class Form1 : Form
    {
        bool brightness = false;
        bool contrast = false;
        bool rotate = false;
        bool scale = false;
        Device[] myDevices;

        public Form1()
        {
            InitializeComponent();
            this.Height = 376;
            myDevices = DeviceManager.GetAllDevices();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            if (open.ShowDialog() == DialogResult.OK)
                pictureBox1.Image = Image.FromFile(open.FileName);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            if (pictureBox2.Image != null && save.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image.Save(save.FileName);
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (pictureBox1 != null)
            {
                hideGroupBoxVisibility(3);
                Bitmap img = (Bitmap)pictureBox1.Image;
                Bitmap copyImg = new Bitmap(img.Width, img.Height);
                for (int x = 0; x < img.Width; x++)
                {
                    for (int y = 0; y < img.Height; y++)
                    {
                        Color pixel = img.GetPixel(x, y);
                        copyImg.SetPixel(x, y, pixel);
                    }
                }
                pictureBox2.Image = copyImg;
            }
        }

        private void grayScalingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                hideGroupBoxVisibility(3);
                btnMakeBaseImg.Enabled = true;
                Bitmap img = (Bitmap)pictureBox1.Image;
                Bitmap grayscale_img = new Bitmap(img.Width, img.Height);
                for (int x = 0; x < img.Width; x++)
                {
                    for (int y = 0; y < img.Height; y++)
                    {
                        Color pixel = img.GetPixel(x, y);
                        int gray_pixel = (pixel.R + pixel.G + pixel.B) / 3;
                        grayscale_img.SetPixel(x, y, Color.FromArgb(gray_pixel, gray_pixel, gray_pixel));
                    } 
                }
                pictureBox2.Image = grayscale_img;
            }
        }

        private void colorInversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                hideGroupBoxVisibility(3);
                btnMakeBaseImg.Enabled = true;
                Bitmap img = (Bitmap)pictureBox1.Image;
                Bitmap colorInversion_img = new Bitmap(img.Width, img.Height);
                for (int x = 0; x < img.Width; x++)
                {
                    for (int y = 0; y < img.Height; y++)
                    {
                        Color pixel = img.GetPixel(x, y);
                        colorInversion_img.SetPixel(x, y, Color.FromArgb(255 - pixel.R, 255 - pixel.G, 255 - pixel.B));
                    }
                }
                pictureBox2.Image = colorInversion_img;
            }
        }

        private void sepiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                hideGroupBoxVisibility(3);
                btnMakeBaseImg.Enabled = true;
                Bitmap img = (Bitmap)pictureBox1.Image;
                Bitmap sepia_img = new Bitmap(img.Width, img.Height);
                int outputRed, outputGreen, outputBlue;
                for (int x = 0; x < img.Width; x++)
                {
                    for (int y = 0; y < img.Height; y++)
                    {
                        Color pixel = img.GetPixel(x, y);
                        outputRed = (int)Math.Min(255, (pixel.R * .393) + (pixel.G * .769) + (pixel.B * .189));
                        outputGreen =(int)Math.Min(255, (pixel.R * .349) + (pixel.G * .686) + (pixel.B * .168));
;                       outputBlue = (int)Math.Min(255, (pixel.R * .272) + (pixel.G * .534) + (pixel.B * .131));
                        sepia_img.SetPixel(x, y, Color.FromArgb(outputRed, outputGreen, outputBlue));
                    }
                }
                pictureBox2.Image = sepia_img;
            }
        }

        private void histogramToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            btnMakeBaseImg.Enabled = false;
            hideGroupBoxVisibility(3);
            if (scale) { scaleBox.Visible = false; }
            else if (brightness || contrast || rotate) { groupBox1.Visible = false; }

            if (pictureBox1.Image == null) { return; }

            Bitmap img = (Bitmap)pictureBox1.Image;
            Bitmap result = new Bitmap(img.Width, img.Height);
            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {
                    Color pixel = img.GetPixel(x, y);
                    int gray_pixel = (pixel.R + pixel.G + pixel.B) / 3;
                    result.SetPixel(x, y, Color.FromArgb(gray_pixel, gray_pixel, gray_pixel));
                }
            }
            
            Color sample;
            int[] histdata = new int[256];
            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {
                    sample = result.GetPixel(x, y);
                    histdata[sample.R]++;
                }
            }

            //Drawing the histogram
            Bitmap histo = new Bitmap(256, 800);
            for (int x = 0; x < 256; x++)
            {
                for(int y = 0;y < 800; y++)
                {
                    histo.SetPixel(x, y, Color.White);
                }
            }

            for (int x = 0; x < 256; x++)
            {
                for (int y = 0; y < Math.Min(histdata[x]/5, 800); y++)
                {
                    histo.SetPixel(x, 799 - y, Color.Gray);
                }
            }

            pictureBox2.Image = histo;
        }

        private void brightnessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!brightness && pictureBox1.Image != null)
            {
                hideGroupBoxVisibility(1);
                btnMakeBaseImg.Enabled = true;
                this.Height = 563;
                brightness = true;
                contrast = false;
                rotate = false;
                scale = false;
                btnApply.Visible = true;
                btnStop.Visible = true;
                groupBox1.Text = "Change Brightness";
                groupBox1.Visible = true;
                scaleBox.Visible = false;
                trackBar1.Value = 0;
                trackBar1.Minimum = -50;
                trackBar1.Maximum = 50;
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void contrastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!contrast && pictureBox1.Image != null)
            {
                hideGroupBoxVisibility(1);
                btnMakeBaseImg.Enabled = true;
                this.Height = 563;
                brightness = false;
                contrast = true;
                rotate = false;
                scale = false;
                btnApply.Visible = true;
                btnStop.Visible = true;
                groupBox1.Text = "Change Contrast";
                groupBox1.Visible = true;
                scaleBox.Visible = false;
                trackBar1.Value = 0;
                trackBar1.Minimum = -50;
                trackBar1.Maximum = 50;
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void rotateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!rotate && pictureBox1.Image != null)
            {
                hideGroupBoxVisibility(1);
                btnMakeBaseImg.Enabled = true;
                this.Height = 563;
                brightness = false;
                contrast = false;
                rotate = true;
                scale = false;
                btnApply.Visible = true;
                btnStop.Visible = true;
                groupBox1.Text = "Rotate Image (-360 to 360)";
                groupBox1.Visible = true;
                scaleBox.Visible = false;
                trackBar1.Value = 0;
                trackBar1.Minimum = -360;
                trackBar1.Maximum = 360;
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void scaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!scale && pictureBox1.Image != null)
            {
                hideGroupBoxVisibility(2);
                btnMakeBaseImg.Enabled = true;
                this.Height = 563;
                brightness = false;
                contrast = false;
                rotate = false;
                scale = true;
                btnApply.Visible = true;
                btnStop.Visible = true;
                scaleBox.Visible = true;
                groupBox1.Visible = false;
                pictureBox2.Image = null;
                pictureBox2.SizeMode = PictureBoxSizeMode.Normal;
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            btnMakeBaseImg.Enabled = true;

            //Change Brightness
            if (brightness)
            {
                int val = trackBar1.Value;
                Bitmap img = (Bitmap)pictureBox1.Image;
                Bitmap result = new Bitmap(img.Width, img.Height);

                for (int x = 0; x < img.Width; x++)
                {
                    for (int y = 0; y < img.Height; y++)
                    {
                        Color pixel = img.GetPixel(x, y);
                        if (val >= 0)
                            result.SetPixel(x, y, Color.FromArgb(Math.Min(pixel.R + val, 255),
                                                                 Math.Min(pixel.G + val, 255),
                                                                 Math.Min(pixel.B + val, 255)));
                        else 
                            result.SetPixel(x, y, Color.FromArgb(Math.Max(pixel.R + val, 0),
                                                                 Math.Max(pixel.G + val, 0),
                                                                 Math.Max(pixel.B + val, 0)));
                    }
                }
                pictureBox2.Image = result;
            }
            //Change Contrast (Equalization)
            else if (contrast)
            {
                Bitmap a = (Bitmap)pictureBox1.Image;
                Bitmap b = new Bitmap(a.Width, a.Height);
                int degree = trackBar1.Value;

                int width = a.Width;
                int height = a.Height;
                int numSamples;
                int[] rHistData = new int[256];
                int[] gHistData = new int[256];
                int[] bHistData = new int[256];

                for (int x = 0; x < width; x++)
                {
                    for (int y = 0; y < height; y++)
                    {
                        Color pixel = a.GetPixel(x, y);
                        rHistData[pixel.R]++;
                        gHistData[pixel.G]++;
                        bHistData[pixel.B]++;   
                    }
                }
                // Histogram of RGB
                numSamples = (width * height);
                int rHistSum = 0;
                int[] rYMap = new int[256];
                for (int h = 0; h < 256; h++)
                {
                    rHistSum += rHistData[h];
                    rYMap[h] = rHistSum * 255 / numSamples;
                }
                int gHistSum = 0;
                int[] gYMap = new int[256];
                for (int h = 0; h < 256; h++)
                {
                    gHistSum += gHistData[h];
                    gYMap[h] = gHistSum * 255 / numSamples;
                }
                int bHistSum = 0;
                int[] bYMap = new int[256];
                for (int h = 0; h < 256; h++)
                {
                    bHistSum += bHistData[h];
                    bYMap[h] = bHistSum * 255 / numSamples;
                }
                // Mapping the values
                if (degree < 100)
                {
                    for (int h = 0; h < 256; h++)
                    {
                        rYMap[h] = Math.Max(0, Math.Min(255, h + ((int)rYMap[h] - h) * degree / 100));
                        gYMap[h] = Math.Max(0, Math.Min(255, h + ((int)gYMap[h] - h) * degree / 100));
                        bYMap[h] = Math.Max(0, Math.Min(255, h + ((int)bYMap[h] - h) * degree / 100));
                    }
                } 
                // Setting the pixel
                for (int x = 0; x < width; x++)
                {
                    for (int y = 0; y < height; y++)
                    {
                        Color pixel = Color.FromArgb(rYMap[a.GetPixel(x, y).R], 
                                                     gYMap[a.GetPixel(x, y).G], 
                                                     bYMap[a.GetPixel(x, y).B]);
                        b.SetPixel(x, y, pixel);
                    }
                }
                pictureBox2.Image = b;
            }
            // Rotate image (-360 to 360 degrees)
            else if (rotate)
            {
                Bitmap img = (Bitmap)pictureBox1.Image;
                Bitmap result = new Bitmap(img.Width, img.Height);

                // Get Center of image
                int centerX = img.Width / 2;
                int centerY = img.Height / 2;

                // Convert angle from degrees to radians
                float angle = trackBar1.Value;
                double radians = Math.PI * angle / 180.0;
                
                float cosA = (float)Math.Cos(radians);
                float sinA = (float)Math.Sin(radians);
                int x0, y0, xs, ys;

                for (int x = 0; x < img.Width; x++)
                {
                    for (int y = 0; y < img.Height; y++)
                    {
                        x0 = x - centerX;
                        y0 = y - centerY;
                        xs = (int)(x0 * cosA + y0 * sinA + centerX);
                        ys = (int)(-x0 * sinA + y0 * cosA + centerY);

                        // Check if the rotated coordinates are within the picturebox boundaries
                        if (xs >= 0 && xs < img.Width && ys >= 0 && ys < img.Height)
                        {
                            result.SetPixel(x, y, img.GetPixel(xs, ys));
                        }
                        else
                        {
                            // Set background color to transparent for pixels that fall outside the picturebox boundaries
                            result.SetPixel(x, y, Color.Transparent);
                        }
                    }
                }
                pictureBox2.Image = result;
            }
            // Scale image (input dimension)
            else if (scale)
            {
                Bitmap img = (Bitmap)pictureBox1.Image;
                if (!isNumber(inputWidth.Text) || !isNumber(inputHeight.Text)) { return; }

                int targetWidth = int.Parse(inputWidth.Text);
                int targetHeight = int.Parse(inputHeight.Text);

                if (targetWidth <= 0 || targetHeight <= 0) { return; }

                Bitmap result = new Bitmap(targetWidth, targetHeight);
                int xSource, ySource;

                for (int x = 0; x < targetWidth; x++)
                {
                    for (int y = 0; y < targetHeight; y++)
                    {
                        // Calculate source coordinates based on scaling factors
                        xSource = (int)x * img.Width / targetWidth;
                        ySource = (int)y * img.Height / targetHeight;

                        // Get pixel from the original image and set it in the scaled image
                        Color pixel = img.GetPixel(xSource, ySource);
                        result.SetPixel(x, y, pixel);
                    }
                }

                pictureBox2.Image = result;
            }
        }

        private void hideGroupBoxVisibility(int choice)
        {
            switch (choice)
            {
                case 1:
                    scaleBox.Visible = false;
                    scale = false;
                    break;
                case 2:
                    groupBox1.Visible = false;
                    brightness = false;
                    contrast = false;
                    rotate = false;
                    break;
                case 3:
                    scaleBox.Visible = false;
                    groupBox1.Visible = false;
                    btnApply.Visible = false;
                    btnStop.Visible = false;
                    this.Height = 376;
                    break;
            }
        }

        public bool isNumber(string str)
        {
            try
            {
                int num = int.Parse(str);
                return true;
            }
            catch (Exception e)
            {
                return false;
            } 
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            hideGroupBoxVisibility(3);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnMakeBaseImg.Enabled = true;
            if (pictureBox1 != null)
            {
                Bitmap img = (Bitmap)pictureBox1.Image;
                Bitmap flipVert = new Bitmap(img.Width, img.Height);
                for (int x = 0; x < img.Width; x++)
                {
                    for (int y = 0; y < img.Height; y++)
                    {
                        Color pixel = img.GetPixel(x, y);
                        flipVert.SetPixel(x, img.Height - 1 - y, pixel);
                    }
                }
                pictureBox2.Image = flipVert;
            }
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnMakeBaseImg.Enabled = true;
            if (pictureBox1 != null)
            {
                Bitmap img = (Bitmap)pictureBox1.Image;
                Bitmap flipHori = new Bitmap(img.Width, img.Height);
                for (int x = 0; x < img.Width; x++)
                {
                    for (int y = 0; y < img.Height; y++)
                    {
                        Color pixel = img.GetPixel(x, y);
                        flipHori.SetPixel(img.Width - 1 - x, y, pixel);
                    }
                }
                pictureBox2.Image = flipHori;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMakeBaseImg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (pictureBox2.Image != null)
            {
                pictureBox1.Image = pictureBox2.Image;
                pictureBox2.Image = null;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            IDataObject data;
            Bitmap bmap;
            myDevices[0].Sendmessage();
            data = Clipboard.GetDataObject(); 
            bmap = (Bitmap)data.GetData(DataFormats.Bitmap, true);
            Bitmap bit = new Bitmap(bmap);
            pictureBox1.Image = bit;
        }

        private void onToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            myDevices[0].ShowWindow(pictureBox1);
        }

        private void offToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myDevices[0].Stop();
            timer1.Stop();
        }

        private void subtractToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Height = 750;
            groupBox2.Text = "Background Image";
            groupBox3.Visible = true;
            btnLoadImg.Visible = true;
            btnLoadBg.Visible = true;
            btnSubtract.Visible = true;
        }


        private void openFile(ref PictureBox pb)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            if (open.ShowDialog() == DialogResult.OK)
                pb.Image = Image.FromFile(open.FileName);
        }

        private void btnLoadImg_Click(object sender, EventArgs e)
        {
            openFile(ref pictureBox1);
        }

        private void btnLoadBg_Click(object sender, EventArgs e)
        {
            openFile(ref pictureBox2);
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            Bitmap img = (Bitmap)pictureBox1.Image;
            Bitmap bg = (Bitmap)pictureBox2.Image;
            Bitmap result = new Bitmap(bg.Width, bg.Height);
            int threshold = 5;
            Subtract(ref img, ref bg, ref result, threshold);
            pictureBox3.Image = result;
        }
        public static void Subtract(ref Bitmap a, ref Bitmap b, ref Bitmap result, int value)
        {
            result = new Bitmap(a.Width, a.Height);
            Color mygreen = Color.FromArgb(0, 255, 0);
            int greygreen = (mygreen.R + mygreen.G + mygreen.B) / 3;
            for (int x = 0; x < a.Width; x++) 
            {
                for (int y = 0; y < a.Height; y++)
                {
                    Color pixel = a.GetPixel(x, y);
                    Color backpixel = b.GetPixel(x, y);
                    int grey = (pixel.R + pixel.G + pixel.B) / 3;
                    int subtractValue = Math.Abs(grey - greygreen);
                    if (subtractValue > value)
                        result.SetPixel(x, y, pixel); 
                    else
                        result.SetPixel(x, y, backpixel); 
                }
            }
        }
    }
}
