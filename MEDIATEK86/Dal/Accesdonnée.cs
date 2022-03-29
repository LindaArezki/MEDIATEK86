using MEDIATEK86.Modele;
using MEDIATEK86.connexion;
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
        private static string connectionString = "Server=localhost;Database=mediatek86;User Id=mediatekadmin;Password=PaSSword12";

        /// <summary>
        /// Récupère et retourne les personnels provenant de la BDD
        /// </summary>
        /// <returns>liste des personnels</returns>
        public static List<Personnel> GetLesPersonnels()
        {
            List<Personnel> lesPersonnels = new List<Personnel>();
            string req = "SELECT p.IDPERSONNEL as IDPERSONNEL, s.IDSERVICE AS IDSERVICE, p.NOM AS NOM, p.PRENOM AS PRENOM, p.TEL AS TEL, p.MAIL AS MAIL, s.NOM AS 'service'";
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
                Service service = new Service((int)curseur.Field("IDSERVICE"),(string)curseur.Field("NOM"));
                lesServices.Add(service);
            }
            curseur.Close();
            return lesServices;
        }


        /// <summary>
        /// Ajoute un personnel
        /// </summary>
        /// <param name="personnel">objet de type personnel à ajouter</param>
        public static void AddunPersonnel(Personnel personnel)
        {
            string req = "INSERT INTO personnel(NOM, PRENOM, TEL, MAIL, IDSERVICE) ";
            req +="SELECT * FROM(SELECT @NOM AS NOM, @PRENOM AS PRENOM, @TEL AS TEL, @MAIL AS MAIL, @IDSERVICE AS IDSERVICE WHERE NOT EXISTS(SELECT NOM, PRENOM FROM personnel WHERE NOM = @NOM AND PRENOM = @PRENOM); ";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@NOM", personnel.NOM);
            parameters.Add("@PRENOM", personnel.PRENOM);
            parameters.Add("@TEL", personnel.TEL);
            parameters.Add("@MAIL", personnel.MAIL);
            parameters.Add("@IDSERVICE", personnel.IDSERVICE);
            ConnexionBdd connection = ConnexionBdd.GetInstance(connectionString);
            connection.ReqUpdate(req, parameters);
        }

        /// <summary>
        /// Supprime un personnel
        /// </summary>
        /// <param name="IDPERSONNEL">idpersonnel du personnel sélectionné</param>
        public static void DelunPersonnel(int IDPERSONNEL)
        {
            string req = "DELETE FROM personnel WHERE IDPERSONNEL = @IDPERSONNEL;";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@IDPERSONNEL", IDPERSONNEL);
            ConnexionBdd connection = ConnexionBdd.GetInstance(connectionString);
            connection.ReqUpdate(req, parameters);
        }

        /// <summary>
        /// Modification d'un personnel
        /// </summary>
        /// <param name="personnel">objet de type personnel à modifier</param>
        public static void UpdateunPersonnel(Personnel personnel)
        {
            string req = "UPDATE personnel SET NOM = @NOM, PRENOM = @PRENOM WHERE IDPERSONNEL = @IDPERSONNEL TEL = @TEL, MAIL = @MAIL, IDSERVICE = @IDSERVICE AND NOT EXISTS(SELECT NOM, PRENOM FROM personnel WHERE NOM = @NOM , PRENOM = @PRENOM AND IDPERSONNEL = @IDPERSONNEL);";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@IDPERSONNEL", personnel.IDPERSONNEL);
            parameters.Add("@NOM", personnel.NOM);
            parameters.Add("@PRENOM", personnel.PRENOM);
            parameters.Add("@TEL", personnel.TEL);
            parameters.Add("@MAIL", personnel.MAIL);
            parameters.Add("@IDSERVICE", personnel.IDSERVICE);
            ConnexionBdd connection = ConnexionBdd.GetInstance(connectionString);
            connection.ReqUpdate(req, parameters);

        }
    }
}

     

