/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using System.Linq;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Preview.HostedNumbers 
{

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    /// 
    /// Fetch a specific HostedNumberOrder.
    /// </summary>
    public class FetchHostedNumberOrderOptions : IOptions<HostedNumberOrderResource> 
    {
        /// <summary>
        /// HostedNumberOrder sid.
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchHostedNumberOrderOptions
        /// </summary>
        ///
        /// <param name="pathSid"> HostedNumberOrder sid. </param>
        public FetchHostedNumberOrderOptions(string pathSid)
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
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    /// 
    /// Cancel the HostedNumberOrder (only available when the status is in `received`).
    /// </summary>
    public class DeleteHostedNumberOrderOptions : IOptions<HostedNumberOrderResource> 
    {
        /// <summary>
        /// HostedNumberOrder sid.
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new DeleteHostedNumberOrderOptions
        /// </summary>
        ///
        /// <param name="pathSid"> HostedNumberOrder sid. </param>
        public DeleteHostedNumberOrderOptions(string pathSid)
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
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    /// 
    /// Updates a specific HostedNumberOrder.
    /// </summary>
    public class UpdateHostedNumberOrderOptions : IOptions<HostedNumberOrderResource> 
    {
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }
        /// <summary>
        /// A human readable description of this resource.
        /// </summary>
        public string FriendlyName { get; set; }
        /// <summary>
        /// A unique, developer assigned name of this HostedNumberOrder.
        /// </summary>
        public string UniqueName { get; set; }
        /// <summary>
        /// Email.
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// A list of emails.
        /// </summary>
        public List<string> CcEmails { get; set; }
        /// <summary>
        /// The Status of this HostedNumberOrder.
        /// </summary>
        public HostedNumberOrderResource.StatusEnum Status { get; set; }
        /// <summary>
        /// A verification code.
        /// </summary>
        public string VerificationCode { get; set; }

        /// <summary>
        /// Construct a new UpdateHostedNumberOrderOptions
        /// </summary>
        ///
        /// <param name="pathSid"> The sid </param>
        public UpdateHostedNumberOrderOptions(string pathSid)
        {
            PathSid = pathSid;
            CcEmails = new List<string>();
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }

            if (UniqueName != null)
            {
                p.Add(new KeyValuePair<string, string>("UniqueName", UniqueName));
            }

            if (Email != null)
            {
                p.Add(new KeyValuePair<string, string>("Email", Email));
            }

            if (CcEmails != null)
            {
                p.AddRange(CcEmails.Select(prop => new KeyValuePair<string, string>("CcEmails", prop)));
            }

            if (Status != null)
            {
                p.Add(new KeyValuePair<string, string>("Status", Status.ToString()));
            }

            if (VerificationCode != null)
            {
                p.Add(new KeyValuePair<string, string>("VerificationCode", VerificationCode));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    /// 
    /// Retrieve a list of HostedNumberOrders belonging to the account initiating the request.
    /// </summary>
    public class ReadHostedNumberOrderOptions : ReadOptions<HostedNumberOrderResource> 
    {
        /// <summary>
        /// The Status of this HostedNumberOrder.
        /// </summary>
        public HostedNumberOrderResource.StatusEnum Status { get; set; }
        /// <summary>
        /// An E164 formatted phone number.
        /// </summary>
        public Types.PhoneNumber PhoneNumber { get; set; }
        /// <summary>
        /// IncomingPhoneNumber sid.
        /// </summary>
        public string IncomingPhoneNumberSid { get; set; }
        /// <summary>
        /// A human readable description of this resource.
        /// </summary>
        public string FriendlyName { get; set; }
        /// <summary>
        /// A unique, developer assigned name of this HostedNumberOrder.
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

            if (PhoneNumber != null)
            {
                p.Add(new KeyValuePair<string, string>("PhoneNumber", PhoneNumber.ToString()));
            }

            if (IncomingPhoneNumberSid != null)
            {
                p.Add(new KeyValuePair<string, string>("IncomingPhoneNumberSid", IncomingPhoneNumberSid.ToString()));
            }

            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
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
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    /// 
    /// Host a phone number's capability on Twilio's platform.
    /// </summary>
    public class CreateHostedNumberOrderOptions : IOptions<HostedNumberOrderResource> 
    {
        /// <summary>
        /// Address sid.
        /// </summary>
        public string AddressSid { get; }
        /// <summary>
        /// An E164 formatted phone number.
        /// </summary>
        public Types.PhoneNumber PhoneNumber { get; }
        /// <summary>
        /// ISO country code.
        /// </summary>
        public string IsoCountry { get; }
        /// <summary>
        /// Specify SMS capability to host.
        /// </summary>
        public bool? SmsCapability { get; }
        /// <summary>
        /// Email.
        /// </summary>
        public string Email { get; }
        /// <summary>
        /// Account Sid.
        /// </summary>
        public string AccountSid { get; set; }
        /// <summary>
        /// A human readable description of this resource.
        /// </summary>
        public string FriendlyName { get; set; }
        /// <summary>
        /// A unique, developer assigned name of this HostedNumberOrder.
        /// </summary>
        public string UniqueName { get; set; }
        /// <summary>
        /// A list of emails.
        /// </summary>
        public List<string> CcEmails { get; set; }
        /// <summary>
        /// SMS URL.
        /// </summary>
        public Uri SmsUrl { get; set; }
        /// <summary>
        /// SMS Method.
        /// </summary>
        public Twilio.Http.HttpMethod SmsMethod { get; set; }
        /// <summary>
        /// SMS Fallback URL.
        /// </summary>
        public Uri SmsFallbackUrl { get; set; }
        /// <summary>
        /// SMS Fallback Method.
        /// </summary>
        public Twilio.Http.HttpMethod SmsFallbackMethod { get; set; }
        /// <summary>
        /// Status Callback URL.
        /// </summary>
        public Uri StatusCallbackUrl { get; set; }
        /// <summary>
        /// Status Callback Method.
        /// </summary>
        public Twilio.Http.HttpMethod StatusCallbackMethod { get; set; }
        /// <summary>
        /// SMS Application Sid.
        /// </summary>
        public string SmsApplicationSid { get; set; }

        /// <summary>
        /// Construct a new CreateHostedNumberOrderOptions
        /// </summary>
        ///
        /// <param name="addressSid"> Address sid. </param>
        /// <param name="phoneNumber"> An E164 formatted phone number. </param>
        /// <param name="isoCountry"> ISO country code. </param>
        /// <param name="smsCapability"> Specify SMS capability to host. </param>
        /// <param name="email"> Email. </param>
        public CreateHostedNumberOrderOptions(string addressSid, Types.PhoneNumber phoneNumber, string isoCountry, bool? smsCapability, string email)
        {
            AddressSid = addressSid;
            PhoneNumber = phoneNumber;
            IsoCountry = isoCountry;
            SmsCapability = smsCapability;
            Email = email;
            CcEmails = new List<string>();
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (AddressSid != null)
            {
                p.Add(new KeyValuePair<string, string>("AddressSid", AddressSid.ToString()));
            }

            if (PhoneNumber != null)
            {
                p.Add(new KeyValuePair<string, string>("PhoneNumber", PhoneNumber.ToString()));
            }

            if (IsoCountry != null)
            {
                p.Add(new KeyValuePair<string, string>("IsoCountry", IsoCountry));
            }

            if (SmsCapability != null)
            {
                p.Add(new KeyValuePair<string, string>("SmsCapability", SmsCapability.Value.ToString()));
            }

            if (Email != null)
            {
                p.Add(new KeyValuePair<string, string>("Email", Email));
            }

            if (AccountSid != null)
            {
                p.Add(new KeyValuePair<string, string>("AccountSid", AccountSid.ToString()));
            }

            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }

            if (UniqueName != null)
            {
                p.Add(new KeyValuePair<string, string>("UniqueName", UniqueName));
            }

            if (CcEmails != null)
            {
                p.AddRange(CcEmails.Select(prop => new KeyValuePair<string, string>("CcEmails", prop)));
            }

            if (SmsUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("SmsUrl", SmsUrl.AbsoluteUri));
            }

            if (SmsMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("SmsMethod", SmsMethod.ToString()));
            }

            if (SmsFallbackUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("SmsFallbackUrl", SmsFallbackUrl.AbsoluteUri));
            }

            if (SmsFallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("SmsFallbackMethod", SmsFallbackMethod.ToString()));
            }

            if (StatusCallbackUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("StatusCallbackUrl", StatusCallbackUrl.AbsoluteUri));
            }

            if (StatusCallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("StatusCallbackMethod", StatusCallbackMethod.ToString()));
            }

            if (SmsApplicationSid != null)
            {
                p.Add(new KeyValuePair<string, string>("SmsApplicationSid", SmsApplicationSid.ToString()));
            }

            return p;
        }
    }

}