using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PPE
{
    class Niveau
    {
        int id;
        string niveauScolaire;

        //###################################################Accesseur#######################################################
        public Niveau(int id, string nivo)
        {
            this.id = id;
            this.niveauScolaire = nivo;
        }
     
        public int GetId{
            get
            {
                return this.id;
            }
        }
        public string GetniveauScolaire
        {
            get
            {
                return this.niveauScolaire;
            }

        }

    }
}
