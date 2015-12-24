using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace DataEncryption
{
    class Program
    {
        static void Main(string[] args)
        {

            Object obj = "Home";
            var hashCode = obj.GetHashCode();

            Console.WriteLine(hashCode);

            obj = "Houssem";
            var hashCode2 = obj.GetHashCode();
            Console.WriteLine(hashCode2);

            EncryptSomeTextUsingAES();

            EncryptAndDecryptDataUsingRSA();
        }

        private static void EncryptAndDecryptDataUsingRSA()
        {

            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            string publicKeyXml = rsa.ToXmlString(false);
            string privateKeyXml = rsa.ToXmlString(true);
            Console.WriteLine("publicKeyXml: ");
            Console.WriteLine(publicKeyXml);
            Console.WriteLine("privateKeyXml: ");
            Console.WriteLine(privateKeyXml);

            var encrypedData = EncryptDataUsingRSA("My Secret Data!", publicKeyXml);

            Console.WriteLine("encrypedData : " + Encoding.UTF8.GetString(encrypedData).TrimEnd('\0'));

            var decryptedString = DecryptDataUsingRSA(encrypedData, privateKeyXml);

            Console.WriteLine("decryptedString : " + decryptedString); // Displays: My Secret Data!
        }

        private static string DecryptDataUsingRSA(byte[] encrypedData, string privateKeyXml)
        {

            byte[] decryptedData;
            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
            {
                RSA.FromXmlString(privateKeyXml);
                decryptedData = RSA.Decrypt(encrypedData, false);
            }

            UnicodeEncoding byteConverter = new UnicodeEncoding();
            string decryptedString = byteConverter.GetString(decryptedData);

            return decryptedString;
        }

        private static byte[] EncryptDataUsingRSA(string str, string publicKeyXml)
        {

            UnicodeEncoding byteConverter = new UnicodeEncoding();
            byte[] dataToEncrypt = byteConverter.GetBytes(str);
            byte[] encryptedData;

            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
            {
                RSA.FromXmlString(publicKeyXml);
                encryptedData = RSA.Encrypt(dataToEncrypt, false);

                return encryptedData;
            }
        }


        public static void EncryptSomeTextUsingAES()
        {
            string original = "My secret data!";

            using (SymmetricAlgorithm symmetricAlgorithm = new AesManaged())
            {
                byte[] encrypted = Encrypt(symmetricAlgorithm, original);
                string roundtrip = Decrypt(symmetricAlgorithm, encrypted);
                // Displays: My secret data!
                // Displays: My secret data!
                Console.WriteLine("Original: {0}", original);
                Console.WriteLine("Round Trip: {0}", roundtrip);


                Console.WriteLine("encrypted: " + Encoding.UTF8.GetString(encrypted).TrimEnd('\0'));
            }
        }

        static byte[] Encrypt(SymmetricAlgorithm aesAlg, string plainText)
        {

            ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

            using (MemoryStream msEncrypt = new MemoryStream())
            {
                using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                {
                    using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                    {
                        swEncrypt.Write(plainText);
                    }

                    return msEncrypt.ToArray();
                }
            }
        }

        static string Decrypt(SymmetricAlgorithm aesAlg, byte[] cipherText)
        {

            ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

            using (MemoryStream msDecrypt = new MemoryStream(cipherText))
            {
                using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                {
                    using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                    {
                        return srDecrypt.ReadToEnd();
                    }
                }
            }
        }
    }
}
