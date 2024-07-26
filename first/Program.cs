using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a = 19;
            //if (a < 20)
            //{
            //    Console.WriteLine("Girilen sayi 20'den Küçük");
            //    Console.WriteLine("a değeri : " + a);
            //}
            //else
            //{
            //    Console.WriteLine("Girilen Sayı 20'den Büyük");
            //    Console.WriteLine("a değeri : " + a);
            //}
            //Console.WriteLine("----------------------");
            //Console.WriteLine("a değeri : {0}", a); //1. Yazım şekli
            //Console.WriteLine("a değeri : " + a); //2. Yazım şekli


            //////////////////////////////////////////////////////////////////

            //Sistemden girilen notun karşılığını ekrana yazan uygulama
            //char not = 'A';
            //switch (not)
            //{
            //    case 'A':
            //        {
            //            Console.WriteLine("Mükemmel");
            //            break;
            //        }
            //    case 'B':
            //        {
            //            Console.WriteLine("Güzel");
            //            break;
            //        }
            //    case 'C':
            //        {
            //            Console.WriteLine("İyi");
            //            break;
            //        }
            //    default:
            //        {
            //            Console.WriteLine("Yanlış");
            //            break;
            //        }
            //}



            //Kullanıcıdan alınan ntun karşılğını veren program
            //Console.WriteLine("Harf Notunuzu Giriniz..");
            //string not = Console.ReadLine();

            //switch (not)
            //{
            //    case "A":
            //        {
            //            Console.WriteLine("Mükemmel");
            //            break;
            //        }
            //    case "B":
            //        {
            //            Console.WriteLine("Güzel");
            //            break;
            //        }
            //    case "C":
            //        {
            //            Console.WriteLine("İyi");
            //            break;
            //        }
            //    default:
            //        {
            //            Console.WriteLine("Yanlış Veri");
            //            break;
            //        }
            //}

            //////////////////////////////////////////////////////////////

            //Girilen sayı A ise true değise false yazan uygulama
            //Console.WriteLine("Harf Notunuzu Giriniz..");
            //string not = Console.ReadLine();

            //bool sonuc = not == "A" ? true : false;// ? == if
            //Console.WriteLine(sonuc);


            //Saçma ve gereksiz kod dizisi
            //int i = 0;
            //do
            //{
            //    i++;
            //    if (i <= 3)
            //    {
            //        Console.WriteLine(i + ".A");
            //        if (i == 3)
            //            continue;
            //    }
            //    Console.WriteLine((i + 1) + ".B");
            //} while (i < 10);


            //Girilen satır ve sütun sayısına göre ekrana yıldız yazan uygulama
            int r = 0, c = 0;

            Console.Write("Satır sayısını giriniz: ");
            r = Convert.ToInt16(Console.ReadLine());

            Console.Write("Sütun sayısını giriniz: ");
            c = Convert.ToInt16(Console.ReadLine());

            //int i = 0, j = 0;
            for (int i = 0; i < r; i++)
            {
                Console.Write((i + 1) + ". ");
                for (int j = 0; j < c; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }




            Console.ReadLine();
        }
    }
}
