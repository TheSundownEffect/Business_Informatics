namespace Zufall
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
            this.button1 = new System.Windows.Forms.Button();
            this.tb_matrix = new System.Windows.Forms.TextBox();
            this.tb_result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(15, 447);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(453, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "MATRIX";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_matrix
            // 
            this.tb_matrix.BackColor = System.Drawing.SystemColors.WindowText;
            this.tb_matrix.ForeColor = System.Drawing.Color.Chartreuse;
            this.tb_matrix.Location = new System.Drawing.Point(15, 13);
            this.tb_matrix.Multiline = true;
            this.tb_matrix.Name = "tb_matrix";
            this.tb_matrix.Size = new System.Drawing.Size(453, 271);
            this.tb_matrix.TabIndex = 2;
            // 
            // tb_result
            // 
            this.tb_result.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tb_result.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tb_result.Location = new System.Drawing.Point(15, 302);
            this.tb_result.Multiline = true;
            this.tb_result.Name = "tb_result";
            this.tb_result.Size = new System.Drawing.Size(453, 129);
            this.tb_result.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 498);
            this.Controls.Add(this.tb_result);
            this.Controls.Add(this.tb_matrix);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zufall";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_matrix;
        private System.Windows.Forms.TextBox tb_result;
    }
}

