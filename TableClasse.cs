using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;


namespace PPE
{
    class TableClasse
    {
        public int Insert(Classe classe)
        {
            MySqlConnection cnx = ConnexionMysql.GetCnx;
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = cnx;
            cmd.CommandText = "insert into classe (idEnseignant,anneeScolaire,idNiveau) values (@idEnseignant,@anneeScolaire,@idNiveau);";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@idEnseignant", MySqlDbType.Int32);
            cmd.Parameters.Add("@anneeScolaire", MySqlDbType.String);
            cmd.Parameters.Add("@idNiveau", MySqlDbType.Int32);
            cmd.Parameters["@idEnseignant"].Value = classe.GetidEnseignant;
            cmd.Parameters["@anneeScolaire"].Value = classe.GetAnneeScolaire;
            cmd.Parameters["@idNiveau"].Value = classe.GetIdNiveau;
            cnx.Open();
            cmd.ExecuteNonQuery();
            cnx.Close();
            return (int)cmd.LastInsertedId;
            
        }
    }
}
