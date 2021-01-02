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
using System.Data.Common;

namespace collegesystem
{
    public partial class Fees : Form
    {
        public Fees()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(" ");
        private void fillStdId()
        {
            con.Open();
            SqlCommand sw = new SqlCommand("select StdId from StudentTab", con);
            SqlDataReader red;
            red = sw.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("StdId", typeof(int));
            dt.Load(red);
            feesboBox2.ValueMember = "StdId";
            feesboBox2.DataSource = dt;
            con.Close();
        }
        private void populate()
        {
            con.Open();
            string query = "select * from   FeesTb";
            SqlDataAdapter sa = new SqlDataAdapter(query, con);
            SqlCommandBuilder d = new SqlCommandBuilder(sa);
            var ds = new DataSet();
            sa.Fill(ds);
            feesGridView1.DataSource = ds.Tables[0];
            con.Close();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (feesnumTextbox4.Text == "" || feesnameTextbox5.Text == "" || feesamounTextbox6.Text == "" || feesboBox2.Text == "" || feesDateTimePicker2.Text == "")
                {
                    MessageBox.Show("Missing information");
                }
                else
                {
                    con.Open();
                    SqlDataAdapter f = new SqlDataAdapter("select count(*) from FeesTb where StdId="+feesboBox2.Text +" and  period='" + feesDateTimePicker2.Text + "'", con);
                    DataTable g = new DataTable();
                    f.Fill(g);
                    if (g.Rows[0][0].ToString() == "1")
                    {

                        MessageBox.Show("no dues for the selected period");
                        con.Close();
                    
                    }

                    else
                    {
                       
                        SqlCommand sd = new SqlCommand("insert into  FeesTb values(" + feesnumTextbox4.Text + "," + feesboBox2.Text + ",'" + feesnameTextbox5.Text + "','" + feesDateTimePicker2.Text + "'," + feesamounTextbox6.Text + ")", con);
                        sd.ExecuteNonQuery();
                        MessageBox.Show("fees successfully added");
                        con.Close();
                        populate();
                        updateStd();

                    }
                }

            }

            catch (Exception r)
            { MessageBox.Show("something went wrong please try agian"); }

        }
        private void feesboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Close();
            con.Open();
            SqlCommand d = new SqlCommand("select * from StudentTab where StdId="+ feesboBox2.Text+"", con);
            DataTable ds = new DataTable();
            SqlDataAdapter sa = new SqlDataAdapter(d);
            sa.Fill(ds);
            foreach(DataRow dr in ds.Rows)
            feesnameTextbox5.Text = (string)dr["StdName"];
            con.Close();
        }

        private void feesGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            feesnumTextbox4.Text = feesGridView1.SelectedRows[0].Cells[0].Value.ToString();
            feesboBox2.Text = feesGridView1.SelectedRows[0].Cells[1].Value.ToString();
            feesnameTextbox5.Text = feesGridView1.SelectedRows[0].Cells[2].Value.ToString();
            feesDateTimePicker2.Text = feesGridView1.SelectedRows[0].Cells[3].Value.ToString();
            feesamounTextbox6.Text = feesGridView1.SelectedRows[0].Cells[4].Value.ToString();
          /*if(printDialog1.ShowDialog()== DialogResult.OK)
            {
                printDocument1.Print();
            }*/
        }
        private void updateStd()
        {
            con.Open();
            SqlCommand d = new SqlCommand("update StudentTab set StdFees="+ feesamounTextbox6.Text +" where StdId="+ feesboBox2.Text +"",con);
            d.ExecuteNonQuery();
            con.Close();
        }

        private void Fees_Load(object sender, EventArgs e)
        {
            populate();
            fillStdId();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (feesnumTextbox4.Text == "" ||feesboBox2.Text == "" || feesnameTextbox5.Text == "" || feesDateTimePicker2.Text=="" || feesamounTextbox6.Text=="")
                { MessageBox.Show("Missing Data"); }
                else
                {
                    con.Open();
                    SqlCommand y = new SqlCommand("update  FeesTb  set feesNum=" + feesnumTextbox4.Text + ",StdId=" + feesboBox2.Text + ",StdName='"+feesnameTextbox5.Text +"',Period='"+ feesDateTimePicker2.Text +"',Amount="+feesamounTextbox6.Text+" where feesNum = " +feesnumTextbox4.Text + "", con);
                    y.ExecuteNonQuery();
                    MessageBox.Show(" fees update successfully");
                    con.Close();
                    populate();
                    updateStd();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("opps..fees is not updated pelese try again");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (feesnumTextbox4.Text == "")
                { MessageBox.Show("enter the fees number"); }
                else
                {
                    con.Open();
                    SqlCommand y = new SqlCommand("delete from FeesTb where feesNum = " + feesnumTextbox4.Text + "", con);
                    y.ExecuteNonQuery();
                    MessageBox.Show("the fees whose number =" + feesnumTextbox4.Text + " is deleted successfully");
                    con.Close();
                    populate();
                }

            }
            catch (Exception)
            { MessageBox.Show("opps... fees is not deleted pelese try again"); }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            mainForm d = new mainForm();
            d.Show();
            this.Hide();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
           // e.Graphics.DrawString("Fees RECEIPT", new Font("Century", 25, FontStyle.Bold),Brushes.Red,new Point(230));
        }
    }
}
