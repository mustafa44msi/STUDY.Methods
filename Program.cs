using System;

namespace Methods
{
    internal class Program
    {
        static public string Ogrenci()
        {
            Console.Write("Adınızı girin: ");
            string adi = Console.ReadLine();
            Console.Write("Soyadınızı girin: ");
            string soyadi = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Öğrencinin adı: "+adi);
            Console.WriteLine("Öğrencinin soyadı: "+soyadi);
            return "" ;
            
        }
        public static int Not() 
        {
            Console.Write("ilk notunuzu girin: ");
            int not1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("ikinci notunuzu girin: ");
            int not2 = Convert.ToInt32(Console.ReadLine());
            int ort = (not1 + not2) / 2;
            Console.Write("Öğrencinin not ortalaması: ");
            return ort ;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Ogrenci());
            Console.WriteLine(Not());

            Console.WriteLine("uygulamayı kapatmak için 'Enter' tuşuna basınız");
            Console.ReadLine();
        }

    }
}
