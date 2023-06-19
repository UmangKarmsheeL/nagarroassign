using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "hello";
            string str2 = "hello";
            string str3 = new string(new char[] { 'h', 'e', 'l', 'l', 'o' });

            Console.WriteLine(str1 == str2); // Output will be True - both strings have the same value
            Console.WriteLine(str1.Equals(str2)); // Output will be True - both strings have the same value
            Console.WriteLine(Object.ReferenceEquals(str1, str2)); // Output will be True - both strings are the same object in memory

            Console.WriteLine(str1 == str3); // Output will be True - both strings have the same value
            Console.WriteLine(str1.Equals(str3)); // Output will be True - both strings have the same value
            Console.WriteLine(Object.ReferenceEquals(str1, str3)); // Output will be False - str1 and str3 are different objects in memory

            //The "==" operator and "Equals()" method both check if the strings have the same value,
            //which is true for "str1" and "str2", as well as "str1" and "str3".
            //The "ReferenceEqual()" method on other hand check if the two objecs are the same instances in memory.
            Console.ReadLine();
        }
    }
}
