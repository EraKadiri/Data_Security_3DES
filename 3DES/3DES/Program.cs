using _3DES;
using System.Reflection;

namespace TripleDES
{
    class Program
    {
        static void Main(string[] args)
        {
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

        public static void EncryptDecrypt(string input)
        {
            if (input == "text")
            {
                Console.WriteLine("Enter text to encrypt and decrypt: ");
                string plainText = Console.ReadLine();

                string encryptedText = TripleDes.Encrypt(plainText);
                string decryptedText = TripleDes.Decrypt(encryptedText);

                Console.WriteLine("Before Encryption Text = " + plainText + "\n");
                Console.WriteLine("After Encryption Text = " +
                   encryptedText + "\n");
                Console.WriteLine("After Decryption Text = " +
                   decryptedText + "\n");

            }
            else if (input == "file")
            {

                string workingDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                string path = System.IO.Path.Combine(workingDirectory, "plaintext.txt");
                string readText = File.ReadAllText(path);

                string encryptedText = TripleDes.Encrypt(readText);
                string decryptedText = TripleDes.Decrypt(encryptedText);

                Console.WriteLine("Before Encryption Text = " + readText + "\n");
                Console.WriteLine("After Encryption Text = " +
                   encryptedText + "\n");
                Console.WriteLine("After Decryption Text = " +
                   decryptedText + "\n");

            }
        }
    }

}