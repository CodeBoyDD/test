using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SpeedTool
{
    public partial class Frm_Tools_CMD : Form
    {
        public Frm_Tools_CMD()
        {
            InitializeComponent();
        }

        private void Frm_Tools_CMD_Load(object sender, EventArgs e)
        {
            Cmd c = new Cmd();
            richTextBox1.Text = richTextBox1.Text + c.RunCmd(textBox1.Text.Trim());
            richTextBox1.SelectionStart = richTextBox1.TextLength;
            richTextBox1.ScrollToCaret();
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            Cmd c = new Cmd();
            richTextBox1.Text = richTextBox1.Text + c.RunCmd(textBox1.Text.Trim());
            richTextBox1.SelectionStart = richTextBox1.TextLength;
            richTextBox1.ScrollToCaret();
            textBox1.Text = "";
        }
    }
}
