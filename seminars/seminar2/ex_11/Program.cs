int n = new Random().Next(100,1000);
Console.WriteLine($"Сгенерировано число {n}");

int n1 = n / 100;
int n2 = (n / 10) % 10;
int n3 = n % 10;

Console.WriteLine($"{n1}{n3}");
Console.WriteLine(n2);