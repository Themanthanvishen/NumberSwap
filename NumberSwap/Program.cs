// See https://aka.ms/new-console-template for more information
using System;
public class SwapExe
{
    public static void Main(string[] args)
    {
        int number1;
        int number2;
        int sawpnum;

        Console.WriteLine("\nWelcome!");
        Console.Write("\nFirst Number : ");

        number1 = int.Parse(Console.ReadLine());

        Console.Write("\nSecond Number : ");

        number2 = int.Parse(Console.ReadLine());

        sawpnum = number1;
        number1 = number2;
        number2 = sawpnum;

        
        Console.Write("\nFirst Number : " + number1);
        Console.Write("\nSecond Number : " + number2);
        Console.ReadLine();

    }
}