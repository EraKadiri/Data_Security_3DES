using _3DES;

namespace _3DES
{
    class Program
    {
        static void Main(string[] args)
        {
            string encryptedText = TripleDES.Encrypt("hello world");
        }
    }
}