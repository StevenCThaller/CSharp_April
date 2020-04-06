using System;

//For dictionaries and lists
using System.Collections.Generic;

namespace FunctionsIntro
{
    class Other
    {
        // This is a public method. I can call this from outside of this class. BUT I can also
        // call any private methods from within this class in this method as well
        public void Speak()
        {
            SayHello();
        }
        // This is a private method. That means this can only be accessed from INSIDE this class
        private void SayHello()
        {
            System.Console.WriteLine("Hello");
        }

        public int ReturnBalance()
        {
            if( SocialNumber() != 234253324)
            {
                Console.WriteLine("No");
                return -1;
            }
            else
            {
                return 100;
            }


        }

        private int SocialNumber()
        {
            // 2349872983749 lines of code to finish this method
            return 234253324;
        }
    }
    class Program
    {
        // Parts to a function declaration:
        // 1. Accessibility level (public or private)
        // 2. optional keyword static -> is this a standalone function or a method?
        // 3. return type -> string? int? int[]? nothing?
        // 4. function name with arguments
        public static void BarTend(int age)
        {
            Console.WriteLine("Here's your drink sir/madam!");
        }

        static void Main(string[] args)
        {
            // Other other = new Other();

            // BarTend(18);
            
            // arrays are super inflexible
            int[] somearray = new int[]{1,2,3,4,5};
            // Python: somearray = [1,2,3,4,5]
            // JS: var somearray = [1,2,3,4,5];

            somearray = new int[]{1,2,3,4};

            // .Length ==> Length of an array
            System.Console.WriteLine(somearray.Length);

            // Declaring a dictionary
            Dictionary<int, string> somedict = new Dictionary<int, string>();
            // Python: somedict = {}
            // JS: var somedict = {};

            somedict.Add(1, "5");
            somedict.Add(17, "hello all");
            // Python: Add a new dictionary entry --> somedict[keyname] = value
            // JS: Same


            // .Count ==> size of dictionary
            System.Console.WriteLine(somedict.Count);


            List<int> somelist = new List<int>();


            somelist.Add(10);
            somelist.Add(7);
            somelist.Add(7);
            somelist.Add(7);
            somelist.Add(11);

            // .Count ==> Length of the list
            System.Console.WriteLine(somelist.Count);

            // .Remove ==> removes first matching instance of the argument
            somelist.Remove(7);

            // .RemoveAt ==> removes from that index
            somelist.RemoveAt(2);

            


            // Python 
            // for i in range(10):

            // Count based for loop
            for(int i = 0; i < 10; i++) 
            {
                // prints i for each iteration
                System.Console.WriteLine(i);
            }


            // for key, value in errors.items():

            // Loop through each entry in a dictionary
            foreach(KeyValuePair<int,string> lkajhsdfkljaklsdjf in somedict)
            {
                // prints the key of each key value pair
                System.Console.WriteLine(lkajhsdfkljaklsdjf.Key);

                // prints the value of each key value pair
                System.Console.WriteLine(lkajhsdfkljaklsdjf.Value);
            }

            // Loop through each item in a list
            foreach(int number in somelist)
            {
                // prints each number in the list
                System.Console.WriteLine(number);
            }

        }
    }
}
