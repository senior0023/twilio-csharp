#if NET40
using System.Threading.Tasks;
#endif
using Twilio.Clients;

namespace Twilio.Base
{
    /// <summary>
    /// Executor for deletion of a resource.
    /// </summary>
    /// <typeparam name="T">Type of the resource</typeparam>
    public abstract class Deleter<T> where T : Resource
    {
        #if NET40
        /// <summary>
        /// Execute an async request using the default client.
        /// </summary>
        /// <returns>Task that resolves to requested object</returns>
        public Task ExecuteAsync() {
            return ExecuteAsync(TwilioClient.GetRestClient());
        }

        /// <summary>
        /// Execute an async request using a custom client.
        /// </summary>
        /// <param name="client">Custom client to use</param>
        /// <returns>Task that resolves to requested object</returns>
        public abstract Task ExecuteAsync(ITwilioRestClient client);
        #endif

        /// <summary>
        /// Execute a request using the default client.
        /// </summary>
        /// <returns>Requested object</returns>
        public void Execute() {
            Execute(TwilioClient.GetRestClient());
        }

        /// <summary>
        /// Execute a request using a custom client.
        /// </summary>
        /// <param name="client">Custom client to use</param>
        /// <returns>Requested object</returns>
        public abstract void Execute(ITwilioRestClient client);
    }
}