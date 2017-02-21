using System;
using System.Collections.Generic;
using Twilio.Base;

namespace Twilio.Rest.Preview.Wireless 
{

    /// <summary>
    /// FetchCommandOptions
    /// </summary>
    public class FetchCommandOptions : IOptions<CommandResource> 
    {
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }
    
        /// <summary>
        /// Construct a new FetchCommandOptions
        /// </summary>
        ///
        /// <param name="pathSid"> The sid </param>
        public FetchCommandOptions(string pathSid)
        {
            PathSid = pathSid;
        }
    
        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    /// <summary>
    /// ReadCommandOptions
    /// </summary>
    public class ReadCommandOptions : ReadOptions<CommandResource> 
    {
        /// <summary>
        /// The device
        /// </summary>
        public string Device { get; set; }
        /// <summary>
        /// The sim
        /// </summary>
        public string Sim { get; set; }
        /// <summary>
        /// The status
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// The direction
        /// </summary>
        public string Direction { get; set; }
    
        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Device != null)
            {
                p.Add(new KeyValuePair<string, string>("Device", Device));
            }
            
            if (Sim != null)
            {
                p.Add(new KeyValuePair<string, string>("Sim", Sim));
            }
            
            if (Status != null)
            {
                p.Add(new KeyValuePair<string, string>("Status", Status));
            }
            
            if (Direction != null)
            {
                p.Add(new KeyValuePair<string, string>("Direction", Direction));
            }
            
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }
            
            return p;
        }
    }

    /// <summary>
    /// CreateCommandOptions
    /// </summary>
    public class CreateCommandOptions : IOptions<CommandResource> 
    {
        /// <summary>
        /// The command
        /// </summary>
        public string Command { get; }
        /// <summary>
        /// The device
        /// </summary>
        public string Device { get; set; }
        /// <summary>
        /// The sim
        /// </summary>
        public string Sim { get; set; }
        /// <summary>
        /// The callback_method
        /// </summary>
        public string CallbackMethod { get; set; }
        /// <summary>
        /// The callback_url
        /// </summary>
        public Uri CallbackUrl { get; set; }
        /// <summary>
        /// The command_mode
        /// </summary>
        public string CommandMode { get; set; }
        /// <summary>
        /// The include_sid
        /// </summary>
        public string IncludeSid { get; set; }
    
        /// <summary>
        /// Construct a new CreateCommandOptions
        /// </summary>
        ///
        /// <param name="command"> The command </param>
        public CreateCommandOptions(string command)
        {
            Command = command;
        }
    
        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Command != null)
            {
                p.Add(new KeyValuePair<string, string>("Command", Command));
            }
            
            if (Device != null)
            {
                p.Add(new KeyValuePair<string, string>("Device", Device));
            }
            
            if (Sim != null)
            {
                p.Add(new KeyValuePair<string, string>("Sim", Sim));
            }
            
            if (CallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("CallbackMethod", CallbackMethod));
            }
            
            if (CallbackUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("CallbackUrl", CallbackUrl.ToString()));
            }
            
            if (CommandMode != null)
            {
                p.Add(new KeyValuePair<string, string>("CommandMode", CommandMode));
            }
            
            if (IncludeSid != null)
            {
                p.Add(new KeyValuePair<string, string>("IncludeSid", IncludeSid));
            }
            
            return p;
        }
    }

}