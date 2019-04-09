using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PPE
{
    class Eleve
    {
        string nom, prenom, login, passWord;
        static Random random = new Random();

        public Eleve(string prenom, string nom, string login,PassWordType type)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.login = login;
            this.passWord = GeNewPassWord(type);

        }
        static private string GetPasswordAleatoire()
        {
            string mdpAleatoire = "";
            
            List<string> choix = new List<string> { "minuscule", "majuscule", "chiffre", "special", "lettre", "lettre", "lettre", "lettre", "lettre" };
            char[] minuscule = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            char[] majuscule = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            char[] chiffre = "123456789".ToCharArray();
            char[] special = "#-_^@".ToCharArray();
            while (mdpAleatoire.Count() != 9)
            {
                int i = random.Next(choix.Count);
                switch (choix[i])
                {
                    case "minuscule":
                        choix.RemoveAt(i);
                        mdpAleatoire += minuscule[random.Next(minuscule.Length)];
                        break;
                    case "majuscule":
                        choix.RemoveAt(i);
                        mdpAleatoire += majuscule[random.Next(majuscule.Length)];
                        break;
                    case "chiffre":
                        choix.RemoveAt(i);
                        mdpAleatoire += chiffre[random.Next(chiffre.Length)];
                        break;
                    case "special":
                        choix.RemoveAt(i);
                        mdpAleatoire += special[random.Next(special.Length)];
                        break;
                    case "lettre":
                        choix.RemoveAt(i);
                        switch (random.Next(1))
                        {
                            case 1:
                                mdpAleatoire += majuscule[random.Next(majuscule.Length)];
                                break;
                            case 0:
                                mdpAleatoire += minuscule[random.Next(minuscule.Length)];
                                break;
                        }
                        break;
                }
            }
            return mdpAleatoire;
        }
        private string GetPassWordConstruit()
        {
            return string.Format(this.prenom[0] + this.nom);
            
        }
        public string GeNewPassWord(PassWordType type)
        {
            string mdp;
            switch (type)
            {
                case PassWordType.aleatoire:
                    mdp = GetPasswordAleatoire();
                    break;
                case PassWordType.construit:
                    mdp = GetPassWordConstruit();
                    break;
                default:
                    mdp = GetPasswordAleatoire();
                    break;
            }
            return mdp;
        }


        //###################################################Accesseur#######################################################
        public string Nom
        {
            get
            {
                return this.nom;
            }
        }
        public string Prenom
        {
            get
            {
                return this.prenom;
            }
        }
        public string Login
        {
            get
            {
                return this.login;
            }
        }
        public string Password
        {
            get
            {
                return this.passWord;
            }
        }
        
        
    }
}
