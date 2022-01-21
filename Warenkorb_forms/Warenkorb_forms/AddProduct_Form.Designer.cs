namespace Warenkorb_forms
{
    partial class AddProduct_Form
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
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txt_productName = new System.Windows.Forms.Label();
            this.lbl_quantity = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_gotoShoppingCart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_quantity
            // 
            this.txt_quantity.Location = new System.Drawing.Point(122, 60);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(100, 20);
            this.txt_quantity.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(122, 22);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // txt_productName
            // 
            this.txt_productName.AutoSize = true;
            this.txt_productName.Location = new System.Drawing.Point(42, 29);
            this.txt_productName.Name = "txt_productName";
            this.txt_productName.Size = new System.Drawing.Size(73, 13);
            this.txt_productName.TabIndex = 2;
            this.txt_productName.Text = "Produktname:";
            // 
            // lbl_quantity
            // 
            this.lbl_quantity.AutoSize = true;
            this.lbl_quantity.Location = new System.Drawing.Point(45, 66);
            this.lbl_quantity.Name = "lbl_quantity";
            this.lbl_quantity.Size = new System.Drawing.Size(42, 13);
            this.lbl_quantity.TabIndex = 3;
            this.lbl_quantity.Text = "Anzahl:";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(122, 117);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(100, 23);
            this.btn_add.TabIndex = 4;
            this.btn_add.Text = "HINZUFÜGEN";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_gotoShoppingCart
            // 
            this.btn_gotoShoppingCart.Location = new System.Drawing.Point(122, 160);
            this.btn_gotoShoppingCart.Name = "btn_gotoShoppingCart";
            this.btn_gotoShoppingCart.Size = new System.Drawing.Size(100, 23);
            this.btn_gotoShoppingCart.TabIndex = 5;
            this.btn_gotoShoppingCart.Text = "Zum Warenkorb";
            this.btn_gotoShoppingCart.UseVisualStyleBackColor = true;
            this.btn_gotoShoppingCart.Click += new System.EventHandler(this.btn_gotoShoppingCart_Click);
            // 
            // AddProduct_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 206);
            this.Controls.Add(this.btn_gotoShoppingCart);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lbl_quantity);
            this.Controls.Add(this.txt_productName);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txt_quantity);
            this.Name = "AddProduct_Form";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label txt_productName;
        private System.Windows.Forms.Label lbl_quantity;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_gotoShoppingCart;
    }
}

