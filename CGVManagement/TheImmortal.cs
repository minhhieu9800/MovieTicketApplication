using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CGVManagement
{
    public partial class TheImmortal : Form
    {

        string timeStarted;
        public TheImmortal()
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
                sv.name = "TheImmortal";
                sv.Show();
            }
            else
                ActiveChildForm("ChooseSeat");

            
        }
        string nameMovie = "The Immortal";
        string theater = "A";
        string time = "130minutes";
      
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

        private void button9_Click(object sender, EventArgs e)
        {
            timeStarted = button9.Text;
            chooseSeat();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            timeStarted = button10.Text;
            chooseSeat();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            timeStarted = button11.Text;
            chooseSeat();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            timeStarted = button12.Text;
            chooseSeat();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            timeStarted = button13.Text;
            chooseSeat();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            timeStarted = button14.Text;
            chooseSeat();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            timeStarted = button15.Text;
            chooseSeat();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            timeStarted = button16.Text;
            chooseSeat();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            timeStarted = button17.Text;
            chooseSeat();
        }

        private void TheImmortal_Load(object sender, EventArgs e)
        {

        }
    }
}
