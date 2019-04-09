using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace PPE
{
    class TableEnseignant
    {
        MySqlConnection cnx=ConnexionMysql.GetCnx;
        MySqlCommand cmd=new MySqlCommand();
        
        MySqlDataReader data;


        public Enseignant GetByLogin(string login) {
            cmd.Connection = cnx;
            cmd.CommandText = "select e.id,nom,prenom,a.email,pass,idAuth from enseignant e inner join aauth_users a on e.idAuth=a.id where a.email = @login";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@login", MySqlDbType.String);
            cmd.Parameters["@login"].Value = login;
            cnx.Open();
            data=cmd.ExecuteReader();
            data.Read();
            try
            {
                Enseignant e = new Enseignant((int)data[0], (string)data[1], (string)data[2], (string)data[3], (string)data[4], (int)data[5]);
                cnx.Close();
                return e;
            }
            catch
            {
                cnx.Close();
                return new Enseignant();
            }
        }
    }
}
