using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgrammingForCSharp.TopicsOfOOP._1._2._Fields
{
    class Customer
    {
        // Field like a variable used in class, we use fields to store data about classes

        public List<string> Orders;

        // We can intialize Orders Field, by using default or parameter less Constructor
        //C:\Users\200741\source\repos\ObjectOrientedProgrammingForCSharp\ss\ss4.PNG
        //You can see from the pic. There is one Method and a Field
        public Customer()
        {
            Orders = new List<string>();
        }

        // Or we can directly initialize the orders fields without the need to create constructor
        //C:\Users\200741\source\repos\ObjectOrientedProgrammingForCSharp\ss\ss5.PNG
        //You can see from the pic. There is one a Field without the method

        //List<string> Orders = new List<string>();

        //ReadOnlyField ????
    }
}
