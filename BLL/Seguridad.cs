using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class Seguridad
    {
        public static string Encrypt(this string _password)
        {
            string result = string.Empty;
            byte[] encrypted = System.Text.Encoding.Unicode.GetBytes(_password);
            result = Convert.ToBase64String(encrypted);
            return result;
        }

        public static string Decode(this string _passwordEncrypted)
        {
            string encrypted = string.Empty;
            byte[] decode = Convert.FromBase64String(_passwordEncrypted);
            encrypted = System.Text.Encoding.Unicode.GetString(decode);
            return encrypted;
        }
    }
}
