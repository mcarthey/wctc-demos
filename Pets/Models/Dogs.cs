using System.Collections.Generic;

namespace Pets.Models
{
    public class Dogs : PetsModel
    {
        public Dogs()
        {
            Names = new List<string>() {
                "Rover", "Spot", "Sport", "Clifford"
            };
        }
    }
}