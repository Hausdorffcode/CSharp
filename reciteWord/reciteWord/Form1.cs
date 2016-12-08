using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace reciteWord
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //ParameterClass pc = new ParameterClass();
            readWordToArray(wordFile);
        }

        private string wordFile = @"C:\Users\huangqiming\Documents\GitHub\CSharp\reciteWord\College_Grade4.txt";  //单词文件
        private string[] englishArray;  //英语数组
        private string[] chineseArray;  //汉语数组
        private int arrayindex = 0;         //记录下标索引
        Random random = new Random();    //生成随机下标

        public void readWordToArray(string wordFile)
        {//读取单词文件txt到两个数组中
            StreamReader reader = new StreamReader(wordFile, System.Text.ASCIIEncoding.Default);
            string s = reader.ReadToEnd();
            reader.Close();
            string[] lineArray = s.Split('\n');
            englishArray = new string[lineArray.Length];
            chineseArray = new string[lineArray.Length];           
            for(int i = 0; i < lineArray.Length; i++)
            {
                string[] perlineArray = lineArray[i].Trim().Split('\t');
                englishArray[i] = perlineArray[0];
                chineseArray[i] = perlineArray[1];
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labChinese.Text = chineseArray[arrayindex % chineseArray.Length];
            labEnglish.Text = englishArray[arrayindex % englishArray.Length];
            if (btnRandom.Text == "不随机")
                arrayindex++;
            else
                arrayindex = random.Next(chineseArray.Length);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {            
            timer1.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            if(btnRandom.Text == "随机")
            {
                btnRandom.Text = "不随机";
            }
            else
            {
                btnRandom.Text = "随机";
            }
        }

        private void btnSpeed_Click(object sender, EventArgs e)
        {
            if(btnSpeed.Text == "快")
            {
                btnSpeed.Text = "慢";
                timer1.Interval = 2000;
            }
            else
            {
                btnSpeed.Text = "快";
                timer1.Interval = 1000;
            }

        }
    }
}
