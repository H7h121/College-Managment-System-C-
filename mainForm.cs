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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gunaCircleButton1_Click(object sender, EventArgs e)
        {
            new Student().Show();
            this.Hide();
        }

        private void gunaCircleButton2_Click(object sender, EventArgs e)
        {
            teachers s = new teachers();
            s.Show();
            this.Hide();
        }

        private void gunaCircleButton5_Click(object sender, EventArgs e)
        {
            Userform d = new Userform();
            d.Show();
            this.Hide();
        }

        private void gunaCircleButton3_Click(object sender, EventArgs e)
        {
            Department k = new Department();
            k.Show();
            this.Hide();
        }

        private void gunaCircleButton4_Click(object sender, EventArgs e)
        {
            Fees c = new Fees();
            c.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login x = new login();
            x.Show();
            this.Hide();
        }

        private void gunaCircleButton6_Click(object sender, EventArgs e)
        {
            dashboard das = new dashboard();
              das.Show();
            this.Hide();
        }
    }
}
