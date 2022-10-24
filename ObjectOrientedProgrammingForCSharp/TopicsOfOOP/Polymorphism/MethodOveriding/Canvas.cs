using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgrammingForCSharp.TopicsOfOOP.Polymorphism.MethodOveriding
{
    class Canvas
    {
        public void DrawsShapes(List<Shape> shapes)
        {
            foreach(var shape in shapes)
            {
                shape.Draw();
            }
        }
    }
}
