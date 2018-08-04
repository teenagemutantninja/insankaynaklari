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
    public partial class ilanekleisveren : Form
    {
        public ilanekleisveren()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            sirketekle f1 = new sirketekle();
            f1.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ilanekleisveren_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ilanverisverenadi.tbl_ilan' table. You can move, or remove it, as needed.
            this.tbl_ilanTableAdapter.Fill(this.ilanverisverenadi.tbl_ilan);
            // TODO: This line of code loads data into the 'ilanekleisverendataset.tbl_personel' table. You can move, or remove it, as needed.
            this.tbl_personelTableAdapter1.Fill(this.ilanekleisverendataset.tbl_personel);
            // TODO: This line of code loads data into the 'isverenicinaskerlikcinsiyet.tbl_personel' table. You can move, or remove it, as needed.
            this.tbl_personelTableAdapter.Fill(this.isverenicinaskerlikcinsiyet.tbl_personel);
            // TODO: This line of code loads data into the 'ilanverisveren.tbl_Sirket' table. You can move, or remove it, as needed.
            this.tbl_SirketTableAdapter1.Fill(this.ilanverisveren.tbl_Sirket);
            // TODO: This line of code loads data into the 'insankaynaklariDataSet.tbl_Sirket' table. You can move, or remove it, as needed.
            this.tbl_SirketTableAdapter.Fill(this.insankaynaklariDataSet.tbl_Sirket);


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void tblpersonelBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string sirketsehirr = sirketsehir.Text; 
            string isverenadi = isverenaditext.Text;
            string istanimi = istanimitext.Text;
            string departman = departmantext.Text;
            string pozisyon = pozisyontext.Text;
            Int64 maxmas = Convert.ToInt64(maxmaas.Text);
            Int64 minmas = Convert.ToInt64(minmaas.Text);
            string connetionString2 = null;
            string sql2 = null;
            
            connetionString2 = @"Data Source=MACHINE\SQLEXPRESS;Initial Catalog=insankaynaklari;Integrated Security=True";
            using (SqlConnection cnn2 = new SqlConnection(connetionString2))
            {

                sql2 = "Select * from tbl_Sirket Where sirket_adi= '" + isverenadi + "'";
                SqlDataAdapter sda2 = new SqlDataAdapter(sql2, cnn2);
                cnn2.Open();
                SqlDataReader myReader = null;
                DataTable dtbl2 = new DataTable();
                sda2.Fill(dtbl2);
                SqlCommand myCommand = new SqlCommand("select * from tbl_Sirket where sirket_adi='" + isverenadi + "'", cnn2);
                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    sirketadres.Text = (myReader["sirket_adres"].ToString());
                    sirketeposta.Text = (myReader["sirket_eposta"].ToString());
                    sirkettel.Text = (myReader["sirket_no"].ToString());


                }


                DialogResult result = MessageBox.Show("Devam etmek istediğinize emin misiniz?", "İlan Oluştur", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string cinsiyet = null;
                    string askerlik = null;
                    string connetionString = null;
                    string sql = null;
                    int ilanverenisyeri = 1;
                    connetionString = @"Data Source=MACHINE\SQLEXPRESS;Initial Catalog=insankaynaklari;Integrated Security=True";
                    using (SqlConnection cnn = new SqlConnection(connetionString))

                    {
                        sql = "insert into tbl_ilan(ilan_cinsiyet,ilan_departman,ilan_maxmaas,ilan_minmaas,ilan_sirketadi,ilan_askerlik,ilan_pozisyon,ilan_istanim,ilan_sirketadres,ilan_eposta,ilantel,ilanverenisyeri) values(@s1,@s2,@s3,@s4,@s5,@s6,@s7,@s8,@s9,@s10,@s11,@s12)";
                        // p_tc_kimlik, p_isim, p_soy_isim, p_tel, p_adres,
                        // p_cinsiyet, p_departman, personel_dogum_tarihi,
                        // p_egitim, p_askerlik, p_sirketadres, p_eposta, p_ulke,
                        // p_dogumyeri, p_ilgialani, p_referans, p_refiletisim, p_refpoz, p_egitimokuladi, p_egitimbolum,
                        // p_egitimbaslangic, p_egitimbitis, p_notort, p_tecrube, p_tecrubesirketadres,
                        // p_tecrubepozisyon, p_pozisyon, p_dildig, p_resim, p_cv

                        cnn.Open();
                        using (SqlCommand cmd = new SqlCommand(sql, cnn))
                        {

                            if (checkBox1.Checked)
                            {
                                cinsiyet = "Erkek";
                            }
                            if (checkBox3.Checked)
                            {
                                cinsiyet = "Kadın";
                            }
                            if (checkBox1.Checked & checkBox3.Checked)
                            {
                                cinsiyet = "";
                            }
                            if (cinsiyet == null)
                            {
                                MessageBox.Show("Cinsiyet fark etmiyor ise ikisini de seçmelisiniz.");
                            }
                            if (checkBox2.Checked)
                            {
                                askerlik = "Yapılmış olmalı";
                            }
                            else
                            {
                                askerlik = "Fark Etmez";
                            }

                            cmd.Parameters.AddWithValue("@s1", cinsiyet);
                            cmd.Parameters.AddWithValue("@s2", departman);
                            cmd.Parameters.AddWithValue("@s3", minmas);
                            cmd.Parameters.AddWithValue("@s4", maxmas);
                            cmd.Parameters.AddWithValue("@s5", isverenadi);
                            cmd.Parameters.AddWithValue("@s6", askerlik);
                            cmd.Parameters.AddWithValue("@s7", pozisyon);
                            cmd.Parameters.AddWithValue("@s8", istanimi);
                            cmd.Parameters.AddWithValue("@s9", sirketadres.Text);
                            cmd.Parameters.AddWithValue("@s10", sirketeposta.Text);
                            cmd.Parameters.AddWithValue("@s11", sirkettel.Text);
                            cmd.Parameters.AddWithValue("@s12", ilanverenisyeri);

                           // System.Data.SqlClient.SqlException: 'The parameterized query '(@s1 nvarchar(5), @s2 nvarchar(5), @s3 bigint, @s4 bigint, @s5 nvarc' expects the parameter '@s6', which was not supplied.'

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("İlan Başarıyla Eklendi.");
                        }
                    }
                    this.Close();
                }

                if (result == DialogResult.No)
                {
                    //...
                }


            }
        }

        private void minmaas_Leave(object sender, EventArgs e)
        {
            try
            {
                Int64 as1 = Convert.ToInt64(minmaas.Text);
            }
            catch (Exception hataa)
            {
                MessageBox.Show("Ortalama Bilgisini Hatalı Girdiniz");
            }
        }

        private void maxmaas_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Int64 as1 = Convert.ToInt64(maxmaas.Text);
            }
            catch (Exception hataa)
            {
                MessageBox.Show("Ortalama Bilgisini Hatalı Girdiniz");
            }
        }
    }
}
