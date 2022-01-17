﻿using Microsoft.Win32;
using Sap.Data.Hana;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;

namespace PrizeLevel
{
    public class Globals
    {
        private static string sCon;
        private static string h;
        private static string port;
        private static string u;
        private static string pass;
        private static string db;

        public static string Decrypt(string cipher)
        {
            using (var md5 = new MD5CryptoServiceProvider())
            {
                using (var tdes = new TripleDESCryptoServiceProvider())
                {
                    tdes.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes("FIS@-!ERP$SAP#B1"));
                    tdes.Mode = CipherMode.ECB;
                    tdes.Padding = PaddingMode.PKCS7;

                    using (var transform = tdes.CreateDecryptor())
                    {
                        byte[] cipherBytes = Convert.FromBase64String(cipher);
                        byte[] bytes = transform.TransformFinalBlock(cipherBytes, 0, cipherBytes.Length);
                        transform.Dispose();
                        return UTF8Encoding.UTF8.GetString(bytes);
                    }
                }
            }
        }
        //Get connection string
        public static string ConnectionString
        {
            get
            {
                if (Registry.LocalMachine.OpenSubKey(@"SOFTWARE\WOW6432Node").GetSubKeyNames().Contains("Vietlott"))
                {
                    RegistryKey keyVietlott = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\WOW6432Node\Vietlott");
                    if (keyVietlott.GetValueNames().Contains("HanaHost"))
                        h = keyVietlott.GetValue("HanaHost").ToString();
                    if (keyVietlott.GetValueNames().Contains("HanaPort"))
                        port = keyVietlott.GetValue("HanaPort").ToString();
                    if (keyVietlott.GetValueNames().Contains("HanaUser"))
                        u = keyVietlott.GetValue("HanaUser").ToString();
                    if (keyVietlott.GetValueNames().Contains("HanaPassword"))
                        pass = Decrypt(keyVietlott.GetValue("HanaPassword").ToString());
                    if (keyVietlott.GetValueNames().Contains("HanaDB"))
                        db = keyVietlott.GetValue("HanaDB").ToString();

                    sCon = "Server=" + h + ":" + port + ";UserID=" + u + ";Password=" + pass + ";Current Schema=" + db;

                    return sCon;
                }
                else
                    return null;
            }
        }

        public static DataTable QueryToDataTable(string query)
        {
            HanaConnection connection = new HanaConnection(Globals.ConnectionString);
            if (connection != null)
            {
                HanaDataAdapter da = new HanaDataAdapter(query, connection);
                DataTable dt = new DataTable();
                try
                {
                    da.Fill(dt);
                    da.Dispose();
                    if (connection.State != ConnectionState.Closed)
                        connection.Close();
                    return dt;
                }
                catch (Exception e)
                {
                    da.Dispose();
                    if (connection.State != ConnectionState.Closed)
                        connection.Close();
                    WriteLog(e.ToString());
                    return null;
                }
            }
            return null;
        }

        public static void WriteLog(string msg)
        {
            File.AppendAllText(String.Format("{0}\\{1}.txt", Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)), "Prize Level - " + DateTime.Now.ToString("yyyy-MM-dd")), String.Format("{0}: {1}\r\n", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), msg));
        }
    }
}
