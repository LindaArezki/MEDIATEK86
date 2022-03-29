using MEDIATEK86.controleur;
using MEDIATEK86.Modele;
using System;
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
    public partial class Frmabsence : Form
    {
        private Controle controle;

        BindingSource bsAbsence = new BindingSource();
        BindingSource bsmotifs = new BindingSource();


        private bool show;

        /// <summary>
        /// Constructeur de classe
        /// </summary>
        public Frmabsence(Controle controle)
        {
            InitializeComponent();
            this.controle = controle;
            Init();
        }

        private void bttnAjout1_Click(object sender, EventArgs e)
        {

        }
    }

}