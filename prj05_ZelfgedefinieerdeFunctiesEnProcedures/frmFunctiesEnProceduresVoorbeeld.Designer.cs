namespace prj05_ZelfgedefinieerdeFunctiesEnProcedures
{
    partial class frmFunctiesEnProceduresVoorbeeld
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
            this.btnWelkom1 = new System.Windows.Forms.Button();
            this.btnWelkom2 = new System.Windows.Forms.Button();
            this.btnWelkom3 = new System.Windows.Forms.Button();
            this.btnBerekenen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGetal = new System.Windows.Forms.TextBox();
            this.btnKwadraat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnWelkom1
            // 
            this.btnWelkom1.Location = new System.Drawing.Point(43, 34);
            this.btnWelkom1.Name = "btnWelkom1";
            this.btnWelkom1.Size = new System.Drawing.Size(109, 23);
            this.btnWelkom1.TabIndex = 0;
            this.btnWelkom1.Text = "Welkom 1";
            this.btnWelkom1.UseVisualStyleBackColor = true;
            this.btnWelkom1.Click += new System.EventHandler(this.btnWelkom1_Click);
            // 
            // btnWelkom2
            // 
            this.btnWelkom2.Location = new System.Drawing.Point(43, 63);
            this.btnWelkom2.Name = "btnWelkom2";
            this.btnWelkom2.Size = new System.Drawing.Size(109, 23);
            this.btnWelkom2.TabIndex = 1;
            this.btnWelkom2.Text = "Welkom 2";
            this.btnWelkom2.UseVisualStyleBackColor = true;
            this.btnWelkom2.Click += new System.EventHandler(this.btnWelkom2_Click);
            // 
            // btnWelkom3
            // 
            this.btnWelkom3.Location = new System.Drawing.Point(43, 92);
            this.btnWelkom3.Name = "btnWelkom3";
            this.btnWelkom3.Size = new System.Drawing.Size(109, 23);
            this.btnWelkom3.TabIndex = 2;
            this.btnWelkom3.Text = "Welkom 3";
            this.btnWelkom3.UseVisualStyleBackColor = true;
            this.btnWelkom3.Click += new System.EventHandler(this.btnWelkom3_Click);
            // 
            // btnBerekenen
            // 
            this.btnBerekenen.Location = new System.Drawing.Point(43, 121);
            this.btnBerekenen.Name = "btnBerekenen";
            this.btnBerekenen.Size = new System.Drawing.Size(109, 23);
            this.btnBerekenen.TabIndex = 3;
            this.btnBerekenen.Text = "Berekenen";
            this.btnBerekenen.UseVisualStyleBackColor = true;
            this.btnBerekenen.Click += new System.EventHandler(this.btnBerekenen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kwadraat berekenen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Getal";
            // 
            // txtGetal
            // 
            this.txtGetal.Location = new System.Drawing.Point(253, 78);
            this.txtGetal.Name = "txtGetal";
            this.txtGetal.Size = new System.Drawing.Size(100, 20);
            this.txtGetal.TabIndex = 6;
            // 
            // btnKwadraat
            // 
            this.btnKwadraat.Location = new System.Drawing.Point(218, 121);
            this.btnKwadraat.Name = "btnKwadraat";
            this.btnKwadraat.Size = new System.Drawing.Size(75, 23);
            this.btnKwadraat.TabIndex = 7;
            this.btnKwadraat.Text = "Kwadraat";
            this.btnKwadraat.UseVisualStyleBackColor = true;
            this.btnKwadraat.Click += new System.EventHandler(this.btnKwadraat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "label3";
            // 
            // frmFunctiesEnProceduresVoorbeeld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 222);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnKwadraat);
            this.Controls.Add(this.txtGetal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBerekenen);
            this.Controls.Add(this.btnWelkom3);
            this.Controls.Add(this.btnWelkom2);
            this.Controls.Add(this.btnWelkom1);
            this.Name = "frmFunctiesEnProceduresVoorbeeld";
            this.Text = "Voorbeeld";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWelkom1;
        private System.Windows.Forms.Button btnWelkom2;
        private System.Windows.Forms.Button btnWelkom3;
        private System.Windows.Forms.Button btnBerekenen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGetal;
        private System.Windows.Forms.Button btnKwadraat;
        private System.Windows.Forms.Label label3;
    }
}

