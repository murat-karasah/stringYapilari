using System;

namespace stringYapilari
{
    class Program
    {
        static void Main(string[] args)
        {
            //string cumle =  "        Merhaba  dünya  ";

            ////REPLACE
            //string yenicumle = cumle.Replace(cumle,"nasılsın");

            ////Remove
            //string yenicumle = cumle.Remove(0, 3);

            ////Substring
            //string yenicumle = cumle.Substring(2,3);

            ////trim-trimend-trimstart
            ////Trim sağ ve soldaki boşlukları siler
            //string yenicumle = cumle.Trim();
            ////trimEnd bitiş boşlukları
            ////trimstart baş boşluklar
            //string yenicumle = cumle.TrimEnd();

            //// ToLower - To Upper
            //string yenicumle = cumle.ToLower();
            //string yenicumle = cumle.ToUpper();

            ////Lenght
            //int yenicumle = Convert.ToInt32(cumle.Length); 
            //Console.WriteLine(yenicumle);

            //Split
            string cumle = "çorba,pilav,nout";
            for (int i = 0; i < cumle.Split(',').Length; i++)
            {
                Console.WriteLine( cumle.Split(',')[i]);
            }





        }
    }
}
