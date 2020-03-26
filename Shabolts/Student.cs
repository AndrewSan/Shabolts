using System;
using System.Collections.Generic;
using System.Text;

namespace Shabolts
{
    class Student
    {
        public Student( bool budjet) 
        {
            this._budjet = budjet;
        }

        public void GetInformation()
        {
            Console.WriteLine("  Введiть даннi про студента: ");
            Console.Write("  Прiзвище - ");
            _surname = Convert.ToString(Console.ReadLine());
            Console.Write("  Група - ");
            _group = Convert.ToString(Console.ReadLine());
            Console.Write("  Середнiй бал - ");
            _seredniyBal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
        }
        public void ShowInformation()
        {
            Console.WriteLine("  Iнформацiя про студента ");
            Console.WriteLine("  Прiзвище - " + _surname);
            Console.WriteLine("  Група - " + _group);
            Console.WriteLine("  Середнiй бал - " + _seredniyBal);
            if(_budjet)
                Console.WriteLine("  Студент на бюджетi");
            else
                Console.WriteLine("  Студент НЕ на бюджетi");
            Console.WriteLine();
        }


        private double _seredniyBal;
        private string _surname;
        private string _group;
        private bool _budjet;

        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }
        
        public string Group
        {
            get { return _group; }
            set { _group = value; }
        }
        
        public double SeredniyBal
        {
            get { return _seredniyBal; }
            set { _seredniyBal = value; }
        }
        
        public bool Budjet
        {
            get { return _budjet; }
            set { _budjet = value; }
        }
    }
}
