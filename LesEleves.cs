using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace PPE
{
    class LesEleves
    {
        List<Eleve> lesEleves = new List<Eleve>();
        public List<Eleve> GetLesEleves
        {
            get
            {
                return lesEleves;
            }
        }
        public List<Eleve> LoadCsv(PassWordType type,string nomFichier,string path)
        {
            string s = string.Format("{0}/{1}", path,nomFichier);
            StreamReader reader = new StreamReader(s);

            while (!reader.EndOfStream)
            {
                var ligne = reader.ReadLine();
                var values = ligne.Split(';');
                string login = string.Format(values[0] + values[1] + "@sio.jjr");
                lesEleves.Add(new Eleve(values[0], values[1], login, type));
                
            }
            return lesEleves;



        }
        public void CreateCsv(string nomFichier,string path)
        {
            string s = string.Format("{0}/{1}.csv", path, nomFichier);
            StreamWriter file = new StreamWriter(s);
            file.WriteLine("login ; password");
            for (int i = 0; i < lesEleves.Count; i++)
            {
                file.WriteLine("{0};{1}", lesEleves[i].Login, lesEleves[i].Password);
            }
            file.Close();
        }


    }

}
