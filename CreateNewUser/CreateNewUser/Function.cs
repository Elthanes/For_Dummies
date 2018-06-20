using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Amazon.Lambda.Core;
using Amazon.Lambda.APIGatewayEvents;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;


// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace CreateNewUser
{
    public class User
    {
        public int UID { get; set; }
        public String Name { get; set; }
        public String Vorname { get; set; }
        public String Handynummer { get; set; }
        public String Hausarzt { get; set; }
        public DateTime Geburtsdatum { get; set; }
        public String Immunologe { get; set; }

    }
    public class Function
    {

        /// <summary>
        /// Funktion erhält APIGatewayProxyRequest mit neuem User als Json im Körper
        /// Funktion fügt neuen User in die Usertabelle ein und legt individuelle Datentabelle an
        /// </summary>
        /// <param name="input"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public APIGatewayProxyResponse FunctionHandler(APIGatewayProxyRequest input, ILambdaContext context)
        {
            String expression = input.Body;
            User nUser = JsonConvert.DeserializeObject<User>(expression);
            MySqlConnectionStringBuilder constring = new MySqlConnectionStringBuilder
            {
                Server = "rea.cvawub2b2icc.eu-central-1.rds.amazonaws.com",
                Database = "rea",
                UserID = "root",
                Password = "password"
            };
            // SQL Befehl zum einfügen in Usertabelle
            String a = "T";
            String commString1 = "INSERT INTO allusers VALUES(@uid,@name,@vorname,@nummer,@arzt,@gbdatum,@Immuno)";
            //Anlegen der Datentabelle to be determined
            String commString2 = "CREATE TABLE T" + nUser.UID +"(datum DATETIME PRIMARY KEY, dauer INT);";
            using (MySqlConnection conn = new MySqlConnection(constring.ConnectionString))
            {
                using(MySqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = commString1;
                    cmd.Parameters.AddWithValue("@uid", nUser.UID);
                    cmd.Parameters.AddWithValue("@name", nUser.Name);
                    cmd.Parameters.AddWithValue("@vorname", nUser.Vorname);
                    cmd.Parameters.AddWithValue("@nummer", nUser.Handynummer);
                    cmd.Parameters.AddWithValue("@arzt", nUser.Hausarzt);
                    cmd.Parameters.AddWithValue("@gbdatum", nUser.Geburtsdatum);
                    cmd.Parameters.AddWithValue("@Immuno", nUser.Immunologe);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    cmd.Parameters.Clear();
                    cmd.CommandText = commString2;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

            }
            return new APIGatewayProxyResponse { Body = "Done", StatusCode = 200 };
        }
    }
}
