using System;
using System.IO;
using System.Security.Cryptography;

namespace Workshop
{
    #region TripleDES�㷨

    public class ClassTripleDES
    {
        public ClassTripleDES()
        {
        }

        /// <summary>
        /// �����㷨�Ĺ�Կ
        /// </summary>
        public static string passswordkey = "VansCard";

        /// <summary>
        /// ���ܣ�ʹ��������������㷨�Ĺ�Կ����ʹ��TripleDES��������м��ܡ�
        /// </summary>
        /// <param name="pass"></param>
        /// <returns></returns>
        public static string Encrypt(string pass)
        {
            try
            {
                byte[] bt = (new System.Text.UnicodeEncoding()).GetBytes(pass);
                PasswordDeriveBytes pdb = new PasswordDeriveBytes(pass, null);
                byte[] key = pdb.GetBytes(24);
                byte[] iv = pdb.GetBytes(8);
                MemoryStream ms = new MemoryStream();
                TripleDESCryptoServiceProvider tdesc = new TripleDESCryptoServiceProvider();
                CryptoStream cs = new CryptoStream(ms, tdesc.CreateEncryptor(key, iv), CryptoStreamMode.Write);
                cs.Write(bt, 0, bt.Length);
                cs.FlushFinalBlock();
                return Convert.ToBase64String(ms.ToArray());
            }
            catch
            {
                return "";
            }
        }

        /// <summary>
        /// ���ܣ�ʹ��������������㷨�Ĺ�Կ����ʹ��TripleDES�Լ������ݽ��н��ܡ�
        /// </summary>
        /// <param name="str"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
        public static string Decrypt(string str, string pass)
        {
            try
            {
                byte[] bt = Convert.FromBase64String(str);
                PasswordDeriveBytes pdb = new PasswordDeriveBytes(pass, null);
                byte[] key = pdb.GetBytes(24);
                byte[] iv = pdb.GetBytes(8);
                MemoryStream ms = new MemoryStream();
                TripleDESCryptoServiceProvider tdesc = new TripleDESCryptoServiceProvider();
                CryptoStream cs = new CryptoStream(ms, tdesc.CreateDecryptor(key, iv), CryptoStreamMode.Write);
                cs.Write(bt, 0, bt.Length);
                cs.FlushFinalBlock();
                return (new System.Text.UnicodeEncoding()).GetString(ms.ToArray());
            }
            catch
            {
                return "";
            }
        }

        //ʹ�ã�
        //string str = Encrypt("bbb");
        //Console.WriteLine(Decrypt(str, "bbb"));

        /// <summary>
        /// ���ܣ�ʹ��������������㷨�Ĺ�Կ����ʹ��TripleDES��������м��ܡ�
        /// </summary>
        /// <param name="pass"></param>
        /// <param name="p_key"></param>
        /// <returns></returns>
        public static string EncryptWithKey(string pass, string p_key)
        {
            try
            {
                byte[] bt = (new System.Text.UnicodeEncoding()).GetBytes(pass);
                PasswordDeriveBytes pdb = new PasswordDeriveBytes(p_key, null);
                byte[] key = pdb.GetBytes(24);
                byte[] iv = pdb.GetBytes(8);
                MemoryStream ms = new MemoryStream();
                TripleDESCryptoServiceProvider tdesc = new TripleDESCryptoServiceProvider();
                CryptoStream cs = new CryptoStream(ms, tdesc.CreateEncryptor(key, iv), CryptoStreamMode.Write);
                cs.Write(bt, 0, bt.Length);
                cs.FlushFinalBlock();
                return Convert.ToBase64String(ms.ToArray());
            }
            catch
            {
                return "";
            }
        }

        /// <summary>
        /// ���ܣ�ʹ��������������㷨�Ĺ�Կ����ʹ��TripleDES�Լ������ݽ��н��ܡ�
        /// </summary>
        /// <param name="str"></param>
        /// <param name="p_key"></param>
        /// <returns></returns>
        public static string DecryptWithKey(string str, string p_key)
        {
            try
            {
                byte[] bt = Convert.FromBase64String(str);
                PasswordDeriveBytes pdb = new PasswordDeriveBytes(p_key, null);
                byte[] key = pdb.GetBytes(24);
                byte[] iv = pdb.GetBytes(8);
                MemoryStream ms = new MemoryStream();
                TripleDESCryptoServiceProvider tdesc = new TripleDESCryptoServiceProvider();
                CryptoStream cs = new CryptoStream(ms, tdesc.CreateDecryptor(key, iv), CryptoStreamMode.Write);
                cs.Write(bt, 0, bt.Length);
                cs.FlushFinalBlock();
                return (new System.Text.UnicodeEncoding()).GetString(ms.ToArray());
            }
            catch
            {
                return "";
            }
        }

    }

    #endregion

}
