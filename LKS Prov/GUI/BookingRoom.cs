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
    public partial class BookingRoom : Form
    {

        Kelas.Query qr = new Kelas.Query();

        public void cls()
        {
            rt.Text = "";
            cid.Text = "";
            rt.Text = "";
            rt2.Text = "";
            gid.Text = "";
            nm.Text = "";
            rn.Text = "";
            dt2.Text = "";
            ls.Text = "";
            af.Text = "";
            cty.Text = "";
            foor.Text = "";
            rmp.Text = "";
            tprc.Text = "";
            tax.Text = "";
            tot.Text = "";
            gid.Enabled = false;
        }

        public void Show(String q)
        {
            qr.ShowAll(q, "Pemesanan", dgv);
            dgv.AllowUserToAddRows = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.Refresh();
        }

        public String GetQuery(int opsi)
        {
            String q, idj, tp, wm, ip, ik, hp, ih, lt, st, ikk;
           // sr = tsrc.Text;
           // id = qr.GetData("SELECT * FROM TypeKamar Where NamaTypeKamar='" + rmtyp.Text + "'", "IDTypeKamar");
            if (opsi == 1)//insert
            {
                // q = "INSERT INTO Kamar Values('" + idj + "','" + tp + "','" + wm + "','"+ip+"','"+ik+"','"+hp+"','"+ih+"','"+lt+"','"+st+"','"+ikk+"')";
                q = "";
            }
            else
            {
                q = "select a.IDFasilitasTambahan as 'id',a.NamaFailitasTambahan as 'Additional faciliti Name',a.HargaFasilitasTambahan as 'Price' from FasilitasTambahan a";
            }

            return q;
        }

        public void Box()
        {
            qr.ShowBox("SELECT * FROM TypeKamar", "NamaTypeKamar", rt);
            qr.ShowBox("SELECT * FROM JenisPemesanan", "NamaJenisPemesanan", rt2);
            qr.ShowBox("SELECT * FROM FasilitasTambahan", "NamaFailitasTambahan", af);
            qr.ShowBox("select NamaPenghuni+' - '+Email as 'n' from Penghuni","n",nm);
        }

        public Boolean valid()
        {
            /*  if (rmtyp.Text == "" || dytyp.Text == "" || rp.Text == "" || bp.Text == "")
              {
                  MessageBox.Show("Fild not null!");
                  return false;
              }
              else
              {
                  return true;
              }*/
            return false;
        }

        public void SetLabel()
        {
            label1.Text = "Semerbak Bunga Hotel:Booking Room From";
            label2.Text = "Check Room Avaiable";
            label3.Text = "Booking Room";
            label4.Text = "Room Floor";
            label5.Text = "Room Type";
            label6.Text = "Check in Date";
            label7.Text = "Booking type";
            label8.Text = "Guest ID";
            label9.Text = "Guest Name.Email";
            label10.Text = "Room Number";
            label11.Text = "Check-in Date-Hour";
            label12.Text = "Long Stay";
            label13.Text = "Additional Facility";
            label14.Text = "Qty";
            label15.Text = "Floor";
            label16.Text = "Occupied";
            label17.Text = "Note";
            label18.Text = "Avaible";
            label19.Text = "In Repair";
            label20.Text = "Room Price";
            label21.Text = "Total Additional Facility Room";
            label22.Text = "Tax";
            label23.Text = "Total Price";
            add.Text = "Add";
            rmp.Enabled = false;
            tax.Enabled = false;
            tot.Enabled = false;
            tprc.Enabled = false;
            rn.Enabled = false;
            idk.Visible = false;
        }
        public BookingRoom()
        {
            InitializeComponent();
            SetLabel();
            cls();
            Show(GetQuery(3));
            Box();
           
        }

        private void BookingRoom_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddNewGuest gs = new AddNewGuest();
            gs.Show();
       
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            //foor.Text = DateTime.Now.ToString("ss");
            m.Text = DateTime.Now.ToString("hh");
            s.Text = DateTime.Now.ToString("mm");
        }

        private void nm_SelectedIndexChanged(object sender, EventArgs e)
        {
            gid.Text = qr.GetData("select * FROM penghuni where NamaPenghuni+' - '+Email='"+nm.Text+"'","IDPenghuni");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            qr.ShowBox("select NamaPenghuni+' - '+Email as 'n' from Penghuni", "n", nm);
            gid.Text = qr.GetData("select * FROM penghuni order by IDPenghuni desc", "IDPenghuni");
            nm.Text= qr.GetData("select NamaPenghuni+' - '+Email as 'n' FROM penghuni order by IDPenghuni desc", "n");
        }

        private void chk_Click(object sender, EventArgs e)
        {
            rmp.Text = qr.GetData("SELECT * FROM TypeKamar,HargaKamar where HargaKamar.IDTypeKamar=TypeKamar.IDTypeKamar and NamaTypeKamar='"+rt.Text+"'","HargaKamar");
            string id = qr.GetData("SELECT * FROM TypeKamar where NamaTypeKamar='"+rt.Text+"'","IDTypeKamar");
            qr.ShowBox("select * FROM Kamar WHERE IDTypeKamar='"+id+"'", "NomorKamar", rn);
            rn.Enabled = true;
        }

        private void rn_TextChanged(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            String makan, fs;
            int rom = int.Parse(rmp.Text);
            makan= qr.GetData("SELECT * FROM TypeKamar,HargaKamar where HargaKamar.IDTypeKamar=TypeKamar.IDTypeKamar and NamaTypeKamar='" + rt.Text + "'", "HargaSarapan");
            int bf = int.Parse(makan)*int.Parse(ls.Text);
            fs = qr.GetData("select * from FasilitasTambahan where NamaFailitasTambahan='" + af.Text+"'","HargaFasilitasTambahan");
            int jfs = int.Parse(fs)*int.Parse(cty.Text);
            int pjk = (bf + jfs+rom)*10/100;
            tax.Text = pjk.ToString();
            int jml = pjk + bf + jfs+rom;
            tot.Text = jml.ToString();
            tprc.Text = (bf + jfs).ToString();
        }

        private void can_Click(object sender, EventArgs e)
        {
            cls();
        }
    }
}
