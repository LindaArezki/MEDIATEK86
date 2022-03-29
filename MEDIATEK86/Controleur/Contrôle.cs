using MEDIATEK86.Dal;
using MEDIATEK86.Modele;
using MEDIATEK86.Vue;
using System.Collections.Generic;

namespace MEDIATEK86.controleur
{
    /// <summary>
    /// Gère les interractions entre la vue et le modèle
    /// </summary>
    public class Controle
    {
        FrmPersonnels frmPersonnels;
        Frmabsence Frmabsence;

        /// <summary>
        /// Ouverture de la fenêtre
        /// </summary>
        public Controle()
        {
            frmPersonnels = new FrmPersonnels(this);
            frmPersonnels.ShowDialog();
        }

          /// <summary>
          /// Récupère et retourne les infos du personnel provenant de la BDD
          /// </summary>
          /// <returns>liste des personnels</returns>
            public List<Personnel> GetLesPersonnels()
            {
                return Accesdonnée.GetLesPersonnels();
            }

            /// <summary>
            /// Récupère et retourne les infos des services provenant de la BDD
            /// </summary>
            /// <returns>liste des services</returns>
            public List<Service> GetLesServices()
            {
                return Accesdonnée.GetLesServices();
            }


        /// <summary>
        /// Demande pour ajouter un personnel
        /// </summary>
        /// <param name="personnel">objet de type personnel à ajouter</param>
        public void AddunPersonnel(Personnel personnel)
        {
            Accesdonnée.AddunPersonnel(personnel);
        }

        /// <summary>
        /// Demande pour supprimer un personnel
        /// </summary>
        /// <param name="IDPERSONNEL">id du personnel à supprimer</param>
        public void DelunPersonnel(int IDPERSONNEL)
        {
            Accesdonnée.DelunPersonnel(IDPERSONNEL);
        }

        /// <summary>
        /// Demande de modification d'un personnel
        /// </summary>
        /// <param name="personnel">objet de type personnel à modifier</param>
        public void UpdateunPersonnel(Personnel personnel)
        {
            Accesdonnée.UpdateunPersonnel(personnel);
        }
        /// <summary>
        /// Méthode qui appelle la méthode RemplirAbsences de la classe FrmAbsences pour afficher la liste des absences d'un membre du personnel.
        /// Ouvre ensuite la vue FrmAbsences.
        /// </summary>
        /// <param name="personnel">Objet du type Personnel qui représente le membre du personnel dont on veut afficher les absences.</param>
        public void AfficherlesAbsences(Personnel personnel)
        {
            Frmabsence = new Frmabsence(this);
            Frmabsence.ShowDialog();
        }

    }

}

