namespace prj05_ZelfgedefinieerdeFunctiesEnProcedures {
    partial class frm03_BankrekeningValideren {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.txtBanknummerDeel1 = new System.Windows.Forms.TextBox();
            this.txtBanknummerVereficatie = new System.Windows.Forms.TextBox();
            this.txtBanknummerDeel2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bankrekeningsnummer";
            // 
            // txtBanknummerDeel1
            // 
            this.txtBanknummerDeel1.Location = new System.Drawing.Point(151, 54);
            this.txtBanknummerDeel1.MaxLength = 3;
            this.txtBanknummerDeel1.Name = "txtBanknummerDeel1";
            this.txtBanknummerDeel1.Size = new System.Drawing.Size(62, 20);
            this.txtBanknummerDeel1.TabIndex = 1;
            // 
            // txtBanknummerVereficatie
            // 
            this.txtBanknummerVereficatie.Location = new System.Drawing.Point(323, 54);
            this.txtBanknummerVereficatie.MaxLength = 2;
            this.txtBanknummerVereficatie.Name = "txtBanknummerVereficatie";
            this.txtBanknummerVereficatie.Size = new System.Drawing.Size(62, 20);
            this.txtBanknummerVereficatie.TabIndex = 3;
            this.txtBanknummerVereficatie.TextChanged += new System.EventHandler(this.txtBanknummerVereficatie_TextChanged);
            // 
            // txtBanknummerDeel2
            // 
            this.txtBanknummerDeel2.Location = new System.Drawing.Point(219, 54);
            this.txtBanknummerDeel2.MaxLength = 7;
            this.txtBanknummerDeel2.Name = "txtBanknummerDeel2";
            this.txtBanknummerDeel2.Size = new System.Drawing.Size(98, 20);
            this.txtBanknummerDeel2.TabIndex = 2;
            // 
            // frm03_BankrekeningValideren
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(504, 135);
            this.Controls.Add(this.txtBanknummerDeel2);
            this.Controls.Add(this.txtBanknummerVereficatie);
            this.Controls.Add(this.txtBanknummerDeel1);
            this.Controls.Add(this.label1);
            this.Name = "frm03_BankrekeningValideren";
            this.Text = "Bankrekening Valideren";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBanknummerDeel1;
        private System.Windows.Forms.TextBox txtBanknummerVereficatie;
        private System.Windows.Forms.TextBox txtBanknummerDeel2;
    }
}