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
    public partial class Venom : Form
    {
        string timeStarted;
        public Venom()
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
                sv.name = "Venom";
                sv.Show();
            }
            else
                ActiveChildForm("ChooseSeat");
        }
        string nameMovie = "Venom";
        string theater = "E";
        string time = "112minutes";
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

        private void button3_Click(object sender, EventArgs e)
        {
            timeStarted = button3.Text;
            chooseSeat();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timeStarted = button4.Text;
            chooseSeat();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timeStarted = button5.Text;
            chooseSeat();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            timeStarted = button6.Text;
            chooseSeat();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            timeStarted = button7.Text;
            chooseSeat();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            timeStarted = button8.Text;
            chooseSeat();
        }
    }
}
