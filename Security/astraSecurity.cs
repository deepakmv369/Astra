using System.Security.Cryptography;
using System.Text;
using Konscious.Security.Cryptography;

namespace Astra_MK1.Security
{
    public class astraSecurity
    {
        public byte[] createSalt()
        {
            var buffer = new byte[16];
            var rng = RandomNumberGenerator.Create();
            rng.GetBytes(buffer);
            return buffer;
        }

        public byte[] hashPassword(string password, byte[] salt)
        {
            var argon2 = new Argon2id(Encoding.UTF8.GetBytes(password));
            argon2.Salt = salt;
            argon2.DegreeOfParallelism = 8;
            argon2.Iterations = 4;
            argon2.MemorySize = 1024*1024;
            return argon2.GetBytes(16);
        }

        public bool verifyHash(string password, byte[] _salt, byte[] hash)
        {
            var newHash = hashPassword(password, _salt);
            return hash.SequenceEqual(newHash);
        }
    }
}