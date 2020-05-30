namespace LKS_Prov.GUI
{
    partial class ManageRoom
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
            this.src = new System.Windows.Forms.Button();
            this.tsrc = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.del = new System.Windows.Forms.Button();
            this.upd = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.rmid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rmtyp = new System.Windows.Forms.ComboBox();
            this.fl = new System.Windows.Forms.TextBox();
            this.rmn = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // src
            // 
            this.src.Location = new System.Drawing.Point(310, 39);
            this.src.Name = "src";
            this.src.Size = new System.Drawing.Size(75, 23);
            this.src.TabIndex = 34;
            this.src.Text = "button4";
            this.src.UseVisualStyleBackColor = true;
            this.src.Click += new System.EventHandler(this.src_Click);
            // 
            // tsrc
            // 
            this.tsrc.Location = new System.Drawing.Point(52, 42);
            this.tsrc.Name = "tsrc";
            this.tsrc.Size = new System.Drawing.Size(241, 20);
            this.tsrc.TabIndex = 33;
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(10, 68);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(411, 336);
            this.dgv.TabIndex = 32;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // del
            // 
            this.del.Location = new System.Drawing.Point(622, 228);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(75, 23);
            this.del.TabIndex = 31;
            this.del.Text = "button3";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // upd
            // 
            this.upd.Location = new System.Drawing.Point(530, 228);
            this.upd.Name = "upd";
            this.upd.Size = new System.Drawing.Size(75, 23);
            this.upd.TabIndex = 30;
            this.upd.Text = "button2";
            this.upd.UseVisualStyleBackColor = true;
            this.upd.Click += new System.EventHandler(this.upd_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(439, 228);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 29;
            this.add.Text = "button1";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // rmid
            // 
            this.rmid.Location = new System.Drawing.Point(559, 72);
            this.rmid.Name = "rmid";
            this.rmid.Size = new System.Drawing.Size(96, 20);
            this.rmid.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(443, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(443, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(443, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(25, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 21);
            this.label1.TabIndex = 21;
            this.label1.Text = "label1";
            // 
            // rmtyp
            // 
            this.rmtyp.FormattingEnabled = true;
            this.rmtyp.Location = new System.Drawing.Point(559, 105);
            this.rmtyp.Name = "rmtyp";
            this.rmtyp.Size = new System.Drawing.Size(154, 21);
            this.rmtyp.TabIndex = 35;
            // 
            // fl
            // 
            this.fl.Location = new System.Drawing.Point(559, 186);
            this.fl.Name = "fl";
            this.fl.Size = new System.Drawing.Size(96, 20);
            this.fl.TabIndex = 36;
            // 
            // rmn
            // 
            this.rmn.Location = new System.Drawing.Point(559, 145);
            this.rmn.Name = "rmn";
            this.rmn.Size = new System.Drawing.Size(96, 20);
            this.rmn.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(443, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "label6";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(530, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 39;
            this.button1.Text = "Batal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ManageRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 416);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rmn);
            this.Controls.Add(this.fl);
            this.Controls.Add(this.rmtyp);
            this.Controls.Add(this.src);
            this.Controls.Add(this.tsrc);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.del);
            this.Controls.Add(this.upd);
            this.Controls.Add(this.add);
            this.Controls.Add(this.rmid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ManageRoom";
            this.Text = "ManageRoom";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button src;
        private System.Windows.Forms.TextBox tsrc;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button upd;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox rmid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox rmtyp;
        private System.Windows.Forms.TextBox fl;
        private System.Windows.Forms.TextBox rmn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}