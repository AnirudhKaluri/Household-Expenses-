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
    
    public partial class Expenditure_Analysis : Form
    {

        private string mysqlConnectionString = "Server=173.194.109.118;User=mohanth;password=daddyv66;database=info;";

        MySqlConnection scon = new MySqlConnection(mysqlConnectionString);

        public Expenditure_Analysis()
        {
            InitializeComponent();
        }
        private void Expenditure_Analysis_Load(object sender, EventArgs e)
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
            string qrystring = string.Format("SELECT DATES, {0} FROM records WHERE DATES BETWEEN '{1}' AND '{2}'", comboBox1.Text, dateTimePicker1.Text, dateTimePicker2.Text);
            try
            {
                SqlCommand scom = new SqlCommand(qrystring, scon);
                DataSet ds = new DataSet();
                SqlDataAdapter sda = new SqlDataAdapter(scom);
                sda.Fill(ds, "res");
                dataGridView1.DataSource = ds.Tables["res"];
                scom.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error occured:" + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string qrystring = string.Format("SELECT SUM({0}) FROM records WHERE DATES BETWEEN '{1}' AND '{2}'", comboBox1.Text, dateTimePicker1.Text, dateTimePicker2.Text);
            try
            {
                SqlCommand scom = new SqlCommand(qrystring, scon);
                DataSet ds = new DataSet();
                SqlDataAdapter sda = new SqlDataAdapter(scom);
                sda.Fill(ds, "res");
                dataGridView1.DataSource = ds.Tables["res"];
                scom.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error occured:" + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string qrystring = string.Format("SELECT SUM(TOTAL) FROM records WHERE DATES BETWEEN '{0}' AND '{1}'", dateTimePicker1.Text, dateTimePicker2.Text);
            try
            {
                SqlCommand scom = new SqlCommand(qrystring, scon);
                DataSet ds = new DataSet();
                SqlDataAdapter sda = new SqlDataAdapter(scom);
                sda.Fill(ds, "res");
                dataGridView1.DataSource = ds.Tables["res"];
                scom.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error occured:" + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string qrystring = string.Format("SELECT DATES, {0} FROM records WHERE {0}>{1}", comboBox2.Text, Int32.Parse(textBox1.Text));
            try
            {
                SqlCommand scom = new SqlCommand(qrystring, scon);
                DataSet ds = new DataSet();
                SqlDataAdapter sda = new SqlDataAdapter(scom);
                sda.Fill(ds, "res");
                dataGridView1.DataSource = ds.Tables["res"];
                scom.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error occured:" + ex.Message);
            }
        }
    }
}
