namespace PPE
{
    partial class FenetrePrincipale
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbRepertoire = new System.Windows.Forms.Label();
            this.lbFichier = new System.Windows.Forms.Label();
            this.lbAnne = new System.Windows.Forms.Label();
            this.lbNiveau = new System.Windows.Forms.Label();
            this.lbMdp = new System.Windows.Forms.Label();
            this.cbFichier = new System.Windows.Forms.ComboBox();
            this.cbNiveau = new System.Windows.Forms.ComboBox();
            this.btnLancer = new System.Windows.Forms.Button();
            this.tbAnnee = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.clbFichier = new System.Windows.Forms.CheckedListBox();
            this.cbAleatoire = new System.Windows.Forms.CheckBox();
            this.cbConstruit = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbRepertoire
            // 
            this.lbRepertoire.AutoSize = true;
            this.lbRepertoire.Location = new System.Drawing.Point(12, 27);
            this.lbRepertoire.Name = "lbRepertoire";
            this.lbRepertoire.Size = new System.Drawing.Size(118, 13);
            this.lbRepertoire.TabIndex = 0;
            this.lbRepertoire.Text = "Répertoire des fichiers :";
            // 
            // lbFichier
            // 
            this.lbFichier.AutoSize = true;
            this.lbFichier.Location = new System.Drawing.Point(12, 86);
            this.lbFichier.Name = "lbFichier";
            this.lbFichier.Size = new System.Drawing.Size(108, 13);
            this.lbFichier.TabIndex = 1;
            this.lbFichier.Text = "Fichier csv à integrer:";
            // 
            // lbAnne
            // 
            this.lbAnne.AutoSize = true;
            this.lbAnne.Location = new System.Drawing.Point(12, 202);
            this.lbAnne.Name = "lbAnne";
            this.lbAnne.Size = new System.Drawing.Size(83, 13);
            this.lbAnne.TabIndex = 2;
            this.lbAnne.Text = "Année scolaire :";
            // 
            // lbNiveau
            // 
            this.lbNiveau.AutoSize = true;
            this.lbNiveau.Location = new System.Drawing.Point(12, 254);
            this.lbNiveau.Name = "lbNiveau";
            this.lbNiveau.Size = new System.Drawing.Size(47, 13);
            this.lbNiveau.TabIndex = 3;
            this.lbNiveau.Text = "Niveau :";
            // 
            // lbMdp
            // 
            this.lbMdp.AutoSize = true;
            this.lbMdp.Location = new System.Drawing.Point(12, 298);
            this.lbMdp.Name = "lbMdp";
            this.lbMdp.Size = new System.Drawing.Size(71, 13);
            this.lbMdp.TabIndex = 4;
            this.lbMdp.Text = "Mot de passe";
            // 
            // cbFichier
            // 
            this.cbFichier.FormattingEnabled = true;
            this.cbFichier.Location = new System.Drawing.Point(144, 24);
            this.cbFichier.Name = "cbFichier";
            this.cbFichier.Size = new System.Drawing.Size(198, 21);
            this.cbFichier.TabIndex = 5;
            // 
            // cbNiveau
            // 
            this.cbNiveau.FormattingEnabled = true;
            this.cbNiveau.Location = new System.Drawing.Point(144, 246);
            this.cbNiveau.Name = "cbNiveau";
            this.cbNiveau.Size = new System.Drawing.Size(85, 21);
            this.cbNiveau.TabIndex = 6;
            // 
            // btnLancer
            // 
            this.btnLancer.Location = new System.Drawing.Point(144, 327);
            this.btnLancer.Name = "btnLancer";
            this.btnLancer.Size = new System.Drawing.Size(144, 26);
            this.btnLancer.TabIndex = 7;
            this.btnLancer.Text = "Lancer l\'intégration";
            this.btnLancer.UseVisualStyleBackColor = true;
            // 
            // tbAnnee
            // 
            this.tbAnnee.Location = new System.Drawing.Point(144, 199);
            this.tbAnnee.Name = "tbAnnee";
            this.tbAnnee.Size = new System.Drawing.Size(85, 20);
            this.tbAnnee.TabIndex = 8;
            // 
            // clbFichier
            // 
            this.clbFichier.FormattingEnabled = true;
            this.clbFichier.Location = new System.Drawing.Point(144, 86);
            this.clbFichier.Name = "clbFichier";
            this.clbFichier.Size = new System.Drawing.Size(246, 94);
            this.clbFichier.TabIndex = 9;
            // 
            // cbAleatoire
            // 
            this.cbAleatoire.AutoSize = true;
            this.cbAleatoire.Location = new System.Drawing.Point(144, 297);
            this.cbAleatoire.Name = "cbAleatoire";
            this.cbAleatoire.Size = new System.Drawing.Size(67, 17);
            this.cbAleatoire.TabIndex = 10;
            this.cbAleatoire.Text = "Aléatoire";
            this.cbAleatoire.UseVisualStyleBackColor = true;
            // 
            // cbConstruit
            // 
            this.cbConstruit.AutoSize = true;
            this.cbConstruit.Location = new System.Drawing.Point(262, 297);
            this.cbConstruit.Name = "cbConstruit";
            this.cbConstruit.Size = new System.Drawing.Size(67, 17);
            this.cbConstruit.TabIndex = 11;
            this.cbConstruit.Text = "Construit";
            this.cbConstruit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(496, 365);
            this.Controls.Add(this.cbConstruit);
            this.Controls.Add(this.cbAleatoire);
            this.Controls.Add(this.clbFichier);
            this.Controls.Add(this.tbAnnee);
            this.Controls.Add(this.btnLancer);
            this.Controls.Add(this.cbNiveau);
            this.Controls.Add(this.cbFichier);
            this.Controls.Add(this.lbMdp);
            this.Controls.Add(this.lbNiveau);
            this.Controls.Add(this.lbAnne);
            this.Controls.Add(this.lbFichier);
            this.Controls.Add(this.lbRepertoire);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbRepertoire;
        private System.Windows.Forms.Label lbFichier;
        private System.Windows.Forms.Label lbAnne;
        private System.Windows.Forms.Label lbNiveau;
        private System.Windows.Forms.Label lbMdp;
        private System.Windows.Forms.ComboBox cbFichier;
        private System.Windows.Forms.ComboBox cbNiveau;
        private System.Windows.Forms.Button btnLancer;
        private System.Windows.Forms.TextBox tbAnnee;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.CheckedListBox clbFichier;
        private System.Windows.Forms.CheckBox cbAleatoire;
        private System.Windows.Forms.CheckBox cbConstruit;
    }
}

