public class MyClass
{
    public MyClass() { }

    // Public members can be accessed from any other class
    public void Func1()
    {
        Console.WriteLine("This is Func1");
        SomeValue += 1;
    }

    // Protected members can be accessed only from this class or derived classes
    protected void Func2()
    {
        Console.WriteLine("This is Func2");
        SomeValue -= 1;
    }

    // Private members can only be accessed by this class
    private int SomeValue = 1;

    // Properties often expose internal data, so they are usually public
    public int Data
    {
        get => SomeValue;
        set => SomeValue = value;
    }
}

public class DerivedClass : MyClass
{
    public DerivedClass() { }

    public void Func3()
    {
        Console.WriteLine("This is Func3");

        // Func2 can be accessed because this is a subclass of MyClass
        // SomeValue++ can not be accessed, it is derived, but member is private
        base.Func2();
    }
}