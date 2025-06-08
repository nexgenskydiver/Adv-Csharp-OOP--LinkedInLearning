// Defining and Instantiating classes

// Create some new Rectangle objects with dimensions
Rectangle rect1 = new Rectangle(10, 20);
Rectangle rect2 = new Rectangle(30);

Console.WriteLine(rect1.GetArea());
Console.WriteLine(rect2.GetArea());

// Operate on the Properties
rect1.BorderSize = 5;
Console.WriteLine($"{rect1.BorderSize}");

rect1.Width  = 5;
rect1.Height = 6;
Console.WriteLine(rect1.GetArea());

// Try setting an invalid value
// rect1.Height = -30;