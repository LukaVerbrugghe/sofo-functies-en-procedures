using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prj05_ZelfgedefinieerdeFunctiesEnProcedures
{
    public partial class frm05_Geboortedatum : Form
    {
        public frm05_Geboortedatum()
        {
            InitializeComponent();
        }

        private void btnLeeftijd_Click(object sender, EventArgs e)
        {
            //datum opvangen
            DateTime dteGeboortedatum = Convert.ToDateTime(txtGeboortedatum.Text);

            //checken hoeveel jaar er verschil is met vandaag
            TimeSpan tmsVerschil = DateTime.Today.Subtract(dteGeboortedatum);
            int intLeeftijd = tmsVerschil.Days / 363;
            label2.Text = "Je bent " + intLeeftijd.ToString() + " jaar oud.";
        }
    }
}
