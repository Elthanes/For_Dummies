using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Amazon.Lambda.Core;
using Amazon.Lambda.APIGatewayEvents;
using System;
using System.Net.Http;


// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace CredentialsTest
{
    public class Function
    {
        public APIGatewayProxyResponse FunctionHandler(APIGatewayProxyRequest input, ILambdaContext context)
        {
            
            input.Headers.TryGetValue("Authorization", out String to);
            String res;
            using (HttpClient client = new HttpClient())
            {
                String url = "https://7ss3rsj2og.execute-api.eu-central-1.amazonaws.com/Eh/TokenDecode";
                var content = new StringContent(to, System.Text.Encoding.UTF8, "text/plain");
                using (var response = client.PostAsync(url, content).Result)
                {
                    res = response.Content.ReadAsStringAsync().Result;
                }
            }
            APIGatewayProxyResponse result = new APIGatewayProxyResponse
            {
                StatusCode = 200,
                Headers = input.Headers,
                Body = res
            };
            return result;
        }
    }
}
