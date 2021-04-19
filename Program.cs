using System;
using System.Text.RegularExpressions;

namespace Регулярные_выражения
{
    class Program
    {
        static void Main(string[] args)
        {
            rglr rg = new rglr();
        }
    }
    class rglr
    {
        public rglr()
        {
            string s;
            //Console.WriteLine("Введите почтовый индекс");
            //s = Console.ReadLine();
            //Console.WriteLine(Index(s));
            //Console.WriteLine("Введите серию и номер паспорта");
            //s = Console.ReadLine();
            //Console.WriteLine(Passport(s));
            //Console.WriteLine("Введите номер телефона");
            //s = Console.ReadLine();
            //Console.WriteLine(Phone(s));
            //Console.WriteLine("Введите номер группы");
            //s = Console.ReadLine();
            //Console.WriteLine(Group(s));
            Console.WriteLine("Введите пароль");
            s = Console.ReadLine();
            Console.WriteLine(Password(s));
        }
        bool Index(string s)
        {
            Regex rg = new Regex("^[0-9]{6}$");
            return rg.IsMatch(s);
        }
        bool Passport(string s)
        {
            Regex rg = new Regex("^[0-9]{2} [0-9]{2} [0-9]{6}$");
            return rg.IsMatch(s);
        }
        bool Phone(string s)
        {
            Regex rg = new Regex("^(89[0-9]{9})|(.+79[0-9]{9})$");
            return rg.IsMatch(s);
        }
        bool Group(string s)
        {
            Regex rg = new Regex("^([0-4][0-9]([ПБЮВЛ]|Пр))$");
            return rg.IsMatch(s);
        }
        string Password(string s)
        {
            string otv = "";
            Regex rg1 = new Regex("(?=(.*[a-z]){3,})[a-z0-9A-Z!@#$%^&*()_/+=]{8,}");
            Regex rg2 = new Regex("(?=(.*[0-9]){2,})[a-z0-9A-Z!@#$%^&*()_/+=]{8,}");
            Regex rg3 = new Regex("(?=.*[A-Z])[a-z0-9A-Z!@#$%^&*()_/+=]{8,}");
            Regex rg4 = new Regex("(?=.*[!@#$%^&*()_/+=])[a-z0-9A-Z!@#$%^&*()_/+=]{8,}");
            if(!rg1.IsMatch(s))
            {
                otv += "Недостаточно строчных букв\n";
            }
            if(!rg2.IsMatch(s))
            {
                otv += "Недостаточно цифр\n";
            }
            if (!rg3.IsMatch(s))
            {
                otv += "Недостаточно заглавных букв\n";
            }
            if (!rg4.IsMatch(s))
            {
                otv += "Недостаточно специальных символов\n";
            }
            if(rg1.IsMatch(s) && rg2.IsMatch(s) && rg3.IsMatch(s) && rg4.IsMatch(s))
            {
                otv = "Пароль подходит";
            }
            return otv;
        }
    }
}
