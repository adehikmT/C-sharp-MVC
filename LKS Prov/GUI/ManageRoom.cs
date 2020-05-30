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
    public partial class ManageRoom : Form
    {
        Kelas.Query qr = new Kelas.Query();
        public void SetLabel()
        {
            label1.Text = "Semerbak Bunga Hotel:Manage Room From";
            label2.Text = "Serch";
            label3.Text = "Room ID";
            label4.Text = "Room Type Number";
            label5.Text = "Room Number";
            label6.Text = "floor";
            rmid.Enabled = false;
            src.Text = "Serch";
            add.Text = "Add";
            upd.Text = "Update";
            del.Text = "Delete";
        }

        public void cls()
        {
            rmtyp.Text = "";
            rmn.Text = "";
            fl.Text = "";
            tsrc.Text = "";
        }

        public void Show(String q)
        {
            qr.ShowAll(q, "Kamar", dgv);
            dgv.AllowUserToAddRows = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.Refresh();
        }

        public String GetQuery(int opsi)
        {
            String q, id, mn, rid, lf, sr;
            rid = rmid.Text;
            mn = rmn.Text;
            lf = fl.Text;
            sr = tsrc.Text;
            id = qr.GetData("SELECT * FROM TypeKamar Where NamaTypeKamar='" + rmtyp.Text + "'", "IDTypeKamar");
            if (opsi == 1)//insert
            {
                q = "INSERT INTO Kamar Values('" + mn + "','" + lf + "','" + id +"')";
            }
            else if (opsi == 2)//update
            {
                q = "UPDATE Kamar SET NomorKamar='" + mn + "',Lantai='" + lf + "',IDTypeKamar='" + id + "'";
            }
            else if (opsi == 3)//select
            {
                q = "SELECT Kamar.IDKamar as 'Id',Kamar.NomorKamar as 'Nomor',Kamar.Lantai as 'Lantai',TypeKamar.NamaTypeKamar as 'Tipe' from Kamar,TypeKamar where Kamar.IDTypeKamar=TypeKamar.IDTypeKamar";
            }
            else if (opsi == 4)//serch
            {
                q = "SELECT Kamar.IDKamar as 'Id',Kamar.NomorKamar as 'Nomor',Kamar.Lantai as 'Lantai',TypeKamar.NamaTypeKamar as 'Tipe' from Kamar,TypeKamar where Kamar.IDTypeKamar=TypeKamar.IDTypeKamar and Kamar.NomorKamar like '%" + sr + "%' OR TypeKamar.NamaTypeKamar like '%" + sr + "%' OR Kamar.IDKamar like '%" + sr + "%'";
            }
            else//delete
            {
                q = "DELETE FROM Kamar Where IDKamar='" + rid + "'";
            }

            return q;
        }

        public void Box()
        {
            qr.ShowBox("SELECT * FROM TypeKamar", "NamaTypeKamar", rmtyp);
        }

        public Boolean valid()
        {
            if (rmn.Text == "" || rmid.Text == "" || rmtyp.Text == "" || fl.Text == "")
            {
                MessageBox.Show("Fild not null!");
                return false;
            }
            else
            {
                return true;
            }
        }

        public void Showid()
        {
            String id=qr.GetData("SELECT * FROM Kamar Order by IDKamar desc","IDKamar");
            int coun = int.Parse(id)+1;
            rmid.Text = coun.ToString();
        }


        public ManageRoom()
        {
            InitializeComponent();
            SetLabel();
            cls();
            Show(GetQuery(3));
            Box();
            Showid();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            rmid.Text = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
            rmn.Text = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
            fl.Text = dgv.Rows[e.RowIndex].Cells[2].Value.ToString();
            rmtyp.Text = dgv.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void src_Click(object sender, EventArgs e)
        {
            if (tsrc.Text != "")
            {
                qr.ShowAll(GetQuery(4), "Penghuni", dgv);
            }
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

        private void upd_Click(object sender, EventArgs e)
        {
            if (valid())
            {
                qr.InUpDel(GetQuery(2), "Data Updated Success!");
                cls();
            }
            Show(GetQuery(3));
        }

        private void del_Click(object sender, EventArgs e)
        {
            if (rmid.Text != "")
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

        private void button1_Click(object sender, EventArgs e)
        {
            cls();
        }
    }
}
