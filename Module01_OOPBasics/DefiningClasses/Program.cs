﻿// Defining and Instantiating classes

// Create some new Rectangle objects with dimensions
Rectangle rect1 = new Rectangle(10, 20);
Rectangle rect2 = new Rectangle(30);

Console.WriteLine(rect1.GetArea());
Console.WriteLine(rect2.GetArea());

// Change the values od width and height
rect2.width = 5;
rect2.height = 7;
Console.WriteLine(rect2.GetArea());