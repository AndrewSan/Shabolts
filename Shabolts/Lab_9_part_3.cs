// Усі подальші приклади були запущені та розібрані 
/*  
плюси   
відсутність проблем з передачею ключа;
спрощена процедура зберігання пароля (відсутність необхідності передавати кому-то закритий ключ).
мінуси
складності в розумінні роботи системи; 
процедура шифрування і дешифрування вимагає від комп'ютера, на якому вона проводиться, значних ресурсів.

   Принцип дії
   У системах з відкритим ключем використовуються два ключі - відкритий і закритий, 
   пов'язані певним математичним чином один з одним. 
   Відкритий ключ передається по відкритому (тобто незахищені, доступному для спостереження) каналу
   і використовується для шифрування повідомлення і для перевірки ЕЦП. 
   Для розшифровки повідомлення і для генерації ЕЦП використовується таємний ключ.
   Дана схема вирішує проблему симетричних схем, пов'язану з початкової передачею ключа іншій стороні. 
   Якщо в симетричних схемах зловмисник перехопить ключ, то він зможе як «слухати», 
   так і вносити правки в передану інформацію. В асиметричних системах іншій стороні передається відкритий ключ, 
   який дозволяє шифрувати, але не розшифровувати інформацію. 
   Таким чином вирішується проблема симетричних систем, пов'язана з синхронізацією ключів.
*/
using System;
using System.IO;
using System.Security.Cryptography;
namespace Shifr
{
    public class DigitalSignature
    {
        private RSAParameters _publicKey;
        private RSAParameters _privateKey;
        public void AssignNewKey()
        {
            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                rsa.PersistKeyInCsp = false;
                _publicKey = rsa.ExportParameters(false);
                _privateKey = rsa.ExportParameters(true);
            }
        }
        public byte[] SignData(byte[] hashOfDataToSign)
        {
            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                rsa.PersistKeyInCsp = false;
                rsa.ImportParameters(_privateKey);
                var rsaFormatter = new RSAPKCS1SignatureFormatter(rsa);
                rsaFormatter.SetHashAlgorithm(&quot; SHA256 & quot;);
                return rsaFormatter.CreateSignature(hashOfDataToSign);
            }
        }
        public bool VerifySignature(byte[] hashOfDataToSign, byte[] signature)
        {
            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                rsa.ImportParameters(_publicKey);
                var rsaDeformatter = new RSAPKCS1SignatureDeformatter(rsa);
                rsaDeformatter.SetHashAlgorithm(&quot; SHA256 & quot;);
                return rsaDeformatter.VerifySignature(hashOfDataToSign, signature);
            }
        }
    }
}