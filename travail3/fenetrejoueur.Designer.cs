namespace travail3
{
    partial class FenetreJoueur
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
            this.grpPosition = new System.Windows.Forms.GroupBox();
            this.optADeterminer = new System.Windows.Forms.RadioButton();
            this.optDefenseur = new System.Windows.Forms.RadioButton();
            this.optAilierDroit = new System.Windows.Forms.RadioButton();
            this.optAilierGauche = new System.Windows.Forms.RadioButton();
            this.optCentre = new System.Windows.Forms.RadioButton();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.optGardienDeBut = new System.Windows.Forms.RadioButton();
            this.grpPosition.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPosition
            // 
            this.grpPosition.Controls.Add(this.optGardienDeBut);
            this.grpPosition.Controls.Add(this.optADeterminer);
            this.grpPosition.Controls.Add(this.optDefenseur);
            this.grpPosition.Controls.Add(this.optAilierDroit);
            this.grpPosition.Controls.Add(this.optAilierGauche);
            this.grpPosition.Controls.Add(this.optCentre);
            this.grpPosition.Location = new System.Drawing.Point(230, 9);
            this.grpPosition.Name = "grpPosition";
            this.grpPosition.Size = new System.Drawing.Size(200, 169);
            this.grpPosition.TabIndex = 4;
            this.grpPosition.TabStop = false;
            this.grpPosition.Text = "P&osition:";
            // 
            // optADeterminer
            // 
            this.optADeterminer.AutoSize = true;
            this.optADeterminer.Location = new System.Drawing.Point(6, 141);
            this.optADeterminer.Name = "optADeterminer";
            this.optADeterminer.Size = new System.Drawing.Size(86, 17);
            this.optADeterminer.TabIndex = 5;
            this.optADeterminer.Text = "À Déterminer";
            this.optADeterminer.UseVisualStyleBackColor = true;
            // 
            // optDefenseur
            // 
            this.optDefenseur.AutoSize = true;
            this.optDefenseur.Location = new System.Drawing.Point(7, 95);
            this.optDefenseur.Name = "optDefenseur";
            this.optDefenseur.Size = new System.Drawing.Size(74, 17);
            this.optDefenseur.TabIndex = 3;
            this.optDefenseur.Text = "Défenseur";
            this.optDefenseur.UseVisualStyleBackColor = true;
            // 
            // optAilierDroit
            // 
            this.optAilierDroit.AutoSize = true;
            this.optAilierDroit.Location = new System.Drawing.Point(7, 70);
            this.optAilierDroit.Name = "optAilierDroit";
            this.optAilierDroit.Size = new System.Drawing.Size(72, 17);
            this.optAilierDroit.TabIndex = 2;
            this.optAilierDroit.Text = "Ailier Droit";
            this.optAilierDroit.UseVisualStyleBackColor = true;
            // 
            // optAilierGauche
            // 
            this.optAilierGauche.AutoSize = true;
            this.optAilierGauche.Location = new System.Drawing.Point(7, 45);
            this.optAilierGauche.Name = "optAilierGauche";
            this.optAilierGauche.Size = new System.Drawing.Size(88, 17);
            this.optAilierGauche.TabIndex = 1;
            this.optAilierGauche.Text = "Ailier Gauche";
            this.optAilierGauche.UseVisualStyleBackColor = true;
            // 
            // optCentre
            // 
            this.optCentre.AutoSize = true;
            this.optCentre.Location = new System.Drawing.Point(7, 20);
            this.optCentre.Name = "optCentre";
            this.optCentre.Size = new System.Drawing.Size(56, 17);
            this.optCentre.TabIndex = 0;
            this.optCentre.Text = "Centre";
            this.optCentre.UseVisualStyleBackColor = true;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(12, 80);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(212, 20);
            this.txtPrenom.TabIndex = 3;
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(12, 64);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(46, 13);
            this.lblPrenom.TabIndex = 2;
            this.lblPrenom.Text = "&Prénom:";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(12, 25);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(212, 20);
            this.txtNom.TabIndex = 1;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(12, 9);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(32, 13);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "&Nom:";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Location = new System.Drawing.Point(233, 198);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 6;
            this.btnAnnuler.Text = "&Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(139, 198);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // optGardienDeBut
            // 
            this.optGardienDeBut.AutoSize = true;
            this.optGardienDeBut.Location = new System.Drawing.Point(6, 118);
            this.optGardienDeBut.Name = "optGardienDeBut";
            this.optGardienDeBut.Size = new System.Drawing.Size(95, 17);
            this.optGardienDeBut.TabIndex = 4;
            this.optGardienDeBut.Text = "Gardien de but";
            this.optGardienDeBut.UseVisualStyleBackColor = true;
            // 
            // FenetreJoueur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 233);
            this.Controls.Add(this.grpPosition);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnOK);
            this.Name = "FenetreJoueur";
            this.Text = "fenetrejoueur";
            this.grpPosition.ResumeLayout(false);
            this.grpPosition.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPosition;
        private System.Windows.Forms.RadioButton optADeterminer;
        private System.Windows.Forms.RadioButton optDefenseur;
        private System.Windows.Forms.RadioButton optAilierDroit;
        private System.Windows.Forms.RadioButton optAilierGauche;
        private System.Windows.Forms.RadioButton optCentre;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.RadioButton optGardienDeBut;
    }
}