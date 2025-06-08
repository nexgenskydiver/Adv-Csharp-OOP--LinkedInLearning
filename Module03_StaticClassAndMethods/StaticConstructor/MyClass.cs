// Using static constructors

// Define a regular class with instance and static methods
public class MyClass
{
    // static members that only need one-time initialization
    public static long CallCounter;
    public static string LastCaller;

    // The static constructor is only called once, has no parameters,
    // is not called directly, and can not be inherited/overloaded
    static MyClass()
    {
        CallCounter = 0;
        LastCaller = "Nobody";
        Console.WriteLine("Static constructor has been called");
    }

    // Regular constructor
    public MyClass()
    {
        Console.WriteLine("Regular constructor has been called");
    }

    // Instance Method
    public void MethodA()
    {
        CallCounter++;
        LastCaller = "MethodA";
    }

    // Static method
    public static void MethodB()
    {
        CallCounter++;
        LastCaller = "MethodB";
    }
}