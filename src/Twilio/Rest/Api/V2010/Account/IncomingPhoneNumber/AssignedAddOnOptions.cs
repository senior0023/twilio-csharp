using System;
using System.Collections.Generic;
using Twilio.Base;

namespace Twilio.Rest.Api.V2010.Account.IncomingPhoneNumber 
{

    /// <summary>
    /// Fetch an instance of an Add-on installation currently assigned to this Number.
    /// </summary>
    public class FetchAssignedAddOnOptions : IOptions<AssignedAddOnResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// The resource_sid
        /// </summary>
        public string PathResourceSid { get; }
        /// <summary>
        /// The unique Installed Add-on Sid
        /// </summary>
        public string PathSid { get; }
    
        /// <summary>
        /// Construct a new FetchAssignedAddOnOptions
        /// </summary>
        ///
        /// <param name="pathResourceSid"> The resource_sid </param>
        /// <param name="pathSid"> The unique Installed Add-on Sid </param>
        public FetchAssignedAddOnOptions(string pathResourceSid, string pathSid)
        {
            PathResourceSid = pathResourceSid;
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
    /// Retrieve a list of Add-on installations currently assigned to this Number.
    /// </summary>
    public class ReadAssignedAddOnOptions : ReadOptions<AssignedAddOnResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// The resource_sid
        /// </summary>
        public string PathResourceSid { get; }
    
        /// <summary>
        /// Construct a new ReadAssignedAddOnOptions
        /// </summary>
        ///
        /// <param name="pathResourceSid"> The resource_sid </param>
        public ReadAssignedAddOnOptions(string pathResourceSid)
        {
            PathResourceSid = pathResourceSid;
        }
    
        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }
            
            return p;
        }
    }

    /// <summary>
    /// Assign an Add-on installation to the Number specified.
    /// </summary>
    public class CreateAssignedAddOnOptions : IOptions<AssignedAddOnResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// The resource_sid
        /// </summary>
        public string PathResourceSid { get; }
        /// <summary>
        /// A string that uniquely identifies the Add-on installation
        /// </summary>
        public string InstalledAddOnSid { get; }
    
        /// <summary>
        /// Construct a new CreateAssignedAddOnOptions
        /// </summary>
        ///
        /// <param name="pathResourceSid"> The resource_sid </param>
        /// <param name="installedAddOnSid"> A string that uniquely identifies the Add-on installation </param>
        public CreateAssignedAddOnOptions(string pathResourceSid, string installedAddOnSid)
        {
            PathResourceSid = pathResourceSid;
            InstalledAddOnSid = installedAddOnSid;
        }
    
        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (InstalledAddOnSid != null)
            {
                p.Add(new KeyValuePair<string, string>("InstalledAddOnSid", InstalledAddOnSid.ToString()));
            }
            
            return p;
        }
    }

    /// <summary>
    /// Remove the assignment of an Add-on installation from the Number specified.
    /// </summary>
    public class DeleteAssignedAddOnOptions : IOptions<AssignedAddOnResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// The resource_sid
        /// </summary>
        public string PathResourceSid { get; }
        /// <summary>
        /// The Installed Add-on Sid to remove
        /// </summary>
        public string PathSid { get; }
    
        /// <summary>
        /// Construct a new DeleteAssignedAddOnOptions
        /// </summary>
        ///
        /// <param name="pathResourceSid"> The resource_sid </param>
        /// <param name="pathSid"> The Installed Add-on Sid to remove </param>
        public DeleteAssignedAddOnOptions(string pathResourceSid, string pathSid)
        {
            PathResourceSid = pathResourceSid;
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

}