using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore;

using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

namespace IO.Swagger
{
    /// <summary>
    /// Program
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            Console.WriteLine(" [!] Preparing the Rabbit...");
            var factory = new ConnectionFactory() { HostName = "rabbitmq.application.dev", UserName = "pernalonga", Password = "eAiVelhinho"};
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.QueueDeclare(queue: "team",
                                     durable: false,
                                     exclusive: false,
                                     autoDelete: false,
                                     arguments: null);

                var consumer = new EventingBasicConsumer(channel);
                consumer.Received += (model, ea) => {
                    var body = ea.Body;
                    var message = Encoding.UTF8.GetString(body);
                    Console.WriteLine(" [x] Received {0}", message);
                };
                channel.BasicConsume(queue: "team",
                                     autoAck: true,
                                     consumer: consumer);
                 // Console.WriteLine(" [!] Waiting for Events...");
                 // Console.WriteLine(" Press [enter] to exit.");
                 // Console.ReadLine();
                 BuildWebHost(args).Run();
            }
            // Posicao original no Run()
            //BuildWebHost(args).Run();
        }

        /// <summary>
        /// Build Web Host
        /// </summary>
        /// <param name="args"></param>
        /// <returns>Webhost</returns>
        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .UseUrls("http://*:5001")
                .Build();
    }
}
