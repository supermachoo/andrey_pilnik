using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Создать класс типа - Множество. Методы:
 * добавляют элемент к множеству, удаляют элемент,
 * выводят текущее количество элементов множества. Создать массив объектов.
 * Вывести:  множества  с наименьшей/наибольшей суммой элементов;
 *
 */
namespace Лаба_2
{
    public class Mnojestvo
    {


        public static int[] number=new int[5];
        public int sum;
        public int chislo;
        public Mnojestvo()
        {

        }
        public void AddChislo()
        {
            /*Console.WriteLine("Введите кол-во элементов:");
            int kol = int.Parse(Console.ReadLine());*/
            
            for (int i = 0; i < number.Length; i++)
            {
                number[i] = int.Parse(Console.ReadLine());
            }
        }

        public void Vivod()
        {
            foreach (int chis in number)
                Console.Write("  "+chis+"  ");
            Console.WriteLine();
            Console.WriteLine("Кол-во элементов в множестве: "+number.Length);
        }

        public void del()
        {
            Array.Clear(number,0,5);
        }

        public int Sum()
        {
            
            return  sum = number.Sum(); 

             
        }
        class Program
        {
            static void Main(string[] args)
            {

                Mnojestvo m1 = new Mnojestvo();
                Mnojestvo m2 = new Mnojestvo();
                Mnojestvo m3 = new Mnojestvo();
                int choose;
               

                {
                    do
                    {
                        
                        Console.WriteLine("1-Ввод в первое множество\n2-Ввод во второе множество\n3-Ввод в третье множество.");
                        choose = int.Parse(Console.ReadLine());
                        if (choose != 4)
                        {
                            switch (choose)
                            {
                                case 1:
                                    {
                                        Console.WriteLine("Ввод чисел в первое множество:");
                                        m1.AddChislo();
                                        m1.Vivod();
                                        break;
                                    }
                                case 2:
                                    {
                                        Console.WriteLine("Ввод чисел во второе множество:");
                                        m2.AddChislo();
                                        m2.Vivod();
                                        break;
                                    }
                                case 3:
                                    {
                                        Console.WriteLine("Ввод чисел в третье множество:");
                                        m3.AddChislo();
                                        m3.Vivod();
                                        break;
                                    }
                                
                                case 4:
                                    {
                                        break;
                                    }


                            }
                        }
                        Console.WriteLine("1-Ввод в первое множество\n2-Ввод во второе множество\n3-Ввод в третье множество\n4-Выход.");
                    } while (choose != 4);
                }
                /* Console.WriteLine("Выберете множество: первое(клавиша 1)\t,второе(клавиша 2)\tили третье(клавиша 3)\t.");
                 int a = int.Parse(Console.ReadLine());
                 if (a==1)
                 {
                     Console.WriteLine("Ввод чисел в первое множество:");
                     m1.AddChislo();
                 }
                 if(a==2)
                 {
                     Console.WriteLine("Ввод чисел во второе множество:");
                     m2.AddChislo();
                 }
                 if(a==3)
                 {
                     Console.WriteLine("Ввод чисел в третье множество:");
                     m3.AddChislo();
                 }*/
                
                
               
                
                
                Console.ReadLine();

                Mnojestvo[] mass = new Mnojestvo[3];
                for (int i=0;i<3;i++)
                {
                    mass[i] = new Mnojestvo();
                }
                int[] summ = new int[3];
                for (int i = 0; i < 3; i++)
                {
                    
                    mass[i].AddChislo();
                    mass[i].Vivod();
                    summ[i]= mass[i].Sum();
                    Console.WriteLine(summ[i]);

                }
                int max = summ[0];
                int min = summ[0];
                for (int i=0;i<3;i++)
                {
                    if(max<summ[i])
                    {
                        max = summ[i];
                    }
                    
                }
                for (int i = 0; i < 3; i++)
                {
                    
                    if (min > summ[i])
                    {
                        min = summ[i];
                    }
                }
                Console.WriteLine("max=" + max+"\tmin="+min);
            }
        }

        /*protected int size;
        protected int index;
        private Chislo[] chisloArr;
        private int pos = -1;

        public const string b = "prosto stroka";
        public Mnojestvo()
        {
            chisloArr=new Chislo[0]; 
        }
        public void AddChislo(int ch)
        {
            Array.Resize(ref chisloArr, chisloArr.Length + 1);
            chisloArr[chisloArr.Length - 1] = new Chislo(ch);
        }
        public Chislo this[int index]
        {
            get { return chisloArr[index]; }
        }

        public int count
        {
            get { return chisloArr.Length; }
        }

    }

    public class Chislo
    {
        private int _cifra;
        public Chislo(int cifra)
        {
            this._cifra = cifra;
        }
        public int Cifra
        {
            get { return this._cifra; }
        }
    }
    */


        
    }
}
