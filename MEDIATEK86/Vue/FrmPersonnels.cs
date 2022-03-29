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
    /// <summary>
    /// Fenêtre du personnel
    /// </summary>
    public partial class FrmPersonnels : Form
    {
        /// <summary>
        /// Instance de la classe controle
        /// </summary>
        private Controle controle;

        BindingSource bsPersonnels = new BindingSource();
        BindingSource bsServices = new BindingSource();
        

        private bool show;

        /// <summary>
        /// Constructeur de classe
        /// </summary>
        public FrmPersonnels(Controle controle)
        {
            InitializeComponent();
            this.controle = controle;
            Init();
        }

        /// <summary>
        /// 
        /// </summary>
        public void Init()
        {
            Remplirdgvpersonnels();
            RemplirCmbxServices();
        }

        /// <summary>
        /// Affiche les personnels
        /// </summary>
        public void Remplirdgvpersonnels()
        {
            List<Personnel> lespersonnels = controle.GetLesPersonnels();
            bsPersonnels.DataSource = lespersonnels;
            dgvPersonnels.DataSource = bsPersonnels;
            dgvPersonnels.Columns["IDPERSONNEL"].Visible = false;
            dgvPersonnels.Columns["IDSERVICE"].Visible = false;
            dgvPersonnels.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        /// <summary>
        /// Affiche les services
        /// </summary>
        public void RemplirCmbxServices()
        {
            List<Service> lesServices = controle.GetLesServices();
            bsServices.DataSource = lesServices;
            cmbxServices.DataSource = bsServices;
        }

        /// <summary>
        /// Methode pour le bouttonmoddifer pour modifier un personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnModifier_Click(object sender, EventArgs e)
        {
            if (dgvPersonnels.SelectedRows.Count > 0)
            {
                Personnel personnel = (Personnel)bsPersonnels.List[bsPersonnels.Position];
                controle.UpdateunPersonnel(personnel);
            }

            else
            {
                MessageBox.Show("Tous les champs ne sont pas remplis ou/et aucun personnel n'a été séléctionner.", "Attention");
            }

        }

        private void bttnajoutperso_Click(object sender, EventArgs e)
        {
            if (!TxtNom.Text.Equals("") && !txtPrénom.Text.Equals("") && !TxtTEL.Text.Equals("") && !txtEmail.Text.Equals("") && cmbxServices.SelectedIndex != -1)
            {
                int IDPERSONNEL = 0;
                Service service = (Service)bsServices.List[bsServices.Position];
                Personnel personnel = new Personnel(IDPERSONNEL, TxtNom.Text , txtPrénom.Text, TxtTEL.Text, txtEmail.Text, service.IDSERVICE, service.NOM);
                controle.AddunPersonnel(personnel);
            }
            else
            {
                MessageBox.Show("Tous les champs ne sont pas remplis.", "ATTENTION");
            }

        }

        private void bttnSupp_Click(object sender, EventArgs e)
        {
            if (dgvPersonnels.SelectedRows.Count > 0)
            {
                Personnel personnel = (Personnel)bsPersonnels.List[bsPersonnels.Position];

                if (MessageBox.Show("Voulez-vous supprimer supprimer ce personnel ?", "Etes-vous sur ?", MessageBoxButtons.OKCancel) == DialogResult.Yes)
                {
                    controle.DelunPersonnel(personnel.IDPERSONNEL);
                    Remplirdgvpersonnels();
                }
            }
            else
            {
                MessageBox.Show("Aucun personnel n'a été séléctionné", "ATTENTION");
            }

        }
        private void BttnVoirabsence_Click(object sender, EventArgs e)
        {
            if (dgvPersonnels.SelectedRows.Count > 0)
            {
                Personnel personnel = (Personnel)bsPersonnels.List[bsPersonnels.Position];
                controle.AfficherlesAbsences(personnel);
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un membre du personnel.", "ATTENTION");
            }
        }
    }
}
