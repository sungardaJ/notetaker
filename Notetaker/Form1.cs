using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notetaker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                richTextBox.SaveFile(saveFileDialog.FileName);
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                richTextBox.LoadFile(openFileDialog.FileName);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (FontFamily font in FontFamily.Families)
            {
                comboBox1.Items.Add(font.Name.ToString());
            }

        }

        private void RichTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {


        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                richTextBox.Font = new Font(comboBox1.Text, comboBox1.Font.Size);
            }
            catch { }
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                richTextBox.Font = new Font(richTextBox.Font.FontFamily, float.Parse(comboBox2.SelectedItem.ToString()));
            }
            catch { }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.ShowDialog();
            richTextBox.ForeColor = dlg.Color;
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                    richTextBox.LoadFile(openFileDialog.FileName);
            }


        }

        private void ToolStripButton1_Click_1(object sender, EventArgs e)
        {
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    richTextBox.SaveFile(saveFileDialog.FileName);
            }

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            ColorDialog dlgg = new ColorDialog();
            dlgg.ShowDialog();
            BackColor = dlgg.Color;

        }
    }
}
