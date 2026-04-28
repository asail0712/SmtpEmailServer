using AetherCore.Entities;

namespace Common.DTO.MailLogs
{
    public class MailLogsEntity : IDBEntity
    {        
        public string Id                { get; set; }   = string.Empty;
        public DateTime CreatedAt       { get; set; }             // 建立時間
        public DateTime UpdatedAt       { get; set; }             // 更新時間

        public string ToEmail           { get; set; }   = string.Empty;
        public string Subject           { get; set; }   = string.Empty;
        public string SendGroup         { get; set; }   = string.Empty;
        public string ServiceId         { get; set; }   = string.Empty;
        public SendResult SendResult    { get; set; }   = SendResult.Failure;
        public string ResultDesc        { get; set; }   = string.Empty;
        public MailLogsEntity() 
        {
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
        }
    }
}
