using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    struct itoka{
    public string nev;
    public int ar;
    }
    static void fileba(List<itoka> itokak){
        StreamWriter ir = new StreamWriter("termekek.txt");

        for(int i = 0; i < itokak.Count(); i++){
            ir.WriteLine(itokak[i].nev + "\t" + itokak[i].ar);
        }

        ir.Close();
    }
    public static void Main(){
        List<itoka> itokak = new List<itoka>();
        itoka egyitoka = new itoka();

        bool newitokak = true;
        int ciklus = 0;

        StreamReader olvas = new StreamReader("termekek.txt");
        string[] sor = new string[2];
        while(! olvas.EndOfStream){
            sor = olvas.ReadLine().Split("\t");
            egyitoka.nev = sor[0];
            egyitoka.ar = int.Parse(sor[1]);
            itokak.Add(egyitoka);
        }
        olvas.Close();

        Console.WriteLine(itokak.Count() + "db termek van");

        do{
            if(ciklus > 0){
                Console.Write("adja meg az ital nevét ");
                egyitoka.nev = Console.ReadLine();
                Console.Write("adja meg az ital árát ");
                egyitoka.ar = int.Parse(Console.ReadLine());
                itokak.Add(egyitoka);
            }

            Console.WriteLine("Szeretne felveni új italt?");
            if(Console.ReadLine() == "nem" ){
                newitokak = false;
            }
            ciklus ++;
        }while(newitokak);

       fileba(itokak);

    }
}