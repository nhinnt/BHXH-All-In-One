using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
namespace BHXH.Util
{
  public  class MyCryptor
    {
        public static string Decrypt(string str)
        {
            return System.Text.ASCIIEncoding.ASCII.GetString(Convert.FromBase64String(str));
        }
        public static string Encrypt(string str)
        {
            return Convert.ToBase64String(ASCIIEncoding.ASCII.GetBytes(str));
        }
    }
  public class MyMD5
  {
      public static string Encrypt(string strTextToEncrypt)
      {
          System.Text.UTF32Encoding u = new UTF32Encoding();
          MD5CryptoServiceProvider md = new MD5CryptoServiceProvider();
          return Convert.ToBase64String(md.ComputeHash(u.GetBytes(strTextToEncrypt)));
      }
  }
  public class MyRSA
  {
      public static string Encrypt(string strTextToEncrypt)
      {
          RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
          System.Text.UTF32Encoding u = new UTF32Encoding();
          return Convert.ToBase64String(rsa.Encrypt(u.GetBytes(strTextToEncrypt), false));//a string

      }

  }
}
