using System;

// README.md를 읽고 아래에 코드를 작성하세요.

//1
Func<int> getNumber = () => 1234;
Func<int, int> square = x => x * x;
Func<int, int, int> add = (x, y) => x + y;

Console.WriteLine(getNumber());
Console.WriteLine(square(3));
Console.WriteLine(add(3, 5));

//2
Action sayHello = () => Console.WriteLine("안녕하세요!");
Action<string> print = (msg) => Console.WriteLine(msg);
Action<string, int> repeat = (msg, count) =>
{
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine(msg);
    }
};

sayHello();
print("Hello, Lambda!");
repeat("반복!", 3);

//3
Func<int, int> annonymous = delegate (int x) { return x * x; };
Func<int, int> lambda = x => x * x;

Console.WriteLine(annonymous(2));
Console.WriteLine(lambda(2));