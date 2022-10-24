using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgrammingForCSharp.TopicsOfOOP
{
    /// <summary>
    /// 
    /// Access Modifiers is about controlling element of classes
    /// 
    /// There are few of them:
    /// public : Accesible from everwhere
    /// private : Accesible only from the class
    /// protected : Accesible only from the class and it is derived classes
    /// internal : Accesible only from the same assembly
    /// protected internal : Accesible only from the same assembly and any derived classes
    ///    
    /// There is a reason why we want to develop our classes as BlackBox. 
    /// If there is a change in somewhere It has to be efect minimum area of an app
    /// 
    /// </summary>
    class Customers
    {
        //C:\Users\200741\source\repos\ObjectOrientedProgrammingForCSharp\ss\ss7.png
        //You can see the public interface of an method
        // ToString, Equal, GetType is derived from ***Base Object Class***
        // Bold members is belong to customer class itself
        //All of this together make up the public interface of customer class
        //We want to minimize this interface in order to prevent tightly coupling

        //We cannot see
        public int Id { get; set; }
        public int Name { get; set; }

        public void GetPrometed(int ratingScore)
        {
            if(ratingScore > 5)
            {
                Console.WriteLine("YourGetPromoted");
            }
            else
            {
                Console.WriteLine(CalculateRating());
            }
        }

        //We cannot see the Calculate rating because It is private now 
        //Any changes in a private method now stayes in the class and effect fewer places
        private int CalculateRating()
        {
            return 0;
        }
        //If we want the see the method in an Solution we use internal 
        //I we want see anywhere we use public

        


    }
}
