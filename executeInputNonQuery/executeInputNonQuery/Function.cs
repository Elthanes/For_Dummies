using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Amazon.Lambda.Core;
using MySql.Data;
using MySql.Data.MySqlClient;
// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace executeInputNonQuery
{
    public class Function
    {
        
        /// <summary>
        /// A simple function that takes a string and does a ToUpper
        /// </summary>
        /// <param name="input"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public string FunctionHandler(string input, ILambdaContext context)
        {
            string result = "nothing happened";
            string connectionString = "Server:rea.cvawub2b2icc.eu-central-1.rds.amazonaws.com;Database=rea;Uid=root;Pwd=password";
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(input,conn);
            result =cmd.ExecuteNonQuery().ToString();
            conn.Close();
            return result;
        }
    }
}
