using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            var bird1 = new Bird();
            bird1.HaveWings = true;
            bird1.FeatherCount = 3000;


            Console.WriteLine($"My bird, {bird1.Name}, is {bird1.Color} and the size of {bird1.Size} inch(es). Does it have legs? {bird1.HaveLegs}");
            Console.WriteLine($"Does it have a beak? {bird1.HaveBeak}. Does it have wings? {bird1.HaveWings}. It has {bird1.FeatherCount} feathers. Can it lays eggs? {bird1.LayEggs}");
            Console.WriteLine("\n");

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            var reptile1 = new Reptile();
            reptile1.HaveTail = true;
            reptile1.HowManyEggs = 100;

            Console.WriteLine($"My lizard, {reptile1.Name}, is {reptile1.Color} and the size of {reptile1.Size} inch(es). Does it have legs? {reptile1.HaveLegs}");
            Console.WriteLine($"Does it have a tail? {reptile1.HaveTail}. Does it have scaly skin? {reptile1.ScalySkin}. It can lay up to {reptile1.HowManyEggs} eggs. It can crawl? {reptile1.Crawl}");
        }
    }
}
