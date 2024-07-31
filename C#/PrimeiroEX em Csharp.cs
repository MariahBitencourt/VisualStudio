int n1,n2,soma,subtracao,divisao,multiplicacao;

Console.WriteLine("Digite o primeiro número: ");
n1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo número:");
n2 = int.Parse(Console.ReadLine());

soma = n1 + n2;
subtracao = n1 - n2;
divisao = n1 / n2;
multiplicacao = n1 * n2;

Console.WriteLine("O resultado da soma dos números é:"+soma);
Console.WriteLine("O resultado da subtração dos números é: " + subtracao);
Console.WriteLine("O resultado da divisão dos números é: " + divisao);
Console.WriteLine("O resultado da multiplicação dos números é: " + multiplicacao);



