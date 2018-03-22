using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structure
{
    public struct Book
    {
        public string Name;
        public string Author;
        public int Pages;
        public int Number;

        //public Book(string name, string author,int pages, int number)
        //{
        //    Name = name;
        //    Author = author;
        //    Pages = pages;
        //    Number = number;

        //}
    }

    public struct Cars
    {
        public string Name;
        public int Year;
        public int Price;
        public int FuelTank;

        public Cars(string name, int year, int price, int fuelTank)
        {
            Name = name;
            Year = year;
            Price = price;
            FuelTank = fuelTank;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Book book = new Book("Idiot", "Dostaevskiy", 150, 777);
            List<Book> list = new List<Book>
            {
                new Book { Name = "Mymy", Author = "Tyrgeniev", Pages=10, Number=999},
                new Book { Name = "C#", Author = "Troelsen", Pages = 1500, Number =111},
                new Book { Name = "Idiot", Author = "Dostaevskiy", Pages=555, Number=222}
            };
            
            //foreach (var item in list.OrderBy(f => f.Pages))
            //{
            //    Console.WriteLine($"{item.Name}, {item.Author}, {item.Pages}, {item.Number}");
            //}
            //for (int i = 0; i <list.Count ; i++)
            //{

            //    for (int j = 1; j < list.Count; j++)
            //    {
            //        if (list[i].Pages > list[j].Pages)
            //        {
            //            Book temp;
            //            temp = list[i];
            //            list[i] = list[j];
            //            list[j] = temp;
            //        }

            //    }
            //}
            //foreach (var item in list)
            //{
            //    Console.WriteLine($"{item.Name}, {item.Author}, {item.Pages}, {item.Number}");
            //}


            List<Cars> listCars = new List<Cars>
            {
            new Cars { Name = "Tesla", Year = 2019, Price = 100000, FuelTank = 0},
            new Cars {Name = "MERCEDES", Year = 2017, Price = 30000, FuelTank = 75 },
            new Cars {Name = "BMW", Year = 2018, Price = 50000, FuelTank = 70 },
            new Cars { Name = "Zapor", Year = 1968, Price=100, FuelTank = 30}
            };
            listCars.Add(new Cars { Name = Console.ReadLine(), Year = int.Parse(Console.ReadLine()), Price = int.Parse(Console.ReadLine()), FuelTank = int.Parse(Console.ReadLine()) });
            foreach (var item in listCars.OrderBy(f=>f.Price))
            {
                Console.WriteLine($"{item.Name}     \t    {item.Year}       \t     {item.Price}");
            }

            





            }
        }
}
