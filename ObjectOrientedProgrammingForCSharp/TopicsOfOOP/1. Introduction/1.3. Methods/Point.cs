using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgrammingForCSharp.TopicsOfOOP
{
    class Point
    {
        public string PhoneNumber;

        //VOID METHODS
        // Methods are piece of code that works for a class in order to complete a structured task
        // Void method that can not take any parameter
        // <Access Modifiers><void><Method Name>(){<codes>}
        public void Calculate() { }// Some methods doesnt return any object or value.This kind of methods calls "void type methods"   

        //VOID WITHOUT PARAMETERS
        //Parameters can be variable, array or a class
        //One or more parameters can be used
        //<Acces Modifiers><void><Method Name>(object parameter1, object parameter2){<codes>}
        public void Calculater(string name, string secondName) {} //Parameters write with camelCase


        //VALUE RETURNING METHODS
        //Some methods returns a value to the place that they call
        //Programmers decide what type of value that she/he returns
        //Value returning methods can take parameter or not
        //Returning process done with "Return" keyword
        //Value returning methods return value by using "Return" keyword
        //Returning value can be a variable, class or value
        //Both void and return can be used but It does not return any object
        //Returns causes  compieler to leave the method

        //RETURN WITHOUT PARAMETER
        //<Acces Modifiers>< data Type ><Method Name> (){<codes><Return>}
        public string Caller()
        {
            this.PhoneNumber = "5412863404";
            return PhoneNumber;
        }


        //RETURN WITH PARAMETER
        //<Acces Modifiers><data Type><Method Name> (object parameter1, object parameter2){<codes><Return>}
        public string Receiver(string phoneNumber)
        {
            this.PhoneNumber = phoneNumber; // Field : PhoneNumber ==>> PascalCase   // Parameter : phoneNumber ==>> camelCase
            return PhoneNumber;
        }

        //Call By Value / Call By Reference (????)


        //Overloading
        //If you determine more than 1 method with the same name It calls overloading
        public int Topla(int a, int b) { return a + b; }
        public int Topla(int a, int b, int c) { return a + b; }
        public double Topla(double a, double b) { return a + b; }

        //Params
        public void Add(params int[] numbers) { }

    }
}
