using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            saveFileDialog1.Filter = "Text File(*.txt)|*.txt";
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.Cancel) return;
            File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);
            MessageBox.Show("File saved!");
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.Cancel) return;
            richTextBox1.Text = File.ReadAllText(openFileDialog1.FileName); 
            MessageBox.Show("File opened!");
        }

        private void sAToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(richTextBox1.TextLength != 0)
            {
                richTextBox1.Copy();
            }
        }
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength != 0)
            {
                richTextBox1.Paste();
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength != 0)
            {
                richTextBox1.Cut();
            }
        }
        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength != 0)
            {
                richTextBox1.SelectAll();
            }
        }

        private void fontSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog(); 
            richTextBox1.Font = fontDialog1.Font;

        }

        private void backgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.BackColor = colorDialog1.Color;
        }

        private void richTextBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                richTextBox1.ContextMenuStrip = contextMenuStrip1;
            }
        }

        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength != 0)
            {
                richTextBox1.Copy();
            }
        }

        private void pasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength != 0)
            {
                richTextBox1.Paste();
            }
        }

        private void cutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength != 0)
            {
                richTextBox1.Cut();
            }
        }

        private void selectAllToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength != 0)
            {
                richTextBox1.SelectAll();
            }
        }
    }
}
