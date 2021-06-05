using System;
using System.Windows.Forms;
using Hockey;

namespace travail3
{
    public partial class FenetreJoueur : Form
    {
        private Joueur m_leJoueur;

        public FenetreJoueur ()
        {
            InitializeComponent ();
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MinimizeBox = false;
            MaximizeBox = false;
            ShowInTaskbar = false;
            AcceptButton = btnOK;
            CancelButton = btnAnnuler;
            btnOK.DialogResult = DialogResult.OK;
            btnAnnuler.DialogResult = DialogResult.Cancel;
            optADeterminer.Checked = true;
        }

        public Joueur LeJoueur
        {
            get { return m_leJoueur; }
        }

        private void btnOK_Click (object sender, EventArgs e)
        {
            Position laPosition;

            if (optCentre.Checked)
            {
                laPosition = Position.Centre;
            }
            else if (optAilierGauche.Checked)
            {
                laPosition = Position.AilierGauche;
            }
            else if (optAilierDroit.Checked)
            {
                laPosition = Position.AilierDroit;
            }
            else if (optDefenseur.Checked)
            {
                laPosition = Position.Defenseur;
            }
            else if (optGardienDeBut.Checked)
            {
                laPosition = Position.GardienDeBut;
            }
            else
            {
                laPosition = Position.ADeterminer;
            }
            try
            {
                m_leJoueur = new Joueur (txtNom.Text, txtPrenom.Text,
                    laPosition);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show (ex.Message,
                    FenetrePrincipale.TITRE_APPLICATION, MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                DialogResult = DialogResult.None;
            }
        }
    }
}
