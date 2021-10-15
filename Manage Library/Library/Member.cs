using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    abstract class Member
    {
        protected int Id;
        protected string Name;
        protected string Type;
        protected int MaxLet;
        protected int Status;
        protected  DrwScr d = new DrwScr();
        

        public abstract void Setinfo();
        public abstract void SetId();

        public int Getid() { return (Id); }
        public string GetName() { return (Name); }
        public int GetStatus() { return (Status); }
        public int GetMax() { return (MaxLet); }
        public string Getype() { return (Type); }
        public void Addbook() { Status++; }
        public void ReciveBook() { Status--; }
        

    }
}
