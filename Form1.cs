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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection con = new OleDbConnection();
                con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|res.accdb";
                con.Open();

                string sql = "select * from accs where usernamee='" + textBox1.Text + "'AND passwordd='" + textBox2.Text + "'";
                OleDbCommand cmd = new OleDbCommand(sql, con);
                OleDbDataReader myread;
                myread = cmd.ExecuteReader();
                if (myread.Read())
                {

                    con.Close();
                    HOME hh = new HOME();
                    hh.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("WRONG DATA");
                }

            }
            catch
            {
                MessageBox.Show("WRONG DATA");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
