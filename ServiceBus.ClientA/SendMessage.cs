// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SendMessage.cs" company="GSA">
//   Guillem Solà
// </copyright>
// <summary>
//   Defines the SendMessage type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ServiceBus.ClientA
{
    using System;

    using NServiceBus;

    using ServiceBus.Messages;

    /// <summary>
    /// The send message.
    /// </summary>
    public class SendMessage : IWantToRunWhenBusStartsAndStops
    {
        /// <summary>
        /// Gets or sets the bus.
        /// </summary>
        public IBus Bus { get; set; }

        /// <summary>
        /// The start.
        /// </summary>
        public void Start()
        {
            Console.WriteLine("Client A. Press 'Enter' to send a message2");

            while (Console.ReadLine() != null)
            {
                var id = Guid.NewGuid();

                this.Bus.Send("ServiceBus.Server", new FileSent { FileId = id, Status = 1, Message = "File published in CRS" });
                
                // Bus.Publish<FileSent>(e => { e.FileId = id; e.Status = 1; e.Message = "File published in CRS"; });
                Console.WriteLine("======");
                Console.WriteLine("Send message for file {0}", id.ToString("N").ToUpper());
            }
        }

        /// <summary>
        /// The stop.
        /// </summary>
        public void Stop()
        {
            Console.WriteLine("Client A Stop");
        }
    }
}
