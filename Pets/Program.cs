using System;
using Pets.Models;

namespace Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            // ask user to select pet
            var dog = new Dogs();
            var cat = new Cats();
            var bird = new Birds();

            // find pet with specific name
            var ourDog = dog.Names.Find(petname => petname.Equals("Spot"));
            var ourCat = cat.Names.Find(cat.FindOurPet);
            
            System.Console.WriteLine($"Our pet name is {ourDog}");
            System.Console.WriteLine($"Our pet name is {ourCat}");
       }
    }
}
