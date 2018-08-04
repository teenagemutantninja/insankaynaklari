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
    public partial class personeleklee : Form
    {
        Int64 p_tel;
        Int64 p_notort;
        Int64 p_tc_kimlik;
        public personeleklee()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            // p_tc_kimlik, p_isim, p_soy_isim, p_tel, p_adres,
            // p_cinsiyet, p_departman, personel_dogum_tarihi,
            // p_egitim, p_askerlik, p_sirketadres, p_eposta, p_ulke,
            // p_dogumyeri, p_ilgialani, p_referans, p_refiletisim, p_refpoz, p_egitimokuladi, p_egitimbolum,
            // p_egitimbaslangic, p_egitimbitis, p_notort, p_tecrube, p_tecrubesirketadres,
            // p_tecrubepozisyon, p_pozisyon, p_dildig, p_resim, p_cv           
          
            string p_isim = padi.Text;
            string p_soy_isim = psoy.Text;
            string p_adres = padres.Text;
            string p_cinsiyet = comboBox1.Text;
            string p_departman = pdept.Text;
            DateTime personel_dogum_tarihi = Convert.ToDateTime(pdt.Text);
            string p_askerlik = comboBox2.Text;
            string p_eposta = pep.Text;
            string p_ulke = pul.Text;
            string p_dogumyeri = pdogyer.Text;
            string p_ilgialani = pilgi.Text;
            string p_resim = textBox4.Text;
            string p_dil = null;
            if (checkBox6.Checked)
            {
                p_dil = "Biliyor";
            }
            else
            {
                p_dil = "Bilmiyor";
            }
            string p_egitim = comboBox3.Text;
            string p_egitimokuladi = pokul.Text;
            string p_egitimbolum = pokulbolum.Text;
            DateTime p_egitimbaslangic = Convert.ToDateTime(egitimbaslangic.Text);
            DateTime p_egitimbitis = Convert.ToDateTime(egitimbitis.Text);

           
            string p_dildig = pdil.Text;
            string p_tecrube = ptecrubesirketadi.Text;
            string p_tecrubepozisyon = ppozisyon.Text;
            string p_tecrubesirketadres = ptecrubeadres.Text;
            string p_referans = prefad.Text;
            string p_refiletisim = prefil.Text;
            string p_refpoz = prefpoz.Text;
            string p_cv = textBox19.Text;


            DialogResult result = MessageBox.Show("Personel oluşturulsun mu?", "Personel Oluştur", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                

                string connetionString = null;
                string sql = null;
                connetionString = @"Data Source=MACHINE\SQLEXPRESS;Initial Catalog=insankaynaklari;Integrated Security=True";
                using (SqlConnection cnn = new SqlConnection(connetionString))
                {
                    sql = "insert into tbl_personel(p_dil,p_tc_kimlik,p_isim,p_soy_isim,p_tel,p_adres,p_cinsiyet,p_departman,personel_dogum_tarihi,p_egitim,p_askerlik,p_eposta,p_ulke,p_dogumyeri,p_ilgialani,p_referans,p_refiletisim,p_refpoz,p_egitimokuladi,p_egitimbolum,p_egitimbaslangic,p_egitimbitis,p_notort,p_tecrube,p_tecrubesirketadres,p_tecrubepozisyon,p_dildig,p_resim,p_cv) values(@p_dil,@p_tc_kimlik,@p_isim,@p_soy_isim,@p_tel,@p_adres,@p_cinsiyet,@p_departman,@personel_dogum_tarihi,@p_egitim,@p_askerlik,@p_eposta,@p_ulke,@p_dogumyeri,@p_ilgialani,@p_referans,@p_refiletisim,@p_refpoz,@p_egitimokuladi,@p_egitimbolum,@p_egitimbaslangic,@p_egitimbitis,@p_notort,@p_tecrube,@p_tecrubesirketadres,@p_tecrubepozisyon,@p_dildig,@p_resim,@p_cv)";
                    // p_tc_kimlik, p_isim, p_soy_isim, p_tel, p_adres,
                    // p_cinsiyet, p_departman, personel_dogum_tarihi,
                    // p_egitim, p_askerlik, p_sirketadres, p_eposta, p_ulke,
                    // p_dogumyeri, p_ilgialani, p_referans, p_refiletisim, p_refpoz, p_egitimokuladi, p_egitimbolum,
                    // p_egitimbaslangic, p_egitimbitis, p_notort, p_tecrube, p_tecrubesirketadres,
                    // p_tecrubepozisyon, p_pozisyon, p_dildig, p_resim, p_cv

                    cnn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, cnn))
                    {
                        cmd.Parameters.AddWithValue("@p_tc_kimlik", p_tc_kimlik);
                        cmd.Parameters.AddWithValue("@p_isim", p_isim);
                        cmd.Parameters.AddWithValue("@p_soy_isim", p_soy_isim);
                        cmd.Parameters.AddWithValue("@p_tel", p_tel);
                        cmd.Parameters.AddWithValue("@p_adres", p_adres);
                        cmd.Parameters.AddWithValue("@p_cinsiyet", p_cinsiyet);
                        cmd.Parameters.AddWithValue("@personel_dogum_tarihi", personel_dogum_tarihi);
                        cmd.Parameters.AddWithValue("@p_egitim", p_egitim);
                        cmd.Parameters.AddWithValue("@p_askerlik", p_askerlik);
                        cmd.Parameters.AddWithValue("@p_departman", p_departman);
                        cmd.Parameters.AddWithValue("@p_dil", p_dil);

                        cmd.Parameters.AddWithValue("@p_eposta", p_eposta);
                        cmd.Parameters.AddWithValue("@p_ulke", p_ulke);
                        cmd.Parameters.AddWithValue("@p_dogumyeri", p_dogumyeri);
                        cmd.Parameters.AddWithValue("@p_ilgialani", p_ilgialani);

                        cmd.Parameters.AddWithValue("@p_referans", p_referans);
                        cmd.Parameters.AddWithValue("@p_egitimokuladi", p_egitimokuladi);
                        cmd.Parameters.AddWithValue("@p_egitimbolum", p_egitimbolum);
                        cmd.Parameters.AddWithValue("@p_egitimbaslangic", p_egitimbaslangic);
                        cmd.Parameters.AddWithValue("@p_egitimbitis", p_egitimbitis);

                        cmd.Parameters.AddWithValue("@p_refiletisim", p_refiletisim);
                        cmd.Parameters.AddWithValue("@p_refpoz", p_refpoz);

                        cmd.Parameters.AddWithValue("@p_notort", p_notort);
                        cmd.Parameters.AddWithValue("@p_tecrube", p_tecrube);
                        cmd.Parameters.AddWithValue("@p_tecrubesirketadres", p_tecrubesirketadres);
                        cmd.Parameters.AddWithValue("@p_tecrubepozisyon", p_tecrubepozisyon);

                        cmd.Parameters.AddWithValue("@p_dildig", p_dildig);
                        cmd.Parameters.AddWithValue("@p_resim", p_resim);
                        cmd.Parameters.AddWithValue("@p_cv", p_cv);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Personel Başarıyla Eklendi.");
                    }
                }
                this.Close();
            }

            if (result == DialogResult.No)
            {
                //...
            }






        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Resim Dosyası |*.jpg;*.nef;*.png |  Tüm Dosyalar |*.*";
            dosya.ShowDialog();
            string dosyayolu = dosya.FileName;
            textBox4.Text = dosyayolu;
            Bitmap bmp = new Bitmap(textBox4.Text);
            pictureBox1.Image = bmp;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog personelcv = new OpenFileDialog();
            personelcv.Filter = "CV Dosyası |*.doc;*.pdf;*.docx |  Tüm Dosyalar |*.*";
            personelcv.ShowDialog();
            string dosyayolu = personelcv.FileName;
            textBox19.Text = dosyayolu;
            
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            string p_dil = "";
            if (checkBox6.Checked)
            {
                p_dil = "Biliyor";
            }
            else
            {
                p_dil = "Bilmiyor";
            }
            
        }

        

        private void ptel_Leave(object sender, EventArgs e)
        {
            try
            {
                p_tel = Convert.ToInt64(ptel.Text);
            }
            catch (Exception ptelhata)
            {
                MessageBox.Show("Telefon Bilgisini Hatalı Girdiniz");
            }
        }

        private void ptctext_Leave(object sender, EventArgs e)
        {
            try
            {
                p_tc_kimlik = Convert.ToInt64(ptctext.Text);
            }
            catch (Exception hataa)
            {
                MessageBox.Show("Kimlik Bilgisini Hatalı Girdiniz");
            }
        }

        private void notort_Leave(object sender, EventArgs e)
        {
            try
            {
                p_notort = Convert.ToInt64(notort.Text);
            }
            catch (Exception hataa)
            {
                MessageBox.Show("Ortalama Bilgisini Hatalı Girdiniz");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ptctext_Leave_1(object sender, EventArgs e)
        {
            try
            {
                p_tc_kimlik = Convert.ToInt64(ptctext.Text);
            }
            catch (Exception hataa)
            {
                MessageBox.Show("Kimlik Bilgisini Hatalı Girdiniz");
            }
        }
    }
}
