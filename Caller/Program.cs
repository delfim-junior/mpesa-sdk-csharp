using System;
using System.Threading.Tasks;
using MPesa;
using Environment = MPesa.Environment;

namespace Caller
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var client = new Client.Builder()
                .ApiKey("ApiKeyExample")
                .PublicKey("PublicKeyExample")
                .ServiceProviderCode("ServiceProviderExample")
                .InitiatorIdentifier("InitiatorIdentifierExample")
                .Environment(Environment.Development)
                .Build();

            var paymentRequest = new Request.Builder()
                .Amount(10.0)
                .From("841234567")
                .Reference("12345")
                .Transaction("12345")
                .Build();

            //Async
            try
            {
                var response = await client.Receive(paymentRequest);
                //Handle Success Scenario
            }
            catch (Exception e)
            {
                //Handle Failure Scenario
            }




        }
    }
}