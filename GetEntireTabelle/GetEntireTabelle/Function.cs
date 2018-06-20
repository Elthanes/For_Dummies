using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;

using Amazon.Lambda.Core;
using Amazon.Lambda.APIGatewayEvents;
using Newtonsoft.Json;
using MySql.Data.MySqlClient;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace GetEntireTabelle
{
    public class RowUsers
    {
        public int UID { get; set; }
        public String Name { get; set; }
        public String Vorname { get; set; }
        public String Handynummer { get; set; }
        public String Hausarzt { get; set; }
        public DateTime Geburtsdatum { get; set; }
        public String Immunologe { get; set; }
    }
    public class RowData
    {
        public DateTime Datum { get; set; }
        public int Dauer { get; set; }
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
            //Create Connection String securely

            APIGatewayProxyResponse result = new APIGatewayProxyResponse();
            MySqlConnectionStringBuilder anta = new MySqlConnectionStringBuilder
            {
                Server = "rea.cvawub2b2icc.eu-central-1.rds.amazonaws.com",
                Database = "rea",
                UserID = "root",
                Password = "password"
            };
            String expression = input.Body;
            String command = "SELECT * FROM " + expression;

            DataTable tb = new DataTable();
            //create connection
            using (MySqlConnection conn = new MySqlConnection(anta.ConnectionString))
            {
                using (MySqlCommand cmd = conn.CreateCommand())
                {

                    //Specify Command
                    cmd.CommandText = command;
                    if (expression.Equals("allusers"))
                    {
                        List<RowUsers> rows = new List<RowUsers>();
                        conn.Open();
                        ///Execute Reader or NonQuery
                        ///            
                        MySqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            rows.Add(new RowUsers
                            {
                                UID = (int)reader["uid"],
                                Name = (String)reader["name"],
                                Vorname = (String)reader["vorname"],
                                Handynummer = (String)reader["handynummer"],
                                Hausarzt = (String)reader["hausarzt"],
                                Geburtsdatum = (DateTime)reader["geburtsdatum"],
                                Immunologe = (String)reader["immunologe"]
                            });
                        }
                        reader.Close();
                        conn.Close();
                        result.Body = JsonConvert.SerializeObject(rows);
                    }
                    else
                    {
                        List<RowData> rows = new List<RowData>();
                        conn.Open();
                        ///Execute Reader or NonQuery
                        ///            
                        MySqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            rows.Add(new RowData
                            {
                                Datum = (DateTime)reader["datum"],
                                Dauer = (int)reader["dauer"]
                            });
                        }
                        reader.Close();
                        conn.Close();
                        result.Body = JsonConvert.SerializeObject(rows);
                    }
                }
            }
            result.StatusCode = 200;
            return result;
    }
}
}
