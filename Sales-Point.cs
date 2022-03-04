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
    public partial class Sales_Point : Form
    {
        public Sales_Point()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
       
                OleDbConnection con = new OleDbConnection();
                con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|res.accdb";
                con.Open();
                string sql = "select item_name from items where Item_name like'" + textBox8.Text + "%'";
                DataSet ds = new DataSet();
                OleDbDataAdapter da = new OleDbDataAdapter(sql, con);
                da.Fill(ds);
                listBox1.DataSource = ds.Tables[0];
                listBox1.DisplayMember = "Item_name";
     
                con.Close();

        }

        private void button8_Click(object sender, EventArgs e)
        {

            HOME hh = new HOME();
            hh.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           




            
        }
            
        private void button1_Click(object sender, EventArgs e)
        {
               int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value);
            }
  
   


            
try


         {
    

             OleDbConnection con = new OleDbConnection();
             con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|res.accdb";
             con.Open();

             string sql = "insert into salespoint(Total,datee,Cust_Ph_no) values(" + sum + ",'" + DateTime.Today.ToShortDateString() + "'," + textBox1.Text + ")";
             OleDbCommand cmd = new OleDbCommand(sql, con);
             cmd.ExecuteNonQuery();
             MessageBox.Show("PAYMENT DONE  !");
              
    
             con.Close();
         }
         catch
         {
             MessageBox.Show("WRONG DATA check once again");

         }
             
        
        
        }

        private void button2_Click(object sender, EventArgs e)
     {
        

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Sales_Point_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            

                OleDbConnection con = new OleDbConnection();
                con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|res.accdb";
                con.Open();
                string sql = "select * from items where Item_name='" + listBox1.Text + "'";
                OleDbDataReader muread;
                OleDbCommand cmd = new OleDbCommand(sql, con);
                muread = cmd.ExecuteReader();
                muread.Read();

                dataGridView1.Rows.Add(muread.GetValue(0).ToString(), muread.GetString(1), muread.GetValue(6).ToString());
           
        }

        private void dataGridView1_Enter(object sender, EventArgs e)
        {
       
        }

        private void Sales_Point_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                int rowindex = dataGridView1.CurrentCell.RowIndex;
                int colindex = dataGridView1.CurrentCell.ColumnIndex;
                dataGridView1.Rows[rowindex].Cells[colindex].Value = int.Parse(dataGridView1.Rows[rowindex].Cells[2].Value.ToString()) * int.Parse(dataGridView1.Rows[rowindex].Cells[3].Value.ToString());
                dataGridView1.Rows[rowindex].Cells[5].Value = DateTime.Today.ToShortDateString();
            }
            catch
            {

            }
        
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
      
        }
    }
}
