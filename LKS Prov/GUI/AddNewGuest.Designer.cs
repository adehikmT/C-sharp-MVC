namespace LKS_Prov.GUI
{
    partial class AddNewGuest
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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.vt = new System.Windows.Forms.ComboBox();
            this.ln = new System.Windows.Forms.TextBox();
            this.pn = new System.Windows.Forms.TextBox();
            this.em = new System.Windows.Forms.TextBox();
            this.ic = new System.Windows.Forms.TextBox();
            this.nm = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(67, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(68, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "label7";
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(71, 347);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 20;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // vt
            // 
            this.vt.FormattingEnabled = true;
            this.vt.Location = new System.Drawing.Point(189, 287);
            this.vt.Name = "vt";
            this.vt.Size = new System.Drawing.Size(183, 21);
            this.vt.TabIndex = 89;
            // 
            // ln
            // 
            this.ln.Location = new System.Drawing.Point(189, 251);
            this.ln.Name = "ln";
            this.ln.Size = new System.Drawing.Size(145, 20);
            this.ln.TabIndex = 88;
            // 
            // pn
            // 
            this.pn.Location = new System.Drawing.Point(189, 208);
            this.pn.Name = "pn";
            this.pn.Size = new System.Drawing.Size(145, 20);
            this.pn.TabIndex = 87;
            // 
            // em
            // 
            this.em.Location = new System.Drawing.Point(189, 131);
            this.em.Name = "em";
            this.em.Size = new System.Drawing.Size(145, 20);
            this.em.TabIndex = 86;
            // 
            // ic
            // 
            this.ic.Location = new System.Drawing.Point(189, 170);
            this.ic.Name = "ic";
            this.ic.Size = new System.Drawing.Size(183, 20);
            this.ic.TabIndex = 85;
            // 
            // nm
            // 
            this.nm.Location = new System.Drawing.Point(189, 94);
            this.nm.Name = "nm";
            this.nm.Size = new System.Drawing.Size(96, 20);
            this.nm.TabIndex = 84;
            // 
            // AddNewGuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 396);
            this.Controls.Add(this.vt);
            this.Controls.Add(this.ln);
            this.Controls.Add(this.pn);
            this.Controls.Add(this.em);
            this.Controls.Add(this.ic);
            this.Controls.Add(this.nm);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddNewGuest";
            this.Text = "AddNewGuest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.ComboBox vt;
        private System.Windows.Forms.TextBox ln;
        private System.Windows.Forms.TextBox pn;
        private System.Windows.Forms.TextBox em;
        private System.Windows.Forms.TextBox ic;
        private System.Windows.Forms.TextBox nm;
    }
}