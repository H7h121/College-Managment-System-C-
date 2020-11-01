using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace collegesystem
{
    public partial class Userform : Form
    {
        public Userform()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idTextbox1.Text = userGridView1.SelectedRows[0].Cells[0].Value.ToString();
            nameTextbox3.Text = userGridView1.SelectedRows[0].Cells[1].Value.ToString();
            passTextbox2.Text = userGridView1.SelectedRows[0].Cells[2].Value.ToString();
        }
        SqlConnection con = new SqlConnection("Server= LENOVO; Database= college;Integrated Security = SSPI; ");

        private void Userform_Load(object sender, EventArgs e)
        {
            populate();
        }
        private void populate()
        {
            con.Open();
            string query = "select * from Usertab";
            SqlDataAdapter sa = new SqlDataAdapter(query, con);
            SqlCommandBuilder d = new SqlCommandBuilder(sa);
            var ds = new DataSet();
            sa.Fill(ds);
            userGridView1.DataSource = ds.Tables[0];
            con.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (idTextbox1.Text == "" || nameTextbox3.Text == "" || passTextbox2.Text == "")
                {
                    MessageBox.Show("Missing information");
                }
                else
                {
                    con.Open();
                    SqlCommand sd = new SqlCommand("insert into Usertab values(" + idTextbox1.Text + ",'" + nameTextbox3.Text + "','" + passTextbox2.Text + "')", con);

                    sd.ExecuteNonQuery();
                    MessageBox.Show("User successfully added");
                    con.Close();
                    populate();
                }

            }
            catch (Exception)
            { MessageBox.Show("something  went wrong"); }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (idTextbox1.Text == "")
                { MessageBox.Show("enter the user id"); }
                else
                {
                    con.Open();
                    SqlCommand y = new SqlCommand("delete from Usertab where UserId = " + idTextbox1.Text + "", con);
                    y.ExecuteNonQuery();
                    MessageBox.Show("the user whose id =" + idTextbox1.Text + " is deleted successfully");
                    con.Close();
                    populate();
                }

            }
            catch (Exception)
            { MessageBox.Show("opps..user is not deleted"); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (idTextbox1.Text == "" || nameTextbox3.Text=="" || passTextbox2.Text=="")
                { MessageBox.Show("Missing Data"); }
                else
                {
                    con.Open();
                    SqlCommand y = new SqlCommand("update  Usertab  set UserName='"+nameTextbox3.Text+"',Userpass='"+passTextbox2.Text+"'where UserId = " + idTextbox1.Text + "", con);
                    y.ExecuteNonQuery();
                    MessageBox.Show(" user update successfully");
                    con.Close();
                    populate();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("opps..user is not updated");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            mainForm d = new mainForm();
            d.Show();
            this.Hide();
        }
    }
}    

