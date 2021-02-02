using System;
using System.Collections.Generic;
using System.Text;

namespace Phonebook.Utilities.Helpers
{
    public class PasswordEncryptor
    {
        public static List<byte[]> EncryptPassword(string password)
        {
            byte[] passwordSalt, passwordHash;

            // convert password to hash value and generate salt
            using (var hash = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hash.Key;
                passwordHash = hash.ComputeHash(Encoding.UTF8.GetBytes(password));
            }

            var result = new List<byte[]>
            {
                passwordHash,
                passwordSalt
            };

            return result;
        }

        public static bool ComparePassword(byte[] passwordSalt, byte[] passwordHash, string password)
        {
            using (var hash = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                var hashGenerated = hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < hashGenerated.Length; i++)
                {
                    if (hashGenerated[i] != passwordHash[i])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
