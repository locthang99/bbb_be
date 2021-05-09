using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdPartyServices.Hash
{
    public interface IHashService
    {
        public string Sha256Hash(string data);
        public string Base64Encode(string data);
        public string Base64Decode(string data);
    }
}
