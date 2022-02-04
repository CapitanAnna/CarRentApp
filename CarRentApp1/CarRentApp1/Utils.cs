using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentApp1
{
    public static class Utils
    {
        public static bool FormIsOpen(string name)
        {
            //check if window is already open
            var openForms = Application.OpenForms.Cast<Form>();
            var isOpen = openForms.Any(x => x.Name == name);
            return isOpen;
        }

        public static string HashPassword(string password)
        {
            //to do red info about sincron cripting 
            SHA256 sha = SHA256.Create();
            //convert string to byte array and compute hash
            byte[] data = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
            var stringBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                stringBuilder.Append(data[i].ToString("x2"));
            }
            return stringBuilder.ToString();
        }
    }
}
