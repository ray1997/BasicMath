namespace BasicMath
{
    public static class MathOperations<T>
    {
        public static T Add(T a, T b)
        {
            dynamic x = a;
            dynamic y = b;
            return x + y;
        }

        public static T Subtract(T a, T b)
        {
            dynamic x = a;
            dynamic y = b;
            return x - y;
        }

        public static T Multiply(T a, T b)
        {
            dynamic x = a;
            dynamic y = b;
            return x * y;
        }

        public static T Divide(T a, T b)
        {
            dynamic x = a;
            dynamic y = b;
            return x / y;
        }
    }
}
