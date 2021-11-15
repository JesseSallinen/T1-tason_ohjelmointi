
namespace CRUD_tehtava
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SukunimiTB = new System.Windows.Forms.TextBox();
            this.EtunimiTB = new System.Windows.Forms.TextBox();
            this.idTB = new System.Windows.Forms.TextBox();
            this.PuhelinTB = new System.Windows.Forms.TextBox();
            this.PostiTB = new System.Windows.Forms.TextBox();
            this.NumeroTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TietotauluDG = new System.Windows.Forms.DataGridView();
            this.TyhjennaBT = new System.Windows.Forms.Button();
            this.TallennaBT = new System.Windows.Forms.Button();
            this.PaivitaBT = new System.Windows.Forms.Button();
            this.PoistaBT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TietotauluDG)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "ETUNIMI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "SUKUNIMI:";
            // 
            // SukunimiTB
            // 
            this.SukunimiTB.Location = new System.Drawing.Point(130, 90);
            this.SukunimiTB.Name = "SukunimiTB";
            this.SukunimiTB.Size = new System.Drawing.Size(242, 29);
            this.SukunimiTB.TabIndex = 3;
            // 
            // EtunimiTB
            // 
            this.EtunimiTB.Location = new System.Drawing.Point(130, 56);
            this.EtunimiTB.Name = "EtunimiTB";
            this.EtunimiTB.Size = new System.Drawing.Size(242, 29);
            this.EtunimiTB.TabIndex = 4;
            // 
            // idTB
            // 
            this.idTB.Location = new System.Drawing.Point(130, 22);
            this.idTB.Name = "idTB";
            this.idTB.Size = new System.Drawing.Size(242, 29);
            this.idTB.TabIndex = 5;
            // 
            // PuhelinTB
            // 
            this.PuhelinTB.Location = new System.Drawing.Point(577, 23);
            this.PuhelinTB.Name = "PuhelinTB";
            this.PuhelinTB.Size = new System.Drawing.Size(249, 29);
            this.PuhelinTB.TabIndex = 11;
            // 
            // PostiTB
            // 
            this.PostiTB.Location = new System.Drawing.Point(577, 56);
            this.PostiTB.Name = "PostiTB";
            this.PostiTB.Size = new System.Drawing.Size(249, 29);
            this.PostiTB.TabIndex = 10;
            // 
            // NumeroTB
            // 
            this.NumeroTB.Location = new System.Drawing.Point(577, 89);
            this.NumeroTB.Name = "NumeroTB";
            this.NumeroTB.Size = new System.Drawing.Size(249, 29);
            this.NumeroTB.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(396, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "OPISKELIJANRO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(396, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "SÄHKÖPOSTI:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(396, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "PUHELIN:";
            // 
            // TietotauluDG
            // 
            this.TietotauluDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TietotauluDG.Location = new System.Drawing.Point(12, 188);
            this.TietotauluDG.Name = "TietotauluDG";
            this.TietotauluDG.Size = new System.Drawing.Size(1177, 381);
            this.TietotauluDG.TabIndex = 12;
            this.TietotauluDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TietotauluDG_CellContentClick);
            // 
            // TyhjennaBT
            // 
            this.TyhjennaBT.Location = new System.Drawing.Point(16, 140);
            this.TyhjennaBT.Name = "TyhjennaBT";
            this.TyhjennaBT.Size = new System.Drawing.Size(163, 42);
            this.TyhjennaBT.TabIndex = 13;
            this.TyhjennaBT.Text = "TYHJENNÄ";
            this.TyhjennaBT.UseVisualStyleBackColor = true;
            this.TyhjennaBT.Click += new System.EventHandler(this.TyhjennaBT_Click);
            // 
            // TallennaBT
            // 
            this.TallennaBT.Location = new System.Drawing.Point(211, 140);
            this.TallennaBT.Name = "TallennaBT";
            this.TallennaBT.Size = new System.Drawing.Size(163, 42);
            this.TallennaBT.TabIndex = 14;
            this.TallennaBT.Text = "TALLENNA";
            this.TallennaBT.UseVisualStyleBackColor = true;
            this.TallennaBT.Click += new System.EventHandler(this.TallennaBT_Click);
            // 
            // PaivitaBT
            // 
            this.PaivitaBT.Location = new System.Drawing.Point(406, 140);
            this.PaivitaBT.Name = "PaivitaBT";
            this.PaivitaBT.Size = new System.Drawing.Size(163, 42);
            this.PaivitaBT.TabIndex = 15;
            this.PaivitaBT.Text = "PÄIVITÄ";
            this.PaivitaBT.UseVisualStyleBackColor = true;
            this.PaivitaBT.Click += new System.EventHandler(this.PaivitaBT_Click);
            // 
            // PoistaBT
            // 
            this.PoistaBT.Location = new System.Drawing.Point(601, 140);
            this.PoistaBT.Name = "PoistaBT";
            this.PoistaBT.Size = new System.Drawing.Size(163, 42);
            this.PoistaBT.TabIndex = 16;
            this.PoistaBT.Text = "POISTA";
            this.PoistaBT.UseVisualStyleBackColor = true;
            this.PoistaBT.Click += new System.EventHandler(this.PoistaBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 571);
            this.Controls.Add(this.PoistaBT);
            this.Controls.Add(this.PaivitaBT);
            this.Controls.Add(this.TallennaBT);
            this.Controls.Add(this.TyhjennaBT);
            this.Controls.Add(this.TietotauluDG);
            this.Controls.Add(this.PuhelinTB);
            this.Controls.Add(this.PostiTB);
            this.Controls.Add(this.NumeroTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.idTB);
            this.Controls.Add(this.EtunimiTB);
            this.Controls.Add(this.SukunimiTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TietotauluDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SukunimiTB;
        private System.Windows.Forms.TextBox EtunimiTB;
        private System.Windows.Forms.TextBox idTB;
        private System.Windows.Forms.TextBox PuhelinTB;
        private System.Windows.Forms.TextBox PostiTB;
        private System.Windows.Forms.TextBox NumeroTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView TietotauluDG;
        private System.Windows.Forms.Button TyhjennaBT;
        private System.Windows.Forms.Button TallennaBT;
        private System.Windows.Forms.Button PaivitaBT;
        private System.Windows.Forms.Button PoistaBT;
    }
}

