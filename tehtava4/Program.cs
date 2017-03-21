using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAMK.IT;

namespace JAMK.IT
{
    abstract class Program : Shapes
    {
        static void Main(string[] args)
        {
            Shapes shapes = new Shapes();
            shapes.AddShape(new Circle(1));
            shapes.AddShape(new Circle(2));
            shapes.AddShape(new Circle(3));
            shapes.AddShape(new Rectangle(10, 20));
            shapes.AddShape(new Rectangle(20, 30));
            shapes.AddShape(new Rectangle(40, 50));

            foreach (var item in shapes.list)
            {
                Console.WriteLine(item);
            }
        }
    }
}