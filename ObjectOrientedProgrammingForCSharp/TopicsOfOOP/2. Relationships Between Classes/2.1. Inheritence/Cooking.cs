using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgrammingForCSharp.TopicsOfOOP._2._Relationships_Between_Classes
{
    /// <summary>    
    /// 
    /// Coupling is a term about associaion between Classes
    /// Tightly Couple : When the classes in an app to dependent to each other It calls Tightly Couple
    /// Loosely Couple : We rather loosely couple. Cause when we change a class, we want this change to be isolated    /// 
    /// 
    /// </summary>
    public class Cooking
    {
        public string Foods;
        public string Beverages;

        public Cooking(int cookingMin)
        {
            Console.WriteLine("Cooking class is being initilized..." + cookingMin.ToString());
        }

        public void HeatingFood()
        {
            Console.WriteLine("Food is heated..");
        }
        public void ServeBeverages()
        {
            Console.WriteLine("Beverages are served...");
        }


    }
}
