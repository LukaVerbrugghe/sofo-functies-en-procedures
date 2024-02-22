using Microsoft.VisualBasic;
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
    public partial class frm02_Cirkel : Form {

        //var
        double dblStraalCirkel1, dblStraalCirkel2;

        public frm02_Cirkel() {
            InitializeComponent();

            //straal van de cirkels opvragen
            dblStraalCirkel1 = Convert.ToDouble(Interaction.InputBox("Geef de straal in van cirkel 1."));
            dblStraalCirkel2 = Convert.ToDouble(Interaction.InputBox("Geef de straal in van cirkel 2."));

            //labels instellen
            lblCirkel1.Text = "Cirkel 1 heeft een straal van " + dblStraalCirkel1 + " cm.";
            lblCirkel2.Text = "Cirkel 2 heeft een straal van " + dblStraalCirkel2 + " cm.";

            lblCirkel1Berekening.Text = "";
            lblCirkel2Berekening.Text = "";
        }

        private void btnBereken_Click(object sender, EventArgs e) {
            //functies oproepen en weergeven in labels
            lblCirkel1Berekening.Text = "De omtrek van cirkel 1 is " + Convert.ToString(BerekenOmtrek(dblStraalCirkel1)) + " cm.\nDe oppervlakte van cirkel 1 is " + Convert.ToString(BerekenOppervlakte(dblStraalCirkel1)) + " cm.";
            lblCirkel2Berekening.Text = "De omtrek van cirkel 2 is " + Convert.ToString(BerekenOmtrek(dblStraalCirkel2)) + " cm.\nDe oppervlakte van cirkel 2 is " + Convert.ToString(BerekenOppervlakte(dblStraalCirkel1)) + " cm.";
        }

        private double BerekenOmtrek(double dblStraal) {
            return Math.Round(dblStraal * 2 * Math.PI, 2);
        }

        private double BerekenOppervlakte(double dblStraal) {
            return Math.Round(dblStraal * dblStraal * Math.PI, 2);
        }
    }
}
