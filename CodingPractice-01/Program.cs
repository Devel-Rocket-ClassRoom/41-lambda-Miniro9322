using System;

// README.md를 읽고 아래에 코드를 작성하세요.

//1
PrintMessage printMessage = () => Console.WriteLine("안녕하세요.");
printMessage();

//2
Transformer square = x => x * x;
Console.WriteLine(square(3));
Console.WriteLine(square(4));

//3
IsLonger isLong = (string msg, int len) => msg.Length > len;
Console.WriteLine(isLong("안녕하세요.", 5));
Console.WriteLine(isLong("반갑습니다.", 10));

//4
Greeting greeting = () =>
{
    Console.WriteLine("안녕하세요.");
    Console.WriteLine("반갑습니다.");
};

greeting();


//5
Calculator add = (int a, int b) =>
{
    Console.WriteLine($"{a} + {b} = {a + b}");
    return a + b;
};
Console.WriteLine($"합계: {add(3, 5)}");

//1
delegate void PrintMessage();
//2
delegate int Transformer(int i);
//3
delegate bool IsLonger(string s, int i);
//4
delegate void Greeting();
//5
delegate int Calculator(int a, int b);