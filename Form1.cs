using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace analysis_lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int n5 = 10 + 4;//добавить № варианта 
        FileStream file1;
        StreamReader reader;
        string filename1;
        StreamWriter writer;
        private void открытьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            // использовать расширение по варианту 
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл             
            string filename = openFileDialog1.FileName;
            // читаем файл в строку 
            string fileText = File.ReadAllText(filename);
            richTextBox1.Text = fileText;
            string s1 = "абвгдеёжзийклмнопрстуфхцчшщъыьэюяАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
            string s2 = "abvgde_=zijklmnoprstufhc@%&*y()-!ABVGDEEJZIJKLMNOPRSTUFHCHSITYWLOY";
            string s = "";
            string buf = richTextBox1.Text;
            for (int i = 0; i < buf.Length; i++)
            {
                int k = 0;
                for (int j = 1; j < 66; j++)
                {
                    if (s1[j] == buf[i])
                    { k = j; };
                };
                if (k > 0)
                { s += s2[k].ToString(); }
                else
                { s += buf[i].ToString(); };
            };
            System.IO.File.WriteAllText(filename, s, Encoding.UTF8);
        }
        private void создатьПапкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel) 
            if (folderBrowserDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            Directory.SetCurrentDirectory(folderBrowserDialog1.SelectedPath);
            Directory.CreateDirectory("TestDir");     //№ варианта        
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FileInfo fsi = new FileInfo(openFileDialog1.FileName);
            if (folderBrowserDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            DirectoryInfo di = new DirectoryInfo(folderBrowserDialog1.SelectedPath);
            // Get a reference to each file in that directory. 
            FileInfo[] fiArr = di.GetFiles();
            // Display the names and sizes of the files. 
            richTextBox1.AppendText("\n" + "The directory contains the following files:" + di.Name);
            foreach (FileInfo f in fiArr)
                richTextBox1.AppendText("\n" + "The size of " + f.Name + " is " + f.Length + " bytes. " + f.CreationTime);
        }
    }
}
