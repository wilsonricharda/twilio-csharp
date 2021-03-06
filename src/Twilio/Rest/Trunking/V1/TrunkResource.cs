using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Trunking.V1 
{

    /// <summary>
    /// TrunkResource
    /// </summary>
    public class TrunkResource : Resource 
    {
        private static Request BuildFetchRequest(FetchTrunkOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Trunking,
                "/v1/Trunks/" + options.PathSid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="options"> Fetch Trunk parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Trunk </returns> 
        public static TrunkResource Fetch(FetchTrunkOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
    
        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="options"> Fetch Trunk parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Trunk </returns> 
        public static async System.Threading.Tasks.Task<TrunkResource> FetchAsync(FetchTrunkOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
    
        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="pathSid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Trunk </returns> 
        public static TrunkResource Fetch(string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchTrunkOptions(pathSid);
            return Fetch(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="pathSid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Trunk </returns> 
        public static async System.Threading.Tasks.Task<TrunkResource> FetchAsync(string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchTrunkOptions(pathSid);
            return await FetchAsync(options, client);
        }
        #endif
    
        private static Request BuildDeleteRequest(DeleteTrunkOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Trunking,
                "/v1/Trunks/" + options.PathSid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// delete
        /// </summary>
        ///
        /// <param name="options"> Delete Trunk parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Trunk </returns> 
        public static bool Delete(DeleteTrunkOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
    
        #if !NET35
        /// <summary>
        /// delete
        /// </summary>
        ///
        /// <param name="options"> Delete Trunk parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Trunk </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteTrunkOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif
    
        /// <summary>
        /// delete
        /// </summary>
        ///
        /// <param name="pathSid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Trunk </returns> 
        public static bool Delete(string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteTrunkOptions(pathSid);
            return Delete(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// delete
        /// </summary>
        ///
        /// <param name="pathSid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Trunk </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteTrunkOptions(pathSid);
            return await DeleteAsync(options, client);
        }
        #endif
    
        private static Request BuildCreateRequest(CreateTrunkOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Trunking,
                "/v1/Trunks",
                client.Region,
                postParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// create
        /// </summary>
        ///
        /// <param name="options"> Create Trunk parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Trunk </returns> 
        public static TrunkResource Create(CreateTrunkOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
    
        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        ///
        /// <param name="options"> Create Trunk parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Trunk </returns> 
        public static async System.Threading.Tasks.Task<TrunkResource> CreateAsync(CreateTrunkOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
    
        /// <summary>
        /// create
        /// </summary>
        ///
        /// <param name="friendlyName"> The friendly_name </param>
        /// <param name="domainName"> The domain_name </param>
        /// <param name="disasterRecoveryUrl"> The disaster_recovery_url </param>
        /// <param name="disasterRecoveryMethod"> The disaster_recovery_method </param>
        /// <param name="recording"> The recording </param>
        /// <param name="secure"> The secure </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Trunk </returns> 
        public static TrunkResource Create(string friendlyName = null, string domainName = null, Uri disasterRecoveryUrl = null, Twilio.Http.HttpMethod disasterRecoveryMethod = null, string recording = null, bool? secure = null, ITwilioRestClient client = null)
        {
            var options = new CreateTrunkOptions{FriendlyName = friendlyName, DomainName = domainName, DisasterRecoveryUrl = disasterRecoveryUrl, DisasterRecoveryMethod = disasterRecoveryMethod, Recording = recording, Secure = secure};
            return Create(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        ///
        /// <param name="friendlyName"> The friendly_name </param>
        /// <param name="domainName"> The domain_name </param>
        /// <param name="disasterRecoveryUrl"> The disaster_recovery_url </param>
        /// <param name="disasterRecoveryMethod"> The disaster_recovery_method </param>
        /// <param name="recording"> The recording </param>
        /// <param name="secure"> The secure </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Trunk </returns> 
        public static async System.Threading.Tasks.Task<TrunkResource> CreateAsync(string friendlyName = null, string domainName = null, Uri disasterRecoveryUrl = null, Twilio.Http.HttpMethod disasterRecoveryMethod = null, string recording = null, bool? secure = null, ITwilioRestClient client = null)
        {
            var options = new CreateTrunkOptions{FriendlyName = friendlyName, DomainName = domainName, DisasterRecoveryUrl = disasterRecoveryUrl, DisasterRecoveryMethod = disasterRecoveryMethod, Recording = recording, Secure = secure};
            return await CreateAsync(options, client);
        }
        #endif
    
        private static Request BuildReadRequest(ReadTrunkOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Trunking,
                "/v1/Trunks",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="options"> Read Trunk parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Trunk </returns> 
        public static ResourceSet<TrunkResource> Read(ReadTrunkOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            
            var page = Page<TrunkResource>.FromJson("trunks", response.Content);
            return new ResourceSet<TrunkResource>(page, options, client);
        }
    
        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="options"> Read Trunk parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Trunk </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<TrunkResource>> ReadAsync(ReadTrunkOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));
            
            var page = Page<TrunkResource>.FromJson("trunks", response.Content);
            return new ResourceSet<TrunkResource>(page, options, client);
        }
        #endif
    
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Trunk </returns> 
        public static ResourceSet<TrunkResource> Read(int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadTrunkOptions{PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Trunk </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<TrunkResource>> ReadAsync(int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadTrunkOptions{PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        ///
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns> 
        public static Page<TrunkResource> NextPage(Page<TrunkResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Trunking,
                    client.Region
                )
            );
            
            var response = client.Request(request);
            return Page<TrunkResource>.FromJson("trunks", response.Content);
        }
    
        private static Request BuildUpdateRequest(UpdateTrunkOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Trunking,
                "/v1/Trunks/" + options.PathSid + "",
                client.Region,
                postParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// update
        /// </summary>
        ///
        /// <param name="options"> Update Trunk parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Trunk </returns> 
        public static TrunkResource Update(UpdateTrunkOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
    
        #if !NET35
        /// <summary>
        /// update
        /// </summary>
        ///
        /// <param name="options"> Update Trunk parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Trunk </returns> 
        public static async System.Threading.Tasks.Task<TrunkResource> UpdateAsync(UpdateTrunkOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
    
        /// <summary>
        /// update
        /// </summary>
        ///
        /// <param name="pathSid"> The sid </param>
        /// <param name="friendlyName"> The friendly_name </param>
        /// <param name="domainName"> The domain_name </param>
        /// <param name="disasterRecoveryUrl"> The disaster_recovery_url </param>
        /// <param name="disasterRecoveryMethod"> The disaster_recovery_method </param>
        /// <param name="recording"> The recording </param>
        /// <param name="secure"> The secure </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Trunk </returns> 
        public static TrunkResource Update(string pathSid, string friendlyName = null, string domainName = null, Uri disasterRecoveryUrl = null, Twilio.Http.HttpMethod disasterRecoveryMethod = null, string recording = null, bool? secure = null, ITwilioRestClient client = null)
        {
            var options = new UpdateTrunkOptions(pathSid){FriendlyName = friendlyName, DomainName = domainName, DisasterRecoveryUrl = disasterRecoveryUrl, DisasterRecoveryMethod = disasterRecoveryMethod, Recording = recording, Secure = secure};
            return Update(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// update
        /// </summary>
        ///
        /// <param name="pathSid"> The sid </param>
        /// <param name="friendlyName"> The friendly_name </param>
        /// <param name="domainName"> The domain_name </param>
        /// <param name="disasterRecoveryUrl"> The disaster_recovery_url </param>
        /// <param name="disasterRecoveryMethod"> The disaster_recovery_method </param>
        /// <param name="recording"> The recording </param>
        /// <param name="secure"> The secure </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Trunk </returns> 
        public static async System.Threading.Tasks.Task<TrunkResource> UpdateAsync(string pathSid, string friendlyName = null, string domainName = null, Uri disasterRecoveryUrl = null, Twilio.Http.HttpMethod disasterRecoveryMethod = null, string recording = null, bool? secure = null, ITwilioRestClient client = null)
        {
            var options = new UpdateTrunkOptions(pathSid){FriendlyName = friendlyName, DomainName = domainName, DisasterRecoveryUrl = disasterRecoveryUrl, DisasterRecoveryMethod = disasterRecoveryMethod, Recording = recording, Secure = secure};
            return await UpdateAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a TrunkResource object
        /// </summary>
        ///
        /// <param name="json"> Raw JSON string </param>
        /// <returns> TrunkResource object represented by the provided JSON </returns> 
        public static TrunkResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<TrunkResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }
    
        /// <summary>
        /// The account_sid
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The domain_name
        /// </summary>
        [JsonProperty("domain_name")]
        public string DomainName { get; private set; }
        /// <summary>
        /// The disaster_recovery_method
        /// </summary>
        [JsonProperty("disaster_recovery_method")]
        [JsonConverter(typeof(HttpMethodConverter))]
        public Twilio.Http.HttpMethod DisasterRecoveryMethod { get; private set; }
        /// <summary>
        /// The disaster_recovery_url
        /// </summary>
        [JsonProperty("disaster_recovery_url")]
        public Uri DisasterRecoveryUrl { get; private set; }
        /// <summary>
        /// The friendly_name
        /// </summary>
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }
        /// <summary>
        /// The secure
        /// </summary>
        [JsonProperty("secure")]
        public bool? Secure { get; private set; }
        /// <summary>
        /// The recording
        /// </summary>
        [JsonProperty("recording")]
        public object Recording { get; private set; }
        /// <summary>
        /// The auth_type
        /// </summary>
        [JsonProperty("auth_type")]
        public string AuthType { get; private set; }
        /// <summary>
        /// The auth_type_set
        /// </summary>
        [JsonProperty("auth_type_set")]
        public List<string> AuthTypeSet { get; private set; }
        /// <summary>
        /// The date_created
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The date_updated
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }
        /// <summary>
        /// The sid
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// The url
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }
        /// <summary>
        /// The links
        /// </summary>
        [JsonProperty("links")]
        public Dictionary<string, string> Links { get; private set; }
    
        private TrunkResource()
        {
        
        }
    }

}