
namespace Laskin
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LukuyksiTB = new System.Windows.Forms.TextBox();
            this.LukukaksiTB = new System.Windows.Forms.TextBox();
            this.LaskutoimitusCB = new System.Windows.Forms.ComboBox();
            this.VastausLB = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LaskeLB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LukuyksiTB
            // 
            this.LukuyksiTB.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LukuyksiTB.Location = new System.Drawing.Point(227, 108);
            this.LukuyksiTB.Name = "LukuyksiTB";
            this.LukuyksiTB.Size = new System.Drawing.Size(100, 35);
            this.LukuyksiTB.TabIndex = 0;
            // 
            // LukukaksiTB
            // 
            this.LukukaksiTB.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LukukaksiTB.Location = new System.Drawing.Point(376, 106);
            this.LukukaksiTB.Name = "LukukaksiTB";
            this.LukukaksiTB.Size = new System.Drawing.Size(100, 35);
            this.LukukaksiTB.TabIndex = 1;
            // 
            // LaskutoimitusCB
            // 
            this.LaskutoimitusCB.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LaskutoimitusCB.FormattingEnabled = true;
            this.LaskutoimitusCB.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.LaskutoimitusCB.Location = new System.Drawing.Point(333, 106);
            this.LaskutoimitusCB.Name = "LaskutoimitusCB";
            this.LaskutoimitusCB.Size = new System.Drawing.Size(37, 38);
            this.LaskutoimitusCB.TabIndex = 2;
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VastausLB.Location = new System.Drawing.Point(515, 111);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(25, 30);
            this.VastausLB.TabIndex = 3;
            this.VastausLB.Text = "X";
            this.VastausLB.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(482, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "=";
            // 
            // LaskeLB
            // 
            this.LaskeLB.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LaskeLB.Location = new System.Drawing.Point(627, 106);
            this.LaskeLB.Name = "LaskeLB";
            this.LaskeLB.Size = new System.Drawing.Size(108, 38);
            this.LaskeLB.TabIndex = 5;
            this.LaskeLB.Text = "Laske";
            this.LaskeLB.UseVisualStyleBackColor = true;
            this.LaskeLB.Click += new System.EventHandler(this.LaskeLB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 578);
            this.Controls.Add(this.LaskeLB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.LaskutoimitusCB);
            this.Controls.Add(this.LukukaksiTB);
            this.Controls.Add(this.LukuyksiTB);
            this.Name = "Form1";
            this.Text = "Yksinkertainen nelilaskin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LukuyksiTB;
        private System.Windows.Forms.TextBox LukukaksiTB;
        private System.Windows.Forms.ComboBox LaskutoimitusCB;
        private System.Windows.Forms.Label VastausLB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LaskeLB;
    }
}

