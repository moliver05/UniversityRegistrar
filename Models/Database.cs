using System;
using MySql.Data.MySqlClient;
using UniversityRegistrar.Solution;

namespace UniversityRegistrar.Solution.Models
{
    public class DB
    {
        public static MySqlConnection Connection()
        {
            MySqlConnection conn = new MySqlConnection(DBConfiguration.ConnectionString);
            return conn;
        }
    }
}
