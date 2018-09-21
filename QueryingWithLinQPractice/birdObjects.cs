using System.Linq;
using System.Collections.Generic;

namespace Treehouse.CodeChallenges
{
    public class Bird
    {
        public string Name { get; set;}
        public string Color { get; set;}
        public int Sightings {get; set;}

        List<Bird> birds = new List<Bird>
        {
            new Bird { Name = "Cardinal", Color = "Red", Sightings = 3 },
            new Bird { Name = "Dove", Color = "White", Sightings = 2} 
            };
        }
}
using System.Collections.Generic;

namespace Treehouse.CodeChallenges
{
    public static class BirdRepository
    {
             public static List<Bird> LoadBirds()
        {
            var birds = new List<Bird>
            {
                new Bird { Name = "Pelican", Color = "White", Sightings = 3 }
            };
            return birds;
        }

        }
    }
