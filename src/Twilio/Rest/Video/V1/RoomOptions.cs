using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Video.V1 
{

    /// <summary>
    /// FetchRoomOptions
    /// </summary>
    public class FetchRoomOptions : IOptions<RoomResource> 
    {
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }
    
        /// <summary>
        /// Construct a new FetchRoomOptions
        /// </summary>
        ///
        /// <param name="pathSid"> The sid </param>
        public FetchRoomOptions(string pathSid)
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
    /// CreateRoomOptions
    /// </summary>
    public class CreateRoomOptions : IOptions<RoomResource> 
    {
        /// <summary>
        /// The enable_turn
        /// </summary>
        public bool? EnableTurn { get; set; }
        /// <summary>
        /// The type
        /// </summary>
        public RoomResource.RoomTypeEnum Type { get; set; }
        /// <summary>
        /// The unique_name
        /// </summary>
        public string UniqueName { get; set; }
        /// <summary>
        /// The status_callback
        /// </summary>
        public Uri StatusCallback { get; set; }
        /// <summary>
        /// The status_callback_method
        /// </summary>
        public Twilio.Http.HttpMethod StatusCallbackMethod { get; set; }
        /// <summary>
        /// The max_participants
        /// </summary>
        public int? MaxParticipants { get; set; }
    
        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (EnableTurn != null)
            {
                p.Add(new KeyValuePair<string, string>("EnableTurn", EnableTurn.Value.ToString()));
            }
            
            if (Type != null)
            {
                p.Add(new KeyValuePair<string, string>("Type", Type.ToString()));
            }
            
            if (UniqueName != null)
            {
                p.Add(new KeyValuePair<string, string>("UniqueName", UniqueName));
            }
            
            if (StatusCallback != null)
            {
                p.Add(new KeyValuePair<string, string>("StatusCallback", StatusCallback.ToString()));
            }
            
            if (StatusCallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("StatusCallbackMethod", StatusCallbackMethod.ToString()));
            }
            
            if (MaxParticipants != null)
            {
                p.Add(new KeyValuePair<string, string>("MaxParticipants", MaxParticipants.Value.ToString()));
            }
            
            return p;
        }
    }

    /// <summary>
    /// ReadRoomOptions
    /// </summary>
    public class ReadRoomOptions : ReadOptions<RoomResource> 
    {
        /// <summary>
        /// The status
        /// </summary>
        public RoomResource.RoomStatusEnum Status { get; set; }
        /// <summary>
        /// The start_time_after
        /// </summary>
        public DateTime? StartTimeAfter { get; set; }
        /// <summary>
        /// The start_time_before
        /// </summary>
        public DateTime? StartTimeBefore { get; set; }
        /// <summary>
        /// The unique_name
        /// </summary>
        public string UniqueName { get; set; }
    
        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Status != null)
            {
                p.Add(new KeyValuePair<string, string>("Status", Status.ToString()));
            }
            
            if (StartTimeAfter != null)
            {
                p.Add(new KeyValuePair<string, string>("StartTimeAfter", StartTimeAfter.Value.ToString("yyyy-MM-dd'T'HH:mm:ss")));
            }
            
            if (StartTimeBefore != null)
            {
                p.Add(new KeyValuePair<string, string>("StartTimeBefore", StartTimeBefore.Value.ToString("yyyy-MM-dd'T'HH:mm:ss")));
            }
            
            if (UniqueName != null)
            {
                p.Add(new KeyValuePair<string, string>("UniqueName", UniqueName));
            }
            
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }
            
            return p;
        }
    }

    /// <summary>
    /// UpdateRoomOptions
    /// </summary>
    public class UpdateRoomOptions : IOptions<RoomResource> 
    {
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }
        /// <summary>
        /// The status
        /// </summary>
        public RoomResource.RoomStatusEnum Status { get; }
    
        /// <summary>
        /// Construct a new UpdateRoomOptions
        /// </summary>
        ///
        /// <param name="pathSid"> The sid </param>
        /// <param name="status"> The status </param>
        public UpdateRoomOptions(string pathSid, RoomResource.RoomStatusEnum status)
        {
            PathSid = pathSid;
            Status = status;
        }
    
        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Status != null)
            {
                p.Add(new KeyValuePair<string, string>("Status", Status.ToString()));
            }
            
            return p;
        }
    }

}