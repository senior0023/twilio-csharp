/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using System.Linq;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Taskrouter.V1.Workspace.Task 
{

    /// <summary>
    /// ReadReservationOptions
    /// </summary>
    public class ReadReservationOptions : ReadOptions<ReservationResource> 
    {
        /// <summary>
        /// The workspace_sid
        /// </summary>
        public string PathWorkspaceSid { get; }
        /// <summary>
        /// The task_sid
        /// </summary>
        public string PathTaskSid { get; }
        /// <summary>
        /// The reservation_status
        /// </summary>
        public ReservationResource.StatusEnum ReservationStatus { get; set; }

        /// <summary>
        /// Construct a new ReadReservationOptions
        /// </summary>
        ///
        /// <param name="pathWorkspaceSid"> The workspace_sid </param>
        /// <param name="pathTaskSid"> The task_sid </param>
        public ReadReservationOptions(string pathWorkspaceSid, string pathTaskSid)
        {
            PathWorkspaceSid = pathWorkspaceSid;
            PathTaskSid = pathTaskSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (ReservationStatus != null)
            {
                p.Add(new KeyValuePair<string, string>("ReservationStatus", ReservationStatus.ToString()));
            }

            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// FetchReservationOptions
    /// </summary>
    public class FetchReservationOptions : IOptions<ReservationResource> 
    {
        /// <summary>
        /// The workspace_sid
        /// </summary>
        public string PathWorkspaceSid { get; }
        /// <summary>
        /// The task_sid
        /// </summary>
        public string PathTaskSid { get; }
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchReservationOptions
        /// </summary>
        ///
        /// <param name="pathWorkspaceSid"> The workspace_sid </param>
        /// <param name="pathTaskSid"> The task_sid </param>
        /// <param name="pathSid"> The sid </param>
        public FetchReservationOptions(string pathWorkspaceSid, string pathTaskSid, string pathSid)
        {
            PathWorkspaceSid = pathWorkspaceSid;
            PathTaskSid = pathTaskSid;
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
    /// UpdateReservationOptions
    /// </summary>
    public class UpdateReservationOptions : IOptions<ReservationResource> 
    {
        /// <summary>
        /// The workspace_sid
        /// </summary>
        public string PathWorkspaceSid { get; }
        /// <summary>
        /// The task_sid
        /// </summary>
        public string PathTaskSid { get; }
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }
        /// <summary>
        /// The reservation_status
        /// </summary>
        public ReservationResource.StatusEnum ReservationStatus { get; set; }
        /// <summary>
        /// The worker_activity_sid
        /// </summary>
        public string WorkerActivitySid { get; set; }
        /// <summary>
        /// The instruction
        /// </summary>
        public string Instruction { get; set; }
        /// <summary>
        /// The dequeue_post_work_activity_sid
        /// </summary>
        public string DequeuePostWorkActivitySid { get; set; }
        /// <summary>
        /// The dequeue_from
        /// </summary>
        public string DequeueFrom { get; set; }
        /// <summary>
        /// The dequeue_record
        /// </summary>
        public string DequeueRecord { get; set; }
        /// <summary>
        /// The dequeue_timeout
        /// </summary>
        public int? DequeueTimeout { get; set; }
        /// <summary>
        /// The dequeue_to
        /// </summary>
        public string DequeueTo { get; set; }
        /// <summary>
        /// The dequeue_status_callback_url
        /// </summary>
        public Uri DequeueStatusCallbackUrl { get; set; }
        /// <summary>
        /// The call_from
        /// </summary>
        public string CallFrom { get; set; }
        /// <summary>
        /// The call_record
        /// </summary>
        public string CallRecord { get; set; }
        /// <summary>
        /// The call_timeout
        /// </summary>
        public int? CallTimeout { get; set; }
        /// <summary>
        /// The call_to
        /// </summary>
        public string CallTo { get; set; }
        /// <summary>
        /// The call_url
        /// </summary>
        public Uri CallUrl { get; set; }
        /// <summary>
        /// The call_status_callback_url
        /// </summary>
        public Uri CallStatusCallbackUrl { get; set; }
        /// <summary>
        /// The call_accept
        /// </summary>
        public bool? CallAccept { get; set; }
        /// <summary>
        /// The redirect_call_sid
        /// </summary>
        public string RedirectCallSid { get; set; }
        /// <summary>
        /// The redirect_accept
        /// </summary>
        public bool? RedirectAccept { get; set; }
        /// <summary>
        /// The redirect_url
        /// </summary>
        public Uri RedirectUrl { get; set; }
        /// <summary>
        /// The to
        /// </summary>
        public string To { get; set; }
        /// <summary>
        /// The from
        /// </summary>
        public string From { get; set; }
        /// <summary>
        /// The status_callback
        /// </summary>
        public Uri StatusCallback { get; set; }
        /// <summary>
        /// The status_callback_method
        /// </summary>
        public Twilio.Http.HttpMethod StatusCallbackMethod { get; set; }
        /// <summary>
        /// The status_callback_event
        /// </summary>
        public List<ReservationResource.CallStatusEnum> StatusCallbackEvent { get; set; }
        /// <summary>
        /// The timeout
        /// </summary>
        public int? Timeout { get; set; }
        /// <summary>
        /// The record
        /// </summary>
        public bool? Record { get; set; }
        /// <summary>
        /// The muted
        /// </summary>
        public bool? Muted { get; set; }
        /// <summary>
        /// The beep
        /// </summary>
        public string Beep { get; set; }
        /// <summary>
        /// The start_conference_on_enter
        /// </summary>
        public bool? StartConferenceOnEnter { get; set; }
        /// <summary>
        /// The end_conference_on_exit
        /// </summary>
        public bool? EndConferenceOnExit { get; set; }
        /// <summary>
        /// The wait_url
        /// </summary>
        public Uri WaitUrl { get; set; }
        /// <summary>
        /// The wait_method
        /// </summary>
        public Twilio.Http.HttpMethod WaitMethod { get; set; }
        /// <summary>
        /// The early_media
        /// </summary>
        public bool? EarlyMedia { get; set; }
        /// <summary>
        /// The max_participants
        /// </summary>
        public int? MaxParticipants { get; set; }
        /// <summary>
        /// The conference_status_callback
        /// </summary>
        public Uri ConferenceStatusCallback { get; set; }
        /// <summary>
        /// The conference_status_callback_method
        /// </summary>
        public Twilio.Http.HttpMethod ConferenceStatusCallbackMethod { get; set; }
        /// <summary>
        /// The conference_status_callback_event
        /// </summary>
        public List<ReservationResource.ConferenceEventEnum> ConferenceStatusCallbackEvent { get; set; }
        /// <summary>
        /// The conference_record
        /// </summary>
        public string ConferenceRecord { get; set; }
        /// <summary>
        /// The conference_trim
        /// </summary>
        public string ConferenceTrim { get; set; }
        /// <summary>
        /// The recording_channels
        /// </summary>
        public string RecordingChannels { get; set; }
        /// <summary>
        /// The recording_status_callback
        /// </summary>
        public Uri RecordingStatusCallback { get; set; }
        /// <summary>
        /// The recording_status_callback_method
        /// </summary>
        public Twilio.Http.HttpMethod RecordingStatusCallbackMethod { get; set; }
        /// <summary>
        /// The conference_recording_status_callback
        /// </summary>
        public Uri ConferenceRecordingStatusCallback { get; set; }
        /// <summary>
        /// The conference_recording_status_callback_method
        /// </summary>
        public Twilio.Http.HttpMethod ConferenceRecordingStatusCallbackMethod { get; set; }
        /// <summary>
        /// The region
        /// </summary>
        public string Region { get; set; }
        /// <summary>
        /// The sip_auth_username
        /// </summary>
        public string SipAuthUsername { get; set; }
        /// <summary>
        /// The sip_auth_password
        /// </summary>
        public string SipAuthPassword { get; set; }
        /// <summary>
        /// The dequeue_status_callback_event
        /// </summary>
        public List<string> DequeueStatusCallbackEvent { get; set; }
        /// <summary>
        /// The post_work_activity_sid
        /// </summary>
        public string PostWorkActivitySid { get; set; }

        /// <summary>
        /// Construct a new UpdateReservationOptions
        /// </summary>
        ///
        /// <param name="pathWorkspaceSid"> The workspace_sid </param>
        /// <param name="pathTaskSid"> The task_sid </param>
        /// <param name="pathSid"> The sid </param>
        public UpdateReservationOptions(string pathWorkspaceSid, string pathTaskSid, string pathSid)
        {
            PathWorkspaceSid = pathWorkspaceSid;
            PathTaskSid = pathTaskSid;
            PathSid = pathSid;
            StatusCallbackEvent = new List<ReservationResource.CallStatusEnum>();
            ConferenceStatusCallbackEvent = new List<ReservationResource.ConferenceEventEnum>();
            DequeueStatusCallbackEvent = new List<string>();
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (ReservationStatus != null)
            {
                p.Add(new KeyValuePair<string, string>("ReservationStatus", ReservationStatus.ToString()));
            }

            if (WorkerActivitySid != null)
            {
                p.Add(new KeyValuePair<string, string>("WorkerActivitySid", WorkerActivitySid.ToString()));
            }

            if (Instruction != null)
            {
                p.Add(new KeyValuePair<string, string>("Instruction", Instruction));
            }

            if (DequeuePostWorkActivitySid != null)
            {
                p.Add(new KeyValuePair<string, string>("DequeuePostWorkActivitySid", DequeuePostWorkActivitySid.ToString()));
            }

            if (DequeueFrom != null)
            {
                p.Add(new KeyValuePair<string, string>("DequeueFrom", DequeueFrom));
            }

            if (DequeueRecord != null)
            {
                p.Add(new KeyValuePair<string, string>("DequeueRecord", DequeueRecord));
            }

            if (DequeueTimeout != null)
            {
                p.Add(new KeyValuePair<string, string>("DequeueTimeout", DequeueTimeout.Value.ToString()));
            }

            if (DequeueTo != null)
            {
                p.Add(new KeyValuePair<string, string>("DequeueTo", DequeueTo));
            }

            if (DequeueStatusCallbackUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("DequeueStatusCallbackUrl", DequeueStatusCallbackUrl.AbsoluteUri));
            }

            if (CallFrom != null)
            {
                p.Add(new KeyValuePair<string, string>("CallFrom", CallFrom));
            }

            if (CallRecord != null)
            {
                p.Add(new KeyValuePair<string, string>("CallRecord", CallRecord));
            }

            if (CallTimeout != null)
            {
                p.Add(new KeyValuePair<string, string>("CallTimeout", CallTimeout.Value.ToString()));
            }

            if (CallTo != null)
            {
                p.Add(new KeyValuePair<string, string>("CallTo", CallTo));
            }

            if (CallUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("CallUrl", CallUrl.AbsoluteUri));
            }

            if (CallStatusCallbackUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("CallStatusCallbackUrl", CallStatusCallbackUrl.AbsoluteUri));
            }

            if (CallAccept != null)
            {
                p.Add(new KeyValuePair<string, string>("CallAccept", CallAccept.Value.ToString()));
            }

            if (RedirectCallSid != null)
            {
                p.Add(new KeyValuePair<string, string>("RedirectCallSid", RedirectCallSid.ToString()));
            }

            if (RedirectAccept != null)
            {
                p.Add(new KeyValuePair<string, string>("RedirectAccept", RedirectAccept.Value.ToString()));
            }

            if (RedirectUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("RedirectUrl", RedirectUrl.AbsoluteUri));
            }

            if (To != null)
            {
                p.Add(new KeyValuePair<string, string>("To", To));
            }

            if (From != null)
            {
                p.Add(new KeyValuePair<string, string>("From", From));
            }

            if (StatusCallback != null)
            {
                p.Add(new KeyValuePair<string, string>("StatusCallback", StatusCallback.AbsoluteUri));
            }

            if (StatusCallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("StatusCallbackMethod", StatusCallbackMethod.ToString()));
            }

            if (StatusCallbackEvent != null)
            {
                p.AddRange(StatusCallbackEvent.Select(prop => new KeyValuePair<string, string>("StatusCallbackEvent", prop.ToString())));
            }

            if (Timeout != null)
            {
                p.Add(new KeyValuePair<string, string>("Timeout", Timeout.Value.ToString()));
            }

            if (Record != null)
            {
                p.Add(new KeyValuePair<string, string>("Record", Record.Value.ToString()));
            }

            if (Muted != null)
            {
                p.Add(new KeyValuePair<string, string>("Muted", Muted.Value.ToString()));
            }

            if (Beep != null)
            {
                p.Add(new KeyValuePair<string, string>("Beep", Beep));
            }

            if (StartConferenceOnEnter != null)
            {
                p.Add(new KeyValuePair<string, string>("StartConferenceOnEnter", StartConferenceOnEnter.Value.ToString()));
            }

            if (EndConferenceOnExit != null)
            {
                p.Add(new KeyValuePair<string, string>("EndConferenceOnExit", EndConferenceOnExit.Value.ToString()));
            }

            if (WaitUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("WaitUrl", WaitUrl.AbsoluteUri));
            }

            if (WaitMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("WaitMethod", WaitMethod.ToString()));
            }

            if (EarlyMedia != null)
            {
                p.Add(new KeyValuePair<string, string>("EarlyMedia", EarlyMedia.Value.ToString()));
            }

            if (MaxParticipants != null)
            {
                p.Add(new KeyValuePair<string, string>("MaxParticipants", MaxParticipants.Value.ToString()));
            }

            if (ConferenceStatusCallback != null)
            {
                p.Add(new KeyValuePair<string, string>("ConferenceStatusCallback", ConferenceStatusCallback.AbsoluteUri));
            }

            if (ConferenceStatusCallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("ConferenceStatusCallbackMethod", ConferenceStatusCallbackMethod.ToString()));
            }

            if (ConferenceStatusCallbackEvent != null)
            {
                p.AddRange(ConferenceStatusCallbackEvent.Select(prop => new KeyValuePair<string, string>("ConferenceStatusCallbackEvent", prop.ToString())));
            }

            if (ConferenceRecord != null)
            {
                p.Add(new KeyValuePair<string, string>("ConferenceRecord", ConferenceRecord));
            }

            if (ConferenceTrim != null)
            {
                p.Add(new KeyValuePair<string, string>("ConferenceTrim", ConferenceTrim));
            }

            if (RecordingChannels != null)
            {
                p.Add(new KeyValuePair<string, string>("RecordingChannels", RecordingChannels));
            }

            if (RecordingStatusCallback != null)
            {
                p.Add(new KeyValuePair<string, string>("RecordingStatusCallback", RecordingStatusCallback.AbsoluteUri));
            }

            if (RecordingStatusCallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("RecordingStatusCallbackMethod", RecordingStatusCallbackMethod.ToString()));
            }

            if (ConferenceRecordingStatusCallback != null)
            {
                p.Add(new KeyValuePair<string, string>("ConferenceRecordingStatusCallback", ConferenceRecordingStatusCallback.AbsoluteUri));
            }

            if (ConferenceRecordingStatusCallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("ConferenceRecordingStatusCallbackMethod", ConferenceRecordingStatusCallbackMethod.ToString()));
            }

            if (Region != null)
            {
                p.Add(new KeyValuePair<string, string>("Region", Region));
            }

            if (SipAuthUsername != null)
            {
                p.Add(new KeyValuePair<string, string>("SipAuthUsername", SipAuthUsername));
            }

            if (SipAuthPassword != null)
            {
                p.Add(new KeyValuePair<string, string>("SipAuthPassword", SipAuthPassword));
            }

            if (DequeueStatusCallbackEvent != null)
            {
                p.AddRange(DequeueStatusCallbackEvent.Select(prop => new KeyValuePair<string, string>("DequeueStatusCallbackEvent", prop)));
            }

            if (PostWorkActivitySid != null)
            {
                p.Add(new KeyValuePair<string, string>("PostWorkActivitySid", PostWorkActivitySid.ToString()));
            }

            return p;
        }
    }

}