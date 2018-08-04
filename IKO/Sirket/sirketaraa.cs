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
using System.Data.Common;
using System.Data.SqlClient;
using System.Configuration;


namespace IKO
{
    public partial class sirketaraa : Form
    {
        int a = 1;
        int b = 1;
        int c = 1;

        public sirketaraa()
        {
            InitializeComponent();
        }

        private void sirketaraa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'insankaynaklariDataSet2.tbl_Sirket' table. You can move, or remove it, as needed.
            this.tbl_SirketTableAdapter.Fill(this.insankaynaklariDataSet2.tbl_Sirket);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string varsa, aranan;
            string connetionString = null;
            
            connetionString = @"Data Source=MACHINE\SQLEXPRESS;Initial Catalog=insankaynaklari;Integrated Security=True";
            using (SqlConnection cnn = new SqlConnection(connetionString))
            { 
                
                cnn.Open();
            varsa = textBox1.Text;
            aranan = "Select * from tbl_Sirket where sirket_adi like '%" + textBox1.Text + "%'";
            SqlDataAdapter adap = new SqlDataAdapter(aranan, cnn);
            DataTable table = new DataTable();
            adap.Fill(table);
            cnn.Close();
            dataGridView1.DataSource = table;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(100)))));
           
          
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            
            this.button1.UseVisualStyleBackColor = false;
            
            if (a == 1)
            {
                dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Ascending);
                a = 2;
            }
            else
            {
                dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Descending);
                a = 1;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (b == 1)
            {
             
                dataGridView1.Sort(dataGridView1.Columns[5], ListSortDirection.Ascending);
                b = 2;
            }
            else
            {
                dataGridView1.Sort(dataGridView1.Columns[5], ListSortDirection.Descending);
                b = 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (c == 1)
            {
                dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
                c = 2;
            }
            else
            {
              
                dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Descending);
                c = 1;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
