using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    class Unmember:Member 
    {
        public Unmember()
        {
            Status = 0;
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
            MaxLet = int.Parse(Console.ReadLine());

        }
        public override void SetId()
        {
            Console.Write("Member Id   :");
            Id = int.Parse(Console.ReadLine());

        }
    }
}
