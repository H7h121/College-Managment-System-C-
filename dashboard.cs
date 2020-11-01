using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace collegesystem
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Server= LENOVO; Database= college;Integrated Security = SSPI; ");
        private void populate()
        {
            con.Open();
            string query = "select count(*) from   StudentTab";
            SqlDataAdapter sa = new SqlDataAdapter(query, con);
            DataTable s = new DataTable();
            sa.Fill(s);
            stdlabel4.Text =s.Rows[0][0].ToString() ;
            con.Close();
        }
        private void popu()
        {
            con.Open();
            string query = "select count(*) from   FeesTb";
            SqlDataAdapter sa = new SqlDataAdapter(query, con);
            DataTable s = new DataTable();
            sa.Fill(s);
            label9.Text = s.Rows[0][0].ToString();
            con.Close();
        }
        private void pop()
        {
            con.Open();
            string query = "select count(*) from   Teachertab";
            SqlDataAdapter sa = new SqlDataAdapter(query, con);
            DataTable s = new DataTable();
            sa.Fill(s);
            label5.Text = s.Rows[0][0].ToString();
            con.Close();
        }
        private void dep()
        {
            con.Open();
            string query = "select count(*) from  Department";
            SqlDataAdapter sa = new SqlDataAdapter(query, con);
            DataTable s = new DataTable();
            sa.Fill(s);
            label7.Text = s.Rows[0][0].ToString();
            con.Close();
        }
        private void dashboard_Load(object sender, EventArgs e)
        {
            populate();
            pop();
            dep();
            popu();

        }

        private void label4_Click(object sender, EventArgs e)
        {
            mainForm d = new mainForm();
             d.Show();
            this.Hide();
        }
    }
}
