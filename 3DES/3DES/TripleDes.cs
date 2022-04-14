using System.Security.Cryptography;
using System.Text;

namespace _3DES
{
    public class TripleDes
    {
        private const string securityKey = "DataSecurity3DES";

        public static string Encrypt(string TextToEncrypt)
        {
            string encryptedText = "";
            byte[] MyEncryptedArray = UTF8Encoding.UTF8.GetBytes(TextToEncrypt);
            MD5CryptoServiceProvider MyMD5CryptoService = new MD5CryptoServiceProvider();
            return encryptedText;
        }

        public static string Decrypt(string TextToDecrypt)
        {
            //TODO: implement method
        }
    }
}
