using System;

namespace schoolDistrict
{
    class Program
    {
        static void Main(string[] args)
        {
            int childAge;

            Console.WriteLine("Welcome to the WCCI School District Age Sorter");
            Console.WriteLine("WHat age is your child?");

            childAge = Convert.ToInt32(Console.ReadLine());
            
            if (childAge >=0 && childAge <= 2) //checks boolean condition
            {
                Console.WriteLine("Still in mamma's arms");
            }
            //If the above condition isn't true check this condition
            //This locks the above conditional from executing
            else if (childAge == 3 || childAge == 4)
            {
                Console.WriteLine("Preschool Maniac");
            }
            else if (childAge >=5 && childAge <= 11)
            {
                Console.WriteLine("Elementary School");
            }
            else if (childAge >=12 && childAge <= 14)
            {
                Console.WriteLine("Middle School");
            }
            else if (childAge >= 15 && childAge <= 18)
            {
                Console.WriteLine("High School");
            }
            else if (childAge >= 19 && childAge <= 22)
            {
                Console.WriteLine("College");
            }
            else if (childAge >= 23 && childAge <= 65)
            {
                Console.WriteLine("Working for the Man");
            }
            else if (childAge >= 66 && childAge <= 100)
            {
                Console.WriteLine("Golden Years");
            }
            else if (childAge > 100 || childAge <0)
            {
                Console.WriteLine("This program is for humans");
            }
            else
            {
                Console.WriteLine("I don't have a category for that age. Where are you from");
            }
        }
    }
}
