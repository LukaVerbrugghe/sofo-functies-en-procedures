namespace prj05_ZelfgedefinieerdeFunctiesEnProcedures {
    partial class frm02_Cirkel {
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
            this.lblCirkel1 = new System.Windows.Forms.Label();
            this.lblCirkel2 = new System.Windows.Forms.Label();
            this.btnBereken = new System.Windows.Forms.Button();
            this.lblCirkel1Berekening = new System.Windows.Forms.Label();
            this.lblCirkel2Berekening = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCirkel1
            // 
            this.lblCirkel1.AutoSize = true;
            this.lblCirkel1.Location = new System.Drawing.Point(36, 32);
            this.lblCirkel1.Name = "lblCirkel1";
            this.lblCirkel1.Size = new System.Drawing.Size(35, 13);
            this.lblCirkel1.TabIndex = 0;
            this.lblCirkel1.Text = "label1";
            // 
            // lblCirkel2
            // 
            this.lblCirkel2.AutoSize = true;
            this.lblCirkel2.Location = new System.Drawing.Point(36, 58);
            this.lblCirkel2.Name = "lblCirkel2";
            this.lblCirkel2.Size = new System.Drawing.Size(35, 13);
            this.lblCirkel2.TabIndex = 1;
            this.lblCirkel2.Text = "label2";
            // 
            // btnBereken
            // 
            this.btnBereken.Location = new System.Drawing.Point(39, 121);
            this.btnBereken.Name = "btnBereken";
            this.btnBereken.Size = new System.Drawing.Size(75, 23);
            this.btnBereken.TabIndex = 2;
            this.btnBereken.Text = "Bereken";
            this.btnBereken.UseVisualStyleBackColor = true;
            this.btnBereken.Click += new System.EventHandler(this.btnBereken_Click);
            // 
            // lblCirkel1Berekening
            // 
            this.lblCirkel1Berekening.AutoSize = true;
            this.lblCirkel1Berekening.Location = new System.Drawing.Point(42, 204);
            this.lblCirkel1Berekening.Name = "lblCirkel1Berekening";
            this.lblCirkel1Berekening.Size = new System.Drawing.Size(35, 13);
            this.lblCirkel1Berekening.TabIndex = 3;
            this.lblCirkel1Berekening.Text = "label3";
            // 
            // lblCirkel2Berekening
            // 
            this.lblCirkel2Berekening.AutoSize = true;
            this.lblCirkel2Berekening.Location = new System.Drawing.Point(42, 236);
            this.lblCirkel2Berekening.Name = "lblCirkel2Berekening";
            this.lblCirkel2Berekening.Size = new System.Drawing.Size(35, 13);
            this.lblCirkel2Berekening.TabIndex = 5;
            this.lblCirkel2Berekening.Text = "label5";
            // 
            // frm02_Cirkel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCirkel2Berekening);
            this.Controls.Add(this.lblCirkel1Berekening);
            this.Controls.Add(this.btnBereken);
            this.Controls.Add(this.lblCirkel2);
            this.Controls.Add(this.lblCirkel1);
            this.Name = "frm02_Cirkel";
            this.Text = "Cirkel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCirkel1;
        private System.Windows.Forms.Label lblCirkel2;
        private System.Windows.Forms.Button btnBereken;
        private System.Windows.Forms.Label lblCirkel1Berekening;
        private System.Windows.Forms.Label lblCirkel2Berekening;
    }
}