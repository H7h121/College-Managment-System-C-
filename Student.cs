using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace collegesystem
{
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Student_Load(object sender, EventArgs e)
        {
            populate();
            fillDepNmae();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

    

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void gunaDateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTextbox1_OnTextChange(object sender, EventArgs e)
        {

        }

        private void bunifuTextbox1_OnTextChange_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            mainForm d = new mainForm();
            d.Show();
            this.Hide();
        }
        SqlConnection con = new SqlConnection("Server= LENOVO; Database= college;Integrated Security = SSPI; ");
        private void fillDepNmae()
        {
            con.Open();
            SqlCommand sw = new SqlCommand("select DepName from Department", con);
            SqlDataReader red;
            red = sw.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("DepName", typeof(string));
            dt.Load(red);
            studentcomboBox1.ValueMember = "DepName";
            studentcomboBox1.DataSource = dt;
            con.Close();
        }
        private void populate()
        {
            con.Open();
            string query = "select * from   StudentTab";
            SqlDataAdapter sa = new SqlDataAdapter(query, con);
            SqlCommandBuilder d = new SqlCommandBuilder(sa);
            var s = new DataSet();
            sa.Fill(s);
            stdDataGridView1.DataSource = s.Tables[0];
            con.Close();
        }
        private void studentcomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (studentDateTimePicker1.Text == "" || StdIdTextbox1.Text == "" || StdNameTextbox4.Text == "" || StdcomboBox1.Text == "" || StdfeesTextbox5.Text == "" || StdphoneTextbox3.Text=="" || studentcomboBox1.Text=="")
                {
                    MessageBox.Show("Missing information");
                }
                else
                {
                    con.Open();
                    SqlCommand sd = new SqlCommand("insert into StudentTab values(" + StdIdTextbox1.Text + ",'" + StdNameTextbox4.Text + "','" + StdcomboBox1.Text + "','" + studentDateTimePicker1.Text + "'," + StdphoneTextbox3.Text + ",'"+ studentcomboBox1.Text +"',"+ StdfeesTextbox5.Text+ ")", con);
                    sd.ExecuteNonQuery();
                    MessageBox.Show("student successfully added");
                    con.Close();
                    populate();
                   
                }

            }
            catch (Exception)
            { MessageBox.Show("something  went wrong pelese  try again"); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (studentDateTimePicker1.Text == "" || StdIdTextbox1.Text == "" || StdNameTextbox4.Text == "" || StdcomboBox1.Text == "" || StdfeesTextbox5.Text == "" || StdphoneTextbox3.Text == "" || studentcomboBox1.Text == "")
                {
                    MessageBox.Show("Missing Data");
                }
                else
                {
                    con.Open();
                    SqlCommand sd = new SqlCommand("update StudentTab set StdName='" + StdNameTextbox4.Text + "',StudentGender='" + StdcomboBox1.Text + "',StdDOB='" + studentDateTimePicker1.Text + "',StdPhone=" + StdphoneTextbox3.Text + ",StdDep='" + studentcomboBox1.Text + "',StdFees=" + StdfeesTextbox5.Text + " where StdId="+ StdIdTextbox1.Text +"", con);
                    sd.ExecuteNonQuery();
                    MessageBox.Show("student successfully updated");
                    con.Close();
                    populate();

                }

            }
            catch (Exception t)
            { MessageBox.Show("opps..student is not updated pelese try again"); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if ( StdIdTextbox1.Text == "" )
                {
                    MessageBox.Show("Missing Data");
                }
                else
                {
                    con.Open();
                    SqlCommand sd = new SqlCommand("delete from StudentTab  where StdId=" + StdIdTextbox1.Text + "", con);
                    sd.ExecuteNonQuery();
                    MessageBox.Show("student successfully deleted");
                    con.Close();
                    populate();

                }

            }
            catch (Exception t)
            { MessageBox.Show("opps..student is not deleted pelese try again"); }
        }

        private void stdDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            StdIdTextbox1.Text = stdDataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            StdNameTextbox4.Text = stdDataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            StdcomboBox1.Text = stdDataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            studentDateTimePicker1.Text = stdDataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            StdphoneTextbox3.Text = stdDataGridView1.SelectedRows[0].Cells[4].Value.ToString();
           studentcomboBox1.Text = stdDataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            StdfeesTextbox5.Text = stdDataGridView1.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
        private void pop()
        {
            con.Open();
            string query = "select * from   StudentTab where StdFees>0";
            SqlDataAdapter sa = new SqlDataAdapter(query, con);
            SqlCommandBuilder d = new SqlCommandBuilder(sa);
            var s = new DataSet();
            sa.Fill(s);
            stdDataGridView1.DataSource = s.Tables[0];
            con.Close();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            pop();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            populate();
        }
    }
}
