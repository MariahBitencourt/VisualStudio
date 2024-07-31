using System;

int tab,i;

    Console.WriteLine("Digite um número para a tabuada:  ");
tab = int.Parse(Console.ReadLine());


for ( i = 0; i <= 10; i++) 
{
    Console.WriteLine(tab + "X" + i + "=" + (tab * i));
}

    
    
