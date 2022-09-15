using System;
using System.Collections.Generic;
using ObjectOrientedProgrammingForCSharp.TopicsOfOOP;
using ObjectOrientedProgrammingForCSharp.TopicsOfOOP.Introduction;
using ObjectOrientedProgrammingForCSharp.TopicsOfOOP._1._1._Constructor;
using ObjectOrientedProgrammingForCSharp.TopicsOfOOP._1._2._Fields;
using ObjectOrientedProgrammingForCSharp.TopicsOfOOP._2._Relationships_Between_Classes.Inheritence;
using ClassLibraryForOOP.AccesModifiers;

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
            //Introduction
            var person = new Person();
            person.Name = "Yagmur";
            person.Introduce();

            //Constructor
            var emp = new Employee("Yagmur");
            emp.EmployeeOfMonth();

            //Fields
            var cs = new Customer();
            var list = new List<string> { "One", "Two", "Three" };
            cs.Orders = list;

            //Methods
            var point = new Point();
            Console.WriteLine("PhoneNumber is : " + point.Caller());
            Console.WriteLine("PhoneNumber is : " + point.Receiver("5412863404"));
            point.Add( 1, 2, 3, 4 ); //If you use params yo can add values like this instead of below
            point.Add(new int[] { 1, 2, 3, 4 });

            //Acces Modifiers
            var john = new Customers();
            var promote = new CustomerPromoter();
            promote.CalculatePromotionCase1(1);         

            

            //Inheritence
            var chopping = new Chopping();
            chopping.HeatingFood();

            //Composition
            //???
            

            


        }


    }
}
