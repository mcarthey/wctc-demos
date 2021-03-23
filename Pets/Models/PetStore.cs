using System.Collections.Generic;
using System.Linq;

namespace Pets.Models
{
    public class PetStore
    {
        private List<PetModel> _pets;

        public PetStore()
        {
            _pets = new List<PetModel>();
        }
        public void AdoptPet(PetModel pet)
        {
            _pets.Add(pet);
        }
        public PetModel Locate(string petname) {
            return _pets.Find(pet=>pet.Name.Equals(petname));
        }

        public PetModel Search(string petname) 
        {
            var foundPets = _pets.Where(pet => pet.Name.Equals(petname));
            if (foundPets.Count() > 1)
            {
                var pet = foundPets.ToList().Find(pet=>pet.Owner.Equals("Michael"));
                return pet; 
            }
            return null;
        }
    }
}