using _3DES;

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
        }
    }
}