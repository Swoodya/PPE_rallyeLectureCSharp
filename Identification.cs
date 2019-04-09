using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PPE
{
    public partial class Identification : Form
    {
        // constructeur 

        public Identification()
        {
            InitializeComponent();
            // association btnConnexion et methode 
            btnConnexion.Click += new EventHandler(btnConnexion_Click);
            //association btn et entrée pour la fenetre 
            btnConnexion.Focus();
        }
        
        
        void btnConnexion_Click(object sender, EventArgs e)
        {
            // Creation d'une Tablenseignant 
            TableEnseignant tEnseignant = new TableEnseignant();
            //créa enseignant avec l'enseignant renvoyé par la fonction
            Enseignant enseignant = tEnseignant.GetByLogin(this.tbUtilisateur.Text);

            //test si le mdp hashe de enseignant est = au mdp hashe rentré dans le form
            if (enseignant.HashPassWord == (string)Hash.GetSha256FromString(tbPass.Text, enseignant.IdAuth))
            {
                MessageBox.Show("Connexion Réussie !");
                //affichage de la fenetree principale
                new FenetrePrincipale(tbUtilisateur.Text).Show();
                //cahche de la fen identification
                this.Hide();
            }
            //si test est faux on affiche erreur
            else
            {
                MessageBox.Show("Erreur login / mdp");
            }
        }
            

        
    }
}
