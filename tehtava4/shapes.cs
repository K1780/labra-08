using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Shapes
    {
        public List<Shape> list = new List<Shape>();

        public Shapes()
        { }

        public void AddShape(Shape shape)
        {
            list.Add(shape);
        }
    }
}