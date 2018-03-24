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

namespace CS_lab1
{
    public partial class Form1 : Form
    {
        class TextStatistics
        {
            public Dictionary<char, int> probability = new Dictionary<char, int>();

            public void addChar(char ch)
            {
                if (probability.Keys.Contains(ch))
                {
                    probability[ch]++;
                }
                else
                {
                    probability.Add(ch, 1);
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void printTextStatistics(string filename)
        {
            labelFileame.Text = filename;

            TextStatistics textStatistics = new TextStatistics();

            int charsSum = -1;

            using (StreamReader sr = new StreamReader(filename, System.Text.Encoding.UTF8))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (!checkBoxUpercase.Checked)
                        line = line.ToLower();

                    foreach (char c in line)
                    {
                        textStatistics.addChar(c);
                    }

                    charsSum += line.Length;

                    if (checkBoxEnter.Checked)
                    {
                        textStatistics.addChar('\n');
                        charsSum += 1;
                    }
                }
            }

            double charsCount = -1,
                prob,
                entr = 0;

            foreach (int value in textStatistics.probability.Values)
                charsCount += value;

            listView1.Clear();
            listView1.Columns.Add("Частота появи символів в тексті:", -2, HorizontalAlignment.Left);

            ListViewItem item;
            string itemtext;

            foreach (char c in textStatistics.probability.Keys)
            {
                if (c == ' ')
                    itemtext = "space";
                else
                    if (c == '\n')
                {
                    itemtext = "enter";
                }
                else
                    itemtext = "'" + c + "'";

                prob = (textStatistics.probability[c] - (c == '\n' ? 1 : 0)) / charsCount;

                itemtext += ": " + prob;

                item = new ListViewItem(itemtext);
                listView1.Items.Add(item);

                if(prob != 0)
                    entr -= prob * Math.Log(prob) / Math.Log(2);
            }

            listView1.Refresh();

            labelEntr.Text = entr + " біт";
            labelInfo.Text = (entr * charsSum / 8) + " байт";

            FileInfo fi = new FileInfo(filename);

            labelFileSize.Text = fi.Length + " байт";
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = @"E:\GoogleDisk\Study\Temp\Комп'ютерні системи\lab1";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog1.FileName;

                printTextStatistics(filename);
            }
        }
    }
}
