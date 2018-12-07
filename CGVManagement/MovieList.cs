using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CGVManagement
{
    public partial class MovieList : Form
    {
        public MovieList()
        {
            InitializeComponent();
        }
        private void ActiveChildForm(String name)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    frm.Activate();
                    break;
                }

            }
        }

        private bool CheckExistForm(String name)
        {
            bool check = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }
        private void MovieList_Load(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            if (!CheckExistForm("TheImmortal"))
            {
                TheImmortal sv = new TheImmortal();
               
                sv.Show();
            }
            else
                ActiveChildForm("TheImmortal");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("Goosebumps_2"))
            {
                Goosebumps_2 sv = new Goosebumps_2();

                sv.Show();
            }
            else
                ActiveChildForm("Goosebumps_2");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("Hex"))
            {
                Hex sv = new Hex();

                sv.Show();
            }
            else
                ActiveChildForm("Hex");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("QCTC"))
            {
                QCTC sv = new QCTC();

                sv.Show();
            }
            else
                ActiveChildForm("QCTC");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("Venom"))
            {
                Venom sv = new Venom();

                sv.Show();
            }
            else
                ActiveChildForm("Venom");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("BadTimesAtTheELRoyale"))
            {
                BadTimesAtTheELRoyale sv = new BadTimesAtTheELRoyale();

                sv.Show();
            }
            else
                ActiveChildForm("BadTimesAtTheELRoyale");
        }
    }
}
