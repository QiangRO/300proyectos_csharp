using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    class Book
    {
        private DrwScr d = new DrwScr();

        private int Id;
        private string Name;
        private int RentId;

        public Book(int id, string name)
        {
            Id = id;
            Name = name;
            RentId = 0;
        }
        public Book()
        {
            Id = 0;
            Name = "";
            RentId = 0;
        }
        public void SetInfo()
        {
            Console.Clear();
            d.Drwmain();
            Console.SetCursorPosition(0, 2);
            Console.Write("Enter book id :");
            Id = int.Parse(Console.ReadLine());
            Console.Write("Enter book name :");
            Name = Console.ReadLine();

        }
        public int GetId() { return (Id); }
        public string Getname() { return (Name); }
        public int GetRentId() { return (RentId); }
        public void SetId()
        {
            Console.Clear();
            d.Drwmain();
            Console.SetCursorPosition(0, 2);
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("Enter book Id   : ");
            Name = "";
            Id = int.Parse(Console.ReadLine());
        }
        public void PrintInfo()
        {
            Console.Clear();
            d.Drwmain();
            Console.SetCursorPosition(0, 2);
            Console.WriteLine("Book name   : " +Name);
            Console.WriteLine("Book Id     : " + Id);
            Console.WriteLine("Book RentId : " + RentId);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("    Press any key to continue .");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();

        }
        public void GiveBook(int MemId)
        {
            RentId = MemId;
        }
        public void ReciveBook()
        {
            RentId = 0;
        }
    }
}
