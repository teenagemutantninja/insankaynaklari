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
    public partial class personel : Form
    {
        int a = 0;
        int basti = 0;
        public personel()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            basti = 1;
            // panel arkasında açık kalan butonları kapatıyoruz

            if (a == 1)
            {
                foreach (personeleklee fer in panel1.Controls.OfType<Form>().ToArray())
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
                foreach (personelkaldirr fr in panel1.Controls.OfType<Form>().ToArray())
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
                foreach (personelduzenlee frr in panel1.Controls.OfType<Form>().ToArray())
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
                foreach (personelizinn ann in panel1.Controls.OfType<Form>().ToArray())
                    ann.Close();
                a = 123;
                basti = 2;
            }
            else
            {
                //
            }

            if (a == 5)
            {
                foreach (arailan bb in panel1.Controls.OfType<Form>().ToArray())
                    bb.Close();
                a = 123;
                basti = 2;
            }
            else
            {
                //
            }

            if (a == 6)
            {
                foreach (personelaraa cc in panel1.Controls.OfType<Form>().ToArray())
                    cc.Close();
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


            // tekrar geri gelecekler 
            personelduzenle.Visible = true;
            personelekle.Visible = true;
            personelsil.Visible = true;
            personelizin.Visible = true;
          
            button2.Visible = true;
        }
        private void button6_MouseHover(object sender, EventArgs e)
        {

        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {
            ileributton.BackgroundImage = Properties.Resources.redb;
            ileributton.Text = "";
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            ileributton.BackgroundImage = Properties.Resources.back_button;
            ileributton.Text = "GERİ";
        }
        

        private void ileributton_MouseDown(object sender, MouseEventArgs e)
        {
            ileributton.BackgroundImage = Properties.Resources.back_button;
        }





        private void panel1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void personelekle_MouseEnter(object sender, EventArgs e)
        {
            personelekle.BackgroundImage = Properties.Resources.c2a;
            personelekle.Text = "";
        }

        private void personelekle_MouseLeave(object sender, EventArgs e)
        {
            personelekle.BackgroundImage = Properties.Resources._2ayse;
            personelekle.Text = "Personel Ekle";
        }

        private void personelekle_MouseClick(object sender, MouseEventArgs e)
        {
            personelekle.BackgroundImage = Properties.Resources.c2a;
        }

        private void personelekle_MouseDown(object sender, MouseEventArgs e)
        {
            personelekle.BackgroundImage = Properties.Resources._2ayse;
        }

        //sil

        private void personelsil_MouseEnter(object sender, EventArgs e)
        {
            personelsil.BackgroundImage = Properties.Resources.cdu;
            personelsil.Text = "";
        }
        private void personelsil_MouseLeave(object sender, EventArgs e)
        {
            personelsil.BackgroundImage = Properties.Resources._2duser;
            personelsil.Text = "Personel Sil";
        }

        private void personelsil_MouseClick(object sender, MouseEventArgs e)
        {
            personelsil.BackgroundImage = Properties.Resources.cdu;
        }

        private void personelsil_MouseDown(object sender, MouseEventArgs e)
        {
            personelsil.BackgroundImage = Properties.Resources._2duser;
        }

        //update

        private void personelduzenle_MouseEnter(object sender, EventArgs e)
        {
            personelduzenle.BackgroundImage = Properties.Resources.cu;
            personelduzenle.Text = "";
        }

        private void personelduzenle_MouseLeave(object sender, EventArgs e)
        {
            personelduzenle.BackgroundImage = Properties.Resources.upt2;
            personelduzenle.Text = "Personel Düzenle";
        }

        private void personelduzenle_MouseClick(object sender, MouseEventArgs e)
        {
            personelduzenle.BackgroundImage = Properties.Resources.cu;
        }

        private void personelduzenle_MouseDown(object sender, MouseEventArgs e)
        {
            personelduzenle.BackgroundImage = Properties.Resources.upt2;
        }

        //izin

        private void personelizin_MouseEnter(object sender, EventArgs e)
        {
            personelizin.BackgroundImage = Properties.Resources.cb;
            personelizin.Text = "";
        }

        private void personelizin_MouseLeave(object sender, EventArgs e)
        {
            personelizin.BackgroundImage = Properties.Resources.beee;
            personelizin.Text = "Personel İzin";
        }

        private void personelizin_MouseClick(object sender, MouseEventArgs e)
        {
            personelizin.BackgroundImage = Properties.Resources.cb;
        }

        private void personelizin_MouseDown(object sender, MouseEventArgs e)
        {
            personelizin.BackgroundImage = Properties.Resources.beee;
        }

        private void ileributton_MouseClick(object sender, MouseEventArgs e)
        {
            ileributton.BackgroundImage = Properties.Resources.redb;
        }

      

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
           

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackgroundImage = Properties.Resources.se128renkli;
            button2.Text = "";
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackgroundImage = Properties.Resources.se128;
            button2.Text = "Personel Ara";
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            button2.BackgroundImage = Properties.Resources.se128renkli;
           
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            button2.BackgroundImage = Properties.Resources.se128;
           
        }

        private void personelekle_Click(object sender, EventArgs e)
        {
         
            a = 1;
            personelduzenle.Visible = false;
            personelekle.Visible = false;
            personelsil.Visible = false;
            personelizin.Visible = false;
            
            button2.Visible = false;
            personeleklee ekleprs = new personeleklee();
            ekleprs.TopLevel = false;
            ekleprs.Parent = panel1;

            panel1.Controls.Add(ekleprs);

            ekleprs.Show();
        }

        private void personelsil_Click(object sender, EventArgs e)
        {
            a = 2;
            personelduzenle.Visible = false;
            personelekle.Visible = false;
            personelsil.Visible = false;
            personelizin.Visible = false;
            
            button2.Visible = false;
            personelkaldirr klrd = new personelkaldirr();
            klrd.TopLevel = false;
            klrd.Parent = panel1;

            panel1.Controls.Add(klrd);

            klrd.Show();
        }

        private void personelduzenle_Click(object sender, EventArgs e)
        {
            a = 3;
            personelduzenle.Visible = false;
            personelekle.Visible = false;
            personelsil.Visible = false;
            personelizin.Visible = false;
            
            button2.Visible = false;
            personelduzenlee dzn = new personelduzenlee();
            dzn.TopLevel = false;
            dzn.Parent = panel1;

            panel1.Controls.Add(dzn);

            dzn.Show();
        }

        private void personelizin_Click(object sender, EventArgs e)
        {
            a = 4;
            personelduzenle.Visible = false;
            personelekle.Visible = false;
            personelsil.Visible = false;
            personelizin.Visible = false;
            
            button2.Visible = false;
            personelizinn izn = new personelizinn();
            izn.TopLevel = false;
            izn.Parent = panel1;

            panel1.Controls.Add(izn);

            izn.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = 5;
            personelduzenle.Visible = false;
            personelekle.Visible = false;
            personelsil.Visible = false;
            personelizin.Visible = false;
            
            button2.Visible = false;
            arailan ara = new arailan();
            ara.TopLevel = false;
            ara.Parent = panel1;

            panel1.Controls.Add(ara);

            ara.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a = 6;
            personelduzenle.Visible = false;
            personelekle.Visible = false;
            personelsil.Visible = false;
            personelizin.Visible = false;
           
            button2.Visible = false;
            personelaraa aara = new personelaraa();
            aara.TopLevel = false;
            aara.Parent = panel1;

            panel1.Controls.Add(aara);

            aara.Show();
        }
    }
}
