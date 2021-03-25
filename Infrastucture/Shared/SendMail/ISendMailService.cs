using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ThirdPartyServices.SendMail
{
    public interface ISendMailService
    {
        Task<bool> SendMailNotify(string subject, string body, string receiver);
        Task<bool> SendMailResetPwd();
        Task<bool> SendMailConfirmPwd();

    }
}
