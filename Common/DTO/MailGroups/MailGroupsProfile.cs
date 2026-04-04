using AutoMapper;

namespace Common.DTO.MailGroups
{
    public class MailGroupsProfile : Profile
    {
        public MailGroupsProfile()
        {
            CreateMap<MailGroupsRequest, MailGroupsEntity>();
            CreateMap<MailGroupsEntity, MailGroupsResponse>();
            CreateMap<MailGroupsEntity, MailGroupsDocument>();
            CreateMap<MailGroupsDocument, MailGroupsEntity>();
        }
    }

}
