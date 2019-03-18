using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShifrB
{
    public partial class XORParams : Form
    {
        bool Caesar;
        public XORParams(bool caesar)
        {
            InitializeComponent();
            if (caesar)
            {
                Caesar = caesar;
                label1.Text = "Сдвиг";
                textBox1.Visible = false;
                numericUpDown1.Visible = true;
                button4.Visible = false;
                button5.Visible = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (StreamWriter outputFile = new StreamWriter(saveFileDialog1.FileName))
                {
                    outputFile.WriteLine(textBox1.Text);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (StreamReader outputFile = new StreamReader(openFileDialog1.FileName))
                {
                    textBox1.Text = outputFile.ReadLine();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        public string GetSecretKey()
        {
            if(!Caesar)
                return textBox1.Text;
            else
                return numericUpDown1.Value.ToString();
        }
    }
}
