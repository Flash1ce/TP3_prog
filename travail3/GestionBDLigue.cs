/******************************************************************************
 * Classe:      GestionBDLigue
 * Classe:      ConnexionCommande
 * 
 * Fichier:     GestionBDLigue.cs
 * 
 * Auteur:      Antoine Bédard
 * 
 * But:         Elle s'occupe de géré en majorité les requètes a la base de
 *              données.
 *              
 * But:         Elle s'occupe de crée les commandes.
 * ***************************************************************************/
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace Hockey
{
    /// <summary>
    /// Class public static, elle est caractériser par les
    /// information de conexion et une liste de commandes préparer.
    /// Elle s'occupe de géré en majorité les requètes a la base de données.
    /// </summary>
    public static class GestionBDLigue
    {
        /// <summary>
        /// class private, elle est caractériser par une connexion 
        /// et une commande. Elle crée les commandes.
        /// </summary>
        private class ConnexionCommande
        {
            /// <summary>
            /// Attribut de type MySqlConnection, m_laConnexion représente 
            /// la connexion au serveur de BD.
            /// </summary>
            private MySqlConnection m_laConnexion;
            /// <summary>
            /// Attribut de type MySqlCommand, m_laCommande représente une 
            /// commande pour la BD.
            /// </summary>
            private MySqlCommand m_laCommande;

            /// <summary>
            /// Constructeur, il prend en paramètre une connexion et une commande.
            /// </summary>
            /// <param name="uneConnexion">Une connexion a un serveur de BD.
            /// </param>
            /// <param name="uneCommande">Une commande pour une BD.</param>
            public ConnexionCommande(
                MySqlConnection uneConnexion, MySqlCommand uneCommande)
            {
                m_laConnexion = uneConnexion;
                m_laCommande = uneCommande;
            }

            /// <summary>
            /// Accesseur en lecture seulement, return la connexion.
            /// </summary>
            public MySqlConnection Connexion
            {
                // Return m_laConnexion.
                get { return m_laConnexion; }
            }

            /// <summary>
            /// Accesseur en lecture seulement, return la commande.
            /// </summary>
            public MySqlCommand Commande
            {
                // Return m_laCommande
                get { return m_laCommande; }
            }
        }

        /// <summary>
        /// Attribut const string INFOS_CONNEXION, elle représente les informations,
        /// server, database, uid et pwd.
        /// </summary>
        private const string INFOS_CONNEXION = 
            "server=localhost;" +
            "database=14b_travail3;" +
            "uid=usager;" +
            "pwd=abcdef";

        /// <summary>
        /// Attribut static de type List<ConnexionCommande>, 
        /// g_lesConnexionsCommandes représente la liste de 
        /// commande et de connexion préparer.
        /// </summary>
        //private static List<ConnexionCommande> g_lesConnexionsCommandes;
        private static List<ConnexionCommande> g_lesConnexionsCommandes 
            = new List<ConnexionCommande>();

        /// <summary>
        /// Permet de préparer quatre requêtes destinées à être utilisées 
        /// plusieurs fois dans le cours de l'exécution de l'application.
        /// De plus elle sont ajouter a la liste.
        /// </summary>
        public static void PreparerRequetes()
        {
            // Déclaration de la connexion de type MySqlConnection.
            MySqlConnection uneConnexion;
            // Déclaration de la requete de type string.
            string strRequete;
            // Déclaration de la commande de type MySqlCommand.
            MySqlCommand uneCommande;

            // Premiere commande préparée.
            // Création de la connexion
            uneConnexion = new MySqlConnection(INFOS_CONNEXION);
            // Ouverture de la connexion.
            uneConnexion.Open();

            // une requete.
            strRequete = 
                "insert into equipes values (@Code, @Nom, @Endroit);";
            uneCommande = new MySqlCommand(strRequete, uneConnexion);
            // préparation de la requete.
            uneCommande.Prepare();
            // ajoute des parametres.
            uneCommande.Parameters.Add("@Code", MySqlDbType.VarChar);
            uneCommande.Parameters.Add("@Nom", MySqlDbType.VarChar);
            uneCommande.Parameters.Add("@Endroit", MySqlDbType.VarChar);
            g_lesConnexionsCommandes.Add(new ConnexionCommande(
                uneConnexion, uneCommande));

            // Deuxième commande préparée.
            // une requete.
            strRequete = "DELETE FROM equipes WHERE Code=@Code;";
            uneCommande = new MySqlCommand(strRequete, uneConnexion);
            // préparation de la requete.
            uneCommande.Prepare();
            // ajoute des parametres.
            uneCommande.Parameters.Add("@Code", MySqlDbType.VarChar);
            g_lesConnexionsCommandes.Add(new ConnexionCommande(
                uneConnexion, uneCommande));

            // Troisième commande préparée.
            // une requete.
            strRequete = 
                "INSERT INTO joueurs (Nom,Prenom,Position) " +
                "VALUES (@Nom, @Prenom, @Position);";
            uneCommande = new MySqlCommand(strRequete, uneConnexion);
            // préparation de la requete.
            uneCommande.Prepare();
            // ajoute des parametres.
            uneCommande.Parameters.Add("@Nom", MySqlDbType.VarChar);
            uneCommande.Parameters.Add("@Prenom", MySqlDbType.VarChar);
            uneCommande.Parameters.Add("@Position", MySqlDbType.VarChar);
            g_lesConnexionsCommandes.Add(new ConnexionCommande(
                uneConnexion, uneCommande));

            // Quatrième commande préparée.
            // une requete.
            strRequete =
                "UPDATE joueurs SET CodeEquipe=@Code " +
                "WHERE Numero=(SELECT Numero FROM joueurs " +
                "WHERE Nom=@Nom AND Prenom=@Prenom AND Position=@Position AND CodeEquipe IS NULL);";
            uneCommande = new MySqlCommand(strRequete, uneConnexion);
            // préparation de la requete.
            uneCommande.Prepare();
            // ajoute des parametres.
            uneCommande.Parameters.Add("@Code", MySqlDbType.VarChar);
            uneCommande.Parameters.Add("@Nom", MySqlDbType.VarChar);
            uneCommande.Parameters.Add("@Prenom", MySqlDbType.VarChar);
            uneCommande.Parameters.Add("@Position", MySqlDbType.VarChar);
            g_lesConnexionsCommandes.Add(new ConnexionCommande(
                uneConnexion, uneCommande));
        }

        /// <summary>
        /// Cette méthode permet de fermer toutes les connexions qui 
        /// se trouvent dans la liste représentée par l'attribut 
        /// g_lesConnexionsCommandes et de vider cette liste une fois 
        /// les connexions fermées.
        /// </summary>
        public static void LibererRequetes()
        {
            // Nombre de connexion et de commande dans l'atribut.
            int iNbConnexion = g_lesConnexionsCommandes.Count;

            // Variable d'incrémentation.
            int i;
            // Boucle qui fermme les connexions.
            for (i = 0; i < iNbConnexion; i++)
            {
                ConnexionCommande uneConnexion = g_lesConnexionsCommandes[i];
                uneConnexion.Connexion.Close();
            }

            // Clear la lsite.
            g_lesConnexionsCommandes.Clear();
        }

        /// <summary>
        /// Cette méthode permet d'obtenir la liste des équipes contenant 
        /// leurs joueurs respectifs à partir de la base de données.
        /// </summary>
        /// <returns>Return la list d'equipe de type list<Equipe></returns>
        public static List<Equipe> ObtenirEquipes()
        {
            MySqlConnection laConnexion = new MySqlConnection(INFOS_CONNEXION);
            string strRequete = "SELECT * FROM equipes;";
            MySqlCommand laCommande;
            MySqlDataReader leLecteur;
            List<Equipe> lstEquipes;

            laConnexion.Open();
            laCommande = new MySqlCommand(strRequete, laConnexion);
            leLecteur = laCommande.ExecuteReader();
            lstEquipes = new List<Equipe>();
            while (leLecteur.Read())
            {
                lstEquipes.Add(new Equipe(
                    leLecteur.GetString("Code"), 
                    leLecteur.GetString("Nom"), 
                    leLecteur.GetString("Endroit")));
            }
            leLecteur.Close();

            // Préparer command pour joueurs.
            MySqlCommand uneCommande;

            strRequete = "SELECT * FROM joueurs WHERE CodeEquipe =@Code;";
            uneCommande = new MySqlCommand(strRequete, laConnexion);
            uneCommande.Prepare();
            uneCommande.Parameters.Add("@Code", MySqlDbType.VarChar);

            for (int i = 0; i < lstEquipes.Count; i++)
            {
                uneCommande.Parameters["@Code"].Value = lstEquipes[i].Code;
                leLecteur = uneCommande.ExecuteReader();
                while (leLecteur.Read())
                {
                    char laPosition = leLecteur.GetChar("Position");
                    Position position = 0;
                    if (laPosition == 'C')
                    {
                        position = 0;
                    }
                    else if (laPosition == 'L')
                    {
                        position = (Position)1;
                    }
                    else if (laPosition == 'R')
                    {
                        position = (Position)2;
                    }
                    else if (laPosition == 'D')
                    {
                        position = (Position)3;
                    }
                    else if (laPosition == 'G')
                    {
                        position = (Position)4;
                    }
                    else if (laPosition == 'I')
                    {
                        position = (Position)5;
                    }

                    lstEquipes[i].Ajouter(new Joueur(
                        leLecteur.GetString("Nom"), 
                        leLecteur.GetString("Prenom"), 
                        position));
                }
                // Fermeture du lecteur.
                leLecteur.Close();
            }

            // Fermeture de la connexion.
            laConnexion.Close();
            return lstEquipes;
        }

        /// <summary>
        /// Cette méthode permet d'obtenir la liste des agents libres.
        /// </summary>
        /// <returns>Return une liste de type Joueur, c'est une liste 
        /// des joueur sans équipe.</returns>
        public static List<Joueur> ObtenirAgentsLibres()
        {
            // Une connexion pour la BD.
            MySqlConnection laConnexion = new MySqlConnection(INFOS_CONNEXION);

            // Une requete pour la BD.
            string strRequete = 
                "SELECT * FROM joueurs WHERE CodeEquipe IS NULL;";

            // Une commande de type MySqlCommand
            MySqlCommand laCommande;
            // Un lecteur de type MySqlDataReader
            MySqlDataReader leLecteur;
            // Une liste de type Joueur, qui représente les joueurs sans équipe.
            List<Joueur> lstAgentsLibres;

            // Ouverture de la connexion.
            laConnexion.Open();

            // Création de la commande.
            laCommande = new MySqlCommand(strRequete, laConnexion);

            // Lancement du lecteur.
            leLecteur = laCommande.ExecuteReader();

            // Création de la liste lstAgentsLibres.
            lstAgentsLibres = new List<Joueur>();

            // While, Tant que le lecteur vas lire la boucle vas s'executer.
            while (leLecteur.Read())
            {
                // Char qui représente la position du joueur.
                char laPosition = leLecteur.GetChar("Position");

                // Déclaration de position de Type Position.
                Position position = 0;

                if (laPosition == 'C')
                {
                    position = 0;
                }
                else if (laPosition == 'L')
                {
                    position = (Position)1;
                }
                else if (laPosition == 'R')
                {
                    position = (Position)2;
                }
                else if (laPosition == 'D')
                {
                    position = (Position)3;
                }
                else if (laPosition == 'G')
                {
                    position = (Position)4;
                }
                else if (laPosition == 'I')
                {
                    position = (Position)5;
                }

                // Ajout de joueur dans la liste lstAgentsLibres.
                lstAgentsLibres.Add(new Joueur(
                    leLecteur.GetString("Nom"), 
                    leLecteur.GetString("Prenom"), 
                    position));
            }

            // Fermeture du lecteur.
            leLecteur.Close();

            // Return la liste lstAgentsLibres.
            return lstAgentsLibres;
        }

        /// <summary>
        /// Elle ajoute l'équipe en exécutent la première requête préparée.
        /// L'équipe qui est ajouter est celle recus en paramètre.
        /// </summary>
        /// <param name="uneEquipe">une equipe de type Equipe, c'est l'équipe
        /// a ajouter</param>
        public static void AjouterEquipe(Equipe uneEquipe)
        {
            // Récupération de la commande.
            MySqlCommand laCommande = g_lesConnexionsCommandes[0].Commande;

            // Donne une value au parameters.
            laCommande.Parameters["@Code"].Value = uneEquipe.Code;
            laCommande.Parameters["@Nom"].Value = uneEquipe.Nom;
            laCommande.Parameters["@Endroit"].Value = uneEquipe.Endroit;

            // Exécution de la commande.
            laCommande.ExecuteNonQuery();
        }

        /// <summary>
        /// Supprime l'équipe recus en paramètre.
        /// </summary>
        /// <param name="uneEquipe">Type Equipe, une equipe a supprimer.
        /// </param>
        public static void SupprimerEquipe(Equipe uneEquipe)
        {
            // Récupération de l'équipe.
            MySqlCommand laCommande = g_lesConnexionsCommandes[1].Commande;

            // Donne une value au parameters.
            laCommande.Parameters["@Code"].Value = uneEquipe.Code;

            // Exécution de la commande.
            laCommande.ExecuteNonQuery();
        }

        /// <summary>
        /// Permet d'ajouter un joueur recus en paramètre.
        /// </summary>
        /// <param name="unJoueur">Type joueur, un joueur a ajouter.</param>
        public static void AjouterJoueur(Joueur unJoueur)
        {
            // Char qui représente la position du joueur.
            char laPosition = ' ';

            // Récupère le caractère de la position en fonction de la position.
            if (unJoueur.Position == 0)
            {
                // Centre
                laPosition = 'C';
            }
            else if (unJoueur.Position == (Position)1)
            {
                // AilierGauche
                laPosition = 'L';
            }
            else if (unJoueur.Position == (Position)2)
            {
                // AilierDroit
                laPosition = 'R';
            }
            else if (unJoueur.Position == (Position)3)
            {
                // Defenseur
                laPosition = 'D';
            }
            else if (unJoueur.Position == (Position)4)
            {
                // GardienDeBut
                laPosition = 'G';
            }
            else if (unJoueur.Position == (Position)5)
            {
                // ADeterminer
                laPosition = 'I';
            }

            // La commande pour ajouter de type MySqlCommand.
            MySqlCommand laCommande = g_lesConnexionsCommandes[2].Commande;

            // Donne une value au parameters.
            laCommande.Parameters["@Nom"].Value = unJoueur.Nom;
            laCommande.Parameters["@Prenom"].Value = unJoueur.Prenom;
            laCommande.Parameters["@Position"].Value = laPosition;

            // Execution de la commande.
            laCommande.ExecuteNonQuery();
        }

        /// <summary>
        /// Permet de modifier l'équipe d'un joueur. En fonction de l'équipe
        /// et du joueur recus en paramètre.
        /// </summary>
        /// <param name="unJoueur">Le joueur de type Joueur a qui l'équipe vas 
        /// être modifier,</param>
        /// <param name="uneEquipe">Une équipe de type Equipe a la quelle le
        /// joueur vas être attribuer.</param>
        public static void AffecterJoueurAEquipe(
             Equipe uneEquipe, Joueur unJoueur)
        {
            // Char qui représente la position du joueur.
            char laPosition = ' ';

            // Récupère le caractère de la position en fonction de la position.
            if (unJoueur.Position == 0)
            {
                // Centre
                laPosition = 'C';
            }
            else if (unJoueur.Position == (Position)1)
            {
                // AilierGauche
                laPosition = 'L';
            }
            else if (unJoueur.Position == (Position)2)
            {
                // AilierDroit
                laPosition = 'R';
            }
            else if (unJoueur.Position == (Position)3)
            {
                // Defenseur
                laPosition = 'D';
            }
            else if (unJoueur.Position == (Position)4)
            {
                // GardienDeBut
                laPosition = 'G';
            }
            else if (unJoueur.Position == (Position)5)
            {
                // ADeterminer
                laPosition = 'I';
            }

            // La commande de type MySqlCommand.
            MySqlCommand laCommande = g_lesConnexionsCommandes[3].Commande;

            // Donne une value aux parameters.
            laCommande.Parameters["@Code"].Value = uneEquipe.Code;
            laCommande.Parameters["@Nom"].Value = unJoueur.Nom;
            laCommande.Parameters["@Prenom"].Value = unJoueur.Prenom;
            laCommande.Parameters["@Position"].Value = laPosition;

            // Exécution de la commande.
            laCommande.ExecuteNonQuery();
        }
    }
}
