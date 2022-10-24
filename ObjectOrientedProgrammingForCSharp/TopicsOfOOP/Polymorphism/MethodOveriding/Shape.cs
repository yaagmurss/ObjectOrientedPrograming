using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgrammingForCSharp.TopicsOfOOP.Polymorphism.MethodOveriding
{

    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("It is a Circle");
        }
    }
    class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("It is a Triangle");
        }
    }
    abstract class Shape
    {
        public int width { get; set; }
        public string name { get; set; }

        public abstract void Draw();
       
    }
}
