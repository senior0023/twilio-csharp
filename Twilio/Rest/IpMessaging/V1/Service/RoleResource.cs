using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Types;

namespace Twilio.Rest.IpMessaging.V1.Service 
{

    public class RoleResource : Resource 
    {
        public sealed class RoleTypeEnum : StringEnum 
        {
            private RoleTypeEnum(string value) : base(value) {}
            public RoleTypeEnum() {}
        
            public static RoleTypeEnum Channel = new RoleTypeEnum("channel");
            public static RoleTypeEnum Deployment = new RoleTypeEnum("deployment");
        }
    
        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="serviceSid"> The service_sid </param>
        /// <param name="sid"> The sid </param>
        /// <returns> RoleFetcher capable of executing the fetch </returns> 
        public static RoleFetcher Fetcher(string serviceSid, string sid)
        {
            return new RoleFetcher(serviceSid, sid);
        }
    
        /// <summary>
        /// delete
        /// </summary>
        ///
        /// <param name="serviceSid"> The service_sid </param>
        /// <param name="sid"> The sid </param>
        /// <returns> RoleDeleter capable of executing the delete </returns> 
        public static RoleDeleter Deleter(string serviceSid, string sid)
        {
            return new RoleDeleter(serviceSid, sid);
        }
    
        /// <summary>
        /// create
        /// </summary>
        ///
        /// <param name="serviceSid"> The service_sid </param>
        /// <param name="friendlyName"> The friendly_name </param>
        /// <param name="type"> The type </param>
        /// <param name="permission"> The permission </param>
        /// <returns> RoleCreator capable of executing the create </returns> 
        public static RoleCreator Creator(string serviceSid, string friendlyName, RoleResource.RoleTypeEnum type, List<string> permission)
        {
            return new RoleCreator(serviceSid, friendlyName, type, permission);
        }
    
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="serviceSid"> The service_sid </param>
        /// <returns> RoleReader capable of executing the read </returns> 
        public static RoleReader Reader(string serviceSid)
        {
            return new RoleReader(serviceSid);
        }
    
        /// <summary>
        /// update
        /// </summary>
        ///
        /// <param name="serviceSid"> The service_sid </param>
        /// <param name="sid"> The sid </param>
        /// <param name="permission"> The permission </param>
        /// <returns> RoleUpdater capable of executing the update </returns> 
        public static RoleUpdater Updater(string serviceSid, string sid, List<string> permission)
        {
            return new RoleUpdater(serviceSid, sid, permission);
        }
    
        /// <summary>
        /// Converts a JSON string into a RoleResource object
        /// </summary>
        ///
        /// <param name="json"> Raw JSON string </param>
        /// <returns> RoleResource object represented by the provided JSON </returns> 
        public static RoleResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<RoleResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }
    
        [JsonProperty("sid")]
        public string Sid { get; set; }
        [JsonProperty("account_sid")]
        public string AccountSid { get; set; }
        [JsonProperty("service_sid")]
        public string ServiceSid { get; set; }
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; set; }
        [JsonProperty("type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public RoleResource.RoleTypeEnum Type { get; set; }
        [JsonProperty("permissions")]
        public List<string> Permissions { get; set; }
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; set; }
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; set; }
        [JsonProperty("url")]
        public Uri Url { get; set; }
    
        public RoleResource()
        {
        
        }
    
        private RoleResource([JsonProperty("sid")]
                             string sid, 
                             [JsonProperty("account_sid")]
                             string accountSid, 
                             [JsonProperty("service_sid")]
                             string serviceSid, 
                             [JsonProperty("friendly_name")]
                             string friendlyName, 
                             [JsonProperty("type")]
                             RoleResource.RoleTypeEnum type, 
                             [JsonProperty("permissions")]
                             List<string> permissions, 
                             [JsonProperty("date_created")]
                             string dateCreated, 
                             [JsonProperty("date_updated")]
                             string dateUpdated, 
                             [JsonProperty("url")]
                             Uri url)
                             {
            Sid = sid;
            AccountSid = accountSid;
            ServiceSid = serviceSid;
            FriendlyName = friendlyName;
            Type = type;
            Permissions = permissions;
            DateCreated = MarshalConverter.DateTimeFromString(dateCreated);
            DateUpdated = MarshalConverter.DateTimeFromString(dateUpdated);
            Url = url;
        }
    }
}