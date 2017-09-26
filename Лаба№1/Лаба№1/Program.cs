using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace тренировка
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("privet");
            Console.ReadLine();
            byte a = 1;//neyavnoe
            sbyte b = 2;//neyavnoe
            short c = 3;//neyavnoe
            ushort d = (ushort)c;//yavnoe
            int e = 5;//neyavnoe
            uint f = (uint)e;//yavnoe
            long h = 7;//neyavnoe
            ulong g = (ulong)h; //yavnoe
            char s = '9';
            float k = (float)a;//yavnoe
            double j = (double)b;//yavnoe
            bool hook = true;
            decimal q = 12;
            string str = "lol";
            object v = 13;
            dynamic o = 14;
            var kl = 35;//primer s neyavnoi tipizirovannoi peremennoi
            Console.WriteLine((kl + e));
            Console.ReadLine();
            object obj = c;     // упаковка
            short valUnboxed = (short)obj;// распаковка
            object obj1 = b;
            sbyte valUnboxed1 = (sbyte)obj1;
            object obj2 = a;
            byte valUnboxed2 = (byte)obj2;
            object obj3 = d;
            ushort valUnboxed3 = (ushort)obj3;
            object obj4 = e;
            int valUnboxed4 = (int)obj4;
            object obj5 = f;
            uint valUnboxed5 = (uint)obj5;
            object obj6 = h;
            long valUnboxed6 = (long)obj6;
            object obj7 = g;
            ulong valUnboxed7 = (ulong)obj7;
            object obj8 = s;
            char valUnboxed8 = (char)obj8;
            object obj9 = k;
            float valUnboxed9 = (float)obj9;
            object obj10 = j;
            double valUnboxed10 = (double)obj10;
            object obj11 = hook;
            bool valUnboxed11 = (bool)obj11;
            int x1 = 4;
            int? x2 = x1;
            Console.WriteLine(x2);
            Console.ReadLine();
            string str1 = "pip", str2 = "joj", str3 = "rer";
            string scepl = string.Concat(str1, str2, str3);
            Console.WriteLine("Sceplenie strok str1, str2 & str3.\nStr1=pip\nstr2=joj\nstr3=rer\nsceplenie = " + scepl);
            Console.ReadLine();
            str2 = string.Copy(str1);
            Console.WriteLine("Scopiroval iz str1 v str. Str2= " + str2);
            Console.ReadLine();
            string str4 = "OOP LOVE";
            int indexstart = 2;
            int length = 5;
            string substring = str4.Substring(indexstart, length);
            Console.WriteLine("Videlenie podstroki " + str4 + "\ns 3 elementa dlinnoi 5 simvolov\nresult= " + substring);
            Console.ReadLine();
            //razdelenie stroki na slova
            const string Text = "Привет, Ваня. Как дела?";
            string[] words = Text.Split(new[] { ' ', ',', ':', '?', '!', '.' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
            //vstavka podstroki v zadannuy poziciu
            Console.WriteLine("Изначальный вид:" + Text);
            String Text1 = Text.Insert(13, "Петя, ");
            Console.WriteLine("Измененный вид:" + Text1);
            //udalenie zadannoi podstroki
            Console.WriteLine("Udalenie 'Ваня' из строки 'Text1' " + Text1.Remove(8, 5));
            //pustaya and null-stroka
            String pust1 = String.Empty;
            String pust2 = null;
            Console.WriteLine(pust1 + pust2);
            bool ch = (pust1 == pust2);
            Console.WriteLine(ch);
            Console.WriteLine("Dlina pustoi stroki:" + pust1.Length);
            //pri opredelenii dlini null-stroki vidaet oshibku
            //stringbuilder
            StringBuilder strbuilder = new StringBuilder("Zdorova op", 25);
            Console.WriteLine("stroka strbuilder bez izmenenii: " + strbuilder);
            strbuilder.Remove(2, 2);
            Console.WriteLine("stroka strbuilder s udaleniem 2 pozicii 2 simvolov pozicii: " + strbuilder);
            strbuilder.Insert(0, "nachalo");
            Console.WriteLine("stroka strbuilder s dobavleniem v nachalo: " + strbuilder);
            strbuilder.Insert(15, "konec");
            Console.WriteLine("stroka strbuilder s dobavleniem v konec: " + strbuilder);
            //dvumernii massiv
            int[,] arr = { { 2, 5 }, { 3, 2 }, { 4, 1 }, { 9, 0 } };
            for (int i = 0; i < 4; i++)
            {
                for (int po = 0; po < 2; po++)
                {
                    Console.Write(arr[i, po] + " ");
                }
                Console.WriteLine();

            }
            //odnomernii massiv strok
            string[] stroka = { "popop", "kekek", "nenene" };
            for (int i = 0; i < 3; i++)
                Console.WriteLine(stroka[i]);
            Console.WriteLine("dlina massiva: " + stroka.Length);
            Console.ReadLine();
            Console.WriteLine("Ukagite kakoi element massiva zamenit (0-2): ");
            int jk = int.Parse(Console.ReadLine());
            stroka[jk].Remove(1);
            Console.WriteLine("Vvedite novoe znachenie elementa massiva: ");
            stroka[jk] = Console.ReadLine();
            for (int i = 0; i < 3; i++)
                Console.WriteLine(stroka[i]);
            Console.ReadLine();
            //stupenchatii massiv
            double[][] arr2 = new double[3][];
            arr2[0] = new double[2];
            arr2[1] = new double[3];
            arr2[2] = new double[4];

            for (int i = 0; i < 3; i++)
            {
                for (int ko = 0; ko < arr2[i].Length; ko++)
                {
                    arr2[i][ko] = double.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int ko = 0; ko < arr2[i].Length; ko++)
                {
                    Console.Write(arr2[i][ko] + " ");
                }
                Console.WriteLine();
            }
            var klj = new[] { 1, 2, 3 };
            var ss = "gleb";
            //kortegi

            (int pervii, string vtoroi, char tretii, string chetvertii, ulong pyatii) kortg1 = (1, "sas", 's', "kok", 5443);
            (int pervii, string vtoroi, char tretii, string chetvertii, ulong pyatii) kortg2 = (1, "sas", 's', "kok", 5443);
            Console.WriteLine(kortg1);
            Console.WriteLine(kortg1.pervii + kortg1.tretii + kortg1.chetvertii);
            //sravnenie
            Console.WriteLine(kortg1.Equals(kortg2));
            //function
            Tuple<int, int, int, string> locfun(int[] x, string l)
            {


                int min, max, summ = 0;
                string bukva;
                min = x[0];
                for (int i = 0; i < x.Length; i++)
                {
                    if (min > x[i])
                        min = x[i];
                }
                max = x[0];
                for (int i = 0; i < x.Length; i++)
                {
                    if (max < x[i])
                        max = x[i];
                }
                for (int i = 0; i < x.Length; i++)
                {
                    summ += x[i];
                }
                bukva = l.Remove(2);
                (int min, int max, int summ, string bukva) kot;
                return new Tuple<int, int, int, string>(min, max, summ, bukva);
            }
            int[] arr5 = { 1, 2, 3, 4, 5 };
            string jkl = "sdkjf";
            locfun(arr5, jkl);
        }
    }
}
