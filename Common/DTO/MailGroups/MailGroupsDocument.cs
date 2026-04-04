using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Entities;
using AetherCore.Entities;

namespace Common.DTO.MailGroups
{
    public class MailGroupsDocument : IEntity, IDBEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }              = string.Empty;
        public DateTime CreatedAt { get; set; }                                     // 建立時間
        public DateTime UpdatedAt { get; set; }                                     // 更新時間

        public string GroupName { get; set; }       = string.Empty;
        public string FromName { get; set; }        = string.Empty;
        public string FromEmail { get; set; }       = string.Empty;
        public string Host { get; set; }            = string.Empty;
        public int Port { get; set; }               = 0;
        public string UserName { get; set; }        = string.Empty;
        public string Password { get; set; }        = string.Empty;

        // 實作 IEntity
        public object GenerateNewID()   => ObjectId.GenerateNewId().ToString()!;
        public bool HasDefaultID()      => string.IsNullOrEmpty(Id);
    }
}
