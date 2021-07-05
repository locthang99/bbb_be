using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ThirdPartyServices.Payment.DTO;

namespace ThirdPartyServices.Payment
{
    public interface IMomoService
    {
        public Task<InitPaymentResponse> InitPayment(InitRequest rq);
    }
}
