using System.Security.Cryptography;
using System.Text;

namespace BixbyShop_LK.Services;

public static class EncryptionHelper
{
    private static readonly string key = "nfjdwhjeceehchebjcbhebcebhcbevhe";

    public static string Decrypt(string ciphertext)
    {
        var combinedData = Convert.FromBase64String(ciphertext);

        using (var aesAlg = Aes.Create())
        {
            var ivSize = aesAlg.BlockSize / 8;
            var iv = new byte[ivSize];
            var encryptedData = new byte[combinedData.Length - ivSize];

            Array.Copy(combinedData, 0, iv, 0, ivSize);
            Array.Copy(combinedData, ivSize, encryptedData, 0, encryptedData.Length);

            aesAlg.Key = Encoding.UTF8.GetBytes(key);
            aesAlg.IV = iv;

            var decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

            string plaintext;

            using (var msDecrypt = new MemoryStream(encryptedData))
            {
                using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                {
                    using (var srDecrypt = new StreamReader(csDecrypt))
                    {
                        plaintext = srDecrypt.ReadToEnd();
                    }
                }
            }

            return plaintext;
        }
    }
}