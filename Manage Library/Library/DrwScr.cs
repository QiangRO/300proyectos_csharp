using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    class DrwScr
    {
        public void Init()
        {
            Console.Clear();
            Drwmain();
            Writemain();
        }
        public void Drwmain()
        {
            for (int i = 0; i <= 79; i++)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(i, 0);
                Console.Write(" ");
            }
            Console.SetCursorPosition(28, 0);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Library Management System");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            WriteDown();
        }
        public void Writemain()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(4, 3);
            Console.WriteLine("1 . Add    teacher member .");
            Console.SetCursorPosition(4, 4);
            Console.WriteLine("2 . Add    student member .");
            Console.SetCursorPosition(4, 5);
            Console.WriteLine("3 . Add    employe member .");
            Console.SetCursorPosition(4, 7);
            Console.WriteLine("4 . Delete teacher member .");
            Console.SetCursorPosition(4, 8);
            Console.WriteLine("5 . Delete student member .");
            Console.SetCursorPosition(4, 9);
            Console.WriteLine("6 . Delete employe member .");
            Console.SetCursorPosition(4, 11);
            Console.WriteLine("7 . Add    book .");
            Console.SetCursorPosition(4, 12);
            Console.WriteLine("8 . Delete book .");
            Console.SetCursorPosition(4, 14);
            Console.WriteLine("9 . Give   book .");
            Console.SetCursorPosition(4, 15);
            Console.WriteLine("10. Recive book .");
            Console.SetCursorPosition(4, 17);
            Console.WriteLine("11. Vew info .");
            Console.SetCursorPosition(4, 19);
            Console.WriteLine("12. Exit .");

            Console.SetCursorPosition(5, 21);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Enter your choice : ");


        }
        public void WriteDown()
        {
            for (int i = 0; i <= 79; i++)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(i, 23);
                Console.Write(" ");
            }
            Console.SetCursorPosition(1, 23);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Programmer : Hamed Arfaee");
            Console.SetCursorPosition(65, 23);
            Console.Write("1385/11/15");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;

 
        }
        public void Writerr(int m)
        {
                Console.Clear();
                Drwmain();
                Console.SetCursorPosition(3, 5);
            if (m == 1) Console.Write("This book is not available !");
            if (m == 2) Console.Write("This member capacity is full !");
            if (m == 3) Console.Write("This book is not rent to member !");
            if (m == 4) Console.Write("Can't delete this member!");
            if (m == 5) Console.Write("Can't delete this book!");

                Console.ReadKey();
                Init();
        }
    }
}
