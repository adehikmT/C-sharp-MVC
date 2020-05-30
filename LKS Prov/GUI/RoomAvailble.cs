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
    public partial class RoomAvailble : Form
    {
        Kelas.Query qr = new Kelas.Query();
        public void SetLabel()
        {
            label1.Text = "Semerbak Bunga Hotel:Room Avaibel Report";
            label2.Text = "Bgin Month";
            label3.Text = "Duration";
            label4.Text = "Room Type";
        }

        public void Shb()
        {
            List<String> mont = new List<string>();
            mont.Add("Januari"); mont.Add("February"); mont.Add("Mart"); mont.Add("April"); mont.Add("Mei"); mont.Add("Juni"); mont.Add("Juli"); mont.Add("Agustus"); mont.Add("September"); mont.Add("Oktober"); mont.Add("November"); mont.Add("Desember");
            int a = 0,b=0;
            while (a<=11)
            {
                cb.Items.Add(mont[a]);
                Console.WriteLine(a);
                a++;
            }
            List<String> dgt = new List<string>();
            dgt.Add("3 Month"); dgt.Add("6 Month"); dgt.Add("9 Month"); dgt.Add("12 Month");
            while(b<=3)
            {
                cb2.Items.Add(dgt[b]);
                b++;
            }
        }
        public RoomAvailble()
        {
            InitializeComponent();
            SetLabel();
            Shb();
            ck1.Checked = true;
            qr.ShowRep("select a.TglPemesanan,b.TglPembayaran ,b.TotalPembayaran from Pemesanan a,Pembayaran b,TypeKamar c,Kamar d where b.IDPemesanan=a.IDPemesanan and a.IDKamar=d.IDKamar and d.IDTypeKamar=c.IDTypeKamar", "All", chart1);
            qr.ShowRep("select a.TglPemesanan,b.TglPembayaran ,b.TotalPembayaran from Pemesanan a,Pembayaran b,TypeKamar c,Kamar d where b.IDPemesanan=a.IDPemesanan and a.IDKamar=d.IDKamar and d.IDTypeKamar=c.IDTypeKamar and c.NamaTypeKamar='Standar'", "Standar", chart1);
            qr.ShowRep("select a.TglPemesanan,b.TglPembayaran ,b.TotalPembayaran from Pemesanan a,Pembayaran b,TypeKamar c,Kamar d where b.IDPemesanan=a.IDPemesanan and a.IDKamar=d.IDKamar and d.IDTypeKamar=c.IDTypeKamar and c.NamaTypeKamar='Super'", "Super", chart1);
            qr.ShowRep("select a.TglPemesanan,b.TglPembayaran ,b.TotalPembayaran from Pemesanan a,Pembayaran b,TypeKamar c,Kamar d where b.IDPemesanan=a.IDPemesanan and a.IDKamar=d.IDKamar and d.IDTypeKamar=c.IDTypeKamar and c.NamaTypeKamar='Deluxe Room'", "Deluxe", chart1);
            qr.ShowRep("select a.TglPemesanan,b.TglPembayaran ,b.TotalPembayaran from Pemesanan a,Pembayaran b,TypeKamar c,Kamar d where b.IDPemesanan=a.IDPemesanan and a.IDKamar=d.IDKamar and d.IDTypeKamar=c.IDTypeKamar and c.NamaTypeKamar='Superior Room'", "Deluxe", chart1);
            qr.ShowRep("select a.TglPemesanan,b.TglPembayaran ,b.TotalPembayaran from Pemesanan a,Pembayaran b,TypeKamar c,Kamar d where b.IDPemesanan=a.IDPemesanan and a.IDKamar=d.IDKamar and d.IDTypeKamar=c.IDTypeKamar and c.NamaTypeKamar='Excekutif Room'", "Excekutif", chart1);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
