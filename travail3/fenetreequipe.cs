using System;
using System.Windows.Forms;
using Hockey;

namespace travail3
{
    public partial class FenetreEquipe : Form
    {
        private Equipe m_laEquipe;

        public FenetreEquipe ()
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
        }

        public Equipe LaEquipe
        {
            get { return m_laEquipe; }
        }

        private void btnOK_Click (object sender, EventArgs e)
        {
            try
            {
                m_laEquipe = new Equipe (txtCode.Text, txtNom.Text, txtEndroit.Text);
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
