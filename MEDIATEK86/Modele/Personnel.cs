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
    class Personnel
    {
        private readonly int IDPERSONNEL;
        private readonly int IDSERVICE;
        private readonly string NOM;
        private readonly string PRENOM;
        private readonly string TEL;
        private readonly string MAIL;
        private readonly string service;

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
    }
}
