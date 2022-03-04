using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication2
{
    public partial class accounts : Form
    {
        public accounts()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
           



            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {

                OleDbConnection con = new OleDbConnection();
                con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|res.accdb";
                con.Open();

                string sql = "insert into accs values(" + textBox1.Text + ",'" + textBox2.Text + "','" + textBox3.Text + "')";
                OleDbCommand cmd = new OleDbCommand(sql, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("account DATA SAVED !");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
         
                con.Close();
            }
            catch
            {
                MessageBox.Show("WRONG DATA check once again");

              }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                OleDbConnection con = new OleDbConnection();
                con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|res.accdb";
                con.Open();

                string sql = "delete from accs where emp_id=" + textBox1.Text;
                OleDbCommand cmd = new OleDbCommand(sql, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("DATA deleted !");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
     
                con.Close();
            }
            catch
            {
                MessageBox.Show("not deleted!");

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                OleDbConnection con = new OleDbConnection();
                con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|res.accdb";
                con.Open();

                string sql = "update accs set Usernamee='" + textBox2.Text + "',Passwordd='" + textBox3.Text + "' where emp_id=" + textBox1.Text;
                OleDbCommand cmd = new OleDbCommand(sql, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("DATA updated !");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
             
                con.Close();
            }

            catch
            {
                MessageBox.Show("not updated!");

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            HOME hh = new HOME();
            hh.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection con = new OleDbConnection();
                con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|res.accdb";
                con.Open();

                string sql = "select * from accs where emp_id=" + textBox1.Text;
                OleDbCommand cmd = new OleDbCommand(sql, con);
                OleDbDataReader myread;
                myread = cmd.ExecuteReader();
                myread.Read();
                textBox2.Text = myread.GetValue(1).ToString();
                textBox3.Text = myread.GetString(2);
              con.Close();

            }
            catch
            {
                MessageBox.Show("WRONG DATA");

            }
        }
    }
}
