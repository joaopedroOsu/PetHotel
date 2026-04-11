Console.WriteLine("=Pet Hotel=");
Console.Write("especie.....:");
String especie = Console.ReadLine();
Console.Write("Raca.....:");
String raca = Console.ReadLine();
Console.Write("Nome do Animal.........:");
String nome = Console.ReadLine();
Console.Write("Idade Do Animal.....:");
String idade = Console.ReadLine();
Console.Write("Pelagem do Animal.....:");
String pelagem = Console.ReadLine();

// .Insert(15, "|")
// Console.Write("| Raca:".Insert(, "|"));

 Console.Write("| Especie:");
 Console.Write(especie.Trim().ToUpper().PadLeft(15, '.').Substring(0, 15));

Console.Write("| Raca:");
Console.Write(raca.Trim().ToUpper().PadLeft(15, '.').Substring(0, 15));
Console.Write(" |");

Console.Write("\n| Atende pela alcunha de:.......");
Console.Write(nome.Trim().ToUpper().PadLeft(15, '.').Substring(0, 15));
Console.Write(" |");

Console.Write("\n| Idade:");
Console.Write(idade.Trim().ToUpper());
Console.Write(" anos(s) |");



Console.Write(" Pelagem/cor:");
Console.Write(pelagem.Trim().ToUpper().PadLeft(15, '.').Substring(0, 15));
Console.Write(" |");

Console.Write("\n+=========================================================+");