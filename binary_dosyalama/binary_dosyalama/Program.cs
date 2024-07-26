using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace binary_dosyalama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream f = new FileStream("akmyo.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            for (byte i = 0; i < 20; i++)
            {
                f.WriteByte(i);
            }
            f.Position = 0;
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(f.ReadByte());
            }

            //String[] isimler = new string[] { "ankara", "istanbul", "düzce", "sakarya" };
            //using (StreamWriter sw = new StreamWriter("D:at.txt"))
            //{
            //    foreach (var isim in isimler)
            //    {
            //        sw.WriteLine(isim);
            //    }
            //}


            Console.ReadKey();
        }
    }
}
