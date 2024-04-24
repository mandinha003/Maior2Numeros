double primeiro, segundo;

Console.Write("Digite o primeiro número..: ");
primeiro = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o segundo número...: ");
segundo = Convert.ToDouble(Console.ReadLine());

if (primeiro > segundo)
{
    Console.WriteLine($"O maior número é {primeiro}");
}
else
{
    Console.WriteLine($"O maior número é {segundo}");
}