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
    public partial class ManageHolidayPrice : Form
    {
        Kelas.Query qr = new Kelas.Query();

        public void cls()
        {
            rmtyp.Text = "";
            dt1.Text = "";
            dt2.Text = "";
            pr.Text = "";
            tsrc.Text = "";
            label8.Visible = false;
        }

        public void Show(String q)
        {
            qr.ShowAll(q, "HargaFluktuatif", dgv);
            dgv.AllowUserToAddRows = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.Refresh();
        }

        public String GetQuery(int opsi)
        {
            String q, id, td, td2, rp, sr,rid;
            sr = tsrc.Text;
            td = dt1.Text;
            td2 = dt2.Text;
            rp = pr.Text;
            rid = label8.Text;
            id = qr.GetData("SELECT * FROM TypeKamar Where NamaTypeKamar='" + rmtyp.Text + "'", "IDTypeKamar");
            if (opsi == 1)//insert
            {
                  q = "INSERT INTO HargaFluktuatif Values('" + id + "','" + rp + "','" + td + "','"+td2+"')";
            }
            else if (opsi == 2)//update
            {
                q = "UPDATE HargaFluktuatif set IDTypeKamar='" + id + "',Persentase='" + rp + "',TglMulai='" + td + "',TglSelesai='"+td2+"' where IDHargaFluktuatif='"+rid+"'";
            }
            else if (opsi == 3)//select
            {
                q = "select distinct c.IDHargaFluktuatif,a.NamaTypeKamar,b.HargaKamar,c.Persentase,b.HargaKamar+b.HargaSarapan as 'Final Price',c.TglMulai,c.TglSelesai from TypeKamar a,HargaKamar b,HargaFluktuatif c where c.IDTypeKamar=a.IDTypeKamar and b.IDTypeKamar=c.IDTypeKamar";
            }
            else if (opsi == 4)//serch
            {
                 q = "select distinct c.IDHargaFluktuatif,a.NamaTypeKamar,b.HargaKamar,c.Persentase,b.HargaKamar + b.HargaSarapan as 'Final Price',c.TglMulai,c.TglSelesai from TypeKamar a, HargaKamar b,HargaFluktuatif c, Kamar d where c.IDTypeKamar = a.IDTypeKamar and b.IDTypeKamar = c.IDTypeKamar and d.IDKamar = a.IDTypeKamar and d.NomorKamar like '%"+sr+"%' or d.Lantai like '%"+sr+"%' or a.IDTypeKamar like '%"+sr+"%'";
            }
            else//delete
            {
                  q = "DELETE FROM Kamar Where IDKamar='" + rid + "'";
            }
            Console.WriteLine(q);
            return q;
        }

        public void Box()
        {
            qr.ShowBox("SELECT * FROM TypeKamar", "NamaTypeKamar", rmtyp);
        }

        public Boolean valid()
        {
            if (rmtyp.Text == "" || dt1.Text == "" || dt2.Text == "" || pr.Text == "")
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
            label1.Text = "Semerbak Bunga Hotel:Manage Room Holiday Price From";
            label3.Text = "Add Type Name";
            label4.Text = "Bgin Date";
            label6.Text = "End Date";
            label7.Text = "Percebtage";
            label2.Text = "Add Holiday Price";
            label5.Text = "Search Holiday Price";
            src.Text = "Serch";
            add.Text = "Add";
            del.Text = "Delete";
        }
        public ManageHolidayPrice()
        {
            InitializeComponent();
            SetLabel();
            cls();
            Show(GetQuery(3));
            Box();
        }

        private void rmtyp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            if (valid())
            {
                qr.InUpDel(GetQuery(1),"Data Bsrhasil di simpan");
            }
            Show(GetQuery(3));
            cls();
        }

        private void src_Click(object sender, EventArgs e)
        {
            if (tsrc.Text != "")
            {
                Show(GetQuery(4));
            }
            else
            {
                Show(GetQuery(3));
                cls();
            }
            
        }

        private void del_Click(object sender, EventArgs e)
        {
            if (label8.Text != "label8")
            {
                if (MessageBox.Show("Yakin?", "INFO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    qr.InUpDel(GetQuery(5), "Data Berhasil Di hapus");
                }
            } else
            {
                MessageBox.Show("SELECT Data From Data grid");
            }
            Show(GetQuery(3));
            cls();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            rmtyp.Text = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
            pr.Text = dgv.Rows[e.RowIndex].Cells[3].Value.ToString();
            dt1.Text = dgv.Rows[e.RowIndex].Cells[5].Value.ToString();
            dt2.Text = dgv.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cls();
        }
    }
}
