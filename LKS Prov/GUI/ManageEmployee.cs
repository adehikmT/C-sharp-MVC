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
   public partial class ManageEmployee : Form
    {
        Kelas.Query qr = new Kelas.Query();

        public void SetLabel()
        {
            label1.Text = "Semerbak Bunga Hotel:Manage Employee Form";
            label2.Text = "Serch";
            label3.Text = "Emplyee ID";
            label4.Text = "Employee Name";
            label5.Text = "Email";
            label6.Text = "Password";
            label7.Text = "Date Of Birdth";
            label8.Text = "Gender";
            empid.Enabled = false;
            src.Text = "Serch";
            add.Text = "Add";
            upd.Text = "Update";
            del.Text = "Delete";
            psw.PasswordChar = '*';
            l.Text = "L";
            p.Text = "P";
            p.Checked = false;
            l.Checked = false;
        }

        public void cls()
        {
            nm.Text = "";
            em.Text = "";
            psw.Text = "";
            dt.Text = "";
            p.Checked = false;
            l.Checked = false;
        }

        public void Show(String q)
        {
            qr.ShowAll(q, "Kariawan", dgv);
            dgv.AllowUserToAddRows = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.Refresh();
        }

        public String GetQuery(int opsi)
        {
            String sr, id, mn, me, p, dto, gn,q;
            id = empid.Text;
            sr = tsrc.Text;
            mn = nm.Text;
            me = em.Text;
            p = psw.Text;
            dto = dt.Text;
            if (l.Checked == true)
            {
                gn = "L";
            } else
            {
                gn = "P";
            } 
          
            if (opsi == 1)//insert
            {
                q = "INSERT INTO Kariawan Values('" + mn + "','" + me + "','" + p + "','" + dto + "','" + gn + "')";
            }
            else if (opsi == 2)//update
            {
                q = "UPDATE Kariawan SET NamaKariawan='" + mn + "',Email='" + me + "',TglLahir='" + dto + "',JenisKelamin='" + gn + "' where IDKariawan='" + id + "'";
            }
            else if (opsi == 3)//select
            {
                q = "SELECT IDKariawan as 'ID', NamaKariawan as 'Nama',Email,TglLahir as 'Tanggal Lahir',JenisKelamin as 'Jenis Kelamin' from Kariawan";
            }
            else if (opsi == 4)//serch
            {
                q = "SELECT IDKariawan as 'ID', NamaKariawan as 'Nama',Email,TglLahir as 'Tanggal Lahir',JenisKelamin as 'Jenis Kelamin' from Kariawan where IDKariawan like '%"+sr+"%' OR NamaKariawan like '%"+sr+"%' or Email like '%"+sr+"%'";
            }
            else//delete
            {
                q = "DELETE FROM Kariawan Where IDKariawan='" + id + "'";
            }
            Showid();
            return q;
        }

        public Boolean valid()
        {
            if (empid.Text == "" || nm.Text == "" || em.Text == "" || dt.Text == "" )
            {
                MessageBox.Show("Fild not null!");

                return false;
            }
            return true;
        }

        public void Showid()
        {
            String id;
            id=qr.GetData("SELECT * FROM Kariawan Order by IDKariawan desc","IDKariawan");
            int inid = int.Parse(id)+1;
            empid.Text = inid.ToString();
        }
        public ManageEmployee()
        {
            InitializeComponent();
            SetLabel();
            cls();
            Show(GetQuery(3));
            Showid();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            empid.Text = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
            nm.Text = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
            em.Text = dgv.Rows[e.RowIndex].Cells[2].Value.ToString();
            dt.Text = dgv.Rows[e.RowIndex].Cells[3].Value.ToString();
            String gn=dgv.Rows[e.RowIndex].Cells[4].Value.ToString();
            if (gn == "L")
            {
                l.Select();
            }
            else
            {
                p.Select();
            }
    
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
            if (empid.Text != "")
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
