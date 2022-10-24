using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgrammingForCSharp.TopicsOfOOP.Introduction
{
    //Introduction
    public class Person //Each Class should have Name ==>> Must be PascalCase
    {
        /// <summary>
        /// 
        /// Writing every time a code piece that works same or similar to others is a waste of time.
        /// Instead of that you can use Classes and methods to code saving              
        /// Classes ==>> Building Block of Application      
        /// 
        /// UML is a graphical language are representing classes under collabration
        /// 
        /// Person             ==>>Name Of Class
        /// 
        /// Name   :  String   ==>>Fields/Attributes
        /// Age    :  Byte     ==>>Fields/Attributes
        /// Height :  Float    ==>>Fields/Attributes
        /// Weight :  Byte     ==>>Fields/Attributes
        /// 
        /// Introduce()        ==>>Methods/Functions
        /// Talk()             ==>>Methods/Functions
        /// Walk()             ==>>Methods/Functions
        /// 
        /// John               ==>>Object
        /// Mary               ==>>Object
        /// Scott              ==>>Object
        /// 
        /// An application consist multiple classes each responsible for a particular behaviour
        /// And all these classes togeether will provide the expected output application
        /// Object : an instanse of a class that resides in memory 
        /// 
        /// 
        /// </summary>

        //Declaring The Fields

        public string Name; // ==>>Fields/Attributes + Name Field must be PascalCase
        public string Age;
        public string Height;
        public string Weight;

        //Declaring The Methods
        public void Introduce() // ==>>Methods/Functions
        {
            Console.WriteLine("My Name is : " + Name);
        }

        /// <summary>
        /// 
        /// Using Object
        /// var identifier = new TypeOfTheClass(); 
        /// First we have to create Person Object, then we can return Person Object
        /// 
        /// public       ==>> Acces Modifiers
        /// Person      ==>> Object Type
        /// ParsingTest  ==>> Method Name
        /// str          ==>> Parameter
        ///         
        /// If we use static modifier, we dont have to declare person object First
        /// 
        /// </summary>

        public Person ParsingTest(string str)
        {
            var person = new Person();
            person.Name = str;
            return person;
        }

        public static Person ParsingTestSecond(string str)
        {
            var person = new Person();
            person.Name = str;
            return person;
        }






    }
}
