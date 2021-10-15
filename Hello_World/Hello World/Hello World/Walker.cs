using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hello_World
{
    public class Walker
    {
        #region Properties
        public float X { set; get; }
        public float Y { set; get; }

        public int Speed { set; get; }
        #endregion

        public Walker()
        {
            
        }
        public bool IsOn(int mx,int my)
        {
            if (Math.Sqrt(Math.Pow(mx - X, 2) + Math.Pow(my - Y, 2)) <= 5)
            {
                return true;
            }
            return false;
        }
        public Walker(int _x,int _y,int speed)
        {
            X = _x;
            Y = _y;
            Speed = speed;
        }

        public void MoveTo(float _x, float _y)
        {
            X += (_x - X) / Speed;
            Y += (_y - Y) / Speed;
        }
    }
}
