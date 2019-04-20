using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace AspNetCore.Infrastructure.Secret
{
    public class SecretHelper
    {
        private readonly static string salt = "j83b46AwjsC/DZvNXnIB3Q==";
        public static string GenerateHashSecret(string password)
        {
            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
            password: password,
            salt: Convert.FromBase64String(salt),
            prf: KeyDerivationPrf.HMACSHA1,
            iterationCount: 10000,
            numBytesRequested: 256 / 8));
     
            return hashed;
        }

        public static byte[] GenerateSalt()
        {
            byte[] salt = new byte[128 / 8];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);

                var saltstring = Convert.ToBase64String(salt);
               
            }
            return salt;
        }

    }
}
