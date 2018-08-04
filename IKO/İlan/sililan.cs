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
    public partial class sililan : Form
    {
        public sililan()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView2.Visible = true;
            dataGridView1.Visible = false;
            textBox2.Visible = true;
            textBox2.Enabled = true;
            textBox1.Visible = false;
            label2.Visible = true;
            textBox1.Enabled = false;

            label1.Visible = true;
            label3.Visible = true;
            label6.Visible = false;
            label5.Visible = false;

            string aranan;
            string connetionString = null;
            comboBox1.Visible = true;
            comboBox2.Visible = true;
            comboBox1.Enabled = true;
            comboBox2.Enabled = true;


            comboBox3.Visible = false;
            comboBox4.Visible = false;



            connetionString = @"Data Source=MACHINE\SQLEXPRESS;Initial Catalog=insankaynaklari;Integrated Security=True";
            using (SqlConnection cnn = new SqlConnection(connetionString))
            {

                cnn.Open();

                aranan = "Select * from tbl_ilan where ilanverenisyeri like '1'";
                SqlDataAdapter adap = new SqlDataAdapter(aranan, cnn);
                DataTable table = new DataTable();
                adap.Fill(table);
                cnn.Close();
                dataGridView2.DataSource = table;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            label2.Visible = true;
            textBox2.Enabled = false;
            textBox1.Visible = true;
            textBox1.Enabled = true;

            label1.Visible = false;
            label3.Visible = false;
            label6.Visible = true;
            label5.Visible = true;

            dataGridView2.Visible = false;
            dataGridView1.Visible = true;
            string aranan1;
            string connetionString1 = null;
            comboBox1.Visible = false;
            comboBox2.Visible = false;
            comboBox3.Visible = true;
            comboBox4.Visible = true;
            comboBox3.Enabled = true;
            comboBox4.Enabled = true;

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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string var, ara;
            string connetionString = null;

            connetionString = @"Data Source=MACHINE\SQLEXPRESS;Initial Catalog=insankaynaklari;Integrated Security=True";
            using (SqlConnection cn = new SqlConnection(connetionString))
            {
                cn.Open();
                var = textBox2.Text;
                ara = "Select * from tbl_ilan where ilan_sirketadi like '%" + textBox2.Text + "%'";
                SqlDataAdapter ada = new SqlDataAdapter(ara, cn);
                DataTable tab = new DataTable();
                ada.Fill(tab);
                cn.Close();
                dataGridView1.DataSource = tab;
            }
        }

        private void sililan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ilankaldirdataset.tbl_ilan' table. You can move, or remove it, as needed.
            this.tbl_ilanTableAdapter4.Fill(this.ilankaldirdataset.tbl_ilan);
            // TODO: This line of code loads data into the 'ilaneklepersoneldataaaa1.tbl_ilan' table. You can move, or remove it, as needed.
            this.tbl_ilanTableAdapter3.Fill(this.ilaneklepersoneldataaaa1.tbl_ilan);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //işveren
            if(radioButton1.Checked)
            { 
                 DialogResult result = MessageBox.Show("İlanı kaldırmak istediğinizden emin misiniz?", "İlan Kaldır", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                 if (result == DialogResult.Yes)
                 {
                     SqlConnection sqlcon = new SqlConnection(@"Data Source=MACHINE\SQLEXPRESS;Initial Catalog=insankaynaklari;Integrated Security=True");
                     string query = "Select * from tbl_ilan Where ilan_sirketadi= '" + comboBox1.Text + "' and ilanno = '" + comboBox2.Text + "'";

                     SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
                        sqlcon.Open();
                     DataTable dtbl = new DataTable();
                        sda.Fill(dtbl);

                     if (dtbl.Rows.Count == 1)
                     {

                         using (SqlCommand command = sqlcon.CreateCommand())
                         {
                             string silmeSorgusu = "DELETE from tbl_ilan Where ilan_sirketadi= '" + comboBox1.Text + "' and ilanno = '" + comboBox2.Text + "'";

                            SqlCommand silKomutu = new SqlCommand(silmeSorgusu, sqlcon);
                             silKomutu.ExecuteNonQuery();
                             sqlcon.Close();
                             MessageBox.Show("Kayıt Silindi...");
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


                     }
                     else
                     {
                           MessageBox.Show("Böyle bir şey kayıtlarda yok. Lütfen Tekrar Deneyiniz.");
                     }


                 }
                else if (result == DialogResult.No)
                {
                //...
                }
                this.Close();
            }
            
            //iş arayan personel
            if (radioButton2.Checked)
            {
                DialogResult result = MessageBox.Show("İlanı kaldırmak istediğinizden emin misiniz?", "İlan Kaldır", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    SqlConnection sqlcon = new SqlConnection(@"Data Source=MACHINE\SQLEXPRESS;Initial Catalog=insankaynaklari;Integrated Security=True");
                    string query = "Select * from tbl_ilan Where ilan_departman= '" + comboBox3.Text + "' and ilan_basvuranpersonelid = '" + comboBox4.Text + "'";

                    SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
                    sqlcon.Open();
                    DataTable dtbl = new DataTable();
                    sda.Fill(dtbl);

                    if (dtbl.Rows.Count == 1)
                    {

                        using (SqlCommand command = sqlcon.CreateCommand())
                        {
                            string silmeSorgusu = "DELETE from tbl_ilan Where ilan_departman= '" + comboBox3.Text + "' and ilan_basvuranpersonelid = '" + comboBox4.Text + "'";

                            SqlCommand silKomutu = new SqlCommand(silmeSorgusu, sqlcon);
                            silKomutu.ExecuteNonQuery();
                            sqlcon.Close();
                            MessageBox.Show("Kayıt Silindi...");
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


                    }
                    else
                    {
                        MessageBox.Show("Böyle bir kullanıcı kayıtlarda yok. Lütfen Tekrar Deneyiniz.");
                    }


                }
                else if (result == DialogResult.No)
                {
                    //...
                }
                this.Close();
            }
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
                aranan = "Select * from tbl_ilan where ilan_departman like '%" + textBox1.Text + "%'";
                SqlDataAdapter adap = new SqlDataAdapter(aranan, cnn);
                DataTable table = new DataTable();
                adap.Fill(table);
                cnn.Close();
                dataGridView1.DataSource = table;
            }
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
                aranan = "Select * from tbl_ilan where ilan_sirketadi like '%" + textBox2.Text + "%'";
                SqlDataAdapter adap = new SqlDataAdapter(aranan, cnn);
                DataTable table = new DataTable();
                adap.Fill(table);
                cnn.Close();
                dataGridView2.DataSource = table;
            }
        }
    }
}
