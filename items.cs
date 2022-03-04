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
    public partial class items : Form
    {
        public items()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void items_Load(object sender, EventArgs e)
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

                string sql = "select * from items where item_id=" + textBox1.Text;
               
                OleDbCommand cmd = new OleDbCommand(sql, con);
                 OleDbDataReader myread;
                myread = cmd.ExecuteReader();
                myread.Read();
                textBox1.Text = myread.GetValue(0).ToString();
                textBox2.Text = myread.GetString(1);
                textBox3.Text = myread.GetString(2);
                dateTimePicker1.Text = myread.GetDateTime(3).ToShortDateString();
                dateTimePicker2.Text = myread.GetDateTime(4).ToShortDateString();
                textBox4.Text = myread.GetValue(5).ToString();

                textBox5.Text = myread.GetValue(6).ToString();

               
                con.Close();

            }
            catch
            {
                MessageBox.Show("WRONG DATA");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                OleDbConnection con = new OleDbConnection();
                con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|res.accdb";
                con.Open();

                string sql = "insert into items values(" + textBox1.Text + ",'" + textBox2.Text + "','" + textBox3.Text + "','" + dateTimePicker1.Value.ToShortDateString() + "','" + dateTimePicker2.Value.ToShortDateString() + "'," + textBox4.Text + "," + textBox5.Text + ")";
                OleDbCommand cmd = new OleDbCommand(sql, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("DATA SAVED !");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                dateTimePicker1.Text = "";
                dateTimePicker2.Text = "";
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

                string sql = "delete from items where item_id=" + textBox1.Text;
                OleDbCommand cmd = new OleDbCommand(sql, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("DATA deleted");
                
                
                
              
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox5.Clear();
                dateTimePicker1.Text = "";
                dateTimePicker2.Text = "";
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

                  string sql = "update items set Item_name='" + textBox2.Text + "',Company='" + textBox3.Text + "',MFQ='" + dateTimePicker1.Value.ToShortDateString() + "',EXP_Date='" + dateTimePicker2.Value.ToShortDateString() + "',price_in=" + textBox4.Text + ",price_out=" + textBox5.Text + " where Item_Id=" + textBox1.Text;
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
