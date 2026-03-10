using System;
using System.Collections.Generic;

// README.md를 읽고 아래에 코드를 작성하세요.

//1
Action[] actions = new Action[3];

for(int i  = 0; i < actions.Length; i++)
{
    actions[i] = () => Console.Write(i);
}

foreach(var action in actions)
{
    action();
}
Console.WriteLine();

//2
actions = new Action[3];
for (int i = 0; i < actions.Length; i++)
{
    int loopVar = i;
    actions[i] = () => Console.Write(loopVar);
}

foreach (var action in actions)
{
    action();
}
Console.WriteLine();

//3
string[] names = { "김철수", "이영희", "박민수", "최지연" };

Array.Sort(names, (a, b) => a.Length.CompareTo(b.Length));
Console.WriteLine("이름 길이순 정렬:");
foreach(var name in names)
{
    Console.WriteLine(name);
}
Console.WriteLine();

Array.Sort(names, (a, b) => b.CompareTo(a));
Console.WriteLine("역순 정렬:");
foreach (var name in names)
{
    Console.WriteLine(name);
}

//4
List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

Console.WriteLine($"첫 번째 짝수: {numbers.Find(x => x % 2 == 0)}");
Console.WriteLine($"모든 짝수: {string.Join(", ", numbers.FindAll(x => x % 2 == 0))}");
Console.WriteLine($"8보다 큰 수: {numbers.Exists(x => x > 8)}");
Console.WriteLine($"모두 양수: {numbers.TrueForAll(x => x > 0)}");
Console.WriteLine($"제거된 짝수 개수: {numbers.RemoveAll(x => x % 2 == 0)}");
Console.WriteLine($"남은 숫자: {string.Join(", ", numbers)}");