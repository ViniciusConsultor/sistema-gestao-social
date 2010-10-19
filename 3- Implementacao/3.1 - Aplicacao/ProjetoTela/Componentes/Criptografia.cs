using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


using System.Text;
using System.IO;
using System.Security.Cryptography;

namespace SGS.Componentes
{

    /// <summary>
    /// Componente para Criptografar e Descriptografar dados.
    /// Desenvolvido por: Thiago Diniz
    /// http://www.desenvolvendoparaweb.net/profiles/blogs/criptografar-e-descriptografar
    /// </summary>
    public class Criptografia
    {

        private static byte[] chave = { };
        private static byte[] iv = { 12, 34, 56, 78, 90, 102, 114, 126 };

        public Criptografia()
        {
        }

        /// <summary>
        /// Este método criptografa 
        /// </summary>
        /// <param name="valor"></param>
        /// <param name="chaveCriptografia"></param>
        /// <returns></returns>
        public static string Criptografar(string valor, string chaveCriptografia)
        {
            //DESCryptoServiceProvider des;
            //MemoryStream ms;
            //CryptoStream cs; byte[] input;

            //try
            //{
            //    des = new DESCryptoServiceProvider();
            //    ms = new MemoryStream();

            //    input = Encoding.UTF8.GetBytes(valor); 
            //    chave = Encoding.UTF8.GetBytes(chaveCriptografia.Substring(0, 8));

            //    cs = new CryptoStream(ms, des.CreateEncryptor(chave, iv), CryptoStreamMode.Write);
            //    cs.Write(input, 0, input.Length);
            //    cs.FlushFinalBlock();


            //    return Convert.ToBase64String(ms.ToArray());
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}

            return valor;
        }


        /// <summary>
        /// Este método Descriptografa 
        /// </summary>
        /// <param name="valor"></param>
        /// <param name="chaveCriptografia"></param>
        /// <returns></returns>
        public static string Descriptografar(string valor, string chaveCriptografia)
        {
            //DESCryptoServiceProvider des;
            //MemoryStream ms;
            //CryptoStream cs; byte[] input;

            //try
            //{
            //    des = new DESCryptoServiceProvider();
            //    ms = new MemoryStream();

            //    input = new byte[valor.Length];
            //    input = Convert.FromBase64String(valor.Replace(" ", "+"));

            //    chave = Encoding.UTF8.GetBytes(chaveCriptografia.Substring(0, 8));

            //    cs = new CryptoStream(ms, des.CreateDecryptor(chave, iv), CryptoStreamMode.Write);
            //    cs.Write(input, 0, input.Length);
            //    cs.FlushFinalBlock();

            //    return Encoding.UTF8.GetString(ms.ToArray());
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}

            return valor;
        }

    }
}