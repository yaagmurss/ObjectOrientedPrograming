using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgrammingForCSharp.TopicsOfOOP._2._Relationships_Between_Classes.Inheritence
{
    /// <summary>
    /// Inheritence
    /// 
    /// Inheritence is a relation between classes   
    /// A Class inherit from another. In a C# project A Class can only have one parent
    /// 
    /// ParentBaseClass / Child DerivedClass
    ///      Cooking    /    Chopping
    /// 
    /// "C:\Users\200741\source\repos\ObjectOrientedProgrammingForCSharp\ss\ss6.png"
    /// We see the snap abow we can see that If we create Chopping Object we can acces Cooking fields and methods
    /// Because Chopping inherit from Cooking
    /// 
    /// And also we see few more methods that we dont create when we try to call a method Like "GetType", "ToString", "Equal"...
    /// These methods are defined in the object class which is the parent of all the classes in .NET    /// 
    /// 
    /// </summary>
    public class Chopping : Cooking // Child : Parent
    {
        public int SliceCount;
        public string vegetables;

        public Chopping(int cookingMin)
            :base(cookingMin)

        {
            Console.WriteLine("Chopping class is being initilized..." + cookingMin.ToString());
        }

        public void Slicer()
        {
            Console.WriteLine("vegetables is being slied...");
        }


    }
}
