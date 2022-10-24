using System;
using System.Collections.Generic;
using ObjectOrientedProgrammingForCSharp.TopicsOfOOP;
using ObjectOrientedProgrammingForCSharp.TopicsOfOOP.Introduction;
using ObjectOrientedProgrammingForCSharp.TopicsOfOOP._1._1._Constructor;
using ObjectOrientedProgrammingForCSharp.TopicsOfOOP._1._2._Fields;
using ObjectOrientedProgrammingForCSharp.TopicsOfOOP._2._Relationships_Between_Classes.Inheritence;
using ObjectOrientedProgrammingForCSharp.TopicsOfOOP.Polymorphism.MethodOveriding;

namespace ObjectOrientedProgrammingForCSharp
{

    class Program
    {

        //Every C# project needs an Main Method (Every project that you done is compile from ***Main Method***)
        //C:\Users\200741\source\repos\ObjectOrientedProgrammingForCSharp\ss\ss1.PNG
        //C:\Users\200741\source\repos\ObjectOrientedProgrammingForCSharp\ss\ss2.PNG
        //You can see "Program" title that represent class that we work
        //If you Look at the solution Explorer you can see the "Program.cs" item that maintain "Main Methods"

        static void Main(string[] args)
        {
            Console.WriteLine("-----------Introduction---------");
            //Introduction
            var person = new Person();
            person.Name = "Yagmur";
            person.Introduce();

            Console.WriteLine("-----------Constructor---------");
            //Constructor
            var emp = new Employee("Yagmur");
            emp.EmployeeOfMonth();

            Console.WriteLine("-----------Fields---------");
            //Fields
            var cs = new Customer();
            var list = new List<string> { "One", "Two", "Three" };
            cs.Orders = list;

            Console.WriteLine("-----------Methods---------");
            //Methods
            var point = new Point();
            Console.WriteLine("PhoneNumber is : " + point.Caller());
            Console.WriteLine("PhoneNumber is : " + point.Receiver("5412863404"));
            point.Add( 1, 2, 3, 4 ); //If you use params yo can add values like this instead of below
            point.Add(new int[] { 1, 2, 3, 4 });

            Console.WriteLine("-----------Modifiers---------");
            //Acces Modifiers
            var john = new Customers();
            var customer = new Customers();
            customer.GetPrometed(5);

            Console.WriteLine("-----------Inheritence---------");
            //Inheritence
            var chopping = new Chopping(5);

            Console.WriteLine("-----------Composition---------");
            //Composition
            //???


            Console.WriteLine("-----------UpCasting---------");
            //UpCasting

            //Text text = new Text();
            ////Shape shape = text;

            //text.Width = 100;
            //shape.Width = 200;

            //Console.WriteLine("Object Width is : {0} ", text.Width); //Returns 200


            Console.WriteLine("-----------MethodOverriding---------");

            var shapes = new List<Shape>();
            shapes.Add(new Circle());
            shapes.Add(new Triangle());

            var canva = new Canvas();
            canva.DrawsShapes(shapes);


        }


    }
}
