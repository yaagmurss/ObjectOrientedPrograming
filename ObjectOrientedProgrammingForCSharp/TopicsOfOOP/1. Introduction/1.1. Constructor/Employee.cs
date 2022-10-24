using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgrammingForCSharp.TopicsOfOOP._1._1._Constructor
{
    class Employee
    {
        /// <summary>
        /// 
        /// If the class name "Employee" then Constructor name will be "Employee". It is requirement
        ///        
        /// Constructor is a skeleton to initialize the field at the early stage of the class.
        /// Constructor Initialize fields and does not return any value.
        /// 
        /// Constructor's name has to be the same with class. 
        /// If you change the name of the constructor, the rutime will not treat it as it is a constructor method.            
        /// Constructor must have public Acces Modifiers
        /// 
        /// If you dont define a default or parameter less constructor for your class C# complier creates one for it
        /// For any kind of numbers ==>> 0
        /// boolean ==>> False
        /// string,char ==>> "" 
        /// 
        /// </summary>

        public string Name; //Name Field must be PascalCase
        public string LastName;

        // If you want to create a constructor you can simply write ctor and press Tab two times
        //This is a keyword that references the currnt object
        public Employee(string name) // Name Parameter must be camelCase
        {
            this.Name = name; //Name Field and name parameter they both have the same spell but different name convention
        }

        public Employee() //Parameter Less Constructor
        {
        }

        //OverLoading
        //Overloading ==>> Creating constructor method by same name with different signatures
        //You can see from "C:\Users\200741\source\repos\ObjectOrientedProgrammingForCSharp\ss\ss3.png" as how it look on the main Method

        public Employee(string name, int age) { }
        public Employee(string name, int id, bool isExists) { }
        public Employee(string name, int id, bool isExists, int num) { }

        

        public void EmployeeOfMonth()
        {
            Console.WriteLine("Employee Of Month is : " + Name);
        }

        //Object Initializers
        //Object Initialiers : A syntax for quickly initalizing an object without using Constructor

        //Employee empl = new Employee()
        //{
        //    Name = "Yagmur",
        //    LastName = "Solmaz"
        //};


        //Base class
        //Base Class Constructor are always executed First
        //And they are not inherited





    }
}
