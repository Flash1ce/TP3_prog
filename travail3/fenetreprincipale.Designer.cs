namespace travail3
{
    partial class FenetrePrincipale
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose ();
            }
            base.Dispose (disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            this.lblEquipes = new System.Windows.Forms.Label();
            this.lstEquipes = new System.Windows.Forms.ListBox();
            this.lblAgentsLibres = new System.Windows.Forms.Label();
            this.lstAgentsLibres = new System.Windows.Forms.ListBox();
            this.btnAjouterEquipe = new System.Windows.Forms.Button();
            this.btnSupprimerEquipe = new System.Windows.Forms.Button();
            this.btnAjouterAgentLibre = new System.Windows.Forms.Button();
            this.btnRecruterAgentLibre = new System.Windows.Forms.Button();
            this.btnAPropos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEquipes
            // 
            this.lblEquipes.AutoSize = true;
            this.lblEquipes.Location = new System.Drawing.Point(12, 9);
            this.lblEquipes.Name = "lblEquipes";
            this.lblEquipes.Size = new System.Drawing.Size(48, 13);
            this.lblEquipes.TabIndex = 0;
            this.lblEquipes.Text = "É&quipes:";
            // 
            // lstEquipes
            // 
            this.lstEquipes.FormattingEnabled = true;
            this.lstEquipes.Location = new System.Drawing.Point(12, 25);
            this.lstEquipes.Name = "lstEquipes";
            this.lstEquipes.Size = new System.Drawing.Size(256, 264);
            this.lstEquipes.TabIndex = 1;
            // 
            // lblAgentsLibres
            // 
            this.lblAgentsLibres.AutoSize = true;
            this.lblAgentsLibres.Location = new System.Drawing.Point(274, 9);
            this.lblAgentsLibres.Name = "lblAgentsLibres";
            this.lblAgentsLibres.Size = new System.Drawing.Size(70, 13);
            this.lblAgentsLibres.TabIndex = 2;
            this.lblAgentsLibres.Text = "&Agents libres:";
            // 
            // lstAgentsLibres
            // 
            this.lstAgentsLibres.FormattingEnabled = true;
            this.lstAgentsLibres.Location = new System.Drawing.Point(277, 25);
            this.lstAgentsLibres.Name = "lstAgentsLibres";
            this.lstAgentsLibres.Size = new System.Drawing.Size(544, 264);
            this.lstAgentsLibres.TabIndex = 3;
            // 
            // btnAjouterEquipe
            // 
            this.btnAjouterEquipe.Location = new System.Drawing.Point(827, 25);
            this.btnAjouterEquipe.Name = "btnAjouterEquipe";
            this.btnAjouterEquipe.Size = new System.Drawing.Size(145, 23);
            this.btnAjouterEquipe.TabIndex = 4;
            this.btnAjouterEquipe.Text = "A&jouter une équipe";
            this.btnAjouterEquipe.UseVisualStyleBackColor = true;
            this.btnAjouterEquipe.Click += new System.EventHandler(this.btnAjouterEquipe_Click);
            // 
            // btnSupprimerEquipe
            // 
            this.btnSupprimerEquipe.Location = new System.Drawing.Point(827, 54);
            this.btnSupprimerEquipe.Name = "btnSupprimerEquipe";
            this.btnSupprimerEquipe.Size = new System.Drawing.Size(145, 23);
            this.btnSupprimerEquipe.TabIndex = 5;
            this.btnSupprimerEquipe.Text = "&Supprimer une équipe";
            this.btnSupprimerEquipe.UseVisualStyleBackColor = true;
            this.btnSupprimerEquipe.Click += new System.EventHandler(this.btnSupprimerEquipe_Click);
            // 
            // btnAjouterAgentLibre
            // 
            this.btnAjouterAgentLibre.Location = new System.Drawing.Point(827, 83);
            this.btnAjouterAgentLibre.Name = "btnAjouterAgentLibre";
            this.btnAjouterAgentLibre.Size = new System.Drawing.Size(145, 23);
            this.btnAjouterAgentLibre.TabIndex = 6;
            this.btnAjouterAgentLibre.Text = "Aj&outer un agent libre";
            this.btnAjouterAgentLibre.UseVisualStyleBackColor = true;
            this.btnAjouterAgentLibre.Click += new System.EventHandler(this.btnAjouterAgentLibre_Click);
            // 
            // btnRecruterAgentLibre
            // 
            this.btnRecruterAgentLibre.Location = new System.Drawing.Point(827, 112);
            this.btnRecruterAgentLibre.Name = "btnRecruterAgentLibre";
            this.btnRecruterAgentLibre.Size = new System.Drawing.Size(145, 23);
            this.btnRecruterAgentLibre.TabIndex = 7;
            this.btnRecruterAgentLibre.Text = "&Recruter un agent libre";
            this.btnRecruterAgentLibre.UseVisualStyleBackColor = true;
            this.btnRecruterAgentLibre.Click += new System.EventHandler(this.btnRecruterAgentLibre_Click);
            // 
            // btnAPropos
            // 
            this.btnAPropos.Location = new System.Drawing.Point(827, 141);
            this.btnAPropos.Name = "btnAPropos";
            this.btnAPropos.Size = new System.Drawing.Size(145, 23);
            this.btnAPropos.TabIndex = 8;
            this.btnAPropos.Text = "À &propos de";
            this.btnAPropos.UseVisualStyleBackColor = true;
            this.btnAPropos.Click += new System.EventHandler(this.btnAPropos_Click);
            // 
            // FenetrePrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 304);
            this.Controls.Add(this.btnAPropos);
            this.Controls.Add(this.btnRecruterAgentLibre);
            this.Controls.Add(this.btnAjouterAgentLibre);
            this.Controls.Add(this.btnSupprimerEquipe);
            this.Controls.Add(this.btnAjouterEquipe);
            this.Controls.Add(this.lstAgentsLibres);
            this.Controls.Add(this.lblAgentsLibres);
            this.Controls.Add(this.lstEquipes);
            this.Controls.Add(this.lblEquipes);
            this.Name = "FenetrePrincipale";
            this.Text = "fenetreprincipale";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FenetrePrincipale_FormClosed);
            this.Load += new System.EventHandler(this.FenetrePrincipale_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEquipes;
        private System.Windows.Forms.ListBox lstEquipes;
        private System.Windows.Forms.Label lblAgentsLibres;
        private System.Windows.Forms.ListBox lstAgentsLibres;
        private System.Windows.Forms.Button btnAjouterEquipe;
        private System.Windows.Forms.Button btnSupprimerEquipe;
        private System.Windows.Forms.Button btnAjouterAgentLibre;
        private System.Windows.Forms.Button btnRecruterAgentLibre;
        private System.Windows.Forms.Button btnAPropos;
    }
}