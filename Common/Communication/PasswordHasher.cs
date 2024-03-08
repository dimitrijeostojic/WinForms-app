using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class PasswordHasher
    {
        // Metoda za generisanje heša lozinke
        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                // Pretvaranje lozinke u bajt niz
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

                // Računanje heša
                byte[] hashBytes = sha256.ComputeHash(passwordBytes);

                // Pretvaranje heša nazad u string
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }

        // Metoda za proveru podudaranja unete i heširane lozinke
        public static bool VerifyPassword(string enteredPassword, string storedHash)
        {
            // Heširanje unete lozinke i provera podudaranja sa hešem u bazi
            return HashPassword(enteredPassword) == storedHash;
        }
    }
}
