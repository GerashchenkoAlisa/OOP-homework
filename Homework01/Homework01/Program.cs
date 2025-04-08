using ArrayDoing;

ArrayProcessing array_a = new ArrayProcessing();
array_a.MaidArray();
array_a.PrintArray();

int a = ArrayProcessing.SumNegativeAfter2Zero(array_a.array);

ArrayProcessing array_b = new ArrayProcessing();
array_b.MaidArray();
array_b.PrintArray();

int b = ArrayProcessing.SumNegativeAfter2Zero(array_b.array) * 2;

ArrayProcessing array_c = new ArrayProcessing();
array_c.MaidArray();
array_c.PrintArray();

int c = ArrayProcessing.SumNegativeAfter2Zero(array_c.array) / 2;

double result = Calculator.Calculate(a, b, c);
Console.WriteLine($"Result: {result}");
Console.ReadLine();