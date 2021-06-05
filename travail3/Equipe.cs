/******************************************************************************
 * Classe:      Equipe
 * 
 * Fichier:     Equipe.cs
 * 
 * Auteur:      Antoine Bédard
 * 
 * But:         Elle gère la création d'une équipe, elle a des accesseurs pour
 *              obtenir le code, le nom, l'endroit ou les joueurs de l'équipe.
 *              Elle vérifie que les équipe soit bien générer ( elle s'assure
 *              que les valeur soit les bone, qu'elles respecte les règles.).
 * ***************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;

namespace Hockey
{
    /// <summary>
    /// Class public Equipe, elle est caractériser par un code, un nom, 
    /// un endroit et une liste de joueurs.
    /// </summary>
    public class Equipe
    {
        /// <summary>
        /// Attribu string m_strCode, représente le code de l'équipe.
        /// </summary>
        private string m_strCode;
        /// <summary>
        /// Attribu string m_strNom, représente le nom de l'équipe.
        /// </summary>
        private string m_strNom;
        /// <summary>
        /// Attribu string m_strEndroit, représente l'endroit de l'équipe.
        /// </summary>
        private string m_strEndroit;
        /// <summary>
        /// Attribu List<Joueur> m_lesJoueurs, 
        /// représente la liste des joueur de l'équipe.
        /// </summary>
        private List<Joueur> m_lesJoueurs;

        /// <summary>
        /// Constructeur, il recoit le nom, le code et l'endroit de l'équipe en
        /// paramètre. Il vérifie si elles respecte les contraintes et si oui
        /// il les assignes au attribus. (Il crée une nouvelle équipe).
        /// </summary>
        /// <param name="code">String code, code de l'équipe.</param>
        /// <param name="nom">String nom, nom de l'équipe.</param>
        /// <param name="endroit">String endroit, endroit de l'équipe.</param>
        public Equipe(string code, string nom, string endroit)
        {
            // Vérification du code.
            // Variable bool blCodeValide, elle indique si le code 
            // est valide ou non.
            bool blCodeValide = true;

            // Vérification si le code est nul.
            if (code == null)
            {
                // Le code est nul donc il n'est pas valide.
                // La variable blCodeValide devient false.
                blCodeValide = false;

                // Lancement d'une exeption de type ArgumentNullException
                // elle envoie le message "Le code est nul.".
                throw new ArgumentNullException("Le code est nul.", (Exception)null);
            }

            // Vérification si le code a seulement 3 caractères.
            if (code.Length != 3 || code == "")
            {
                // Le code n'as pas 3 caractères, il est donc invalide.
                // La variable blCodeValide devient false.
                blCodeValide = false;

                // Lancement d'une exeption de type ArgumentException
                // elle envoie le message "La longueur du code est invalide.".
                throw new ArgumentException(
                    "La longueur du code est invalide.");
            }

            // Vérification si le code a la bonne alphabet.

            // Bool codeCaractereValide, elle représente si les 
            // caractères du code sont valide.
            bool codeCaractereValide = true;

            // Cette boucle for parcoure le code pour vérifier si c'est 
            // caractères sont valide.
            char[] alpha = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz".ToCharArray();
            int i;
            for (i = 0; i < code.Length; i++)
            {
                // Contrainte qui vérifie le charactère.
                //if (char.IsLetter(code, i) == false)
                if (alpha.Contains(code[i]) == false)
                {
                    // les charactères du code ne sont pas valide.
                    codeCaractereValide = false;

                    // Le code n'est pas valide.
                    blCodeValide = false;
                }
            }

            // Vérification si le code a des charactères invalide.
            if (codeCaractereValide == false)
            {
                // Le code a des charactères invalide, donc il y a un lancement
                // d'une exeption de type ArgumentException qui envoie le 
                // message "Le code contient au moins un caractère invalide.".
                throw new ArgumentException(
                    "Le code contient au moins un caractère invalide.");
            }

            // Vérification du nom.
            //Bool blNomValide représente si le nom est valide ou non.
            bool blNomValide = true;

            // Vérification si le nom est nul.
            if (nom == null)
            {
                // Le nom est nul.
                // blNomValide devient false, car le nom est invalide.
                blNomValide = false;

                // Lancement d'une exeption de type ArgumentNullException
                // elle envoie le message "Le nom est nul.".
                throw new ArgumentNullException("Le nom est nul.", (Exception)null);
            }

            // Vérification si le nom respecte la taille.
            if (nom.Length < 1 || nom.Length > 32)
            {
                // La taille n'est pas entre 1 et 32, alors blNomValide
                // devient false.
                blNomValide = false;

                // Lancement d'une exeption de type ArgumentException
                // elle envoie le message "La longueur du nom est invalide.".
                throw new ArgumentException(
                    "La longueur du nom est invalide.");
            }

            // Vérification de l'endroit.
            // Bool blEndroitValide, représente si l'endroit est valide ou non.
            bool blEndroitValide = true;

            // Vérification si l'endroit est nul.
            if (endroit == null)
            {
                // L'endroit est nul, donc blEndroitValide devient false.
                blEndroitValide = false;

                // Lancement d'une exeption de type ArgumentNullException
                // elle envoie le message "L'endroit est nul.".
                throw new ArgumentNullException("L'endroit est nul.", (Exception)null);
            }

            // Vérification si la taille de l'endroit est entre 1 et 32.
            if (endroit.Length < 1 || endroit.Length > 32)
            {
                // La taille est invalide, donc blEndroitValide devient false.
                blEndroitValide = false;

                // Lancement d'une exeption de type ArgumentException
                // elle envoie le message 
                // "La longueur de l'endroit est invalide.".
                throw new ArgumentException(
                    "La longueur de l'endroit est invalide.");
            }

            // vérification que tout les contraintes soit respecter.
            if (blCodeValide == true &&
                blNomValide == true &&
                blEndroitValide == true)
            {
                // Les contraintes sont tous respecter alors les 
                // valeurs sont attribuer a leur attribut respectif.
                m_strCode = code.ToUpper();
                m_strNom = nom;
                m_strEndroit = endroit;
                m_lesJoueurs = new List<Joueur>();
            }
        }

        /// <summary>
        /// Accesseur en lecture seulement, il retourne le code de l'équipe.
        /// </summary>
        public string Code
        {
            // Return m_strCode
            get { return m_strCode; }
        }

        /// <summary>
        /// Accesseur en lecture seulement, il retourne le nom de l'équipe.
        /// </summary>
        public string Nom
        {
            // Return m_strNom
            get { return m_strNom; }
        }

        /// <summary>
        /// Accesseur en lecture seulement, il retourne l'endroit de l'équipe.
        /// </summary>
        public string Endroit
        {
            // Return m_mstrEndroit
            get { return m_strEndroit; }
        }

        /// <summary>
        /// Ovveride de la methode ToString, elle formate un string et le
        /// return. "nom de endroit"
        /// </summary>
        /// <returns>String, return un string formater.</returns>
        public override string ToString()
        {
            // Return un string formater.
            return string.Format("{0} de {1}", m_strNom, m_strEndroit);
        }

        /// <summary>
        /// Cette méthode permet de comparer les deux équipes 
        /// reçues en paramètres. Spécifiquement à la classe, les deux équipes
        /// sont considérés comme étant égales si leurs
        /// codes respectifs sont égaux.
        /// </summary>
        /// <param name="equipeGauche">Première equipe de type Equipe a 
        /// comparer.</param>
        /// <param name="equipeDroite">Deuxième equipe de type Equipe a 
        /// comparer.</param>
        /// <returns>Return true si elle sont == et false si elle sont !=
        /// </returns>
        public static bool operator ==(
            Equipe equipeGauche, Equipe equipeDroite)
        {
            if (Object.ReferenceEquals(equipeGauche, equipeDroite))
            {
                return true;
            }
            if ((Object)equipeGauche == null
            || (Object)equipeDroite == null)
            {
                return false;
            }
            return (equipeGauche.Code == equipeDroite.Code);
        }

        /// <summary>
        /// Cette méthode retourne l'inverse du résultat de l'opérateur ==
        /// Elle vérifie si les équipe sont !=.
        /// </summary>
        /// <param name="equipeGauche">Première equipe de type Equipe a 
        /// comparer.</param>
        /// <param name="equipeDroite">Deuxième equipe de type Equipe a 
        /// comparer.</param>
        /// <returns>Return true si elle sont != et false si ell sont ==
        /// (inverse de operator ==)</returns>
        public static bool operator !=(
            Equipe equipeGauche, Equipe equipeDroite)
        {
            return !(equipeGauche == equipeDroite);
        }

        /// <summary>
        /// Cette méthode retourne le résultat de l'opérateur == si l'objet 
        /// reçu en paramètre est effectivement un objet de type Equipe.
        /// Sinon, elle retourne faux.
        /// </summary>
        /// <param name="obj">obj de type object</param>
        /// <returns>return true si c'est le même type d'objet</returns>
        public override bool Equals(object obj)
        {
            if (obj is Equipe)
            {
                return (this == (Equipe)obj);
            }
            return false;
        }

        /// <summary>
        /// Cette méthode retourne le résultat de la méthode 
        /// GetHashCode de la classe de base.
        /// </summary>
        /// <returns>Le résultat de GetHashCode de base.</returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        /// <summary>
        /// Elle permet d'obtenir le joueur a l'indice fournis et
        /// le return par la suite.
        /// </summary>
        /// <param name="iIndice">Indice de type int du joueur voulus.</param>
        /// <returns>Le joueur de type Joueur. Return null si l'indice
        /// est invalide.</returns>
        public Joueur ObtenirJoueur(int iIndice)
        {
            // Vérifie si l'indice est valide.
            if (iIndice >= 0 && iIndice < m_lesJoueurs.Count)
            {
                // unJoueur de type Joueur, il représente le joueur voulus.
                Joueur unJoueur = m_lesJoueurs[iIndice];

                // Return du joueur.
                return unJoueur;
            }
            else
            {
                // Return null, car l'indice est invalide.
                return null;
            }
        }

        /// <summary>
        /// Permet d'ajouter un joueur de type Joueur recus en paramètre.
        /// Le joueur est ajouter dans la liste si il n'est pas déja dedans.
        /// </summary>
        /// <param name="leJoueur">Le joueur de type Joueur a ajouter.</param>
        /// <returns>Return true si il est ajouter et false si il est pas 
        /// ajouter</returns>
        public bool Ajouter(Joueur leJoueur)
        {
            // Vérification si le joueur est null et si il est déja 
            // dans la liste.
            if (leJoueur != null && !m_lesJoueurs.Contains(leJoueur))
            {
                // Le joueur est ajouter.
                m_lesJoueurs.Add(leJoueur);

                // Return true.
                return true;
            }
            else
            {
                // Retrun false et le joueur n'est pas ajouter.
                return false;
            }
        }

        /// <summary>
        /// Retire le joueur fournis en paramètre de type Joueur de la liste.
        /// </summary>
        /// <param name="leJoueur">Le joueur de type Joueur a supprimer.
        /// </param>
        /// <returns>Return true si le joueur est supprimer et false si il
        /// n'est pas supprimer.</returns>
        public bool Retirer(Joueur leJoueur)
        {
            // Vérification si le joueur est contenu dans la liste.
            if (m_lesJoueurs.Contains(leJoueur))
            {
                // Le joueur est contenu donc il est supprimer.
                m_lesJoueurs.Remove(leJoueur);

                // Return true
                return true;
            }
            else
            {
                // Return false, car le joueur n'es pas supprimer.
                return false;
            }
        }
    }
}
