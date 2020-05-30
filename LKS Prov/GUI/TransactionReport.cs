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
    public partial class TransactionReport : Form
    {
        Kelas.Query qr = new Kelas.Query();
        public void SetLabel()
        {
            label1.Text = "Semerbak Bunga Hotel:Transaction Reaport";
            label2.Text = "Bgin Date";
            label3.Text = "End Date";
            label4.Text = "Room Type";
            lod.Text = "Load";
            rt.Text = "ALL";
        }
        public TransactionReport()
        {
            InitializeComponent();
            SetLabel();
            qr.ShowBox("SELECT * FROM TypeKamar","NamaTypeKamar",rt);
            qr.ShowRep("select a.TglPemesanan,b.TglPembayaran ,b.TotalPembayaran from Pemesanan a,Pembayaran b,TypeKamar c,Kamar d where b.IDPemesanan=a.IDPemesanan and a.IDKamar=d.IDKamar and d.IDTypeKamar=c.IDTypeKamar", "All", chart1);
            qr.ShowRep("select a.TglPemesanan,b.TglPembayaran ,b.TotalPembayaran from Pemesanan a,Pembayaran b,TypeKamar c,Kamar d where b.IDPemesanan=a.IDPemesanan and a.IDKamar=d.IDKamar and d.IDTypeKamar=c.IDTypeKamar and c.NamaTypeKamar='Standar'", "Standar", chart1);
            qr.ShowRep("select a.TglPemesanan,b.TglPembayaran ,b.TotalPembayaran from Pemesanan a,Pembayaran b,TypeKamar c,Kamar d where b.IDPemesanan=a.IDPemesanan and a.IDKamar=d.IDKamar and d.IDTypeKamar=c.IDTypeKamar and c.NamaTypeKamar='Super'", "Super", chart1);
            qr.ShowRep("select a.TglPemesanan,b.TglPembayaran ,b.TotalPembayaran from Pemesanan a,Pembayaran b,TypeKamar c,Kamar d where b.IDPemesanan=a.IDPemesanan and a.IDKamar=d.IDKamar and d.IDTypeKamar=c.IDTypeKamar and c.NamaTypeKamar='Deluxe Room'", "Deluxe", chart1);
            qr.ShowRep("select a.TglPemesanan,b.TglPembayaran ,b.TotalPembayaran from Pemesanan a,Pembayaran b,TypeKamar c,Kamar d where b.IDPemesanan=a.IDPemesanan and a.IDKamar=d.IDKamar and d.IDTypeKamar=c.IDTypeKamar and c.NamaTypeKamar='Superior Room'", "Deluxe", chart1);
            qr.ShowRep("select a.TglPemesanan,b.TglPembayaran ,b.TotalPembayaran from Pemesanan a,Pembayaran b,TypeKamar c,Kamar d where b.IDPemesanan=a.IDPemesanan and a.IDKamar=d.IDKamar and d.IDTypeKamar=c.IDTypeKamar and c.NamaTypeKamar='Excekutif Room'", "Excekutif", chart1);
        }

        private void lod_Click(object sender, EventArgs e)
        {
            if (rt.Text=="ALL")
            {
                qr.ShowRep("select a.TglPemesanan,b.TglPembayaran ,b.TotalPembayaran from Pemesanan a,Pembayaran b,TypeKamar c,Kamar d where b.IDPemesanan=a.IDPemesanan and a.IDKamar=d.IDKamar and d.IDTypeKamar=c.IDTypeKamar", "All", chart1);
            }
            if (rt.Text!="ALL")
            {
                String q = "select a.TglPemesanan,b.TglPembayaran ,b.TotalPembayaran from Pemesanan a,Pembayaran b,TypeKamar c,Kamar d where b.IDPemesanan=a.IDPemesanan and a.IDKamar=d.IDKamar and d.IDTypeKamar=c.IDTypeKamar and c.NamaTypeKamar='" + rt.Text + "'";
                Console.WriteLine(q);
             qr.ShowRep(q,"Standar", chart1);
            }
        }

        private void rt_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
