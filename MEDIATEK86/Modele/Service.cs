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
        private readonly int IDSERVICE;
        private readonly string NOM;

        /// <summary>
        /// Constructeur : valorise les propriétés
        /// </summary>
        /// <param name="IDSERVICE"></param>
        /// <param name="NOM"></param>
        public Service(int IDSERVICE, string NOM)
        {
            this.IDSERVICE = IDSERVICE;
            this.NOM = NOM;
        }
    }
}

