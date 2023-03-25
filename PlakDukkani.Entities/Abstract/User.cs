using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PlakDukkani.Entities.Abstract
{
    public class User : BaseEntity
    {
        public string KullaniciAdi { get; set; }
        private string _sifre;

        public string Sifre
        {
            get { return _sifre; }
            set
            {
               if(IsValidPassword(value)== true)
                {
                    _sifre = sha256_hash(value);
                }

                else
                {
                    throw new Exception("Şifre aşağıdaki gibi olmalıdır: En az 8 karakter uzunluğunda olmalıdır.\r\n• En az 2 büyük  harf içermelidir.\r\n• En az 3 küçük harf içermelidir. \r\n• ! (ünlem), : (iki nokta üst üste), +(artı), *(yıldız) karakterlerinden en az 2 tanesini içermelidir.\r\n(Aynı karakterden birden fazla olabilir)\r\n");
                }
            }
      
        
        
        }


        static bool IsValidPassword(string password)
        {
            int upperCase = 0, lowerCase = 0, specialChars = 0;

            if (password.Length <= 8)
                return false;

            foreach (char c in password)
            {
                if (char.IsUpper(c))
                    upperCase++;
                else if (char.IsLower(c))
                    lowerCase++;
                else if (c == '!' || c == ':' || c == '+' || c == '*')
                    specialChars++;
            }

            return upperCase >= 2 && lowerCase >= 3 && specialChars >= 2;
        }


        public string sha256_hash(string sifre)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(sifre)).Select(l => l.ToString("X2")));
            }
        }

    }



   

}



