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
    public partial class kullanicisil : Form
    {
        public kullanicisil()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int aa, bb;
            string a = (String)textBox1.Text.ToString();
            string b = (String)textBox2.Text.ToString();

            aa = a.Length;
            bb = b.Length;

            if (aa == 0 || bb == 0)
            {
                MessageBox.Show("Tüm alanları doldurmalısınız!", "UYARI",
                 MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }



            DialogResult result = MessageBox.Show("Kullanıcıyı Silmek istediğinizden emin misiniz?", "Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                SqlConnection sqlcon = new SqlConnection(@"Data Source=MACHINE\SQLEXPRESS;Initial Catalog=insankaynaklari;Integrated Security=True");
                string query = "Select * from tbl_Login Where username= '" + textBox1.Text.Trim() + "' and password = '" + textBox2.Text.Trim() + "'";
                
                SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
                sqlcon.Open();
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);

                if (dtbl.Rows.Count == 1)
                {

                    using (SqlCommand command = sqlcon.CreateCommand())
                    {
                        string silmeSorgusu = "DELETE from tbl_login Where username= '" + textBox1.Text.Trim() + "' and password = '" + textBox2.Text.Trim() + "'";

                        SqlCommand silKomutu = new SqlCommand(silmeSorgusu, sqlcon);                                           
                        silKomutu.ExecuteNonQuery();
                        sqlcon.Close();
                        MessageBox.Show("Kayıt Silindi...");
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
                else
                {
                    MessageBox.Show("Böyle bir kullanıcı kayıtlarda yok. Lütfen Tekrar Deneyiniz.");
                }


            }
            else if (result == DialogResult.No)
            {
                //...
            }


        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = checkBox2.Checked ? '\0' : '*';
           
        }
    }
}
