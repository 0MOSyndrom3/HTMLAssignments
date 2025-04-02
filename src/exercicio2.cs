using System;

public class Compras
{
    public static void Main(string[] args)
    {
        int quant;
        float preco, total;
        
        Console.WriteLine("Digite a quantidade do produto que deseja: ");
        quant = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Digite o preco do produto que deseja: ");
        preco = Convert.ToSingle(Console.ReadLine());
        
        total = quant*preco;
        
        Console.WriteLine("O valor total vai ser de: R$" + total);
    }
}
