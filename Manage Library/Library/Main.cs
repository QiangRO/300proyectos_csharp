using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    class Main
    {
        private Booklist Bookslist = new Booklist();
        private MemberList memberslist = new MemberList();




        public void Init()
        {
            start();
            int UC;
            int Isend = 0;
            DrwScr scr = new DrwScr();
            while (Isend==0)
            {   
                scr.Init();
                UC = int.Parse(Console.ReadLine());
                switch (UC)
                {
                    case 1:                              // Add teacher member
                        MTeacher t1 = new MTeacher();
                        t1.Setinfo();
                        memberslist.Add(t1);
                        break;
                    case 2:                              //Add student member
                        Mstudent s1 = new Mstudent();
                        s1.Setinfo();
                        memberslist.Add(s1);
                        break;
                    case 3:                              // Add employe member
                        Memploye e1 = new Memploye();
                        e1.Setinfo();
                        memberslist.Add(e1);
                        break;
                    case 4:                              // Delete teacher member
                        MTeacher t2 = new MTeacher();
                        t2.SetId();
                        memberslist.Delete(t2);
                        break;
                    case 5:                              // Delete student member
                        Mstudent s2 = new Mstudent();
                        s2.SetId();
                        memberslist.Delete(s2);
                        break;
                    case 6:                              // Delete employe member
                        Memploye e2 = new Memploye();
                        e2.SetId();
                        memberslist.Delete(e2);
                        break;
                    case 7:                              // Add new book
                        Book book = new Book();
                        book.SetInfo();
                        Bookslist.add(book);
                        break;
                    case 8:                              // Delete a Book                                
                        Book b1 = new Book();
                        b1.SetId();
                        Bookslist.delete(b1);
                        break;
                    case 9:                              // Give book to member                               
                        Book BR = new Book();
                        Unmember MR = new Unmember();
                        BR.SetId();
                        MR.SetId();
                        if (!Bookslist.IsAble(BR)) { scr.Writerr(1); break; }
                        if (!memberslist.IsAble(MR)) { scr.Writerr(2); break; }
                        Bookslist.Givevebook(BR,MR);
                        memberslist.Setrent(MR);
                        break;
                    case 10:                              // Give back book from member                              
                        Book b2 = new Book();
                        b2.SetId();
                        int R = Bookslist.Bookrentid(b2.GetId());
                        if (R == 0) { scr.Writerr(3); break; }
                        Bookslist.Recivebook(b2.GetId());
                        memberslist.Recivebook(R);
                        break;
                    case 11:                              // View information         

                        Bookslist.PrintInfo();
                        memberslist.PrintInfo();
                        break;
                    case 12:                              // Exit         
                        Isend = 1;
                        break;
                }
            }
        }
        public void start()
        {

            Mstudent mt1 = new Mstudent(10, "Hamed", 4);
            memberslist.Add(mt1); 
            Mstudent mt2 = new Mstudent(11, "Hasan", 3);
            memberslist.Add(mt2);
            MTeacher mt3 = new MTeacher(12, "Vahid");
            memberslist.Add(mt3); 
            Mstudent mt4 = new Mstudent(13, "Naser", 3);
            memberslist.Add(mt4); 
            Mstudent mt5 = new Mstudent(14, "Gasem", 3);
            memberslist.Add(mt5); 
            Mstudent mt6 = new Mstudent(15, "Mohammad", 3);
            memberslist.Add(mt6);
            Mstudent mt7 = new Mstudent(16, "Ali", 4);
            memberslist.Add(mt7);

            Book bt1 = new Book(20, "C#.Net");
            Bookslist.add(bt1);
            Book bt2 = new Book(21, "J#.Net");
            Bookslist.add(bt2);
            Book bt3 = new Book(22, "VC++.Net");
            Bookslist.add(bt3); 
            Book bt4 = new Book(23, "C++");
            Bookslist.add(bt4);
            Book bt5 = new Book(24, "VB.Net");
            Bookslist.add(bt5);
            Book bt6 = new Book(25, "Java");
            Bookslist.add(bt6);
            Book bt7 = new Book(26, "Maya");
            Bookslist.add(bt7);



        }

    }
    
}
