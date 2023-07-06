namespace Bixby_web_server.Helpers;

public class EncryptionHelper
{
    public static string Encrypt(string text, int shift)
    {
        var chars = text.ToCharArray();
        for (var i = 0; i < chars.Length; i++)
        {
            var c = chars[i];
            if (char.IsLetter(c))
            {
                var baseChar = char.IsUpper(c) ? 'A' : 'a';
                c = (char)((c - baseChar + shift) % 26 + baseChar);
            }

            chars[i] = c;
        }

        return new string(chars);
    }

    public static string Decrypt(string cipherText, int shift)
    {
        return Encrypt(cipherText, 26 - shift);
    }
}