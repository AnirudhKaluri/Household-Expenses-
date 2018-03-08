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
    public partial class Modify_Record : Form
    {
        private string mysqlConnectionString = "Server=173.194.109.118;User=mohanth;password=daddyv66;database=info;";

        MySqlConnection scon = new MySqlConnection(mysqlConnectionString);

        public Modify_Record()
        {
            InitializeComponent();
        }

        private void Modify_Record_Load(object sender, EventArgs e)
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

    

        private void button1_Click_1(object sender, EventArgs e)
        {
            string qrystring = string.Format("UPDATE records SET {0}={1} WHERE DATES='{2}'", ComboBox1.Text, Int64.Parse(textBox1.Text), dateTimePicker1.Text);
            try
            {
                SqlCommand scom = new SqlCommand(qrystring, scon);
                scom.ExecuteNonQuery();
                scom.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error occured in updating specified column:" + ex.Message);
            }
            qrystring = string.Format("UPDATE records SET TOTAL=FOOD+CLOTHING+GROCERY+RENT+ELECTRONICS+MAINTENANCE+EDUCATION+MEDICAL+CONVEYANCE WHERE DATES='{0}'", dateTimePicker1.Text);
            try
            {
                SqlCommand scom2 = new SqlCommand(qrystring, scon);
                scom2.ExecuteNonQuery();
                scom2.Dispose();
                MessageBox.Show("RECORD MODIFIED/UPDATED");
                textBox1.Text = "0";
                dateTimePicker1.Focus();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("error occured in updating TOTAL column:" + ex.Message);
            }
        }
    }
}
