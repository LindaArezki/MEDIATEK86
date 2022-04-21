using MEDIATEK86.connexion;
using MEDIATEK86.Modele;
using MEDIATEK86.controleur;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEDIATEK86.Dal
{
    /// <summary>
    /// Classe permettant de gérer les demandes concernant les données distantes
    /// </summary>
    public class Accesdonnée
    {
        /// <summary>
        /// chaine de connexion à la bdd
        /// </summary>
        private static string connectionString = "Server=localhost;Database=mediatek86;User Id=Mediatekadmin;Password=PaSSword12";

        /// <summary>
        /// Récupère et retourne les personnels provenant de la BDD
        /// </summary>
        /// <returns>liste des personnels</returns>
        public static List<Personnel> GetLesPersonnels()
        {
            List<Personnel> lesPersonnels = new List<Personnel>();
            string req = "SELECT p.IDPERSONNEL as IDPERSONNEL, p.IDSERVICE AS IDSERVICE, p.NOM AS NOM, p.PRENOM AS PRENOM, p.TEL AS TEL, p.MAIL AS MAIL, s.NOM AS service ";
            req += "FROM personnel p JOIN service s USING (IDSERVICE)";
            req += "ORDER BY NOM, PRENOM;";
            ConnexionBdd curseur = ConnexionBdd.GetInstance(connectionString);
            curseur.ReqSelect(req, null);
            while (curseur.Read())
            {


                Personnel personnel = new Personnel((int)curseur.Field("IDPERSONNEL"),
                                                    (int)curseur.Field("IDSERVICE"),
                                                    (string)curseur.Field("NOM"),
                                                    (string)curseur.Field("PRENOM"),
                                                    (string)curseur.Field("TEL"),
                                                    (string)curseur.Field("MAIL"),
                                                    (string)curseur.Field("service"));
                lesPersonnels.Add(personnel);

            }
            curseur.Close();
            return lesPersonnels;
        }

        /// <summary>
        /// Récupère et retourne les services provenant de la BDD
        /// </summary>
        /// <returns>liste des services</returns>
        public static List<Service> GetLesServices()
        {
            List<Service> lesServices = new List<Service>();
            string req = "SELECT * FROM service ORDER BY NOM;";
            ConnexionBdd curseur = ConnexionBdd.GetInstance(connectionString);
            curseur.ReqSelect(req, null);
            while (curseur.Read())
            {
                Service service = new Service((int)curseur.Field("IDSERVICE"),
                                              (string)curseur.Field("NOM"));
                lesServices.Add(service);
            }
            curseur.Close();
            return lesServices;
        }

        /// <summary>
        /// Récupère et retourne les absences provenant de la BDD
        /// </summary>
        /// <param name="personnel"> </param>
        /// <returns>liste des absences</returns>
        public static List<Absence> GetlesAbsences(Personnel personnel)
        {
            List<Absence> lesabsences = new List<Absence>();
            string req = "SELECT p.IDPERSONNEL AS IDPERSONNEL, a.DATEDEBUT AS DATEDEBUT, a.DATEFIN AS DATEFIN , a.IDMOTIF AS IDMOTIF, m.LIBELLE AS 'motif' ";
            req += "FROM absence a JOIN motif m USING (IDMOTIF) JOIN personnel p ON p.IDPERSONNEL = a.IDPERSONNEL ";
            req += "WHERE p.IDPERSONNEL = @IDPERSONNEL ";
            req += "ORDER BY DATEDEBUT DESC;";
            Dictionary < string,object> parameters = new Dictionary<string, object>();
            parameters.Add("@IDPERSONNEL", personnel.IDpersonnel);
            ConnexionBdd curseur = ConnexionBdd.GetInstance(connectionString);
            curseur.ReqSelect(req, parameters);
            while (curseur.Read())
            {
                Absence absence = new Absence((int)curseur.Field("IDPERSONNEL"),
                                              (DateTime)curseur.Field("DATEDEBUT"),
                                              (DateTime)curseur.Field("DATEFIN"),
                                              (int)curseur.Field("IDMOTIF"),
                                              (string)curseur.Field("motif"));
                lesabsences.Add(absence);

            }
            curseur.Close();
            return lesabsences;
        }

        /// <summary>
        /// Récupère et retourne les motifs provenant de la BDD
        /// </summary>
        /// <returns>liste des motifs</returns>
        public static List<Motif> GetMotifs()
        {
            List<Motif> motifs = new List<Motif>();
            string req = "SELECT * FROM motif ORDER BY LIBELLE;";
            ConnexionBdd curseur = ConnexionBdd.GetInstance(connectionString);
            curseur.ReqSelect(req, null);
            while (curseur.Read())
            {
                Motif motif = new Motif((int)curseur.Field("IDMOTIF"),
                                        (string)curseur.Field("LIBELLE"));
                motifs.Add(motif);
            }
            curseur.Close();
            return motifs;
        }


        /// <summary>
        /// Ajoute un personnel
        /// </summary>
        /// <param name="personnel">objet de type personnel à ajouter</param>
        public static void AddunPersonnel(Personnel personnel)
        {
            string req = "INSERT INTO personnel(IDSERVICE,NOM, PRENOM, TEL, MAIL) ";
            req += "VALUES ( @IDSERVICE, @NOM, @PRENOM, @TEL, @MAIL)";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add( "@IDSERVICE", personnel.IDservice );
            parameters.Add("@NOM", personnel.Nom);
            parameters.Add("@PRENOM", personnel.Prénom);
            parameters.Add("@TEL", personnel.Téléphone);
            parameters.Add("@MAIL", personnel.Mail );
            ConnexionBdd connection = ConnexionBdd.GetInstance(connectionString);
            connection.ReqUpdate(req, parameters);
        }

        /// <summary>
        /// Supprime un personnel
        /// </summary>
        /// <param name="personnel">idpersonnel du personnel sélectionné</param>
        public static void DelunPersonnel(Personnel personnel)
        {
            string req = "DELETE FROM personnel WHERE IDPERSONNEL = @IDPERSONNEL;";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@IDPERSONNEL", personnel.IDpersonnel);
            ConnexionBdd connection = ConnexionBdd.GetInstance(connectionString);
            connection.ReqUpdate(req, parameters);
        }

        /// <summary>
        /// Modification d'un personnel
        /// </summary>
        /// <param name="personnel">objet de type personnel à modifier</param>
        public static void UpdateunPersonnel(Personnel personnel)
        {
            string req = "UPDATE personnel SET NOM = @NOM, PRENOM = @PRENOM , TEL = @TEL, MAIL = @MAIL,IDSERVICE = @IDSERVICE ";
            req+= "WHERE IDPERSONNEL = @IDPERSONNEL";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@IDPERSONNEL", personnel.IDpersonnel);
            parameters.Add("@NOM", personnel.Nom);
            parameters.Add("@PRENOM", personnel.Prénom);
            parameters.Add("@TEL", personnel.Téléphone);
            parameters.Add("@MAIL", personnel.Mail);
            parameters.Add("@IDSERVICE", personnel.IDservice);
            ConnexionBdd connection = ConnexionBdd.GetInstance(connectionString);
            connection.ReqUpdate(req, parameters);

        }


        /// <summary>
        /// Ajoute une absence
        /// </summary>
        /// <param name="absence">objet de type absence à ajouter</param>
        /// <param name="personnel"></param>

        public static void Adduneabsence (Absence absence,Personnel personnel)
        {
            string req = "INSERT INTO absence(IDPERSONNEL,DATEDEBUT, DATEFIN,IDMOTIF)  ";
            req += "VALUES( @IDPERSONNEL, @DATEDEBUT, @DATEFIN, @IDMOTIF)";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@IDPERSONNEL", personnel.IDpersonnel);
            parameters.Add("@DATEDEBUT", absence.Datedebut);
            parameters.Add("@DATEFIN", absence.Datefin);
            parameters.Add("@IDMOTIF", absence.Idmotif);
    
            ConnexionBdd connection = ConnexionBdd.GetInstance(connectionString);
            connection.ReqUpdate(req, parameters);
        }

        /// <summary>
        /// Suppression d'une absence
        /// </summary>
        /// <param name="absence">objet de type absence à supprimer</param>
        /// <param name="personnel">objet de type personnel à supprimer</param>
        public static void Deluneabsence (Absence absence, Personnel personnel)
        {
            string req = "DELETE FROM absence WHERE IDPERSONNEL = @IDPERSONNEL AND DATEDEBUT = @DATEDEBUT;";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@IDPERSONNEL", personnel.IDpersonnel);
            parameters.Add("@DATEDEBUT", absence.Datedebut);

            ConnexionBdd connection = ConnexionBdd.GetInstance(connectionString);
            connection.ReqUpdate(req, parameters);
        }

        /// <summary>
        /// Modification d'une absence
        /// </summary>
        /// <param name="absence"></param>
        /// <param name="personnel"></param>
        public static void Updateuneabsence (Absence absence, Personnel personnel)
        {

            string req = "UPDATE absence SET IDPERSONNEL = @IDPERSONNEL, DATEDEBUT = @DATEDEBUT, IDMOTIF = @IDMOTIF, DATEFIN = @DATEFIN ";
            req+="WHERE DATEDEBUT = @DATEDEBUT AND IDPERSONNEL= @IDPERSONNEL";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@IDMOTIF", absence.Idmotif);
            parameters.Add("@IDPERSONNEL", personnel.IDpersonnel);
            parameters.Add("@DATEDEBUT", absence.Datedebut);
            parameters.Add("@DATEFIN", absence.Datefin);
            ConnexionBdd connection = ConnexionBdd.GetInstance(connectionString);
            connection.ReqUpdate(req, parameters);
           
        }
    }
}

     

