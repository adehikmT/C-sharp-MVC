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
    public partial class MainForm : Form
    {
        private int childFormNumber = 0;

        public MainForm()
        {
            InitializeComponent();
            idk.Visible = false;
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword fm = new ChangePassword();
            fm.MdiParent = this;
            fm.idk.Text = idk.Text;
            fm.idk.Visible = false;
            fm.Show();
        }

        private void bookingRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookingRoom fm = new BookingRoom();
            fm.MdiParent = this;
            fm.idk.Text = idk.Text;
            fm.Show();
        }

        private void manageBokingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageBooking fm = new ManageBooking();
            fm.MdiParent = this;
            fm.Show();
        }

        private void inputPymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputPayment fm = new InputPayment();
            fm.MdiParent = this;
            fm.Show();
        }

        private void viewPymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewPayment fm = new ViewPayment();
            fm.MdiParent = this;
            fm.Show();
        }

        private void manageRoomTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageRoomType fm = new ManageRoomType();
            fm.MdiParent = this;
            fm.Show();
        }

        private void manageRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageRoom fm = new ManageRoom();
            fm.MdiParent = this;
            fm.Show();
        }

        private void manageRoomFacilityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageRoomFacility fm = new ManageRoomFacility();
            fm.MdiParent = this;
            fm.Show();
        }

        private void manageRoomRepairmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageRoomRepairment fm = new ManageRoomRepairment();
            fm.MdiParent = this;
            fm.Show();
            fm.label9.Text = idk.Text;
        }

        private void manageDailyPriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageDailyPrice fm = new ManageDailyPrice();
            fm.MdiParent = this;
            fm.Show();
        }

        private void manageHolidayPriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
           ManageHolidayPrice fm = new ManageHolidayPrice();
            fm.MdiParent = this;
            fm.Show();
        }

        private void manageEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageEmployee fm = new ManageEmployee();
            fm.MdiParent = this;
            fm.Show();
        }

        private void manageGuestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageGuest fm = new ManageGuest();
            fm.MdiParent = this;
            fm.Show();
        }

        private void transactionReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransactionReport fm = new TransactionReport();
            fm.MdiParent = this;
            fm.Show();
        }

        private void roomAvailabilityReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RoomAvailble fm = new RoomAvailble();
            fm.MdiParent = this;
            fm.Show();
        }
    }
}
