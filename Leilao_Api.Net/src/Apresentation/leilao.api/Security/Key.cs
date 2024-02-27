using System.Security.Cryptography;

namespace leilao.api.Security
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
