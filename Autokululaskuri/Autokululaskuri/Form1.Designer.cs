namespace Autokululaskuri
{
    partial class Form1
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
            this.KilometritCB = new System.Windows.Forms.ComboBox();
            this.LainaTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.NesteetTB = new System.Windows.Forms.TextBox();
            this.VakuutusTB = new System.Windows.Forms.TextBox();
            this.MuutkulutTB = new System.Windows.Forms.TextBox();
            this.PolttonesteTB = new System.Windows.Forms.TextBox();
            this.PesutTB = new System.Windows.Forms.TextBox();
            this.HuollotTB = new System.Windows.Forms.TextBox();
            this.RenkaatTB = new System.Windows.Forms.TextBox();
            this.VastausLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // KilometritCB
            // 
            this.KilometritCB.FormattingEnabled = true;
            this.KilometritCB.Items.AddRange(new object[] {
            "1000",
            "10000",
            "50000"});
            this.KilometritCB.Location = new System.Drawing.Point(798, 217);
            this.KilometritCB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.KilometritCB.Name = "KilometritCB";
            this.KilometritCB.Size = new System.Drawing.Size(238, 33);
            this.KilometritCB.TabIndex = 0;
            this.KilometritCB.SelectedIndexChanged += new System.EventHandler(this.KilometritCB_SelectedIndexChanged);
            // 
            // LainaTB
            // 
            this.LainaTB.Location = new System.Drawing.Point(386, 74);
            this.LainaTB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.LainaTB.Name = "LainaTB";
            this.LainaTB.Size = new System.Drawing.Size(131, 31);
            this.LainaTB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lainan lyhennys korkoineen:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lisättävät nesteet yms:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Vakuutusmaksut:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Muut kulut:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Polttoneste:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(619, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Pesut:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(619, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "Huollot:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(619, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 25);
            this.label8.TabIndex = 9;
            this.label8.Text = "Renkaat:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(619, 220);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 25);
            this.label9.TabIndex = 10;
            this.label9.Text = "Kilometrit/vuosi";
            // 
            // NesteetTB
            // 
            this.NesteetTB.Location = new System.Drawing.Point(386, 125);
            this.NesteetTB.Name = "NesteetTB";
            this.NesteetTB.Size = new System.Drawing.Size(131, 31);
            this.NesteetTB.TabIndex = 11;
            // 
            // VakuutusTB
            // 
            this.VakuutusTB.Location = new System.Drawing.Point(386, 172);
            this.VakuutusTB.Name = "VakuutusTB";
            this.VakuutusTB.Size = new System.Drawing.Size(131, 31);
            this.VakuutusTB.TabIndex = 12;
            // 
            // MuutkulutTB
            // 
            this.MuutkulutTB.Location = new System.Drawing.Point(386, 217);
            this.MuutkulutTB.Name = "MuutkulutTB";
            this.MuutkulutTB.Size = new System.Drawing.Size(131, 31);
            this.MuutkulutTB.TabIndex = 13;
            // 
            // PolttonesteTB
            // 
            this.PolttonesteTB.Location = new System.Drawing.Point(386, 260);
            this.PolttonesteTB.Name = "PolttonesteTB";
            this.PolttonesteTB.Size = new System.Drawing.Size(131, 31);
            this.PolttonesteTB.TabIndex = 14;
            // 
            // PesutTB
            // 
            this.PesutTB.Location = new System.Drawing.Point(798, 74);
            this.PesutTB.Name = "PesutTB";
            this.PesutTB.Size = new System.Drawing.Size(103, 31);
            this.PesutTB.TabIndex = 15;
            // 
            // HuollotTB
            // 
            this.HuollotTB.Location = new System.Drawing.Point(798, 122);
            this.HuollotTB.Name = "HuollotTB";
            this.HuollotTB.Size = new System.Drawing.Size(103, 31);
            this.HuollotTB.TabIndex = 16;
            // 
            // RenkaatTB
            // 
            this.RenkaatTB.Location = new System.Drawing.Point(798, 175);
            this.RenkaatTB.Name = "RenkaatTB";
            this.RenkaatTB.Size = new System.Drawing.Size(103, 31);
            this.RenkaatTB.TabIndex = 17;
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Location = new System.Drawing.Point(87, 362);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(82, 25);
            this.VastausLB.TabIndex = 18;
            this.VastausLB.Text = "label10";
            this.VastausLB.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 609);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.RenkaatTB);
            this.Controls.Add(this.HuollotTB);
            this.Controls.Add(this.PesutTB);
            this.Controls.Add(this.PolttonesteTB);
            this.Controls.Add(this.MuutkulutTB);
            this.Controls.Add(this.VakuutusTB);
            this.Controls.Add(this.NesteetTB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LainaTB);
            this.Controls.Add(this.KilometritCB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox KilometritCB;
        private System.Windows.Forms.TextBox LainaTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox NesteetTB;
        private System.Windows.Forms.TextBox VakuutusTB;
        private System.Windows.Forms.TextBox MuutkulutTB;
        private System.Windows.Forms.TextBox PolttonesteTB;
        private System.Windows.Forms.TextBox PesutTB;
        private System.Windows.Forms.TextBox HuollotTB;
        private System.Windows.Forms.TextBox RenkaatTB;
        private System.Windows.Forms.Label VastausLB;
    }
}

