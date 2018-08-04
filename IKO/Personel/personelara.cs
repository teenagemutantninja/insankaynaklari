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
    public partial class personelaraa : Form
    {
        public personelaraa()
        {
            InitializeComponent();
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
                aranan = "Select * from tbl_personel where p_isim like '%" + textBox1.Text + "%'";
                SqlDataAdapter adap = new SqlDataAdapter(aranan, cnn);
                DataTable table = new DataTable();
                adap.Fill(table);
                cnn.Close();
                dataGridView1.DataSource = table;
            }
        }

        private void personelaraa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'insankaynaklariDataSet5.tbl_personel' table. You can move, or remove it, as needed.
            this.tbl_personelTableAdapter.Fill(this.insankaynaklariDataSet5.tbl_personel);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string aranan;
            string connetionString = null;
            
            connetionString = @"Data Source=MACHINE\SQLEXPRESS;Initial Catalog=insankaynaklari;Integrated Security=True";
            using (SqlConnection cnn = new SqlConnection(connetionString))
            {

                aranan = "Select * from tbl_personel where p_cinsiyet like 'Erkek' and p_askerlik like 'Yapıldı'";
                SqlDataAdapter adap = new SqlDataAdapter(aranan, cnn);
                DataTable table = new DataTable();
                adap.Fill(table);
                cnn.Close();
                dataGridView1.DataSource = table;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string aranan;
            string connetionString = null;
            
            connetionString = @"Data Source=MACHINE\SQLEXPRESS;Initial Catalog=insankaynaklari;Integrated Security=True";
            using (SqlConnection cnn = new SqlConnection(connetionString))
            {

                aranan = "Select * from tbl_personel where p_dil like 'Biliyor'";
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

                aranan = "Select * from tbl_personel where p_cinsiyet like 'Erkek'";
                SqlDataAdapter adap = new SqlDataAdapter(aranan, cnn);
                DataTable table = new DataTable();
                adap.Fill(table);
                cnn.Close();
                dataGridView1.DataSource = table;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string aranan;
            string connetionString = null;
            
            connetionString = @"Data Source=MACHINE\SQLEXPRESS;Initial Catalog=insankaynaklari;Integrated Security=True";
            using (SqlConnection cnn = new SqlConnection(connetionString))
            {

                aranan = "Select * from tbl_personel where p_cinsiyet like 'Kız'";
                SqlDataAdapter adap = new SqlDataAdapter(aranan, cnn);
                DataTable table = new DataTable();
                adap.Fill(table);
                cnn.Close();
                dataGridView1.DataSource = table;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string aranan;
            string connetionString = null;
            ;
            connetionString = @"Data Source=MACHINE\SQLEXPRESS;Initial Catalog=insankaynaklari;Integrated Security=True";
            using (SqlConnection cnn = new SqlConnection(connetionString))
            {

                aranan = "Select * from tbl_personel where p_askerlik not like 'Yapıldı'";
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
            
            connetionString = @"Data Source=MACHINE\SQLEXPRESS;Initial Catalog=insankaynaklari;Integrated Security=True";
            using (SqlConnection cnn = new SqlConnection(connetionString))
            {

                aranan = "Select * from tbl_personel;";
                SqlDataAdapter adap = new SqlDataAdapter(aranan, cnn);
                DataTable table = new DataTable();
                adap.Fill(table);
                cnn.Close();
                dataGridView1.DataSource = table;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string varsa, aranan;
            string connetionString = null;

            connetionString = @"Data Source=MACHINE\SQLEXPRESS;Initial Catalog=insankaynaklari;Integrated Security=True";
            using (SqlConnection cnn = new SqlConnection(connetionString))
            {
                cnn.Open();
                varsa = textBox1.Text;

                aranan = "Select * from tbl_personel where p_egitim like 'Üniversite'";
                SqlDataAdapter adap = new SqlDataAdapter(aranan, cnn);
                DataTable table = new DataTable();
                adap.Fill(table);

                aranan = "Select * from tbl_personel where p_egitim like 'doktora'";
                SqlDataAdapter qwe = new SqlDataAdapter(aranan, cnn);
                qwe.Fill(table);

                aranan = "Select * from tbl_personel where p_egitim like 'lisans'";
                SqlDataAdapter ewq = new SqlDataAdapter(aranan, cnn);
                ewq.Update(table);
                ewq.Fill(table);

                aranan = "Select * from tbl_personel where p_egitim like 'Ön Lisans'";
                SqlDataAdapter ee = new SqlDataAdapter(aranan, cnn);
                ewq.Update(table);
                ee.Fill(table);

               
                dataGridView1.DataSource = table;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string varsa, aranan;
            string connetionString = null;

            connetionString = @"Data Source=MACHINE\SQLEXPRESS;Initial Catalog=insankaynaklari;Integrated Security=True";
            using (SqlConnection cnn = new SqlConnection(connetionString))
            {
                cnn.Open();
                varsa = textBox1.Text;

                aranan = "Select * from tbl_personel where p_egitim like 'lise'";
                SqlDataAdapter adap = new SqlDataAdapter(aranan, cnn);
                DataTable table = new DataTable();
                adap.Fill(table);
                dataGridView1.DataSource = table;
            }

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            string varsa, aranan;
            string connetionString = null;

            connetionString = @"Data Source=MACHINE\SQLEXPRESS;Initial Catalog=insankaynaklari;Integrated Security=True";
            using (SqlConnection cnn = new SqlConnection(connetionString))
            {
                cnn.Open();
                varsa = textBox2.Text;
                aranan = "Select * from tbl_personel where p_tc_kimlik like '%" + textBox2.Text + "%'";
                SqlDataAdapter adap = new SqlDataAdapter(aranan, cnn);
                DataTable table = new DataTable();
                adap.Fill(table);
                cnn.Close();
                dataGridView1.DataSource = table;
            }
        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {
            string varsa, aranan;
            string connetionString = null;

            connetionString = @"Data Source=MACHINE\SQLEXPRESS;Initial Catalog=insankaynaklari;Integrated Security=True";
            using (SqlConnection cnn = new SqlConnection(connetionString))
            {
                cnn.Open();
                varsa = textBox3.Text;
                aranan = "Select * from tbl_personel where p_departman like '%" + textBox3.Text + "%'";
                SqlDataAdapter adap = new SqlDataAdapter(aranan, cnn);
                DataTable table = new DataTable();
                adap.Fill(table);
                cnn.Close();
                dataGridView1.DataSource = table;
            }
        }
    }
}
