/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Insights.V1.Call
{

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    ///
    /// ReadMetricOptions
    /// </summary>
    public class ReadMetricOptions : ReadOptions<MetricResource>
    {
        /// <summary>
        /// The call_sid
        /// </summary>
        public string PathCallSid { get; }
        /// <summary>
        /// The edge
        /// </summary>
        public MetricResource.TwilioEdgeEnum Edge { get; set; }
        /// <summary>
        /// The direction
        /// </summary>
        public MetricResource.StreamDirectionEnum Direction { get; set; }

        /// <summary>
        /// Construct a new ReadMetricOptions
        /// </summary>
        /// <param name="pathCallSid"> The call_sid </param>
        public ReadMetricOptions(string pathCallSid)
        {
            PathCallSid = pathCallSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Edge != null)
            {
                p.Add(new KeyValuePair<string, string>("Edge", Edge.ToString()));
            }

            if (Direction != null)
            {
                p.Add(new KeyValuePair<string, string>("Direction", Direction.ToString()));
            }

            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

}