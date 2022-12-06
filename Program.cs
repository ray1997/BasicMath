MathOperations<int> mathOperations = new MathOperations<int>();

int result1 = mathOperations.Add(5, 10);
int result2 = mathOperations.Subtract(20, 10);
int result3 = mathOperations.Multiply(5, 10);
int result4 = mathOperations.Divide(100, 10);

Console.WriteLine($"5 + 10 = {result1}");
Console.WriteLine($"20 - 10 = {result2}");
Console.WriteLine($"5 × 10 = {result3}");
Console.WriteLine($"100 ÷ 10 = {result4}");