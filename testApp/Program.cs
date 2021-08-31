using System;

namespace testApp
{
    class Program
    {
        static void Main(string[] args)
        {
            denemeChuragai.Service1Client kk = new denemeChuragai.Service1Client();
            var bilgi =  kk.getFirmaInfoByVergiNo("0490062253");
            Console.WriteLine(bilgi);
        }
    }
}
