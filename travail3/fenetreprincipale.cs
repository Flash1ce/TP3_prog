using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Hockey;

namespace travail3
{
    public partial class FenetrePrincipale : Form
    {
        // Texte qui doit apparaitre dans la barre-titre de la fenêtre
        // principale et dans la barre-titre de chacune des boites de
        // message.
        public const string TITRE_APPLICATION = "Travail 3";

        public FenetrePrincipale()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Text = TITRE_APPLICATION;
            lstEquipes.Font = new Font("Lucida Console", 9);
            lstEquipes.Sorted = true;
            lstAgentsLibres.Font = new Font("Lucida Console", 9);
            lstAgentsLibres.Sorted = true;
        }

        private void FenetrePrincipale_Load(object sender, EventArgs e)
        {
            List<Equipe> lstEquipe = GestionBDLigue.ObtenirEquipes();

            List<Joueur> lstAgentsLibres = 
                GestionBDLigue.ObtenirAgentsLibres();

            int i;
            for (i = 0; i < lstAgentsLibres.Count; i++)
            {
                this.lstAgentsLibres.Items.Add(lstAgentsLibres[i]);
            }

            if (this.lstAgentsLibres.Items.Count != 0)
            {
                this.lstAgentsLibres.SelectedIndex = 0;
            }

            int j;
            for (j = 0; j < lstEquipe.Count; j++)
            {
                this.lstEquipes.Items.Add(lstEquipe[j]);
            }

            if (this.lstEquipes.Items.Count != 0)
            {
                this.lstEquipes.SelectedIndex = 0;
            }

            // Préparer les requêtes de la classe GestionBDLigue.
            GestionBDLigue.PreparerRequetes();
        }

        private void FenetrePrincipale_FormClosed(object sender,
            FormClosedEventArgs e)
        {
            // Libérer les requêtes préparées de la classe GestionBDLigue.
            GestionBDLigue.LibererRequetes();
        }

        /// <summary>
        /// Ajouter une nouvelle équipe.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjouterEquipe_Click(object sender, EventArgs e)
        {

            FenetreEquipe frmEquipe;
            frmEquipe = new FenetreEquipe();
            frmEquipe.Text = TITRE_APPLICATION;

            if (frmEquipe.ShowDialog() == DialogResult.OK)
            {
                Equipe uneEquipe = frmEquipe.LaEquipe;
                if (!this.lstEquipes.Items.Contains(uneEquipe))
                {
                    GestionBDLigue.AjouterEquipe(uneEquipe);
                    this.lstEquipes.Items.Add(uneEquipe);
                    this.lstEquipes.SelectedItem = uneEquipe;
                }
                else
                {
                    MessageBox.Show(
                        "Une équipe avec le même nom est déjà dans la liste.", 
                        TITRE_APPLICATION, 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Warning);
                }
            }
            // Libérer les ressources.
            frmEquipe.Dispose();
        }

        /// <summary>
        /// Supprimer une équipe.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimerEquipe_Click(object sender, EventArgs e)
        {
            if (this.lstEquipes.SelectedItem != null)
            {
                Equipe uneEquipe = (Equipe)this.lstEquipes.SelectedItem;
                GestionBDLigue.SupprimerEquipe(uneEquipe);

                List<Joueur> uneLstAgentsLibres = GestionBDLigue.ObtenirAgentsLibres();

                int i;
                for (i = 0; i < uneLstAgentsLibres.Count; i++)
                {
                    this.lstAgentsLibres.Items.Add(uneLstAgentsLibres[i]);
                }

                int indice = this.lstEquipes.Items.IndexOf(uneEquipe);
                this.lstEquipes.Items.Remove(uneEquipe);

                if (this.lstEquipes.Items.Count >= 2)
                {
                    this.lstEquipes.SelectedIndex = indice - 1;
                }
                else if (this.lstEquipes.Items.Count == 1)
                {
                    this.lstEquipes.SelectedIndex = indice;
                }
            }
            else
            {
                MessageBox.Show("Vous devez sélectionner une " +
                    "équipe pour pouvoir la supprimer.",
                    TITRE_APPLICATION, 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Crée un nouveau joueur.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjouterAgentLibre_Click(object sender, EventArgs e)
        {
            FenetreJoueur frmJoueur;
            frmJoueur = new FenetreJoueur();
            frmJoueur.Text = TITRE_APPLICATION;

            if (frmJoueur.ShowDialog() == DialogResult.OK)
            {
                Joueur unJoueur = frmJoueur.LeJoueur;
                GestionBDLigue.AjouterJoueur(unJoueur);

                this.lstAgentsLibres.Items.Add(unJoueur);
                this.lstAgentsLibres.SelectedItem = unJoueur;
            }
            // Libérer les ressources.
            frmJoueur.Dispose();
        }

        /// <summary>
        /// Fonction qui sert a recruter les joueurs sans équipe
        /// dans une équipe.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRecruterAgentLibre_Click(object sender, EventArgs e)
        {
            if (this.lstAgentsLibres.SelectedItem != null && 
                this.lstEquipes.SelectedItem != null)
            {
                Joueur unJoueur = (Joueur)this.lstAgentsLibres.SelectedItem;
                Equipe uneEquipe = (Equipe)this.lstEquipes.SelectedItem;

                GestionBDLigue.AffecterJoueurAEquipe(uneEquipe, unJoueur);

                List<Joueur> lstJoueurLibre = 
                    GestionBDLigue.ObtenirAgentsLibres();

                int iNbJoueur = lstJoueurLibre.Count;

                int indice = this.lstAgentsLibres.Items.IndexOf(unJoueur);
                this.lstAgentsLibres.Items.Remove(unJoueur);

                if (this.lstAgentsLibres.Items.Count >= 2 && indice >= 1)
                {
                    this.lstAgentsLibres.SelectedIndex = indice - 1;
                }
                else if (this.lstAgentsLibres.Items.Count == 1 && indice == 1)
                {
                    this.lstAgentsLibres.SelectedIndex = indice;
                }
                else if (this.lstAgentsLibres.Items.Count >= 1 && indice == 0)
                {
                    this.lstAgentsLibres.SelectedIndex = indice;
                }

            }
            else if (this.lstEquipes.SelectedItem == null)
            {
                MessageBox.Show("Vous devez sélectionner une équipe " +
                    "pour qu'elle puisse recruter un agent libre.", 
                    TITRE_APPLICATION, 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning);
            }
            else if (this.lstAgentsLibres.SelectedItem == null)
            {
                MessageBox.Show("Vous devez sélectionner un agent" +
                    " libre pour qu'il puisse être recruté par une équipe.", 
                    TITRE_APPLICATION, 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Affiche un message box pour donner les informations.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAPropos_Click(object sender, EventArgs e)
        {
            MessageBox.Show(TITRE_APPLICATION + 
                " réalisé par Antoine Bédard (1939379).", 
                TITRE_APPLICATION, 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
        }
    }
}
