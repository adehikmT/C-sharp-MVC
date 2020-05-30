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
    public partial class ManageRoomType : Form
    {
        Kelas.Query qr = new Kelas.Query();

        public void SetLabel()
        {
            label1.Text = "Semerbak Bunga Hotel:Manage Room Type From";
            label2.Text = "Serch";
            label3.Text = "Room ID";
            label4.Text = "Room Type Name";
            label5.Text = "Description";
            rmid.Enabled = false;
            src.Text = "Serch";
            add.Text = "Add";
            upd.Text = "Update";
            del.Text = "Delete";
        }

        public void cls()
        {
            nm.Text = "";
            ds.Text = "";
        }

        public void Show(String q)
        {
            qr.ShowAll(q, "TypeKamar", dgv);
            dgv.AllowUserToAddRows = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.Refresh();
        }

        public String GetQuery(int opsi)
        {
            String sr, id, mn, sd, q;
            id = rmid.Text;
            sr = tsrc.Text;
            mn = nm.Text;
            sd = ds.Text;         

            if (opsi == 1)//insert
            {
                q = "INSERT INTO TypeKamar Values('" + mn + "','" + sd + "')";
            }
            else if (opsi == 2)//update
            {
                q = "UPDATE TypeKamar SET NamaTypeKamar='" + mn + "',Deskripsi='" + sd + "' where IDTypeKamar='" + id + "'";
            }
            else if (opsi == 3)//select
            {
                q = "SELECT IDTypeKamar as 'ID',NamaTypeKamar as 'Tipe Kamar', Deskripsi from TypeKamar";
            }
            else if (opsi == 4)//serch
            {
                q = "SELECT IDTypeKamar as 'ID',NamaTypeKamar as 'Tipe Kamar', Deskripsi from TypeKamar where  NamaTypeKamar like '%" + sr + "%'";
            }
            else//delete
            {
                q = "DELETE FROM TypeKamar Where IDTypeKamar='" + id + "'";
            }
            Showid();
            return q;
        }

        public Boolean valid()
        {
            if (rmid.Text == "" || nm.Text == "" || ds.Text == "")
            {
                MessageBox.Show("Fild not null!");
                return false;
            }
            return true;
        }

        public void Showid()
        {
            String id;
            id = qr.GetData("SELECT * FROM TypeKamar Order by IDTypeKamar desc", "IDTypeKamar");
            int inid = int.Parse(id) + 1;
            rmid.Text = inid.ToString();
        }
        public ManageRoomType()
        {
            InitializeComponent();
            SetLabel();
            cls();
            Show(GetQuery(3));
            Showid();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            rmid.Text = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
            nm.Text = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
            ds.Text = dgv.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void src_Click(object sender, EventArgs e)
        {
            if (tsrc.Text != "")
            {
                qr.ShowAll(GetQuery(4), "Kariawan", dgv);
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            cls();
        }
    }
}
