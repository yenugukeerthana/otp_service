namespace In.ProjectEKA.OtpService.Clients
{
    public class D7SmsServiceProperties
    {
        public string Token { get; }
        public string Channel { get; }
        public string Originator { get; }

        public D7SmsServiceProperties(string token, string channel,string originator)
        {
            Token = token;
            Channel = channel;
            Originator = originator;
        }
        
    }
}