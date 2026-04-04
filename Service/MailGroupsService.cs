using AetherCore.Service;
using AetherCore.Utility.Attributes;
using AutoMapper;
using Common.DTO.MailGroups;
using Microsoft.Extensions.DependencyInjection;
using Repository.Interface;
using Service.Interface;

namespace Service
{
    [AutoInject(ServiceLifetime.Scoped)]
    public class MailGroupsService : GenericService<MailGroupsEntity, MailGroupsRequest, MailGroupsResponse, IMailGroupsRepository>, IMailGroupsService
    {
        public MailGroupsService(IMailGroupsRepository repo, IMapper mapper) 
            : base(repo, mapper)
        {
        }
    }
}
