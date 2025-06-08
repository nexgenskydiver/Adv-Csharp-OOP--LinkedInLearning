// Defining abstract classes

Car c = new Car() { Make = "Ford", Model = "Escort" };
Motorcycle m = new Motorcycle() { Make = "Triumph", Model = "Thunderbird" };

Console.WriteLine(c);
c.SoundHorn();
Console.WriteLine(m);
m.SoundHorn();

// Instantiate the base class
//Vehicle v = new Vehicle();
//Console.WriteLine(v);