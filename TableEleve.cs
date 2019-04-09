using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace PPE
{
    class TableEleve
    {
        MySqlConnection cnx = ConnexionMysql.GetCnx;
        
        MySqlDataReader data;


        public void Insert(Eleve eleve,int idClasse)
        {
            
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = cnx;
            cmd.CommandText = "select max(id) from aauth_users";
            cmd.CommandType = CommandType.Text;
            cnx.Open();
            int idAuth = ( Convert.ToInt32(cmd.ExecuteScalar()) + 1);
            cmd.CommandText = "insert into aauth_users(email,pass) values(@username,@pass)";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@username", MySqlDbType.String);
            cmd.Parameters.Add("@pass", MySqlDbType.String);
            cmd.Parameters["@username"].Value = eleve.Login;
            cmd.Parameters["@pass"].Value = Hash.GetSha256FromString(eleve.Password,idAuth);
            cmd.ExecuteNonQuery();
            cmd.CommandText = "insert into aauth_user_to_group values(@user_id,4);";
            cmd.Parameters.Add("@user_id", MySqlDbType.Int32);
            cmd.Parameters["@user_id"].Value = idAuth;
            cmd.ExecuteNonQuery();
            cmd.CommandText = "insert into eleve(idClasse,nom,prenom,login,idAuth) values(@idClasse,@nom,@prenom,@login,@idAuth);";
            cmd.Parameters.Add("@idClasse", MySqlDbType.Int32);
            cmd.Parameters.Add("@nom", MySqlDbType.String);
            cmd.Parameters.Add("@prenom", MySqlDbType.String);
            cmd.Parameters.Add("@idAuth", MySqlDbType.Int32);
            cmd.Parameters.Add("@login", MySqlDbType.String);
            cmd.Parameters["@idClasse"].Value=idClasse;
            cmd.Parameters["@nom"].Value = eleve.Nom;
            cmd.Parameters["@prenom"].Value = eleve.Prenom;
            cmd.Parameters["@login"].Value = eleve.Login;
            cmd.Parameters["@idAuth"].Value = idAuth;
            cmd.ExecuteNonQuery();
            cnx.Close();
            
            

        }
       

    }
}
