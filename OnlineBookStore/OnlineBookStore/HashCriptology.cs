using System.Security.Cryptography;
using System.Text;

namespace OnlineBookStore
{
    public class HashCriptology
    {
        public StringBuilder sb = new StringBuilder();

        public void MD5Sifrele(ref string sifrelenecekMetin)
        {
            // MD5CryptoServiceProvider sınıfının bir örneğini oluşturduk.
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            //Parametre olarak gelen veriyi byte dizisine dönüştürdük.
            byte[] dizi = Encoding.UTF8.GetBytes(sifrelenecekMetin);
            //dizinin hash'ini hesaplattık.
            dizi = md5.ComputeHash(dizi);
            //Hashlenmiş verileri depolamak için StringBuilder nesnesi oluşturduk.
            //Her byte'i dizi içerisinden alarak string türüne dönüştürdük.

            foreach (byte ba in dizi)
            {
                sb.Append(ba.ToString("x2").ToLower());
            }
            sifrelenecekMetin = sb.ToString();
        }

        public string getPass()
        {
            return sb.ToString();
        }
    }
}