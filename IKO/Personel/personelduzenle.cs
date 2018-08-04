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
    public partial class personelduzenlee : Form
    {

        public personelduzenlee()
        {

            InitializeComponent();
            groupBox2.Visible = false;
            groupBox1.Visible = false;
            groupBox4.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Int64 tckimlikcombo = Convert.ToInt64(comboBox6.Text);
            string adcombo = comboBox5.Text;

            string connetionString = null;
            string sql = null;
            connetionString = @"Data Source=MACHINE\SQLEXPRESS;Initial Catalog=insankaynaklari;Integrated Security=True";
            using (SqlConnection cnn = new SqlConnection(connetionString))
            {

                sql = "Select * from tbl_personel Where p_tc_kimlik= '" + tckimlikcombo + "'";
                SqlDataAdapter sda = new SqlDataAdapter(sql, cnn);
                cnn.Open();
                SqlDataReader myReader = null;
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                SqlCommand myCommand = new SqlCommand("select * from tbl_personel where p_tc_kimlik='" + tckimlikcombo + "'", cnn);
                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    idtext.Text = (myReader["p_id"].ToString());
                    tckimlik.Text = (myReader["p_tc_kimlik"].ToString());
                    adi.Text = (myReader["p_isim"].ToString());
                    soyadi.Text = (myReader["p_soy_isim"].ToString());
                    ptel.Text = (myReader["p_tel"].ToString());
                    padres.Text = (myReader["p_adres"].ToString());
                    comboBox1.Text = (myReader["p_cinsiyet"].ToString());
                    pdepart.Text = (myReader["p_departman"].ToString());
                    pdogumtar.Text = (myReader["personel_dogum_tarihi"].ToString());
                    comboBox3.Text = (myReader["p_egitim"].ToString());
                    comboBox2.Text = (myReader["p_askerlik"].ToString());
                    peposta.Text = (myReader["p_eposta"].ToString());
                    pulke.Text = (myReader["p_ulke"].ToString());
                    pdogumyer.Text = (myReader["p_dogumyeri"].ToString());
                    textBox16.Text = (myReader["p_ilgialani"].ToString());
                    pokuladi.Text = (myReader["p_egitimokuladi"].ToString());
                    pokulbolum.Text = (myReader["p_egitimbolum"].ToString());
                    pokulbaslangic.Text = (myReader["p_egitimbaslangic"].ToString());
                    pokulbitis.Text = (myReader["p_egitimbitis"].ToString());
                    pokulnot.Text = (myReader["p_notort"].ToString());
                    resimyolut.Text = (myReader["p_resim"].ToString());
                    cvyolut.Text = (myReader["p_cv"].ToString());



                    

                }
                try { 
                Bitmap bmp = new Bitmap(resimyolut.Text);
                pictureBox1.Image = bmp;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                cnn.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Personel Fotoğrafı Yok.");
                }



            }
            groupBox2.Visible = true;
            groupBox1.Visible = true;
            groupBox4.Visible = true;
            
        }

        private void personelduzenlee_Load(object sender, EventArgs e)
        {
           //comboboxlara veri getirir
            this.tbl_personelTableAdapter1.Fill(this.personelduzenleyeni.tbl_personel);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Personel düzenlenecek. Devam etmek ister misiniz?", "Şifre Değiştirme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Int64 id = Convert.ToInt64(idtext.Text);
                String s1 = tckimlik.Text;
                String s2 = adi.Text;

                String s4 = soyadi.Text;
                Int64 s5 = Convert.ToInt64(ptel.Text);
                String s6 = padres.Text;
                String s7 = comboBox1.Text;
                String s8 = pdepart.Text;
                String s9 = pdogumtar.Text;
                String s10 = comboBox3.Text;
                String s11 = comboBox2.Text;
                String s12 = peposta.Text;
                String s13 = pulke.Text;
                String s14 = pdogumyer.Text;
                String s15 = textBox16.Text;
                String s16 = pokuladi.Text;
                String s17 = pokulbolum.Text;
                String s18 = pokulbaslangic.Text;
                String s19 = pokulbitis.Text;
                String s20 = pokulnot.Text;
                String s21 = resimyolut.Text;
                String s22 = cvyolut.Text;

                String strin = @"Data Source=MACHINE\SQLEXPRESS;Initial Catalog=insankaynaklari;Integrated Security=True";
                SqlConnection myConnection = new SqlConnection(strin);

                myConnection.Open();
                String query = "UPDATE tbl_personel SET p_tc_kimlik = @s1,p_isim = @s2,p_soy_isim = @s4,p_tel = @s5,p_adres = @s6,p_cinsiyet = @s7,p_departman = @s8,personel_dogum_tarihi = @s9,p_egitim = @s10,p_askerlik = @s11,p_eposta = @s12,p_ulke = @s13,p_dogumyeri = @s14,p_ilgialani = @s15,p_egitimokuladi = @s16,p_egitimbolum = @s17,p_egitimbaslangic = @s18,p_egitimbitis = @s19,p_notort = @s20,p_resim = @s21,p_cv = @s22 WHERE p_id = (@id);";
                SqlCommand commandEdit = new SqlCommand(query, myConnection);
                commandEdit.Parameters.AddWithValue("@id", id);
                commandEdit.Parameters.AddWithValue("@s1", s1);
                commandEdit.Parameters.AddWithValue("@s2", s2);
                
                commandEdit.Parameters.AddWithValue("@s4", s4);
                commandEdit.Parameters.AddWithValue("@s5", s5);
                commandEdit.Parameters.AddWithValue("@s6", s6);
                commandEdit.Parameters.AddWithValue("@s7", s7);
                commandEdit.Parameters.AddWithValue("@s8", s8);
                commandEdit.Parameters.AddWithValue("@s9", s9);
                commandEdit.Parameters.AddWithValue("@s10", s10);
                commandEdit.Parameters.AddWithValue("@s11", s11);
                commandEdit.Parameters.AddWithValue("@s12", s12);
                commandEdit.Parameters.AddWithValue("@s13", s13);
                commandEdit.Parameters.AddWithValue("@s14", s14);
                commandEdit.Parameters.AddWithValue("@s15", s15);
                commandEdit.Parameters.AddWithValue("@s16", s16);
                commandEdit.Parameters.AddWithValue("@s17", s17);
                commandEdit.Parameters.AddWithValue("@s18", s18);
                commandEdit.Parameters.AddWithValue("@s19", s19);
                commandEdit.Parameters.AddWithValue("@s20", s20);
                commandEdit.Parameters.AddWithValue("@s21", s21);
                commandEdit.Parameters.AddWithValue("@s22", s22);




                commandEdit.ExecuteNonQuery();
                MessageBox.Show("Personel Düzenlendi");

                SqlCommand tete = new SqlCommand(query, myConnection);
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

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog personelcv = new OpenFileDialog();
            personelcv.Filter = "CV Dosyası |*.doc;*.pdf;*.docx |  Tüm Dosyalar |*.*";
            personelcv.ShowDialog();
            string dosyayolu = personelcv.FileName;
            cvyolut.Text = dosyayolu;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Resim Dosyası |*.jpg;*.nef;*.png |  Tüm Dosyalar |*.*";
            dosya.ShowDialog();
            string dosyayolu = dosya.FileName;
            resimyolut.Text = dosyayolu;
            Bitmap bmp = new Bitmap(resimyolut.Text);
            pictureBox1.Image = bmp;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void tckimlik_Leave(object sender, EventArgs e)
        {
            try
            {
                Int64 as1 = Convert.ToInt64(tckimlik.Text);
            }
            catch (Exception hataa)
            {
                MessageBox.Show("Kimlik Numarası Bilgisini Hatalı Girdiniz");
            }
        }

        private void ptel_Leave(object sender, EventArgs e)
        {
            try
            {
                Int64 ss = Convert.ToInt64(ptel.Text);
            }
            catch (Exception hataa)
            {
                MessageBox.Show("Telefon Bilgisini Hatalı Girdiniz");
            }
        }

        private void pokulnot_Leave(object sender, EventArgs e)
        {
            try
            {
                Int64 sss = Convert.ToInt64(pokulnot.Text);
            }
            catch (Exception hataa)
            {
                MessageBox.Show("Ortalama Bilgisini Hatalı Girdiniz");
            }
        }
    }
}
