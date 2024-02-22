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
    public partial class frm04_BankrekeningUitbreiding : Form {
        public frm04_BankrekeningUitbreiding() {
            InitializeComponent();

            //form gereed zetten
            txtBanknummerDeel2.Enabled = false;
            txtBanknummerVereficatie.Enabled = false;
        }

        private void txtBanknummerVereficatie_TextChanged(object sender, EventArgs e) {
            //eerst moet gecheckt worden of de textbox vol is
            if (txtBanknummerVereficatie.Text.Length == txtBanknummerVereficatie.MaxLength) {
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
            if (intEersteHokjes % 97 == intVerificatie) {
                return true;
            }
            else {
                return false;
            }
        }

        private void txtBanknummerDeel1_TextChanged(object sender, EventArgs e) {
            if (txtBanknummerDeel1.Text.Length == 3){
                txtBanknummerDeel2.Enabled = true;
                txtBanknummerDeel2.Focus();
            }
            else
            {
                txtBanknummerDeel2.Enabled = false;
            }
        }

        private void txtBanknummerDeel2_TextChanged(object sender, EventArgs e) {
            if (txtBanknummerDeel2.Text.Length == 7) {
                txtBanknummerVereficatie.Enabled = true;
                txtBanknummerVereficatie.Focus();
            }
            else {
                txtBanknummerVereficatie.Enabled = false;
            }
        }
    }
}
