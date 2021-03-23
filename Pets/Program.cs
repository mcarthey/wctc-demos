using System;
using Pets.Models;

namespace Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            // open the pet store
            var petStore = new PetStore();
            petStore.AdoptPet(new Dog() {Name="Spot", Owner="Jim"});
            petStore.AdoptPet(new Dog() {Name="Rover", Owner="Bob"});
            petStore.AdoptPet(new Cat() {Name="Fluffy", Owner="Susan"});
            petStore.AdoptPet(new Cat() {Name="Spot", Owner="Michael"});
            petStore.AdoptPet(new Bird() {Name="Tweety", Owner="Elmer"});
            
            // find pet with specific name
            var pet = petStore.Locate("Spot");
            System.Console.WriteLine($"Our pet name is {pet.Name}");
            System.Console.WriteLine($"Our pet owner is {pet.Owner}");

            var pet2 = petStore.Search("Spot");
            System.Console.WriteLine($"Our pet name is {pet2.Name}");
            System.Console.WriteLine($"Our pet owner is {pet2.Owner}");

       }
    }
}
