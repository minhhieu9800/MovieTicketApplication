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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
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

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
            if (!CheckExistForm("MovieList"))
            {
                MovieList sv = new MovieList();
                sv.MdiParent = this;
                sv.Show();
            }
            else
                ActiveChildForm("MovieList");
            
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("Payment"))
            {
                Payment sv = new Payment();
                sv.MdiParent = this;
                sv.Show();
            }
            else
                ActiveChildForm("Payment");
        }

       
    }
}
