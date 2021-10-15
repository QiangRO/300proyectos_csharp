using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Library
{
    class MemberList
    {
        private ArrayList list;
        public MemberList()
        {
            list = new ArrayList();
        }
        public void Add(Member m1)
        {
            list.Add(m1);
        }
        public int Delete(Member  m2)
        {
            if (list.Count != 0)
                for (int i = 0; i < list.Count; i++)
                    if (((Member)list[i]).GetType() == m2.GetType() && ((Member)list[i]).Getid() == m2.Getid())
                        if (((Member)list[i]).GetStatus() == 0)
                        {
                            list.RemoveAt(i);
                            return (1);
                        }
            DrwScr d = new DrwScr();
            d.Writerr(4);
            return (0);
        }
        public void PrintInfo()
        {
            int iMax = 0;
            DrwScr d = new DrwScr();
            for (int Satr = 0; Satr < ((int)(list.Count / 3)) + 1; Satr++)
            {
                Console.Clear();
                d.Drwmain();
                Console.SetCursorPosition(0, 2);
                if (list.Count - (Satr * 3) < 3) iMax = list.Count;
                if (list.Count - (Satr * 3) > 3) iMax = 3*(Satr +1);
                for (int i = (Satr) * 3; i < iMax; i++)
                {

                    Console.WriteLine("Member Id     : " + ((Member)list[i]).Getid());
                    Console.WriteLine("Member Name   : " + ((Member)list[i]).GetName());
                    Console.WriteLine("Member Type   : " + ((Member)list[i]).Getype());
                    Console.WriteLine("Max Rent Let  : " + ((Member)list[i]).GetMax());
                    Console.WriteLine("Member Status : " + ((Member)list[i]).GetStatus());
                    Console.WriteLine("--------------------------");
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("    Press any key to continue .");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();
            }

        }
        public bool IsAble(Member  M1)
        {
            if (list.Count != 0)
            {
                for (int i = 0; i < list.Count; i++)
                    if (((Member)list[i]).Getid() == M1.Getid())
                    {
                        if (((Member)list[i]).GetStatus() < ((Member)list[i]).GetMax())
                        {
                            return (true);
                        }
                        else
                        {
                            return (false);
                        }
                    }
            }
            
                return (false);
            
        }
        public bool Setrent(Member M1)
        {
            if (list.Count != 0)
            {
                for (int i = 0; i <= list.Count; i++)
                    if (((Member)list[i]).Getid() == M1.Getid())
                    {
                        ((Member)list[i]).Addbook();
                        break;
                    }
            }

            return (false);

        }
        public bool Recivebook(int M1)
        {
            if (list.Count != 0)
            {
                for (int i = 0; i <= list.Count; i++)
                    if (((Member)list[i]).Getid() == M1)
                    {
                        ((Member)list[i]).ReciveBook ();
                        break;
                    }
            }

            return (false);

        }

    }
}
