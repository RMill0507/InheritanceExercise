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
            Birds favBird = new Birds();
            
            favBird.Name = "Bald Eagle";
            favBird.FeatherColor = "Brown";
            favBird.Size = "Large Bird";
            favBird.CanFly = true;

            Console.WriteLine($"My favorite Bird is the {favBird.Name}");
            Console.WriteLine($"The colors of its feathers are {favBird.FeatherColor} and it's a very {favBird.Size}");
            Console.WriteLine($"Can it Fly?: {favBird.CanFly}");

            /*Create an object of your Reptile class
           *  give values to your members using the object of your Reptile class
           *  
           * Creatively display the class member values 
           */
            var favReptile = new Reptile();
            favReptile.HasLegs = true;
            favReptile.SkinColor = "green";
            favReptile.Name = "Crocodile";
            favReptile.Size = "one of the biggest reptiles on the planet";
            favReptile.HasTeeth = true;
            Console.WriteLine();
            Console.WriteLine($"My #1 reptile is the {favReptile.Name}");
            Console.WriteLine($"Its color is mostly {favReptile.SkinColor} and is {favReptile.Size}");  
            Console.WriteLine($"Does it have teeth?: {favReptile.HasTeeth}");   







        }
    }
}
