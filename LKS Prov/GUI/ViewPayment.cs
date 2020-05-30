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
    public partial class ViewPayment : Form
    {
        Kelas.Query qr = new Kelas.Query();
        public void SetLabel()
        {
            label1.Text = "Semerbak Bunga Hotel:View Payment From";
            label2.Text = "Search";
        }
        public ViewPayment()
        {
            InitializeComponent();
            SetLabel();
            qr.ShowAll("select distinct a.IDPembayaran,a.TglPembayaran,b.IDPemesanan,c.NamaPenghuni,d.NomorKamar,e.NamaKariawan,a.TotalPembayaran,b.HargaPerMalam*b.LamaTinggal+f.HargaKamar+f.HargaSarapan*b.LamaTinggal+g.JumlahFasilitasTambahan as 'sisa pembayaran',b.Status from Pembayaran a,Pemesanan b,Penghuni c,Kamar d,Kariawan e,HargaKamar f,PemesananDetil g,TypeKamar h where a.IDKariawan=e.IDKariawan and a.IDPemesanan=b.IDPemesanan and b.IDFasilitasTambahan=g.IDFasilitasTambahan and b.IDKamar=d.IDKamar and b.IDPenghuni=c.IDPenghuni and  f.IDTypeKamar=h.IDTypeKamar", "Pembayran",dgv);
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ViewPayment_Load(object sender, EventArgs e)
        {

        }

        private void src_Click(object sender, EventArgs e)
        {
            if (tsrc.Text != "")
            {
                String q = "select distinct a.IDPembayaran,a.TglPembayaran,b.IDPemesanan,c.NamaPenghuni,d.NomorKamar,e.NamaKariawan,a.TotalPembayaran,b.HargaPerMalam*b.LamaTinggal+f.HargaKamar+f.HargaSarapan*b.LamaTinggal+g.JumlahFasilitasTambahan as 'sisa pembayaran',b.Status from Pembayaran a,Pemesanan b,Penghuni c,Kamar d,Kariawan e,HargaKamar f,PemesananDetil g,TypeKamar h where a.IDKariawan=e.IDKariawan and a.IDPemesanan=b.IDPemesanan and b.IDFasilitasTambahan=g.IDFasilitasTambahan and b.IDKamar=d.IDKamar and b.IDPenghuni=c.IDPenghuni and  f.IDTypeKamar=h.IDTypeKamar and a.TglPembayaran like '%" + tsrc.Text + "%' or a.IDPembayaran like '%" + tsrc.Text + "%' or b.IDPemesanan like '%" + tsrc.Text + "%' or c.NamaPenghuni like '%" + tsrc.Text + "%' or d.NomorKamar like '%" + tsrc.Text + "%' or e.NamaKariawan like '% " + tsrc.Text + "%'";
                qr.ShowAll(q, "Pembayran", dgv);
                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                qr.ShowAll("select distinct a.IDPembayaran,a.TglPembayaran,b.IDPemesanan,c.NamaPenghuni,d.NomorKamar,e.NamaKariawan,a.TotalPembayaran,b.HargaPerMalam*b.LamaTinggal+f.HargaKamar+f.HargaSarapan*b.LamaTinggal+g.JumlahFasilitasTambahan as 'sisa pembayaran',b.Status from Pembayaran a,Pemesanan b,Penghuni c,Kamar d,Kariawan e,HargaKamar f,PemesananDetil g,TypeKamar h where a.IDKariawan=e.IDKariawan and a.IDPemesanan=b.IDPemesanan and b.IDFasilitasTambahan=g.IDFasilitasTambahan and b.IDKamar=d.IDKamar and b.IDPenghuni=c.IDPenghuni and  f.IDTypeKamar=h.IDTypeKamar", "Pembayran", dgv);
                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }
    }
}
