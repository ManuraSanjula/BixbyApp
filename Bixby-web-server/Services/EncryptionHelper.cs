using System;
using System.Security.Cryptography;
using System.Text;


namespace BixbyShop_LK.Services {
    public static class EncryptionHelper
    {
        private static readonly string key = "nfjdwhjeceehchebjcbhebcebhcbevhe";
        
        public static string Decrypt(string ciphertext)
        {
            byte[] combinedData = Convert.FromBase64String(ciphertext);

            using (Aes aesAlg = Aes.Create())
            {
                int ivSize = aesAlg.BlockSize / 8;
                byte[] iv = new byte[ivSize];
                byte[] encryptedData = new byte[combinedData.Length - ivSize];

                Array.Copy(combinedData, 0, iv, 0, ivSize);
                Array.Copy(combinedData, ivSize, encryptedData, 0, encryptedData.Length);

                aesAlg.Key = Encoding.UTF8.GetBytes(key);
                aesAlg.IV = iv;

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                string plaintext;

                using (var msDecrypt = new System.IO.MemoryStream(encryptedData))
                {
                    using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (var srDecrypt = new System.IO.StreamReader(csDecrypt))
                        {
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }

                return plaintext;
            }
        }
    }
}