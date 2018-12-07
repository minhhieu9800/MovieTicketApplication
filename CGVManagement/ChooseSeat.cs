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
    public partial class ChooseSeat : Form
    {
        int ID = 0;
        ArrayList seat = new ArrayList();
        string connectionString = @"Data Source=DESKTOP-RO89RPR\BINHPCSE62805;Initial Catalog=CGVManagement;Integrated Security=True";
        public ChooseSeat()
        {
            InitializeComponent();
        }
        public void refresh()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string sql = "Select nameMovie, timeStarted, seat, ID from tblCGVs";

            SqlCommand cmd = new SqlCommand(sql, conn);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                if (dr["nameMovie"].ToString().Contains("The Immortal"))
                {
                    if (dr["ID"].ToString() != null)
                    {
                        string core = dr["ID"].ToString().Substring(1);
                        ID = int.Parse(core);
                    }
                    if (dr["timeStarted"].ToString().Contains(timeBeginn))
                    {

                        isButton(dr["seat"].ToString());


                    }

                }
                if (dr["nameMovie"].ToString().Contains("Goosebumps 2: Haunted Halloween"))
                {
                    if (dr["ID"].ToString() != null)
                    {
                        string core = dr["ID"].ToString().Substring(1);
                        ID = int.Parse(core);
                    }
                    if (dr["timeStarted"].ToString().Contains(timeBeginn))
                    {

                        isButton(dr["seat"].ToString());
                    }

                }
                if (dr["nameMovie"].ToString().Contains("Hex"))
                {
                    if (dr["ID"].ToString() != null)
                    {
                        string core = dr["ID"].ToString().Substring(1);
                        ID = int.Parse(core);
                    }
                    if (dr["timeStarted"].ToString().Contains(timeBeginn))
                    {

                        isButton(dr["seat"].ToString());
                    }

                }
                if (dr["nameMovie"].ToString().Contains("Quy Co Thua Ke"))
                {
                    if (dr["ID"].ToString() != null)
                    {
                        string core = dr["ID"].ToString().Substring(1);
                        ID = int.Parse(core);
                    }
                    if (dr["timeStarted"].ToString().Contains(timeBeginn))
                    {

                        isButton(dr["seat"].ToString());
                    }

                }
                if (dr["nameMovie"].ToString().Contains("Venom"))
                {
                    if (dr["ID"].ToString() != null)
                    {
                        string core = dr["ID"].ToString().Substring(1);
                        ID = int.Parse(core);
                    }
                    if (dr["timeStarted"].ToString().Contains(timeBeginn))
                    {

                        isButton(dr["seat"].ToString());
                    }

                }
                if (dr["nameMovie"].ToString().Contains("Bad Times At The EL Royale"))
                {
                    if (dr["ID"].ToString() != null)
                    {
                        string core = dr["ID"].ToString().Substring(1);
                        ID = int.Parse(core);
                    }
                    if (dr["timeStarted"].ToString().Contains(timeBeginn))
                    {

                        isButton(dr["seat"].ToString());
                    }

                }

            }

            A04.Click += MyButtonClick;
            A05.Click += MyButtonClick;
            A06.Click += MyButtonClick;
            A07.Click += MyButtonClick;
            A08.Click += MyButtonClick;
            A09.Click += MyButtonClick;
            A10.Click += MyButtonClick;
            A11.Click += MyButtonClick;
            A12.Click += MyButtonClick;
            A13.Click += MyButtonClick;
            A14.Click += MyButtonClick;
            A15.Click += MyButtonClick;
            A16.Click += MyButtonClick;

            B03.Click += MyButtonClick;
            B04.Click += MyButtonClick;
            B05.Click += MyButtonClick;
            B06.Click += MyButtonClick;
            B07.Click += MyButtonClick;
            B08.Click += MyButtonClick;
            B09.Click += MyButtonClick;
            B10.Click += MyButtonClick;
            B11.Click += MyButtonClick;
            B12.Click += MyButtonClick;
            B13.Click += MyButtonClick;
            B14.Click += MyButtonClick;
            B15.Click += MyButtonClick;
            B16.Click += MyButtonClick;
            B17.Click += MyButtonClick;

            C02.Click += MyButtonClick;
            C03.Click += MyButtonClick;
            C04.Click += MyButtonClick;
            C05.Click += MyButtonClick;
            C06.Click += MyButtonClick;
            C07.Click += MyButtonClick;
            C08.Click += MyButtonClick;
            C09.Click += MyButtonClick;
            C10.Click += MyButtonClick;
            C11.Click += MyButtonClick;
            C12.Click += MyButtonClick;
            C13.Click += MyButtonClick;
            C14.Click += MyButtonClick;
            C15.Click += MyButtonClick;
            C16.Click += MyButtonClick;
            C17.Click += MyButtonClick;
            C18.Click += MyButtonClick;

            D01.Click += MyButtonClick;
            D02.Click += MyButtonClick;
            D03.Click += MyButtonClick;
            D04.Click += MyButtonClick;
            D05.Click += MyButtonClick;
            D06.Click += MyButtonClick;
            D07.Click += MyButtonClick;
            D08.Click += MyButtonClick;
            D09.Click += MyButtonClick;
            D10.Click += MyButtonClick;
            D11.Click += MyButtonClick;
            D12.Click += MyButtonClick;
            D13.Click += MyButtonClick;
            D14.Click += MyButtonClick;
            D15.Click += MyButtonClick;
            D16.Click += MyButtonClick;
            D17.Click += MyButtonClick;
            D18.Click += MyButtonClick;
            D19.Click += MyButtonClick;

            E01.Click += MyButtonClick;
            E02.Click += MyButtonClick;
            E03.Click += MyButtonClick;
            E04.Click += MyButtonClick;
            E05.Click += MyButtonClick;
            E06.Click += MyButtonClick;
            E07.Click += MyButtonClick;
            E08.Click += MyButtonClick;
            E09.Click += MyButtonClick;
            E10.Click += MyButtonClick;
            E11.Click += MyButtonClick;
            E12.Click += MyButtonClick;
            E13.Click += MyButtonClick;
            E14.Click += MyButtonClick;
            E15.Click += MyButtonClick;
            E16.Click += MyButtonClick;
            E17.Click += MyButtonClick;
            E18.Click += MyButtonClick;
            E19.Click += MyButtonClick;

            F01.Click += MyButtonClick;
            F02.Click += MyButtonClick;
            F03.Click += MyButtonClick;
            F04.Click += MyButtonClick;
            F05.Click += MyButtonClick;
            F06.Click += MyButtonClick;
            F07.Click += MyButtonClick;
            F08.Click += MyButtonClick;
            F09.Click += MyButtonClick;
            F10.Click += MyButtonClick;
            F11.Click += MyButtonClick;
            F12.Click += MyButtonClick;
            F13.Click += MyButtonClick;
            F14.Click += MyButtonClick;
            F15.Click += MyButtonClick;
            F16.Click += MyButtonClick;
            F17.Click += MyButtonClick;
            F18.Click += MyButtonClick;
            F19.Click += MyButtonClick;

            G01.Click += MyButtonClick;
            G02.Click += MyButtonClick;
            G03.Click += MyButtonClick;
            G04.Click += MyButtonClick;
            G05.Click += MyButtonClick;
            G06.Click += MyButtonClick;
            G07.Click += MyButtonClick;
            G08.Click += MyButtonClick;
            G09.Click += MyButtonClick;
            G10.Click += MyButtonClick;
            G11.Click += MyButtonClick;
            G12.Click += MyButtonClick;
            G13.Click += MyButtonClick;
            G14.Click += MyButtonClick;
            G15.Click += MyButtonClick;
            G16.Click += MyButtonClick;
            G17.Click += MyButtonClick;
            G18.Click += MyButtonClick;
            G19.Click += MyButtonClick;

            H01.Click += MyButtonClick;
            H02.Click += MyButtonClick;
            H03.Click += MyButtonClick;
            H04.Click += MyButtonClick;
            H05.Click += MyButtonClick;
            H06.Click += MyButtonClick;
            H07.Click += MyButtonClick;
            H08.Click += MyButtonClick;
            H09.Click += MyButtonClick;
            H10.Click += MyButtonClick;
            H11.Click += MyButtonClick;
            H12.Click += MyButtonClick;
            H13.Click += MyButtonClick;
            H14.Click += MyButtonClick;
            H15.Click += MyButtonClick;
            H16.Click += MyButtonClick;
            H17.Click += MyButtonClick;
            H18.Click += MyButtonClick;
            H19.Click += MyButtonClick;

            I01.Click += MyButtonClick;
            I02.Click += MyButtonClick;
            I03.Click += MyButtonClick;
            I04.Click += MyButtonClick;
            I05.Click += MyButtonClick;
            I06.Click += MyButtonClick;
            I07.Click += MyButtonClick;
            I08.Click += MyButtonClick;
            I09.Click += MyButtonClick;
            I10.Click += MyButtonClick;
            I11.Click += MyButtonClick;
            I12.Click += MyButtonClick;
            I13.Click += MyButtonClick;
            I14.Click += MyButtonClick;
            I15.Click += MyButtonClick;
            I16.Click += MyButtonClick;
            I17.Click += MyButtonClick;
            I18.Click += MyButtonClick;
            I19.Click += MyButtonClick;

            J01.Click += MyButtonClick;
            J02.Click += MyButtonClick;
            J03.Click += MyButtonClick;
            J04.Click += MyButtonClick;
            J05.Click += MyButtonClick;
            J06.Click += MyButtonClick;
            J07.Click += MyButtonClick;
            J08.Click += MyButtonClick;
            J09.Click += MyButtonClick;
            J10.Click += MyButtonClick;
            J11.Click += MyButtonClick;
            J12.Click += MyButtonClick;
            J13.Click += MyButtonClick;
            J14.Click += MyButtonClick;
            J15.Click += MyButtonClick;
            J16.Click += MyButtonClick;
            J17.Click += MyButtonClick;
            J18.Click += MyButtonClick;
            J19.Click += MyButtonClick;

            K01.Click += MyButtonClick;
            K02.Click += MyButtonClick;
            K03.Click += MyButtonClick;
            K04.Click += MyButtonClick;
            K05.Click += MyButtonClick;
            K06.Click += MyButtonClick;
            K07.Click += MyButtonClick;
            K08.Click += MyButtonClick;
            K09.Click += MyButtonClick;
            K10.Click += MyButtonClick;
            K11.Click += MyButtonClick;
            K12.Click += MyButtonClick;
            K13.Click += MyButtonClick;
            K14.Click += MyButtonClick;
            K15.Click += MyButtonClick;
            K16.Click += MyButtonClick;
            K17.Click += MyButtonClick;
            K18.Click += MyButtonClick;
            K19.Click += MyButtonClick;

            L01.Click += MyButtonClick;
            L02.Click += MyButtonClick;
            L03.Click += MyButtonClick;
            L04.Click += MyButtonClick;
            L05.Click += MyButtonClick;
            L06.Click += MyButtonClick;
            L07.Click += MyButtonClick;
            L08.Click += MyButtonClick;
            L09.Click += MyButtonClick;
            L10.Click += MyButtonClick;
            L11.Click += MyButtonClick;
            L12.Click += MyButtonClick;
            L13.Click += MyButtonClick;
            L14.Click += MyButtonClick;
            L15.Click += MyButtonClick;
            L16.Click += MyButtonClick;
            L17.Click += MyButtonClick;
            L18.Click += MyButtonClick;
            L19.Click += MyButtonClick;

            M01.Click += MyButtonClick;
            M02.Click += MyButtonClick;
            M03.Click += MyButtonClick;
            M04.Click += MyButtonClick;
            M05.Click += MyButtonClick;
            M06.Click += MyButtonClick;
            M07.Click += MyButtonClick;
            M08.Click += MyButtonClick;
            M09.Click += MyButtonClick;
            M10.Click += MyButtonClick;
            M11.Click += MyButtonClick;
            M12.Click += MyButtonClick;
            M13.Click += MyButtonClick;
            M14.Click += MyButtonClick;
            M15.Click += MyButtonClick;
            M16.Click += MyButtonClick;
            M17.Click += MyButtonClick;
            M18.Click += MyButtonClick;
            M19.Click += MyButtonClick;

            N01.Click += MyButtonClick;
            N02.Click += MyButtonClick;
            N03.Click += MyButtonClick;
            N04.Click += MyButtonClick;
            N05.Click += MyButtonClick;
            N06.Click += MyButtonClick;
            N07.Click += MyButtonClick;
            N08.Click += MyButtonClick;
            N09.Click += MyButtonClick;
            N10.Click += MyButtonClick;
            N11.Click += MyButtonClick;
            N12.Click += MyButtonClick;
            N13.Click += MyButtonClick;
            N14.Click += MyButtonClick;
            N15.Click += MyButtonClick;
            N16.Click += MyButtonClick;
            N17.Click += MyButtonClick;
            N18.Click += MyButtonClick;
            N19.Click += MyButtonClick;

            O01.Click += MyButtonClick;
            O02.Click += MyButtonClick;
            O03.Click += MyButtonClick;
            O04.Click += MyButtonClick;
            O05.Click += MyButtonClick;
            O06.Click += MyButtonClick;
            O07.Click += MyButtonClick;
            O08.Click += MyButtonClick;
            O09.Click += MyButtonClick;
            O10.Click += MyButtonClick;
            O11.Click += MyButtonClick;
            O12.Click += MyButtonClick;
            O13.Click += MyButtonClick;
            O14.Click += MyButtonClick;
            O15.Click += MyButtonClick;
            O16.Click += MyButtonClick;
            O17.Click += MyButtonClick;
            O18.Click += MyButtonClick;
            O19.Click += MyButtonClick;

            P01.Click += MyButtonClick;
            P02.Click += MyButtonClick;
            P03.Click += MyButtonClick;
            P04.Click += MyButtonClick;
            P05.Click += MyButtonClick;
            P06.Click += MyButtonClick;
            P07.Click += MyButtonClick;
            P08.Click += MyButtonClick;
            P09.Click += MyButtonClick;
            P10.Click += MyButtonClick;
            P11.Click += MyButtonClick;
            P12.Click += MyButtonClick;
            P13.Click += MyButtonClick;
            P14.Click += MyButtonClick;
            P15.Click += MyButtonClick;
            P16.Click += MyButtonClick;
            P17.Click += MyButtonClick;
            P18.Click += MyButtonClick;
            P19.Click += MyButtonClick;
        }
        private void ChooseSeat_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button125_Click(object sender, EventArgs e)
        {

        }

        private void G13_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (name.Contains("TheImmortal"))
            {
                TheImmortal();
            }
            if (name.Contains("Goosebumps_2"))
            {
                Goosebumps_2();
            }
            if (name.Contains("Hex"))
            {
                Hex();
            }
            if (name.Contains("Quy Co Thua Ke"))
            {
                QCTC();
            }
            if (name.Contains("Venom"))
            {
                Venom();
            }
            if (name.Contains("BadTimesAtTheELRoyale"))
            {
                BadTimesAtTheELRoyale();
            }

        }

        public void isButton(string cont)
        {
            if (A04.Name.Contains(cont))
            {
                A04.BackColor = Color.Red;
                A04.Enabled = false;
            }
            if (A05.Name.Contains(cont))
            {
                A05.BackColor = Color.Red;
                A05.Enabled = false;
            }
            if (A06.Name.Contains(cont))
            {
                A06.BackColor = Color.Red;
                A06.Enabled = false;
            }
            if (A07.Name.Contains(cont))
            {
                A07.BackColor = Color.Red;
                A07.Enabled = false;
            }
            if (A08.Name.Contains(cont))
            {
                A08.BackColor = Color.Red;
                A08.Enabled = false;
            }
            if (A09.Name.Contains(cont))
            {
                A09.BackColor = Color.Red;
                A09.Enabled = false;
            }
            if (A10.Name.Contains(cont))
            {
                A10.BackColor = Color.Red;
                A10.Enabled = false;
            }
            if (A11.Name.Contains(cont))
            {
                A11.BackColor = Color.Red;
                A11.Enabled = false;
            }
            if (A12.Name.Contains(cont))
            {
                A12.BackColor = Color.Red;
                A12.Enabled = false;
            }
            if (A13.Name.Contains(cont))
            {
                A13.BackColor = Color.Red;
                A13.Enabled = false;
            }
            if (A14.Name.Contains(cont))
            {
                A14.BackColor = Color.Red;
                A14.Enabled = false;
            }
            if (A15.Name.Contains(cont))
            {
                A15.BackColor = Color.Red;
                A15.Enabled = false;
            }
            if (A16.Name.Contains(cont))
            {
                A16.BackColor = Color.Red;
                A16.Enabled = false;
            }

            if (B03.Name.Contains(cont))
            {
                B03.BackColor = Color.Red;
                B03.Enabled = false;
            }
            if (B04.Name.Contains(cont))
            {
                B04.BackColor = Color.Red;
                B04.Enabled = false;
            }
            if (B05.Name.Contains(cont))
            {
                B05.BackColor = Color.Red;
                B05.Enabled = false;
            }
            if (B06.Name.Contains(cont))
            {
                B06.BackColor = Color.Red;
                B06.Enabled = false;
            }
            if (B07.Name.Contains(cont))
            {
                B07.BackColor = Color.Red;
                B07.Enabled = false;
            }
            if (B08.Name.Contains(cont))
            {
                B08.BackColor = Color.Red;
                B08.Enabled = false;
            }
            if (B09.Name.Contains(cont))
            {
                B09.BackColor = Color.Red;
                B09.Enabled = false;
            }
            if (B10.Name.Contains(cont))
            {
                B10.BackColor = Color.Red;
                B10.Enabled = false;
            }
            if (B11.Name.Contains(cont))
            {
                B11.BackColor = Color.Red;
                B11.Enabled = false;
            }
            if (B12.Name.Contains(cont))
            {
                B12.BackColor = Color.Red;
                B12.Enabled = false;
            }
            if (B13.Name.Contains(cont))
            {
                B13.BackColor = Color.Red;
                B13.Enabled = false;
            }
            if (B14.Name.Contains(cont))
            {
                B14.BackColor = Color.Red;
                B14.Enabled = false;
            }
            if (B15.Name.Contains(cont))
            {
                B15.BackColor = Color.Red;
                B15.Enabled = false;
            }
            if (B16.Name.Contains(cont))
            {
                B16.BackColor = Color.Red;
                B16.Enabled = false;
            }
            if (B17.Name.Contains(cont))
            {
                B17.BackColor = Color.Red;
                B17.Enabled = false;
            }

            if (C02.Name.Contains(cont))
            {
                C02.BackColor = Color.Red;
                C02.Enabled = false;
            }
            if (C03.Name.Contains(cont))
            {
                C03.BackColor = Color.Red;
                C03.Enabled = false;
            }
            if (C04.Name.Contains(cont))
            {
                C04.BackColor = Color.Red;
                C04.Enabled = false;
            }
            if (C05.Name.Contains(cont))
            {
                C05.BackColor = Color.Red;
                C05.Enabled = false;
            }
            if (C06.Name.Contains(cont))
            {
                C06.BackColor = Color.Red;
                C06.Enabled = false;
            }
            if (C07.Name.Contains(cont))
            {
                C07.BackColor = Color.Red;
                C07.Enabled = false;
            }
            if (C08.Name.Contains(cont))
            {
                C08.BackColor = Color.Red;
                C08.Enabled = false;
            }
            if (C09.Name.Contains(cont))
            {
                C09.BackColor = Color.Red;
                C09.Enabled = false;
            }
            if (C10.Name.Contains(cont))
            {
                C10.BackColor = Color.Red;
                C10.Enabled = false;
            }
            if (C11.Name.Contains(cont))
            {
                C11.BackColor = Color.Red;
                C11.Enabled = false;
            }
            if (C12.Name.Contains(cont))
            {
                C12.BackColor = Color.Red;
                C12.Enabled = false;
            }
            if (C13.Name.Contains(cont))
            {
                C13.BackColor = Color.Red;
                C13.Enabled = false;
            }
            if (C14.Name.Contains(cont))
            {
                C14.BackColor = Color.Red;
                C14.Enabled = false;
            }
            if (C15.Name.Contains(cont))
            {
                C15.BackColor = Color.Red;
                C15.Enabled = false;
            }
            if (C16.Name.Contains(cont))
            {
                C16.BackColor = Color.Red;
                C16.Enabled = false;
            }
            if (C17.Name.Contains(cont))
            {
                C17.BackColor = Color.Red;
                C17.Enabled = false;
            }
            if (C18.Name.Contains(cont))
            {
                C18.BackColor = Color.Red;
                C18.Enabled = false;
            }

            if (D01.Name.Contains(cont))
            {
                D01.BackColor = Color.Red;
                D01.Enabled = false;
            }
            if (D02.Name.Contains(cont))
            {
                D02.BackColor = Color.Red;
                D02.Enabled = false;
            }
            if (D03.Name.Contains(cont))
            {
                D03.BackColor = Color.Red;
                D03.Enabled = false;
            }
            if (D04.Name.Contains(cont))
            {
                D04.BackColor = Color.Red;
                D04.Enabled = false;
            }
            if (D05.Name.Contains(cont))
            {
                D05.BackColor = Color.Red;
                D05.Enabled = false;
            }
            if (D06.Name.Contains(cont))
            {
                D06.BackColor = Color.Red;
                D06.Enabled = false;
            }
            if (D07.Name.Contains(cont))
            {
                D07.BackColor = Color.Red;
                D07.Enabled = false;
            }
            if (D08.Name.Contains(cont))
            {
                D08.BackColor = Color.Red;
                D08.Enabled = false;
            }
            if (D09.Name.Contains(cont))
            {
                D09.BackColor = Color.Red;
                D09.Enabled = false;
            }
            if (D10.Name.Contains(cont))
            {
                D10.BackColor = Color.Red;
                D10.Enabled = false;
            }
            if (D11.Name.Contains(cont))
            {
                D11.BackColor = Color.Red;
                D11.Enabled = false;
            }
            if (D12.Name.Contains(cont))
            {
                D12.BackColor = Color.Red;
                D12.Enabled = false;
            }
            if (D13.Name.Contains(cont))
            {
                D13.BackColor = Color.Red;
                D13.Enabled = false;
            }
            if (D14.Name.Contains(cont))
            {
                D14.BackColor = Color.Red;
                D14.Enabled = false;
            }
            if (D15.Name.Contains(cont))
            {
                D15.BackColor = Color.Red;
                D15.Enabled = false;
            }
            if (D16.Name.Contains(cont))
            {
                D16.BackColor = Color.Red;
                D16.Enabled = false;
            }
            if (D17.Name.Contains(cont))
            {
                D17.BackColor = Color.Red;
                D17.Enabled = false;
            }
            if (D18.Name.Contains(cont))
            {
                D18.BackColor = Color.Red;
                D18.Enabled = false;
            }
            if (D19.Name.Contains(cont))
            {
                D19.BackColor = Color.Red;
                D19.Enabled = false;
            }

            if (E01.Name.Contains(cont))
            {
                E01.BackColor = Color.Red;
                E01.Enabled = false;
            }
            if (E02.Name.Contains(cont))
            {
                E02.BackColor = Color.Red;
                E02.Enabled = false;
            }
            if (E03.Name.Contains(cont))
            {
                E03.BackColor = Color.Red;
                E03.Enabled = false;
            }
            if (E04.Name.Contains(cont))
            {
                E04.BackColor = Color.Red;
                E04.Enabled = false;
            }
            if (E05.Name.Contains(cont))
            {
                E05.BackColor = Color.Red;
                E05.Enabled = false;
            }
            if (E06.Name.Contains(cont))
            {
                E06.BackColor = Color.Red;
                E06.Enabled = false;
            }
            if (E07.Name.Contains(cont))
            {
                E07.BackColor = Color.Red;
                E07.Enabled = false;
            }
            if (E08.Name.Contains(cont))
            {
                E08.BackColor = Color.Red;
                E08.Enabled = false;
            }
            if (E09.Name.Contains(cont))
            {
                E09.BackColor = Color.Red;
                E09.Enabled = false;
            }
            if (E10.Name.Contains(cont))
            {
                E10.BackColor = Color.Red;
                E10.Enabled = false;
            }
            if (E11.Name.Contains(cont))
            {
                E11.BackColor = Color.Red;
                E11.Enabled = false;
            }
            if (E12.Name.Contains(cont))
            {
                E12.BackColor = Color.Red;
                E12.Enabled = false;
            }
            if (E13.Name.Contains(cont))
            {
                E13.BackColor = Color.Red;
                E13.Enabled = false;
            }
            if (E14.Name.Contains(cont))
            {
                E14.BackColor = Color.Red;
                E14.Enabled = false;
            }
            if (E15.Name.Contains(cont))
            {
                E15.BackColor = Color.Red;
                E15.Enabled = false;
            }
            if (E16.Name.Contains(cont))
            {
                E16.BackColor = Color.Red;
                E16.Enabled = false;
            }
            if (E17.Name.Contains(cont))
            {
                E17.BackColor = Color.Red;
                E17.Enabled = false;
            }
            if (E18.Name.Contains(cont))
            {
                E18.BackColor = Color.Red;
                E18.Enabled = false;
            }
            if (E19.Name.Contains(cont))
            {
                E19.BackColor = Color.Red;
                E19.Enabled = false;
            }

            if (F01.Name.Contains(cont))
            {
                F01.BackColor = Color.Red;
                F01.Enabled = false;
            }
            if (F02.Name.Contains(cont))
            {
                F02.BackColor = Color.Red;
                F02.Enabled = false;
            }
            if (F03.Name.Contains(cont))
            {
                F03.BackColor = Color.Red;
                F03.Enabled = false;
            }
            if (F04.Name.Contains(cont))
            {
                F04.BackColor = Color.Red;
                F04.Enabled = false;
            }
            if (F05.Name.Contains(cont))
            {
                F05.BackColor = Color.Red;
                F05.Enabled = false;
            }
            if (F06.Name.Contains(cont))
            {
                F06.BackColor = Color.Red;
                F06.Enabled = false;
            }
            if (F07.Name.Contains(cont))
            {
                F07.BackColor = Color.Red;
                F07.Enabled = false;
            }
            if (F08.Name.Contains(cont))
            {
                F08.BackColor = Color.Red;
                F08.Enabled = false;
            }
            if (F09.Name.Contains(cont))
            {
                F09.BackColor = Color.Red;
                F09.Enabled = false;
            }
            if (F10.Name.Contains(cont))
            {
                F10.BackColor = Color.Red;
                F10.Enabled = false;
            }
            if (F11.Name.Contains(cont))
            {
                F11.BackColor = Color.Red;
                F11.Enabled = false;
            }
            if (F12.Name.Contains(cont))
            {
                F12.BackColor = Color.Red;
                F12.Enabled = false;
            }
            if (F13.Name.Contains(cont))
            {
                F13.BackColor = Color.Red;
                F13.Enabled = false;
            }
            if (F14.Name.Contains(cont))
            {
                F14.BackColor = Color.Red;
                F14.Enabled = false;
            }
            if (F15.Name.Contains(cont))
            {
                F15.BackColor = Color.Red;
                F15.Enabled = false;
            }
            if (F16.Name.Contains(cont))
            {
                F16.BackColor = Color.Red;
                F16.Enabled = false;
            }
            if (F17.Name.Contains(cont))
            {
                F17.BackColor = Color.Red;
                F17.Enabled = false;
            }
            if (F18.Name.Contains(cont))
            {
                F18.BackColor = Color.Red;
                F18.Enabled = false;
            }
            if (F19.Name.Contains(cont))
            {
                F19.BackColor = Color.Red;
                F19.Enabled = false;
            }

            if (G01.Name.Contains(cont))
            {
                G01.BackColor = Color.Red;
                G01.Enabled = false;
            }
            if (G02.Name.Contains(cont))
            {
                G02.BackColor = Color.Red;
                G02.Enabled = false;
            }
            if (G03.Name.Contains(cont))
            {
                G03.BackColor = Color.Red;
                G03.Enabled = false;
            }
            if (G04.Name.Contains(cont))
            {
                G04.BackColor = Color.Red;
                G04.Enabled = false;
            }
            if (G05.Name.Contains(cont))
            {
                G05.BackColor = Color.Red;
                G05.Enabled = false;
            }
            if (G06.Name.Contains(cont))
            {
                G06.BackColor = Color.Red;
                G06.Enabled = false;
            }
            if (G07.Name.Contains(cont))
            {
                G07.BackColor = Color.Red;
                G07.Enabled = false;
            }
            if (G08.Name.Contains(cont))
            {
                G08.BackColor = Color.Red;
                G08.Enabled = false;
            }
            if (G09.Name.Contains(cont))
            {
                G09.BackColor = Color.Red;
                G09.Enabled = false;
            }
            if (G10.Name.Contains(cont))
            {
                G10.BackColor = Color.Red;
                G10.Enabled = false;
            }
            if (G11.Name.Contains(cont))
            {
                G11.BackColor = Color.Red;
                G11.Enabled = false;
            }
            if (G12.Name.Contains(cont))
            {
                G12.BackColor = Color.Red;
                G12.Enabled = false;
            }
            if (G13.Name.Contains(cont))
            {
                G13.BackColor = Color.Red;
                G13.Enabled = false;
            }
            if (G14.Name.Contains(cont))
            {
                G14.BackColor = Color.Red;
                G14.Enabled = false;
            }
            if (G15.Name.Contains(cont))
            {
                G15.BackColor = Color.Red;
                G15.Enabled = false;
            }
            if (G16.Name.Contains(cont))
            {
                G16.BackColor = Color.Red;
                G16.Enabled = false;
            }
            if (G17.Name.Contains(cont))
            {
                G17.BackColor = Color.Red;
                G17.Enabled = false;
            }
            if (G18.Name.Contains(cont))
            {
                G18.BackColor = Color.Red;
                G18.Enabled = false;
            }
            if (G19.Name.Contains(cont))
            {
                G19.BackColor = Color.Red;
                G19.Enabled = false;
            }

            if (H01.Name.Contains(cont))
            {
                H01.BackColor = Color.Red;
                H01.Enabled = false;
            }
            if (H02.Name.Contains(cont))
            {
                H02.BackColor = Color.Red;
                H02.Enabled = false;
            }
            if (H03.Name.Contains(cont))
            {
                H03.BackColor = Color.Red;
                H03.Enabled = false;
            }
            if (H04.Name.Contains(cont))
            {
                H04.BackColor = Color.Red;
                H04.Enabled = false;
            }
            if (H05.Name.Contains(cont))
            {
                H05.BackColor = Color.Red;
                H05.Enabled = false;
            }
            if (H06.Name.Contains(cont))
            {
                H06.BackColor = Color.Red;
                H06.Enabled = false;
            }
            if (H07.Name.Contains(cont))
            {
                H07.BackColor = Color.Red;
                H07.Enabled = false;
            }
            if (H08.Name.Contains(cont))
            {
                H08.BackColor = Color.Red;
                H08.Enabled = false;
            }
            if (H09.Name.Contains(cont))
            {
                H09.BackColor = Color.Red;
                H09.Enabled = false;
            }
            if (H10.Name.Contains(cont))
            {
                H10.BackColor = Color.Red;
                H10.Enabled = false;
            }
            if (H11.Name.Contains(cont))
            {
                H11.BackColor = Color.Red;
                H11.Enabled = false;
            }
            if (H12.Name.Contains(cont))
            {
                H12.BackColor = Color.Red;
                H12.Enabled = false;
            }
            if (H13.Name.Contains(cont))
            {
                H13.BackColor = Color.Red;
                H13.Enabled = false;
            }
            if (H14.Name.Contains(cont))
            {
                H14.BackColor = Color.Red;
                H14.Enabled = false;
            }
            if (H15.Name.Contains(cont))
            {
                H15.BackColor = Color.Red;
                H15.Enabled = false;
            }
            if (H16.Name.Contains(cont))
            {
                H16.BackColor = Color.Red;
                H16.Enabled = false;
            }
            if (H17.Name.Contains(cont))
            {
                H17.BackColor = Color.Red;
                H17.Enabled = false;
            }
            if (H18.Name.Contains(cont))
            {
                H18.BackColor = Color.Red;
                H18.Enabled = false;
            }
            if (H19.Name.Contains(cont))
            {
                H19.BackColor = Color.Red;
                H19.Enabled = false;
            }

            if (I01.Name.Contains(cont))
            {
                I01.BackColor = Color.Red;
                I01.Enabled = false;
            }
            if (I02.Name.Contains(cont))
            {
                I02.BackColor = Color.Red;
                I02.Enabled = false;
            }
            if (I03.Name.Contains(cont))
            {
                I03.BackColor = Color.Red;
                I03.Enabled = false;
            }
            if (I04.Name.Contains(cont))
            {
                I04.BackColor = Color.Red;
                I04.Enabled = false;
            }
            if (I05.Name.Contains(cont))
            {
                I05.BackColor = Color.Red;
                I05.Enabled = false;
            }
            if (I06.Name.Contains(cont))
            {
                I06.BackColor = Color.Red;
                I06.Enabled = false;
            }
            if (I07.Name.Contains(cont))
            {
                I07.BackColor = Color.Red;
                I07.Enabled = false;
            }
            if (I08.Name.Contains(cont))
            {
                I08.BackColor = Color.Red;
                I08.Enabled = false;
            }
            if (I09.Name.Contains(cont))
            {
                I09.BackColor = Color.Red;
                I09.Enabled = false;
            }
            if (I10.Name.Contains(cont))
            {
                I10.BackColor = Color.Red;
                I10.Enabled = false;
            }
            if (I11.Name.Contains(cont))
            {
                I11.BackColor = Color.Red;
                I11.Enabled = false;
            }
            if (I12.Name.Contains(cont))
            {
                I12.BackColor = Color.Red;
                I12.Enabled = false;
            }
            if (I13.Name.Contains(cont))
            {
                I13.BackColor = Color.Red;
                I13.Enabled = false;
            }
            if (I14.Name.Contains(cont))
            {
                I14.BackColor = Color.Red;
                I14.Enabled = false;
            }
            if (I15.Name.Contains(cont))
            {
                I15.BackColor = Color.Red;
                I15.Enabled = false;
            }
            if (I16.Name.Contains(cont))
            {
                I16.BackColor = Color.Red;
                I16.Enabled = false;
            }
            if (I17.Name.Contains(cont))
            {
                I17.BackColor = Color.Red;
                I17.Enabled = false;
            }
            if (I18.Name.Contains(cont))
            {
                I18.BackColor = Color.Red;
                I18.Enabled = false;
            }
            if (I19.Name.Contains(cont))
            {
                I19.BackColor = Color.Red;
                I19.Enabled = false;
            }

            if (J01.Name.Contains(cont))
            {
                J01.BackColor = Color.Red;
                J01.Enabled = false;
            }
            if (J02.Name.Contains(cont))
            {
                J02.BackColor = Color.Red;
                J02.Enabled = false;
            }
            if (J03.Name.Contains(cont))
            {
                J03.BackColor = Color.Red;
                J03.Enabled = false;
            }
            if (J04.Name.Contains(cont))
            {
                J04.BackColor = Color.Red;
                J04.Enabled = false;
            }
            if (J05.Name.Contains(cont))
            {
                J05.BackColor = Color.Red;
                J05.Enabled = false;
            }
            if (J06.Name.Contains(cont))
            {
                J06.BackColor = Color.Red;
                J06.Enabled = false;
            }
            if (J07.Name.Contains(cont))
            {
                J07.BackColor = Color.Red;
                J07.Enabled = false;
            }
            if (J08.Name.Contains(cont))
            {
                J08.BackColor = Color.Red;
                J08.Enabled = false;
            }
            if (J09.Name.Contains(cont))
            {
                J09.BackColor = Color.Red;
                J09.Enabled = false;
            }
            if (J10.Name.Contains(cont))
            {
                J10.BackColor = Color.Red;
                J10.Enabled = false;
            }
            if (J11.Name.Contains(cont))
            {
                J11.BackColor = Color.Red;
                J11.Enabled = false;
            }
            if (J12.Name.Contains(cont))
            {
                J12.BackColor = Color.Red;
                J12.Enabled = false;
            }
            if (J13.Name.Contains(cont))
            {
                J13.BackColor = Color.Red;
                J13.Enabled = false;
            }
            if (J14.Name.Contains(cont))
            {
                J14.BackColor = Color.Red;
                J14.Enabled = false;
            }
            if (J15.Name.Contains(cont))
            {
                J15.BackColor = Color.Red;
                J15.Enabled = false;
            }
            if (J16.Name.Contains(cont))
            {
                J16.BackColor = Color.Red;
                J16.Enabled = false;
            }
            if (J17.Name.Contains(cont))
            {
                J17.BackColor = Color.Red;
                J17.Enabled = false;
            }
            if (J18.Name.Contains(cont))
            {
                J18.BackColor = Color.Red;
                J18.Enabled = false;
            }
            if (J19.Name.Contains(cont))
            {
                J19.BackColor = Color.Red;
                J19.Enabled = false;
            }

            if (K01.Name.Contains(cont))
            {
                K01.BackColor = Color.Red;
                K01.Enabled = false;
            }
            if (K02.Name.Contains(cont))
            {
                K02.BackColor = Color.Red;
                K02.Enabled = false;
            }
            if (K03.Name.Contains(cont))
            {
                K03.BackColor = Color.Red;
                K03.Enabled = false;
            }
            if (K04.Name.Contains(cont))
            {
                K04.BackColor = Color.Red;
                K04.Enabled = false;
            }
            if (K05.Name.Contains(cont))
            {
                K05.BackColor = Color.Red;
                K05.Enabled = false;
            }
            if (K06.Name.Contains(cont))
            {
                K06.BackColor = Color.Red;
                K06.Enabled = false;
            }
            if (K07.Name.Contains(cont))
            {
                K07.BackColor = Color.Red;
                K07.Enabled = false;
            }
            if (K08.Name.Contains(cont))
            {
                K08.BackColor = Color.Red;
                K08.Enabled = false;
            }
            if (K09.Name.Contains(cont))
            {
                K09.BackColor = Color.Red;
                K09.Enabled = false;
            }
            if (K10.Name.Contains(cont))
            {
                K10.BackColor = Color.Red;
                K10.Enabled = false;
            }
            if (K11.Name.Contains(cont))
            {
                K11.BackColor = Color.Red;
                K11.Enabled = false;
            }
            if (K12.Name.Contains(cont))
            {
                K12.BackColor = Color.Red;
                K12.Enabled = false;
            }
            if (K13.Name.Contains(cont))
            {
                K13.BackColor = Color.Red;
                K13.Enabled = false;
            }
            if (K14.Name.Contains(cont))
            {
                K14.BackColor = Color.Red;
                K14.Enabled = false;
            }
            if (K15.Name.Contains(cont))
            {
                K15.BackColor = Color.Red;
                K15.Enabled = false;
            }
            if (K16.Name.Contains(cont))
            {
                K16.BackColor = Color.Red;
                K16.Enabled = false;
            }
            if (K17.Name.Contains(cont))
            {
                K17.BackColor = Color.Red;
                K17.Enabled = false;
            }
            if (K18.Name.Contains(cont))
            {
                K18.BackColor = Color.Red;
                K18.Enabled = false;
            }
            if (K19.Name.Contains(cont))
            {
                K19.BackColor = Color.Red;
                K19.Enabled = false;
            }

            if (L01.Name.Contains(cont))
            {
                L01.BackColor = Color.Red;
                L01.Enabled = false;
            }
            if (L02.Name.Contains(cont))
            {
                L02.BackColor = Color.Red;
                L02.Enabled = false;
            }
            if (L03.Name.Contains(cont))
            {
                L03.BackColor = Color.Red;
                L03.Enabled = false;
            }
            if (L04.Name.Contains(cont))
            {
                L04.BackColor = Color.Red;
                L04.Enabled = false;
            }
            if (L05.Name.Contains(cont))
            {
                L05.BackColor = Color.Red;
                L05.Enabled = false;
            }
            if (L06.Name.Contains(cont))
            {
                L06.BackColor = Color.Red;
                L06.Enabled = false;
            }
            if (L07.Name.Contains(cont))
            {
                L07.BackColor = Color.Red;
                L07.Enabled = false;
            }
            if (L08.Name.Contains(cont))
            {
                L08.BackColor = Color.Red;
                L08.Enabled = false;
            }
            if (L09.Name.Contains(cont))
            {
                L09.BackColor = Color.Red;
                L09.Enabled = false;
            }
            if (L10.Name.Contains(cont))
            {
                L10.BackColor = Color.Red;
                L10.Enabled = false;
            }
            if (L11.Name.Contains(cont))
            {
                L11.BackColor = Color.Red;
                L11.Enabled = false;
            }
            if (L12.Name.Contains(cont))
            {
                L12.BackColor = Color.Red;
                L12.Enabled = false;
            }
            if (L13.Name.Contains(cont))
            {
                L13.BackColor = Color.Red;
                L13.Enabled = false;
            }
            if (L14.Name.Contains(cont))
            {
                L14.BackColor = Color.Red;
                L14.Enabled = false;
            }
            if (L15.Name.Contains(cont))
            {
                L15.BackColor = Color.Red;
                L15.Enabled = false;
            }
            if (L16.Name.Contains(cont))
            {
                L16.BackColor = Color.Red;
                L16.Enabled = false;
            }
            if (L17.Name.Contains(cont))
            {
                L17.BackColor = Color.Red;
                L17.Enabled = false;
            }
            if (L18.Name.Contains(cont))
            {
                L18.BackColor = Color.Red;
                L18.Enabled = false;
            }
            if (L19.Name.Contains(cont))
            {
                L19.BackColor = Color.Red;
                L19.Enabled = false;
            }

            if (M01.Name.Contains(cont))
            {
                M01.BackColor = Color.Red;
                M01.Enabled = false;
            }
            if (M02.Name.Contains(cont))
            {
                M02.BackColor = Color.Red;
                M02.Enabled = false;
            }
            if (M03.Name.Contains(cont))
            {
                M03.BackColor = Color.Red;
                M03.Enabled = false;
            }
            if (M04.Name.Contains(cont))
            {
                M04.BackColor = Color.Red;
                M04.Enabled = false;
            }
            if (M05.Name.Contains(cont))
            {
                M05.BackColor = Color.Red;
                M05.Enabled = false;
            }
            if (M06.Name.Contains(cont))
            {
                M06.BackColor = Color.Red;
                M06.Enabled = false;
            }
            if (M07.Name.Contains(cont))
            {
                M07.BackColor = Color.Red;
                M07.Enabled = false;
            }
            if (M08.Name.Contains(cont))
            {
                M08.BackColor = Color.Red;
                M08.Enabled = false;
            }
            if (M09.Name.Contains(cont))
            {
                M09.BackColor = Color.Red;
                M09.Enabled = false;
            }
            if (M10.Name.Contains(cont))
            {
                M10.BackColor = Color.Red;
                M10.Enabled = false;
            }
            if (M11.Name.Contains(cont))
            {
                M11.BackColor = Color.Red;
                M11.Enabled = false;
            }
            if (M12.Name.Contains(cont))
            {
                M12.BackColor = Color.Red;
                M12.Enabled = false;
            }
            if (M13.Name.Contains(cont))
            {
                M13.BackColor = Color.Red;
                M13.Enabled = false;
            }
            if (M14.Name.Contains(cont))
            {
                M14.BackColor = Color.Red;
                M14.Enabled = false;
            }
            if (M15.Name.Contains(cont))
            {
                M15.BackColor = Color.Red;
                M15.Enabled = false;
            }
            if (M16.Name.Contains(cont))
            {
                M16.BackColor = Color.Red;
                M16.Enabled = false;
            }
            if (M17.Name.Contains(cont))
            {
                M17.BackColor = Color.Red;
                M17.Enabled = false;
            }
            if (M18.Name.Contains(cont))
            {
                M18.BackColor = Color.Red;
                M18.Enabled = false;
            }
            if (M19.Name.Contains(cont))
            {
                M19.BackColor = Color.Red;
                M19.Enabled = false;
            }

            if (N01.Name.Contains(cont))
            {
                N01.BackColor = Color.Red;
                N01.Enabled = false;
            }
            if (N02.Name.Contains(cont))
            {
                N02.BackColor = Color.Red;
                N02.Enabled = false;
            }
            if (N03.Name.Contains(cont))
            {
                N03.BackColor = Color.Red;
                N03.Enabled = false;
            }
            if (N04.Name.Contains(cont))
            {
                N04.BackColor = Color.Red;
                N04.Enabled = false;
            }
            if (N05.Name.Contains(cont))
            {
                N05.BackColor = Color.Red;
                N05.Enabled = false;
            }
            if (N06.Name.Contains(cont))
            {
                N06.BackColor = Color.Red;
                N06.Enabled = false;
            }
            if (N07.Name.Contains(cont))
            {
                N07.BackColor = Color.Red;
                N07.Enabled = false;
            }
            if (N08.Name.Contains(cont))
            {
                N08.BackColor = Color.Red;
                N08.Enabled = false;
            }
            if (N09.Name.Contains(cont))
            {
                N09.BackColor = Color.Red;
                N09.Enabled = false;
            }
            if (N10.Name.Contains(cont))
            {
                N10.BackColor = Color.Red;
                N10.Enabled = false;
            }
            if (N11.Name.Contains(cont))
            {
                N11.BackColor = Color.Red;
                N11.Enabled = false;
            }
            if (N12.Name.Contains(cont))
            {
                N12.BackColor = Color.Red;
                N12.Enabled = false;
            }
            if (N13.Name.Contains(cont))
            {
                N13.BackColor = Color.Red;
                N13.Enabled = false;
            }
            if (N14.Name.Contains(cont))
            {
                N14.BackColor = Color.Red;
                N14.Enabled = false;
            }
            if (N15.Name.Contains(cont))
            {
                N15.BackColor = Color.Red;
                N15.Enabled = false;
            }
            if (N16.Name.Contains(cont))
            {
                N16.BackColor = Color.Red;
                N16.Enabled = false;
            }
            if (N17.Name.Contains(cont))
            {
                N17.BackColor = Color.Red;
                N17.Enabled = false;
            }
            if (N18.Name.Contains(cont))
            {
                N18.BackColor = Color.Red;
                N18.Enabled = false;
            }
            if (N19.Name.Contains(cont))
            {
                N19.BackColor = Color.Red;
                N19.Enabled = false;
            }

            if (O01.Name.Contains(cont))
            {
                O01.BackColor = Color.Red;
                O01.Enabled = false;
            }
            if (O02.Name.Contains(cont))
            {
                O02.BackColor = Color.Red;
                O02.Enabled = false;
            }
            if (O03.Name.Contains(cont))
            {
                O03.BackColor = Color.Red;
                O03.Enabled = false;
            }
            if (O04.Name.Contains(cont))
            {
                O04.BackColor = Color.Red;
                O04.Enabled = false;
            }
            if (O05.Name.Contains(cont))
            {
                O05.BackColor = Color.Red;
                O05.Enabled = false;
            }
            if (O06.Name.Contains(cont))
            {
                O06.BackColor = Color.Red;
                O06.Enabled = false;
            }
            if (O07.Name.Contains(cont))
            {
                O07.BackColor = Color.Red;
                O07.Enabled = false;
            }
            if (O08.Name.Contains(cont))
            {
                O08.BackColor = Color.Red;
                O08.Enabled = false;
            }
            if (O09.Name.Contains(cont))
            {
                O09.BackColor = Color.Red;
                O09.Enabled = false;
            }
            if (O10.Name.Contains(cont))
            {
                O10.BackColor = Color.Red;
                O10.Enabled = false;
            }
            if (O11.Name.Contains(cont))
            {
                O11.BackColor = Color.Red;
                O11.Enabled = false;
            }
            if (O12.Name.Contains(cont))
            {
                O12.BackColor = Color.Red;
                O12.Enabled = false;
            }
            if (O13.Name.Contains(cont))
            {
                O13.BackColor = Color.Red;
                O13.Enabled = false;
            }
            if (O14.Name.Contains(cont))
            {
                O14.BackColor = Color.Red;
                O14.Enabled = false;
            }
            if (O15.Name.Contains(cont))
            {
                O15.BackColor = Color.Red;
                O15.Enabled = false;
            }
            if (O16.Name.Contains(cont))
            {
                O16.BackColor = Color.Red;
                O16.Enabled = false;
            }
            if (O17.Name.Contains(cont))
            {
                O17.BackColor = Color.Red;
                O17.Enabled = false;
            }
            if (O18.Name.Contains(cont))
            {
                O18.BackColor = Color.Red;
                O18.Enabled = false;
            }
            if (O19.Name.Contains(cont))
            {
                O19.BackColor = Color.Red;
                O19.Enabled = false;
            }

            if (P01.Name.Contains(cont))
            {
                P01.BackColor = Color.Red;
                P01.Enabled = false;
            }
            if (P02.Name.Contains(cont))
            {
                P02.BackColor = Color.Red;
                P02.Enabled = false;
            }
            if (P03.Name.Contains(cont))
            {
                P03.BackColor = Color.Red;
                P03.Enabled = false;
            }
            if (P04.Name.Contains(cont))
            {
                P04.BackColor = Color.Red;
                P04.Enabled = false;
            }
            if (P05.Name.Contains(cont))
            {
                P05.BackColor = Color.Red;
                P05.Enabled = false;
            }
            if (P06.Name.Contains(cont))
            {
                P06.BackColor = Color.Red;
                P06.Enabled = false;
            }
            if (P07.Name.Contains(cont))
            {
                P07.BackColor = Color.Red;
                P07.Enabled = false;
            }
            if (P08.Name.Contains(cont))
            {
                P08.BackColor = Color.Red;
                P08.Enabled = false;
            }
            if (P09.Name.Contains(cont))
            {
                P09.BackColor = Color.Red;
                P09.Enabled = false;
            }
            if (P10.Name.Contains(cont))
            {
                P10.BackColor = Color.Red;
                P10.Enabled = false;
            }
            if (P11.Name.Contains(cont))
            {
                P11.BackColor = Color.Red;
                P11.Enabled = false;
            }
            if (P12.Name.Contains(cont))
            {
                P12.BackColor = Color.Red;
                P12.Enabled = false;
            }
            if (P13.Name.Contains(cont))
            {
                P13.BackColor = Color.Red;
                P13.Enabled = false;
            }
            if (P14.Name.Contains(cont))
            {
                P14.BackColor = Color.Red;
                P14.Enabled = false;
            }
            if (P15.Name.Contains(cont))
            {
                P15.BackColor = Color.Red;
                P15.Enabled = false;
            }
            if (P16.Name.Contains(cont))
            {
                P16.BackColor = Color.Red;
                P16.Enabled = false;
            }
            if (P17.Name.Contains(cont))
            {
                P17.BackColor = Color.Red;
                P17.Enabled = false;
            }
            if (P18.Name.Contains(cont))
            {
                P18.BackColor = Color.Red;
                P18.Enabled = false;
            }
            if (P19.Name.Contains(cont))
            {
                P19.BackColor = Color.Red;
                P19.Enabled = false;
            }

        }
        bool cont = false;
        public string timeBeginn;
        public string name;
        
        public void TheImmortal()
        {
        
            TheImmortal ti = new TheImmortal();
            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                foreach (object obj in seat)
                {
                    ID++;
                    string nameMovie = ti.getNameMovie();
                    string theater = ti.getTheater();
                    string seat = obj.ToString();
                    DateTime date = DateTime.Now;
                    string time = ti.getTime();
                    string timeBegin = timeBeginn;
                    string address = "119B Nguyen Van Qua Street, Đong Hung Thuan, Q.12";
                    string phoneNumber = "1900 2224";
                    string bill = null;
                    string sql = "Insert into tblCGVs values('" + 'A' + ID + "','" + nameMovie + "','"  + theater + "','" + seat + "','" + date + "','" + time + "','" + timeBegin + "','" + address + "','" + phoneNumber + "','" + bill + "')";
                    SqlCommand updateCmd = new SqlCommand(sql, conn);
                    updateCmd.CommandType = CommandType.Text;
                    updateCmd.ExecuteNonQuery();

                }
                
                MessageBox.Show("Insert success!", "THÔNG BÁO", MessageBoxButtons.OK);
                conn.Close();
                this.Close();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Goosebumps_2()
        {

            Goosebumps_2 ti = new Goosebumps_2();
            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                foreach (object obj in seat)
                {
                    ID++;
                    string nameMovie = ti.getNameMovie();
                    string theater = ti.getTheater();
                    string seat = obj.ToString();
                    DateTime date = DateTime.Now;
                    string time = ti.getTime();
                    string timeBegin = timeBeginn;
                    string address = "119B Nguyen Van Qua Street, Đong Hung Thuan, Q.12";
                    string phoneNumber = "1900 2224";
                    string bill = null;
                    string sql = "Insert into tblCGVs values('" + 'B' + ID + "','" + nameMovie + "','" + theater + "','" + seat + "','" + date + "','" + time + "','" + timeBegin + "','" + address + "','" + phoneNumber + "','" + bill + "')";
                    SqlCommand updateCmd = new SqlCommand(sql, conn);
                    updateCmd.CommandType = CommandType.Text;
                    updateCmd.ExecuteNonQuery();

                }

                MessageBox.Show("Insert success!", "THÔNG BÁO", MessageBoxButtons.OK);
                conn.Close();
                this.Close();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Hex()
        {

            Hex ti = new Hex();
            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                foreach (object obj in seat)
                {
                    ID++;
                    string nameMovie = ti.getNameMovie();
                    string theater = ti.getTheater();
                    string seat = obj.ToString();
                    DateTime date = DateTime.Now;
                    string time = ti.getTime();
                    string timeBegin = timeBeginn;
                    string address = "119B Nguyen Van Qua Street, Đong Hung Thuan, Q.12";
                    string phoneNumber = "1900 2224";
                    string bill = null;
                    string sql = "Insert into tblCGVs values('" + 'C' + ID + "','" + nameMovie + "','" + theater + "','" + seat + "','" + date + "','" + time + "','" + timeBegin + "','" + address + "','" + phoneNumber + "','" + bill + "')";
                    SqlCommand updateCmd = new SqlCommand(sql, conn);
                    updateCmd.CommandType = CommandType.Text;
                    updateCmd.ExecuteNonQuery();

                }

                MessageBox.Show("Insert success!", "THÔNG BÁO", MessageBoxButtons.OK);
                conn.Close();
                this.Close();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void QCTC()
        {

            QCTC ti = new QCTC();
            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                foreach (object obj in seat)
                {
                    ID++;
                    string nameMovie = ti.getNameMovie();
                    string theater = ti.getTheater();
                    string seat = obj.ToString();
                    DateTime date = DateTime.Now;
                    string time = ti.getTime();
                    string timeBegin = timeBeginn;
                    string address = "119B Nguyen Van Qua Street, Đong Hung Thuan, Q.12";
                    string phoneNumber = "1900 2224";
                    string bill = null;
                    string sql = "Insert into tblCGVs values('" + 'D' + ID + "','" + nameMovie + "','" + theater + "','" + seat + "','" + date + "','" + time + "','" + timeBegin + "','" + address + "','" + phoneNumber + "','" + bill + "')";
                    SqlCommand updateCmd = new SqlCommand(sql, conn);
                    updateCmd.CommandType = CommandType.Text;
                    updateCmd.ExecuteNonQuery();

                }

                MessageBox.Show("Insert success!", "THÔNG BÁO", MessageBoxButtons.OK);
                conn.Close();
                this.Close();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Venom()
        {

            Venom ti = new Venom();
            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                foreach (object obj in seat)
                {
                    ID++;
                    string nameMovie = ti.getNameMovie();
                    string theater = ti.getTheater();
                    string seat = obj.ToString();
                    DateTime date = DateTime.Now;
                    string time = ti.getTime();
                    string timeBegin = timeBeginn;
                    string address = "119B Nguyen Van Qua Street, Đong Hung Thuan, Q.12";
                    string phoneNumber = "1900 2224";
                    string bill = null;
                    string sql = "Insert into tblCGVs values('" + 'E' + ID + "','" + nameMovie + "','" + theater + "','" + seat + "','" + date + "','" + time + "','" + timeBegin + "','" + address + "','" + phoneNumber + "','" + bill + "')";
                    SqlCommand updateCmd = new SqlCommand(sql, conn);
                    updateCmd.CommandType = CommandType.Text;
                    updateCmd.ExecuteNonQuery();

                }

                MessageBox.Show("Insert success!", "THÔNG BÁO", MessageBoxButtons.OK);
                conn.Close();
                this.Close();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void BadTimesAtTheELRoyale()
        {

            BadTimesAtTheELRoyale ti = new BadTimesAtTheELRoyale();
            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                foreach (object obj in seat)
                {
                    ID++;
                    string nameMovie = ti.getNameMovie();
                    string theater = ti.getTheater();
                    string seat = obj.ToString();
                    DateTime date = DateTime.Now;
                    string time = ti.getTime();
                    string timeBegin = timeBeginn;
                    string address = "119B Nguyen Van Qua Street, Đong Hung Thuan, Q.12";
                    string phoneNumber = "1900 2224";
                    string bill = null;
                    string sql = "Insert into tblCGVs values('" + 'F' + ID + "','" + nameMovie + "','" + theater + "','" + seat + "','" + date + "','" + time + "','" + timeBegin + "','" + address + "','" + phoneNumber + "','" + bill + "')";
                    SqlCommand updateCmd = new SqlCommand(sql, conn);
                    updateCmd.CommandType = CommandType.Text;
                    updateCmd.ExecuteNonQuery();

                }

                MessageBox.Show("Insert success!", "THÔNG BÁO", MessageBoxButtons.OK);
                conn.Close();
                this.Close();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void MyButtonClick(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (cont == false)
            {
                button.BackColor = Color.Red;
                
                if(seat.Count == 0)
                {
                    seat.Add(button.Name);

                }
                
                bool bo = false;
                foreach (object obj in seat)
                {
                    if ((button.Name).Equals(obj.ToString()))
                    {
                        bo = true;
                    }
                   
                }
               
                if(bo == false)
                {
                    seat.Add(button.Name);
                }

                
            }
            if (cont == true)
            {
                button.BackColor = Color.DarkBlue;
                seat.Remove(button.Name);
            }
            if (cont == false)
            {
                cont = true;
            }
            else
            {
                cont = false;
            }
        }

        
        private void A04_Click(object sender, EventArgs e)
        {
            
            
        }

        private void A05_Click(object sender, EventArgs e)
        {
           
        }

        public void delete(String ID)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string sql = "Delete from tblCGVs where ID='" + ID + "'";
            SqlCommand deleteCmd = new SqlCommand(sql, conn);
            deleteCmd.CommandType = CommandType.Text;
            deleteCmd.ExecuteNonQuery();
            
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string sql = "Select nameMovie, timeStarted, seat, ID from tblCGVs";

            SqlCommand cmd = new SqlCommand(sql, conn);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                if (dr["nameMovie"].ToString().Contains("The Immortal"))
                {
                    
                    if (dr["timeStarted"].ToString().Contains(timeBeginn))
                    {

                        delete(dr["ID"].ToString());
                        

                    }

                }
                if (dr["nameMovie"].ToString().Contains("Goosebumps 2: Haunted Halloween"))
                {
                    
                    if (dr["timeStarted"].ToString().Contains(timeBeginn))
                    {

                        delete(dr["ID"].ToString());
                        

                    }

                }
                if (dr["nameMovie"].ToString().Contains("Hex"))
                {
                    
                    if (dr["timeStarted"].ToString().Contains(timeBeginn))
                    {

                        delete(dr["ID"].ToString());
                        

                    }

                }
                if (dr["nameMovie"].ToString().Contains("Quy Co Thua Ke"))
                {
                    
                    if (dr["timeStarted"].ToString().Contains(timeBeginn))
                    {

                        delete(dr["ID"].ToString());
                        

                    }

                }
                if (dr["nameMovie"].ToString().Contains("Venom"))
                {
                    
                    if (dr["timeStarted"].ToString().Contains(timeBeginn))
                    {

                        delete(dr["ID"].ToString());
                        

                    }

                }
                if (dr["nameMovie"].ToString().Contains("Bad Times At The EL Royale"))
                {
                    
                    if (dr["timeStarted"].ToString().Contains(timeBeginn))
                    {
                        delete(dr["ID"].ToString());
                        

                    }

                }

            }
            MessageBox.Show("Success!", "Message", MessageBoxButtons.OK);
            this.Close();
            
        }
    }
}
