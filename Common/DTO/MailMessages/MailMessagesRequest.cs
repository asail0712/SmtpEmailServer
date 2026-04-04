namespace Common.DTO.MailMessages
{
    public class MailMessagesRequest
    {
        public string SendGroup { get; set; }   = string.Empty;
        public string ToMail { get; set; }      = string.Empty;
        public string Subject { get; set; }     = string.Empty;
        public string TextBody { get; set; }    = string.Empty;
    }
}
