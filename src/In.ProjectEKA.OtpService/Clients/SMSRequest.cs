namespace In.ProjectEKA.OtpService.Clients
{
    public class SMSRequest
    {
        public string PhoneNumber { get; }
        public string Message { get;  }
        
        public SMSRequest(string phoneNumber, string message)
        {
            PhoneNumber = phoneNumber;
            Message = message;
        }
    }
}