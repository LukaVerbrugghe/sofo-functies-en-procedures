namespace prj05_ZelfgedefinieerdeFunctiesEnProcedures
{
    partial class frm01_KleurenMengen
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
            this.trbRed = new System.Windows.Forms.TrackBar();
            this.label = new System.Windows.Forms.Label();
            this.trbGroen = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trbBlue = new System.Windows.Forms.TrackBar();
            this.lblRGB = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trbRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbGroen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // trbRed
            // 
            this.trbRed.Location = new System.Drawing.Point(83, 12);
            this.trbRed.Maximum = 255;
            this.trbRed.Name = "trbRed";
            this.trbRed.Size = new System.Drawing.Size(565, 45);
            this.trbRed.TabIndex = 0;
            this.trbRed.Scroll += new System.EventHandler(this.trbRed_Scroll);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.White;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(12, 12);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(42, 20);
            this.label.TabIndex = 1;
            this.label.Text = "Red";
            // 
            // trbGroen
            // 
            this.trbGroen.Location = new System.Drawing.Point(83, 89);
            this.trbGroen.Maximum = 255;
            this.trbGroen.Name = "trbGroen";
            this.trbGroen.Size = new System.Drawing.Size(565, 45);
            this.trbGroen.TabIndex = 2;
            this.trbGroen.Scroll += new System.EventHandler(this.trbGroen_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Green";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Blue";
            // 
            // trbBlue
            // 
            this.trbBlue.Location = new System.Drawing.Point(83, 159);
            this.trbBlue.Maximum = 255;
            this.trbBlue.Name = "trbBlue";
            this.trbBlue.Size = new System.Drawing.Size(565, 45);
            this.trbBlue.TabIndex = 5;
            this.trbBlue.Scroll += new System.EventHandler(this.trbBlue_Scroll);
            // 
            // lblRGB
            // 
            this.lblRGB.AutoSize = true;
            this.lblRGB.BackColor = System.Drawing.Color.White;
            this.lblRGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRGB.Location = new System.Drawing.Point(12, 239);
            this.lblRGB.Name = "lblRGB";
            this.lblRGB.Size = new System.Drawing.Size(115, 20);
            this.lblRGB.TabIndex = 6;
            this.lblRGB.Text = "RGB (0, 0, 0)";
            // 
            // frm01_KleurenMengen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(698, 297);
            this.Controls.Add(this.lblRGB);
            this.Controls.Add(this.trbBlue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trbGroen);
            this.Controls.Add(this.label);
            this.Controls.Add(this.trbRed);
            this.Name = "frm01_KleurenMengen";
            this.Text = "Kleuren mengen";
            ((System.ComponentModel.ISupportInitialize)(this.trbRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbGroen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbBlue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trbRed;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TrackBar trbGroen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trbBlue;
        private System.Windows.Forms.Label lblRGB;
    }
}