using NServiceBus;
using ServiceBus.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceBus.ClientA
{
    public class SendMessage : IWantToRunWhenBusStartsAndStops
    {
        public IBus Bus { get; set; }

        public void Start()
        {
            Console.WriteLine("Client A. Press 'Enter' to send a message2");

            while (Console.ReadLine() != null)
            {
                var id = Guid.NewGuid();

                Bus.Send("ServiceBus.Server", new FileSent() { FileId = id, Status = 1, Message = "File published in CRS" });
                //Bus.Publish<FileSent>(e => { e.FileId = id; e.Status = 1; e.Message = "File published in CRS"; });

                Console.WriteLine("======");
                Console.WriteLine("Send message for file {0}", id.ToString("N").ToUpper());
            }
        }

        public void Stop()
        {
            Console.WriteLine("Client A Stop");
        }
    }
}
