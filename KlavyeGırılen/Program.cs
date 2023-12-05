using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlavyeGırılen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KlavyeGırılenSayi klavye = new KlavyeGırılenSayi();
            klavye.toplaMetodu();
            








        }
    }
        
}
public class KlavyeGırılenSayi
{
    public void toplaMetodu()
    {

        int sayi, toplam = 0;
        while (true)
        {
            Console.Write("Sayı Gir : ");
            sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi == 0)
            {
                break;
            }
            toplam += sayi;
        }
        Console.WriteLine("Girdiğiniz Sayıların Toplamı: " + toplam);
        Console.ReadKey();
    }
}   



