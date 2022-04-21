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

        /// <summary>
        /// 
        /// </summary>
        private Personnel personnel;

        /// <summary>
        /// Constructeur de classe
        /// </summary>
        public Frmabsence(Controle controle,Personnel personnel)
        {
            InitializeComponent();
            this.controle = controle;
            this.personnel = personnel;
            Init();
        }

        /// <summary>
        /// 
        /// </summary>

        private void Init()
        { 
            Remplirdgvabsences();
            RemplirCmbxmotifs();
        }

        /// <summary>
        /// Affiche les absences
        /// </summary>
        public void Remplirdgvabsences()
        {
            List<Absence> lesabsences = controle.GetlesAbsences(personnel);
            bsAbsence.DataSource = lesabsences;
            dgvAbsences.DataSource = bsAbsence;
            dgvAbsences.Columns["IDPERSONNEL"].Visible = false;
            dgvAbsences.Columns["IDMOTIF"].Visible = false;
            dgvAbsences.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        /// <summary>
        /// 
        /// </summary>
        public void RemplirCmbxmotifs() 
        {
            List<Motif> motifs = controle.GetMotifs();
            bsmotifs.DataSource = motifs;
            cmbxmotifs.DataSource = bsmotifs;
        }  
        
        private void Bttnmodif1_Click(object sender, EventArgs e)
        {
            if (dgvAbsences.SelectedRows.Count > 0)
            {
                if (!dateTimePicker1.Value.Equals("") && !dateTimePicker2.Value.Equals("") && cmbxmotifs.SelectedIndex != -1)
                {
                    
                    Absence absence = (Absence)bsAbsence.List[bsAbsence.Position];
                    Motif motif = (Motif)bsmotifs.List[bsmotifs.Position];
                    absence = new Absence(personnel.IDpersonnel, absence.Datedebut, dateTimePicker2.Value, motif.Idmotif, motif.Libelle);

                       if (MessageBox.Show("Souhaitez-vous confirmer la modification?", "Etes vous sur ?", MessageBoxButtons.OKCancel) == DialogResult.OK)
                       {
                           controle.Updateuneabsence(absence, personnel);
                           Remplirdgvabsences();
                       }
                }

                else
                {
                        MessageBox.Show("Aucune absence n'a été séléctionnée.", "Attention");
                }
            }
        }

        private void BttnAjout1_Click(object sender, EventArgs e)
        {
            if (!dateTimePicker1.Value.Equals("") && !dateTimePicker2.Value.Equals("") && cmbxmotifs.SelectedIndex != -1)
            {
                
                Motif motif = (Motif)bsmotifs.List[bsmotifs.Position];
                Absence absence = new Absence(personnel.IDpersonnel, dateTimePicker1.Value, dateTimePicker2.Value, motif.Idmotif, motif.Libelle) ;
                controle.Adduneabsence(absence,personnel);
                Remplirdgvabsences();
            }
            else
            {
                MessageBox.Show("Tous les champs ne sont pas remplis.", "ATTENTION");
            }
        }

        private void BttnSupp1_Click(object sender, EventArgs e)
        {
            if (dgvAbsences.SelectedRows.Count > 0)
                {
                    Absence absence = (Absence)bsAbsence.List[bsAbsence.Position];
                    if (MessageBox.Show("Voulez-vous supprimer supprimer cette absence ?", "Etes-vous sur ?", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        controle.Deluneabsence(absence,personnel);
                        Remplirdgvabsences();
                    }
                }
             else
                {
                    MessageBox.Show("Aucune absence n'a été séléctionné", "ATTENTION");
                }
        }

        private void Bttnretour_Click(object sender, EventArgs e)
        {
            controle.Retourverslepersonnel();
        }
    }
}