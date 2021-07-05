using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdPartyServices.Payment.DTO
{
    public class InitRequest
    {
        public string notifyUrl { get; set; }
        public string returnUrl { get; set; }
        public string orderId { get; set; }
        public string amount { get; set; }
        public string orderInfo { get; set; }
        public string requestId { get; set; }
        public string extraData { get; set; }
    }
    public class InitPaymentRequest : InitRequest
    {
        public string accessKey { get; set; }
        public string partnerCode { get; set; }
        public string signature { get; set; }
        public string requestType { get; set; }
        public InitPaymentRequest(InitRequest init)
        {
            notifyUrl = init.notifyUrl;
            returnUrl = init.returnUrl;
            orderId = init.orderId;
            amount = init.amount;
            orderInfo = init.orderInfo;
            requestId = init.requestId;
            extraData = init.extraData;
        }
    }
    
}
