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
    public partial class login : Form
    {
        public login()
        {
            
            InitializeComponent();
        }
        public static string user;
        public static string nuser;
        public static string snuser;
        public static int id;
        public static string gonder;

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=MACHINE\SQLEXPRESS;Initial Catalog=insankaynaklari;Integrated Security=True");
            string query = "Select * from tbl_Login Where username= '" + txtUserId.Text.Trim() + "' and password = '" + txtPassword.Text.Trim() + "'";
            string id = "Select loginId from tbl_Login Where username= '" + txtUserId.Text.Trim() + "' and password = '" + txtPassword.Text.Trim() + "'";
            string snuser = "Select sname from tbl_Login Where username= '" + txtUserId.Text.Trim() + "' and password = '" + txtPassword.Text.Trim() + "'";

            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);

            if (dtbl.Rows.Count == 1)
            {
                user = txtUserId.Text;
                gonder = Convert.ToString(id);
                panel objpanel = new panel();
                this.Hide();
                objpanel.Show();
            }
            else
            {
                MessageBox.Show("Kullaıcı Adı veya Şifre Hatalı. Lütfen Tekrar Deneyiniz.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void login_Load(object sender, EventArgs e)
        {
            
        }

        private void checkBox_save_password_CheckedChanged(object sender, EventArgs e)
        {

            txtPassword.PasswordChar = checkBox_save_password.Checked ? '\0' : '*';
           
        }
       
    }
}
