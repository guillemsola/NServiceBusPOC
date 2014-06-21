using NServiceBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceBus.Messages
{
    public class FileSent : ICommand
    {
        public Guid FileId { get; set; }
        public int Status { get; set; }
        public string Message { get; set; }
    }
}
