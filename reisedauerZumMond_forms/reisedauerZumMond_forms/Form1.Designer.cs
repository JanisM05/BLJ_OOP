namespace reisedauerZumMond_forms
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
            this.rb_days = new System.Windows.Forms.RadioButton();
            this.rd_hours = new System.Windows.Forms.RadioButton();
            this.txt_speed = new System.Windows.Forms.TextBox();
            this.lbl_geschw = new System.Windows.Forms.Label();
            this.lbl_ergebnis = new System.Windows.Forms.Label();
            this.lbl_einheit = new System.Windows.Forms.Label();
            this.btn_berechnen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rb_days
            // 
            this.rb_days.AutoSize = true;
            this.rb_days.Location = new System.Drawing.Point(48, 12);
            this.rb_days.Name = "rb_days";
            this.rb_days.Size = new System.Drawing.Size(68, 17);
            this.rb_days.TabIndex = 0;
            this.rb_days.TabStop = true;
            this.rb_days.Text = "In Tagen";
            this.rb_days.UseVisualStyleBackColor = true;
            // 
            // rd_hours
            // 
            this.rd_hours.AutoSize = true;
            this.rd_hours.Location = new System.Drawing.Point(170, 12);
            this.rd_hours.Name = "rd_hours";
            this.rd_hours.Size = new System.Drawing.Size(77, 17);
            this.rd_hours.TabIndex = 1;
            this.rd_hours.TabStop = true;
            this.rd_hours.Text = "In Stunden";
            this.rd_hours.UseVisualStyleBackColor = true;
            // 
            // txt_speed
            // 
            this.txt_speed.Location = new System.Drawing.Point(170, 51);
            this.txt_speed.Name = "txt_speed";
            this.txt_speed.Size = new System.Drawing.Size(100, 20);
            this.txt_speed.TabIndex = 2;
            // 
            // lbl_geschw
            // 
            this.lbl_geschw.AutoSize = true;
            this.lbl_geschw.Location = new System.Drawing.Point(48, 54);
            this.lbl_geschw.Name = "lbl_geschw";
            this.lbl_geschw.Size = new System.Drawing.Size(119, 13);
            this.lbl_geschw.TabIndex = 3;
            this.lbl_geschw.Text = "Geschwindigkeit (km/h)";
            // 
            // lbl_ergebnis
            // 
            this.lbl_ergebnis.AutoSize = true;
            this.lbl_ergebnis.Location = new System.Drawing.Point(48, 157);
            this.lbl_ergebnis.Name = "lbl_ergebnis";
            this.lbl_ergebnis.Size = new System.Drawing.Size(0, 13);
            this.lbl_ergebnis.TabIndex = 4;
            // 
            // lbl_einheit
            // 
            this.lbl_einheit.AutoSize = true;
            this.lbl_einheit.Location = new System.Drawing.Point(183, 157);
            this.lbl_einheit.Name = "lbl_einheit";
            this.lbl_einheit.Size = new System.Drawing.Size(0, 13);
            this.lbl_einheit.TabIndex = 5;
            // 
            // btn_berechnen
            // 
            this.btn_berechnen.Location = new System.Drawing.Point(124, 103);
            this.btn_berechnen.Name = "btn_berechnen";
            this.btn_berechnen.Size = new System.Drawing.Size(75, 23);
            this.btn_berechnen.TabIndex = 6;
            this.btn_berechnen.Text = "Berechnen";
            this.btn_berechnen.UseVisualStyleBackColor = true;
            this.btn_berechnen.Click += new System.EventHandler(this.btn_berechnen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 207);
            this.Controls.Add(this.btn_berechnen);
            this.Controls.Add(this.lbl_einheit);
            this.Controls.Add(this.lbl_ergebnis);
            this.Controls.Add(this.lbl_geschw);
            this.Controls.Add(this.txt_speed);
            this.Controls.Add(this.rd_hours);
            this.Controls.Add(this.rb_days);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rb_days;
        private System.Windows.Forms.RadioButton rd_hours;
        private System.Windows.Forms.TextBox txt_speed;
        private System.Windows.Forms.Label lbl_geschw;
        private System.Windows.Forms.Label lbl_ergebnis;
        private System.Windows.Forms.Label lbl_einheit;
        private System.Windows.Forms.Button btn_berechnen;
    }
}

