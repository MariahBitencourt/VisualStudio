int idade;
Console.WriteLine("Digite sua idade: ");
idade = int.Parse(Console.ReadLine());

if (idade >= 18)
{
    Console.WriteLine("Você tem " + idade + " anos");
    Console.WriteLine("Você pode tirar carta de motorista");

}
else if (idade < 18)
{
    Console.WriteLine("Você tem " + idade + " anos");
    Console.WriteLine("Você não tem idade suficiente para tirar carta de motorista");
}

