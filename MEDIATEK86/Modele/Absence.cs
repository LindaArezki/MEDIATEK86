using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEDIATEK86.Modele
{
    /// <summary>
    /// Classe absence de la table absence de la bdd
    /// </summary>
    public class Absence
    {

        private int IDPERSONNEL;
        private int IDMOTIF;
        private DateTime datedebut;
        private DateTime datefin;
        private string motif;

        /// <summary>
        /// Constructeur : valorise les propriétés
        /// </summary>
        /// <param name="IDPERSONNEL"></param>
        /// <param name="IDMOTIF"></param>
        /// <param name="datedebut"></param>
        /// <param name="datefin"></param>
        /// <param name="motif"></param>
        public Absence(int IDPERSONNEL, int IDMOTIF, DateTime datedebut, DateTime datefin, string motif)
        {
            this.IDPERSONNEL = IDPERSONNEL;
            this.IDMOTIF = IDMOTIF;
            this.datedebut = datedebut;
            this.datefin = datefin;
            this.motif = motif;
        }

        /// <summary>
        /// permet l'utilisation 'getter' et 'setter' en lien avec le DataGridview
        /// </summary>
        public int iDPERSONNEL { get => IDPERSONNEL; set => IDPERSONNEL = value; }
        /// <summary>
        /// permet l'utilisation 'getter' et 'setter' en lien avec le DataGridview
        /// </summary>
        public int iDMOTIF { get => IDMOTIF; set => IDMOTIF = value; }
        /// <summary>
        /// permet l'utilisation 'getter' et 'setter' en lien avec le DataGridview
        /// </summary>
        public DateTime Datedebut { get => datedebut; set => datedebut = value; }
        /// <summary>
        /// permet l'utilisation 'getter' et 'setter' en lien avec le DataGridview
        /// </summary>
        public DateTime Datefin { get => datefin; set => datefin = value; }
        /// <summary>
        /// permet l'utilisation 'getter' et 'setter' en lien avec le DataGridview
        /// </summary>
        public string Motif { get => motif; set => motif = value; }

    }
}
