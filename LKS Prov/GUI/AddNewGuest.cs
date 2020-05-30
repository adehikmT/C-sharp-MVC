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
    public partial class AddNewGuest : Form
    {
        Kelas.Query qr = new Kelas.Query();
        public void cls()
        {
            nm.Text = "";
            em.Text = "";
            ic.Text = "";
            pn.Text = "";
            ln.Text = "";
            vt.Text = "";
        }
        public void SetLabel()
        {
            label1.Text = "Semerbak Bunga Hotel:Add New User From";
            label2.Text = "Guest Name";
            label3.Text = "Email";
            label4.Text = "ID Card";
            label5.Text = "Phone Number";
            label6.Text = "Vhicle Licence Number";
            label7.Text = "Vhicle type";
            add.Text = "Add";
        }

        public String GetQuery(int opsi)
        {
            String q, id, mn, me, ci, np, nl, tv, idp, sr;
            mn = nm.Text;
            me = em.Text;
            ci = ic.Text;
            np = pn.Text;
            nl = ln.Text;
            tv = vt.Text;
            id = qr.GetData("SELECT * FROM TypeKendaraan Where NamaTypeKendaraan='" + tv + "'", "IDTypeKendaraan");
            q = "INSERT INTO Penghuni Values('" + mn + "','" + ci + "','" + me + "','" + np + "','" + nl + "','" + id + "')";
            return q;
        }

        public void Box()
        {
            qr.ShowBox("SELECT * FROM TypeKendaraan", "NamaTypeKendaraan", vt);
        }

        public Boolean valid()
        {
            if (nm.Text == "" || ic.Text == "" || em.Text == "" || pn.Text == "" || ln.Text == "" || vt.Text == "")
            {
                MessageBox.Show("Fild not null!");
                if (pn.Text.Length <= 12)
                {
                    MessageBox.Show("Phone Number mush be 12 digit!");
                }
                else if (ic.Text.Length <= 20)
                {
                    MessageBox.Show("NIK Number mush be 30 digit!");
                }
                return false;
            }
            else
            {
                return true;
            }
        }
        public AddNewGuest()
        {
            InitializeComponent();
            SetLabel();
            Box();
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (valid())
            {
                qr.InUpDel(GetQuery(1), "Data Saved Success!");
                cls();
            }
        }
    }
}
