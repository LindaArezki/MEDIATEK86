using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEDIATEK86.Modele
{
    /// <summary>
    /// La classe métier correspondant à la table du même nom de la BDD
    /// </summary>
    public class Service
    {
        private int iDSERVICE;
        private string nOM;

        /// <summary>
        /// Constructeur : valorise les propriétés
        /// </summary>
        /// <param name="iDSERVICE"></param>
        /// <param name="nOM"></param>
        public Service(int iDSERVICE, string nOM)
        {
            this.iDSERVICE = iDSERVICE;
            this.nOM = NOM;
        }

        /// <summary>
        ///  permet l'utilisation 'getter' et 'setter' en lien avec le DataGridview
        /// </summary>
        public int IDSERVICE { get => iDSERVICE; set => iDSERVICE = value; }
        /// <summary>
        ///  permet l'utilisation 'getter' et 'setter' en lien avec le DataGridview
        /// </summary>
        public string NOM { get => nOM; set => nOM = value;  }
    }
}

