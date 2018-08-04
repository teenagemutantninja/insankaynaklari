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
    public partial class kullanicisifre : Form
    {
        public kullanicisifre()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
    
            int aa, bb, cc;
            string a = (String)textBox2.Text.ToString();
            string b = (String)textBox3.Text.ToString();
            string c = (String)textBox1.Text.ToString();
            string userr;
            userr = login.user;

            aa = a.Length;
            bb = b.Length;
            cc = c.Length;

            if (aa == 0 || bb == 0 || cc == 0)
            {
                MessageBox.Show("Tüm alanları doldurmalısınız!", "UYARI",
                 MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

           else if (textBox2.Text == textBox3.Text)
            {
                DialogResult result = MessageBox.Show("Şifrenizi değiştirmek istediğinize emin misiniz?", "Şifre Değiştirme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    SqlConnection sqlcon = new SqlConnection(@"Data Source=MACHINE\SQLEXPRESS;Initial Catalog=insankaynaklari;Integrated Security=True");
                    string query = "Select * from tbl_Login Where username= '" + userr.Trim() + "' and password = '" + textBox1.Text.Trim() + "'";
                    string update = "Select sname from tbl_Login Where username= '" + userr.Trim() + "' and password = '" + textBox1.Text.Trim() + "'";

                    SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
                    sqlcon.Open();
                    DataTable dtbl = new DataTable();
                    sda.Fill(dtbl);

                    if (dtbl.Rows.Count == 1)
                    {

                        using (SqlCommand command = sqlcon.CreateCommand())
                        {
                          command.CommandText = "UPDATE tbl_Login SET password = '"+ textBox2.Text.Trim() +"' where username = '"+userr.Trim()+"'";
                          string strcom = "UPDATE tbl_Login SET password = '" + textBox2.Text.Trim() + "' where username = '" + userr.Trim() + "'";

                            SqlCommand tete = new SqlCommand(strcom, sqlcon);
                            try
                            {
                                tete.ExecuteNonQuery();
                                MessageBox.Show("Şifreniz değiştirildi.", "Şifre Değiştirme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.None);
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
            else if(aa > 0 & bb > 0 )
            {
               
                label4.ForeColor = Color.Red;
                MessageBox.Show("Girdiğiniz yeni şifre tekrarı ile uyuşmadı. Lütfen yeni şifrenizi tekrarı ile beraber doğru yazdığınızdan emin olunuz.", "UYARI",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);

                textBox2.Clear();
                textBox3.Clear();
                textBox1.Clear();
            }

            


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label4.ForeColor = Color.White;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            label4.ForeColor = Color.White;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = checkBox2.Checked ? '\0' : '*';
            textBox3.PasswordChar = checkBox2.Checked ? '\0' : '*';
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }
    }
}
