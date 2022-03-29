﻿using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MEDIATEK86.connexion
{
    /// <summary>
    /// Connexion à la base de données et exécution des requêtes
    /// </summary>
    public class ConnexionBdd
    {
        /// <summary>
        /// objet de connexion à la BDD à partir d'une chaîne de connexion
        /// </summary>
        private readonly MySqlConnection connection;
        /// <summary>
        /// objet pour exécuter une requête SQL
        /// </summary>
        private MySqlCommand command;
        /// <summary>
        /// objet contenant le résultat d'une requête "select" (curseur)
        /// </summary>
        private MySqlDataReader reader;
        /// <summary>
        /// Unique instance de la classe
        /// </summary>
        private static ConnexionBdd instance = null;

        /// <summary>
        /// Constructeur privé pour créer la connexion à la BDD et l'ouvrir
        /// </summary>
        /// <param name="stringConnect">chaine de connexion</param>
        private ConnexionBdd(string stringConnect)
        {
            try
            {
                connection = new MySqlConnection(stringConnect);
                connection.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Application.Exit();
            }
        }

        internal static ConnexionBdd GetInstance(object connectionString)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Crée une instance unique de la classe
        /// </summary>
        /// <param name="stringConnect">chaine de connexion</param>
        /// <returns>instance unique de la classe</returns>
        public static ConnexionBdd GetInstance(string stringConnect)
        {
            if (instance is null)
            {
                instance = new ConnexionBdd(stringConnect);
            }
            return instance;
        }

        /// <summary>
        /// Exécution d'une requête autre que "select"
        /// </summary>
        /// <param name="stringQuery">requête autre que select</param>
        /// <param name="parameters"></param>
        public void ReqUpdate(string stringQuery, Dictionary<string, object> parameters)
        {
            try
            {
                command = new MySqlCommand(stringQuery, connection);
                foreach (KeyValuePair<string, object> parameter in parameters)
                {
                    command.Parameters.Add(new MySqlParameter(parameter.Key, parameter.Value));
                }
                command.Prepare();
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Exécute une requête type "select" et valorise le curseur
        /// </summary>
        /// <param name="stringQuery">requête select</param>
        /// <param name="p"></param>
        public void ReqSelect(string stringQuery, object p)
        {
            try
            {
                command = new MySqlCommand(stringQuery, connection);
                reader = command.ExecuteReader();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Tente de lire la ligne suivante du curseur
        /// </summary>
        /// <returns>false si fin de curseur atteinte</returns>
        public bool Read()
        {
            if (reader is null)
            {
                return false;
            }
            try
            {
                return reader.Read();
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Retourne le contenu d'un champ dont le nom est passé en paramètre
        /// </summary>
        /// <param name="nameField">nom du champ</param>
        /// <returns>valeur du champ</returns>
        public object Field(string nameField)
        {
            if (reader is null)
            {
                return null;
            }
            try
            {
                return reader[nameField];
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Fermeture du curseur
        /// </summary>
        public void Close()
        {
            if (!(reader is null))
            {
                reader.Close();
            }
        }

    }
}


