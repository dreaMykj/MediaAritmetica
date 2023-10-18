double primeiro, segundo, terceiro, media;

Console.WriteLine("Média Aritmética de 3 números");

Console.Write("Digite o primeiro número: ");
primeiro = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o segundo número: ");
segundo = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o terceiro número: ");
terceiro = Convert.ToDouble(Console.ReadLine());

media = (primeiro + segundo + terceiro) / 3;
Console.WriteLine($"Média: {media:N1}");