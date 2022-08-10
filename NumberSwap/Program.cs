// See https://aka.ms/new-console-template for more information
using System;
public class SwapExe
{
    public static void Main(string[] args)
    {
        int num1;
        int num2;
        int sawpnum;

        Console.WriteLine("\nWelcome!");
        Console.Write("\nFirst Number : ");

        num1 = int.Parse(Console.ReadLine());

        Console.Write("\nSecond Number : ");

        num2 = int.Parse(Console.ReadLine());

        sawpnum = num1;
        num1 = num2;
        num2 = sawpnum;

        
        Console.Write("\nFirst Number : " + num1);
        Console.Write("\nSecond Number : " + num2);

        // Method 2 without third variable
        int numb1, numb2;
        Console.WriteLine("\n\nMethod 2 (without third variable)");
        Console.Write("\nFirst Number : ");

        numb1 = int.Parse(Console.ReadLine());

        Console.Write("\nSecond Number : ");

        numb2 = int.Parse(Console.ReadLine());

        numb1 = numb1 + numb2;
        numb2 = numb1 - numb2;
        numb1 = numb1 - numb2;
        Console.Write("\nFirst Number : " + numb1);
        Console.Write("\nSecond Number : " + numb2);
        Console.ReadLine();

    }
}