using System.Collections.Generic;

namespace Pets.Models
{
    public class Birds : PetsModel
    {
        public Birds()
        {
            Names = new List<string>() {
                "Tweety", "Woodstock", "Big Bird", "Woody"
            };
        }        
    }
}