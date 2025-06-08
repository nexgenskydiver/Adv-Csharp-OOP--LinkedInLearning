// Using Inheritance to define a class hierarchy

// Instantiate some objects
Circle c = new Circle(10);
Rectangle r = new Rectangle(10, 20);
Square s = new Square(10);

// Exercise the ToString() method
Console.WriteLine($"{c}");
Console.WriteLine($"{r}");

// Use the "is" operator to test an object type
Console.WriteLine($"{c is Shape2D}");
Console.WriteLine($"{c is Rectangle}");

// Call the GetArea() function on each one
Console.WriteLine(c.GetArea());
Console.WriteLine(r.GetArea());
Console.WriteLine(s.GetArea());

// Print the area of each shape
void PrintArea(Shape2D shape)
{
    Console.WriteLine($"{shape.GetArea()}");
}

// All the classes derive from Shape2D, so we can treat each one
// as an instance of the base class.
PrintArea(c);
PrintArea(r);
PrintArea(s);