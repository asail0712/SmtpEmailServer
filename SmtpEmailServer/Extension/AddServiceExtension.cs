using Service;
using Service.Interface;
using AetherCore.Module.Interface;
using AetherCore.Module.AI;
using AetherCore.Module.Mail;

namespace SmtpEmailServer.Extension
{
    public static class AddServiceExtension
    {
        static public void SlaveServices(this IServiceCollection services)
        {
            /***********************************************************************************************
            * add Singleton Services
            ************************************************************************************************/
            services.AddSingleton<ISmtpEmailSender, SmtpEmailSender>(); // Email 寄信服務

            /***********************************************************************************************
            * 讓 DI 容器可以提供 IHttpContextAccessor
            ************************************************************************************************/
            services.AddHttpContextAccessor();
        }
    }
}
