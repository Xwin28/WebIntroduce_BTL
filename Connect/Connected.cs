using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WebAPI_Form.Connect
{
    public class Connected
    {
        public static MySqlConnection GetDBConnection()
        {

            // Connection String.
            string host = "127.0.0.1";
            int port = 3306;
            string database = "webintroduce";
            string username = "root";
            string password = "1234";
            // Connection String.
            String connString = "Server=" + host + ";Database=" + database
                + ";port=" + port + ";User Id=" + username + ";password=" + password;
            MySqlConnection conn;
            //String connString = @"server=localhost;user id=root;persistsecurityinfo=True;database=loginservice";
            conn = new MySqlConnection(connString);

            return conn;
        }
    }
}