using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEDIATEK86.Modele
{
    /// <summary>
    /// Classe metier de la table responsable de la BDD
    /// </summary>
   public class Responsable
    {
        /// <summary>
        /// Déclaration des propriétés
        /// </summary>
        private string login;
        private string pwd;

        /// <summary>
        /// Constructeur,valorise les propiétés.
        /// </summary>
        /// <param name="login"></param>
        /// <param name="pwd"></param>
        public Responsable(string login,string pwd)
        {
            this.login = login;
            this.pwd = pwd;
        }

        /// <summary>
        /// permet l'utilisation 'getter' 
        /// </summary>
        public string Login { get => login; }

        /// <summary>
        /// permet l'utilisation 'getter' 
        /// </summary>
        public string Pwd { get => pwd; }
    }
}
