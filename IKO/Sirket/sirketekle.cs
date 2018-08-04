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

    public partial class sirketekle : Form
    {
       


        public sirketekle()
        {
            InitializeComponent();
        }
         

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            string sirketadi = sirketaditext.Text;
            string sirketadres = sirketadrestext.Text;
            Int64 sirketno = Convert.ToInt64(sirkettelefontext.Text);
        
            string sirketsektor = sirketsektortext.Text;
            string sirketyonetici = sirketyoneticitext.Text;
            string sirketeposta = sirketepostatext.Text;
            string sirketresimyolu = (resimyolu.Text);

            int aa, bb, cc, dd, ff, gg, pp;
            string a = (String)sirketaditext.Text.ToString();
            string b = (String)sirketadrestext.Text.ToString();
            string c = (String)sirkettelefontext.Text.ToString();
            string d = (String)sirketsektortext.Text.ToString();
            string f = (String)sirketyoneticitext.Text.ToString();
            string g = (String)sirketepostatext.Text.ToString();
            string p = (string)resimyolu.Text.ToString();

            aa = a.Length;
            bb = b.Length;
            cc = c.Length;
            dd = d.Length;
            ff = f.Length;
            gg = g.Length;
            pp = p.Length;

            if (aa == 0 || bb == 0 || cc == 0 || dd == 0 || ff == 0 || gg == 0)
            {
                MessageBox.Show("Tüm alanları doldurmalısınız!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (pp == 0)
            {
                MessageBox.Show("Fotoğraf Eklemelisiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                DialogResult result = MessageBox.Show("İşleme devam etmeye emin misiniz?", "Şirket Oluştur", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string connetionString = null;
                    string sql = null;
                    connetionString = @"Data Source=MACHINE\SQLEXPRESS;Initial Catalog=insankaynaklari;Integrated Security=True";
                    using (SqlConnection cnn = new SqlConnection(connetionString))
                    {
                        sql = "insert into tbl_Sirket(sirket_adi,sirket_adres,sirket_no,sirket_sektor,sirket_yonetici,sirket_eposta,sirket_resimyolu) values(@sirketadi,@sirketadres,@sirketno,@sirketsektor,@sirketyonetici,@sirketeposta,@sirketresimyolu)";
                        cnn.Open();
                        using (SqlCommand cmd = new SqlCommand(sql, cnn))
                        {
                            cmd.Parameters.AddWithValue("@sirketadi", sirketadi);
                            cmd.Parameters.AddWithValue("@sirketadres", sirketadres);
                            cmd.Parameters.AddWithValue("@sirketno", sirketno);
                            cmd.Parameters.AddWithValue("@sirketsektor", sirketsektor);
                            cmd.Parameters.AddWithValue("@sirketyonetici", sirketyonetici);
                            cmd.Parameters.AddWithValue("@sirketeposta", sirketeposta);
                            cmd.Parameters.AddWithValue("@sirketresimyolu", sirketresimyolu);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Şirket Başarıyla Eklendi.");
                        }
                    }
                }

                if (result == DialogResult.No)
                {
                    //...
                }
               
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sirketaditext.Clear();
            sirketadrestext.Clear();
            sirkettelefontext.Clear();
            sirketsektortext.Clear();
            sirketyoneticitext.Clear();
            sirketepostatext.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            { 
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Resim Dosyası |*.jpg;*.nef;*.png |  Tüm Dosyalar |*.*";
            dosya.ShowDialog();
            string dosyayolu = dosya.FileName;
            resimyolu.Text = dosyayolu;
            Bitmap bmp = new Bitmap(resimyolu.Text);
            pictureBox1.Image = bmp;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch(Exception hata)
            {
                ///
            }

        }

        private void sirkettelefontext_Leave(object sender, EventArgs e)
        {
            try
            {
                Int64 as1 = Convert.ToInt64(sirkettelefontext.Text);
            }
            catch (Exception hataa)
            {
                MessageBox.Show("Telefon Bilgisini Hatalı Girdiniz");
            }
        }
    }
}

