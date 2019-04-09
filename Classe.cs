using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PPE
{
    class Classe
    {
        int idEnseignant, idNiveau;
        string anneeScolaire;
        public Classe(int idEnseignant, int idNiveau, string anneeScolaire) {
            this.idEnseignant = idEnseignant;
            this.anneeScolaire = anneeScolaire;
            this.idNiveau = idNiveau;
        }
        //###################################################Accesseur#######################################################
        public int GetidEnseignant
        {
            get
            {
                return this.idEnseignant;
            }
        }
        public int GetIdNiveau
        {
            get {
                return this.idNiveau;
            }
        }
        public string GetAnneeScolaire
        {
            get
            {
                return this.anneeScolaire;
            }
        }
    }

}
