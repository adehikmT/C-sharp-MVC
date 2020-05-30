using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LKS_Prov.GUI
{
    public partial class InputPayment : Form
    {
        Kelas.Query qr = new Kelas.Query();

        public void Box()
        {
            qr.ShowBox("SELECT * FROM Pemesanan", "IDPemesanan", bk);
        }

        public void SetLabel()
        {
            label1.Text = "Semerbak Bunga Hotel:Input Payment From";
            label2.Text = "Booking ID";
            label3.Text = "Remaining Payment";
            label4.Text = "Payment";
            label5.Text = "Balance";
            label6.Text = "Payment Date";
            rp.Enabled = false;
            bl.Enabled = false;
        }
        public InputPayment()
        {
            InitializeComponent();
            SetLabel();
            Box();
        }

        private void InputPayment_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bk_SelectedIndexChanged(object sender, EventArgs e)
        {
            bl.Text = qr.GetData("select Pemesanan.HargaPerMalam*Pemesanan.LamaTinggal+HargaKamar.HargaKamar+HargaKamar.HargaSarapan*Pemesanan.LamaTinggal+PemesananDetil.JumlahFasilitasTambahan as 'Harga Bayar' from Pemesanan,Kamar,TypeKamar,HargaKamar,PemesananDetil where Pemesanan.IDKamar=Kamar.IDKamar and Kamar.IDTypeKamar=TypeKamar.IDTypeKamar and HargaKamar.IDTypeKamar=Kamar.IDKamar and PemesananDetil.IDPemesanan=Pemesanan.IDPemesanan and Pemesanan.IDPemesanan='" + bk.Text+"'","Harga Bayar");
        }
    }
}
