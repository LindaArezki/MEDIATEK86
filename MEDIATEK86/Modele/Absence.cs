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
        private DateTime DATEDEBUT;
        private DateTime DATEFIN;
        private int IDMOTIF; 
        private string motif;


        /// <summary>
        /// Constructeur : valorise les propriétés
        /// </summary>
        /// <param name="IDPERSONNEL"></param>
        /// <param name="DATEDEBUT"></param>
        /// <param name="DATEFIN"></param>
        /// <param name="IDMOTIF"></param>
        /// <param name="motif"></param>
        public Absence(int IDPERSONNEL,DateTime DATEDEBUT, DateTime DATEFIN,int IDMOTIF,string motif)
        {
            this.IDPERSONNEL = IDPERSONNEL;
            this.DATEDEBUT = DATEDEBUT;
            this.DATEFIN = DATEFIN;
            this.IDMOTIF = IDMOTIF;
            this.motif = motif;
        }

        

        /// <summary>
        /// permet l'utilisation 'getter' et 'setter' en lien avec le DataGridview
        /// </summary>
        public int Idpersonnel { get => IDPERSONNEL; set => IDPERSONNEL = value; }
        /// <summary>
        /// permet l'utilisation 'getter' et 'setter' en lien avec le DataGridview
        /// </summary>
        public DateTime Datedebut { get => DATEDEBUT; set => DATEFIN = value; } 
        /// <summary>
        /// permet l'utilisation 'getter' et 'setter' en lien avec le DataGridview
        /// </summary>
        public DateTime Datefin { get => DATEFIN; set => DATEFIN = value; }
        /// <summary>
        /// permet l'utilisation 'getter' et 'setter' en lien avec le DataGridview
        /// </summary>
        public int Idmotif { get => IDMOTIF; set => IDMOTIF = value; }
       
        /// <summary>
        /// permet l'utilisation 'getter' et 'setter' en lien avec le DataGridview
        /// </summary>
        public string Motif { get => motif; set => motif = value; }

    }
}
