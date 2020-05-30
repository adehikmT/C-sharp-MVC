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
    public partial class LoginForm : Form
    {
        Kelas.Query qr = new Kelas.Query();
        public void SetLabel()
        {
            label1.Text = "Semerbak Bunga Hotel";
            label2.Text = "Username";
            label3.Text = "Password";
            psw.PasswordChar = '*';
        }

        public void cls()
        {
            psw.Text = "";
            user.Text = "";
        }

        public String GetQuery()
        {
            String pw, usr, q;
            pw = psw.Text;
            usr = user.Text;
            q = "SELECT * FROM Kariawan where Password='"+pw+"' and Email='"+usr+"'";
            return q;
        }

        public LoginForm()
        {
            InitializeComponent();
            SetLabel();
            cls();
            Kelas.Koneksi con = new Kelas.Koneksi();
            con.GetCon();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (psw.Text!="" && user.Text!="")
            {
                if (qr.GetData(GetQuery(), "IDKariawan") != null)
                {
                    String id = qr.GetData(GetQuery(), "IDKariawan");
                    MainForm mn = new MainForm();
                    mn.Show();
                    mn.idk.Text = id;
                    mn.logout.Enabled = false;
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Please Try Again, Your Data Is not Valid!", "INFO", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Fild not null!","INFO",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
