using System;
using System.Collections.Generic;
class Program{
    static int automataoszeg = 300000000, kartapenz = 1000000;
    static int pin = 3456;
    static int vasarlasilimit = 5000;
    static Allapot states = Allapot.kartabedugasa;
    public enum Allapot{
        kartabedugasa,
        szerencsejatek,
        menu,
        admin,
        pincsere,
        egyenleglekerdezes,
        csekbefizetes,
        vasarlasilimitbeallitas,
        biztositas,
        pinbeker,
        penzberak,
        penzfelvet,
        telefonfeltolt,
        kilepes
    }
    public static void szerencsejatek(){
        Console.Clear();
        Console.WriteLine("adja meg a tétet");
        int tet = int.Parse(Console.ReadLine());
        if (tet > kartapenz){
            Console.WriteLine("nincs elég fedezete");
        }else{
            kartapenz -= tet;
            int szam = 0;
            Random rnd = new Random();
            int gondolt = 0;
            if(tet < 5000){
                Console.WriteLine("adjon me ey számot 1-10 ig");
                szam = int.Parse(Console.ReadLine());
                gondolt = rnd.Next(10);
            }else if (tet<20000)
            {
                Console.WriteLine("adjon me ey számot 1-20 ig");
                szam = int.Parse(Console.ReadLine());
                gondolt = rnd.Next(20);
            }else
            {
                Console.WriteLine("adjon me ey számot 1-50 ig");
                szam = int.Parse(Console.ReadLine());  
                gondolt = rnd.Next(50);
            }
            
            if (tet == gondolt){
                Console.WriteLine("gratulálunk eltaláltad");
                Console.WriteLine("nyereményed: " + tet *3 + "Ft");
                kartapenz += tet * 3;
            }else{
                Console.WriteLine("nem nyert");
            }
    }
        System.Threading.Thread.Sleep(4000);
        states = Allapot.menu;
    }
    public static void penzberak(){
        Console.Clear();
        Console.WriteLine("adja meg menji bankót akar berakni:");
         int beeeerak = 0;
        Console.Write("500:"); beeeerak += int.Parse(Console.ReadLine()) *500;
        Console.Write("1000:"); beeeerak += int.Parse(Console.ReadLine()) *1000;
        Console.Write("2000:"); beeeerak += int.Parse(Console.ReadLine()) *2000;
        Console.Write("5000:"); beeeerak += int.Parse(Console.ReadLine()) *5000;
        Console.Write("10000:"); beeeerak += int.Parse(Console.ReadLine()) *10000;
        Console.Write("20000:"); beeeerak += int.Parse(Console.ReadLine()) *20000;
        kartapenz += beeeerak;
        Console.WriteLine(kartapenz);
        System.Threading.Thread.Sleep(4000);
        states = Allapot.kilepes;
    }
    public static void pinbeker(){
        Console.Clear();
        Console.Write("adja meg a pin kódját:");
        int pink = int.Parse(Console.ReadLine());
        if(pink == pin){
            states = Allapot.menu;
        }
    }
    public static void beztositas(){
        Console.Clear();
        Console.WriteLine("vÁlassza ki melyik biztosÍtást szeretné:");
        Console.WriteLine("1.vagyon biztosÍtás");
        Console.WriteLine("2.élet biztosÍtás");
        Console.WriteLine("3.gépjármű biztosÍtás");
        Console.WriteLine("4.utas biztosÍtás");
        int bizt = int.Parse(Console.ReadLine());
switch(bizt){
    case 1: Console.WriteLine("-5000FT"); break;
    case 2:Console.WriteLine("-1000000FT"); break;
    case 3:Console.WriteLine("-50000"); break;
    case 4:Console.WriteLine("-10000"); break;
    default:Console.WriteLine("nincs ilyen lehetőség"); break;
}

        System.Threading.Thread.Sleep(4000);
        states = Allapot.kilepes;
    }
    public static void vasarlasilimit_beall(){
        Console.Clear();
        Console.WriteLine("adja meg az új vásárlási limitet");
        vasarlasilimit = int.Parse(Console.ReadLine());
        System.Threading.Thread.Sleep(4000);
        states = Allapot.kilepes;
    }
    public static void csekbefizetes(){

        Console.Clear();
        Console.WriteLine("adja meg a csekk sor számát");
        int csekk = int.Parse(Console.ReadLine());
        Console.WriteLine("adja meg az összegett");
         int összeg = int.Parse(Console.ReadLine());
         kartapenz -= összeg;
         Console.WriteLine("A csekk befizetésre került");
        System.Threading.Thread.Sleep(4000);
        states = Allapot.menu;
    }
    public static void pincsere(){
        Console.Clear();
        Console.WriteLine("Adja meg a régi pinkodját");
        int pinkód = int.Parse(Console.ReadLine());
        if (pin == pinkód)
        {
            Console.WriteLine("adja meg az új pinkódját");
            int pinseged = int.Parse(Console.ReadLine());
            Console.WriteLine("adja meg még egyszer az új pinkódját");
            pinkód = int.Parse(Console.ReadLine());
            if (pinkód == pinseged){
                Console.WriteLine("pinkódja meg változott");
                pin = pinkód;
            }else{
                Console.WriteLine("nem edjezik a két pinkód");
            }
        }

        System.Threading.Thread.Sleep(4000);
        states = Allapot.kilepes;
    }
    public static void egyenlegbekerdezes(){
        Console.Clear();
        Console.WriteLine("egyenleg: " + kartapenz);
        System.Threading.Thread.Sleep(4000);
        states = Allapot.menu;
    }
    public static void Kartabedugasa(){
        Console.Clear();
        Console.WriteLine("kérem dugja be a kártyát");
        string karta = "";
        do
        {
            karta = Console.ReadLine();
        } while (karta != "1" && karta != "creper tech 404");
        states = Allapot.pinbeker;
        if(karta == "creper tech 404"){
            states = Allapot.admin;
        }
    }
    public static void Menu(){
        Console.Clear();
        Console.WriteLine("1--pénz felveastell");
        Console.WriteLine("2--telefon feltoltés");
        Console.WriteLine("3--kilepess");
        Console.WriteLine("4--pincsere");
        Console.WriteLine("5--egyenleglekerdezes");
        Console.WriteLine("6--csekbefizetes");
        Console.WriteLine("7--beztositas");
        Console.WriteLine("8--penzberak");
        Console.WriteLine("9--vasarlasilimit");
        Console.WriteLine("13--szerencsejatek");
        
        int bugos = int.Parse(Console.ReadLine());

        switch (bugos)
        {
            case 1: states = Allapot.penzfelvet;break;
            case 3: states = Allapot.kilepes;break;
            case 2: states = Allapot.telefonfeltolt; break;
            case 4: states = Allapot.pincsere; break;
            case 5: states = Allapot.egyenleglekerdezes; break;
            case 6: states = Allapot.csekbefizetes; break;
            case 7: states = Allapot.biztositas; break;
            case 8: states = Allapot.penzberak; break;
            case 9: states = Allapot.vasarlasilimitbeallitas; break;
            case 13: states = Allapot.szerencsejatek; break;

            
        }
    }
    public static void telefonfeltoltes(){
        Console.Clear();
        Console.WriteLine("adja meg a telefon számát");
        string telszam = Console.ReadLine();
        Console.Write("ekkora öszegel akaja föltölteni");
        int teloszeg = int.Parse(Console.ReadLine());
        kartapenz -= teloszeg;
        Console.WriteLine("aa kártyán maradt:" + kartapenz);
        System.Threading.Thread.Sleep(4000);
        states = Allapot.kilepes;
    }
    public static void Penzfelvet(){
        Console.Clear();
        Console.Write("adjon meg egy üszeget:");
        int penzszeszeg = int.Parse (Console.ReadLine());
        if(kartapenz <penzszeszeg){
            Console.WriteLine("nincs eleg felfedezete");
        }else{
            kartapenz -= penzszeszeg;
            Console.WriteLine("a káááártyáán leevő peinz:" + kartapenz);
        }
        System.Threading.Thread.Sleep(4000);
        states = Allapot.kilepes;
    }
    public static void Admin(){
        Console.Clear();
        Console.WriteLine("adja meg hányás darabot rakot bölélük");
        int beeeerak = 0;
        Console.Write("500:"); beeeerak += int.Parse(Console.ReadLine()) *500;
        Console.Write("1000:"); beeeerak += int.Parse(Console.ReadLine()) *1000;
        Console.Write("2000:"); beeeerak += int.Parse(Console.ReadLine()) *2000;
        Console.Write("5000:"); beeeerak += int.Parse(Console.ReadLine()) *5000;
        Console.Write("10000:"); beeeerak += int.Parse(Console.ReadLine()) *10000;
        Console.Write("20000:"); beeeerak += int.Parse(Console.ReadLine()) *20000;
        automataoszeg += beeeerak;
        Console.WriteLine("az autó matatááááááában" + automataoszeg + " foorint talahfató");
        System.Threading.Thread.Sleep(4000);
        states = Allapot.kartabedugasa;
    }
    public static void Kilepes(){
        Console.Clear();
        Console.WriteLine("kérem lopja ki a kártyáját");
        System.Threading.Thread.Sleep(4000);
        states = Allapot.kartabedugasa;
        
    }
    static void Main(){
        do
        {
            switch (states)
            {
                case Allapot.kartabedugasa: Kartabedugasa();break;
                case Allapot.menu:  Menu(); break;
                case Allapot.admin: Admin(); break;
                case Allapot.penzfelvet: Penzfelvet();break;
                case Allapot.kilepes: Kilepes(); break;   
                case Allapot.telefonfeltolt: telefonfeltoltes(); break;       
                case Allapot.szerencsejatek: szerencsejatek(); break;
                case Allapot.pincsere:  pincsere(); break;
                case Allapot.egyenleglekerdezes: egyenlegbekerdezes(); break;
                case Allapot.csekbefizetes: csekbefizetes(); break;
                case Allapot.vasarlasilimitbeallitas: vasarlasilimit_beall(); break;
                case Allapot.biztositas: beztositas(); break;
                case Allapot.pinbeker: pinbeker(); break;
                case Allapot.penzberak:penzberak(); break;
            }
        } while (1 != 2);
    }
}