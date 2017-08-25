/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Pricing.V1.PhoneNumber 
{

    /// <summary>
    /// ReadCountryOptions
    /// </summary>
    public class ReadCountryOptions : ReadOptions<CountryResource> 
    {
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
    /// FetchCountryOptions
    /// </summary>
    public class FetchCountryOptions : IOptions<CountryResource> 
    {
        /// <summary>
        /// The iso_country
        /// </summary>
        public string PathIsoCountry { get; }

        /// <summary>
        /// Construct a new FetchCountryOptions
        /// </summary>
        ///
        /// <param name="pathIsoCountry"> The iso_country </param>
        public FetchCountryOptions(string pathIsoCountry)
        {
            PathIsoCountry = pathIsoCountry;
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