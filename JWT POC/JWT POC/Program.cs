using JWT;
using JWT.Algorithms;
using JWT.Builder;
using JWT.Serializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JWT_POC
{
    class Program
    {
        public static void Main(string[] args)
        {
            //CreateJWTToken();
            string token = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJSaXNobmkiOiJSaXNobmkgdG9mYW5pIGNoaGUiLCJEaHVrZGkiOiJEaHVrZGkgbWFoYSB0b2ZhbmkgY2hoZSIsImV4cCI6MTYxODY0MzU2OSwiaWF0IjoxNjE4NjQzNDQ5fQ.vjoormcrte8xZApLsBdtvdoI3Z89pnGt1Ja5jZfSSOA";
            ValidateJWTToken(token);
            Console.ReadLine();
        }

        static void CreateJWTToken()
        {
            const string secret = "4rwegrthdr574rgFEvdbtdDSREGB57hfhg";

            //using manual way
            var payload = new Dictionary<string, object>
            {
                { "Name", "JWT token poc" },
                { "Description","doing jwt token poc to create and validate jwt token" },
                { "exp", DateTimeOffset.UtcNow.AddMinutes(2) }
            };

            //selects the algorithm to sign the token
            IJwtAlgorithm algorithm = new HMACSHA256Algorithm();
            //serializes the json payload
            //as we aare using manual way of generate jwt token and will pass the payload in json we need to serialize the json
            IJsonSerializer serializer = new JsonNetSerializer();
            //base64 encode for payload string 
            IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();

            //encoder will encode the payload into JWT token
            //it will select the algorithm which we have selected, it will use the serializer and url encoder which we have selected.
            IJwtEncoder encoder = new JwtEncoder(algorithm, serializer, urlEncoder);

            //encoder will encode the payload with secret key with selected algorith, serializer and url encoder
            var token = encoder.Encode(payload, secret);
            ////using the fluent builder api - this builder api handles almost every thing on its own so we just need to pass the params 
            //var token = JwtBuilder.Create()
            //          .WithAlgorithm(new HMACSHA256Algorithm()) // symmetric
            //          .WithSecret(secret)
            //          .AddClaim("Rishni", "Rishni tofani chhe")
            //          .AddClaim("Dhukdi","Dhukdi maha tofani chhe")
            //          .AddClaim("exp", DateTimeOffset.UtcNow.AddMinutes(2).ToUnixTimeSeconds())
            //          .AddClaim("iat",DateTimeOffset.UtcNow.ToUnixTimeSeconds())
            //          .Encode();

            Console.WriteLine(token);

        }
        static void ValidateJWTToken(string token)
        {
            const string secret = "4rwegrthdr574rgFEvdbtdDSREGB57hfhg";

            //using fluent api
            //var json = JwtBuilder.Create()
            //         .WithAlgorithm(new HMACSHA256Algorithm()) // symmetric
            //         .WithSecret(secret)
            //         //.MustVerifySignature()
            //         .Decode(token);

            //as the token will decode and convert into json so of course we need json serializer
            IJsonSerializer serializer = new JsonNetSerializer();

            //date time provider to validate the token whether its not expired
            var provider = new UtcDateTimeProvider();

            //validator to validate the token with two things serializer and provider
            IJwtValidator validator = new JwtValidator(serializer, provider);

            //api url encoder
            IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();
            
            //algorith to validate the token is generated with the same algorithm or not
            IJwtAlgorithm algorithm = new HMACSHA256Algorithm(); 

            //decoder will have all the things needed to parse the token 
            IJwtDecoder decoder = new JwtDecoder(serializer, validator, urlEncoder, algorithm);

            //Decode method will decode the actual token, will verify the time, algorithma aand secret key
            var json = decoder.Decode(token, secret, verify: true);
            Console.WriteLine(json);
        }


    }
}
