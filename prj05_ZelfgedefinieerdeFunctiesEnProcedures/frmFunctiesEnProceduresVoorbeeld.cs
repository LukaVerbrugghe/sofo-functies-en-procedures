using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace prj05_ZelfgedefinieerdeFunctiesEnProcedures
{
    public partial class frmFunctiesEnProceduresVoorbeeld : Form
    {
        public frmFunctiesEnProceduresVoorbeeld()
        {
            InitializeComponent();
        }

        private void btnWelkom1_Click(object sender, EventArgs e)
        {
            //functie voor eerste procedure oproepen
            EersteProcedure();
        }

        private void btnWelkom2_Click(object sender, EventArgs e)
        {
            //functie oproepen voor meerdere namen
            HalloZeggen("Jens");
            HalloZeggen("Willem");
            HalloZeggen("Nathan");
            HalloZeggen("Lieven");
        }

        private void btnWelkom3_Click(object sender, EventArgs e)
        {
            //functie oproepen met de naam van de gebruiker
            string strIngegevenNaam = Interaction.InputBox("Geef je naam in.");
            HalloZeggen(strIngegevenNaam);
        }

        private void btnBerekenen_Click(object sender, EventArgs e)
        {
            //functie oproepen die 2 getallen samentelt
            int intGetal1 = Convert.ToInt16(Interaction.InputBox("Gelieve een getal in te geven."));
            int intGetal2 = Convert.ToInt16(Interaction.InputBox("Gelieve een getal in te geven."));
            Optellen(intGetal1, intGetal2);
        }

        private void btnKwadraat_Click(object sender, EventArgs e)
        {
            //functie oproepen die een getal kwadrateert
            //invoer ophalen
            Kwadrateer(Convert.ToInt16(txtGetal.Text));
        }




        //eigen functies
        private void EersteProcedure()
        {
            //messagebox weergeven
            MessageBox.Show("Dit is een eerste procedure.", "Boodschap");
        }

        private void HalloZeggen(string strNaam)
        {
            MessageBox.Show("Hallo " + strNaam);
        }

        private void Optellen(int intGetal1, int intGetal2)
        {
            int intSom = intGetal1 + intGetal2;
            MessageBox.Show("De som van de ingegeven getallen " + intGetal1.ToString() + " en " + intGetal2.ToString() + " is: " + intSom.ToString() + ".", "Som");
        }

        private void Kwadrateer(int intGetal)
        {
            intGetal = intGetal * intGetal;
            label3.Text = intGetal.ToString();
        }
    }
}
