using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEDIATEK86.Modele
{
    /// <summary>
    /// Classe personnel de la table personnel de la bdd
    /// </summary>
     public class Personnel
    {
        private int IDPERSONNEL;
        private int IDSERVICE;
        private string NOM;
        private string PRENOM;
        private string TEL;
        private string MAIL;
        private string service;
       


        /// <summary>
        /// Constructeur, valorise les propriétés.
        /// </summary>
        /// <param name="IDPERSONNEL">idPersonnel du membre du personnel.</param>
        /// <param name="IDSERVICE">idService du membre du personnel.</param>
        /// <param name="NOM">Nom du membre du personnel.</param>
        /// <param name="PRENOM">Prénom du membre du personnel.</param>
        /// <param name="TEL">Service du membre du personnel.</param>
        /// <param name="MAIL">Téléphone du membre du personnel.</param>
        /// <param name="service">Adresse mail du membre du personnel.</param>
        public Personnel(int IDPERSONNEL, int IDSERVICE, string NOM, string PRENOM, string TEL, string MAIL, string service)
        {
            this.IDPERSONNEL = IDPERSONNEL;
            this.IDSERVICE = IDSERVICE;
            this.NOM = NOM;
            this.PRENOM = PRENOM;
            this.TEL = TEL;
            this.MAIL = MAIL;
            this.service = service;
        }

 

        /// <summary>
        /// permet l'utilisation 'getter' et 'setter' en lien avec le DataGridview
        /// </summary>
        public int IDpersonnel { get => IDPERSONNEL; set => IDPERSONNEL = value; }
        /// <summary>
        /// permet l'utilisation 'getter' et 'setter' en lien avec le DataGridview
        /// </summary>
        public int IDservice { get => IDSERVICE; set => IDSERVICE = value; }
        /// <summary>
        /// permet l'utilisation 'getter' et 'setter' en lien avec le DataGridview
        /// </summary>
        public string Nom { get => NOM; set => NOM = value; }
        /// <summary>
        /// permet l'utilisation 'getter' et 'setter' en lien avec le DataGridview
        /// </summary>
        public string Prénom { get => PRENOM; set => PRENOM = value ; }
        /// <summary>
        /// permet l'utilisation 'getter' et 'setter' en lien avec le DataGridview
        /// </summary>
        public string Téléphone { get => TEL; set => TEL = value;  }
        /// <summary>
        /// permet l'utilisation 'getter' et 'setter' en lien avec le DataGridview
        /// </summary>
        public string Mail { get => MAIL; set => MAIL = value; }
        /// <summary>
        /// permet l'utilisation 'getter' et 'setter' en lien avec le DataGridview
        /// </summary>
        public string Services { get => service; set => service = value;  }

    }

}
