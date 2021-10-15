using System;
using System.Collections.Generic;
using System.Text;

namespace STUPS
{
    class Program
    {
        public static AllStruct.Student[] structStuArray = new AllStruct.Student[2];
        public static AllStruct.Lesson[] structLesArray = new AllStruct.Lesson[2];
        public static AllStruct.Teacher[] structTeachArray = new AllStruct.Teacher[2];
        public static AllStruct.SLT[] structSLTArray = new AllStruct.SLT[100];

        static void Main(string[] args)
        {
            Menu.CreatMenu();
            //Console.WriteLine("{0}",structStu[1].name.ToString());
            Console.ReadLine();
        }
    }
}
