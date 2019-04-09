using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace PPE
{
    public partial class FenetrePrincipale : Form
    {
        //Création d'un TableNivo 
        TableNiveau niveau = new TableNiveau();
        //Variable contenant la liste des niveaux
        List<Niveau> listeNiveaux;
        string enseignantLogin;

        public FenetrePrincipale(string enseignantLogin)
        {
            InitializeComponent();
            this.enseignantLogin = enseignantLogin;
            //On recupere les niveaux qu'on ajoute à la liste
            listeNiveaux = niveau.GetAll();
            // on affiche tous les niveau de la bdd dans la ComboBox du form
            foreach (Niveau n in listeNiveaux)
            {
                cbNiveau.Items.Add(n.GetniveauScolaire);
            }
            this.cbFichier.Click += new EventHandler(cbFichier_Click);
            this.btnLancer.Click += new EventHandler(btnLancer_Click);
        }

        void btnLancer_Click(object sender, EventArgs e)
        {
            // variable de verification 
            bool fail = true;
            // on instancie lesEleves
            LesEleves lesEleves = new LesEleves();
            //On boucle sur le nombre de fichier csv selectionné dans la checkedlistBox pour ensuite les loader
            foreach (string nomFichier in this.clbFichier.SelectedItems)
            {
                //on test ici qu'elle option du motys de passe à été selectionné
                if (this.cbAleatoire.Checked == true || this.cbConstruit.Checked == true)
                {
                    if (this.cbConstruit.Checked == true)
                    {
                        lesEleves.LoadCsv(PassWordType.construit, nomFichier, folderBrowserDialog1.SelectedPath);

                    }
                    else
                    {
                        lesEleves.LoadCsv(PassWordType.aleatoire, nomFichier, folderBrowserDialog1.SelectedPath);
                    }
                }
                //Sinon automatiquement on prend le mdp "construit"
                else
                {
                    lesEleves.LoadCsv(PassWordType.construit, nomFichier, folderBrowserDialog1.SelectedPath);
                }
                //Ici on va créer le nouveau csv avec la methode CreateCsv parametre le niveau rentré, l'année et le chemin du repertoire
                fail = false;
                lesEleves.CreateCsv(string.Format("{0}_{1}",this.cbNiveau.Text,this.tbAnnee.Text),folderBrowserDialog1.SelectedPath);
            }
            if (fail == true) {
                MessageBox.Show("Intégration fail");
            }
            else
            {
                MessageBox.Show("Intégration réussit");
            }
            // On appel la methode qui va intégrer les élèves du csv dans la bdd
            IntegrationBdd(lesEleves);

        }
        //Methode d'intégration 
        void IntegrationBdd(LesEleves lesEleves)
        {
            // on créer toutes les tables dont on va avoir besoin
            TableClasse tabClasse = new TableClasse();
            TableEnseignant tabEnseignant = new TableEnseignant();
            TableEleve tabEleve = new TableEleve();
            // on prend l'enseignant qui s'est connecté à l'appli
            Enseignant enseignant = tabEnseignant.GetByLogin(enseignantLogin);
            int idNiveau = 0;
            foreach (Niveau n in listeNiveaux)
            {
                if (n.GetniveauScolaire == this.cbNiveau.Text)
                {
                    idNiveau = n.GetId;
                }
            }
            int idClasse=tabClasse.Insert(new Classe(enseignant.Id, idNiveau, this.tbAnnee.Text));
            foreach (Eleve eleve in lesEleves.GetLesEleves)
            {
                tabEleve.Insert(eleve, idClasse);
            }
            
        }
        void cbFichier_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            cbFichier.Text = folderBrowserDialog1.SelectedPath;
            DirectoryInfo dir = new DirectoryInfo(folderBrowserDialog1.SelectedPath);
            FileInfo[] fichiers = dir.GetFiles("*.csv");
            foreach (FileInfo fichier in fichiers)
            {
                clbFichier.Items.Add(fichier.Name);
            }
        }

    }
}
