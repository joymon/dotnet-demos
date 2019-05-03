using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace CurrentUserTests
{
    class MD5BasedETagCalculator
    {
        internal static string ComputeHash(string instance)
        {
            var cryptoServiceProvider = new MD5CryptoServiceProvider();

            byte[] byteArray = Encoding.ASCII.GetBytes(instance);
            using (var memoryStream = new MemoryStream(byteArray))
            {
                cryptoServiceProvider.ComputeHash(memoryStream.ToArray());

                return $"\"{String.Join("", cryptoServiceProvider.Hash.Select(c => c.ToString("x2")))}\"";
            }
        }
    }
}