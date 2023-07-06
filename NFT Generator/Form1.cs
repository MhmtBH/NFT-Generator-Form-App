using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NFT_Generator
{

    public partial class Form1 : Form
    {
        int outputCount = 0;

        int layerImageNumber_1 = 1;
        int layerImageNumber_2 = 1;
        int layerImageNumber_3 = 1;
        int layerImageNumber_4 = 1;
        int layerImageNumber_5 = 1;
        int layerImageNumber_6 = 1;
        int layerImageNumber_7 = 1;
        int layerImageNumber_8 = 1;
        int layerImageNumber_9 = 1;
        int layerImageNumber_10 = 1;

        int layer_10_ImageCount;
        int layer_9_ImageCount;
        int layer_8_ImageCount;
        int layer_7_ImageCount;
        int layer_6_ImageCount;
        int layer_5_ImageCount;
        int layer_4_ImageCount;
        int layer_3_ImageCount;
        int layer_2_ImageCount;
        int layer_1_ImageCount;

        
        public Form1()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            

            if (outputCount == 0)
            {
                progressBar1.Value = 0;
                label1.Text = "";
            }
        }

        private void CombinationGenerator()
        {
            
            while (layerImageNumber_1 <= layer_1_ImageCount)
            {
                layerImageNumber_2 = 1;

                while (layerImageNumber_2 <= layer_2_ImageCount)
                {
                    layerImageNumber_3 = 1;

                    while (layerImageNumber_3 <= layer_3_ImageCount)
                    {
                        layerImageNumber_4 = 1;

                        while (layerImageNumber_4 <= layer_4_ImageCount)
                        {
                            layerImageNumber_5 = 1;

                            while (layerImageNumber_5 <= layer_5_ImageCount)
                            {
                                layerImageNumber_6 = 1;

                                while (layerImageNumber_6 <= layer_6_ImageCount)
                                {
                                    layerImageNumber_7 = 1;

                                    while (layerImageNumber_7 <= layer_7_ImageCount)
                                    {
                                        layerImageNumber_8 = 1;

                                        while (layerImageNumber_8 <= layer_8_ImageCount)
                                        {
                                            layerImageNumber_9 = 1;

                                            while (layerImageNumber_9 <= layer_9_ImageCount)
                                            {
                                                layerImageNumber_10 = 1;

                                                while (layerImageNumber_10 <= layer_10_ImageCount)
                                                {
                                                    output();
                                                    outputCount += 1;
                                                    layerImageNumber_10 += 1;
                                                }

                                                layerImageNumber_9 += 1;

                                            }

                                            layerImageNumber_8 += 1;

                                        }

                                        layerImageNumber_7 += 1;

                                    }

                                    layerImageNumber_6 += 1;
                                }

                                layerImageNumber_5 += 1;

                            }

                            layerImageNumber_4 += 1;

                        }

                        layerImageNumber_3 += 1;
                    }

                    layerImageNumber_2 += 1;
                }

                layerImageNumber_1 += 1;

                

            }
        }

        private void output()
        {
            Image layer1image = Image.FromFile(imgFolder_1_text.Text + "\\" + layerImageNumber_1 + ".png");
            Image layer2image = Image.FromFile(imgFolder_2_text.Text + "\\" + layerImageNumber_2 + ".png");
            Image layer3image = Image.FromFile(imgFolder_3_text.Text + "\\" + layerImageNumber_3 + ".png");
            Image layer4image = Image.FromFile(imgFolder_4_text.Text + "\\" + layerImageNumber_4 + ".png");
            Image layer5image = Image.FromFile(imgFolder_5_text.Text + "\\" + layerImageNumber_5 + ".png");
            Image layer6image = Image.FromFile(imgFolder_6_text.Text + "\\" + layerImageNumber_6 + ".png");
            Image layer7image = Image.FromFile(imgFolder_7_text.Text + "\\" + layerImageNumber_7 + ".png");
            Image layer8image = Image.FromFile(imgFolder_8_text.Text + "\\" + layerImageNumber_8 + ".png");
            Image layer9image = Image.FromFile(imgFolder_9_text.Text + "\\" + layerImageNumber_9 + ".png");
            Image layer10image = Image.FromFile(imgFolder_10_text.Text + "\\" + layerImageNumber_10 + ".png");
            using (Graphics gr = Graphics.FromImage(layer1image))
            {
                gr.DrawImage(layer1image, new Point(0, 0));
                gr.DrawImage(layer2image, new Point(0, 0));
                gr.DrawImage(layer3image, new Point(0, 0));
                gr.DrawImage(layer4image, new Point(0, 0));
                gr.DrawImage(layer5image, new Point(0, 0));
                gr.DrawImage(layer6image, new Point(0, 0));
                gr.DrawImage(layer7image, new Point(0, 0));
                gr.DrawImage(layer8image, new Point(0, 0));
                gr.DrawImage(layer9image, new Point(0, 0));
                gr.DrawImage(layer10image, new Point(0, 0));

            }
            pictureBox1.Image = layer1image;
            layer1image.Save(outputTextBox.Text + "\\" + outputCount + ".png", System.Drawing.Imaging.ImageFormat.Png);

            if (outputCount >= layer_1_ImageCount * layer_2_ImageCount * layer_3_ImageCount * layer_4_ImageCount * layer_5_ImageCount * layer_6_ImageCount * layer_7_ImageCount * layer_8_ImageCount * layer_9_ImageCount * layer_10_ImageCount - 5)
            {        
                label1.Text = "Finish";
                progressBar1.Value = 100;
            }
        }









        private void button1_Click(object sender, EventArgs e)
        {
            CombinationGenerator();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog outputDialog = new FolderBrowserDialog();
            if(outputDialog.ShowDialog() == DialogResult.OK)
            {
                outputTextBox.Text = outputDialog.SelectedPath;
            }
        }

        private void Image_Folder_1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog imgFolder_1_Dialog = new FolderBrowserDialog();
            if (imgFolder_1_Dialog.ShowDialog() == DialogResult.OK)
            {
                imgFolder_1_text.Text = imgFolder_1_Dialog.SelectedPath;
            }
        }

        private void Image_Folder_2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog imgFolder_2_Dialog = new FolderBrowserDialog();
            if (imgFolder_2_Dialog.ShowDialog() == DialogResult.OK)
            {
                imgFolder_2_text.Text = imgFolder_2_Dialog.SelectedPath;
            }
        }

        private void Image_Folder_3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog imgFolder_3_Dialog = new FolderBrowserDialog();
            if (imgFolder_3_Dialog.ShowDialog() == DialogResult.OK)
            {
                imgFolder_3_text.Text = imgFolder_3_Dialog.SelectedPath;
            }
        }

        private void Image_Folder_4_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog imgFolder_4_Dialog = new FolderBrowserDialog();
            if (imgFolder_4_Dialog.ShowDialog() == DialogResult.OK)
            {
                imgFolder_4_text.Text = imgFolder_4_Dialog.SelectedPath;
            }

        }

        private void Image_Folder_5_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog imgFolder_5_Dialog = new FolderBrowserDialog();
            if (imgFolder_5_Dialog.ShowDialog() == DialogResult.OK)
            {
                imgFolder_5_text.Text = imgFolder_5_Dialog.SelectedPath;
            }
        }

        private void Image_Folder_6_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog imgFolder_6_Dialog = new FolderBrowserDialog();
            if (imgFolder_6_Dialog.ShowDialog() == DialogResult.OK)
            {
                imgFolder_6_text.Text = imgFolder_6_Dialog.SelectedPath;
            }
        }

        private void Image_Folder_7_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog imgFolder_7_Dialog = new FolderBrowserDialog();
            if (imgFolder_7_Dialog.ShowDialog() == DialogResult.OK)
            {
                imgFolder_7_text.Text = imgFolder_7_Dialog.SelectedPath;
            }
        }

        private void Image_Folder_8_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog imgFolder_8_Dialog = new FolderBrowserDialog();
            if (imgFolder_8_Dialog.ShowDialog() == DialogResult.OK)
            {
                imgFolder_8_text.Text = imgFolder_8_Dialog.SelectedPath;
            }
        }

        private void Image_Folder_9_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog imgFolder_9_Dialog = new FolderBrowserDialog();
            if (imgFolder_9_Dialog.ShowDialog() == DialogResult.OK)
            {
                imgFolder_9_text.Text = imgFolder_9_Dialog.SelectedPath;
            }
        }

        private void Image_Folder_10_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog imgFolder_10_Dialog = new FolderBrowserDialog();
            if (imgFolder_10_Dialog.ShowDialog() == DialogResult.OK)
            {
                imgFolder_10_text.Text = imgFolder_10_Dialog.SelectedPath;
            }
        }

        public void button2_Click_1(object sender, EventArgs e)
        {
            layer_1_ImageCount = ((int)numericUpDown1.Value);
            layer_2_ImageCount = ((int)numericUpDown2.Value);
            layer_3_ImageCount = ((int)numericUpDown3.Value);
            layer_4_ImageCount = ((int)numericUpDown4.Value);
            layer_5_ImageCount = ((int)numericUpDown5.Value);
            layer_6_ImageCount = ((int)numericUpDown6.Value);
            layer_7_ImageCount = ((int)numericUpDown7.Value);
            layer_8_ImageCount = ((int)numericUpDown8.Value);
            layer_9_ImageCount = ((int)numericUpDown9.Value);
            layer_10_ImageCount = ((int)numericUpDown10.Value);
        }
    }
}
