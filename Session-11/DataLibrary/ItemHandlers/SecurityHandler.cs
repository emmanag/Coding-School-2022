using DataLibrary.DataClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace DataLibrary.ItemHandlers
{
    public class SecurityHandler
    {
        private const string SECURITY_KEY = "d5ZbRjMthcoonhh9URhz";

        public SecurityHandler()
        {

        }

        public void WritePassFile(string filename, Credential user)
        {
            if (!File.Exists(filename))
            {
                File.Create(filename).Close();
            }
            File.AppendAllText(filename, $"\n{user.Username}:{user.Password}");
        }

        public List<Credential> ReadPassFile(string filename)
        {
            try
            {
                List<Credential> list = new List<Credential>();
                string[] s = File.ReadAllLines(filename);
                foreach (var line in s)
                {
                    if (line != string.Empty)
                    {
                        list.Add(new Credential(line.Split(':')[0])
                        {
                            Password = line.Split(':')[1]
                        });
                    }
                }

                return list;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string EncryptUserPassword(string password)
        {
            // Firstly, we need to have access to two Crypto Services. One of them is
            // MD5 to get the hash of our security key and the other is TripleDES algorithm
            // to actually encrypt the password of the user.
            var md5CryptoService = new MD5CryptoServiceProvider();
            var tripleDESCryptoService = new TripleDESCryptoServiceProvider();

            byte[] arrayToEncrypt = UTF8Encoding.UTF8.GetBytes(password);
            byte[] securityKey = md5CryptoService.ComputeHash(UTF8Encoding.UTF8.GetBytes(SECURITY_KEY));
            byte[] encryptedPassword;

            md5CryptoService.Clear();

            tripleDESCryptoService.Key = securityKey;
            tripleDESCryptoService.Mode = CipherMode.ECB;
            tripleDESCryptoService.Padding = PaddingMode.PKCS7;

            var encryptor = tripleDESCryptoService.CreateEncryptor();
            encryptedPassword = encryptor.TransformFinalBlock(arrayToEncrypt, 0, arrayToEncrypt.Length);
            tripleDESCryptoService.Clear();

            return Convert.ToBase64String(encryptedPassword);
        }

        public string DecryptUserPassword(Credential user)
        {
            // We need to have access to two Crypto Services. One of them is
            // MD5 to get the hash of our security key and the other is TripleDES algorithm
            // to decrypt the password of the given user.
            var md5CryptoService = new MD5CryptoServiceProvider();
            var tripleDESCryptoService = new TripleDESCryptoServiceProvider();

            byte[] arrayToDecrypt = Convert.FromBase64String(user.Password);
            byte[] securityKey = md5CryptoService.ComputeHash(UTF8Encoding.UTF8.GetBytes(SECURITY_KEY));
            byte[] decryptedPassword;

            md5CryptoService.Clear();

            tripleDESCryptoService.Key = securityKey;
            tripleDESCryptoService.Mode = CipherMode.ECB;
            tripleDESCryptoService.Padding = PaddingMode.PKCS7;

            var decryptor = tripleDESCryptoService.CreateDecryptor();
            decryptedPassword = decryptor.TransformFinalBlock(arrayToDecrypt, 0, arrayToDecrypt.Length);
            tripleDESCryptoService.Clear();

            return UTF8Encoding.UTF8.GetString(decryptedPassword);
        }

        public bool ValidateUserCredentials(Credential user, string password)
        {
            if (DecryptUserPassword(user) == password)
            {
                return true;
            }
            return false;
        }

    }

}
