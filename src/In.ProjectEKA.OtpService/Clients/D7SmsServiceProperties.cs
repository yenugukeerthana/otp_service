namespace In.ProjectEKA.OtpService.Clients
{
    public class D7SmsServiceProperties
    {
        public string Token { get; }
        public string Channel { get; }

        public D7SmsServiceProperties(string token, string channel)
        {
            Token = token;
            Channel = channel;
        }
        
    }
}