using System;

namespace ShaboltsC____
{
    class Program
    {
        static void Main()
        {
            //string alphabetEng = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            //string alphabetRus = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
            //string alphabetUkr = "АБВГҐДЕЄЖЗИІЇЙКЛМНОПРСТУФХЦЧШЩЬЮЯ";

            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Сделайте выбор алфавита(0 - англиский, 1 - руський, 2 - український)");
            int alf = Convert.ToInt32(Console.ReadLine());
            string alfavit = string.Empty;
            if (alf == 0)
            {
                alfavit = alphabetEng;
            }
            else if (alf == 1)
            {
                alfavit = alphabetRus;
            }
            else if (alf == 2)
            {
                alfavit = alphabetUkr;
            }
            Console.WriteLine("Сделайте выбор действия(0 - шифрование, 1 - дешифрование)");
            int chois = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите текст");
            string text = Convert.ToString(Console.ReadLine());
            Xor.To(ref text);

            Console.WriteLine("Введите ключ");
            string key = Convert.ToString(Console.ReadLine());
            Xor.To(ref key);

            string crypt = Xor.Encryption(text, key, chois, alfavit);
            Console.WriteLine("Результат:\n" + crypt);
        }
    }

    static class Xor
    {

        static private int k, x, z;
        static private string res;

        static public void To(ref string str)
        {
            str = str.ToUpper();
        }
        static public string Encryption(string source, string key, int chois, string alf)
        {
            res = string.Empty;

            while (key.Length < source.Length)
            {
                key += key;
                if (key.Length > source.Length) key = key.Remove(source.Length);
            }

            for (int i = 0; i < source.Length; i++)
            {
                for (int id = 0; id < alf.Length; id++)
                {
                    if (key[i] == alf[id]) k = id;
                    if (source[i] == alf[id]) x = id;
                    switch (chois)
                    {
                        case 0:
                            z = (x + k) % alf.Length;
                            break;
                        case 1:
                            z = ((source[i] - key[i]) + alf.Length) % alf.Length;
                            break;
                        default:
                            break;
                    }
                }
                res += alf[z];
            }
            return res;
        }
    }
}