using AetherCore.Service;
using Common.DTO.MailMessages;

namespace Service.Interface
{
    public interface IMailMessagesService : IService<MailMessagesRequest, MailMessagesResponse>
    {
        Task<bool> SendMail(MailMessagesRequest request, string serviceId);
    }
}
