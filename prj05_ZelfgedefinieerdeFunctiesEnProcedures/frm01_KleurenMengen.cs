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
    public partial class frm01_KleurenMengen : Form
    {
        public frm01_KleurenMengen()
        {
            InitializeComponent();
        }

        private void trbRed_Scroll(object sender, EventArgs e)
        {
            ChangeBackgroundColor(trbRed.Value, trbGroen.Value, trbBlue.Value);
        }

        private void trbGroen_Scroll(object sender, EventArgs e)
        {
            ChangeBackgroundColor(trbRed.Value, trbGroen.Value, trbBlue.Value);
        }
        private void trbBlue_Scroll(object sender, EventArgs e)
        {
            ChangeBackgroundColor(trbRed.Value, trbGroen.Value, trbBlue.Value);
        }
        private void ChangeBackgroundColor(int intRed, int intGreen, int intBlue)
        {
            this.BackColor = Color.FromArgb(intRed, intGreen, intBlue);
            lblRGB.Text = "RGB (" + intRed.ToString() + ", " + intGreen.ToString() + ", " + intBlue.ToString() + ")";
        }

    }
}
