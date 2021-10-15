using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;


namespace Library
{
    class Booklist
    {
        private ArrayList list;
        public Booklist()
        {
            list = new ArrayList();
        }
        public void add(Book  b)
        {
            list.Add(b);
        }
        public int delete(Book b)
        {
            if (list.Count != 0)
                for (int i = 0; i < list.Count; i++)
                    if (((Book)list[i]).GetId() == b.GetId())
                        if (((Book)list[i]).GetRentId() == 0)
                        {
                            list.RemoveAt(i);
                            return (1);
                        }
            DrwScr d = new DrwScr();
            d.Writerr(5);
            return (0);
        }
        public void PrintInfo()
        {
            int iMax = 0;
            DrwScr d = new DrwScr();
            for (int Satr = 0; Satr <((int)(list.Count/5))+1; Satr++)
            {
                Console.Clear();
                d.Drwmain();
                Console.SetCursorPosition(0, 2);
                if (list.Count - (Satr * 5) < 5) iMax = list.Count;
                if (list.Count - (Satr * 5) > 5) iMax = 5;
                for (int i = (Satr)*5 ; i < iMax ; i++)
                {
                    
                    Console.WriteLine("Book name   : " + ((Book)list[i]).Getname());
                    Console.WriteLine("Book Id     : " + ((Book)list[i]).GetId ());
                    Console.WriteLine("Book RentId : " + ((Book)list[i]).GetRentId());
                    Console.WriteLine("--------------------------");
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("    Press any key to continue .");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();
            }

        }
        public bool IsAble(Book b1)
        {
            if (list.Count != 0)
            {
                for (int i = 0; i < list.Count; i++)
                    if (((Book)list[i]).GetId() == b1.GetId())
                        if (((Book)list[i]).GetRentId() == 0) return (true);
            }
            return (false);
        }
        public void Recivebook(int b1)
        {
            if (list.Count != 0)
                for (int i = 0; i < list.Count; i++)
                    if (((Book)list[i]).GetId() == b1) ((Book)list[i]).ReciveBook();

        }
        public void Givevebook(Book b1, Member m1)
        {
            if (list.Count != 0)
                for (int i = 0; i < list.Count; i++)
                    if (((Book)list[i]).GetId() == b1.GetId()) ((Book)list[i]).GiveBook(m1.Getid());

        }
        public int Bookrentid(int b1)
        {
            if (list.Count != 0)
                for (int i = 0; i < list.Count; i++)
                    if (((Book)list[i]).GetId() == b1) return (((Book)list[i]).GetRentId());
            return (0);
        }// tell book renter Id
    }

}
