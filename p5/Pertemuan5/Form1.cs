using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pertemuan5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            //hitung 10% softskill (nilai * 10 /100)
            double nilaiSoftSkill = Double.Parse(textSoftSkill.Text) * 0.1;
            //hitung 20% tugas
            double nilaiTugas = Double.Parse(textTugas.Text) * 0.2;
            //hitung 10% kuis
            double nilaiKuis = Double.Parse(textKuis.Text) * 0.1;
            //30% uts
            double nilaiUTS = Double.Parse(textUTS.Text) * 0.3;
            //30% uas
            double nilaiUAS = Double.Parse(textUAS.Text) * 0.3;

            //hitung nilai akhir
            double nilaiAkhir = nilaiSoftSkill + nilaiTugas + nilaiKuis + nilaiUTS + nilaiUAS;
            textTotalNilai.Text = nilaiAkhir.ToString();

            //menampilkan nilai huruf
            if (nilaiAkhir > 90) //(90 sd 100) = A
            {
                textNilaiHuruf.Text = "A";
            }
            else if (nilaiAkhir > 70 && nilaiAkhir < 90) //(70 sd 90)  = B
            {
                textNilaiHuruf.Text = "B";
            }
            else if (nilaiAkhir > 50 && nilaiAkhir < 70) //(50 sd 70)  = C
            {
                textNilaiHuruf.Text = "C";
            }
            else //(0 sd 50) = D
            {
                textNilaiHuruf.Text = "D";
            }
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            //menutup aplikasi
            this.Close();
        }
    }
}
