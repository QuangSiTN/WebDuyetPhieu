using System;
using System.Security.Cryptography;
using System.Text;

namespace DuyetPhieu.Server.CodeMD5
{
	public class CryptMD5
    {
        public string Encrypt(string toEncrypt, string key, bool useHashing)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(toEncrypt);
            byte[] numArray = !useHashing ? Encoding.UTF8.GetBytes(key) : new MD5CryptoServiceProvider().ComputeHash(Encoding.UTF8.GetBytes(key));
            TripleDESCryptoServiceProvider cryptoServiceProvider = new TripleDESCryptoServiceProvider();
            cryptoServiceProvider.Key = numArray;
            cryptoServiceProvider.Mode = CipherMode.ECB;
            cryptoServiceProvider.Padding = PaddingMode.PKCS7;
            byte[] inArray = cryptoServiceProvider.CreateEncryptor().TransformFinalBlock(bytes, 0, bytes.Length);
            return Convert.ToBase64String(inArray, 0, inArray.Length);
        }

        public string Decrypt(string toDecrypt, string key, bool useHashing)
        {
            byte[] inputBuffer = Convert.FromBase64String(toDecrypt);
            byte[] numArray = !useHashing ? Encoding.UTF8.GetBytes(key) : new MD5CryptoServiceProvider().ComputeHash(Encoding.UTF8.GetBytes(key));
            TripleDESCryptoServiceProvider cryptoServiceProvider = new TripleDESCryptoServiceProvider();
            cryptoServiceProvider.Key = numArray;
            cryptoServiceProvider.Mode = CipherMode.ECB;
            cryptoServiceProvider.Padding = PaddingMode.PKCS7;
            return Encoding.UTF8.GetString(cryptoServiceProvider.CreateDecryptor().TransformFinalBlock(inputBuffer, 0, inputBuffer.Length));
        }
    }
}
