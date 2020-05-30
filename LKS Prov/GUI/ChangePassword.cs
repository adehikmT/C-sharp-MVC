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
    public partial class ChangePassword : Form
    {
        Kelas.Query qr = new Kelas.Query();
        
        public void SetLabel()
        {
            label1.Text = "Semerbak Bunga Hotel";
            label2.Text = "Old Password";
            label3.Text = "New Password";
            label4.Text = "Confirm Password";
            psw.PasswordChar = '*';
            old.PasswordChar = '*';
            confirm.PasswordChar = '*';

        }

        public void cls()
        {
            psw.Text = "";
            old.Text = "";
            confirm.Text = "";
        }

        public String GetQuery(int opsi)
        {
            String cm,pw, ld,q,id;
            pw = psw.Text;
            ld =old.Text;
            id = idk.Text;
            cm = confirm.Text;
            if (opsi == 1)
            {
                q = "SELECT * FROM Kariawan where Password='" + ld + "' and IDKariawan='" + id + "'";
            }
            else
            {
                q = "UPDATE Kariawan SET Password='"+cm+"' where IDKariawan='"+id+"'";
            }
                
            return q;
        }

        public ChangePassword()
        {
            InitializeComponent();
            SetLabel();
            cls();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (psw.Text!=""&&old.Text!=""&&confirm.Text!="")
            {
                if (qr.GetData(GetQuery(1), "IDKariawan") != null)
                {
                    if (psw.Text==confirm.Text)
                    {
                        qr.InUpDel(GetQuery(2),"Password is Change!");
                    }
                    else
                    {
                        MessageBox.Show("Password Not Match!");
                    }
                }
                else
                {
                    MessageBox.Show("Your Password Not registed!");
                }
            }
        }
    }
}
