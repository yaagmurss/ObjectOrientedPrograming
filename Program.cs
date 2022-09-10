using System;
using System.Collections.Generic;
using ObjectOrientedProgrammingForCSharp.TopicsOfOOP.Introduction;
using ObjectOrientedProgrammingForCSharp.TopicsOfOOP._1._1._Constructor;
using ObjectOrientedProgrammingForCSharp.TopicsOfOOP._1._2._Fields;

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

            //Acces Modifiers

            //Properties

            //Indexer


        }


    }
}
