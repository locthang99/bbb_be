using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdPartyServices.Deeplearning.DTO
{
    public class Model
    {
        public int no { get; set; }
        public string name { get; set; }
        public string typeNetwork { get; set; }
        public bool isAvailable { get; set; }
        public string typeMusic { get; set; }
        public string acc { get; set; }
        public int totalTrain { get; set; }
        public string parameters { get; set; }
    }
    public class List_Models
    {
        public List<Model> data { get; set; }
    }
}
