using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;


namespace AzFunctionwithServicebus
{
    public class ServiceBusQueueFunc
    {

        [FunctionName("ServicebusQueueFunc")]
        public static void Run([ServiceBusTrigger("testq", Connection = "connectionString")] string myQueueItem, ILogger log)
        {
            log.LogInformation($"C# ServiceBus queue trigger function processed message: {myQueueItem}");
            //Console.WriteLine(myQueueItem);
        }
    }
}
