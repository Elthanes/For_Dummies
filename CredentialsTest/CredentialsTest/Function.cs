using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Amazon.Lambda.Core;
using Amazon.Lambda.APIGatewayEvents;
using RestSharp;


// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace CredentialsTest
{
    public class Function
    {
        public APIGatewayProxyResponse FunctionHandler(APIGatewayProxyRequest input, ILambdaContext context)
        {
            String res = "";
            RestClient cli = new RestClient("https://7ss3rsj2og.execute-api.eu-central-1.amazonaws.com/Eh/TokenDecode/");
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "text/plain");
            request.AddBody(input.Body);
            var response = cli.Execute(request);
            res = response.Content;
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
