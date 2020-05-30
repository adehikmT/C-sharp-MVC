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
    public partial class ManageGuest : Form
    {
        Kelas.Query qr = new Kelas.Query();

        public void SetLabel()
        {
            label1.Text = "Semerbak Bunga Hotel:Manage Employee Form";
            label2.Text = "Serch";
            label3.Text = "Guest Name";
            label4.Text = "Email";
            label5.Text = "ID Card Number";
            label6.Text = "Phone Number";
            label7.Text = "Vehicle license Number";
            label8.Text = "Vhincle Type";
            idd.Visible = false;
            idd.Text = "";
            src.Text = "Serch";
            add.Text = "Add";
            upd.Text = "Update";
            del.Text = "Delete";
        }

        public void cls()
        {
            nm.Text = "";
            em.Text = "";
            ic.Text = "";
            pn.Text = "";
            ln.Text = "";
            vt.Text = "";
        }

        public void Show(String q)
        {
            qr.ShowAll(q,"Penghuni",dgv);
            dgv.AllowUserToAddRows = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.Refresh();
        }

        public String GetQuery(int opsi)
        {
            String q,id,mn, me,ci, np, nl,tv,idp,sr;
            mn=nm.Text;
            me=em.Text;
            ci=ic.Text;
            np=pn.Text;
            nl=ln.Text;
            sr = tsrc.Text;
            tv=vt.Text;
            idp = idd.Text;
            id = qr.GetData("SELECT * FROM TypeKendaraan Where NamaTypeKendaraan='"+tv+"'","IDTypeKendaraan");
            if (opsi == 1)//insert
            {
                q = "INSERT INTO Penghuni Values('" + mn + "','" + ci + "','" + me + "','" + np + "','" + nl + "','" + id + "')";
            }
            else if (opsi == 2)//update
            {
                q = "UPDATE Penghuni SET NamaPenghuni='" + mn + "',NomorKTP='" + ci + "',Email='" + me + "',NomorHP='" + np + "',PlatNoKendaraan='" + nl + "',IDTypeKendaraan='" + id + "' where IDPenghuni='" + idp + "'";
            }
            else if (opsi ==3)//select
            {
               q = "SELECT Penghuni.IDPenghuni as 'Id',Penghuni.NamaPenghuni as 'Nama',Penghuni.NomorKTP as 'KTP',Penghuni.Email,Penghuni.NomorHP as 'Nomor HP',Penghuni.PlatNoKendaraan as 'Nomor Kendaraan',TypeKendaraan.NamaTypeKendaraan as 'Kendaraan' from Penghuni,TypeKendaraan where Penghuni.IDTypeKendaraan=TypeKendaraan.IDTypeKendaraan";
            }
            else if (opsi == 4)//serch
            {
                q = "SELECT Penghuni.IDPenghuni as 'Id',Penghuni.NamaPenghuni as 'Nama',Penghuni.NomorKTP as 'KTP',Penghuni.Email,Penghuni.NomorHP as 'Nomor HP',Penghuni.PlatNoKendaraan as 'Nomor Kendaraan',TypeKendaraan.NamaTypeKendaraan as 'Kendaraan' from Penghuni,TypeKendaraan where Penghuni.IDTypeKendaraan=TypeKendaraan.IDTypeKendaraan and Penghuni.NamaPenghuni like '%" + sr + "%' OR Penghuni.Email like '%" + sr + "%' OR Penghuni.NomorHP like '%" + sr + "%'";
            }
            else//delete
            {
                q = "DELETE FROM Penghuni Where IDPenghuni='" + idp + "'";
            }

            return q;
        }

        public void Box()
        {
            qr.ShowBox("SELECT * FROM TypeKendaraan","NamaTypeKendaraan",vt);
        }

        public Boolean valid()
        {
            if (nm.Text == "" || ic.Text == "" || em.Text==""||pn.Text==""||ln.Text==""||vt.Text=="")
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
        public ManageGuest()
        {
            InitializeComponent();
            SetLabel();
            cls();
            Show(GetQuery(3));
            Box();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            nm.Text= dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
            em.Text= dgv.Rows[e.RowIndex].Cells[3].Value.ToString();
            ic.Text= dgv.Rows[e.RowIndex].Cells[2].Value.ToString();
            pn.Text= dgv.Rows[e.RowIndex].Cells[4].Value.ToString();
            ln.Text= dgv.Rows[e.RowIndex].Cells[5].Value.ToString();
            vt.Text= dgv.Rows[e.RowIndex].Cells[6].Value.ToString();
            idd.Text=dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void src_Click(object sender, EventArgs e)
        {
            if (tsrc.Text!="")
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
            if (idd.Text != "")
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
    }
}
