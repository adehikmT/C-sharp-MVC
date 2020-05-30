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
    public partial class ManageBooking : Form
    {
        Kelas.Query qr = new Kelas.Query();
        public void cls()
        {
            tsrc.Text = "";
        }

        public void Show(String q)
        {
            qr.ShowAll(q, "HargaKamar", dgv);
            dgv.AllowUserToAddRows = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.Refresh();
        }

        public String GetQuery(int opsi)
        {
            String q, id, mn, rid, lf, sr;
           // sr = tsrc.Text;
            //id = qr.GetData("SELECT * FROM TypeKamar Where NamaTypeKamar='" + rmtyp.Text + "'", "IDTypeKamar");
            if (opsi == 1)//insert
            {
                //  q = "INSERT INTO Kamar Values('" + mn + "','" + lf + "','" + id + "')";
            }
            else if (opsi == 2)//update
            {
                //q = "UPDATE Kamar SET NomorKamar='" + mn + "',Lantai='" + lf + "',IDTypeKamar='" + id + "'";
            }
            else if (opsi == 3)//select
            {
                q = "";
            }
            else if (opsi == 4)//serch
            {
                // q = "SELECT Kamar.IDKamar as 'Id',Kamar.NomorKamar as 'Nomor',Kamar.Lantai as 'Lantai',TypeKamar.NamaTypeKamar as 'Tipe' from Kamar,TypeKamar where Kamar.IDTypeKamar=TypeKamar.IDTypeKamar and Kamar.NomorKamar like '%" + sr + "%' OR TypeKamar.NamaTypeKamar like '%" + sr + "%' OR Kamar.IDKamar like '%" + sr + "%'";
            }
            else//delete
            {
                //  q = "DELETE FROM Kamar Where IDKamar='" + rid + "'";
            }

            return q = "select Pemesanan.IDPemesanan,Pemesanan.TglPemesanan,Penghuni.NamaPenghuni,Penghuni.NomorHP,Kamar.NomorKamar,Pemesanan.Status from Pemesanan,Penghuni,Kamar where Pemesanan.IDPenghuni=Penghuni.IDPenghuni and Pemesanan.IDKamar=kamar.IDKamar";
        }
        public void SetLabel()
        {
            label1.Text = "Semerbak Bunga Hotel:Manage Booking";
            label2.Text = "search";
        }
        public ManageBooking()
        {
            InitializeComponent();
            SetLabel();
            cls();
            Show(GetQuery(3));
        }
    }
}
