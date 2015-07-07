// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EndpointConfig.cs" company="GSA">
//   Guillem Solà
// </copyright>
// <summary>
//   Defines the SendMessage type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ServiceBus.Server
{
    using NServiceBus;

    /// <summary>
    /// The endpoint config.
    /// </summary>
    public class EndpointConfig : IConfigureThisEndpoint, AsA_Server
    {
        /// <summary>
        /// The customize.
        /// </summary>
        /// <param name="configuration">
        /// The configuration.
        /// </param>
        public void Customize(BusConfiguration configuration)
        {
            configuration.UsePersistence<InMemoryPersistence>();
            configuration.UseTransport<RabbitMQTransport>();
        }
    }
}
