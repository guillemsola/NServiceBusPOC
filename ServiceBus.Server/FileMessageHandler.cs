using NServiceBus;
using ServiceBus.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceBus.Server
{
    public class FileMessageHandler : IHandleMessages<FileSent>
    {
        public IBus Bus { get; set; }

        public void Handle(FileSent message)
        {
            Console.WriteLine("Detected file {0} with id {1}", message.FileId, message.Message);
        }
    }
}
