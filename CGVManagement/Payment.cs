using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CGVManagement
{
    public partial class Payment : Form
    {
        string connectionString = @"Data Source=DESKTOP-RO89RPR\BINHPCSE62805;Initial Catalog=CGVManagement;Integrated Security=True";
        public Payment()
        {
            InitializeComponent();
        }

        private void tblCGVsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblCGVsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cGVManagementDataSet2);

        }

        private void Payment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cGVManagementDataSet2.tblCGVs' table. You can move, or remove it, as needed.

            refresh();
        }

        public void refresh()
        {
            this.tblCGVsTableAdapter.Fill(this.cGVManagementDataSet2.tblCGVs);
            iDTextBox.Enabled = false;
            nameMovieTextBox.Enabled = false;
            theaterTextBox.Enabled = false;
            seatTextBox.Enabled = false;
            dateDateTimePicker.Enabled = false;
            timeTextBox.Enabled = false;
            timeStartedTextBox.Enabled = false;
            addressTextBox.Enabled = false;
            phoneNumberTextBox.Enabled = false;
            billTextBox.Enabled = false;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                label2.Text = "45000";
                checkBox2.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                label2.Text = "90000";
                checkBox1.Checked = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                int currentIndex = tblCGVsDataGridView.CurrentCell.RowIndex;

                string ID = Convert.ToString(tblCGVsDataGridView.Rows[currentIndex].Cells[0].Value.ToString());

                string bill = label2.Text;
                string sql = "Update tblCGVs set bill='" + bill + "' where ID='" + ID + "'";
                SqlCommand updateCmd = new SqlCommand(sql, conn);
                updateCmd.CommandType = CommandType.Text;
                updateCmd.ExecuteNonQuery();
                MessageBox.Show("Success!", "Message", MessageBoxButtons.OK);
                conn.Close();
                refresh();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                int currentIndex = tblCGVsDataGridView.CurrentCell.RowIndex;

                string ID = Convert.ToString(tblCGVsDataGridView.Rows[currentIndex].Cells[0].Value.ToString());

                string sql = "Delete from tblCGVs where ID='" + ID + "'";
                SqlCommand deleteCmd = new SqlCommand(sql, conn);
                deleteCmd.CommandType = CommandType.Text;
                deleteCmd.ExecuteNonQuery();
                MessageBox.Show("Success!", "Message", MessageBoxButtons.OK);
                conn.Close();
                refresh();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        string text = "ticket";
        int count = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            String textCont = text.Substring(0, 6);
            count++;
            textCont += count;
            
            if (double.Parse(billTextBox.Text) != 0)
            {
                string line = "Movie: " + nameMovieTextBox.Text + "\r\n"
                + "Theater: " + theaterTextBox.Text + "\r\n"
                + "Seat: " + seatTextBox.Text + "\r\n"
                + "DateTime: " + dateDateTimePicker.Text + "\r\n"
                + "Time: " + timeTextBox.Text + "\r\n"
                + "Time Started: " + timeStartedTextBox.Text + "\r\n"
                + "Address: " + addressTextBox.Text + "\r\n"
                + "Phone Number: " + phoneNumberTextBox.Text + "\r\n"
                + "Bill: " + billTextBox.Text + " VND";
                System.IO.File.WriteAllText(textCont, line);
                refresh();
            }
            else
            {
                MessageBox.Show("Error because bill = 0! Please input for bill");
            }
            
        }

        private void tblCGVsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
