using System;
using System.Collections.Generic;
using System.Text;

namespace STUPS
{
    class AllStruct
    {
        public AllStruct()
        {
            //Constructor of "AllStruct" Class
        }
        public struct Student
        {
            public string stuID;
            public string name;
            public string family;
            public string fatherName;
        }
        public struct Lesson
        {
            public string lessonID;
            public string lessonName;
        }
        public struct Teacher
        {
            public string teacherID;
            public string teacherName;
        }
        public struct SLT
        {
            public string stuID;
            public string lessonID;
            public string teacherID;
        }
    }
}
