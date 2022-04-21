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
        private int IDMOTIF;
        private string LIBELLE;

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

        /// <summary>
        ///  permet l'utilisation 'getter' et 'setter' en lien avec le DataGridview
        /// </summary>
        public int Idmotif { get => IDMOTIF; set => IDMOTIF = value; }
        /// <summary>
        ///  permet l'utilisation 'getter' et 'setter' en lien avec le DataGridview
        /// </summary>
        public string Libelle { get => LIBELLE;  }

        /// <summary>
        /// Definit le motif à afficher. 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Libelle;
        }

    }

}
