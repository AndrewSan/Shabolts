using System;
using System.Collections.Generic;

namespace Qurantine_is_hell
{
    class Program
    {
        static void Main()
        {
            Stack<Mocik> bigObj = new Stack<Mocik>();
            Mocik w = new Mocik();
            
            Console.WriteLine("  Яку кiлькiсть мотоциклiв ви знаєте щоб заповнити? ");
            Console.Write("  >> ");
            int bufer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            for (int i = 0; i < bufer; i++)
            {
                w.GetInformation();
                bigObj.Push(w);
            }

            try
            {
                for (int i = 0; i < bufer; i++)
                {
                    Console.WriteLine(bigObj.Peek());
                    bigObj.Pop();
                }
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(" Error! { 0}", ex.Message);
            }
        }
    }
}