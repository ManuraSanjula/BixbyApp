namespace Bixby_web_server.Helpers;
public class EncryptionHelper
{
    public static string Encrypt(string text, int shift)
    {
        char[] chars = text.ToCharArray();
        for (int i = 0; i < chars.Length; i++)
        {
            char c = chars[i];
            if (char.IsLetter(c))
            {
                char baseChar = char.IsUpper(c) ? 'A' : 'a';
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
