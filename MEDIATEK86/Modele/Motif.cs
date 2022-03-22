using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEDIATEK86.Modele
{
    /// <summary>
    /// Classe motif de la table motif de la bdd
    /// </summary>
    public class Motif
    {
        private readonly int IDMOTIF;
        private readonly string LIBELLE;

        /// <summary>
        /// Constructeur, valorise les propriétés.
        /// </summary>
        /// <param name="IDMOTIF">IDMOTIF du Motif.</param>
        /// <param name="LIBELLE">LIBELLE du Motif.</param>
        public Motif(int IDMOTIF, string LIBELLE)
        {
            this.IDMOTIF = IDMOTIF;
            this.LIBELLE = LIBELLE;
        }
    }
}
