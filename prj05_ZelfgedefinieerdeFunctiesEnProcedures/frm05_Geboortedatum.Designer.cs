namespace prj05_ZelfgedefinieerdeFunctiesEnProcedures
{
    partial class frm05_Geboortedatum
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
            this.txtGeboortedatum = new System.Windows.Forms.TextBox();
            this.btnLeeftijd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Geboortedatum (jjjj-mm-dd)";
            // 
            // txtGeboortedatum
            // 
            this.txtGeboortedatum.Location = new System.Drawing.Point(214, 61);
            this.txtGeboortedatum.Name = "txtGeboortedatum";
            this.txtGeboortedatum.Size = new System.Drawing.Size(100, 20);
            this.txtGeboortedatum.TabIndex = 1;
            // 
            // btnLeeftijd
            // 
            this.btnLeeftijd.Location = new System.Drawing.Point(143, 114);
            this.btnLeeftijd.Name = "btnLeeftijd";
            this.btnLeeftijd.Size = new System.Drawing.Size(125, 40);
            this.btnLeeftijd.TabIndex = 2;
            this.btnLeeftijd.Text = "Leeftijd?";
            this.btnLeeftijd.UseVisualStyleBackColor = true;
            this.btnLeeftijd.Click += new System.EventHandler(this.btnLeeftijd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Voer je leeftijd in en druk op de knop.";
            // 
            // frm05_Geboortedatum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(394, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLeeftijd);
            this.Controls.Add(this.txtGeboortedatum);
            this.Controls.Add(this.label1);
            this.Name = "frm05_Geboortedatum";
            this.Text = "Geboortedatum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGeboortedatum;
        private System.Windows.Forms.Button btnLeeftijd;
        private System.Windows.Forms.Label label2;
    }
}