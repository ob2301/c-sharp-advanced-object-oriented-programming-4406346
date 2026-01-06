// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Using object and collection initializers

// TODO: Use the initializer syntax to create new objects
Dog doggy = new Dog {Name = "Fido", Age = 4, IsTrained = true};
Cat kitty = new Cat {Name = "Sassy", Age = 2, IsDeclawed = true};
Console.WriteLine($"Dog: {doggy.Name}, Age: {doggy.Age}, Trained: {doggy.IsTrained}");
Console.WriteLine($"Cat: {kitty.Name}, Age: {kitty.Age}, Declawed: {kitty.IsDeclawed}");

// TODO: Initializers can be used on anonymous types
var pet = new
{
    Name = "Omar",
    Age = 4
};
Console.WriteLine($"Pet: {pet.Name}, Age: {pet.Age}");

// TODO: Collections can also be initialized this way

int[] numbers = new int[] {1,2,3,4,5};
Console.WriteLine("Numbers: " + numbers.Length);


// TODO: Initialize a collection with a set of objects

PetOwner owner = new PetOwner
{
    Name = "Joe",
    Pets = new List<Pet>
    {
        new Dog { Name = "Rex", Age = 5, IsTrained = true },
        new Cat { Name = "Whiskers", Age = 3, IsDeclawed = false }
    }
};

Console.WriteLine($"Owner: {owner.Name}, Number of Pets: {owner.Pets?.Count}");

foreach (Pet p in owner.Pets!)
{
    Console.WriteLine($"Pet Name: {p.Name}, Age: {p.Age}");
}
