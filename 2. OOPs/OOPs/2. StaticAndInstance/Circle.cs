using System;
using System.Collections.Generic;
using System.Text;

namespace OOPs._2._StaticAndInstance
{
    public class Circle
    {
        float _PI = 3.141F;
        int _RADIUS;

        public Circle(int Radius)
        {
            this._RADIUS = Radius;
        }

        public void Area()
        {
            Console.WriteLine(this._PI * this._RADIUS * this._RADIUS);
        }
    }
}
