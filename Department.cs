using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace collegesystem
{
    public partial class Department : Form
    {
        public Department()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Server= LENOVO; Database= college;Integrated Security = SSPI; ");
        private void populate()
        {
            con.Open();
            string query = "select * from  Department";
            SqlDataAdapter sa = new SqlDataAdapter(query, con);
            SqlCommandBuilder d = new SqlCommandBuilder(sa);
            var ds = new DataSet();
            sa.Fill(ds);
            DepartGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (namedepTextbox2.Text == "" || descripTextbox4.Text == "" ||durationTextbox1.Text == "")
                {
                    MessageBox.Show("Missing information");
                }
                else
                {
                    con.Open();
                    SqlCommand sd = new SqlCommand("insert into Department  values('" + namedepTextbox2.Text + "','" + descripTextbox4.Text + "'," + durationTextbox1.Text + ")", con);
                    sd.ExecuteNonQuery();
                    MessageBox.Show("Department  successfully added");
                    con.Close();
                    populate();
                }

            }
            catch (Exception)
            { MessageBox.Show("something  went wrong"); }
        }

        private void Department_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (namedepTextbox2.Text == "")
                { MessageBox.Show("enter the department name"); }
                else
                {
                    con.Open();
                    SqlCommand y = new SqlCommand("delete from Department where DepName = '" + namedepTextbox2.Text + "'", con);
                    y.ExecuteNonQuery();
                    MessageBox.Show("the department whose name =" + namedepTextbox2.Text + " is deleted successfully");
                    con.Close();
                    populate();
                }

            }
            catch (Exception)
            { MessageBox.Show("opps... department is not deleted"); }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DepartGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            namedepTextbox2.Text = DepartGridView1.SelectedRows[0].Cells[0].Value.ToString();
            descripTextbox4.Text = DepartGridView1.SelectedRows[0].Cells[1].Value.ToString();
            durationTextbox1.Text = DepartGridView1.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (namedepTextbox2.Text == "" || descripTextbox4.Text == "" || durationTextbox1.Text == "")
                { MessageBox.Show("Missing Data"); }
                else
                {
                    con.Open();
                    SqlCommand y = new SqlCommand("update  Department  set DepDesc='" + descripTextbox4.Text + "',DepDuration='" + durationTextbox1.Text + "'where DepName = '" + namedepTextbox2.Text + "'", con);
                    y.ExecuteNonQuery();
                    MessageBox.Show(" user update successfully");
                    con.Close();
                    populate();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("opps..Department is not updated");
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
