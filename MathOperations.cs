/// <summary>
/// A static class that provides methods for performing basic math operations using generics.
/// </summary>
public static class MathOperations<T>
{
    /// <summary>
    /// Adds two values of the specified type and returns the result.
    /// </summary>
    /// <param name="a">The first value to add.</param>
    /// <param name="b">The second value to add.</param>
    /// <returns>The sum of the two values.</returns>
    public static T Add(T a, T b)
    {
        dynamic x = a; // convert the values to dynamic to allow for operations on different data types
        dynamic y = b;
        return x + y; // return the sum of the two values
    }

    /// <summary>
    /// Subtracts two values of the specified type and returns the result.
    /// </summary>
    /// <param name="a">The value to subtract from.</param>
    /// <param name="b">The value to subtract.</param>
    /// <returns>The difference of the two values.</returns>
    public static T Subtract(T a, T b)
    {
        dynamic x = a; // convert the values to dynamic to allow for operations on different data types
        dynamic y = b;
        return x - y; // return the difference of the two values
    }

    /// <summary>
    /// Multiplies two values of the specified type and returns the result.
    /// </summary>
    /// <param name="a">The first value to multiply.</param>
    /// <param name="b">The second value to multiply.</param>
    /// <returns>The product of the two values.</returns>
    public static T Multiply(T a, T b)
    {
        dynamic x = a; // convert the values to dynamic to allow for operations on different data types
        dynamic y = b;
        return x * y; // return the product of the two values
    }

    /// <summary>
    /// Divides two values of the specified type and returns the result.
    /// </summary>
    /// <param name="a">The value to be divided.</param>
    /// <param name="b">The value to divide by.</param>
    /// <returns>The quotient of the two values.</returns>
    public static T Divide(T a, T b)
    {
        dynamic x = a; // convert the values to dynamic to allow for operations on different data types
        dynamic y = b;
        return x / y; // return the quotient of the two values
    }
}
