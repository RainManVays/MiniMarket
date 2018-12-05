using System;
using System.Security.Cryptography;
using System.Text;

namespace MiniMarket.Infrastructure
{
    public  class Crypto
    {
        public static string GetStringSha1(string value)
        {
            using(var hashManager= new SHA1Managed())
            {
                var hash = hashManager.ComputeHash(Encoding.UTF8.GetBytes(value));
                return Convert.ToBase64String(hash);
            }
        }

    }
}
