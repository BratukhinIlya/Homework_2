using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    struct Prepod
    {
        public string name;
        public int vuz;

        public Prepod(string Name, int Vuz)
        {
            this.name = Name;
            this.vuz = Vuz;
        }
        public void Print1()
        {
            Console.WriteLine($"Имя: {name}, Вуз: {vuz}");
        }
    }
    enum Un
    {
        kgu = 0, kai = 1, khti = 2
    }

    struct Bank
    {
        public string type;
        public int number;
        public string balance;
        public Bank(int Number, string Type, string Balance)
        {
            this.number = Number;
            this.type = Type;
            this.balance = Balance;
        }
        public void Print()
        {
            Console.WriteLine($"Номер: {number}, Тип: {type}, Баланс: {balance}");
        }
    }
    enum Types
    {
        Текущий, Сберегательный
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 3.1");
            foreach (Types credit in Enum.GetValues(typeof(Types)))
            {
                Console.WriteLine("Кредит - {0}, Номер - {1}", credit, (int)credit);
            }
            Console.WriteLine("Задание 3.2");
            Bank info = new Bank(210011349, "Сберегательный", "2000000$");
            info.Print();

            Console.WriteLine("Домашка 3.1");
            Prepod worker1 = new Prepod("Москвин Игорь Сергеевич", (int)Un.kai);
            worker1.Print1();
            Prepod worker2 = new Prepod("Иванов Сергей Юрьевич", (int)Un.khti);
            worker2.Print1();
            Prepod worker3 = new Prepod("Климентьев Гарник Владимирович", (int)Un.kgu);
            worker3.Print1();
            Console.WriteLine("0 - КАИ / 1 - КХТИ / 2 - КГУ");
            Console.ReadLine();
        }
    }
}
