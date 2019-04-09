using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PPE
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Lancement de la fenetre d'identification

            Application.Run(new Identification());

            //Mise en place de la vraible cnx afin qu'elle soit accessible partout

            MySqlConnection cnx = ConnexionMysql.GetCnx;
        }
    }
}
