// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Using inheritance to define a class hierarchy

// Instantiate some objects
Circle c = new Circle(10);
Rectangle r = new Rectangle(10,20);

// TODO: Exercise the ToString() method


// TODO: Use the "is" operator to test an object type
Console.WriteLine($"{c is Shape2D}");
Console.WriteLine($"{r is Shape2D}");

// TODO: Call the GetArea() function on each one
double area1 = c.GetArea();
double area2 = r.GetArea();

// TODO: Print the area of each shape

Square x = new Square(10);
Console.WriteLine($"Area of square is {x.GetArea()}");


// TODO: All of the classes derive from Shape2D, so we can treat each one
// as an instance of the base class. 

Console.WriteLine(x is Shape2D);

void PrintArea(Shape2D shape)
{
    Console.WriteLine($"Area is {shape.GetArea()}");
}

Console.WriteLine("Printing areas via base class reference:");
PrintArea(r);
PrintArea(c);
PrintArea(x);

