using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassWork_09._10._21
{
    class Program
    {
        static void Compare(byte[] clanOne, byte[] clanTwo)
        {
            if (clanOne.Count(n => n == 5) == clanTwo.Count(n => n == 5))
            {
                Console.WriteLine("Drinks All Around! Free Beers on Bjrong!");
            }
            else
            {
                Console.WriteLine("Ой, Бьорг - пончик! Ни для кого пива!");
            }
        }
        static void Main(string[] args)
        {
            Random r = new Random();
            short maxValue = 15;
            int bbbCount = r.Next(1, maxValue), ssCount = r.Next(1, maxValue);
            byte[] bbb = new byte[bbbCount], ss = new byte[ssCount];
            for (int i = 0; i < bbb.Length; i++)
            {
                bbb[i] = (byte)r.Next(10);
            }
            for (int i = 0; i < ss.Length; i++)
            {
                ss[i] = (byte)r.Next(10);
            }
            Compare(ss, bbb);

            byte n = 1;
            string path = Path.Combine(Directory.GetCurrentDirectory(), "pics");
            List<string> pics = new List<string>();
            IEnumerable<string> pictures = Directory.EnumerateFiles(path);
            foreach (var picture in pictures)
            {
                pics.Add(picture);
                Console.WriteLine("{0}: {1}", n, picture);
                n++;
            }
            for (int i = pics.Count() - 1; i >= 1; i--)
            {
                int j = r.Next(i + 1);
                string temp = pics[j];
                pics[j] = pics[i];
                pics[i] = temp;
            }
            Console.WriteLine();
            n = 1;
            foreach (var pic in pics)
            {
                Console.WriteLine("{0}: {1}", n, pic);
                n++;
            }
            
            Console.ReadKey();
        }
    }
}
