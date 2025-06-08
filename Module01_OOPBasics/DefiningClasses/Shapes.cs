// Defining and Instantiating classes

// Define a Class using the 'class' keyword
class Rectangle
{
    // The Constructor accepts parameters used to create the object
    public Rectangle (int w, int h)
    {
        width = w;
        height = h;
    }

    // For convenience, we can have a constructor that takes one value
    // for squares that have the same size sides
    public Rectangle (int side)
    {
        width = height = side;
    }

    // classes can define Methods that return values
    public int GetArea()
    {
        return width * height;
    }

    // Member variables hold data
    public int width;
    public int height;
}