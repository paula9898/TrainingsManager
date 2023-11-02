using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TrainingsManager.Backend.Application.HashingPasswordService
{
    public class HashPasswordService
    {
        public bool VerifyPassword(string password, string hash)
        {
            return GenerateHash(password) == hash;
        }

        public string GenerateHash(string password)
        {
            var data = Encoding.UTF8.GetBytes(password);

            using (var sha512Generator = SHA512.Create())
            {
                var hash = sha512Generator.ComputeHash(data);

                var hashInBase64 = Convert.ToBase64String(hash);

                return hashInBase64;
            }
        }
    }
}
