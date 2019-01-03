namespace Loesung_eines_Gleichungssystems
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_lgs1_a = new System.Windows.Forms.TextBox();
            this.tb_lgs2_a = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_lgs1_b = new System.Windows.Forms.TextBox();
            this.tb_lgs2_b = new System.Windows.Forms.TextBox();
            this.tb_lgs1_rs = new System.Windows.Forms.TextBox();
            this.tb_lgs2_rs = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label_loesung1 = new System.Windows.Forms.Label();
            this.label_loesung2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label_loesung_a = new System.Windows.Forms.Label();
            this.label_loesung_b = new System.Windows.Forms.Label();
            this.label_meldung = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(440, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Das Programm löst ein euzugebendes LGS mit 2 Gleichungen und 2 Unbekannten (a und" +
    " b)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "der folgenden Form unter Einsatz der Determinantenrechnung:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gleichung 1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gleichung 2:";
            // 
            // tb_lgs1_a
            // 
            this.tb_lgs1_a.Location = new System.Drawing.Point(102, 86);
            this.tb_lgs1_a.Name = "tb_lgs1_a";
            this.tb_lgs1_a.Size = new System.Drawing.Size(58, 20);
            this.tb_lgs1_a.TabIndex = 4;
            this.tb_lgs1_a.Text = "2";
            this.tb_lgs1_a.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_lgs2_a
            // 
            this.tb_lgs2_a.Location = new System.Drawing.Point(102, 138);
            this.tb_lgs2_a.Name = "tb_lgs2_a";
            this.tb_lgs2_a.Size = new System.Drawing.Size(58, 20);
            this.tb_lgs2_a.TabIndex = 5;
            this.tb_lgs2_a.Text = "-3";
            this.tb_lgs2_a.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(166, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "* a + ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(175, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "* a + ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(296, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "* b =";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(296, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "* b =";
            // 
            // tb_lgs1_b
            // 
            this.tb_lgs1_b.Location = new System.Drawing.Point(226, 86);
            this.tb_lgs1_b.Name = "tb_lgs1_b";
            this.tb_lgs1_b.Size = new System.Drawing.Size(58, 20);
            this.tb_lgs1_b.TabIndex = 10;
            this.tb_lgs1_b.Text = "-7";
            this.tb_lgs1_b.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_lgs2_b
            // 
            this.tb_lgs2_b.Location = new System.Drawing.Point(226, 142);
            this.tb_lgs2_b.Name = "tb_lgs2_b";
            this.tb_lgs2_b.Size = new System.Drawing.Size(58, 20);
            this.tb_lgs2_b.TabIndex = 11;
            this.tb_lgs2_b.Text = "4";
            this.tb_lgs2_b.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_lgs1_rs
            // 
            this.tb_lgs1_rs.Location = new System.Drawing.Point(357, 86);
            this.tb_lgs1_rs.Name = "tb_lgs1_rs";
            this.tb_lgs1_rs.Size = new System.Drawing.Size(58, 20);
            this.tb_lgs1_rs.TabIndex = 12;
            this.tb_lgs1_rs.Text = "20";
            this.tb_lgs1_rs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_lgs2_rs
            // 
            this.tb_lgs2_rs.Location = new System.Drawing.Point(357, 142);
            this.tb_lgs2_rs.Name = "tb_lgs2_rs";
            this.tb_lgs2_rs.Size = new System.Drawing.Size(58, 20);
            this.tb_lgs2_rs.TabIndex = 13;
            this.tb_lgs2_rs.Text = "-17";
            this.tb_lgs2_rs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(357, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 40);
            this.button1.TabIndex = 14;
            this.button1.Text = "KALKULIEREN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_loesung1
            // 
            this.label_loesung1.AutoSize = true;
            this.label_loesung1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_loesung1.Location = new System.Drawing.Point(13, 204);
            this.label_loesung1.Name = "label_loesung1";
            this.label_loesung1.Size = new System.Drawing.Size(73, 16);
            this.label_loesung1.TabIndex = 15;
            this.label_loesung1.Text = "Lösung a =";
            // 
            // label_loesung2
            // 
            this.label_loesung2.AutoSize = true;
            this.label_loesung2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_loesung2.Location = new System.Drawing.Point(13, 232);
            this.label_loesung2.Name = "label_loesung2";
            this.label_loesung2.Size = new System.Drawing.Size(73, 16);
            this.label_loesung2.TabIndex = 16;
            this.label_loesung2.Text = "Lösung b =";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(357, 232);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 29);
            this.button2.TabIndex = 17;
            this.button2.Text = "CLEAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label_loesung_a
            // 
            this.label_loesung_a.AutoSize = true;
            this.label_loesung_a.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_loesung_a.Location = new System.Drawing.Point(99, 204);
            this.label_loesung_a.Name = "label_loesung_a";
            this.label_loesung_a.Size = new System.Drawing.Size(15, 16);
            this.label_loesung_a.TabIndex = 18;
            this.label_loesung_a.Text = "3";
            this.label_loesung_a.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_loesung_b
            // 
            this.label_loesung_b.AutoSize = true;
            this.label_loesung_b.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_loesung_b.Location = new System.Drawing.Point(99, 232);
            this.label_loesung_b.Name = "label_loesung_b";
            this.label_loesung_b.Size = new System.Drawing.Size(19, 16);
            this.label_loesung_b.TabIndex = 19;
            this.label_loesung_b.Text = "-2";
            this.label_loesung_b.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_meldung
            // 
            this.label_meldung.AutoSize = true;
            this.label_meldung.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_meldung.ForeColor = System.Drawing.Color.Red;
            this.label_meldung.Location = new System.Drawing.Point(103, 216);
            this.label_meldung.Name = "label_meldung";
            this.label_meldung.Size = new System.Drawing.Size(0, 16);
            this.label_meldung.TabIndex = 20;
            this.label_meldung.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(204, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "Komma bitte mit , schreiben";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 273);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label_meldung);
            this.Controls.Add(this.label_loesung_b);
            this.Controls.Add(this.label_loesung_a);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label_loesung2);
            this.Controls.Add(this.label_loesung1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_lgs2_rs);
            this.Controls.Add(this.tb_lgs1_rs);
            this.Controls.Add(this.tb_lgs2_b);
            this.Controls.Add(this.tb_lgs1_b);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_lgs2_a);
            this.Controls.Add(this.tb_lgs1_a);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lösung eines Gleichungssystems";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_lgs1_a;
        private System.Windows.Forms.TextBox tb_lgs2_a;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_lgs1_b;
        private System.Windows.Forms.TextBox tb_lgs2_b;
        private System.Windows.Forms.TextBox tb_lgs1_rs;
        private System.Windows.Forms.TextBox tb_lgs2_rs;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_loesung1;
        private System.Windows.Forms.Label label_loesung2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label_loesung_a;
        private System.Windows.Forms.Label label_loesung_b;
        private System.Windows.Forms.Label label_meldung;
        private System.Windows.Forms.Label label9;
    }
}

