string senhasdigitada;
string senhasperada = "08230617";

Console.Clear();

Console.WriteLine("Digite A Senha ");
senhasdigitada = Console.ReadLine()!;

if (senhasdigitada == senhasperada)
{ 
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("senha correta"); 
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("senha incorreta");
}
Console.ResetColor();
