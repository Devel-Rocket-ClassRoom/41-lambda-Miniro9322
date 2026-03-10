using System;

// README.md를 읽고 아래에 코드를 작성하세요.
var system = CreateLogger("시스템");
var network = CreateLogger("네트워크");

system("서버를 시작합니다.");
system("초기화가 완료되었습니다.");
network("클라이언트가 접속했습니다.");
system("요청을 수리합니다.");
network("데이터를 수신했습니다.");
network("클라이언트가 종료했습니다.");

Action<string> CreateLogger(string category)
{
    int log = 1;
    return msg => Console.WriteLine($"[{category} #{log++}] {msg}");
}

