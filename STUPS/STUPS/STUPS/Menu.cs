using System;
using System.Collections.Generic;
using System.Text;

namespace STUPS
{
    class Menu
    {
        public Menu()
        {
            //Constructor of "Menu" Class
        }
        public static void CreatMenu()
        {
            Console.Title = "STUPS_Main Menu";
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n 1 . Input base data. \n");
            Console.WriteLine("\n 2 . Edit base data.  \n");
            Console.WriteLine("\n 3 . Delete base data. \n");
            Console.WriteLine("\n 4 . Take lesson (for students only). \n");
            Console.WriteLine("\n 5 . Show information (for students only). \n");
            Console.WriteLine("\n 6 . Exit. \n");
            Console.WriteLine("\n\n Enter a digit between 1 and 6 \n");
            Console.CursorVisible = false;
            string selItem = Console.ReadKey().KeyChar.ToString();
            if (selItem == "1" || selItem == "2" || selItem == "3" || selItem == "4" || selItem == "5" || selItem == "6")
            {
                Console.Clear();
                switch (selItem)
                {
                    case "1":
                        CreatSubMenu();
                        break;
                    case "2":
                        STUW.stuEdit();
                        CreatMenu();
                        break;
                    case "3":
                        STUW.stuDel();
                        CreatMenu();
                        break;
                    case "4":
                        Program.structSLTArray = STUW.sltData(Program.structSLTArray);
                        CreatMenu();
                        break;
                    case "5":
                        STUW.showInformation();
                        Console.ReadLine();
                        CreatMenu();
                        break;
                    case "6":
                        Console.WriteLine("Press any key to exit.");
                        break;
                }
            }
            else
            {
                Console.Beep();
                CreatMenu();
            }
        }
        public static void CreatSubMenu()
        {
            Console.Title = "STUPS_Input Data";
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n 1 . Input student data. \n");
            Console.WriteLine("\n 2 . Input teacher data.  \n");
            Console.WriteLine("\n 3 . Input Lesson data. \n");
            Console.WriteLine("\n 4 . Back to main menu. \n");
            Console.WriteLine("\n\n Enter a digit between 1 and 4 \n");
            Console.CursorVisible = false;
            string selSubItem = Console.ReadKey().KeyChar.ToString();
            if (selSubItem == "1" || selSubItem == "2" || selSubItem == "3" || selSubItem == "4")
            {
                Console.Clear();
                switch (selSubItem)
                {
                    case "1":
                        Program.structStuArray = STUW.studentData(Program.structStuArray);
                        CreatSubMenu();
                        break;
                    case "2":
                        Program.structTeachArray = STUW.teacherData(Program.structTeachArray);
                        CreatSubMenu();
                        break;
                    case "3":
                        Program.structLesArray = STUW.lessonData(Program.structLesArray);
                        CreatSubMenu();
                        break;
                    case "4":
                        CreatMenu();
                        break;
                }
            }
            else
            {
                Console.Beep();
                CreatSubMenu();
            }
        }
    }
}
