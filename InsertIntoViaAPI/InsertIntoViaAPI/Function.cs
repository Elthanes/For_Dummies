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

namespace InsertIntoViaAPI
{
    //Abstraktion einer Reihe in der User spezifischen SQL Datenbank als Objekt + identifier(möglicherweiße ändern)
    public class Row
    {
        //Füllen mit Attributen beispiel
        public DateTime Datum { get; set; }
        public int Dauer { get; set; }
        public String UID { get; set; }
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
            List<Row> rows = JsonConvert.DeserializeObject<List<Row>>(expression);
            int changes = 0;
            MySqlConnectionStringBuilder anta = new MySqlConnectionStringBuilder
            {
                Server = "rea.cvawub2b2icc.eu-central-1.rds.amazonaws.com",
                Database = "rea",
                UserID = "root",
                Password = "password"
            };
            String addstring = "INSERT INTO @table VALUES(@datum,@dauer);";
            using (MySqlConnection conn = new MySqlConnection(anta.ConnectionString))
            {
                foreach(Row my in rows)
                {
                    using(MySqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = addstring;
                        cmd.Parameters.AddWithValue("@table", my.UID);
                        cmd.Parameters.AddWithValue("@datum", my.Datum);
                        cmd.Parameters.AddWithValue("@dauer", my.Dauer);
                        conn.Open();
                        changes += cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }
            }

            APIGatewayProxyResponse result = new APIGatewayProxyResponse();
            result.Body = changes.ToString() + " Rows have been added";
            return result;
        }
    }
}
