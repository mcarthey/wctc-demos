using System.Collections.Generic;

namespace Pets.Models
{
    public abstract class PetsModel
    {
        public List<string> Names;

        public PetsModel()
        {
            Names = new List<string>();
        }

        public bool FindOurPet(string petName)
        {
            return petName.Equals("Fluffy");
        }        
    }
}