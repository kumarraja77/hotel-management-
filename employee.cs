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
    public partial class employee : Form
    {
        public employee()
        {
            InitializeComponent();
        }

        private void employee_Load(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection con = new OleDbConnection();
                con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|res.accdb";
                con.Open();

                string sql = "select * from employee where emp_id=" + textBox1.Text;
                OleDbCommand cmd = new OleDbCommand(sql, con);
                OleDbDataReader myread;
                myread = cmd.ExecuteReader();
                myread.Read();
                textBox1.Text = myread.GetValue(0).ToString();
                textBox2.Text = myread.GetString(1);
                comboBox2.Text = myread.GetValue(2).ToString();
                comboBox1.Text = myread.GetString(3);
                textBox3.Text = myread.GetString(4);
                textBox4.Text = myread.GetValue(5).ToString();

                textBox5.Text = myread.GetValue(6).ToString();
                

                dateTimePicker1.Text = myread.GetDateTime(7).ToShortDateString();
                con.Close();

            }
            catch
            {
                MessageBox.Show("WRONG DATA");

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            dateTimePicker1.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                OleDbConnection con = new OleDbConnection();
                con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|res.accdb";
                con.Open();

                string sql = "insert into employee values(" + textBox1.Text + ",'" + textBox2.Text + "','" + comboBox2.Text + "','" + comboBox1.Text + "','" + textBox3.Text + "'," + textBox4.Text + "," + textBox5.Text + ",'" + dateTimePicker1.Value.ToShortDateString() + "')";
                OleDbCommand cmd = new OleDbCommand(sql, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("DATA SAVED !");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                dateTimePicker1.Text = "";
                comboBox1.Text = "";
                comboBox2.Text = "";
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

                string sql = "delete from employee where emp_id=" + textBox1.Text;
                OleDbCommand cmd = new OleDbCommand(sql, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("DATA deleted !");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                dateTimePicker1.Text = "";
                comboBox1.Text = "";
                comboBox2.Text = "";
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

                string sql = "update employee set Name='" + textBox2.Text + "',DESIGNATION='" + comboBox2.Text + "',Gender='" + comboBox1.Text + "',address='" + textBox3.Text + "',Salary=" + textBox4.Text + ",Phone_no=" + textBox5.Text + ",datee='" + dateTimePicker1.Value.ToShortDateString() + "' where emp_id=" + textBox1.Text;
                OleDbCommand cmd = new OleDbCommand(sql, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("DATA updated !");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                dateTimePicker1.Text = "";
                comboBox2.Text = "";
                comboBox1.Text = "";
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            try
            {

                OleDbConnection con = new OleDbConnection();
                con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|res.accdb";
                con.Open();

                string sql = "update employee set Name ='" + textBox2.Text + "',DESIGNATION='" + comboBox2.Text + "',Gender='" + comboBox1.Text + "',address='" + textBox3.Text + "',Salary=" + textBox4.Text + ",Phone_no=" + textBox5.Text + ",date='" + dateTimePicker1.Value.ToShortDateString() + "' where emp_id=" + textBox1.Text;
                OleDbCommand cmd = new OleDbCommand(sql, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("DATA updated !");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                dateTimePicker1.Text = "";
                comboBox2.Text = "";
                comboBox1.Text = "";
                con.Close();
            }

            catch
            {
                MessageBox.Show("not updated!");

            }
        }
    }
}
