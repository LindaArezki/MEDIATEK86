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
        private int iDPERSONNEL;
        private int iDSERVICE;
        private string nOM;
        private string pRENOM;
        private string tEL;
        private string mAIL;
        private string Service;
        private string text1;
        private string text2;
        private string text3;
        private string text4;

        /// <summary>
        /// Constructeur, valorise les propriétés.
        /// </summary>
        /// <param name="iDPERSONNEL">idPersonnel du membre du personnel.</param>
        /// <param name="iDSERVICE">idService du membre du personnel.</param>
        /// <param name="nOM">Nom du membre du personnel.</param>
        /// <param name="pRENOM">Prénom du membre du personnel.</param>
        /// <param name="tEL">Service du membre du personnel.</param>
        /// <param name="mAIL">Téléphone du membre du personnel.</param>
        /// <param name="Service">Adresse mail du membre du personnel.</param>
        public Personnel(int iDPERSONNEL, int iDSERVICE, string nOM, string pRENOM, string tEL, string mAIL, string Service)
        {
            this.iDPERSONNEL = IDPERSONNEL;
            this.iDSERVICE = IDSERVICE;
            this.nOM = NOM;
            this.pRENOM = PRENOM;
            this.tEL = TEL;
            this.mAIL = MAIL;
            this.Service = Service;
        }

        /// <summary>
        /// Ajout du texte dans datagridview
        /// </summary>
        /// <param name="iDPERSONNEL"></param>
        /// <param name="text1"></param>
        /// <param name="text2"></param>
        /// <param name="text3"></param>
        /// <param name="text4"></param>
        /// <param name="iDSERVICE"></param>
        /// <param name="nOM"></param>
        public Personnel(int iDPERSONNEL, string text1, string text2, string text3, string text4, int iDSERVICE, string nOM)
        {
            this.iDPERSONNEL = iDPERSONNEL;
            this.text1 = text1;
            this.text2 = text2;
            this.text3 = text3;
            this.text4 = text4;
            this.iDSERVICE = iDSERVICE;
            this.nOM = nOM;
        }

        /// <summary>
        /// permet l'utilisation 'getter' et 'setter' en lien avec le DataGridview
        /// </summary>
        public int IDPERSONNEL { get => iDPERSONNEL; set => iDPERSONNEL = value; }
        /// <summary>
        /// permet l'utilisation 'getter' et 'setter' en lien avec le DataGridview
        /// </summary>
        public int IDSERVICE { get => iDSERVICE; set => iDSERVICE = value; }
        /// <summary>
        /// permet l'utilisation 'getter' et 'setter' en lien avec le DataGridview
        /// </summary>
        public string NOM { get => nOM; set => nOM = value; }
        /// <summary>
        /// permet l'utilisation 'getter' et 'setter' en lien avec le DataGridview
        /// </summary>
        public string PRENOM { get => pRENOM; set => pRENOM = value ; }
        /// <summary>
        /// permet l'utilisation 'getter' et 'setter' en lien avec le DataGridview
        /// </summary>
        public string TEL { get => tEL; set => tEL = value;  }
        /// <summary>
        /// permet l'utilisation 'getter' et 'setter' en lien avec le DataGridview
        /// </summary>
        public string MAIL { get => mAIL; set => mAIL = value; }
        /// <summary>
        /// permet l'utilisation 'getter' et 'setter' en lien avec le DataGridview
        /// </summary>
        public string service { get => Service; set => Service = value;  }

    }

}
