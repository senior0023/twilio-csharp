/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// RegulationResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Types;

namespace Twilio.Rest.Numbers.V2.RegulatoryCompliance
{

    public class RegulationResource : Resource
    {
        public sealed class EndUserTypeEnum : StringEnum
        {
            private EndUserTypeEnum(string value) : base(value) {}
            public EndUserTypeEnum() {}
            public static implicit operator EndUserTypeEnum(string value)
            {
                return new EndUserTypeEnum(value);
            }

            public static readonly EndUserTypeEnum Individual = new EndUserTypeEnum("individual");
            public static readonly EndUserTypeEnum Business = new EndUserTypeEnum("business");
        }

        private static Request BuildReadRequest(ReadRegulationOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Numbers,
                "/v2/RegulatoryCompliance/Regulations",
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// Retrieve a list of all Regulations.
        /// </summary>
        /// <param name="options"> Read Regulation parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Regulation </returns>
        public static ResourceSet<RegulationResource> Read(ReadRegulationOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<RegulationResource>.FromJson("results", response.Content);
            return new ResourceSet<RegulationResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// Retrieve a list of all Regulations.
        /// </summary>
        /// <param name="options"> Read Regulation parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Regulation </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<RegulationResource>> ReadAsync(ReadRegulationOptions options,
                                                                                                   ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<RegulationResource>.FromJson("results", response.Content);
            return new ResourceSet<RegulationResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// Retrieve a list of all Regulations.
        /// </summary>
        /// <param name="endUserType"> The type of End User of the Regulation resource </param>
        /// <param name="isoCountry"> The ISO country code of the phone number's country </param>
        /// <param name="numberType"> The type of phone number being regulated </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Regulation </returns>
        public static ResourceSet<RegulationResource> Read(RegulationResource.EndUserTypeEnum endUserType = null,
                                                           string isoCountry = null,
                                                           string numberType = null,
                                                           int? pageSize = null,
                                                           long? limit = null,
                                                           ITwilioRestClient client = null)
        {
            var options = new ReadRegulationOptions(){EndUserType = endUserType, IsoCountry = isoCountry, NumberType = numberType, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// Retrieve a list of all Regulations.
        /// </summary>
        /// <param name="endUserType"> The type of End User of the Regulation resource </param>
        /// <param name="isoCountry"> The ISO country code of the phone number's country </param>
        /// <param name="numberType"> The type of phone number being regulated </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Regulation </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<RegulationResource>> ReadAsync(RegulationResource.EndUserTypeEnum endUserType = null,
                                                                                                   string isoCountry = null,
                                                                                                   string numberType = null,
                                                                                                   int? pageSize = null,
                                                                                                   long? limit = null,
                                                                                                   ITwilioRestClient client = null)
        {
            var options = new ReadRegulationOptions(){EndUserType = endUserType, IsoCountry = isoCountry, NumberType = numberType, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the target page of records
        /// </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<RegulationResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<RegulationResource>.FromJson("results", response.Content);
        }

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<RegulationResource> NextPage(Page<RegulationResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Numbers)
            );

            var response = client.Request(request);
            return Page<RegulationResource>.FromJson("results", response.Content);
        }

        /// <summary>
        /// Fetch the previous page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<RegulationResource> PreviousPage(Page<RegulationResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Numbers)
            );

            var response = client.Request(request);
            return Page<RegulationResource>.FromJson("results", response.Content);
        }

        private static Request BuildFetchRequest(FetchRegulationOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Numbers,
                "/v2/RegulatoryCompliance/Regulations/" + options.PathSid + "",
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// Fetch specific Regulation Instance.
        /// </summary>
        /// <param name="options"> Fetch Regulation parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Regulation </returns>
        public static RegulationResource Fetch(FetchRegulationOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Fetch specific Regulation Instance.
        /// </summary>
        /// <param name="options"> Fetch Regulation parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Regulation </returns>
        public static async System.Threading.Tasks.Task<RegulationResource> FetchAsync(FetchRegulationOptions options,
                                                                                       ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Fetch specific Regulation Instance.
        /// </summary>
        /// <param name="pathSid"> The unique string that identifies the Regulation resource </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Regulation </returns>
        public static RegulationResource Fetch(string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchRegulationOptions(pathSid);
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// Fetch specific Regulation Instance.
        /// </summary>
        /// <param name="pathSid"> The unique string that identifies the Regulation resource </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Regulation </returns>
        public static async System.Threading.Tasks.Task<RegulationResource> FetchAsync(string pathSid,
                                                                                       ITwilioRestClient client = null)
        {
            var options = new FetchRegulationOptions(pathSid);
            return await FetchAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a RegulationResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> RegulationResource object represented by the provided JSON </returns>
        public static RegulationResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<RegulationResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// The unique string that identifies the Regulation resource
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// A human-readable description of the Regulation resource
        /// </summary>
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }
        /// <summary>
        /// The ISO country code of the phone number's country
        /// </summary>
        [JsonProperty("iso_country")]
        public string IsoCountry { get; private set; }
        /// <summary>
        /// The type of phone number restricted by the regulatory requirement
        /// </summary>
        [JsonProperty("number_type")]
        public string NumberType { get; private set; }
        /// <summary>
        /// The type of End User of the Regulation resource
        /// </summary>
        [JsonProperty("end_user_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public RegulationResource.EndUserTypeEnum EndUserType { get; private set; }
        /// <summary>
        /// The sid of a regulation object that dictates requirements
        /// </summary>
        [JsonProperty("requirements")]
        public object Requirements { get; private set; }
        /// <summary>
        /// The absolute URL of the Regulation resource
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        private RegulationResource()
        {

        }
    }

}