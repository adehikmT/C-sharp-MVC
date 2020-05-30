namespace LKS_Prov.GUI
{
    partial class ManageRoomType
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rmid = new System.Windows.Forms.TextBox();
            this.nm = new System.Windows.Forms.TextBox();
            this.ds = new System.Windows.Forms.RichTextBox();
            this.add = new System.Windows.Forms.Button();
            this.upd = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.tsrc = new System.Windows.Forms.TextBox();
            this.src = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(27, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(376, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(376, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(376, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "label5";
            // 
            // rmid
            // 
            this.rmid.Location = new System.Drawing.Point(447, 73);
            this.rmid.Name = "rmid";
            this.rmid.Size = new System.Drawing.Size(176, 20);
            this.rmid.TabIndex = 12;
            // 
            // nm
            // 
            this.nm.Location = new System.Drawing.Point(447, 112);
            this.nm.Name = "nm";
            this.nm.Size = new System.Drawing.Size(176, 20);
            this.nm.TabIndex = 13;
            // 
            // ds
            // 
            this.ds.Location = new System.Drawing.Point(447, 149);
            this.ds.Name = "ds";
            this.ds.Size = new System.Drawing.Size(258, 96);
            this.ds.TabIndex = 14;
            this.ds.Text = "";
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(447, 294);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 15;
            this.add.Text = "button1";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // upd
            // 
            this.upd.Location = new System.Drawing.Point(538, 294);
            this.upd.Name = "upd";
            this.upd.Size = new System.Drawing.Size(75, 23);
            this.upd.TabIndex = 16;
            this.upd.Text = "button2";
            this.upd.UseVisualStyleBackColor = true;
            this.upd.Click += new System.EventHandler(this.upd_Click);
            // 
            // del
            // 
            this.del.Location = new System.Drawing.Point(630, 294);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(75, 23);
            this.del.TabIndex = 17;
            this.del.Text = "button3";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 69);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(358, 336);
            this.dgv.TabIndex = 18;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // tsrc
            // 
            this.tsrc.Location = new System.Drawing.Point(54, 43);
            this.tsrc.Name = "tsrc";
            this.tsrc.Size = new System.Drawing.Size(241, 20);
            this.tsrc.TabIndex = 19;
            // 
            // src
            // 
            this.src.Location = new System.Drawing.Point(312, 40);
            this.src.Name = "src";
            this.src.Size = new System.Drawing.Size(75, 23);
            this.src.TabIndex = 20;
            this.src.Text = "button4";
            this.src.UseVisualStyleBackColor = true;
            this.src.Click += new System.EventHandler(this.src_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(538, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 40;
            this.button1.Text = "Batal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ManageRoomType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 417);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.src);
            this.Controls.Add(this.tsrc);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.del);
            this.Controls.Add(this.upd);
            this.Controls.Add(this.add);
            this.Controls.Add(this.ds);
            this.Controls.Add(this.nm);
            this.Controls.Add(this.rmid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ManageRoomType";
            this.Text = "ManageRoomType";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox rmid;
        private System.Windows.Forms.TextBox nm;
        private System.Windows.Forms.RichTextBox ds;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button upd;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox tsrc;
        private System.Windows.Forms.Button src;
        private System.Windows.Forms.Button button1;
    }
}