using _3DES;
using System.Reflection;

namespace _3DES
{
    class Program
    {
        static void Main(string[] args)
        {
            string encryptedText = TripleDES.Encrypt("hello world");
            Console.WriteLine("Do you want to encrypt text or file?: ");
            string input = Console.ReadLine();
            input = input.ToLower();

            while (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Please only answer with 'text' or 'file'");
                input = Console.ReadLine();
            }
            EncryptDecrypt(input);
            Console.WriteLine("Do you want to repeat (y/n): ");
            string continueInput = Console.ReadLine();
            while (continueInput.ToLower() == "y")
            {
                Console.WriteLine("Do you want to encrypt text or file?: ");
                input = Console.ReadLine();
                input = input.ToLower();

                     while (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Please only answer with 'text' or 'file'");
                    input = Console.ReadLine();
                }

                EncryptDecrypt(input);

                Console.WriteLine("Do you want to repeat (y/n): ");
                continueInput = Console.ReadLine();

            }
        }
    }
}