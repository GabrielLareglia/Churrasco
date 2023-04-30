int adultosComBebida, adultosComCarne, criancas, adultos, pessoas;
double carne, acompanhamentos, bebida;

Console.WriteLine("---Churrasco---\n");

Console.Write("Aldultos(que consomem bebida ).......:");
adultosComBebida = Convert.ToInt32(Console.ReadLine());

Console.Write("Adultos (que não consomem carne)...........: ");
adultosComCarne = Convert.ToInt32(Console.ReadLine());

Console.Write("Crianças........................................: ");
criancas = Convert.ToInt32(Console.ReadLine());

adultos = adultosComBebida + adultosComCarne;
pessoas = adultos + criancas;

carne = 0.3 * adultos + 0.3 * criancas;
acompanhamentos = 0.1 * pessoas;
bebida= 2 * adultosComBebida;

Console.WriteLine();

Console.Write($"Carne.............: {carne:N1}kg");
Console.Write($"Acompanhamentos...: {acompanhamentos:N1}kg");
Console.Write($"Bebida............: {bebida:N1}l");


