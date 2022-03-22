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

        private readonly int IDPERSONNEL;
        private readonly int IDMOTIF;
        private readonly DateTime datedebut;
        private readonly DateTime datefin;
        private readonly string motif;

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
    }
}
