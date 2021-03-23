using System.Collections.Generic;

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
    }
}