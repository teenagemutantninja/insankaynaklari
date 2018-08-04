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
using System.Windows.Forms;


namespace IKO
{
    public partial class duyurukaldir : Form
    {
        public duyurukaldir()
        {
            InitializeComponent();
        }

        private void duyurukaldir_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'duyurudataset.tbl_Duyuru' table. You can move, or remove it, as needed.
            this.tbl_DuyuruTableAdapter1.Fill(this.duyurudataset.tbl_Duyuru);
            // TODO: This line of code loads data into the 'insankaynaklariDataSet3.tbl_Duyuru' table. You can move, or remove it, as needed.
            this.tbl_DuyuruTableAdapter.Fill(this.insankaynaklariDataSet3.tbl_Duyuru);
            

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string varsa, aranan;
            string connetionString = null;

            connetionString = @"Data Source=MACHINE\SQLEXPRESS;Initial Catalog=insankaynaklari;Integrated Security=True";
            using (SqlConnection cnn = new SqlConnection(connetionString))
            {

                cnn.Open();
                varsa = textBox2.Text;
                aranan = "Select * from tbl_Duyuru where d_baslik like '%" + textBox2.Text + "%'";
                SqlDataAdapter adap = new SqlDataAdapter(aranan, cnn);
                DataTable table = new DataTable();
                adap.Fill(table);
                cnn.Close();
                dataGridView1.DataSource = table;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Duyuruyu Silmek İstediğinize Emin misiniz?", "Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                
                SqlConnection sqlcon = new SqlConnection(@"Data Source=MACHINE\SQLEXPRESS;Initial Catalog=insankaynaklari;Integrated Security=True");
                string query = "Select * from tbl_Duyuru Where d_olusturan= '" + comboBox1.Text.Trim() + "' and d_baslik = '" + comboBox2.Text.Trim() + "'";

                SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
                sqlcon.Open();
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);

                if (dtbl.Rows.Count == 1)
                {

                    using (SqlCommand command = sqlcon.CreateCommand())
                    {
                        string silmeSorgusu = "DELETE from tbl_Duyuru Where d_olusturan= '" + comboBox1.Text.Trim() + "' and d_baslik = '" + comboBox2.Text.Trim() + "'";

                        SqlCommand silKomutu = new SqlCommand(silmeSorgusu, sqlcon);
                        silKomutu.ExecuteNonQuery();
                        sqlcon.Close();
                        MessageBox.Show("Duyuru Silindi.");
                        SqlCommand tete = new SqlCommand(silmeSorgusu, sqlcon);
                        try
                        {
                            // tete.ExecuteNonQuery();  
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    this.Close();

                }
              

            }
            else if (result == DialogResult.No)
            {
                //...
            }


        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
          
        }
    }
}
