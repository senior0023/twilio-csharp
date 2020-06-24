/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using NSubstitute;
using NSubstitute.ExceptionExtensions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Rest.Supersim.V1;

namespace Twilio.Tests.Rest.Supersim.V1
{

    [TestFixture]
    public class FleetTest : TwilioTest
    {
        [Test]
        public void TestCreateRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Post,
                Twilio.Rest.Domain.Supersim,
                "/v1/Fleets",
                ""
            );
            request.AddPostParam("NetworkAccessProfile", Serialize("HAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"));
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                FleetResource.Create("HAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestCreateResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.Created,
                                         "{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"unique_name\": \"unique_name\",\"data_enabled\": true,\"data_limit\": 1000,\"data_metering\": \"payg\",\"date_created\": \"2019-07-30T20:00:00Z\",\"date_updated\": \"2019-07-30T20:00:00Z\",\"commands_enabled\": true,\"commands_method\": \"GET\",\"commands_url\": \"https://google.com\",\"network_access_profile_sid\": \"HAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"sid\": \"HFaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"url\": \"https://supersim.twilio.com/v1/Fleets/HFaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"}"
                                     ));

            var response = FleetResource.Create("HAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestFetchRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Get,
                Twilio.Rest.Domain.Supersim,
                "/v1/Fleets/HFXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                FleetResource.Fetch("HFXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestFetchResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"unique_name\": \"unique_name\",\"data_enabled\": true,\"data_limit\": 1000,\"data_metering\": \"payg\",\"date_created\": \"2019-07-30T20:00:00Z\",\"date_updated\": \"2019-07-30T20:00:00Z\",\"commands_enabled\": true,\"commands_method\": \"POST\",\"commands_url\": null,\"network_access_profile_sid\": \"HAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"sid\": \"HFaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"url\": \"https://supersim.twilio.com/v1/Fleets/HFaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"}"
                                     ));

            var response = FleetResource.Fetch("HFXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestReadRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Get,
                Twilio.Rest.Domain.Supersim,
                "/v1/Fleets",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                FleetResource.Read(client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestReadEmptyResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"fleets\": [],\"meta\": {\"first_page_url\": \"https://supersim.twilio.com/v1/Fleets?NetworkAccessProfile=HAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa&PageSize=50&Page=0\",\"key\": \"fleets\",\"next_page_url\": null,\"page\": 0,\"page_size\": 50,\"previous_page_url\": null,\"url\": \"https://supersim.twilio.com/v1/Fleets?NetworkAccessProfile=HAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa&PageSize=50&Page=0\"}}"
                                     ));

            var response = FleetResource.Read(client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestReadFullResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"meta\": {\"first_page_url\": \"https://supersim.twilio.com/v1/Fleets?NetworkAccessProfile=HAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa&PageSize=50&Page=0\",\"key\": \"fleets\",\"next_page_url\": null,\"page\": 0,\"page_size\": 50,\"previous_page_url\": null,\"url\": \"https://supersim.twilio.com/v1/Fleets?NetworkAccessProfile=HAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa&PageSize=50&Page=0\"},\"fleets\": [{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"unique_name\": \"Pilot Fleet\",\"data_enabled\": true,\"data_limit\": 1000,\"data_metering\": \"payg\",\"date_created\": \"2019-10-15T20:00:00Z\",\"date_updated\": \"2019-10-15T20:00:00Z\",\"commands_enabled\": true,\"commands_method\": \"POST\",\"commands_url\": null,\"network_access_profile_sid\": \"HAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"sid\": \"HFaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"url\": \"https://supersim.twilio.com/v1/Fleets/HFaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"}]}"
                                     ));

            var response = FleetResource.Read(client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestUpdateRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Post,
                Twilio.Rest.Domain.Supersim,
                "/v1/Fleets/HFXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                FleetResource.Update("HFXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestUpdateUniqueNameResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"unique_name\": \"unique_name\",\"data_enabled\": true,\"data_limit\": 1000,\"data_metering\": \"payg\",\"date_created\": \"2019-10-15T20:00:00Z\",\"date_updated\": \"2019-10-15T20:00:00Z\",\"commands_enabled\": true,\"commands_method\": \"POST\",\"commands_url\": null,\"network_access_profile_sid\": \"HAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"sid\": \"HFaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"url\": \"https://supersim.twilio.com/v1/Fleets/HFaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"}"
                                     ));

            var response = FleetResource.Update("HFXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }
    }

}