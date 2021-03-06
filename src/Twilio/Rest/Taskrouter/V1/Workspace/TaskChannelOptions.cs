using System;
using System.Collections.Generic;
using Twilio.Base;

namespace Twilio.Rest.Taskrouter.V1.Workspace 
{

    /// <summary>
    /// FetchTaskChannelOptions
    /// </summary>
    public class FetchTaskChannelOptions : IOptions<TaskChannelResource> 
    {
        /// <summary>
        /// The workspace_sid
        /// </summary>
        public string PathWorkspaceSid { get; }
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }
    
        /// <summary>
        /// Construct a new FetchTaskChannelOptions
        /// </summary>
        ///
        /// <param name="pathWorkspaceSid"> The workspace_sid </param>
        /// <param name="pathSid"> The sid </param>
        public FetchTaskChannelOptions(string pathWorkspaceSid, string pathSid)
        {
            PathWorkspaceSid = pathWorkspaceSid;
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
    /// ReadTaskChannelOptions
    /// </summary>
    public class ReadTaskChannelOptions : ReadOptions<TaskChannelResource> 
    {
        /// <summary>
        /// The workspace_sid
        /// </summary>
        public string PathWorkspaceSid { get; }
    
        /// <summary>
        /// Construct a new ReadTaskChannelOptions
        /// </summary>
        ///
        /// <param name="pathWorkspaceSid"> The workspace_sid </param>
        public ReadTaskChannelOptions(string pathWorkspaceSid)
        {
            PathWorkspaceSid = pathWorkspaceSid;
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