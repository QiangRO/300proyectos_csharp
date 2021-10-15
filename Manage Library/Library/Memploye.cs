using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    class Memploye:Member
    {
        public Memploye()
        {

            MaxLet = 1;
            Type = "Employe";
            Status = 0;

        }
        public Memploye(int id, string name)
        {
            Type = "Employe";
            Status = 0;
            Id = id;
            Name = name;
            MaxLet = 1;
        }
        public override void Setinfo()
        {
            Console.Clear();
            d.Drwmain();
            Console.SetCursorPosition(0, 1);
            Console.WriteLine("Member Type : " + Type);

            Console.Write("Member Id   :");
            Id = int.Parse(Console.ReadLine());

            Console.Write("Member Name :");
            Name = Console.ReadLine();

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
