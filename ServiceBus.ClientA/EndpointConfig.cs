// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EndpointConfig.cs" company="GSA">
//   Guillem Solà
// </copyright>
// <summary>
//   Defines the SendMessage type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ServiceBus.ClientA
{
    using NServiceBus;

    /// <summary>
    /// The endpoint config.
    /// </summary>
    public class EndpointConfig : IConfigureThisEndpoint, AsA_Client
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
        }
    }
}
