namespace travail3
{
    partial class FenetreEquipe
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
            this.lblCode = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblEndroit = new System.Windows.Forms.Label();
            this.txtEndroit = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(12, 9);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(35, 13);
            this.lblCode.TabIndex = 0;
            this.lblCode.Text = "&Code:";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(12, 25);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(100, 20);
            this.txtCode.TabIndex = 1;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(12, 59);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(32, 13);
            this.lblNom.TabIndex = 2;
            this.lblNom.Text = "&Nom:";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(12, 75);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(212, 20);
            this.txtNom.TabIndex = 3;
            // 
            // lblEndroit
            // 
            this.lblEndroit.AutoSize = true;
            this.lblEndroit.Location = new System.Drawing.Point(12, 111);
            this.lblEndroit.Name = "lblEndroit";
            this.lblEndroit.Size = new System.Drawing.Size(43, 13);
            this.lblEndroit.TabIndex = 4;
            this.lblEndroit.Text = "&Endroit:";
            // 
            // txtEndroit
            // 
            this.txtEndroit.Location = new System.Drawing.Point(12, 127);
            this.txtEndroit.Name = "txtEndroit";
            this.txtEndroit.Size = new System.Drawing.Size(212, 20);
            this.txtEndroit.TabIndex = 5;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(249, 25);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(249, 59);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 7;
            this.btnAnnuler.Text = "&Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // FenetreEquipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 159);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtEndroit);
            this.Controls.Add(this.lblEndroit);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.lblCode);
            this.Name = "FenetreEquipe";
            this.Text = "fenetreequipe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblEndroit;
        private System.Windows.Forms.TextBox txtEndroit;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnAnnuler;
    }
}