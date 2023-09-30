using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p4
{
    public partial class Form1 : Form
    {

        String jenis;

        public Form1()
        {
            InitializeComponent();
        }

        private void rdRoda2_CheckedChanged(object sender, EventArgs e)
        {
            jenis = "roda 2";
        }

        private void rdRoda4_CheckedChanged(object sender, EventArgs e)
        {
            jenis = "roda 4";
        }

        private void cbServiceRingan_CheckedChanged(object sender, EventArgs e)
        {
            if (jenis == "roda 2")
            {
                if (cbServiceRingan.Checked)
                {
                    txtServiceRingan.Text = "50000";

                    int totalbiaya = int.Parse(txtTotalBiaya.Text) + 50000;
                    txtTotalBiaya.Text = totalbiaya.ToString();
                } 
                else
                {
                    txtServiceRingan.Text = "0";

                    int totalbiaya = int.Parse(txtTotalBiaya.Text) - 50000;
                    txtTotalBiaya.Text = totalbiaya.ToString();
                }
            }
            else if (jenis == "roda 4")
            {
                if (cbServiceRingan.Checked)
                {
                    txtServiceRingan.Text = "350000";

                    int totalbiaya = int.Parse(txtTotalBiaya.Text) + 350000;
                    txtTotalBiaya.Text = totalbiaya.ToString();
                }
                else
                {
                    txtServiceRingan.Text = "0";

                    int totalbiaya = int.Parse(txtTotalBiaya.Text) - 350000;
                    txtTotalBiaya.Text = totalbiaya.ToString();
                }
            }
        }

        private void cbServiceLengkap_CheckedChanged(object sender, EventArgs e)
        {
            if (jenis == "roda 2")
            {
                if (cbServiceLengkap.Checked)
                {
                    txtServiceLengkap.Text = "250000";

                    int totalbiaya = int.Parse(txtTotalBiaya.Text) + 250000;
                    txtTotalBiaya.Text = totalbiaya.ToString();
                }
                else
                {
                    txtServiceLengkap.Text = "0";

                    int totalbiaya = int.Parse(txtTotalBiaya.Text) - 250000;
                    txtTotalBiaya.Text = totalbiaya.ToString();
                }
            }
            else if (jenis == "roda 4")
            {
                if (cbServiceLengkap.Checked)
                {
                    txtServiceLengkap.Text = "750000";

                    int totalbiaya = int.Parse(txtTotalBiaya.Text) + 750000;
                    txtTotalBiaya.Text = totalbiaya.ToString();
                }
                else
                {
                    txtServiceLengkap.Text = "0";

                    int totalbiaya = int.Parse(txtTotalBiaya.Text) - 750000;
                    txtTotalBiaya.Text = totalbiaya.ToString();
                }
            }
        }

        private void cbGantiOli_CheckedChanged(object sender, EventArgs e)
        {
            if (jenis == "roda 2")
            {
                if (cbGantiOli.Checked)
                {
                    txtGantiOli.Text = "100000";

                    int totalbiaya = int.Parse(txtTotalBiaya.Text) + 100000;
                    txtTotalBiaya.Text = totalbiaya.ToString();
                }
                else
                {
                    txtGantiOli.Text = "0";

                    int totalbiaya = int.Parse(txtTotalBiaya.Text) - 100000;
                    txtTotalBiaya.Text = totalbiaya.ToString();
                }
            }
            else if (jenis == "roda 4")
            {
                if (cbGantiOli.Checked)
                {
                    txtGantiOli.Text = "500000";

                    int totalbiaya = int.Parse(txtTotalBiaya.Text) + 500000;
                    txtTotalBiaya.Text = totalbiaya.ToString();
                }
                else
                {
                    txtGantiOli.Text = "0";

                    int totalbiaya = int.Parse(txtTotalBiaya.Text) - 500000;
                    txtTotalBiaya.Text = totalbiaya.ToString();
                }
            }
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Tanggal \t\t\t= " + dateTimePicker1.Value.Date.ToString("dd-MM-yyyy") +
                                Environment.NewLine +
                                "Nama \t\t\t= " + txtNama.Text +
                                Environment.NewLine +
                                "No Plat \t\t\t= " + txtNoPlat.Text +
                                Environment.NewLine +
                                "Jenis Kendaraan \t= " + jenis +
                                Environment.NewLine +
                                "Total Biaya \t\t= " + txtTotalBiaya.Text;
        }
    }
}
