using System;

//DevBuild Lab : Blockbuster Lab
//Author: Yosha Kunnummal
//Date: 10/24/2021

namespace BlockBusterLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Blockbuster blockbuster = new Blockbuster();
            Console.WriteLine("Welcome to GC Blockbuster!");
            bool goOn = true;
            while (goOn)
            {
                Console.WriteLine("Please Select a Movie from the list:");
                blockbuster.Checkout();
                goOn = ContinueApplication();
            }
        }
        //A method to check whether the user agrees to continue the application
        public static bool ContinueApplication()
        {
            Console.Write("\nWatch another scene? (y/n):");
            string answer = Console.ReadLine().ToLower();

            if (answer == "y")
            {
                return true;
            }
            else if (answer == "n")
            {
                Console.WriteLine("Bye!");
                return false;
            }
            else
            {
                Console.WriteLine("\nPlease enter 'y' or 'n'");
                //This is recursion, calling a method inside itself
                return ContinueApplication();
            }
        }
    }
}
