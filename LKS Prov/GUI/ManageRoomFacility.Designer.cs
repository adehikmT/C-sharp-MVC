namespace LKS_Prov.GUI
{
    partial class ManageRoomFacility
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.fn = new System.Windows.Forms.ComboBox();
            this.rm = new System.Windows.Forms.ComboBox();
            this.add = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tsrc = new System.Windows.Forms.TextBox();
            this.src = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.del = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.jml = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.jml);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.fn);
            this.panel1.Controls.Add(this.rm);
            this.panel1.Controls.Add(this.add);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 128);
            this.panel1.TabIndex = 0;
            // 
            // fn
            // 
            this.fn.FormattingEnabled = true;
            this.fn.Location = new System.Drawing.Point(92, 59);
            this.fn.Name = "fn";
            this.fn.Size = new System.Drawing.Size(216, 21);
            this.fn.TabIndex = 5;
            // 
            // rm
            // 
            this.rm.FormattingEnabled = true;
            this.rm.Location = new System.Drawing.Point(92, 30);
            this.rm.Name = "rm";
            this.rm.Size = new System.Drawing.Size(216, 21);
            this.rm.TabIndex = 4;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(348, 89);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 3;
            this.add.Text = "button1";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "label3";
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
            this.label1.Location = new System.Drawing.Point(27, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 21);
            this.label1.TabIndex = 22;
            this.label1.Text = "label1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "label5";
            // 
            // tsrc
            // 
            this.tsrc.Location = new System.Drawing.Point(172, 186);
            this.tsrc.Name = "tsrc";
            this.tsrc.Size = new System.Drawing.Size(190, 20);
            this.tsrc.TabIndex = 23;
            // 
            // src
            // 
            this.src.Location = new System.Drawing.Point(380, 186);
            this.src.Name = "src";
            this.src.Size = new System.Drawing.Size(75, 23);
            this.src.TabIndex = 4;
            this.src.Text = "button2";
            this.src.UseVisualStyleBackColor = true;
            this.src.Click += new System.EventHandler(this.src_Click);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(13, 219);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(759, 202);
            this.dgv.TabIndex = 24;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // del
            // 
            this.del.Location = new System.Drawing.Point(473, 185);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(75, 23);
            this.del.TabIndex = 25;
            this.del.Text = "button3";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Jumlah Fasilitas";
            // 
            // jml
            // 
            this.jml.Location = new System.Drawing.Point(101, 92);
            this.jml.Name = "jml";
            this.jml.Size = new System.Drawing.Size(190, 20);
            this.jml.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(420, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "label7";
            // 
            // ManageRoomFacility
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 451);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.del);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.src);
            this.Controls.Add(this.tsrc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "ManageRoomFacility";
            this.Text = "ManageRoomFacility";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tsrc;
        private System.Windows.Forms.Button src;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.ComboBox fn;
        private System.Windows.Forms.ComboBox rm;
        private System.Windows.Forms.TextBox jml;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}