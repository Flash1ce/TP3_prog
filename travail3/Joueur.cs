/******************************************************************************
 * Classe:      Joueur
 * 
 * Fichier:     Joueur.cs
 * 
 * Auteur:      Antoine Bédard
 * 
 * But:         Gère la création d'un joueur avec sont nom, prénom et ca 
 *              position. Elle contiens une énumération des position des
 *              accesseures pour le nom, prénom et la position.
 * ***************************************************************************/
using System;

namespace Hockey
{
    /// <summary>
    /// Enum de type Position, les position du joueur.
    /// de 0 a 5. Centre, AilierGauche, AilierDroit, Defenseur, GardienDeBut,
    /// ADeterminer. Parfois elle sont représenter par seulement 1 caractère.
    /// </summary>
    public enum Position
    {
        Centre,
        AilierGauche,
        AilierDroit,
        Defenseur,
        GardienDeBut,
        ADeterminer
    }

    /// <summary>
    /// Class Joueur, elle représente un joueur. Elle est caractériser par
    /// le nom, le prénom, et la position du joueur. Elle est public.
    /// </summary>
    public class Joueur
    {
        /// <summary>
        /// Attribut m_strNom de type string. Représente le nom du joueur.
        /// </summary>
        private string m_strNom;
        /// <summary>
        /// Attribut m_strPrenom de type string. Représente le 
        /// prénom du joueur.
        /// </summary>
        private string m_strPrenom;
        /// <summary>
        /// Attribut m_laPosition de type Position. 
        /// Représente la position du joueur.
        /// </summary>
        private Position m_laPosition;

        /// <summary>
        /// Constructeur, permet d'initialiser les attributs à l'aide des
        /// paramètres correspondants reçus si les conditions de validation
        /// sont respectées.
        /// </summary>
        /// <param name="nom">String, nom du joueur.</param>
        /// <param name="prenom">String, prenom du joueur.</param>
        /// <param name="position">Position, position du joueur.</param>
        public Joueur(string nom, string prenom, Position position)
        {
            // validation du nom avec sont accesseur et sont assigniation.
            Nom = nom;
            // validation du prenom avec sont accesseur et sont assigniation.
            Prenom = prenom;
            // validation de la position avec sont accesseur et 
            // sont assigniation.
            Position = position;
        }

        /// <summary>
        /// Accesseur du nom en lecture et écriture. La taille du nom
        /// doit être entre 1 et 32 caractères inclusivement.
        /// </summary>
        public string Nom
        {
            // Return le nom.
            get { return m_strNom; }
            // Assigne le nom si il répond au critères.
            set
            {
                // Variable bool, représente si le nom est nul ou pas.
                bool blEstPasNul = false;
                // Variable bool, représente si le nom a la bonne taille.
                bool blEstDeBonneTaille = false;

                // Vérifie si le nom est nul.
                if (value == null)
                {
                    // Le nom est nul, il respecte pas la consigne.
                    // Lancement d'une exeption de type ArgumentNullException
                    // et envoie comme message "Le nom est nul.".
                    throw new ArgumentNullException("Le nom est nul.", (Exception)null);
                }
                else
                {
                    // Le nom est pas nul, il respecte la consigne.
                    blEstPasNul = true;
                }

                // Vérifie si le nom est entre 1 et 32 inclusivement.
                if (value.Length >= 1 && value.Length <= 32)
                {
                    // Le nom respecte la consigne.
                    blEstDeBonneTaille = true;
                }
                else
                {
                    // Le nom ne respecte pas la consigne.
                    // Lancement d'une exeption de type ArgumentException
                    // et envoie comme message "La longueur du nom est 
                    // invalide.".
                    throw new ArgumentException(
                        "La longueur du nom est invalide.");
                }

                // Si le nom est pas nul et qu'il est de taille entre
                // 1 et 32, la valeur recus est assigner a l'attribu.
                if (blEstPasNul == true && blEstDeBonneTaille == true)
                {
                    m_strNom = value;
                }
            }
        }

        /// <summary>
        /// Accesseur du prenom en lecture et écriture. La taille du prenom
        /// doit être entre 1 et 32 caractères inclusivement.
        /// </summary>
        public string Prenom
        {
            // Return le prenom.
            get { return m_strPrenom; }
            // Assigne le prenom si il répond au critères.
            set
            {
                // Variable bool, représente si le nom est nul ou pas.
                bool blEstPasNul = false;
                // Variable bool, représente si le nom a la bonne taille.
                bool blEstDeBonneTaille = false;

                // Vérifie si le prenom est nul.
                if (value == null)
                {
                    // Le prenom est nul, il respecte pas la consigne.
                    // Lancement d'une exeption de type ArgumentNullException
                    // et envoie comme message "Le prénom est nul.".
                    throw new ArgumentNullException("Le prénom est nul.", (Exception)null);
                }
                else
                {
                    // Le prenom est pas nul, il respecte la consigne.
                    blEstPasNul = true;
                }

                // Vérifie si le prenom est entre 1 et 32 inclusivement.
                if (value.Length >= 1 && value.Length <= 32)
                {
                    // le prenom respecte la consigne.
                    blEstDeBonneTaille = true;
                }
                else
                {
                    // Le prenom ne respecte pas la consigne.
                    // Lancement d'une exeption de type ArgumentException
                    // et envoie comme message "La longeur du prénom 
                    // est invalide.".
                    throw new ArgumentException("La longueur du prénom est invalide.");
                }

                // Si le prenom est pas nul et qu'il est de taille entre
                // 1 et 32, la valeur recus est assigner a l'attribu.
                if (blEstPasNul == true && blEstDeBonneTaille == true)
                {
                    m_strPrenom = value;
                }
            }
        }

        /// <summary>
        /// Accesseur de la position en lecture et écriture. La position
        /// doit être comprise dans l'énumération de position de type Position.
        /// </summary>
        public Position Position
        {
            // Return la position
            get { return m_laPosition; }
            // Assigne la valeur a l'attribu si elle respecte les critères.
            set
            {
                // Vérification si la position est présente dans
                // l'énumération.
                if (Enum.IsDefined(typeof(Position), value))
                {
                    // La position est présente donc elle est assigner.
                    m_laPosition = value;
                }
                else
                {
                    // la position n'est pas présente, lancement d'une exeption
                    // de type ArgumentException et envoie le message 
                    // "La position est invalide.".
                    throw new ArgumentException("La position est invalide.");
                }
            }
        }

        /// <summary>
        /// Ovveride de la methode ToString. Elle formate le nom, prenom
        /// et la position du joueur. la position est entre () et est
        /// représenter par seulement un charactères soit C, L, R, D, G ou I
        /// </summary>
        /// <returns>String formaté, "nom, prenom   (position)"</returns>
        public override string ToString()
        {
            // Variable char, représente la position du joueur.
            char chPosition = ' ';

            // Trouver le caractère de la position.
            if (m_laPosition == (Position)0)
            {
                chPosition = 'C';
            }
            else if (m_laPosition == (Position)1)
            {
                chPosition = 'L';
            }
            else if (m_laPosition == (Position)2)
            {
                chPosition = 'R';
            }
            else if (m_laPosition == (Position)3)
            {
                chPosition = 'D';
            }
            else if (m_laPosition == (Position)4)
            {
                chPosition = 'G';
            }
            else if (m_laPosition == (Position)5)
            {
                chPosition = 'I';
            }

            // Return un string formater.
            return string.Format("{0,-66}   ({1})",
                (m_strNom + ", " + m_strPrenom), chPosition);
        }
    }
}
