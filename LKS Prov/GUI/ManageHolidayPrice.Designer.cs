namespace LKS_Prov.GUI
{
    partial class ManageHolidayPrice
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
            this.pr = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tsrc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.del = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.src = new System.Windows.Forms.Button();
            this.rmtyp = new System.Windows.Forms.ComboBox();
            this.add = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dt1 = new System.Windows.Forms.DateTimePicker();
            this.dt2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pr
            // 
            this.pr.Location = new System.Drawing.Point(129, 120);
            this.pr.Name = "pr";
            this.pr.Size = new System.Drawing.Size(100, 20);
            this.pr.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "label6";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(37, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 21);
            this.label1.TabIndex = 36;
            this.label1.Text = "label1";
            // 
            // tsrc
            // 
            this.tsrc.Location = new System.Drawing.Point(170, 227);
            this.tsrc.Name = "tsrc";
            this.tsrc.Size = new System.Drawing.Size(202, 20);
            this.tsrc.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "label4";
            // 
            // del
            // 
            this.del.Location = new System.Drawing.Point(483, 226);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(75, 23);
            this.del.TabIndex = 39;
            this.del.Text = "button3";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(23, 273);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(759, 202);
            this.dgv.TabIndex = 38;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // src
            // 
            this.src.Location = new System.Drawing.Point(390, 227);
            this.src.Name = "src";
            this.src.Size = new System.Drawing.Size(75, 23);
            this.src.TabIndex = 35;
            this.src.Text = "button2";
            this.src.UseVisualStyleBackColor = true;
            this.src.Click += new System.EventHandler(this.src_Click);
            // 
            // rmtyp
            // 
            this.rmtyp.FormattingEnabled = true;
            this.rmtyp.Location = new System.Drawing.Point(129, 30);
            this.rmtyp.Name = "rmtyp";
            this.rmtyp.Size = new System.Drawing.Size(216, 21);
            this.rmtyp.TabIndex = 4;
            this.rmtyp.SelectedIndexChanged += new System.EventHandler(this.rmtyp_SelectedIndexChanged);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(343, 139);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 3;
            this.add.Text = "button1";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dt1);
            this.panel1.Controls.Add(this.dt2);
            this.panel1.Controls.Add(this.pr);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.rmtyp);
            this.panel1.Controls.Add(this.add);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(22, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 178);
            this.panel1.TabIndex = 33;
            // 
            // dt1
            // 
            this.dt1.Location = new System.Drawing.Point(129, 58);
            this.dt1.Name = "dt1";
            this.dt1.Size = new System.Drawing.Size(137, 20);
            this.dt1.TabIndex = 11;
            // 
            // dt2
            // 
            this.dt2.Location = new System.Drawing.Point(129, 88);
            this.dt2.Name = "dt2";
            this.dt2.Size = new System.Drawing.Size(137, 20);
            this.dt2.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "label3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "label5";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(567, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "label8";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(480, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Batal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ManageHolidayPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 488);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tsrc);
            this.Controls.Add(this.del);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.src);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Name = "ManageHolidayPrice";
            this.Text = "ManageHolidayPrice";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox pr;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tsrc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button src;
        private System.Windows.Forms.ComboBox rmtyp;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dt1;
        private System.Windows.Forms.DateTimePicker dt2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
    }
}