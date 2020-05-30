namespace LKS_Prov.GUI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logout = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingRoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageBokingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputPymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewPymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageRoomTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageRoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageRoomFacilityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageRoomRepairmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.priceManagemnetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageDailyPriceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageHolidayPriceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageGuestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomAvailabilityReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.idk = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.transactionToolStripMenuItem,
            this.roomManagementToolStripMenuItem,
            this.priceManagemnetToolStripMenuItem,
            this.userManagementToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePasswordToolStripMenuItem,
            this.logout,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.changePasswordToolStripMenuItem.Text = "&Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // logout
            // 
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(168, 22);
            this.logout.Text = "&Login";
            this.logout.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.exitToolStripMenuItem.Text = "&Logout";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookingRoomToolStripMenuItem,
            this.manageBokingToolStripMenuItem,
            this.inputPymentToolStripMenuItem,
            this.viewPymentToolStripMenuItem});
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.transactionToolStripMenuItem.Text = "Transaction";
            // 
            // bookingRoomToolStripMenuItem
            // 
            this.bookingRoomToolStripMenuItem.Name = "bookingRoomToolStripMenuItem";
            this.bookingRoomToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.bookingRoomToolStripMenuItem.Text = "Booking Room";
            this.bookingRoomToolStripMenuItem.Click += new System.EventHandler(this.bookingRoomToolStripMenuItem_Click);
            // 
            // manageBokingToolStripMenuItem
            // 
            this.manageBokingToolStripMenuItem.Name = "manageBokingToolStripMenuItem";
            this.manageBokingToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.manageBokingToolStripMenuItem.Text = "Manage Boking";
            this.manageBokingToolStripMenuItem.Click += new System.EventHandler(this.manageBokingToolStripMenuItem_Click);
            // 
            // inputPymentToolStripMenuItem
            // 
            this.inputPymentToolStripMenuItem.Name = "inputPymentToolStripMenuItem";
            this.inputPymentToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.inputPymentToolStripMenuItem.Text = "Input Pyment";
            this.inputPymentToolStripMenuItem.Click += new System.EventHandler(this.inputPymentToolStripMenuItem_Click);
            // 
            // viewPymentToolStripMenuItem
            // 
            this.viewPymentToolStripMenuItem.Name = "viewPymentToolStripMenuItem";
            this.viewPymentToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.viewPymentToolStripMenuItem.Text = "view Pyment";
            this.viewPymentToolStripMenuItem.Click += new System.EventHandler(this.viewPymentToolStripMenuItem_Click);
            // 
            // roomManagementToolStripMenuItem
            // 
            this.roomManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageRoomTypeToolStripMenuItem,
            this.manageRoomToolStripMenuItem,
            this.manageRoomFacilityToolStripMenuItem,
            this.manageRoomRepairmentToolStripMenuItem});
            this.roomManagementToolStripMenuItem.Name = "roomManagementToolStripMenuItem";
            this.roomManagementToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.roomManagementToolStripMenuItem.Text = "Room Management";
            // 
            // manageRoomTypeToolStripMenuItem
            // 
            this.manageRoomTypeToolStripMenuItem.Name = "manageRoomTypeToolStripMenuItem";
            this.manageRoomTypeToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.manageRoomTypeToolStripMenuItem.Text = "Manage Room Type";
            this.manageRoomTypeToolStripMenuItem.Click += new System.EventHandler(this.manageRoomTypeToolStripMenuItem_Click);
            // 
            // manageRoomToolStripMenuItem
            // 
            this.manageRoomToolStripMenuItem.Name = "manageRoomToolStripMenuItem";
            this.manageRoomToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.manageRoomToolStripMenuItem.Text = "Manage Room";
            this.manageRoomToolStripMenuItem.Click += new System.EventHandler(this.manageRoomToolStripMenuItem_Click);
            // 
            // manageRoomFacilityToolStripMenuItem
            // 
            this.manageRoomFacilityToolStripMenuItem.Name = "manageRoomFacilityToolStripMenuItem";
            this.manageRoomFacilityToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.manageRoomFacilityToolStripMenuItem.Text = "Manage Room Facility";
            this.manageRoomFacilityToolStripMenuItem.Click += new System.EventHandler(this.manageRoomFacilityToolStripMenuItem_Click);
            // 
            // manageRoomRepairmentToolStripMenuItem
            // 
            this.manageRoomRepairmentToolStripMenuItem.Name = "manageRoomRepairmentToolStripMenuItem";
            this.manageRoomRepairmentToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.manageRoomRepairmentToolStripMenuItem.Text = "Manage Room Repairment";
            this.manageRoomRepairmentToolStripMenuItem.Click += new System.EventHandler(this.manageRoomRepairmentToolStripMenuItem_Click);
            // 
            // priceManagemnetToolStripMenuItem
            // 
            this.priceManagemnetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageDailyPriceToolStripMenuItem,
            this.manageHolidayPriceToolStripMenuItem});
            this.priceManagemnetToolStripMenuItem.Name = "priceManagemnetToolStripMenuItem";
            this.priceManagemnetToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.priceManagemnetToolStripMenuItem.Text = "Price Managemnet";
            // 
            // manageDailyPriceToolStripMenuItem
            // 
            this.manageDailyPriceToolStripMenuItem.Name = "manageDailyPriceToolStripMenuItem";
            this.manageDailyPriceToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.manageDailyPriceToolStripMenuItem.Text = "Manage Daily Price";
            this.manageDailyPriceToolStripMenuItem.Click += new System.EventHandler(this.manageDailyPriceToolStripMenuItem_Click);
            // 
            // manageHolidayPriceToolStripMenuItem
            // 
            this.manageHolidayPriceToolStripMenuItem.Name = "manageHolidayPriceToolStripMenuItem";
            this.manageHolidayPriceToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.manageHolidayPriceToolStripMenuItem.Text = "Manage Holiday Price";
            this.manageHolidayPriceToolStripMenuItem.Click += new System.EventHandler(this.manageHolidayPriceToolStripMenuItem_Click);
            // 
            // userManagementToolStripMenuItem
            // 
            this.userManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageEmployeeToolStripMenuItem,
            this.manageGuestToolStripMenuItem});
            this.userManagementToolStripMenuItem.Name = "userManagementToolStripMenuItem";
            this.userManagementToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.userManagementToolStripMenuItem.Text = "User Management";
            // 
            // manageEmployeeToolStripMenuItem
            // 
            this.manageEmployeeToolStripMenuItem.Name = "manageEmployeeToolStripMenuItem";
            this.manageEmployeeToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.manageEmployeeToolStripMenuItem.Text = "Manage Employee";
            this.manageEmployeeToolStripMenuItem.Click += new System.EventHandler(this.manageEmployeeToolStripMenuItem_Click);
            // 
            // manageGuestToolStripMenuItem
            // 
            this.manageGuestToolStripMenuItem.Name = "manageGuestToolStripMenuItem";
            this.manageGuestToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.manageGuestToolStripMenuItem.Text = "Manage Guest";
            this.manageGuestToolStripMenuItem.Click += new System.EventHandler(this.manageGuestToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transactionReportToolStripMenuItem,
            this.roomAvailabilityReportToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // transactionReportToolStripMenuItem
            // 
            this.transactionReportToolStripMenuItem.Name = "transactionReportToolStripMenuItem";
            this.transactionReportToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.transactionReportToolStripMenuItem.Text = "Transaction Report";
            this.transactionReportToolStripMenuItem.Click += new System.EventHandler(this.transactionReportToolStripMenuItem_Click);
            // 
            // roomAvailabilityReportToolStripMenuItem
            // 
            this.roomAvailabilityReportToolStripMenuItem.Name = "roomAvailabilityReportToolStripMenuItem";
            this.roomAvailabilityReportToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.roomAvailabilityReportToolStripMenuItem.Text = "Room Availability Report";
            this.roomAvailabilityReportToolStripMenuItem.Click += new System.EventHandler(this.roomAvailabilityReportToolStripMenuItem_Click);
            // 
            // idk
            // 
            this.idk.AutoSize = true;
            this.idk.Location = new System.Drawing.Point(358, 48);
            this.idk.Name = "idk";
            this.idk.Size = new System.Drawing.Size(15, 13);
            this.idk.TabIndex = 2;
            this.idk.Text = "id";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.idk);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "Semerbak Bunga Hotel";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookingRoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageBokingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputPymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewPymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageRoomTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageRoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageRoomFacilityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageRoomRepairmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem priceManagemnetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageDailyPriceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageHolidayPriceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageGuestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomAvailabilityReportToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem logout;
        public System.Windows.Forms.Label idk;
    }
}



