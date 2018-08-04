using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace IKO
{
    public partial class arailan : Form
    {
        int a = 1;
        int b = 1;
        public arailan()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void arailan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ilaneklepersoneldataaaa.tbl_ilan' table. You can move, or remove it, as needed.
            this.tbl_ilanTableAdapter3.Fill(this.ilaneklepersoneldataaaa.tbl_ilan);
            // TODO: This line of code loads data into the 'ilanpersonel.tbl_ilan' table. You can move, or remove it, as needed.
            this.tbl_ilanTableAdapter2.Fill(this.ilanpersonel.tbl_ilan);
            // TODO: This line of code loads data into the 'ilanisveren.tbl_ilan' table. You can move, or remove it, as needed.
            this.tbl_ilanTableAdapter1.Fill(this.ilanisveren.tbl_ilan);
            // TODO: This line of code loads data into the 'insankaynaklariDataSet6.tbl_ilan' table. You can move, or remove it, as needed.
            this.tbl_ilanTableAdapter.Fill(this.insankaynaklariDataSet6.tbl_ilan);
            dataGridView1.Visible = false;


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            button7.Visible = true;
            button8.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button5.Visible = false;
            button4.Visible = false;
            button6.Visible = true;
            button9.Visible = true;


            dataGridViewsirket.Visible = true;
            dataGridView1.Visible = false;
            string aranan;
            string connetionString = null;


            connetionString = @"Data Source=MACHINE\SQLEXPRESS;Initial Catalog=insankaynaklari;Integrated Security=True";
            using (SqlConnection cnn = new SqlConnection(connetionString))
            {

                cnn.Open();

                aranan = "Select * from tbl_ilan where ilanverenisyeri like '1'";
                SqlDataAdapter adap = new SqlDataAdapter(aranan, cnn);
                DataTable table = new DataTable();
                adap.Fill(table);
                cnn.Close();
                dataGridViewsirket.DataSource = table;
            }


        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            button8.Visible = true;
            button7.Visible = false;
            dataGridViewsirket.Visible = false;
            dataGridView1.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            button5.Visible = true;
            button4.Visible = true;
            button6.Visible = false;
            button9.Visible = false;

            string aranan1;
            string connetionString1 = null;

            connetionString1 = @"Data Source=MACHINE\SQLEXPRESS;Initial Catalog=insankaynaklari;Integrated Security=True";
            using (SqlConnection cnn1 = new SqlConnection(connetionString1))
            {

                cnn1.Open();

                aranan1 = "Select * from tbl_ilan where ilanverenpersonel like '1'";
                SqlDataAdapter ada1p = new SqlDataAdapter(aranan1, cnn1);
                DataTable table1 = new DataTable();
                ada1p.Fill(table1);
                cnn1.Close();
                dataGridView1.DataSource = table1;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Çok Yakında.. :)");
        }

        private void tblilanBindingSource3_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Çok Yakında.. :)");
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                string varsa, aranan;
                string connetionString = null;

                connetionString = @"Data Source=MACHINE\SQLEXPRESS;Initial Catalog=insankaynaklari;Integrated Security=True";
                using (SqlConnection cnn = new SqlConnection(connetionString))
                {
                    cnn.Open();
                    varsa = textBox1.Text;
                    aranan = "Select * from tbl_ilan where ilan_sirketadi like '%" + textBox1.Text + "%'";
                    SqlDataAdapter adap = new SqlDataAdapter(aranan, cnn);
                    DataTable table = new DataTable();
                    adap.Fill(table);
                    cnn.Close();
                    dataGridViewsirket.DataSource = table;
                }
                if (radioButton2.Checked)
                {
                    string var, ara;
                    string connnn = null;

                    connnn = @"Data Source=MACHINE\SQLEXPRESS;Initial Catalog=insankaynaklari;Integrated Security=True";
                    using (SqlConnection cnn = new SqlConnection(connnn))
                    {
                        cnn.Open();
                        var = textBox1.Text;
                        ara = "Select * from tbl_ilan where ilan_personel like '%" + textBox1.Text + "%'";
                        SqlDataAdapter adap = new SqlDataAdapter(ara, cnn);
                        DataTable table = new DataTable();
                        adap.Fill(table);
                        cnn.Close();
                        dataGridView1.DataSource = table;
                    }
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string aranan;
            string connetionString = null;

            connetionString = @"Data Source=MACHINE\SQLEXPRESS;Initial Catalog=insankaynaklari;Integrated Security=True";
            using (SqlConnection cnn = new SqlConnection(connetionString))
            {

                aranan = "Select * from tbl_ilan where ilan_cinsiyet like 'Erkek' and ilan_askerlik like 'Yapıldı'";
                SqlDataAdapter adap = new SqlDataAdapter(aranan, cnn);
                DataTable table = new DataTable();
                adap.Fill(table);
                cnn.Close();
                dataGridView1.DataSource = table;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string aranan;
            string connetionString = null;
            ;
            connetionString = @"Data Source=MACHINE\SQLEXPRESS;Initial Catalog=insankaynaklari;Integrated Security=True";
            using (SqlConnection cnn = new SqlConnection(connetionString))
            {

                aranan = "Select * from tbl_ilan where ilan_askerlik like 'Yapılmadı'";
                SqlDataAdapter adap = new SqlDataAdapter(aranan, cnn);
                DataTable table = new DataTable();
                adap.Fill(table);
                cnn.Close();
                dataGridView1.DataSource = table;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string aranan;
            string connetionString = null;


            connetionString = @"Data Source=MACHINE\SQLEXPRESS;Initial Catalog=insankaynaklari;Integrated Security=True";
            using (SqlConnection cnn = new SqlConnection(connetionString))
            {
                if  (radioButton1.Checked)
                { 
                aranan = "Select * from tbl_ilan where ilan_cinsiyet like 'Erkek'";
                SqlDataAdapter adap = new SqlDataAdapter(aranan, cnn);
                DataTable table = new DataTable();
                adap.Fill(table);
                cnn.Close();
               
                dataGridViewsirket.DataSource = table;
                }
                else
                {
                    aranan = "Select * from tbl_ilan where ilan_cinsiyet like 'Erkek' and ilanverenisyeri like '1'";
                    SqlDataAdapter adap = new SqlDataAdapter(aranan, cnn);
                    DataTable table = new DataTable();
                    adap.Fill(table);
                    cnn.Close();
                    dataGridView1.DataSource = table;
                    
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string aranan;
            string connetionString = null;

            connetionString = @"Data Source=MACHINE\SQLEXPRESS;Initial Catalog=insankaynaklari;Integrated Security=True";
            using (SqlConnection cnn = new SqlConnection(connetionString))
            {

                aranan = "Select * from tbl_ilan where ilan_cinsiyet like 'Kız'";
                SqlDataAdapter adap = new SqlDataAdapter(aranan, cnn);
                DataTable table = new DataTable();
                adap.Fill(table);
                cnn.Close();
                dataGridView1.DataSource = table;
                dataGridViewsirket.DataSource = table;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string aranan;
            string connetionString = null;

            connetionString = @"Data Source=MACHINE\SQLEXPRESS;Initial Catalog=insankaynaklari;Integrated Security=True";
            using (SqlConnection cnn = new SqlConnection(connetionString))
            {

                aranan = "Select * from tbl_ilan;";
                SqlDataAdapter adap = new SqlDataAdapter(aranan, cnn);
                DataTable table = new DataTable();
                adap.Fill(table);
                cnn.Close();
                dataGridView1.DataSource = table;
                
                if (radioButton1.Checked)
                {
                    int iss = 1;
                    aranan = "Select * from tbl_ilan;";
                    SqlDataAdapter dd = new SqlDataAdapter(aranan, cnn);
                    DataTable tb = new DataTable();
                    adap.Fill(tb);
                    cnn.Close();
                    dataGridViewsirket.DataSource = tb;
                }
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            string aranan;
            string connetionString = null;

            connetionString = @"Data Source=MACHINE\SQLEXPRESS;Initial Catalog=insankaynaklari;Integrated Security=True";
            using (SqlConnection cnn = new SqlConnection(connetionString))
            {

                aranan = "Select * from tbl_ilan where ilan_cinsiyet like 'Kız'";
                SqlDataAdapter adap = new SqlDataAdapter(aranan, cnn);
                DataTable table = new DataTable();
                adap.Fill(table);
                cnn.Close();
                dataGridView1.DataSource = table;
                dataGridViewsirket.DataSource = table;
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            string aranan;
            string connetionString = null;

            connetionString = @"Data Source=MACHINE\SQLEXPRESS;Initial Catalog=insankaynaklari;Integrated Security=True";
            using (SqlConnection cnn = new SqlConnection(connetionString))
            {

                aranan = "Select * from tbl_ilan where ilan_cinsiyet like 'Erkek'";
                SqlDataAdapter adap = new SqlDataAdapter(aranan, cnn);
                DataTable table = new DataTable();
                adap.Fill(table);
                cnn.Close();
                dataGridView1.DataSource = table;
                dataGridViewsirket.DataSource = table;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (a == 1)
            {
                dataGridViewsirket.Sort(dataGridViewsirket.Columns[3], ListSortDirection.Ascending);
                a = 2;
            }
            else
            {
                dataGridViewsirket.Sort(dataGridViewsirket.Columns[3], ListSortDirection.Descending);
                a = 1;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (b == 1)
            {

                dataGridViewsirket.Sort(dataGridViewsirket.Columns[4], ListSortDirection.Ascending);
                b = 2;
            }
            else
            {
                dataGridViewsirket.Sort(dataGridViewsirket.Columns[4], ListSortDirection.Descending);
                b = 1;
            }
        }
    }
}
