using System;

class Program
{
    public static void Main(){
    Console.WriteLine("adjon meg egy számot:");
    int szam = int.Parse(Console.ReadLine());
    Console.WriteLine("adjon meg egy másik számot:");
     int szam2 = int.Parse(Console.ReadLine());
     szam += szam2;
      Console.WriteLine("adjon meg még egy számot:");
       szam2 = int.Parse(Console.ReadLine());
        szam += szam2;
        Console.WriteLine("az összeükk:" + szam);
    }
}