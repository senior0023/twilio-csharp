/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Notify.V1.Service 
{

    /// <summary>
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    /// 
    /// ReadSegmentOptions
    /// </summary>
    public class ReadSegmentOptions : ReadOptions<SegmentResource> 
    {
        /// <summary>
        /// The service_sid
        /// </summary>
        public string PathServiceSid { get; }

        /// <summary>
        /// Construct a new ReadSegmentOptions
        /// </summary>
        ///
        /// <param name="pathServiceSid"> The service_sid </param>
        public ReadSegmentOptions(string pathServiceSid)
        {
            PathServiceSid = pathServiceSid;
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

}