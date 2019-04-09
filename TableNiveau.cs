using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace PPE
{
    class TableNiveau
    {
        MySqlConnection cnx = ConnexionMysql.GetCnx;
        List<Niveau> list;
        public List<Niveau> GetAll()
        {
            cnx.Open();
            MySqlCommand cmd = new MySqlCommand("select * from niveau",cnx);
            MySqlDataReader data = cmd.ExecuteReader();
            list=new List<Niveau>();
            while (data.Read()){
                list.Add(new Niveau((int)data[0],(string)data[1]));
            }
            
            cnx.Close();
            data.Close();
            return list;
        }
    }
}
