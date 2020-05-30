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
    public partial class ManageDailyPrice : Form
    {
        Kelas.Query qr = new Kelas.Query();

        public void cls()
        {
            rmtyp.Text = "";
            dytyp.Text = "";
            bp.Text = "";
            rp.Text = "";
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
            String q, id, id2, pb, pr, sr;
            sr = tsrc.Text;
            pb = bp.Text;
            pr = rp.Text;
            id = qr.GetData("SELECT * FROM TypeKamar Where NamaTypeKamar='" + rmtyp.Text + "'", "IDTypeKamar");
            id2 = qr.GetData("SELECT * FROM TypeHari Where NamaTypeHari='"+dytyp.Text+"'","IDTypeHari");
            if (opsi == 1)//insert
            {
                q = "INSERT INTO HargaKamar Values('" + id + "','" + id2 + "','" + pr + "','"+pb+"')";
            }
            else if (opsi == 2)//update
            {
                q = "UPDATE HargaKamar SET IDTypeKamar='" + id + "',IDTypeHari='" + id2 + "',HargaKamar='" + pr + "',HargaSarapan='"+pb+"'";
            }
            else if (opsi == 3)//select
            {
                q = "SELECT a.IDHargaKamar,b.NamaTypeKamar,d.NamaTypeHari,a.HargaKamar,a.HargaSarapan from HargaKamar a,TypeKamar b,TypeHari d where a.IDTypeKamar=b.IDTypeKamar and a.IDTypeHari=d.IDTypeHari";
            }
            else if (opsi == 4)//serch
            {
                q = "SELECT distinct a.IDHargaKamar,b.NamaTypeKamar,d.NamaTypeHari,a.HargaKamar,a.HargaSarapan from HargaKamar a,TypeKamar b,Kamar c,TypeHari d where a.IDTypeKamar=b.IDTypeKamar and c.IDTypeKamar=b.IDTypeKamar and a.IDTypeHari=d.IDTypeHari and b.NamaTypeKamar like '%"+sr+"%' or c.Lantai like '%+"+sr+"%' OR c.NomorKamar like '%"+sr+"%' OR b.IDTypeKamar like '%"+sr+"%'";
            }
            else//delete
            {
                q = "DELETE FROM HargaKamar Where IDTypeKamar='" + id + "'";
            }
            Console.WriteLine(q);
            return q;
        }

        public void Box()
        {
            qr.ShowBox("SELECT * FROM TypeKamar", "NamaTypeKamar", rmtyp);
            qr.ShowBox("SELECT * FROM TypeHari", "NamaTypeHari", dytyp);
        }

        public Boolean valid()
        {
            if (rmtyp.Text == "" || dytyp.Text == "" || rp.Text == "" || bp.Text == "")
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
            label1.Text = "Semerbak Bunga Hotel:Manage Room Daily Price From";
            label2.Text = "Add Daily Price";
            label3.Text = "Room Type Name";
            label4.Text = "Day Type Name";
            label6.Text = "Room Price";
            label7.Text = "Breakfast Price";
            label5.Text = "Search Daily Price";
            label8.Text = "Rp.";
            label9.Text = "Rp."; 
            src.Text = "Serch";
            add.Text = "Add";
            del.Text = "Delete";
        }
        public ManageDailyPrice()
        {
            InitializeComponent();
            SetLabel();
            cls();
            Show(GetQuery(3));
            Box();
        }

        private void src_Click(object sender, EventArgs e)
        {
            Show(GetQuery(4));
            if (tsrc.Text=="")
            {
                Show(GetQuery(3));
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (valid())
            {
                qr.InUpDel(GetQuery(1),"Data Berhasil Disimpan");
            }
            cls();
            Show(GetQuery(3));
        }

        private void del_Click(object sender, EventArgs e)
        {
            if (rmtyp.Text != "")
            {
                qr.InUpDel(GetQuery(5), "Data Berhasil Di Hapus!");
            }
            else
            {
                MessageBox.Show("Select Data From Data Grid");
            }
            Show(GetQuery(3));
            cls();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            rmtyp.Text = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
            dytyp.Text = dgv.Rows[e.RowIndex].Cells[2].Value.ToString();
            rp.Text = dgv.Rows[e.RowIndex].Cells[3].Value.ToString();
            bp.Text = dgv.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cls();
        }
    }
}
