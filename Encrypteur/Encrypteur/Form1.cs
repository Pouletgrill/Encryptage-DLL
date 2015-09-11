using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encrypteur
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RB_All_Click(object sender, EventArgs e)
        {
            Refresh_Button();
        }

        private void Refresh_Button()
        {
            if (RB_Rotation.Checked)
            {
                NUD_Rotation.Enabled = true;
                NUD_Circulaire.Enabled = false;
            }
            else if (RB_Circulaire.Checked)
            {
                NUD_Rotation.Enabled = false;
                NUD_Circulaire.Enabled = true;
            }
            else
            {
                NUD_Rotation.Enabled = false;
                NUD_Circulaire.Enabled = false;
            }
        }
    }
}
