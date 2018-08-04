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
    public partial class sirketkaldir : Form
    {

        public sirketkaldir()
        {

            InitializeComponent();
            label1.Visible = false;
            sirketadrestext.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            sirketaditext.Visible = false;
            textBox2.Visible = false;
            sirkettelefontext.Visible = false;
            sirketepostatext.Visible = false;
            sirketyoneticitext.Visible = false;
            sirketsektortext.Visible = false;
            button3.Visible = false;
            pictureBox1.Visible = false;
            

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
                    sirketaditext.Text = (myReader["sirket_adi"].ToString());
                    sirkettelefontext.Text = (myReader["sirket_no"].ToString());
                    sirketsektortext.Text = (myReader["sirket_sektor"].ToString());
                    sirketyoneticitext.Text = (myReader["sirket_yonetici"].ToString());
                    sirketepostatext.Text = (myReader["sirket_eposta"].ToString());
                    textBox2.Text = (myReader["sirket_adres"].ToString());
                    resimyol.Text = (myReader["sirket_resimyolu"].ToString());
                    idtext.Text = (myReader["s_id"].ToString());

                    try
                    {
                        Bitmap bmp = new Bitmap(resimyol.Text);
                        pictureBox1.Image = bmp;
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    catch(Exception fotoo)
                    {
                        MessageBox.Show("Şirketin bir fotoğrafı yok.");
                    }

                }
                cnn.Close();


            }


            label1.Visible = true;
            sirketadrestext.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            sirketaditext.Visible = true;
            textBox2.Visible = true;
            sirkettelefontext.Visible = true;
            sirketepostatext.Visible = true;
            sirketyoneticitext.Visible = true;
            sirketsektortext.Visible = true;
            button3.Visible = true;
            pictureBox1.Visible = true;
        }

        private void sirketkaldir_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'insankaynaklariDataSet.tbl_Sirket' table. You can move, or remove it, as needed.
            this.tbl_SirketTableAdapter.Fill(this.insankaynaklariDataSet.tbl_Sirket);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Şirketi Silmek istediğinizden emin misiniz?", "Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                SqlConnection sqlcon = new SqlConnection(@"Data Source=MACHINE\SQLEXPRESS;Initial Catalog=insankaynaklari;Integrated Security=True");
                string query = "Select * from tbl_Sirket Where sirket_adi= '" + comboBox1.Text.Trim() + "' and sirket_yonetici = '" + comboBox2.Text.Trim() + "'";

                SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
                sqlcon.Open();
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);

                if (dtbl.Rows.Count == 1)
                {

                    using (SqlCommand command = sqlcon.CreateCommand())
                    {
                        string silmeSorgusu = "DELETE from tbl_Sirket Where sirket_adi= '" + comboBox1.Text.Trim() + "' and sirket_yonetici = '" + comboBox2.Text.Trim() + "'";

                        SqlCommand silKomutu = new SqlCommand(silmeSorgusu, sqlcon);
                        silKomutu.ExecuteNonQuery();
                        sqlcon.Close();
                        MessageBox.Show("Şirket Silindi");
                        sirketaditext.Clear();
                        textBox2.Clear();
                        sirketepostatext.Clear();
                        sirketsektortext.Clear(); 

                        sirkettelefontext.Clear();
                        sirketyoneticitext.Clear();
                        resimyol.Clear();
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

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
           
        }

        private void tblSirketBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

     

    }
}
