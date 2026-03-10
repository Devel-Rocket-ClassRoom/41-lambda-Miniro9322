using System;

// README.md를 읽고 아래에 코드를 작성하세요.

int[] numbers = { 10, 25, 7, 42, 18, 33 };

Console.Write("배열: ");

for(int i = 0; i < numbers.Length; i++)
{
    if(i == 0)
    {
        Console.Write(numbers[i]);
    }
    else
    {
        Console.Write($", {numbers[i]}");
    }
}
Console.WriteLine();

int sum = ProcessArray(numbers, data =>
{
    int sum = 0;
    foreach (int number in numbers)
    {
        sum += number;
    }
    return sum;
}
);
Console.WriteLine($"합계: {sum}");

int max = ProcessArray(numbers, data =>
{
    int max = int.MinValue;
    foreach (int number in numbers)
    {
        if(number > max)
        {
            max = number;
        }
    }
    return max;
});
Console.WriteLine($"최댓값: {max}");

int min = ProcessArray(numbers, data =>
{
    int min = int.MaxValue;
    foreach (int number in numbers)
    {
        if (number < min)
        {
            min = number;
        }
    }
    return min;
});
Console.WriteLine($"최솟값: {min}");

int even = ProcessArray(numbers, data =>
{
    int even = 0;
    foreach (int number in numbers)
    {
        if (number % 2 == 0)
        {
            even++;
        }
    }
    return even;
});
Console.WriteLine($"짝수 개수: {even}");

int ProcessArray(int[] data, Func<int[], int> processor) => processor(data);
