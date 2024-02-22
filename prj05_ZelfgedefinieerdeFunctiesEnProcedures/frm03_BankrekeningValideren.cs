using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prj05_ZelfgedefinieerdeFunctiesEnProcedures {
    public partial class frm03_BankrekeningValideren : Form {
        public frm03_BankrekeningValideren() {
            InitializeComponent();
        }

        private void txtBanknummerVereficatie_TextChanged(object sender, EventArgs e) {
            //eerst moet gecheckt worden of de textbox vol is
            if (txtBanknummerVereficatie.Text.Length == txtBanknummerVereficatie.MaxLength)
            {
                bool isGeldig = isRest(voegWaardesToe(txtBanknummerDeel1.Text, txtBanknummerDeel2.Text), Convert.ToInt32(txtBanknummerVereficatie.Text));
                if (isGeldig) {
                    MessageBox.Show("Je gaf een geldige bankrekening in.");
                }
                else {
                    MessageBox.Show("Je gaf een ongeldige bankrekening in.");
                }
            }

        }

        private int voegWaardesToe(string strGetal1, string strGetal2) { 
            return Convert.ToInt32(strGetal1 + strGetal2);
        }

        private bool isRest(int intEersteHokjes, int intVerificatie) {
            if (intEersteHokjes % 97 == intVerificatie)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    
}
