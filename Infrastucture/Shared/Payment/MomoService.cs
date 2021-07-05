using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using ThirdPartyServices.Payment.DTO;

namespace ThirdPartyServices.Payment
{
    public class MomoService : IMomoService
    {
        private readonly IConfiguration _config;
        private readonly IHttpClientFactory _httpClientFactoty;
        public MomoService(IConfiguration config, IHttpClientFactory httpClientFactoty)
        {
            _config = config;
            _httpClientFactoty = httpClientFactoty;
        }
        public async Task<InitPaymentResponse> InitPayment(InitRequest rq)
        {
            string rawSignature = "partnerCode=" + _config["Momo_Key:Partner_Code"] 
                                + "&accessKey=" 
                                + _config["Momo_Key:Access_Key"]
                                + "&requestId=" + rq.requestId 
                                + "&amount=" + rq.amount 
                                + "&orderId="
                                + rq.orderId + "&orderInfo=" + rq.orderInfo + "&returnUrl=" + rq.returnUrl
                                + "&notifyUrl=" + rq.notifyUrl + "&extraData=" + rq.extraData;

            InitPaymentRequest fullRq = new InitPaymentRequest(rq);
            fullRq.accessKey = _config["Momo_Key:Access_Key"];
            fullRq.partnerCode = _config["Momo_Key:Partner_Code"];
            fullRq.requestType = "captureMoMoWallet";
            fullRq.signature = getHash(rawSignature);

            var fullRqJson = JsonConvert.SerializeObject(fullRq);
            var body = new StringContent(fullRqJson, System.Text.Encoding.UTF8, "application/json");
            var rs = await _httpClientFactoty.CreateClient().PostAsync(_config["Momo_Key:Api_Endpoint"],body);
            rs.EnsureSuccessStatusCode();
            var resp = await rs.Content.ReadAsStringAsync();
            var obj = JsonConvert.DeserializeObject<InitPaymentResponse>(resp);
            return obj;
        }
        private string getHash(string input)
        {

            ASCIIEncoding encoding = new ASCIIEncoding();
            Byte[] textBytes = encoding.GetBytes(input);
            Byte[] keyBytes = encoding.GetBytes(_config["Momo_Key:Secret_Key"]);
            Byte[] hashBytes;
            using (HMACSHA256 hash = new HMACSHA256(keyBytes)) hashBytes = hash.ComputeHash(textBytes);
            return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
        }
    }
}
