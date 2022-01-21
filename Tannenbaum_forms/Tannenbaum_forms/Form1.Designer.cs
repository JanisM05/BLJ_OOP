namespace Tannenbaum_forms
{
    partial class txt_tannenbaum
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
            this.txt_stammbreite = new System.Windows.Forms.TextBox();
            this.txt_stammhoehe = new System.Windows.Forms.TextBox();
            this.txt_kronenhoehe = new System.Windows.Forms.TextBox();
            this.lbl_stammbreite = new System.Windows.Forms.Label();
            this.lbl_stammhoehe = new System.Windows.Forms.Label();
            this.lbl_kronenhoehe = new System.Windows.Forms.Label();
            this.btn_zeichnen = new System.Windows.Forms.Button();
            this.txt_finished = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txt_stammbreite
            // 
            this.txt_stammbreite.Location = new System.Drawing.Point(156, 45);
            this.txt_stammbreite.Name = "txt_stammbreite";
            this.txt_stammbreite.Size = new System.Drawing.Size(100, 20);
            this.txt_stammbreite.TabIndex = 0;
            // 
            // txt_stammhoehe
            // 
            this.txt_stammhoehe.Location = new System.Drawing.Point(156, 106);
            this.txt_stammhoehe.Name = "txt_stammhoehe";
            this.txt_stammhoehe.Size = new System.Drawing.Size(100, 20);
            this.txt_stammhoehe.TabIndex = 1;
            // 
            // txt_kronenhoehe
            // 
            this.txt_kronenhoehe.Location = new System.Drawing.Point(156, 165);
            this.txt_kronenhoehe.Name = "txt_kronenhoehe";
            this.txt_kronenhoehe.Size = new System.Drawing.Size(100, 20);
            this.txt_kronenhoehe.TabIndex = 2;
            // 
            // lbl_stammbreite
            // 
            this.lbl_stammbreite.AutoSize = true;
            this.lbl_stammbreite.Location = new System.Drawing.Point(67, 51);
            this.lbl_stammbreite.Name = "lbl_stammbreite";
            this.lbl_stammbreite.Size = new System.Drawing.Size(68, 13);
            this.lbl_stammbreite.TabIndex = 3;
            this.lbl_stammbreite.Text = "Stammbreite:";
            // 
            // lbl_stammhoehe
            // 
            this.lbl_stammhoehe.AutoSize = true;
            this.lbl_stammhoehe.Location = new System.Drawing.Point(70, 106);
            this.lbl_stammhoehe.Name = "lbl_stammhoehe";
            this.lbl_stammhoehe.Size = new System.Drawing.Size(66, 13);
            this.lbl_stammhoehe.TabIndex = 4;
            this.lbl_stammhoehe.Text = "Stammhöhe:";
            // 
            // lbl_kronenhoehe
            // 
            this.lbl_kronenhoehe.AutoSize = true;
            this.lbl_kronenhoehe.Location = new System.Drawing.Point(70, 165);
            this.lbl_kronenhoehe.Name = "lbl_kronenhoehe";
            this.lbl_kronenhoehe.Size = new System.Drawing.Size(68, 13);
            this.lbl_kronenhoehe.TabIndex = 5;
            this.lbl_kronenhoehe.Text = "Kronenhöhe:";
            // 
            // btn_zeichnen
            // 
            this.btn_zeichnen.Location = new System.Drawing.Point(329, 165);
            this.btn_zeichnen.Name = "btn_zeichnen";
            this.btn_zeichnen.Size = new System.Drawing.Size(75, 24);
            this.btn_zeichnen.TabIndex = 6;
            this.btn_zeichnen.Text = "ZEICHNEN";
            this.btn_zeichnen.UseVisualStyleBackColor = true;
            this.btn_zeichnen.Click += new System.EventHandler(this.btn_zeichnen_Click);
            // 
            // txt_finished
            // 
            this.txt_finished.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_finished.Location = new System.Drawing.Point(6, 241);
            this.txt_finished.Name = "txt_finished";
            this.txt_finished.Size = new System.Drawing.Size(489, 411);
            this.txt_finished.TabIndex = 7;
            this.txt_finished.Text = "";
            // 
            // txt_tannenbaum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 664);
            this.Controls.Add(this.txt_finished);
            this.Controls.Add(this.btn_zeichnen);
            this.Controls.Add(this.lbl_kronenhoehe);
            this.Controls.Add(this.lbl_stammhoehe);
            this.Controls.Add(this.lbl_stammbreite);
            this.Controls.Add(this.txt_kronenhoehe);
            this.Controls.Add(this.txt_stammhoehe);
            this.Controls.Add(this.txt_stammbreite);
            this.Name = "txt_tannenbaum";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.txt_tannenbaum_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_stammbreite;
        private System.Windows.Forms.TextBox txt_stammhoehe;
        private System.Windows.Forms.TextBox txt_kronenhoehe;
        private System.Windows.Forms.Label lbl_stammbreite;
        private System.Windows.Forms.Label lbl_stammhoehe;
        private System.Windows.Forms.Label lbl_kronenhoehe;
        private System.Windows.Forms.Button btn_zeichnen;
        private System.Windows.Forms.RichTextBox txt_finished;
    }
}

