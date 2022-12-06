public static class MathOperations<T>
{
    // Adds two values of the specified type and returns the result
    public static T Add(T a, T b)
    {
        dynamic x = a; // convert the values to dynamic to allow for operations on different data types
        dynamic y = b;
        return x + y; // return the sum of the two values
    }

    // Subtracts two values of the specified type and returns the result
    public static T Subtract(T a, T b)
    {
        dynamic x = a; // convert the values to dynamic to allow for operations on different data types
        dynamic y = b;
        return x - y; // return the difference of the two values
    }

    // Multiplies two values of the specified type and returns the result
    public static T Multiply(T a, T b)
    {
        dynamic x = a; // convert the values to dynamic to allow for operations on different data types
        dynamic y = b;
        return x * y; // return the product of the two values
    }

    // Divides two values of the specified type and returns the result
    public static T Divide(T a, T b)
    {
        dynamic x = a; // convert the values to dynamic to allow for operations on different data types
        dynamic y = b;
        return x / y; // return the quotient of the two values
    }
}
