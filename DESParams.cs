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
    public partial class DESParams : Form
    {
        public DESParams()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = Shifrator.GenSecretKey();
            textBox2.Text = Shifrator.GenInitializingVector();
        }

        public string GetSecretKey()
        {
            return textBox1.Text;
        }

        public string GetInitializingVector()
        {
            return textBox2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (StreamWriter outputFile = new StreamWriter(saveFileDialog1.FileName))
                {
                    outputFile.WriteLine(textBox1.Text);
                    outputFile.WriteLine(textBox2.Text);
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
                    textBox2.Text = outputFile.ReadLine();
                }
            }
        }
    }
}
