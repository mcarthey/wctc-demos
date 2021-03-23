using System.Collections.Generic;

namespace Pets.Models
{
    public class Cats : PetsModel
    {
        public Cats()
        {
            Names = new List<string>() {
                "Fluffy", "Muffin", "Devil", "Claws"
            };
        }
    }
}