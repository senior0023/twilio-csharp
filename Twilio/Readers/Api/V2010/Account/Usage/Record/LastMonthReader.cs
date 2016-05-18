using System.Threading.Tasks;
using Twilio.Clients;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Readers;
using Twilio.Resources;
using Twilio.Resources.Api.V2010.Account.Usage.Record;

namespace Twilio.Readers.Api.V2010.Account.Usage.Record {

    public class LastMonthReader : Reader<LastMonthResource> {
        private string accountSid;
    
        /**
         * Construct a new LastMonthReader
         * 
         * @param accountSid The account_sid
         */
        public LastMonthReader(string accountSid) {
            this.accountSid = accountSid;
        }
    
        /**
         * Make the request to the Twilio API to perform the read
         * 
         * @param client ITwilioRestClient with which to make the request
         * @return LastMonthResource ResourceSet
         */
        public override async Task<ResourceSet<LastMonthResource>> ExecuteAsync(ITwilioRestClient client) {
            Request request = new Request(
                System.Net.Http.HttpMethod.Get,
                Domains.API,
                "/2010-04-01/Accounts/" + this.accountSid + "/Usage/Records/LastMonth.json"
            );
            
            AddQueryParams(request);
            
            Page<LastMonthResource> page = await PageForRequest(client, request);
            
            return new ResourceSet<LastMonthResource>(this, client, page);
        }
    
        /**
         * Retrieve the next page from the Twilio API
         * 
         * @param nextPageUri URI from which to retrieve the next page
         * @param client ITwilioRestClient with which to make the request
         * @return Next Page
         */
        public override Page<LastMonthResource> NextPage(string nextPageUri, ITwilioRestClient client) {
            Request request = new Request(
                System.Net.Http.HttpMethod.Get,
                nextPageUri
            );
            
            var task = PageForRequest(client, request);
            task.Wait();
            
            return task.Result;
        }
    
        /**
         * Generate a Page of LastMonthResource Resources for a given request
         * 
         * @param client ITwilioRestClient with which to make the request
         * @param request Request to generate a page for
         * @return Page for the Request
         */
        protected async Task<Page<LastMonthResource>> PageForRequest(ITwilioRestClient client, Request request) {
            Response response = await client.Request(request);
            
            if (response == null) {
                throw new ApiConnectionException("LastMonthResource read failed: Unable to connect to server");
            } else if (response.GetStatusCode() != HttpStatus.HTTP_STATUS_CODE_OK) {
                RestException restException = RestException.FromJson(response.GetContent());
                if (restException == null)
                    throw new ApiException("Server Error, no content");
                throw new ApiException(
                    restException.GetMessage(),
                    restException.GetCode(),
                    restException.GetMoreInfo(),
                    restException.GetStatus(),
                    null
                );
            }
            
            Page<LastMonthResource> result = new Page<LastMonthResource>();
            result.deserialize("usage_records", response.GetContent());
            
            return result;
        }
    
        /**
         * Add the requested query string arguments to the Request
         * 
         * @param request Request to add query string arguments to
         */
        private void AddQueryParams(Request request) {
            request.AddQueryParam("PageSize", GetPageSize().ToString());
        }
    }
}