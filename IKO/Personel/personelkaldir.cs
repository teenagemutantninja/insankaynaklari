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
    public partial class personelkaldirr : Form
    {
        public personelkaldirr()
        {
            InitializeComponent();
        }

        private void personelkaldirr_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'insankaynaklariDataSet5.tbl_personel' table. You can move, or remove it, as needed.
            this.tbl_personelTableAdapter.Fill(this.insankaynaklariDataSet5.tbl_personel);

            groupBox1.Visible = false;


            button3.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            groupBox1.Visible = true;


            button3.Visible = true;


            string connetionString = null;
            string sql = null;
            connetionString = @"Data Source=MACHINE\SQLEXPRESS;Initial Catalog=insankaynaklari;Integrated Security=True";
            using (SqlConnection cnn = new SqlConnection(connetionString))
            {
               

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
                    tckimlik.Text = (myReader["p_tc_kimlik"].ToString());
                    adi.Text = (myReader["p_isim"].ToString());
                    soyadi.Text = (myReader["p_soy_isim"].ToString());
                    padres.Text = (myReader["p_adres"].ToString());
                    comboBox1.Text = (myReader["p_cinsiyet"].ToString());
                    pdepart.Text = (myReader["p_departman"].ToString());
                    comboBox2.Text = Convert.ToDateTime(myReader["personel_dogum_tarihi"]).ToString("dd/MM/yyyy");
                    askerlik.Text = (myReader["p_askerlik"].ToString());
                    peposta.Text = (myReader["p_eposta"].ToString());
                    pulke.Text = (myReader["p_ulke"].ToString());
                    ptel.Text = (myReader["p_tel"].ToString());

                    resimyolut.Text = (myReader["p_resim"].ToString());

                    cvyolut.Text = (myReader["p_cv"].ToString());
                    pdogumyer.Text = (myReader["p_dogumyeri"].ToString());
                    idtext.Text = (myReader["p_id"].ToString());

                    
                }
                try
                {
                    Bitmap bmp = new Bitmap(resimyolut.Text);
                    pictureBox1.Image = bmp;
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    cnn.Close();

                }
                catch (Exception exe)
                {
                    MessageBox.Show("Personelin Resmi Yok");
                }

            }
        }


            private void button3_Click(object sender, EventArgs e)
            {
               

            }

            private void comboBox2_TextChanged(object sender, EventArgs e)
            {

            }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Int64 p_tc_kimlik = Convert.ToInt64(tckimlik.Text);
            string p_isim = adi.Text;
            string p_soy_isim = soyadi.Text;
            string p_adres = padres.Text;
            string p_cinsiyet = comboBox1.Text;
            string p_departman = pdepart.Text;
            DateTime personel_dogum_tarihi = Convert.ToDateTime(comboBox2.Text);
            string p_askerlik = askerlik.Text;
            string p_eposta = peposta.Text;
            string p_ulke = pulke.Text;
            string p_dogumyeri = pdogumyer.Text;

            Int64 p_tel = Convert.ToInt64(ptel.Text);
            string p_resim = resimyolut.Text;
            string p_dil = null;

            DialogResult result = MessageBox.Show("Personeli Silmek istediğinizden emin misiniz?", "Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                SqlConnection sqlcon = new SqlConnection(@"Data Source=MACHINE\SQLEXPRESS;Initial Catalog=insankaynaklari;Integrated Security=True");
                string query = "Select * from tbl_personel Where p_isim= '" + comboBox6.Text.Trim() + "' and p_tc_kimlik = '" + comboBox5.Text.Trim() + "'";

                SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
                sqlcon.Open();
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);

                if (dtbl.Rows.Count == 1)
                {

                    using (SqlCommand command = sqlcon.CreateCommand())
                    {
                        string silmeSorgusu = "DELETE from tbl_personel Where p_tc_kimlik= '" + comboBox5.Text.Trim() + "' and p_isim = '" + comboBox6.Text.Trim() + "'";

                        SqlCommand silKomutu = new SqlCommand(silmeSorgusu, sqlcon);
                        silKomutu.ExecuteNonQuery();
                        sqlcon.Close();
                        MessageBox.Show("Personel Silindi");

                        adi.Clear();
                        soyadi.Clear();
                        padres.Clear();
                        comboBox1.Clear();

                        pdepart.Clear();
                        comboBox2.Clear();
                        askerlik.Clear();
                        peposta.Clear();

                        pulke.Clear();
                        pdogumyer.Clear();
                        ptel.Clear();
                        cvyolut.Clear();
                        resimyolut.Clear();
                        idtext.Clear();





                        pictureBox1.Image = Properties.Resources.office_briefcase;
                        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;




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
                this.Close();

            }

        }
    }   } 
