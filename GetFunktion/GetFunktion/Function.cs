using System;
using System.Data;
using Amazon.Lambda.Core;
using Amazon.Lambda.APIGatewayEvents;
using Newtonsoft.Json;
using MySql.Data.MySqlClient;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace GetFunktion
{
    public class Row
    {
        //Füllen mit Attributen beispiel
        public DateTime Datum { get; set; }
        public int Dauer { get; set; }
        public String UID { get; set; }
    }
    public class Req
    {
        public String What { get; set; }
        public String Where { get; set; }
        public String Which { get; set; }
    }
    public class Function
    {
        
        /// <summary>
        /// A simple function that takes a string and does a ToUpper
        /// </summary>
        /// <param name="input"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public APIGatewayProxyResponse FunctionHandler(APIGatewayProxyRequest input, ILambdaContext context)
        {
            String expression = input.Body;
            Req mine = JsonConvert.DeserializeObject<Req>(expression);
            //Create Connection String securely
            MySqlConnectionStringBuilder anta = new MySqlConnectionStringBuilder
            {
                Server = "rea.cvawub2b2icc.eu-central-1.rds.amazonaws.com",
                Database = "rea",
                UserID = "root",
                Password = "password"
            };
            String commString = "SELECT @what FROM @where WHERE @which";
            //create connection
            using (MySqlConnection conn = new MySqlConnection(anta.ConnectionString))
            {
                using(MySqlCommand cmd = conn.CreateCommand())
                {
                    //Specify Command
                    cmd.CommandText = commString;
                    cmd.Parameters.AddWithValue("@what", mine.What);
                    cmd.Parameters.AddWithValue("@where", mine.Where);
                    cmd.Parameters.AddWithValue("@which", mine.Which);
                    conn.Open();
                    ///Execute Reader or NonQuery
                    ///
                    MySqlDataReader reader = cmd.ExecuteReader();
                    DataTable dummy = new DataTable();
                    dummy.Load(reader);

                    conn.Close();
                }
            }

            APIGatewayProxyResponse result = new APIGatewayProxyResponse();
            return result;
        }
    }
}
