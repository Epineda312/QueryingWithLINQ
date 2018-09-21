/*Challenge Task 1 of 2

In the CodeChallenge.cs file, the birds variable holds an array of 
anonymously typed objects similar to our Bird class.

Create a variable named mysteryBird and assign to it an anonymously 
typed object that has a property named Color with a value of "White" 
and another property named Sightings with a value of 3. */

var birds = new[] 
{ 
    new { Name = "Pelican", Color = "White" }, 
    new { Name = "Swan", Color = "White" }, 
    new { Name = "Crow", Color = "Black" } 

};
var mysteryBird = new {Name="MysteryBird", Color = "White", Sightings = 3};

/*Challenge Task 2 of 2

Create a variable named matchingBirds and assign it a LINQ query 
on the birds variable that have the same Color property as the 
mysteryBird object. In the query, return an anonymous type with 
a property named BirdName and assign to it the Name property of the birds.
 */

var birds = new[] 
{ 
    new { Name = "Pelican", Color = "White" }, 
    new { Name = "Swan", Color = "White" }, 
    new { Name = "Crow", Color = "Black" } 

};

var mysteryBird = new {Name="MysteryBird", Color = "White", Sightings = 3};

var matchingBirds = from s in birds
					where s.Color == mysteryBird.Color
                    select new {BirdName = s.Name};
