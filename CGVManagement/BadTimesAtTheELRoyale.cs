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
    public partial class BadTimesAtTheELRoyale : Form
    {
        string timeStarted;
        public BadTimesAtTheELRoyale()
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

        private void chooseSeat()
        {
            if (!CheckExistForm("ChooseSeat"))
            {
                ChooseSeat sv = new ChooseSeat();
                sv.timeBeginn = timeStarted;
                sv.name = "BadTimesAtTheELRoyale";
                sv.Show();
            }
            else
                ActiveChildForm("ChooseSeat");
        }
        string nameMovie = "Bad Times At The EL Royale";
        string theater = "F";
        string time = "141minutes";
        public string getNameMovie()
        {
            return nameMovie;
        }

        public string getTheater()
        {
            return theater;
        }

        public string getTime()
        {
            return time;
        }

        public string getTimeStarted()
        {
            return timeStarted;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timeStarted = button1.Text;
            chooseSeat();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timeStarted = button2.Text;
            chooseSeat();
        }
    }
}
