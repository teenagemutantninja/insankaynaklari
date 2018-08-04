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
    public partial class panel : Form
    {
      
        public panel()
        {
           
            InitializeComponent();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {

            panel4.Controls.Clear();
            sirket srk = new sirket();
            srk.TopLevel = false;
            panel4.Controls.Add(srk);
            srk.Parent = panel4;
            srk.Show();
            srk.Dock = DockStyle.Fill;
            srk.BringToFront();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label1.Text = login.user;
            timer1.Interval = 1000;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            panel4.Controls.Clear();
            personel prs = new personel();
            prs.TopLevel = false;
            panel4.Controls.Add(prs);
            prs.Parent = panel4;
            prs.Show();
            prs.Dock = DockStyle.Fill;
            prs.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            kullanici usr = new kullanici();
            usr.TopLevel = false;
            panel4.Controls.Add(usr);
            usr.Parent = panel4;
            usr.Show();
            usr.Dock = DockStyle.Fill;
            usr.BringToFront();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.ventle.net");
        }

        private void ilanlar_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            ilan ilansayfa = new ilan();
            ilansayfa.TopLevel = false;
            panel4.Controls.Add(ilansayfa);
            ilansayfa.Parent = panel4;
            ilansayfa.Show();
            ilansayfa.Dock = DockStyle.Fill;
            ilansayfa.BringToFront();
        }

        private void duyurular_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            duyuru duyurusayfa = new duyuru();
            
            duyurusayfa.TopLevel = false;
            panel4.Controls.Add(duyurusayfa);
            duyurusayfa.Parent = panel4;
            duyurusayfa.Show();
            duyurusayfa.Dock = DockStyle.Fill;
            duyurusayfa.BringToFront();
        }

        private void panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (duyuruyap.duyuru == 3)
            {
                duyurular.BackgroundImage = Properties.Resources.bildirimvar64;
            }
            else
            {
                duyurular.BackgroundImage = Properties.Resources.duyuru64;
            }

        }

        private void duyurular_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (duyuruyap.duyuru == 3)
            {
                duyurular.BackgroundImage = Properties.Resources.bildirimvar64;
            }
            else
            {
                duyurular.BackgroundImage = Properties.Resources.duyuru64;
            }
        }
    }
}
