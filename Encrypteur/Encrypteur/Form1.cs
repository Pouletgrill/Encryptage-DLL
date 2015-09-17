using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DLLEncrypt;
using System.IO;

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
            //Radio Button
            if (RB_Rotation.Checked)
            {
                NUD_Rotation.Enabled = true;
                NUD_Circulaire.Enabled = false;
            }
            else if (RB_Circulaire.Checked)
            {
                NUD_Rotation.Enabled = false;
                NUD_Circulaire.Enabled = true;
                NUD_Circulaire.Maximum = TB_Text.Text.Length;
            }
            else
            {
                NUD_Rotation.Enabled = false;
                NUD_Circulaire.Enabled = false;
            }

            //Textbox
            if (TB_Text.TextLength <= 0)
            {
                BTN_Decrypter.Enabled = false;
                BTN_Encrypter.Enabled = false;
            }
            else
            {
                BTN_Decrypter.Enabled = true;
                BTN_Encrypter.Enabled = true;
            }
        }

        private void TB_Text_TextChanged(object sender, EventArgs e)
        {
            Refresh_Button();
            NUD_Circulaire.Maximum = TB_Text.Text.Length;
        }

        private void BTN_Encrypter_Click(object sender, EventArgs e)
        {
            if (RB_Rotation.Checked)
            {
                TB_Text.Text = Rotation_dll.Encrypter(TB_Text.Text, Convert.ToInt32(NUD_Rotation.Value));
            }
            else if (RB_Circulaire.Checked)
            {
                TB_Text.Text = Circulaire_dll.Encrypter(TB_Text.Text, Convert.ToInt32(NUD_Circulaire.Value));
            }
            else
            {
                TB_Text.Text = Autre_dll.Encrypter(TB_Text.Text);
            }
            
        }

        private void BTN_Decrypter_Click(object sender, EventArgs e)
        {
            if (RB_Rotation.Checked)
            {
                TB_Text.Text = Rotation_dll.Decrypter(TB_Text.Text, Convert.ToInt32(NUD_Rotation.Value));
            }
            else if (RB_Circulaire.Checked)
            {
                TB_Text.Text = Circulaire_dll.Decrypter(TB_Text.Text, Convert.ToInt32(NUD_Circulaire.Value));
            }
            else
            {
                TB_Text.Text = Autre_dll.Decrypter(TB_Text.Text);
            }
        }

        private void BTN_Save_Click(object sender, EventArgs e)
        {
            if (SFD_Save.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(SFD_Save.FileName, TB_Text.Text);
            }
        }

        private void BTN_Load_Click(object sender, EventArgs e)
        {
            if(OFD_Open.ShowDialog() == DialogResult.OK)
            {
                TB_Text.Text = File.ReadAllText(OFD_Open.FileName);
            }
        }
    }
}
