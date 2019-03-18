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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fromTextBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XORParams frm = new XORParams(false);
            frm.ShowDialog();

            string Key = frm.GetSecretKey();
            if (Key.Length == 0)
            {
                return;
            }

            textBox2.Text = Shifrator.XOR(textBox1.Text, Key);
        }

        private void fromTextBoxToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            XORParams frm = new XORParams(true);
            frm.ShowDialog();

            string Key = frm.GetSecretKey();
            if (Key.Length == 0)
            {
                return;
            }
                   
            textBox2.Text = Shifrator.CaesarRU(textBox1.Text, Int32.Parse(Key));
        }

        private void fromTextBoxToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            DESParams frm = new DESParams();
            frm.ShowDialog();

            string Key = frm.GetSecretKey();
            string IV = frm.GetInitializingVector();
            if (Key.Length > 0 && IV.Length > 0)
            {
                textBox2.Text = Shifrator.DESEncrypt(textBox1.Text, Key, IV);
            } 
        }

        private void fromTextBoxToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            DESParams frm = new DESParams();
            frm.ShowDialog();

            string Key = frm.GetSecretKey();
            string IV = frm.GetInitializingVector();
            if (Key.Length > 0 && IV.Length > 0)
            {
                textBox2.Text = Shifrator.DESDecrypt(textBox1.Text, Key, IV);
            } 
        }

        private void fromFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                XORParams frm = new XORParams(false);
                frm.ShowDialog();

                string Key = frm.GetSecretKey();
                if(Key.Length == 0)
                {
                    return;
                }
                                
                using (StreamReader rdr = new StreamReader(openFileDialog1.FileName))
                {
                    textBox2.Text = Shifrator.XOR(rdr.ReadToEnd(), Key); 
                }
            }
        }

        private void fromFileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                XORParams frm = new XORParams(true);
                frm.ShowDialog();

                string Key = frm.GetSecretKey();
                if (Key.Length == 0)
                {
                    return;
                }

                using (StreamReader rdr = new StreamReader(openFileDialog1.FileName))
                {
                    textBox2.Text = Shifrator.CaesarRU(rdr.ReadToEnd(), Int32.Parse(Key));
                }
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fromFileToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                DESParams frm = new DESParams();
                frm.ShowDialog();

                string Key = frm.GetSecretKey();
                string IV = frm.GetInitializingVector();
                if (Key.Length > 0 && IV.Length > 0)
                {
                    using (StreamReader rdr = new StreamReader(openFileDialog1.FileName))
                    {
                        textBox2.Text = Shifrator.DESEncrypt(rdr.ReadToEnd(), Key, IV);
                    }
                }
            }
        }

        private void fromFileToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                DESParams frm = new DESParams();
                frm.ShowDialog();

                string Key = frm.GetSecretKey();
                string IV = frm.GetInitializingVector();
                if (Key.Length > 0 && IV.Length > 0)
                {
                    using (StreamReader rdr = new StreamReader(openFileDialog1.FileName))
                    {
                        textBox2.Text = Shifrator.DESDecrypt(rdr.ReadToEnd(), Key, IV);
                    }
                }
            }
        }
    }
}
