using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Helpers.Security
{
    public class Key
    {
        public static string Secret = GenerateSecretKey();

        public static string GenerateSecretKey()
        {
            const int keyLength = 32; // 256 bits
            using (var rng = new RNGCryptoServiceProvider())
            {
                var keyBytes = new byte[keyLength];
                rng.GetBytes(keyBytes);
                return Convert.ToBase64String(keyBytes);
            }
        }
    }
}
