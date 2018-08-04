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
    public partial class ilan : Form
    {
        int basti = 0;
        int a = 0;
        public ilan()
        {
            InitializeComponent();
        }

        //ilan ekle

        private void personelekle_MouseClick(object sender, MouseEventArgs e)
        {
            personelekle.BackgroundImage = Properties.Resources.gerceksirketeklerenk;
        }

        private void personelekle_MouseDown(object sender, MouseEventArgs e)
        {
            personelekle.BackgroundImage = Properties.Resources.gerceksirketekle;
        }

        private void personelekle_MouseEnter(object sender, EventArgs e)
        {
            personelekle.BackgroundImage = Properties.Resources.gerceksirketeklerenk;
            personelekle.Text = "";
        }

        private void personelekle_MouseLeave(object sender, EventArgs e)
        {
            personelekle.BackgroundImage = Properties.Resources.gerceksirketekle;
            personelekle.Text = "İlan Ver";
        }

        //ilan kaldır

        private void personelsil_MouseClick(object sender, MouseEventArgs e)
        {
            personelsil.BackgroundImage = Properties.Resources.sirketkaldirrenk;
        }

        private void personelsil_MouseDown(object sender, MouseEventArgs e)
        {
            personelsil.BackgroundImage = Properties.Resources.sirketkaldir;
        }

        private void personelsil_MouseEnter(object sender, EventArgs e)
        {
            personelsil.BackgroundImage = Properties.Resources.sirketkaldirrenk;
            personelsil.Text = "";
        }

        private void personelsil_MouseLeave(object sender, EventArgs e)
        {
            personelsil.BackgroundImage = Properties.Resources.sirketkaldir;
            personelsil.Text = "İlan Kaldır";
        }

        //ilan düzenle

        private void personelduzenle_MouseClick(object sender, MouseEventArgs e)
        {
            personelduzenle.BackgroundImage = Properties.Resources.sirketdüzenlerenk;
        }

        private void personelduzenle_MouseDown(object sender, MouseEventArgs e)
        {
            personelduzenle.BackgroundImage = Properties.Resources.sirketekle;
        }

        private void personelduzenle_MouseEnter(object sender, EventArgs e)
        {
            personelduzenle.BackgroundImage = Properties.Resources.sirketdüzenlerenk;
            personelduzenle.Text = "";
        }

        private void personelduzenle_MouseLeave(object sender, EventArgs e)
        {
            personelduzenle.BackgroundImage = Properties.Resources.sirketekle;
            personelduzenle.Text = "İlan Düzenle";
        }

        //ilanara

        private void sirketara_MouseClick(object sender, MouseEventArgs e)
        {
            sirketara.BackgroundImage = Properties.Resources.search128renk;
        }

        private void sirketara_MouseDown(object sender, MouseEventArgs e)
        {
            sirketara.BackgroundImage = Properties.Resources.se128;

        }

        private void sirketara_MouseEnter(object sender, EventArgs e)
        {
            sirketara.BackgroundImage = Properties.Resources.search128renk;
            sirketara.Text = "";
        }

        private void sirketara_MouseLeave(object sender, EventArgs e)
        {
            sirketara.BackgroundImage = Properties.Resources.se128;
            sirketara.Text = "Ara";
        }

        private void geributton_MouseClick(object sender, MouseEventArgs e)
        {
            geributton.BackgroundImage = Properties.Resources.redb;
        }

        private void geributton_MouseDown(object sender, MouseEventArgs e)
        {
            geributton.BackgroundImage = Properties.Resources.back_button;
        }

        private void geributton_MouseEnter(object sender, EventArgs e)
        {
            geributton.BackgroundImage = Properties.Resources.redb;
            geributton.Text = "";
        }

        private void geributton_MouseLeave(object sender, EventArgs e)
        {
            geributton.BackgroundImage = Properties.Resources.back_button;
            geributton.Text = "Geri";
        }

        private void geributton_Click(object sender, EventArgs e)
        {
            basti = 1;
            if (a == 1)
            {
                foreach (ilanekle fer in panel1.Controls.OfType<Form>().ToArray())
                    fer.Close();
                a = 123;
                basti = 2;
            }
            else
            {
                //
            }


            if (a == 2)
            {
                foreach (sililan fr in panel1.Controls.OfType<Form>().ToArray())
                    fr.Close();
                a = 123;
                basti = 2;
            }
            else
            {
                //
            }


            if (a == 3)
            {
                foreach (duzenleilan frr in panel1.Controls.OfType<Form>().ToArray())
                    frr.Close();
                a = 123;
                basti = 2;
            }
            else
            {
                //
            }

            if (a == 4)
            {
                foreach (arailan ann in panel1.Controls.OfType<Form>().ToArray())
                    ann.Close();
                a = 123;
                basti = 2;
            }
            else
            {
                //
            }

            if (basti == 1)
            {
                this.Close();
            }
            else
            {
                //
            }


            personelekle.Visible = true;
            personelsil.Visible = true;
            
            sirketara.Visible = true;
        }

        private void personelekle_Click(object sender, EventArgs e)
        {
            a = 1;
            personelduzenle.Visible = false;
            personelekle.Visible = false;
            personelsil.Visible = false;
            sirketara.Visible = false;
            
            ilanekle ekleilan = new ilanekle();
            ekleilan.TopLevel = false;
            ekleilan.Parent = panel1;

            panel1.Controls.Add(ekleilan);

            ekleilan.Show();
        }

        private void personelduzenle_Click(object sender, EventArgs e)
        {
            a = 3;
            personelduzenle.Visible = false;
            personelekle.Visible = false;
            personelsil.Visible = false;
            sirketara.Visible = false;

            duzenleilan dznle = new duzenleilan();
            dznle.TopLevel = false;
            dznle.Parent = panel1;

            panel1.Controls.Add(dznle);

            dznle.Show();
        }

        private void personelsil_Click(object sender, EventArgs e)
        {
            a = 2;
            personelduzenle.Visible = false;
            personelekle.Visible = false;
            personelsil.Visible = false;
            sirketara.Visible = false;

            sililan ilans = new sililan();
            ilans.TopLevel = false;
            ilans.Parent = panel1;

            panel1.Controls.Add(ilans);

            ilans.Show();
        }

        private void sirketara_Click(object sender, EventArgs e)
        {
            a = 4;
            personelduzenle.Visible = false;
            personelekle.Visible = false;
            personelsil.Visible = false;
            sirketara.Visible = false;

            arailan arrr = new arailan();
            arrr.TopLevel = false;
            arrr.Parent = panel1;

            panel1.Controls.Add(arrr);

            arrr.Show();
        }
    }
}
