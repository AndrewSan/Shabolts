// Усі подальші приклади були запущені та розібрані 
/*  
    переваги:
звернення до даних за значенням ключа відбувається за одну операцію введення / виводу;
не потрібно створювати ніяких додаткових структур (типу індексу) і витрачати пам'ять на їх зберігання.
    недоліки:
кількість даних і розподіл значень ключа повинні бути відомі заздалегідь;
записи зазвичай невпорядковані за значенням ключа, що призводить до додаткових витрат, наприклад, при виконанні сортування;
складності підбору хеш-функції.
*/
using System;
using System.Text;
using System.Security.Cryptography;
namespace Shifr
{
    class Program
    {
        static string GetMd5Hash(string input)
        {
            MD5 md5Hasher = MD5.Create();
            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
{

                sBuilder.Append(data[i].ToString(" x2 "));

            }
            return sBuilder.ToString();
        }
        static void Main(string[] args)
        {
            string pasHash = GetMd5Hash(" HashHashHashHashHash "); // Hash
            Console.WriteLine(pasHash);
            Console.ReadKey();
        }
    } 
}

//using System;
//using System.Text;
//using System.Security.Cryptography;
//namespace Shifr
//{
//    class Program
//    {
//        static string sha1(string input)
//        {
//            byte[] hash;
//            using (var sha1 = new SHA1CryptoServiceProvider()) //
//                System.Security.Cryptography.SHA1CryptoServiceProvider
//                hash = sha1.ComputeHash(Encoding.Unicode.GetBytes(input));
//            var sb = new StringBuilder();
//            foreach (byte b in hash) sb.AppendFormat("{ 0:x2}", b);
//            return sb.ToString();
//        }
//        static void Main(string[] args)
//        {
//            string pasHash = sha1(" Apply Hash sha1 ");
//            Console.WriteLine(pasHash);
//            Console.ReadKey();
//        }
//    }
//}