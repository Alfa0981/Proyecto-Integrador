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
        public static byte[] EncryptData(byte[] data, byte[] entropy)
        {
            return ProtectedData.Protect(data, entropy, DataProtectionScope.CurrentUser);
        }

        public static byte[] DecryptData(byte[] encryptedData, byte[] entropy)
        {
            return ProtectedData.Unprotect(encryptedData, entropy, DataProtectionScope.CurrentUser);
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

