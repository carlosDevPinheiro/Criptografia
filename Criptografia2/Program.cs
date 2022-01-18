using System;
using System.Net.WebSockets;
using System.Security.Cryptography;

namespace Criptografia2
{
    internal class Program
    {


        // http://msdn.microsoft.com/en-us/library/system.security.cryptography.symmetricalgorithm.aspx
        static void Main(string[] args)
        {
            string textoOutput = "antonio";

            var criptografado = Cryptography.Encrypt<RijndaelManaged>(textoOutput, "123456");
            var original = Cryptography.Decrypt<RijndaelManaged>(criptografado, "123458989");

            var criptografado2 = Cryptography.Encrypt<RijndaelManaged>(textoOutput, "123456");
            var original2 = Cryptography.Decrypt<RijndaelManaged>(criptografado, "123456");

            if (string.Equals(textoOutput, original))
            {
                Console.WriteLine("funcionou");
            };
        }
    }
}
