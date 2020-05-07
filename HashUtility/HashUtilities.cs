using System.Security.Cryptography;
using System.Text;

namespace HashUtility
{
    public class HashUtilities
    {
        public static string GenerateHash(string stringToHash)
        {
            var crypt = new SHA512Managed();
            var hash = new StringBuilder();
            var crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(stringToHash), 0,
                Encoding.UTF8.GetByteCount(stringToHash));

            foreach (var bit in crypto)
            {
                hash.Append(bit.ToString("x2"));
            }

            return hash.ToString();
        }
    }
}