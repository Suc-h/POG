using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExterPrg
{
    public partial class Form1 : Form
    {
        int n,cifry,cifsoucet;
        string cifsouc;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cifsoucet = 0;
            Delitele.Items.Clear();
            n = Convert.ToInt32(numericUpDown1.Value);
            int help = n;
            while (n > 0)
            {
                cifry = n % 10;
                cifsoucet = cifsoucet + cifry;
                n = n / 10;
            }
            n = help;
           

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                   Delitele.Items.Add(i.ToString());
                }
                
            }  
            cifsouc = Convert.ToString(cifsoucet);
            MessageBox.Show(cifsouc);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Delitele.Items.Clear();
            numericUpDown1.ResetText();
            numericUpDown1.Value = 0;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
