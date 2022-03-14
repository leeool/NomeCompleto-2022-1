string nome;
string sobrenome;

//pedir nomes
Console.Write("Digite seu nome: ");
nome = Console.ReadLine()!;
Console.Write("Digite seu sobrenome: ");
sobrenome = Console.ReadLine()!;

//nome completo
Console.ForegroundColor = ConsoleColor.Red;
Console.Write("\nNome Completo: ");
Console.ResetColor();
Console.WriteLine($"{nome} {sobrenome}");

//catálago
Console.ForegroundColor = ConsoleColor.Red;
Console.Write("Catálogo: ");
Console.ResetColor();
Console.WriteLine($"{sobrenome.ToUpper()}, {nome}");