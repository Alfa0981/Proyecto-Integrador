using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace Services
{
    public abstract class UserEncryption
    {
        private const string key = "Hola Mundo";
        private static readonly byte[] entropy = Encoding.UTF8.GetBytes(key);

        public static string EncryptData(string data)
        {
            byte[] bytes = ProtectedData.Protect(Encoding.UTF8.GetBytes(data), entropy, DataProtectionScope.CurrentUser);
            return Convert.ToBase64String(bytes);
        }

        public static string DecryptData(string encryptedData)
        {
            byte[] bytes = ProtectedData.Unprotect(Convert.FromBase64String(encryptedData), entropy, DataProtectionScope.CurrentUser);
            return Encoding.UTF8.GetString(bytes);
        }

        public static string HashSHA256(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = sha256.ComputeHash(inputBytes);

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    builder.Append(hashBytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}

