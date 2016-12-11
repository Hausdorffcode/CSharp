using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlsEx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {//3个checkBox都要调用它
            if (!(sender is CheckBox)) return;
            if (((CheckBox)sender).Parent != this.groupBox1) return;
            string hobby = "";
            foreach (object obj in this.groupBox1.Controls)
            {
                if (obj is CheckBox && ((CheckBox)obj).Checked)
                    hobby += ((CheckBox)obj).Text + ",";
            }
            if (hobby != "")
            {
                this.label1.Text = "兴趣爱好有："
                    + hobby.Remove(hobby.Length - 1, 1) + "。"; //要删除最后一个逗号
            }
            else
            {
                this.label1.Text = "没有兴趣爱好";
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {//3个radioButton都要调用它
            RadioButton rb = sender as RadioButton;
            if (rb == null)
                return;
            if (rb.Checked)
            {
                label1.Text = "性别： " + rb.Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text.Length >= 8)
            {
                this.errorProvider1.SetError(this.textBox1, "长度必须小于8");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Set up the dialog
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Filter = "txt files(*.txt)|*.txt|All files(*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ShowFileText(openFileDialog1.FileName);
            }
        }

        private void ShowFileText(string fileName)
        {
            //Console.WriteLine(fileName);
            System.IO.StreamReader sr = new System.IO.StreamReader(
                fileName, System.Text.Encoding.Default);
            string content = sr.ReadToEnd();
            sr.Close();
            this.textBox2.Text = content;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.label1.Text = "Trans to here.";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Message",
                "Title",
                MessageBoxButtons.OK,
                MessageBoxIcon.Hand);
        }

        private Bitmap MyImage;
        public void showMyImage(String fileToDisplay, int xSize, int ySize)
        {
            // Sets up an image object to be displayed.
            if (MyImage != null)
            {
                MyImage.Dispose();
            }

            // Stretches the image to fit the pictureBox.
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            MyImage = new Bitmap(fileToDisplay);
            pictureBox1.ClientSize = new Size(xSize, ySize);
            pictureBox1.Image = (Image)MyImage;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            showMyImage(@"..\..\..\fish.bmp", 100, 100);   //使用了相对路径

            this.timer1.Interval = 500;
            //this.timer1.Enabled = true;
            this.timer1.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox6.SelectedText = textBox4.Text;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.progressBar1.Value < this.progressBar1.Maximum - 10)
            {
                this.progressBar1.Value += 10;
            }
            else
            {
                this.progressBar1.Value = this.progressBar1.Minimum;
            }
        }
    }
}
