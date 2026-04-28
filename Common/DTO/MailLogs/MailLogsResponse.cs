namespace Common.DTO.MailLogs
{
    public class MailLogsResponse
    {
        public string Id                { get; set; }   = string.Empty;
        public DateTime CreatedAt       { get; set; }             // 建立時間

        public string ToEmail           { get; set; }   = string.Empty;
        public string Subject           { get; set; }   = string.Empty;
        public string SendGroup         { get; set; }   = string.Empty;
        public string ServiceId         { get; set; }   = string.Empty;
        public SendResult SendResult    { get; set; }   = SendResult.Failure;
        public string ResultDesc        { get; set; }   = string.Empty;
    }
}
