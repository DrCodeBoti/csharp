using System;
class Program{
    public static void Main(){
        int ceca = 0;
        for (int i = 0; i < 30; i++){
            ceca*=i;
        }
            Console.WriteLine(ceca);
        Console.WriteLine("How old are you? :)");
        int cecaev =int.Parse(Console.ReadLine());
        Console.WriteLine(cecaev);
    }
}