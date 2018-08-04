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
    public partial class duyuruara : Form
    {
        public static string olusturan;
        public static string tarih;
       
        public static string baslik;
        public static string icerik;
        public duyuruara()
        {
            InitializeComponent();
            
            
        }

        private void duyuruara_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'duyurusondataset.tbl_Duyuru' table. You can move, or remove it, as needed.
            this.tbl_DuyuruTableAdapter.Fill(this.duyurusondataset.tbl_Duyuru);
         
           


        }

        private void tblDuyuruBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
       

       

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox3_DoubleClick(object sender, EventArgs e)
        {
            tarih =listBox3.SelectedItem.ToString();
            
            olusturan = listBox2.SelectedValue.ToString();
            icerik = listBox4.SelectedValue.ToString();
            baslik = listBox1.SelectedValue.ToString();
            duyurugoster goster = new duyurugoster();
            goster.Show();
        }

        private void listBox2_DoubleClick(object sender, EventArgs e)
        {
            tarih = listBox3.SelectedItem.ToString();
           
            olusturan = listBox2.SelectedValue.ToString();
            icerik = listBox4.SelectedValue.ToString();
            baslik = listBox1.SelectedValue.ToString();
            duyurugoster goster = new duyurugoster();
            goster.Show();

        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            tarih = listBox3.SelectedItem.ToString();
            
            olusturan = listBox2.SelectedValue.ToString();
            icerik = listBox4.SelectedValue.ToString();
            baslik = listBox1.SelectedValue.ToString();
            duyurugoster goster = new duyurugoster();
            goster.Show();
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
