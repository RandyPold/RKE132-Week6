int[] numbers = new int[10];
Random rnd = new Random();

int sum = 0;

//populating the array
for (int i = 0; i < numbers.Length; i++)
{
    sum= sum + numbers[i];
}

foreach (int number in numbers)
{
    Console.WriteLine(number);
}

Console.WriteLine($"Total: {sum}");