using System;
using System.IO;

namespace Vigenere
{
    class Program
    {
        static void Main(string[] args)
        {
            var cipher = new VigenereCipher(" АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ-.?!0123456789");

            string path = @"D:\GERASKIN\Vigenere\text.txt";
            var inputText = "";

            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    inputText = sr.ReadToEnd().ToUpper();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("Text: " + inputText);

            Console.Write("Enter Key: ");
            var password = Console.ReadLine().ToUpper();
            var encryptedText = cipher.Encrypt(inputText, password);

            Console.WriteLine("Result of encryption {0}", encryptedText);

            Console.WriteLine("Result of decryption {0}", cipher.Decrypt(encryptedText, password));

            Console.ReadLine();
        }
    }
}
