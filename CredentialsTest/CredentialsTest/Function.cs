using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Amazon.Lambda.Core;
using Amazon.Lambda.APIGatewayEvents;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace CredentialsTest
{
    public class Function
    {
        public APIGatewayProxyResponse FunctionHandler(APIGatewayProxyRequest input, ILambdaContext context)
        {
            String header = "AccID:" + input.RequestContext.AccountId + " Ident:" + input.RequestContext.Identity.UserArn + " or " + input.RequestContext.Identity.User;

            APIGatewayProxyResponse result = new APIGatewayProxyResponse
            {
                StatusCode = 200,
                Headers = input.Headers,
                Body = input.Body +";;;" + header
            };
            return result;
        }
    }
}
