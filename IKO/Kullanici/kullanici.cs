using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IKO
{
    public partial class kullanici : Form
    {
        public kullanici()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            kullanicisifre sfr = new kullanicisifre();
            sfr.TopLevel = false;
            panel2.Controls.Add(sfr);
            sfr.Parent = panel2;
            sfr.Show();
            sfr.Dock = DockStyle.Fill;
            sfr.BringToFront();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            kullanicisil sil = new kullanicisil();
            sil.TopLevel = false;
            panel2.Controls.Add(sil);
            sil.Parent = panel2;
            sil.Show();
            sil.Dock = DockStyle.Fill;
            sil.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            kullaniciekle add = new kullaniciekle();
            add.TopLevel = false;
            panel2.Controls.Add(add);
            add.Parent = panel2;
            add.Show();
            add.Dock = DockStyle.Fill;
            add.BringToFront();
        }

        private void geributonu1(object sender, EventArgs e)
        {

        }

        private void ger(object sender, EventArgs e)
        {
            button4.BackgroundImage = Properties.Resources.redb;
        }

        private void gerger(object sender, EventArgs e)
        {
            button4.BackgroundImage = Properties.Resources.back_button;
        }

        private void button4_MouseDown(object sender, MouseEventArgs e)
        {
           button4. BackgroundImage = Properties.Resources.back_button;
        }
    }
}
