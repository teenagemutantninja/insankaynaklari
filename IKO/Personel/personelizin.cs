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
    public partial class personelizinn : Form
    {
        int p_izin=1;
        public personelizinn()
        {
            InitializeComponent();
        }

        private void personelizinn_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            button1.Visible = false;
            // TODO: This line of code loads data into the 'insankaynaklariDataSet5.tbl_personel' table. You can move, or remove it, as needed.
            this.tbl_personelTableAdapter.Fill(this.insankaynaklariDataSet5.tbl_personel);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            string connetionString = null;
            string sql = null;
            connetionString = @"Data Source=MACHINE\SQLEXPRESS;Initial Catalog=insankaynaklari;Integrated Security=True";
            using (SqlConnection cnn = new SqlConnection(connetionString))
            {
                groupBox1.Visible = true;
                button1.Visible = true;
                sql = "Select * from tbl_personel Where p_tc_kimlik= '" + comboBox5.Text.Trim() + "' and p_isim = '" + comboBox6.Text.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(sql, cnn);
                cnn.Open();
                SqlDataReader myReader = null;
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                SqlCommand myCommand = new SqlCommand("select * from tbl_personel where p_tc_kimlik='" + comboBox5.Text.Trim() + "'", cnn);

                myReader = myCommand.ExecuteReader();

                

                while (myReader.Read())
                {
                    tc.Text = (myReader["p_tc_kimlik"].ToString());
                    ad.Text = (myReader["p_isim"].ToString());
                    soyad.Text = (myReader["p_soy_isim"].ToString());
                    resimyolu.Text = (myReader["p_resim"].ToString());
                    pizintext.Text = (myReader["pizin"].ToString());
                    idtext.Text = (myReader["p_id"].ToString());

                }
                try { 
                Bitmap bmp = new Bitmap(resimyolu.Text);
                pictureBox1.Image = bmp;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                cnn.Close();
                }
                catch(Exception foto)
                {
                    MessageBox.Show("Personelin Fotoğrafı Yok.");
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            string pizinaciklama = izinsebep.Text;
            string p_rapor = rapor.Text;
            DateTime pizinbasla = Convert.ToDateTime(dateTimePicker1.Text);
            DateTime pizinbit = Convert.ToDateTime(dateTimePicker2.Text);
            int aydi = Convert.ToInt32(idtext.Text);
            




            DialogResult result = MessageBox.Show("Personele izin verme işlemine devam etmeye emin misiniz?", "Personel İzin", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
              
                pizintext.Text = Convert.ToString(p_izin);

                string connetionString = null;
               
                connetionString = @"Data Source=MACHINE\SQLEXPRESS;Initial Catalog=insankaynaklari;Integrated Security=True";
                using (SqlConnection cnn = new SqlConnection(connetionString))
                {
                        String sql = "UPDATE tbl_personel SET p_rapor = @p_rapor,pizinaciklama = @pizinaciklama,pizinbit = @pizinbit,pizinbasla = @pizinbasla,pizin = @pizin WHERE p_id = (@id);";
                        SqlCommand myCommand = new SqlCommand("select * from tbl_personel where p_tc_kimlik='" + comboBox5.Text.Trim() + "'", cnn);
                        // sql = "insert into tbl_personel p_rapor = @p_rapor,pizinaciklama = @pizinaciklama,pizinbit = @pizinbit,pizinbasla = @pizinbasla pizin = @pizin WHERE p_tc_kimlik = (@tckimlik);";

                        cnn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, cnn))
                    {
                        cmd.Parameters.AddWithValue("@p_rapor", rapor.Text);
                        cmd.Parameters.AddWithValue("@pizinaciklama", izinsebep.Text);
                        cmd.Parameters.AddWithValue("@pizinbit", dateTimePicker2.Text);
                        cmd.Parameters.AddWithValue("@pizinbasla", dateTimePicker1.Text);
                        cmd.Parameters.AddWithValue("@pizin", pizintext.Text);
                        cmd.Parameters.AddWithValue("@id", aydi);



                        cmd.ExecuteNonQuery();


                        MessageBox.Show("İzin Başarıyla Eklendi.");
                    }
               

                }
              
                  
            }
        }
    }
}
