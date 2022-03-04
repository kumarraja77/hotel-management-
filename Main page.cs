using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class HOME : Form
    {
        public HOME()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void spendsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            spendds S = new spendds();
            S.Show();
            this.Close();
        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            accounts S = new accounts();
            S.Show();
            this.Close();
        }

        private void employeeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            employee S = new employee();
            S.Show();
            this.Close();
        }

        private void itemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            items S = new items();
            S.Show();
            this.Close();
        }

        private void companyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Company S = new Company();
            S.Show();
            this.Close();
        }

        private void storageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Storage hh = new Storage();
            hh.Show();
            this.Close();
        }

        private void saleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sales_Point hh = new Sales_Point();
            hh.Show();
            this.Close();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void aboutUsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Aboutus hh = new Aboutus();
            hh.Show();
            this.Close();
        }

        private void HOME_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 hh = new Form1();
            hh.Show();
            this.Close();
        }

    }

}