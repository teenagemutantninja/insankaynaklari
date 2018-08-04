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
    public partial class ilanekle : Form
    {
        
        public ilanekle()
        {
            InitializeComponent();
        }

        private void personelekle_Click(object sender, EventArgs e)
        {

            ilanekleisveren isvrn = new ilanekleisveren();
            
            isvrn.Show();
         
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ilaneklepersonel prsn = new ilaneklepersonel();

            prsn.Show();
        }

        private void personelekle_MouseClick(object sender, MouseEventArgs e)
        {
            personelekle.BackgroundImage = Properties.Resources.addrenk;
        }

        private void personelekle_MouseDown(object sender, MouseEventArgs e)
        {
            personelekle.BackgroundImage = Properties.Resources.office_briefcase;
        }

        private void personelekle_MouseEnter(object sender, EventArgs e)
        {
            personelekle.BackgroundImage = Properties.Resources.addrenk;
        }

        private void personelekle_MouseLeave(object sender, EventArgs e)
        {
            personelekle.BackgroundImage = Properties.Resources.office_briefcase;
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            button1.BackgroundImage = Properties.Resources.addrenk;
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            button1.BackgroundImage = Properties.Resources.user;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackgroundImage = Properties.Resources.addrenk;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackgroundImage = Properties.Resources.user;
        }
    }
}
