using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdPartyServices.Deeplearning.DTO
{
    public class List_ResponsePredict
    {
        public List<ResponsePredict> data { get; set; }
    }
    public class ResponsePredict
    {
        public string time { get; set; }
        public List<TypePredict> predict {get;set;}
    }
    public class TypePredict
    {
        public string nameType { get; set; }
        public int typeId { get; set; }
        public float value { get; set; }
    }
}
