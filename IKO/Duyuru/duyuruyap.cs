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
    
    public partial class duyuruyap : Form
    {
        public static int duyuru;
        DateTime tarih = DateTime.Now;
        public duyuruyap()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            duyuru = 3;
            Int64 baslikuzunluk, icerikuzunluk;
            string baslik = basliktext.Text;
            string icerik = iceriktext.Text;
            baslikuzunluk = baslik.Length;
            icerikuzunluk = icerik.Length;
            string olusturucu = login.user;
            if (baslikuzunluk == 0 || icerikuzunluk == 0)
            {
                MessageBox.Show("Tüm alanları doldurmalısınız!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult result = MessageBox.Show("İşleme devam etmeye emin misiniz?", "Kullanıcı Oluştur", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string connetionString = null;
                    string sql = null;
                    connetionString = @"Data Source=MACHINE\SQLEXPRESS;Initial Catalog=insankaynaklari;Integrated Security=True";
                    using (SqlConnection cnn = new SqlConnection(connetionString))
                    {
                        sql = "insert into tbl_Duyuru (d_baslik,d_icerik,d_tarih,d_olusturan) values(@d_baslik,@d_icerik,@d_tarih,@d_olusturan)";
                        cnn.Open();
                        using (SqlCommand cmd = new SqlCommand(sql, cnn))
                        {
                            cmd.Parameters.AddWithValue("d_olusturan", olusturucu);
                            cmd.Parameters.AddWithValue("@d_baslik", baslik);
                            cmd.Parameters.AddWithValue("@d_icerik", icerik);
                            cmd.Parameters.AddWithValue("@d_tarih", tarih);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Duyuru Başarıyla Yapıldı.");
                        }
                    }
                }

                else if (result == DialogResult.No)
                {
                    //...
                }
            }

        }
    }
}
