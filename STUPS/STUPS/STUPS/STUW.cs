using System;
using System.Collections.Generic;
using System.Text;

namespace STUPS
{
    class STUW
    {
        public STUW()
        {
            //Constructor of "STUW" Class
        }
        public static AllStruct.Student[] studentData(AllStruct.Student[] structStu)
        {
            Console.Clear();
            Console.CursorVisible = true;
            int condition = 1;
            bool bound = true;
            int i = 0;
            while (1 == condition && bound)
            {
                Console.CursorVisible = true;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n Student ID : \n");
                Console.ForegroundColor = ConsoleColor.White;
                structStu[i].stuID = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n First Name : \n");
                Console.ForegroundColor = ConsoleColor.White;
                structStu[i].name = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n Last Name : \n");
                Console.ForegroundColor = ConsoleColor.White;
                structStu[i].family = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n Father Name : \n");
                Console.ForegroundColor = ConsoleColor.White;
                structStu[i].fatherName = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Green;
                if (i < (structStu.Length -1))
                {
                    i++;
                    bound = true;
                }
                else
                {
                    bound = false;
                }
                Question(ref condition);
            }
            return structStu;
        }
        public static AllStruct.Lesson[] lessonData(AllStruct.Lesson[] structLes)
        {
            Console.Clear();
            Console.CursorVisible = true;
            int condition = 1;
            bool bound = true;
            int i = 0;
            while (1 == condition && bound)
            {
                Console.CursorVisible = true;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n Lesson ID : \n");
                Console.ForegroundColor = ConsoleColor.White;
                structLes[i].lessonID = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n Lesson Name : \n");
                Console.ForegroundColor = ConsoleColor.White;
                structLes[i].lessonName = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Green;
                if (i < (structLes.Length - 1))
                {
                    i++;
                    bound = true;
                }
                else
                {
                    bound = false;
                }
                Question(ref condition);
            }
            return structLes;
        }
        public static AllStruct.Teacher[] teacherData(AllStruct.Teacher[] structTeach)
        {
            Console.Clear();
            Console.CursorVisible = true;
            int condition = 1;
            bool bound = true;
            int i = 0;
            while (1 == condition && bound)
            {
                Console.CursorVisible = true;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n Teacher ID : \n");
                Console.ForegroundColor = ConsoleColor.White;
                structTeach[i].teacherID = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n Teacher Name : \n");
                Console.ForegroundColor = ConsoleColor.White;
                structTeach[i].teacherName = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Green;
                if (i < (structTeach.Length - 1))
                {
                    i++;
                    bound = true;
                }
                else
                {
                    bound = false;
                }
                Question(ref condition);
            }
            return structTeach;
        }
        public static AllStruct.SLT[] sltData(AllStruct.SLT[] structSLT)
        {
            Console.Clear();
            InfoBoard();
            int i = -1;
            int condition = 1;
            while (1 == condition)
            {
                i++;
                Console.CursorVisible = true;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n Student ID : \n");
                Console.ForegroundColor = ConsoleColor.White;
                structSLT[i].stuID = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n Lesson ID : \n");
                Console.ForegroundColor = ConsoleColor.White;
                structSLT[i].lessonID = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n Teacher ID : \n");
                Console.ForegroundColor = ConsoleColor.White;
                structSLT[i].teacherID = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Question(ref condition);
            }
            return structSLT;
        }

        public static void InfoBoard()
        {
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n {0}   {1} \n","Lesson ID","Lesson Name");
            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int i = 0; i < Program.structLesArray.Length; i++)
            {
                Console.WriteLine("\n {0}   {1} \n",Program.structLesArray[i].lessonID,Program.structLesArray[i].lessonName);
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n========================================\n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n {0}   {1} \n", "Teacher ID", "Teacher Name");
            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int j = 0; j < Program.structTeachArray.Length; j++)
            {
                Console.WriteLine("\n {0}   {1} \n", Program.structTeachArray[j].teacherID, Program.structTeachArray[j].teacherName);
            }
        }

        public static void Question(ref int condition)
        {
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n Input more?(Y,N) \n");
            string keyEnter = Console.ReadKey().KeyChar.ToString().ToUpper();
            if (keyEnter == "Y")
            {
                condition = 1;
            }
            else if (keyEnter == "N")
            {
                condition = 0;
            }
            else
            {
                Console.Beep();
                Question(ref condition); 
            }
        }

        public static void showInformation()
        {
            Console.CursorVisible = true;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n Student ID : \n");
            Console.ForegroundColor = ConsoleColor.White;
            string stuID = Console.ReadLine();
            Console.Clear();
            for (int i = 0; i < Program.structStuArray.Length; i++)
            {
                if (stuID == Program.structStuArray[i].stuID)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n Student ID : {0}\n",Program.structStuArray[i].stuID);
                    Console.WriteLine("\n Student First Name : {0}\n", Program.structStuArray[i].name);
                    Console.WriteLine("\n Student Last Name : {0}\n", Program.structStuArray[i].family);
                    Console.WriteLine("\n Student Father Name : {0}\n", Program.structStuArray[i].fatherName);
                }
            }
            Console.WriteLine("\n========================================\n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n {0}   {1} \n", "Lesson Name", "Teacher Name");
            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int j = 0; j < Program.structSLTArray.Length; j++)
            {
                if (stuID == Program.structSLTArray[j].stuID)
                {
                    Console.WriteLine("\n {0}   {1} \n",getLessonName(Program.structSLTArray[j].lessonID),getTeacherName(Program.structSLTArray[j].teacherID));
                }
            }
        }

        public static string getTeacherName(string teacherID)
        {
            string teacherName = null;
            for (int i = 0; i < Program.structTeachArray.Length; i++)
            {
                if (teacherID == Program.structTeachArray[i].teacherID)
                {
                    teacherName = Program.structTeachArray[i].teacherName;
                }
            }
            return teacherName;
        }

        public static string getLessonName(string lessonID)
        {
            string lessonName = null;
            for (int i = 0; i < Program.structLesArray.Length; i++)
            {
                if (lessonID == Program.structLesArray[i].lessonID)
                {
                    lessonName = Program.structLesArray[i].lessonName;
                }
            }
            return lessonName;
        }

        public static void stuDel()
        {
            Console.CursorVisible = true;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n Student ID : \n");
            Console.ForegroundColor = ConsoleColor.White;
            string stuID = Console.ReadLine();
            int condition = 0;
            int stuToDelIndex = -1;
            Console.Clear();
            for (int i = 0; i < Program.structStuArray.Length; i++)
            {
                if (stuID == Program.structStuArray[i].stuID)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n Student ID : {0}\n", Program.structStuArray[i].stuID);
                    Console.WriteLine("\n Student First Name : {0}\n", Program.structStuArray[i].name);
                    Console.WriteLine("\n Student Last Name : {0}\n", Program.structStuArray[i].family);
                    Console.WriteLine("\n Student Father Name : {0}\n", Program.structStuArray[i].fatherName);
                    stuToDelIndex = i;
                    condition = 1;
                }
            }
            Console.WriteLine("\n============================================\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.CursorVisible = false;
            if (condition == 1)
            {
                Console.WriteLine("\n Press Delete key to del this student.\n");
                if (Console.ReadKey().Key == ConsoleKey.Delete)
                {
                    Program.structStuArray[stuToDelIndex].stuID = null;
                    Program.structStuArray[stuToDelIndex].name = null;
                    Program.structStuArray[stuToDelIndex].family = null;
                    Program.structStuArray[stuToDelIndex].fatherName = null;
                    Console.WriteLine("\n You are delete student with student id {0}.\n",stuID);
                }
                else
                {
                    Console.WriteLine("\n You are not agree to delete this student.\n");
                    Console.WriteLine("\n Press any key to back to main menu.\n");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("\n Can not find any student with student id {0}.\n",stuID);
                
            }
        }
        public static void stuEdit()
        {
            Console.CursorVisible = true;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n Student ID : \n");
            Console.ForegroundColor = ConsoleColor.White;
            string stuID = Console.ReadLine();
            int condition = 0;
            int stuToEditIndex = -1;
            Console.Clear();
            for (int i = 0; i < Program.structStuArray.Length; i++)
            {
                if (stuID == Program.structStuArray[i].stuID)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n Student ID : {0}\n", Program.structStuArray[i].stuID);
                    Console.WriteLine("\n Student First Name : {0}\n", Program.structStuArray[i].name);
                    Console.WriteLine("\n Student Last Name : {0}\n", Program.structStuArray[i].family);
                    Console.WriteLine("\n Student Father Name : {0}\n", Program.structStuArray[i].fatherName);
                    stuToEditIndex = i;
                    condition = 1;
                }
            }
            Console.WriteLine("\n============================================\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.CursorVisible = false;
            if (condition == 1)
            {
                Console.WriteLine("\n Press F2 to edit this student.\n");
                if (Console.ReadKey().Key == ConsoleKey.F2)
                {
                    Console.CursorVisible = true;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n Student ID : \n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Program.structStuArray[stuToEditIndex].stuID = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n First Name : \n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Program.structStuArray[stuToEditIndex].name = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n Last Name : \n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Program.structStuArray[stuToEditIndex].family = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n Father Name : \n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Program.structStuArray[stuToEditIndex].fatherName = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n You are Edit student with student id {0}.\n", stuID);
                }
                else
                {
                    Console.WriteLine("\n You are not agree to edit this student.\n");
                    Console.WriteLine("\n Press any key to back to main menu.\n");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("\n Can not find any student with student id {0}.\n", stuID);

            }
        }

    }
}
