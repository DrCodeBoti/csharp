using System;
class Kreta{
    public static void Main(){
        bool exit = false;
        string inp = "";
        string[] Aoszt = {"Pisti(1)", "Marci(2)","Józsi(3)"
        };
        string[] Boszt = {"Ábel(1)", "Géza(2)","Boti(3)"};
        string[] Coszt = {"Szilveszter(1)", "Jani(2)","Balázs(3)"};
        do{
            Console.WriteLine("A osztály(1)\tB osztály(2)\tC osztály(3)");
            inp = Console.ReadLine();
            if (inp == "exit")
            {
                exit = true;
                
            }else if(inp == "1")
            {Console.WriteLine(string.Join("   ", Aoszt));
                
            }else if(inp == "2")
            {Console.WriteLine(string.Join("   ", Boszt));

            }else if(inp == "3")
            {Console.WriteLine(string.Join("   ", Coszt));
                
            }
        }while(!exit);
    }public static void Kölök(){

        string[] démonidézőmódszerek = {"matek", "töri","biologia","köri","sus","rajz","ének","adó","magyar"};
                                                                                                                                                                
        Console.WriteLine("tanuló neve");
        for (int i = 0; i < démonidézőmódszerek.length; i++)
        {Console.Write("");
            
        }    }
}