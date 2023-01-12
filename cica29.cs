
using System;
class Program{
public static void Main(){
    
    
    string inp;
bool  exit = false;

do{
    Console.WriteLine("adjon meg egy műveletett (add +) (sub -) (mul *) (div /)");
   inp =  Console.ReadLine();
   switch(inp){
        
       
       case "add":
       Add();break;
       case "sub":
       Sub();break;
       case "mul":
       Mul();break;
       case "div":
       Div();break;
       case "exit":
        exit = true; break;
        default:
        Console.WriteLine("nincs ilyen művelet: Never gonna give you up Never gonna let you down Never gonna run arund and desert you Never gonna make you cry Never gonna say goodbye");break;
   }
}while(!exit);
   
   }
   public static void Add(){
       Console.WriteLine("adjon meg két számot");
       string[] inp = Console.ReadLine().Split(" ");
       Console.WriteLine(int.Parse(inp[0]) + int.Parse(inp[1]));
       }
 public static void Sub(){
       Console.WriteLine("adjon meg két számot");
       string[] inp = Console.ReadLine().Split(" ");
       Console.WriteLine(int.Parse(inp[0]) - int.Parse(inp[1]));
       }
        public static void Mul(){
       Console.WriteLine("adjon meg két számot");
       string[] inp = Console.ReadLine().Split(" ");
       Console.WriteLine(int.Parse(inp[0]) * int.Parse(inp[1]));
        }
         public static void Div(){
       Console.WriteLine("adjon meg két számot");
       string[] inp = Console.ReadLine().Split(" ");
       Console.WriteLine(int.Parse(inp[0]) / int.Parse(inp[1]));
         }
} 
