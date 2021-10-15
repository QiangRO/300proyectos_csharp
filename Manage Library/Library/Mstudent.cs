using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    class Mstudent:Member 
    {
        public Mstudent()
        {
            Type = "Student";
            Status = 0;
        }
        public Mstudent(int id,string name,int Max)
        {
            Type = "Student";
            Status = 0;
            Id = id;
            Name = name;
            MaxLet = Max;
        }

        public override void Setinfo()
        {
            Console.Clear();
            d.Drwmain();
            Console.SetCursorPosition(0, 1);
            Console.WriteLine("Member Type : " + Type);

            Console.Write("Member Id    :");
            Id = int.Parse(Console.ReadLine());

            Console.Write("Member Name  :");
            Name = Console.ReadLine();

            Console.Write("Max Rent Let :");
            MaxLet  = int.Parse(Console.ReadLine());

        }
        public override void SetId()
        {
            Console.Clear();
            d.Drwmain();
            Console.SetCursorPosition(0, 1);
            Console.WriteLine("Member Type : " + Type);

            Console.Write("Member Id   :");
            Id = int.Parse(Console.ReadLine());

        }
    }
 
}
