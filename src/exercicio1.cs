using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        float n1, n2, n3, menor;
        
        Console.WriteLine("Digite o primeiro numero:");
        n1 = Convert.ToSingle(Console.ReadLine());
        
        Console.WriteLine("Digite o segundo numero:");
        n2 = Convert.ToSingle(Console.ReadLine());
        
        Console.WriteLine("Digite o terceiro numero:");
        n3 = Convert.ToSingle(Console.ReadLine());
        
        Console.WriteLine("Sua media e de: " + (n1+n2+n3)/3);
    }
}
