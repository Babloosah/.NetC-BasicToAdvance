using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_InstanceClassMembers
{

    class Circle    {
        float _pi = 3.24f;
        int _radius;

        public Circle(int radius)
        {
            this._radius = radius;
        }

        public float CalculateArea()
        {
            return this._radius * this._radius * this._pi;
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle(3);
            float area = c1.CalculateArea();
            Console.WriteLine("Area of circle with radius 3 is : {0}", area);

            Circle c2 = new Circle(6);
            float area2 = c2.CalculateArea();
            Console.WriteLine("Area of circle with radius 6 is : {0}", area2);
        }
    }
}
