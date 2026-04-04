using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Entities;
using AetherCore.Entities;

namespace Common.DTO.MailLogs
{
    public enum SendResult
    {
        Success, Failure
    }

    public class MailLogsDocument : IEntity, IDBEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id                { get; set; }   = string.Empty;
        public DateTime CreatedAt       { get; set; }                                     // 建立時間
        public DateTime UpdatedAt       { get; set; }                                     // 更新時間

        public string ToEmail           { get; set; }   = string.Empty;
        public string Subject           { get; set; }   = string.Empty;
        public string SendGroup         { get; set; }   = string.Empty;
        public SendResult SendResult    { get; set; }   = SendResult.Failure;
        public string ResultDesc        { get; set; }   = string.Empty;

        // 實作 IEntity
        public object GenerateNewID()   => ObjectId.GenerateNewId().ToString()!;
        public bool HasDefaultID()      => string.IsNullOrEmpty(Id);
    }
}
