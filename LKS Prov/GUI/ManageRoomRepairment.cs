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
    public partial class ManageRoomRepairment : Form
    {
        Kelas.Query qr = new Kelas.Query();

        public void cls()
        {
            rm.Text = "";
            dt.Text = "";
            dt2.Text = "";
            not.Text = "";
        }
        public void Show(String q)
        {
            qr.ShowAll(q, "PerbaikanKamar", dgv);
            dgv.AllowUserToAddRows = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.Refresh();
        }

        public String GetQuery(int opsi)
        {
            String td,idd, q, idrm, dt1, sr;
            idrm = qr.GetData("SELECT * FROM Kamar Where NomorKamar='" + rm.Text + "'", "IDKamar");
            td = dt.Text;
            dt1 = dt2.Text;
           idd= label8.Text;
            sr = tsrc.Text;
            if (opsi == 1)//insert
            {
                q = "INSERT INTO PerbaikanKamar Values('" + idrm + "','" + td + "','" + dt1 + "','"+not.Text+"','"+label9.Text+"')";
                Console.WriteLine(q);
            }
            else if (opsi == 3)//select
            {
                q = "select c.IDPerbaikanKamar as 'ID', a.NamaTypeKamar as 'Type',b.NomorKamar as 'No Kamar',b.Lantai,c.TglMulai,c.TglSelesai,d.NamaKariawan,c.Catatan from TypeKamar a,Kamar b,PerbaikanKamar c,Kariawan d where a.IDTypeKamar=b.IDTypeKamar and c.IDKamar=b.IDKamar and c.IDKariawan=d.IDKariawan";
            }
            else if (opsi == 4)//serch
            {
                q = "select c.IDPerbaikanKamar as 'ID', a.NamaTypeKamar as 'Type',b.NomorKamar as 'No Kamar',b.Lantai,c.TglMulai,c.TglSelesai,d.NamaKariawan,c.Catatan from TypeKamar a, Kamar b,PerbaikanKamar c, Kariawan d where a.IDTypeKamar = b.IDTypeKamar and c.IDKamar = b.IDKamar and c.IDKariawan = d.IDKariawan and a.NamaTypeKamar like '%" + sr+"%' OR b.Lantai like '%"+sr+"%' OR b.NomorKamar like '%"+sr+"%' OR b.IDKamar like '%"+sr+"%'";
            }
            else//delete
            {
                q = "DELETE FROM PerbaikanKamar Where IDPerbaikanKamar='" + idd + "'";
            }
            Console.WriteLine(q);
            return q;
        }

        public void Box()
        {
            qr.ShowBox("SELECT * FROM Kamar", "NomorKamar", rm);
        }

        public Boolean valid()
        {
            if (rm.Text == "" || dt.Text == "")
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
            label1.Text = "Semerbak Bunga Hotel:Manage Room Repairment From";
            label2.Text = "Add Room to be Repair in Schedule";
            label3.Text = "Room Number";
            label4.Text = "Bgin Date";
            label5.Text = "Search Required Room";
            label6.Text = "End Date";
            label7.Text = "Note";
            src.Text = "Serch";
            add.Text = "Add";
            label8.Visible = false;
            label9.Visible = false;
            del.Text = "Delete";
        }
        public ManageRoomRepairment()
        {
            InitializeComponent();
            SetLabel();
            cls();
            Show(GetQuery(3));
            Box();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            label8.Text = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void src_Click(object sender, EventArgs e)
        {
            if (tsrc.Text != "label8")
            {
                qr.ShowAll(GetQuery(4), "PerbaikanKamar", dgv);
            }
        }

        private void del_Click(object sender, EventArgs e)
        {
            if (label8.Text != "")
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
