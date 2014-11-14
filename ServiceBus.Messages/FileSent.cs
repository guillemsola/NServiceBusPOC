// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FileSent.cs" company="GSA">
//   Guillem Solà
// </copyright>
// <summary>
//   Defines the SendMessage type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ServiceBus.Messages
{
    using System;

    using NServiceBus;

    public class FileSent : ICommand
    {
        /// <summary>
        /// Gets or sets the file id.
        /// </summary>
        public Guid FileId { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        public string Message { get; set; }
    }
}
