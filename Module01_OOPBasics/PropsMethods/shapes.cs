// Defining and Instantiating classes

// Define a Class using the 'class' keyword
class Rectangle
{
    // The Constructor accepts parameters used to create the object
    public Rectangle(int w, int h)
    {
        width = w;
        height = h;
    }

    // For convenience, we can have a constructor that takes one value
    // for squares that have the same size sides
    public Rectangle(int side)
    {
        width = height = side;
    }

    // classes can define Methods that return values
    public int GetArea()
    {
        return width * height;
    }

    // Define Properties that allow access to the private data
    // These are called 'backing field' properties
    public int Width
    {
        get { return width; }
        set { width = value; }
    }

    public int Height
    {
        get { return height; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Height", "must be >= 0");
            }
            height = value;
        }
    }

    // Auto-implmented properties dont have a backing field
    public int BorderSize
    {
        get;
        set;
    } = 1;

    // Member variables hold data
    int width;
    int height;
}