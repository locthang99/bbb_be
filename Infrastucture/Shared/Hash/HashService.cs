using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace ThirdPartyServices.Hash
{
    public class HashService : IHashService
    {
        public string Sha256Hash(string data)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(data));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
        public string Base64Decode(string data)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(data);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }

        public string Base64Encode(string data)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(data);
            return System.Convert.ToBase64String(plainTextBytes);
        }

    }
}
