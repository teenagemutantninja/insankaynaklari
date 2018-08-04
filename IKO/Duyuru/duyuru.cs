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
    public partial class duyuru : Form
    {
        int a = 0;
        int basti = 0;

        public duyuru()
        {
            InitializeComponent();
        }

        private void Personelekle_MouseClick(object sender, MouseEventArgs e)
        {
            personelekle.BackgroundImage = Properties.Resources.loudspeaker_announce;
        }

        private void Personelekle_MouseDown(object sender, MouseEventArgs e)
        {
            personelekle.BackgroundImage = Properties.Resources.duyuru;
        }

        private void Personelekle_MouseEnter(object sender, EventArgs e)
        {
            personelekle.BackgroundImage = Properties.Resources.loudspeaker_announce;
        }

        private void Personelekle_MouseLeave(object sender, EventArgs e)
        {
            personelekle.BackgroundImage = Properties.Resources.duyuru;
        }

        private void Personelsil_MouseClick(object sender, MouseEventArgs e)
        {
            personelsil.BackgroundImage = Properties.Resources.removerenk;
        }

        private void Personelsil_MouseDown(object sender, MouseEventArgs e)
        {
            personelsil.BackgroundImage = Properties.Resources.remove128;
        }

        private void Personelsil_MouseEnter(object sender, EventArgs e)
        {
            personelsil.BackgroundImage = Properties.Resources.removerenk;
        }

        private void Personelsil_MouseLeave(object sender, EventArgs e)
        {
            personelsil.BackgroundImage = Properties.Resources.remove128;
        }

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
        }

        private void Sirketara_MouseLeave(object sender, EventArgs e)
        {
            sirketara.BackgroundImage = Properties.Resources.se128;
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
        }

        private void Geributton_MouseLeave(object sender, EventArgs e)
        {
            geributton.BackgroundImage = Properties.Resources.back_button;
        }

        private void Personelekle_Click(object sender, EventArgs e)
        {
            basti = 1;
            a = 1;
            
            personelekle.Visible = false;
            personelsil.Visible = false;
            sirketara.Visible = false;
            duyuruyap yapp = new duyuruyap();
            {
            yapp.TopLevel = false;
            yapp.Parent = this;      
            yapp.Show();
            }


        }

        private void Geributton_Click(object sender, EventArgs e)
        {

            basti = 1;
            if (a == 1)
            {
                foreach (duyuruyap fer in Controls.OfType<Form>().ToArray())
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
                foreach (duyurukaldir fr in Controls.OfType<Form>().ToArray())
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
                foreach (duyuruara frr in Controls.OfType<Form>().ToArray())
                    frr.Close();
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



        private void Personelsil_Click(object sender, EventArgs e)
        {
            a =2;
            basti = 2;
            personelekle.Visible = false;
            personelsil.Visible = false;
            sirketara.Visible = false;
            duyurukaldir kldr = new duyurukaldir();
            { 
            kldr.TopLevel = false;
            kldr.Parent = this;
            kldr.Show();
            }

        }

        private void Sirketara_Click(object sender, EventArgs e)
        {
            duyuruyap.duyuru = 1;
            a = 3;
            basti = 2;
            personelekle.Visible = false;
            personelsil.Visible = false;
            sirketara.Visible = false;
            duyuruara ar = new duyuruara();
            { 
            ar.TopLevel = false;
            ar.Parent = this;
            ar.Show();
            }

        }
    }
}


