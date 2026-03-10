using System;
using System.Runtime.Serialization;

// README.md를 읽고 아래에 코드를 작성하세요.
Func<string, string> toUpper = value => value.ToUpper();
Func<string, string> mask = value => $"{value.Substring(0, 2)}***";
Func<string, string> greet = value => $"안녕하세요, {value}님!";

Console.Write("[대문자 변환] ");
ApplyAndPrint("hello world", toUpper);

Console.Write("[마스킹 처리] ");
ApplyAndPrint("SecretCode", mask);

Console.Write("[인사말 생성] ");
ApplyAndPrint("민수", greet);


void ApplyAndPrint(string input, Func<string, string> formatter)
{
    Console.WriteLine($"{input} → {formatter(input)}");
}