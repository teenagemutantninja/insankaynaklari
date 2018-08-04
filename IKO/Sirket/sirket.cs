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
    public partial class sirket : Form
    {
        int a = 0;
        int b = 0;
        int basti = 0;
        public sirket()
        {
            InitializeComponent();
        }

        private void Geributton_Click(object sender, EventArgs e)
        {
            basti = 1;
            
            // panel arkasında açık kalan butonları kapatıyoruz
            
            if (a == 1)
            {
                foreach (sirketkaldir fer in panel2.Controls.OfType<Form>().ToArray())
                    fer.Close();
                a = 121;
                b = b + 1;
                basti = 2;
            }
            else
            {
                //
            }

            if (a == 4)
            {
                foreach (sirketaraa rk in panel2.Controls.OfType<Form>().ToArray())
                rk.Close();
                a = 122;
                b = b + 1;
                basti = 2;
            }
            else
            {
                //
            }

            if (a == 2)
            {
                foreach (sirketekle fr in panel2.Controls.OfType<Form>().ToArray())
                    fr.Close();
                    a =123;
                b = b + 1;
                basti = 2;
            }
            else
            {
                //
            }


            if (a == 3)
            {
                    foreach (sirketduzenle frr in panel2.Controls.OfType<Form>().ToArray())
                    frr.Close();
                a = 124;
                b = b + 1;
                basti = 2;
            }
            else
            {
                //
            }

            
            if (b == 1 | b == 2 | b == 3 | b == 4 )
            {
                if (basti == 1)
                {
                    this.Close();
                }
                else
                {
                    //
                }
            }
            else
            {
                //
            }



            // tekrar geri gelecekler 
            personelduzenle.Visible = true;
            personelekle.Visible = true;
            personelsil.Visible = true;
            sirketara.Visible = true;
           
            
        }

        //personel ekle

        private void Personelekle_MouseClick(object sender, MouseEventArgs e)
        {
            personelekle.BackgroundImage = Properties.Resources.gerceksirketeklerenk;
        }

        private void Personelekle_MouseDown(object sender, MouseEventArgs e)
        {
            personelekle.BackgroundImage = Properties.Resources.gerceksirketekle;
        }

        private void Personelekle_MouseEnter(object sender, EventArgs e)
        {
            personelekle.BackgroundImage = Properties.Resources.gerceksirketeklerenk;
            personelekle.Text = "";
        }

        private void Personelekle_MouseLeave(object sender, EventArgs e)
        {
            personelekle.BackgroundImage = Properties.Resources.gerceksirketekle;
            personelekle.Text = "Şirket Ekle";
        }

        //personelsil

        private void Personelsil_MouseClick(object sender, MouseEventArgs e)
        {
            personelsil.BackgroundImage = Properties.Resources.sirketkaldirrenk;
            
        }

        private void Personelsil_MouseDown(object sender, MouseEventArgs e)
        {
            personelsil.BackgroundImage = Properties.Resources.sirketkaldir;

        }

        private void Personelsil_MouseEnter(object sender, EventArgs e)
        {
            personelsil.BackgroundImage = Properties.Resources.sirketkaldirrenk;
            personelsil.Text = "";
        }

        private void Personelsil_MouseLeave(object sender, EventArgs e)
        {
            personelsil.BackgroundImage = Properties.Resources.sirketkaldir;
            personelsil.Text = "Şirket Kaldır";
        }

        //personel düzenle

        private void Personelduzenle_MouseClick(object sender, MouseEventArgs e)
        {
            personelduzenle.BackgroundImage = Properties.Resources.sirketdüzenlerenk;
        }

        private void Personelduzenle_MouseDown(object sender, MouseEventArgs e)
        {
            personelduzenle.BackgroundImage = Properties.Resources.sirketekle;
        }

        private void Personelduzenle_MouseEnter(object sender, EventArgs e)
        {
            personelduzenle.BackgroundImage = Properties.Resources.sirketdüzenlerenk;
            personelduzenle.Text = "";
        }

        private void Personelduzenle_MouseLeave(object sender, EventArgs e)
        {
            personelduzenle.BackgroundImage = Properties.Resources.sirketekle;
            personelduzenle.Text = "Şirket Düzenle";
        }

        //sirketara

        private void Sirketara_MouseClick(object sender, MouseEventArgs e)
        {
            sirketara.BackgroundImage = Properties.Resources.search128renk;
        }

        private void Sirketara_MouseDown(object sender, MouseEventArgs e)
        {
            sirketara.BackgroundImage = Properties.Resources.se128;
        }

        private void Sirketara_MouseEnter(object sender, EventArgs e)
        {
            sirketara.BackgroundImage = Properties.Resources.search128renk;
            sirketara.Text = "";
        }

        private void Sirketara_MouseLeave(object sender, EventArgs e)
        {
            sirketara.BackgroundImage = Properties.Resources.se128;
            sirketara.Text = "Şirket Ara";
        }

       

        private void Personelekle_Click(object sender, EventArgs e)
        {
            a = 2;
            personelduzenle.Visible = false;
            personelekle.Visible = false;
            personelsil.Visible = false;
            sirketara.Visible = false;

            sirketekle srkek = new sirketekle();
            {
            srkek.TopLevel = false;
            srkek.Parent = panel2;
           
            panel2.Controls.Add(srkek);
           
            srkek.Show();
            }

        }

        private void Personelsil_Click(object sender, EventArgs e)
        {
            a = 1;
            personelduzenle.Visible = false;
            personelekle.Visible = false;
            personelsil.Visible = false;
            sirketara.Visible = false;
            sirketkaldir kldqwer = new sirketkaldir();
            { 
            kldqwer.TopLevel = false;
            kldqwer.Parent = panel2;

            panel2.Controls.Add(kldqwer);

            kldqwer.Show();
            }
        }

        private void Personelduzenle_Click(object sender, EventArgs e)
        {
            a = 3;
            personelduzenle.Visible = false;
            personelekle.Visible = false;
            personelsil.Visible = false;
            sirketara.Visible = false;
            sirketduzenle dz = new sirketduzenle();
            { 
            dz.TopLevel = false;
            dz.Parent = panel2;

            panel2.Controls.Add(dz);

            dz.Show();
            }
        }

        private void Sirketara_Click(object sender, EventArgs e)
        {
            a = 4;
            personelduzenle.Visible = false;
            personelekle.Visible = false;
            personelsil.Visible = false;
            sirketara.Visible = false;
            sirketaraa kldrr = new sirketaraa();
            { 
            kldrr.TopLevel = false;
            kldrr.Parent = panel2;

            panel2.Controls.Add(kldrr);

            kldrr.Show();
            }
        }

        private void Geributton_MouseClick(object sender, MouseEventArgs e)
        {
            geributton.BackgroundImage = Properties.Resources.redb;
        }

        private void Geributton_MouseDown(object sender, MouseEventArgs e)
        {
            geributton.BackgroundImage = Properties.Resources.back_button;
            
        }

        private void Geributton_MouseEnter(object sender, EventArgs e)
        {
            geributton.BackgroundImage = Properties.Resources.redb;
            geributton.Text = "";
        }

        private void Geributton_MouseLeave(object sender, EventArgs e)
        {
            geributton.BackgroundImage = Properties.Resources.back_button;
            geributton.Text = "Geri";
        }
    }
}
