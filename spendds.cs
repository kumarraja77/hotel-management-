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
    public partial class spendds : Form
    {
        public spendds()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection con = new OleDbConnection();
                con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|res.accdb";
                con.Open();

                string sql = "select * from spends where s_id=" + textBox1.Text ;
                OleDbCommand cmd = new OleDbCommand(sql, con);
                OleDbDataReader myread;
                myread = cmd.ExecuteReader();
                myread.Read();
                textBox2.Text = myread.GetValue(1).ToString();
                textBox3.Text = myread.GetString(2);
                textBox4.Text = myread.GetValue(3).ToString();
                dateTimePicker1.Text = myread.GetDateTime(4).ToShortDateString();
                con.Close();
              
            }
            catch
            {
                MessageBox.Show("WRONG DATA");

            }
        }

        private void spendds_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            dateTimePicker1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                OleDbConnection con = new OleDbConnection();
                con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|res.accdb";
                con.Open();

                string sql = "insert into spends values(" + textBox1.Text + "," + textBox2.Text + ",'" + textBox3.Text + "'," + textBox4.Text + ",'" + dateTimePicker1.Value.ToShortDateString() + "')";
                OleDbCommand cmd = new OleDbCommand(sql, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("DATA SAVED !");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                dateTimePicker1.Text = "";
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

                string sql = "delete from spends where s_id=" + textBox1.Text;
                OleDbCommand cmd = new OleDbCommand(sql, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("DATA deleted !");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                dateTimePicker1.Text = "";
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

                string sql = "update spends set emp_id=" + textBox2.Text + ",Reason='" + textBox3.Text + "',amountt=" + textBox4.Text + ",Datee='" + dateTimePicker1.Value.ToShortDateString() + "' where s_id=" + textBox1.Text;
                OleDbCommand cmd = new OleDbCommand(sql, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("DATA updated !");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                dateTimePicker1.Text = "";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
           
        
        }
    }

