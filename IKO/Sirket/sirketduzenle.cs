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
    public partial class sirketduzenle : Form
    {
        public sirketduzenle()
        {
            InitializeComponent();
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label1.Visible = false;
            button1.Visible = false;
            button3.Visible = false;
            pictureBox1.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            string sql = null;
            connetionString = @"Data Source=MACHINE\SQLEXPRESS;Initial Catalog=insankaynaklari;Integrated Security=True";
            using (SqlConnection cnn = new SqlConnection(connetionString))
            {

                sql = "Select * from tbl_Sirket Where sirket_adi= '" + comboBox1.Text.Trim() + "' and sirket_yonetici = '" + comboBox2.Text.Trim() + "'";

                SqlDataAdapter sda = new SqlDataAdapter(sql, cnn);
                cnn.Open();
                SqlDataReader myReader = null;
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                SqlCommand myCommand = new SqlCommand("select * from tbl_sirket where sirket_adi='" + comboBox1.Text.Trim() + "'", cnn);

                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    textBox1.Text = (myReader["sirket_adi"].ToString());
                    textBox3.Text = (myReader["sirket_no"].ToString());
                    textBox6.Text = (myReader["sirket_sektor"].ToString());
                    textBox5.Text = (myReader["sirket_yonetici"].ToString());
                    textBox4.Text = (myReader["sirket_eposta"].ToString());
                    textBox2.Text = (myReader["sirket_adres"].ToString());
                    resimyol.Text = (myReader["sirket_resimyolu"].ToString());
                    idtext.Text = (myReader["s_id"].ToString());

                    try { 
                    Bitmap bmp = new Bitmap(resimyol.Text);
                    pictureBox1.Image = bmp;
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    catch(Exception fot)
                    {
                        MessageBox.Show("Şirketin bir fotoğrafı yok.");
                    }

                }
                cnn.Close();


            }

            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label1.Visible = true;
            button1.Visible = true;
            button3.Visible = true;
            pictureBox1.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
        }

        private void sirketduzenle_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'insankaynaklariDataSet.tbl_Sirket' table. You can move, or remove it, as needed.
            this.tbl_SirketTableAdapter.Fill(this.insankaynaklariDataSet.tbl_Sirket);
            // TODO: This line of code loads data into the 'insankaynaklariDataSet.tbl_Sirket' table. You can move, or remove it, as needed.
            this.tbl_SirketTableAdapter.Fill(this.insankaynaklariDataSet.tbl_Sirket);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int aa, bb, cc, dd, ff, gg, tt;
            string a = (String)textBox1.Text.ToString();
            string b = (String)textBox3.Text.ToString();
            string c = (String)textBox6.Text.ToString();
            string d = (String)textBox5.Text.ToString();
            string f = (String)textBox4.Text.ToString();
            string g = (String)textBox2.Text.ToString();
            string t = (String)resimyol.Text.ToString();


            aa = a.Length;
            bb = b.Length;
            cc = c.Length;
            dd = a.Length;
            ff = b.Length;
            gg = c.Length;
            tt = a.Length;

            if (aa == 0 || bb == 0 || cc == 0 | dd == 0 || ff == 0 || gg == 0)
            {
                MessageBox.Show("Tüm alanları doldurmalısınız!", "UYARI",
                 MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            DialogResult result = MessageBox.Show("Şirketi düzenlemek istediğinize emin misiniz?", "Düzenleme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                String s1 = textBox1.Text;
                String s2 = textBox2.Text;
                Int64 s3 = Convert.ToInt64(textBox3.Text);
                String s4 = textBox4.Text;
                String s5 = textBox5.Text;
                String s6 = textBox6.Text;
                String idd = idtext.Text;
                String resim = resimyol.Text;

                String strin = @"Data Source=MACHINE\SQLEXPRESS;Initial Catalog=insankaynaklari;Integrated Security=True";
                SqlConnection myConnection = new SqlConnection(strin);


                myConnection.Open();
                String query = "UPDATE tbl_Sirket SET sirket_adi = @s1,sirket_adres = @s2,sirket_no = @s3,sirket_sektor = @s6,sirket_yonetici = @s5,sirket_eposta = @s4, sirket_resimyolu = @rrr WHERE s_id = (@id);";
                SqlCommand commandEdit = new SqlCommand(query, myConnection);

                commandEdit.Parameters.AddWithValue("@s1", s1);
                commandEdit.Parameters.AddWithValue("@s2", s2);
                commandEdit.Parameters.AddWithValue("@s3", Convert.ToInt32(s3));
                commandEdit.Parameters.AddWithValue("@s4", Convert.ToString(s4));
                commandEdit.Parameters.AddWithValue("@s5", s5);
                commandEdit.Parameters.AddWithValue("@s6", s6);
                commandEdit.Parameters.AddWithValue("@id", idd);
                commandEdit.Parameters.AddWithValue("@rrr", resim);


                commandEdit.ExecuteNonQuery();
                MessageBox.Show("Şirket Düzenlendi");

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
            this.Close();
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            try
            {
                Int64 as1 = Convert.ToInt64(textBox3.Text);
            }
            catch (Exception hataa)
            {
                MessageBox.Show("Ortalama Bilgisini Hatalı Girdiniz");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Resim Dosyası |*.jpg;*.nef;*.png |  Tüm Dosyalar |*.*";
            dosya.ShowDialog();
            string dosyayolu = dosya.FileName;
            resimyol.Text = dosyayolu;
            Bitmap bmp = new Bitmap(resimyol.Text);
            pictureBox1.Image = bmp;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
