using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Amazon.Lambda.Core;
using System.IdentityModel.Tokens.Jwt;
using Amazon.Lambda.APIGatewayEvents;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace TokenDecode
{
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
            String output ="";
            JwtSecurityTokenHandler myhandler = new JwtSecurityTokenHandler();
            var token =myhandler.ReadJwtToken(input.Body);
            var claims = token.Claims;
            foreach(var c in claims)
            {
                if (c.Type.Equals("cognito:username"))
                {
                    output = c.Value;
                }
            }
            APIGatewayProxyResponse result = new APIGatewayProxyResponse
            {
                StatusCode = 200,
                Body = output
            };
            return result;
        }
    }
}
