// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Creating and using Anonymous types

// TODO: Anonymous types can be declared using "new" and { }, similar to JS
var myobj = new
{
    Name = "Omar",
    Age = 30,

    Address = new
    {
        Street = "123 Main St",
        City = "Anywhere"
    }
};

Console.WriteLine($"Name: {myobj.Name}, Age: {myobj.Age}");
Console.WriteLine(myobj);

// Anonymous types are read-only and cannot be modified
//myobj.Name = "Jane Doe"; # will cause an error

// TODO: To change a value, use non-destructive mutation and "with" clause

var myobj2 = myobj with {Name = "Vince"};

Console.WriteLine(myobj2);


// TODO: You can check to see if an anonymous object contains a property

Console.WriteLine(myobj.GetType().GetProperty("Name") != null); //true
Console.WriteLine(myobj2.GetType().GetProperty("ZipCode") != null); //false
