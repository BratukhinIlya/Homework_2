using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkNumder2
{
    struct Person
    {
        public int age;
        public int id;
        public string name;
        public string firstname;
        public string categhory;
        public string town;
        public int kolvo;
        public void Print()
        {
            Console.WriteLine($"Имя: {name} , Фамилия: {firstname} , Возраст: {age} , ID: {id} , Категория алколизма - {categhory} , Количество выпитого: {kolvo}"); 
        }
        public void Print1()
        {
            Console.WriteLine($"Имя: {name}, Город: {town}, Возраст: {age}, ID: {id}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  Person person = new Person();
              person.age = 18;
              person.id = 092211;
              person.name = "Амир";
              string a1 = person.name;
              person.firstname = "Сагдуллин";
              person.categhory = "a";
              person.kolvo = 3;
              double a = person.kolvo;
              person.Print();

              person.age = 18;
              person.id = 092222;
              person.name = "Илья";
              string b1 = person.name;
              person.firstname = "Братухин";
              person.categhory = "c";
              person.kolvo = 1;
              double b = person.kolvo;
              person.Print();

              person.age = 18;
              person.id = 192222;
              person.name = "Илья";
              string c1 = person.name;
              person.firstname = "Романов";
              person.categhory = "b";
              person.kolvo = 2;
              double c = person.kolvo;
              person.Print();

              person.age = 19;
              person.id = 809991;
              person.name = "Роман";
              string d1 = person.name;
              person.firstname = "Черезов";
              person.categhory = "a";
              person.kolvo = 4;
              double d = person.kolvo;
              person.Print();

              person.age = 20;
              person.id = 092341;
              person.name = "Илья";
              string e1 = person.name;
              person.firstname = "Царегородцев";
              person.categhory = "d";
              person.kolvo = 0;
              double e = person.kolvo;
              person.Print();

              double f = a+b+c+d+e;
              Console.WriteLine(f);
              double a3 = (a / f) * 100;
              Console.WriteLine(a3);
              double b3 = (b / f) * 100;
              double c3 = (c / f) * 100;
              double d3 = (d / f) * 100;
              double e3 = (e / f) * 100;
              Math.Round(a3);
              Math.Round(b3);
              Math.Round(c3);
              Math.Round(d3);
              Math.Round(e3);
              Console.WriteLine($"{a3}% выпил {a1}, {b3}% выпил {b1}, {c3}% выпил {c1}, {d3}% выпил {d1}, {e3}% выпил {e1}");

              Console.WriteLine("Задание 2");
              Console.WriteLine($"sbyte: {sbyte.MinValue} ... {sbyte.MaxValue}" + "\n" +
              $"byte: {byte.MinValue} ... {byte.MaxValue}" + "\n" +
              $"short: {short.MinValue} ... {short.MaxValue}" + "\n" +
              $"ushort: {ushort.MinValue} ... {ushort.MaxValue}" + "\n" +
              $"int: {int.MinValue} ... {int.MaxValue}" + "\n" +
              $"uint: {uint.MinValue} ... {uint.MaxValue}" + "\n" +
              $"long: {long.MinValue} ... {long.MaxValue}" + "\n" +
              $"ulong: {ulong.MinValue} ... {ulong.MaxValue}" + "\n" +
              $"char: U+000 ... U+ffff" + "\n" +
              $"float: {float.MinValue} ... {float.MaxValue}" + "\n" +
              $"double: {double.MinValue} ... {double.MaxValue}" + "\n" +
              "bool: true ... false" + "\n" +
              $"decimal: {decimal.MinValue} ... {decimal.MaxValue}" + "\n" +
              "string: Ограничено только системной памятью" + "\n" +
              "object: Практически всё, что угодно" + "\n");

              Console.WriteLine("Задание 3");
              Person myfriend = new Person();
              Console.WriteLine("Введите имя:");
              myfriend.name = Console.ReadLine();
              Console.WriteLine("Введите город:");
              myfriend.town = Console.ReadLine();
              Console.WriteLine("Введите возраст:");
              myfriend.age = int.Parse(Console.ReadLine());
              Console.WriteLine("Введите ПИН-КОД:");
              myfriend.id = int.Parse(Console.ReadLine());
              myfriend.Print1();

              Console.WriteLine("Задание 4");
              string name = Console.ReadLine();
              string surname = Console.ReadLine();
              Console.WriteLine($"{name[0].ToString().ToUpper()}. {surname[0].ToString().ToUpper()}."); 

              Console.WriteLine("Задание 5");
              Console.WriteLine("Какова сумма вашего отпуска?");
              double holidayPrice = int.Parse(Console.ReadLine());
              Console.WriteLine("Какова цена одной бутылки виски?");
              double normPrice = int.Parse(Console.ReadLine());
              Console.WriteLine("Какова скидка в процентах?");
              double salePrice = int.Parse(Console.ReadLine());
              double sale = ((100 - salePrice) / 100) * normPrice; ///цена за одну бутылку sale
              double sale1 = normPrice - sale;
              double kolvo = holidayPrice / sale1;
              Console.WriteLine($"Количество бутылок = {kolvo}"); 

              Console.WriteLine("Задание 6");
              Console.WriteLine("Введите скорость в км/ч - ");
              int v = int.Parse(Console.ReadLine());
              Console.WriteLine($"Скорость в см/с = {(v*100000 / 3600) - (v * 100000 / 3600) % 1}");
              Console.ReadLine();*/

              Console.WriteLine("Задание 7");
              string stIn = Console.ReadLine();
              StringBuilder stOut = new StringBuilder();
              foreach (Char a in stIn.ToCharArray())
              {
                if (Char.IsLower(a))
                {
                    stOut.Append(Char.ToUpper(a));
                }
                else
                {
                    stOut.Append(Char.ToLower(a));
                }
              }
              Console.WriteLine(stOut);
            Console.ReadLine();

        }
    }
}
