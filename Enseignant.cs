using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PPE
{
    class Enseignant
    {
        int id, idAuth;

        
        string nom, prenom, login, hashPassWord;
        public int Id
        {
            get
            {
                return this.id;
            }
        }
        public int IdAuth
        {
            get { return idAuth; }
        }
        public string HashPassWord
        {
            get{
                return this.hashPassWord;
            }
        }
        public Enseignant(int id,string nom, string prenom, string login, string hashPassWord,int idAuth) {
            this.id = id;
            this.idAuth = idAuth;
            this.nom = nom;
            this.prenom = prenom;
            this.login = login;
            this.hashPassWord = hashPassWord;
        }
        public Enseignant()
        {
        }
    }
}
