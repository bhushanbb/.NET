/*
 * Data types in C# are based on Common Type System of the .NET Framework. (.NET is language independent).
 * All data types of each programming language of .NET have to be derived from the types of the CTS.
 * The CTS types are structs and Classes which have methods and constants defined(Similar to wrapper classes of Java).
 * C# has keywords refereing to those classes and structs.
 * structs are value types and classes are reference types. 
 * Value types(Primitive Types):
 * integral: byte(Byte), short(Int16), int(Int32) , long(Int64)
 * floating: float(Single), double(Double), decimal(Decimal)
 * others: char(Char), bool(Boolean), DateTime
 * UDTs: enums and structs. 
 * 
 * Reference Types: Classes,Arrays, delegates, Strings are all reference types. 
 */
using System;
namespace SampleConApp
{
    class AppleExample
    {
        static void Main(string[] args)
        {
            //basicio();
            //conversionExample();
            //checked is a keyword in C# for creating a block that checks for any overflow at the time of compilation only so that it would avoid a lot of unsafe type casting... If the casting is done at runtime, then it throws an OverFlow exception of the casting is improper...
            checked
            {
                Console.WriteLine("Enter a long value");
                int val = (int)long.Parse(Console.ReadLine());
                Console.WriteLine("The value entered is " + val); 
            }
        }

        private static void conversionExample()
        {
            long age = 8768723423468776875;//Integers are implicitly convertable to long.
            //int sAge = (int)age;//Longer range variables have to be explicitly converted to the shorter range using C Style Type casting....
            //C Style casting is not safe as it might give abnormal results if the casting is not possible. Instead use the Convert class which has methods to convert from one type to another. In this case, if the casting is not possible, it throws an Exception and U could handle it...

            int sAge = Convert.ToInt32(age);
            Console.WriteLine("The age is {0}", sAge);//similar to printf kind of format....
        }

        private static void basicio()
        {
            Console.WriteLine("Enter the age");
            int age = int.Parse(Console.ReadLine());
            //Parse is a common method for all value types to convert from string to its type.. 
            //Parse throws a FormatException if the string is not a valid type to which it is converting....

            Console.WriteLine("Enter the salary");
            double salary = double.Parse(Console.ReadLine());

            Console.WriteLine($"The age is {age} and his salary is {salary}");//New syntax of C# 7.0...
        }
    }
}
