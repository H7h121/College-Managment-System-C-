using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.VisualStyles;

namespace collegesystem
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        SqlConnection con = new SqlConnection("Server= LENOVO; Database= college;Integrated Security = SSPI; ");
        private void button1_Click(object sender, EventArgs e)
        {

            mainForm mainfor = new mainForm();
            con.Open();
            SqlDataAdapter s = new SqlDataAdapter("select count(*) from Usertab where UserName='" + logTextbox1.Text + "' and Userpass='" + loginTextbox2.Text + "'", con);
            DataTable b = new DataTable();
            s.Fill(b);
            if (b.Rows[0][0].ToString()=="1")
            {
                mainfor.Show();
                this.Hide();
                con.Close();
            }
            else
            {
                MessageBox.Show(" wrong User name or password");
                
            }
            con.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void loginTextbox2_OnValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
