using AutoMapper;

namespace Common.DTO.MailMessages
{
    public class MailMessagesProfile : Profile
    {
        public MailMessagesProfile()
        {
            CreateMap<MailMessagesRequest, MailMessagesEntity>();
            CreateMap<MailMessagesEntity, MailMessagesResponse>();
            CreateMap<MailMessagesEntity, MailMessagesDocument>();
            CreateMap<MailMessagesDocument, MailMessagesEntity>();
        }
    }

}
