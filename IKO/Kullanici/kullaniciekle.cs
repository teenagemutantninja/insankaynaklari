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
    public partial class kullaniciekle : Form
    {
        public kullaniciekle()
        {
            InitializeComponent();
        }
        private void label11_Click(object sender, EventArgs e){}
        //...
        private void button1_Click(object sender, EventArgs e)
        {
            int kullaniciid = Convert.ToInt32(textBox2.Text);
            string username = textBox4.Text;
            string password = textBox3.Text;
            string gercekisim = textBox6.Text;
            string soyisim = textBox5.Text;
            //formda boşluklar var mı onu kontrol ediyoruz.
            int aa, bb, cc, dd, ff, gg;
            string a = (String)textBox1.Text.ToString();
            string b = (String)textBox2.Text.ToString();
            string c = (String)textBox3.Text.ToString();
            string d = (String)textBox4.Text.ToString();
            string f = (String)textBox5.Text.ToString();
            string g = (String)textBox6.Text.ToString();
            //
            aa = a.Length;
            bb = b.Length;
            cc = c.Length;
            dd = d.Length;
            ff = f.Length;
            gg = g.Length;
            //formda boşluklar var mı onu kontrol ediyoruz.
            if (aa == 0 || bb == 0 || cc == 0 || dd == 0 || ff == 0 || gg == 0)
            {
                MessageBox.Show("Tüm alanları doldurmalısınız!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textBox3.Text != textBox1.Text)
            {
                MessageBox.Show("Şifreler uyuşmadı lütfen tekrar deneyiniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        sql = "insert into tbl_Login (loginId,username,password,name,sname) values(@loginId,@username,@password,@name,@sname)";
                        cnn.Open();
                        using (SqlCommand cmd = new SqlCommand(sql, cnn))
                        {
                            cmd.Parameters.AddWithValue("@loginId", kullaniciid);
                            cmd.Parameters.AddWithValue("@username", textBox4.Text);
                            cmd.Parameters.AddWithValue("@password", textBox3.Text);
                            cmd.Parameters.AddWithValue("@name", textBox6.Text);
                            cmd.Parameters.AddWithValue("@sname", textBox5.Text);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Kullanıcı Başarıyla Eklendi.");
                        }
                    }
                }

                else if (result == DialogResult.No)
                {
                    //...
                }
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.PasswordChar = checkBox2.Checked ? '\0' : '*';
            textBox3.PasswordChar = checkBox2.Checked ? '\0' : '*';
        }
    }
}