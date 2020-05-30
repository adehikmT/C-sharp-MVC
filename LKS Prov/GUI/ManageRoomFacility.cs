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
    public partial class ManageRoomFacility : Form
    {
        Kelas.Query qr = new Kelas.Query();

        public void cls()
        {
            rm.Text = "";
            fn.Text = "";
            tsrc.Text = "";
            jml.Text = "";
        }
        public void Show(String q)
        {
            qr.ShowAll(q, "Fasilitas", dgv);
            dgv.AllowUserToAddRows = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.Refresh();
        }

        public String GetQuery(int opsi)
        {
            String id, q, idrm, jm,sr;
            idrm= qr.GetData("SELECT * FROM TypeKamar Where NamaTypeKamar='" + rm.Text + "'", "IDTypeKamar");
            id = qr.GetData("SELECT * FROM Fasilitas Where NamaFasilitas='" +fn.Text + "'", "IDFasilitas");
            jm = jml.Text;
            sr = tsrc.Text;
            if (opsi == 1)//insert
            {
                q = "INSERT INTO FasilitasBerdasarkanTypeKamar Values('" + idrm + "','" + id + "','" + jm + "')";
            }
            else if (opsi == 3)//select
            {
                q = "select TypeKamar.IDTypeKamar,Fasilitas.IDFasilitas,TypeKamar.NamaTypeKamar,Fasilitas.NamaFasilitas,FasilitasBerdasarkanTypeKamar.JumlahFasilitas FROM FasilitasBerdasarkanTypeKamar,Fasilitas,TypeKamar where FasilitasBerdasarkanTypeKamar.IDFasilitas=Fasilitas.IDFasilitas and FasilitasBerdasarkanTypeKamar.IDTypeKamar=TypeKamar.IDTypeKamar";
            }
            else if (opsi == 4)//serch
            {
                q = "select TypeKamar.IDTypeKamar,Fasilitas.IDFasilitas,TypeKamar.NamaTypeKamar,Fasilitas.NamaFasilitas,FasilitasBerdasarkanTypeKamar.JumlahFasilitas FROM FasilitasBerdasarkanTypeKamar,Fasilitas,TypeKamar,Kamar where FasilitasBerdasarkanTypeKamar.IDFasilitas=Fasilitas.IDFasilitas and FasilitasBerdasarkanTypeKamar.IDTypeKamar=TypeKamar.IDTypeKamar and Kamar.IDTypeKamar=TypeKamar.IDTypeKamar and TypeKamar.NamaTypeKamar like '%" + sr + "%' OR TypeKamar.IDTypeKamar like '%" + sr + "%' OR kamar.NomorKamar like '%" + sr + "%'";
            }
            else//delete
            {
                q = "DELETE FROM FasilitasBerdasarkanTypeKamar Where IDFasilitas='" + id + "'";
            }

            return q;
        }

        public void Box()
        {
            qr.ShowBox("SELECT * FROM TypeKamar", "NamaTypeKamar", rm);
            qr.ShowBox("SELECT * FROM Fasilitas", "NamaFasilitas", fn);
        }

        public Boolean valid()
        {
            if (rm.Text == "" || fn.Text == "")
            {
                MessageBox.Show("Fild not null!");
                return false;
            }
            else
            {
                return true;
            }
        }

        public void SetLabel()
        {
            label1.Text = "Semerbak Bunga Hotel:Manage Room Type From";
            label2.Text = "Add Facility Into Room";
            label3.Text = "Room Number";
            label4.Text = "Facility Name";
            label5.Text = "search room facility";
            src.Text = "Serch";
            add.Text = "Add";
            del.Text = "Delete";
            label7.Visible = false;
        }
        public ManageRoomFacility()
        {
            InitializeComponent();
            SetLabel();
            cls();
            Show(GetQuery(3));
            Box();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            label7.Text = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void src_Click(object sender, EventArgs e)
        {
            if (tsrc.Text != "")
            {
                qr.ShowAll(GetQuery(4), "Penghuni", dgv);
            }
        }

        private void del_Click(object sender, EventArgs e)
        {
            if (label7.Text != "label7")
            {
                cls();
                if (MessageBox.Show("Really Delete Data?", "INFO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    qr.InUpDel(GetQuery(10), "Data Deleted Success!");
                }
            }
            else
            {
                MessageBox.Show("Select Data From Data Grid!");
            }
            Show(GetQuery(3));
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (valid())
            {
                qr.InUpDel(GetQuery(1), "Data Saved Success!");
                cls();
            }
            Show(GetQuery(3));
        }
    }
}
