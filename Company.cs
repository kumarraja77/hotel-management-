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
    public partial class Company : Form
    {
        public Company()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
                 Application.Exit();Application.Exit();
        }

        private void Company_Load(object sender, EventArgs e)
        {
           
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

                string sql = "select * from Company where Company_id=" + textBox1.Text;
                OleDbCommand cmd = new OleDbCommand(sql, con);
                OleDbDataReader myread;
                myread = cmd.ExecuteReader();
                myread.Read();
                textBox1.Text = myread.GetValue(0).ToString();
                textBox2.Text = myread.GetString(1);
                textBox3.Text = myread.GetString(2);
                textBox4.Text = myread.GetValue(3).ToString();
                textBox5.Text = myread.GetString(4);
           
                con.Close();

            }
            catch
            {
                MessageBox.Show("WRONG DATA");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                OleDbConnection con = new OleDbConnection();
                con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|res.accdb";
                con.Open();

                string sql = "insert into company values(" + textBox1.Text + ",'" + textBox2.Text + "','" + textBox3.Text + "'," + textBox4.Text + ",'" + textBox5.Text + "')";
                OleDbCommand cmd = new OleDbCommand(sql, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("DATA SAVED !");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
         
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

                string sql = "delete from company where Company_id=" + textBox1.Text;
                OleDbCommand cmd = new OleDbCommand(sql, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("DATA deleted !");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
       
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

                string sql = "update company set Company_name='" + textBox2.Text + "',Addresss='" + textBox3.Text + "',Phone=" + textBox4.Text + ",E_maill='" + textBox5.Text + "' where Company_id=" + textBox1.Text;
                OleDbCommand cmd = new OleDbCommand(sql, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("DATA updated !");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
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
    }
}
