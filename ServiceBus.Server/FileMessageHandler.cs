// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FileMessageHandler.cs" company="GSA">
//   Guillem Solà
// </copyright>
// <summary>
//   Defines the SendMessage type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ServiceBus.Server
{
    using System;

    using NServiceBus;

    using ServiceBus.Messages;

    /// <summary>
    /// The file message handler.
    /// </summary>
    public class FileMessageHandler : IHandleMessages<FileSent>
    {
        /// <summary>
        /// Gets or sets the bus.
        /// </summary>
        public IBus Bus { get; set; }

        /// <summary>
        /// The handle.
        /// </summary>
        /// <param name="message">
        /// The message.
        /// </param>
        public void Handle(FileSent message)
        {
            Console.WriteLine("Detected file {0} with id {1}", message.FileId, message.Message);
        }
    }
}
