using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace collegesystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int start = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            start += 1;
            bunifuProgressBar3.Value = start;
            if (bunifuProgressBar3.Value == 100)
            {
                bunifuProgressBar3.Value = 0;
                timer1.Stop();
                login log = new login();
                log.Show();
            }


        }

        private void bunifuProgressBar3_progressChanged(object sender, EventArgs e)
        {

        }
    }
}


