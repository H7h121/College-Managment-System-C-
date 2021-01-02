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
    public partial class teachers : Form
    {
        public teachers()
        {
            InitializeComponent();
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void gunaDateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            mainForm d = new mainForm();
            d.Show();
            this.Hide();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection(" ");
        private void fillDepNmae()
        {
            con.Open();
            SqlCommand sw = new SqlCommand("select DepName from Department", con);
            SqlDataReader red;
            red = sw.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("DepName", typeof(string));
            dt.Load(red);
            comboBox2.ValueMember = "DepName";
            comboBox2.DataSource = dt;
            con.Close();
        }
        private void teachers_Load(object sender, EventArgs e)
        {
            fillDepNmae();
            populate();
        }
        private void populate()
        {
            con.Open();
            string query = "select * from   Teachertab";
            SqlDataAdapter sa = new SqlDataAdapter(query, con);
            SqlCommandBuilder d = new SqlCommandBuilder(sa);
            var s = new DataSet();
            sa.Fill(s);
            gunaDataGridView1.DataSource = s.Tables[0];
            con.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (teacheridTextbox1.Text == "" || teachernameTextbox2.Text == "" || comboBox1.Text == "" ||teacherphTextbox4.Text == "" || gunaDateTimePicker1.Text == "" ||teachaddextbox3.Text == "" || comboBox2.Text == "")
                {
                    MessageBox.Show("Missing information");
                }
                else
                {
                    con.Open();
                    SqlCommand sd = new SqlCommand("insert into Teachertab values(" + teacheridTextbox1.Text + ",'" + teachernameTextbox2.Text + "','" + comboBox1.Text + "','" + gunaDateTimePicker1.Text + "'," + teacherphTextbox4.Text + ",'" + comboBox2.Text + "','" + teachaddextbox3.Text + "')", con);
                    sd.ExecuteNonQuery();
                    MessageBox.Show("teacher successfully added");
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
                if (teacheridTextbox1.Text == "" || teachernameTextbox2.Text == "" || comboBox1.Text == "" || teacherphTextbox4.Text == "" || gunaDateTimePicker1.Text == "" || teachaddextbox3.Text == "" || comboBox2.Text == "")
                {
                    MessageBox.Show("Missing Data");
                }
                else
                {
                    con.Open();
                    SqlCommand sd = new SqlCommand("update  Teachertab set TeacherName='" + teachernameTextbox2.Text + "',TeacherGender='" + comboBox1.Text + "',TeacherDOB='" + gunaDateTimePicker1.Text + "',TeacherPhone=" + teacherphTextbox4.Text + ",TeacherDep='" + comboBox2.Text + "',TeacherADD='" + teachaddextbox3.Text + "'where TeacherId="+ teacheridTextbox1.Text +"", con);
                    sd.ExecuteNonQuery();
                    MessageBox.Show("teacher successfully updated");
                    con.Close();
                    
                    populate();

                }

            }
            catch (Exception r)
            { MessageBox.Show("opps..teacher is not updated pelese try again"); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (teacheridTextbox1.Text == "" || teachernameTextbox2.Text == "" || comboBox1.Text == "" || teacherphTextbox4.Text == "" || gunaDateTimePicker1.Text == "" || teachaddextbox3.Text == "" || comboBox2.Text == "")
                {
                    MessageBox.Show("Missing Data");
                }
                else
                {
                    con.Open();
                    SqlCommand sd = new SqlCommand("delete from  Teachertab where TeacherId=" + teacheridTextbox1.Text + "", con);
                    sd.ExecuteNonQuery();
                    MessageBox.Show("teacher successfully deleted");
                    con.Close();

                    populate();

                }

            }
            catch (Exception r)
            { MessageBox.Show("opps..teacher is not deleted pelese try again"); }
        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            teacheridTextbox1.Text = gunaDataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            teachernameTextbox2.Text = gunaDataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            comboBox1.Text = gunaDataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            gunaDateTimePicker1.Text = gunaDataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            teacherphTextbox4.Text = gunaDataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            comboBox2.Text = gunaDataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            teachaddextbox3.Text = gunaDataGridView1.SelectedRows[0].Cells[6].Value.ToString();
        }
    }
}
