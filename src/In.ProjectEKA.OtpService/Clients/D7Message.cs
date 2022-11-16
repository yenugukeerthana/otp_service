using System.Collections.Generic;
using Newtonsoft.Json;

namespace In.ProjectEKA.OtpService.Clients
{
    public class D7Message
    {
        [JsonProperty]
        private string channel;
        [JsonProperty]
        private List<string> recipients;
        [JsonProperty]
        private string content;
        [JsonProperty]
        private string msg_type;
        [JsonProperty]
        private string originator;

        public D7Message(string channel, List<string> recipients, string content, string msgType, string originator)
        {
            this.channel = channel;
            this.recipients = recipients;
            this.content = content;
            msg_type = msgType;
            this.originator = originator;
        }
    }
}