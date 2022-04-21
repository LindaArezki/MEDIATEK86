using MEDIATEK86.controleur;
using MEDIATEK86.Modele;
using System;
using System.Collections.Generic;
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

        BindingSource BsPersonnels = new BindingSource();
        BindingSource BsServices = new BindingSource();

  
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
            BsPersonnels.DataSource = lespersonnels;
            dgvPersonnels.DataSource = BsPersonnels;
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
            BsServices.DataSource = lesServices;
            cmbxServices.DataSource = BsServices;
            if (cmbxServices.Items.Count > 0)
            {
                cmbxServices.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// Methode pour le bouttonmoddifer pour modifier un personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BttnModifier_Click(object sender, EventArgs e)
        {
            if (dgvPersonnels.SelectedRows.Count > 0)
            {
                
                if (!TxtNom.Text.Equals("") && !txtPrénom.Text.Equals("") && !txtPrénom.Text.Equals("") && !TxtTEL.Text.Equals("") && cmbxServices.SelectedIndex != -1)
                {


                    Personnel personnel = (Personnel)BsPersonnels.List[BsPersonnels.Position];
                    Service service = (Service)BsServices.List[BsServices.Position];
                    personnel = new Personnel(personnel.IDpersonnel, service.IDservice, TxtNom.Text, txtPrénom.Text, TxtTEL.Text, txtEmail.Text, service.Nom);
                    

                    if (MessageBox.Show("Souhaitez-vous confirmer la modification?", "Etes vous sur ?", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        
                        controle.UpdateunPersonnel(personnel);
                        Remplirdgvpersonnels();
                      

                    }
                }

            }

            else
            {
                MessageBox.Show("Aucun personnel n'a été séléctionné.", "Attention");
            }

        }

        private void Bttnajoutperso_Click(object sender, EventArgs e)
        {
            if (!TxtNom.Text.Equals("") && !txtPrénom.Text.Equals("") && !TxtTEL.Text.Equals("") && !txtEmail.Text.Equals("") && cmbxServices.SelectedIndex != -1)
            {
                int IDPERSONNEL = 0;
                Service service = (Service)BsServices.List[BsServices.Position];
                Personnel personnel = new Personnel(IDPERSONNEL, service.IDservice, TxtNom.Text, txtPrénom.Text, TxtTEL.Text, txtEmail.Text, service.Nom);
                controle.AddunPersonnel(personnel);
                Remplirdgvpersonnels();
            }
            else
            {
                MessageBox.Show("Tous les champs ne sont pas remplis.", "ATTENTION");
            }

        }

        private void BttnSupp_Click(object sender, EventArgs e)
        {
            if (dgvPersonnels.SelectedRows.Count > 0)
            {

                Personnel personnel = (Personnel)BsPersonnels.List[BsPersonnels.Position];
                if (MessageBox.Show("Voulez-vous supprimer supprimer ce personnel ?", "Etes-vous sur ?", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    controle.DelunPersonnel(personnel);
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
                Personnel personnel = (Personnel)BsPersonnels.List[BsPersonnels.Position];
                controle.AfficherlesAbsences(personnel);
              
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un membre du personnel.", "ATTENTION");
            }

        }


    }
}
