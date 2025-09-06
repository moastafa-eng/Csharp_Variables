using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.IO;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSharp_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Introduction to variables
            // =========
            // Variables
            // =========

            // Summary: in this Lesson, you’ll learn about C# variables including declaring variables, assigning values to variables,
            // and displaying variables in the console.

            //Programs process data.Typically, They work as follows:

            // 1.First, get data from user inputs, files, or third-party API.
            // 2.Second, process the data.
            // 3.Third, output the result to the screen or save it to data storage such as a file or database.

            //To store data during the execution of the program, you use variables.

            //By definition, variables are identifiers whose values can change during the program’s execution.
            //When the program ends, the values stored in the variables are also gone. 
            #endregion

            #region Declare Variables
            // How to declare variable ? 
            // To declare variable using the following syntax : 

            // DataType Variable = Value. 

            // in this syntax the type can be any C# Built_In DataType like <<string>> it represents
            // text or <<int>> represents integers Or CustomType we will learn about the custom type later.

            // The variableName is a valid identifier that starts with a character
            // or underscore (_) and is followed by other characters

            // There are the most commonly used built_in types 
            // 1. int : Integers Like (1,2,3)
            // 2. float : Single-precision floating-point numbers like (1,2f)
            // 3. double : Double-precision floating-point numbers like (12.32) 
            // 4. string : Text Strings like ("Hello World")
            // 5. char : Characters like ('a', 'b', 'c')
            // 6. bool : Boolean values like (True, False)

            // By conventions, variable names are in the camel case start with a small litter like (firstName, lastName)

            // The following example declare the variable age with with the type int
            //int age;

            // After declaring a variable, you can assign a value to it using assignment operator '='
            //age = 23;

            // and you can do both step using one statement
            //int age = 23

            // The following example increases the value of the age variable by one : 
            //int age = 18;
            //Age += 1;

            //After the second statement, the value of age is 19.

            //C# is a type-safe language. It means that the compiler will ensure that the variable will always store a value of the declared type.

            //In the above example, the age variable will always store an integer. If you assign it a string, the compiler will issue an error.

            //The following code will result in an error when compiling:
            //int age = "One"; => error CS0029: Cannot implicitly convert type 'string' to 'int' 
            #endregion

            #region Display Variables

            // To output the age variable to the console you use the Console.WriteLine as follows;
            //int age = 28;
            //Console.WriteLine(age);

            // To embed the age variable to a string and display it, you use the following statement : 
            //int age = 18;
            //Console.WriteLine($" Your age is : {age}");

            //In this statement:
            //
            //First, prefix the string with the $ symbol.
            //Second, place the variable(age) inside the curly braces { }.
            //When the compiler sees a string with the $ prefix, it’ll replace all the variables in the curly braces with their corresponding values

            // Declare Multiple variables : 

            // To Declare multiple variable you use multiple statement : 
            //double weight = 12.2;
            //double Height = 32.23;

            // If variables have the same type, you cane declare them in one statement and use a comma (,) 
            // to separate between them

            //double Height = 12.13,
            //    Weight = 14.12;
            //Console.WriteLine($"the Height is {Height} and the Weight is {Weight}"); 
            #endregion

            #region Variable Example

            // Variable Example : the following example illustrates how to use variables to calculate the body math index

            double weight = 12.2,
                height = 13.4;

            // Calculate BMI.
            double bmi = weight / (height * weight);

            Console.WriteLine("Calculate body math index BMI : ");
            Console.WriteLine($"Weight: {weight}kg");
            Console.WriteLine($"Height: {height}m");
            Console.WriteLine($"BMI: {bmi}");
            #endregion

            #region Summary
            //Summary : 

            //    Variables are identifiers whose values change during the execution of a program.
            //    By convention, variable names are in the camel case.
            //    Use variables to store data in the program.

            #endregion

        }
    }
}
