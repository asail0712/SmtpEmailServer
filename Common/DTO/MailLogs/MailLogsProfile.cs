using AutoMapper;

namespace Common.DTO.MailLogs
{
    public class MailLogsProfile : Profile
    {
        public MailLogsProfile()
        {
            CreateMap<MailLogsRequest, MailLogsEntity>();
            CreateMap<MailLogsEntity, MailLogsResponse>();
            CreateMap<MailLogsEntity, MailLogsDocument>();
            CreateMap<MailLogsDocument, MailLogsEntity>();
        }
    }

}
