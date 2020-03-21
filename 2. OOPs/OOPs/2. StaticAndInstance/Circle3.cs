using System;
using System.Collections.Generic;
using System.Text;

namespace OOPs._2._StaticAndInstance
{
    class Circle3
    {
        //Static variable or field
        static float _PI;
        int _RADIUS;

        //Static constructors are called before instance Constructors
        static Circle3()
        {
            _PI = 3.141F;
        }

        //Instance Constructor
        public Circle3(int Radius)
        {
            this._RADIUS = Radius;
        }

        public float Area()
        {
            return Circle3._PI * this._RADIUS * this._RADIUS;
        }
    }
}
