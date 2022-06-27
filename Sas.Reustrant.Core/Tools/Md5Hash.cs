using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Sas.Reustrant.Core.Tools
{
   public static class Md5Hash
    {
        public static string HashMd5(string data)
        {
            using (MD5 md5=System.Security.Cryptography.MD5.Create())
            {
                byte[] input = System.Text.Encoding.ASCII.GetBytes(data);
                byte[] hashBytes = md5.ComputeHash(input);
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    builder.Append(hashBytes[i].ToString("X2"));
                }
                return builder.ToString();
            }
            
        }
    }
}
