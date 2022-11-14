using System.Collections.Generic;

namespace In.ProjectEKA.OtpService.Clients
{
    public class D7Message
    {
        private string channel;
        private List<string> recipients;
        private string content;
        private string msg_type;
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