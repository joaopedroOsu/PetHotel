Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Fixa do Pet");
Console.Write("especie.....:");
String especie = Console.ReadLine()!;
Console.Write("Raca.....:");
String raca = Console.ReadLine()!;
Console.Write("Nome do Animal.........:");
String nome = Console.ReadLine()!;
Console.Write("Idade Do Animal.....:");
String idade = Console.ReadLine()!;
Console.Write("Pelagem do Animal.....:");
String pelagem = Console.ReadLine()!;

// .Insert(15, "|")
// Console.Write("| Raca:".Insert(, "|"));
// Console.BackgroundColor = ConsoleColor.White; fica muito ruim
Console.ForegroundColor = ConsoleColor.Green;
Console.Write("+=========================================================+");
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("\n|                        Pet Hotel                        |");
Console.ForegroundColor = ConsoleColor.Green;
Console.Write("+=========================================================+");

Console.ForegroundColor = ConsoleColor.Blue;
 Console.Write("\n| Especie:");
 Console.Write(especie.Trim().ToUpper().PadLeft(15, '.').Substring(0, 15));

Console.ForegroundColor = ConsoleColor.Blue;
Console.Write("| Raca:");
Console.Write(raca.Trim().ToUpper().PadLeft(25, '.').Substring(0, 25));
Console.Write(" |");
Console.ForegroundColor = ConsoleColor.Green;
Console.Write("\n+=========================================================+");

Console.ForegroundColor = ConsoleColor.Blue;
Console.Write("\n| Atende pela alcunha de:.......");
Console.Write(nome.Trim().ToUpper().PadLeft(25, '.').Substring(0, 25));
Console.Write(" |");

Console.ForegroundColor = ConsoleColor.Blue;
Console.Write("\n| Idade:");
Console.Write(idade.Trim().ToUpper());
Console.Write(" anos(s) |");

Console.ForegroundColor = ConsoleColor.Blue;
Console.Write(" Pelagem/cor:");
Console.Write(pelagem.Trim().ToUpper().PadLeft(25, '.').Substring(0, 25));
Console.Write(" |");

Console.ForegroundColor = ConsoleColor.Green;
Console.Write("\n+=========================================================+");
Console.ResetColor();