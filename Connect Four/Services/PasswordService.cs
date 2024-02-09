using System.Security.Cryptography;
using System.Text;

namespace Connect_four.Services;

public class PasswordService
{
    private readonly HashAlgorithmName _hashAlgorithmName = HashAlgorithmName.SHA512;

    private const int KeySize = 64;
    private const int Iterations = 350000;

    public string HashPassword(string clearPassword, out byte[] salt)
    {
        salt = RandomNumberGenerator.GetBytes(KeySize);

        var hash = Rfc2898DeriveBytes.Pbkdf2(
            Encoding.UTF8.GetBytes(clearPassword),
            salt,
            Iterations,
            _hashAlgorithmName,
            KeySize
            );

        return Convert.ToHexString(hash);
    }
    
}