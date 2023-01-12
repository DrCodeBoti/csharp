using System.IO;
using System;

class Program{

  public static void Main() {
        StreamReader olvas = new StreamReader("cica28.txt");
        List<int> adatok = new List<int>();
        while(!olvas.EndOfStream){
            adatok.Add(int.Parse(olvas.ReadLine()));
        }
        
        Console.WriteLine(nagyobb(adatok));
        List<int> adatok3 = new List<int>();
        int ossz = 0;
        for (int i = 2; i < adatok.Count(); i++)
        {ossz = adatok[i]+adatok [i-1] + adatok[i-2];
            adatok3.Add(ossz);
        }
        Console.WriteLine(nagyobb(adatok3));
  }
  public static int nagyobb(List<int> adatok){
      int nagyobb = 0;
        for (int i = 1; i < adatok.Count(); i++)
        {
            if (adatok[i] > adatok[i-1])
            {
                nagyobb++;   
            }
        }
        return nagyobb;
  }
}