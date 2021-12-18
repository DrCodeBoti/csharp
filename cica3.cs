using System;
class Program{
    public static void Main(){
        int ceca = 0;
        for (int i = 0; i < 30; i++){
            ceca*=i;
        }
       //     Console.WriteLine(ceca);
        Console.WriteLine("How old are you? :)");
        int cecaeve = 0;
        do{
        cecaeve =int.Parse(Console.ReadLine());
       //Console.WriteLine(cecaeve);
        }while(cecaeve > 11);
    
 
        Console.WriteLine("Wats your name? :)");
       string cecaneve = Console.ReadLine();
        //Console.WriteLine(cecaneve);
        Console.WriteLine("Hello " + cecaneve + "(" + cecaeve + ")");
    }
}