using System;
using System.Collections.Generic;
using System.Text;

namespace OOPs._2._StaticAndInstance
{
    public class Circle2
    {
        //Static variable or field
        static float _PI = 3.141F;
        int _RADIUS;

        public Circle2(int Radius)
        {
            this._RADIUS = Radius;
        }

        public float Area()
        {
            return Circle2._PI * this._RADIUS * this._RADIUS;
        }
    }
}
