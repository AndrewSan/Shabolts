// Усі подальші приклади були запущені та розібрані 
/*  
   У симетричних алгоритмах використовують більш короткі ключі.
   Шифрування відбувається швидше. Але в таких системах складно розподіл ключів.


   Перший недолік асиметричного шифрування полягає в низькій
   швидкості виконання операцій зашифровуваної і розшифровки, 
   що обумовлено необхідністю обробки ресурсномістких операцій. 
   Як наслідок, вимоги до апаратної складової такої системи часто бувають неприйнятні.
   Інший недолік - вже чисто теоретичний, і полягає він у тому, 
   що математично криптостойкость алгоритмів асиметричного шифрування поки ще не доведена.
   Додаткові проблеми виникають і при захисті відкритих ключів від підміни, 
   адже досить просто підмінити відкритий ключ легального користувача,
   щоб згодом легко розшифрувати його своїм секретним ключем.


   Принцип дії
   У симетричних криптосистемах для шифрування і розшифрування використовується один і той же ключ. 
   Звідси назва - симетричні. Алгоритм і ключ вибирається заздалегідь і відомий обом сторонам. 
   Збереження ключа в секретності є важливим завданням для встановлення і підтримки захищеного каналу зв'язку.
   У зв'язку з цим, виникає проблема початкової передачі ключа (синхронізації ключів). 
   Крім того існують методи кріптоатак, що дозволяють так чи інакше дешифрувати інформацію
   не маючи ключа або ж за допомогою його перехоплення на етапі узгодження. 
   В цілому ці моменти є проблемою криптостойкости конкретного алгоритму шифрування 
   і є аргументом при виборі конкретного алгоритму.
*/
using System;
using System.IO;
using System.Security.Cryptography;
namespace Shifr
{
    class Program
    {
        public static void Main()
        {
            try
            {
                const string original = " Advanced Encryption Standard " ;
                using (var myAes = Aes.Create())
                {
                    byte[] encrypted = EncryptStringToBytesAes(original, myAes.Key, myAes.IV);
                    string roundtrip = DecryptStringFromBytesAes(encrypted, myAes.Key, myAes.IV);
                    Console.WriteLine(" Original: { 0}", original);
                    Console.WriteLine(" Round Trip: { 0}", roundtrip);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(" Error: { 0}", e.Message);
            }
        }
        static byte[] EncryptStringToBytesAes(string plainText, byte[] Key, byte[] IV)
{
if (plainText == null || plainText.Length <= 0)
throw new ArgumentNullException(" plainText ");
if (Key == null || Key.Length <= 0)
throw new ArgumentNullException(" Key ");
if (IV == null || IV.Length <= 0)
throw new ArgumentNullException(" IV ");
byte[] encrypted;
using (Aes aesAlg = Aes.Create())
{
aesAlg.Key = Key;
aesAlg.IV = IV;
ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);
using (var msEncrypt = new MemoryStream())
{
using (var csEncrypt = new CryptoStream(msEncrypt, encryptor,
CryptoStreamMode.Write))
{
using (var swEncrypt = new StreamWriter(csEncrypt))
{
//Записываем в поток все данные.
swEncrypt.Write(plainText);
}
encrypted = msEncrypt.ToArray();
}
}
}
return encrypted;
}
static string DecryptStringFromBytesAes(byte[] cipherText, byte[] Key, byte[] IV)
{
    if (cipherText == null || cipherText.Length <= 0)
throw new ArgumentNullException(" cipherText ");
    if (Key == null || Key.Length <= 0)
throw new ArgumentNullException(" Key ");
    if (IV == null || IV.Length <= 0)
throw new ArgumentNullException(" IV ");
    string plaintext;
    using (Aes aesAlg = Aes.Create())
    {
        aesAlg.Key = Key;
        aesAlg.IV = IV;
        ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
using (var msDecrypt = new MemoryStream(cipherText))
{
using (var csDecrypt = new CryptoStream(msDecrypt, decryptor,
CryptoStreamMode.Read))
{
using (var srDecrypt = new StreamReader(csDecrypt))
{
plaintext = srDecrypt.ReadToEnd();
}
}
}
}
return plaintext;
}
}
}