using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCKimlikDogrulama
{
    class Program
    {
        static void Main(string[] args)
        {
            //11 haneli 
            //hepsi rakam
            //son basamak çift
            //ilk 10 basamağın toplamının birler basamağı, 11.basamağa eşit.
            //tüm bu maddeler geçerliyse kimlik doğrulandı.

            Console.Write("Kimlik numaranız:");
            KimlikKontrol(Console.ReadLine());


            Console.ReadLine();


        }

        static void KimlikKontrol(string tc)
        {
            if (tc.Length == 11)
            {
                bool hepsiHarf = true;
                for (int i = 0; i < tc.Length; i++)
                {
                    if (!char.IsNumber(tc[i]))
                    {
                        hepsiHarf = false;
                        break;//herhangi bir karakter numara değilse değeri belirle ve döngüyü sonlandır.
                    }

                }

                if (hepsiHarf)
                {
                    int sonBasamak = int.Parse(tc[10].ToString());
                    //convert.toint32(tc[10])-->facia çünkü ascii kodunu alıyor.
                    if (sonBasamak % 2 == 0)
                    {
                        int toplam = 0;
                        for (int i = 0; i < tc.Length - 1; i++)
                        {
                            toplam += int.Parse(tc[i].ToString());

                        }
                        if (toplam % 10 == sonBasamak)
                        {
                            Console.WriteLine("Kimlik Numarası geçerlidir.");
                        }
                        else
                            Console.WriteLine("Geçersiz kimlik numarası.");
                    }
                    else
                        Console.WriteLine("Son basamak çift sayı olmalıdır.");
                }
                else
                    Console.WriteLine("Kimlik no sadece rakamlardan oluşmalıdır!...");
            }
            else
            {
                Console.WriteLine("Kimlik numarası 11 haneli olmalıdır!...");
            }
        }


    }

}




