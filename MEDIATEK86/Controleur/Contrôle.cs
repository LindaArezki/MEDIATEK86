using System;
using System.Collections.Generic;
using MEDIATEK86.Dal;
using MEDIATEK86.Modele;
using MEDIATEK86.Vue;

namespace MEDIATEK86.controleur
{
    /// <summary>
    /// Gère les interractions entre la vue et le modèle
    /// </summary>
    public class Controle
    {
        /// <summary>
        /// Vue de la frmpersonnel
        /// </summary>
       public FrmPersonnels frmPersonnels;
       /// <summary>
       /// Vue de la frmbsence
       /// </summary>
       private Frmabsence frmabsence;

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
        /// <param name="personnel"> du personnel à supprimer</param>
        public void DelunPersonnel(Personnel personnel)
        {
            Accesdonnée.DelunPersonnel(personnel);
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
        /// </summary>
        /// <param name="personnel">Objet du type Personnel qui représente le membre du personnel dont on veut afficher les absences.</param>
        public void AfficherlesAbsences(Personnel personnel)
        {

            frmPersonnels.Hide();
            frmabsence = new Frmabsence(this,personnel);
            frmabsence.ShowDialog();
           
        }

        /// <summary>
        /// Récupère et retourne les infos des absences provenant de la BDD
        /// </summary>
        /// <returns>Liste des absences</returns>
        public List<Absence> GetlesAbsences(Personnel personnel) 
        {
            return Accesdonnée.GetlesAbsences(personnel);
            
           
            
        }

        /// <summary>
        /// Récupère et retourne les infos des motifs provenant de la BDD
        /// </summary>
        /// <returns>Liste des motifs</returns>
        public List<Motif> GetMotifs()
        {
            return Accesdonnée.GetMotifs();
        }

        /// <summary>
        /// Demande pour ajouter une absence
        /// </summary>
        /// <param name="absence">objet de type absence à ajouter</param>
        /// <param name="personnel"></param>
        public void Adduneabsence(Absence absence,Personnel personnel)
        {
            Accesdonnée.Adduneabsence(absence,personnel);
        }

        /// <summary>
        /// Demande pour supprimer un personnel
        /// </summary>
        /// <param name="absence">objet de type absence à supprimer</param>
        /// <param name="personnel">le personnel dont l'absence est à supprimer</param>
        public void Deluneabsence(Absence absence, Personnel personnel)
        {
            Accesdonnée.Deluneabsence(absence, personnel);
        }

        /// <summary>
        /// Demande de modification d'une absence
        /// </summary>
        /// <param name="absence">objet de type absence à modifier</param>
        /// <param name="personnel">ID du personnel dont l'absence doit être modifiée</param>
        public void Updateuneabsence(Absence absence, Personnel personnel)
        {
            Accesdonnée.Updateuneabsence(absence,personnel);
        }

        /// <summary>
        /// Méthode permettant de retourner vers la FrmPersonnel.
        /// </summary>
        public void Retourverslepersonnel()

        {
            frmabsence.Close();
            frmPersonnels.Show();
        }
      
    }
}



