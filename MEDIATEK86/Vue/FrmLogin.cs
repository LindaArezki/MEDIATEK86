using System;
using MEDIATEK86.controleur;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEDIATEK86.Vue
{
    public partial class FrmLogin : Form
    {
        private Controle controle;
        /// <summary>
        /// Ouverture de la frmlogin
        /// </summary>
        public FrmLogin(Controle controle)
        {
            InitializeComponent();
            this.controle = controle;
        }



        private void btnConnecter1_Click(object sender, EventArgs e)
        {
            if (!textBoxID.Text.Equals("") && !textBoxMDP.Text.Equals(""))
            {
                if (!controle.ControleAuthentification(textBoxID.Text, textBoxMDP.Text))
                {
                    MessageBox.Show("Authentification incorrecte ou vous n'êtes pas admin", "Alerte");
                    textBoxMDP.Text = "";
                    textBoxID.Focus();
                }
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
        }
    }
}
