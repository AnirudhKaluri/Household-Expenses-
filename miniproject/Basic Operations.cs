using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;


namespace miniproject
{
    
    public partial class Basic_Operations : Form
    {
        private string mysqlConnectionString = "Server=173.194.109.118;User=mohanth;password=daddyv66;database=info;";

        MySqlConnection scon = new MySqlConnection(mysqlConnectionString);
        Int64 t;
        public Basic_Operations()
        {
            InitializeComponent();
        }
        
        private void Basic_Operations_Load(object sender, EventArgs e)
        {
            try
            {
                scon.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error occured:" + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            t = Int64.Parse(textBox1.Text) + Int64.Parse(textBox2.Text) + Int64.Parse(textBox3.Text) + Int64.Parse(textBox4.Text) + Int64.Parse(textBox5.Text) + Int64.Parse(textBox6.Text) + Int64.Parse(textBox7.Text) + Int64.Parse(textBox8.Text) + Int64.Parse(textBox9.Text);

            string qrystring = string.Format("INSERT INTO records VALUES ('{0}',{1},{2},{3},{4},{5},{6},{7},{8},{9},{10})",dateTimePicker1.Text,Int64.Parse(textBox1.Text), Int64.Parse(textBox2.Text), Int64.Parse(textBox3.Text), Int64.Parse(textBox4.Text), Int64.Parse(textBox5.Text), Int64.Parse(textBox6.Text), Int64.Parse(textBox7.Text), Int64.Parse(textBox8.Text), Int64.Parse(textBox9.Text),t);
            SqlCommand scom = new SqlCommand(qrystring, scon);
            try
            {
                scom.ExecuteNonQuery();
                scom.Dispose();
                MessageBox.Show("Data successfully stored");
                textBox1.Text = "0";
                textBox2.Text = "0";
                textBox3.Text = "0";
                textBox4.Text = "0";
                textBox5.Text = "0";
                textBox6.Text = "0";
                textBox7.Text = "0";
                textBox8.Text = "0";
                textBox9.Text = "0";
                dateTimePicker1.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error occured:" + ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            string qrystring = string.Format("SELECT * FROM records WHERE DATES='{0}'", dateTimePicker1.Text);
            try
            {
                SqlCommand scom = new SqlCommand(qrystring, scon);
                DataSet ds = new DataSet();
                SqlDataAdapter sda = new SqlDataAdapter(scom);
                sda.Fill(ds, "res");
                dataGridView1.DataSource = ds.Tables["res"];
                dateTimePicker1.Focus();
                scom.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error occured:" + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string qrystring = string.Format(" DELETE FROM records WHERE DATES='{0}'", dateTimePicker1.Text);
            try
            {
                SqlCommand scom = new SqlCommand(qrystring, scon);
                DataSet ds = new DataSet();
                SqlDataAdapter sda = new SqlDataAdapter(scom);
                sda.Fill(ds, "res");
                dataGridView1.DataSource = ds.Tables["res"];
                dateTimePicker1.Focus();
                scom.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error occured:" + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)

        {
            string qrystring = string.Format("SELECT * FROM records");
            try
            {
                SqlCommand scom = new SqlCommand(qrystring, scon);
                DataSet ds = new DataSet();
                SqlDataAdapter sda = new SqlDataAdapter(scom);
                sda.Fill(ds, "res");
                dataGridView1.DataSource = ds.Tables["res"];
                dateTimePicker1.Focus();
                scom.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error occured:" + ex.Message);
            }
        }
    }
}
