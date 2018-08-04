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
    public partial class ilaneklepersonel : Form
    {
        
        public ilaneklepersonel()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string tarihh = DateTime.Today.ToString("M/d/yyyy");
            string persa = personeladi.Text;
            string perss = personelsoyadi.Text;
            Int64 perst = Convert.ToInt64(personeltc.Text);
            string pid = personelid.Text;
            string resim = personelresim.Text;

            string connetionString2 = null;
            string sql2 = null;
          
            connetionString2 = @"Data Source=MACHINE\SQLEXPRESS;Initial Catalog=insankaynaklari;Integrated Security=True";
            using (SqlConnection cnn2 = new SqlConnection(connetionString2))
            {

                sql2 = "Select * from tbl_personel Where p_tc_kimlik= '" + perst + "'";
                SqlDataAdapter sda2 = new SqlDataAdapter(sql2, cnn2);
                cnn2.Open();
                SqlDataReader myReader = null;
                DataTable dtbl2 = new DataTable();
                sda2.Fill(dtbl2);
                SqlCommand myCommand = new SqlCommand("select * from tbl_personel where p_tc_kimlik='" + perst + "'", cnn2);
                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    personelid.Text = (myReader["p_id"].ToString());
                    cinsiyetttt.Text = (myReader["p_cinsiyet"].ToString());
                    psehir.Text = (myReader["p_dogumyeri"].ToString());
                    paskerlik.Text = (myReader["p_askerlik"].ToString());
                    pdepartman.Text = (myReader["p_departman"].ToString());
                    ppozisyon.Text = (myReader["p_pozisyon"].ToString());
                    p_telefon.Text = (myReader["p_tel"].ToString());
                    posta.Text = (myReader["p_eposta"].ToString());
                    personelresim.Text = (myReader["p_resim"].ToString());




                }
                cnn2.Close();
                
                DialogResult result = MessageBox.Show("Devam etmek istediğinize emin misiniz?", "İlan Oluştur", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string connetionString = null;
                    string sql = null;
                    
                    int ilanverenpersonel = 1;
                    Int64 ilanverenpersonelid = Convert.ToInt64(personelid.Text);
                    string persnltlfn = p_telefon.Text;
                    connetionString = @"Data Source=MACHINE\SQLEXPRESS;Initial Catalog=insankaynaklari;Integrated Security=True";
                    using (SqlConnection cnn = new SqlConnection(connetionString))

                    {
                        sql = "insert into tbl_ilan(ilan_tarih,ilan_personel,ilan_cinsiyet,ipersonelsehir,ilan_askerlik,ilan_departman,ilan_pozisyon,ilantel,ilan_eposta,ilanverenpersonel,ilan_basvuranpersonelid) values (@s1,@s2,@s3,@s4,@s5,@s6,@s7,@s8,@s9,@s10,@s11)";
                       
                        cnn.Open();
                        using (SqlCommand cmd = new SqlCommand(sql, cnn))
                        {
                            cmd.Parameters.AddWithValue("@s1", Convert.ToDateTime(tarihh));
                            cmd.Parameters.AddWithValue("@s2", personeladi.Text);
                            cmd.Parameters.AddWithValue("@s3", cinsiyetttt.Text);
                            cmd.Parameters.AddWithValue("@s4", psehir.Text);
                            cmd.Parameters.AddWithValue("@s5", paskerlik.Text);
                            cmd.Parameters.AddWithValue("@s6", pdepartman.Text);
                            cmd.Parameters.AddWithValue("@s7", ppozisyon.Text);
                            cmd.Parameters.AddWithValue("@s8", p_telefon.Text);
                            cmd.Parameters.AddWithValue("@s9", posta.Text);
                            cmd.Parameters.AddWithValue("@s10", ilanverenpersonel);
                            cmd.Parameters.AddWithValue("@s11", ilanverenpersonelid);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("İlan Başarıyla Eklendi.");
                        }
                    }
                    this.Close();
                }



            }


        }

            private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            personeleklee f2 = new personeleklee();
            f2.Show();
        }

        private void ilaneklepersonel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ilaneklepersoneldataset.tbl_personel' table. You can move, or remove it, as needed.
            this.tbl_personelTableAdapter.Fill(this.ilaneklepersoneldataset.tbl_personel);
           

        }

        private void personeltc_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connetionString3 = null;
            string sql3 = null;
            connetionString3 = @"Data Source=MACHINE\SQLEXPRESS;Initial Catalog=insankaynaklari;Integrated Security=True";
            using (SqlConnection cnn3 = new SqlConnection(connetionString3))
            {

                sql3 = "Select * from tbl_personel Where p_tc_kimlik= '" + personeltc.Text + "'";
                SqlDataAdapter sda3 = new SqlDataAdapter(sql3, cnn3);
                cnn3.Open();
                SqlDataReader myReader3 = null;
                DataTable dtbl3 = new DataTable();
                sda3.Fill(dtbl3);
                SqlCommand myCommand = new SqlCommand("select * from tbl_personel where p_tc_kimlik='" + personeltc.Text + "'", cnn3);
                myReader3 = myCommand.ExecuteReader();

                while (myReader3.Read())
                {
                    personelresim.Text = (myReader3["p_resim"].ToString());
                    try
                    {
                        Bitmap bmp = new Bitmap(personelresim.Text);
                        pictureBox1.Image = bmp;
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                       
                    }
                    catch (Exception foto)
                    {
                        MessageBox.Show("Personelin Fotoğrafı Yok.");
                    }

                }

               
                
            }
        }
    }
}
