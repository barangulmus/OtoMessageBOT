using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace otomessagebotx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 1;
            string rictext = richTextBox1.Text;
            int milis = Convert.ToInt32(textBox1.Text);
            System.Threading.Thread.Sleep(2000);
            while (i>0)
            {
                Clipboard.SetText(rictext);
                SendKeys.Send("^v");
                System.Threading.Thread.Sleep(milis);
                SendKeys.Send("{ENTER}");
                System.Threading.Thread.Sleep(milis);

            }
        }
    }
}
