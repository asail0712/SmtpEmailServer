using AetherCore.DTO.Mail;
using AetherCore.Module.Interface;
using AetherCore.Service;
using AetherCore.Utility.Attributes;
using AutoMapper;
using Common.DTO.MailGroups;
using Common.DTO.MailLogs;
using Common.DTO.MailMessages;
using Microsoft.Extensions.DependencyInjection;
using Repository.Interface;
using Service.Interface;

namespace Service
{
    [AutoInject(ServiceLifetime.Scoped)]
    public class MailMessagesService : GenericService<MailMessagesEntity, MailMessagesRequest, MailMessagesResponse, IMailMessagesRepository>, IMailMessagesService
    {
        private readonly IMailGroupsRepository _mailGroupsRepository;
        private readonly IMailLogsRepository _mailLogsRepository;
        private readonly ISmtpEmailSender _smtpEmailSender;

        public MailMessagesService(IMailMessagesRepository repo, 
                                    IMapper mapper,
                                    IMailGroupsRepository mailGroupsRepository,
                                    IMailLogsRepository mailLogsRepository,
                                    ISmtpEmailSender smtpEmailSender) 
            : base(repo, mapper)
        {
            _mailGroupsRepository   = mailGroupsRepository;
            _mailLogsRepository     = mailLogsRepository;
            _smtpEmailSender        = smtpEmailSender;
        }

        public async Task<bool> SendMail(MailMessagesRequest request, string serviceId)
        {
            MailGroupsEntity entity = await _mailGroupsRepository.GetAsync(request.SendGroup);

            if (entity == null)
            {
                return false;
            }

            // 寄送內容
            MessageInfo messageInfo = new MessageInfo() 
            {
                ToEmail     = request.ToMail,
                Subject     = request.Subject,
                TextBody    = request.TextBody
            };

            // 寄送者設定
            SenderGroup senderGroup = new SenderGroup()
            {
                FromName    = entity.FromName,
                FromMail    = entity.FromEmail,
                Host        = entity.Host,
                Port        = entity.Port,
                UserName    = entity.UserName,
                Password    = entity.Password,
            };

            bool bResult                = false;
            MailLogsEntity logEntity    = new MailLogsEntity();

            logEntity.CreatedAt     = DateTime.UtcNow;
            logEntity.UpdatedAt     = DateTime.UtcNow;
            logEntity.ToEmail       = request.ToMail;
            logEntity.Subject       = request.Subject;
            logEntity.SendGroup     = request.SendGroup;
            logEntity.ServiceId     = serviceId;

            try
            {
                // 實際寄送
                await _smtpEmailSender.SendAsync(messageInfo, senderGroup);

                logEntity.SendResult    = SendResult.Success;
                logEntity.ResultDesc    = string.Empty;
                bResult                 = true;
            }
            catch (Exception ex)
            {
                logEntity.SendResult    = SendResult.Failure;
                logEntity.ResultDesc    = ex.Message;
                bResult                 = false;
            }
            finally
            {
                // 將寄送結果備存
                await _mailLogsRepository.InsertAsync(logEntity);
            }

            return bResult;
        }
    }
}
