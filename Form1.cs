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
            openFileDialog.Filter = "Text files(*.txt)|*.txt|Word files(*.doc)|*.doc|All files(*.*)|*.*";
            // использовать расширение по варианту 
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл             
            string filename = openFileDialog.FileName;
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
            if (folderBrowserDialog.ShowDialog() == DialogResult.Cancel)
                return;
            Directory.SetCurrentDirectory(folderBrowserDialog.SelectedPath);
            Directory.CreateDirectory("4");     //№ варианта        
        }

        private void DirBtn_Click(object sender, EventArgs e)
        {
            _ = new FileInfo(openFileDialog.FileName);
            if (folderBrowserDialog.ShowDialog() == DialogResult.Cancel)
                return;
            DirectoryInfo di = new DirectoryInfo(folderBrowserDialog.SelectedPath);
            // Get a reference to each file in that directory. 
            FileInfo[] fiArr = di.GetFiles();
            // Display the names and sizes of the files. 
            richTextBox1.AppendText("\n" + "The directory contains the following files:" + di.Name);
            foreach (FileInfo f in fiArr)
                richTextBox1.AppendText("\n" + "The size of " + f.Name + " is " + f.Length + " bytes. " + f.CreationTime);
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Find(SearchInput.Text);
            richTextBox1.SelectionColor = Color.Red;
        }

        private void ReadBtnOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            filename1 = openFileDialog.FileName;
            file1 = new FileStream(filename1, FileMode.Open);
            reader = new StreamReader(file1);
        }

        private void ReadBtnLine_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("\n" + reader.ReadLine());
        }

        private void WriteBtnLine_Click(object sender, EventArgs e)
        {
            writer.WriteLine(SearchInput.Text);
        }

        private void ReadBtnClose_Click(object sender, EventArgs e)
        {
            reader.Close();
        }

        private void WriteBtnOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            filename1 = openFileDialog.FileName;
            file1 = new FileStream(filename1, FileMode.Append);
            writer = new StreamWriter(file1);
        }

        private void WriteBtnClose_Click(object sender, EventArgs e)
        {
            writer.Close();
        }

        private void ReadBlock_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = openFileDialog.FileName;
            using (FileStream fstream = new FileStream(@filename, FileMode.OpenOrCreate))
            {
                fstream.Seek(int.Parse(PositionInput.Text) + 2, SeekOrigin.Begin);//  .End); 
                byte[] output = new byte[n5];
                int n = fstream.Read(output, 0, output.Length);
                string textFromFile = Encoding.Default.GetString(output);
                SearchInput.Text = textFromFile;
            }
        }

        private void WriteBlock_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = saveFileDialog.FileName;
            using (FileStream fstream = new FileStream(@filename, FileMode.OpenOrCreate))
            {
                string replaceText = SearchInput.Text;
                if (replaceText.Length < n5)
                {
                    replaceText = replaceText + "..........";
                }
                if (replaceText.Length > n5)
                {
                    replaceText = replaceText.Substring(0, n5);// обрезаем сначала до 5 символов
                }
                fstream.Seek(int.Parse(PositionInput.Text) + 2, SeekOrigin.Begin); // на 5 символов
                byte[] input = Encoding.Default.GetBytes(replaceText);
                fstream.Write(input, 0, input.Length);
            }
        }
    }
}
