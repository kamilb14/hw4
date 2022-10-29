using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace hw4
{
    internal class Program
    {
        static void Task1()
        {
            Console.WriteLine("Квадратное уравнение");
            Console.WriteLine("Задание 1.Квадратное уравнение");
            Console.WriteLine("Введите коэффициент a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите коэффициент b ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите коэффициент c");
            int c = int.Parse(Console.ReadLine());
            double d = b * b - 4 * a * c;
            if (d < 0)
            {
                Console.WriteLine("корней нет");
            }
            else if (d > 0)
            {
                double x1 = (-b + Math.Sqrt(d)) / 2 * a;
                double x2 = (-b + Math.Sqrt(d)) / 2 * a;
                Console.WriteLine("корни квадратного уравнения: {0} , {1}", x1, x2);
            }
            else if (d == 0)
            {
                double x3 = -b / (2 * a);
                Console.WriteLine("единственный корень: {0}", x3);
            }
        }

        static void Task2()
        {
            Random rnd = new Random();
            int[] a = new int[20];
            a[0] = rnd.Next(0, 101);
            for (int i = 1; i < 20;)
            {
                int num = rnd.Next(0, 101);
                int j;
                for (j = 0; j < i; j++)
                {
                    if (num == a[j])
                        break;
                }
                if (j == i)
                {
                    a[i] = num;
                    i++;
                }
            }

            Console.WriteLine(String.Join(" ", a));
            Console.WriteLine("введите 2 числа которые хотите поменять");
            int ind1 = Array.IndexOf(a, int.Parse(Console.ReadLine()));
            int ind2 = Array.IndexOf(a, int.Parse(Console.ReadLine()));
            (a[ind1], a[ind2]) = (a[ind2], a[ind1]);
            Console.WriteLine(string.Join(" ", a));


            static int[] Task3(int[] mas)
            {
                int temp;
                for (int i = 0; i < mas.Length; i++)
                {
                    for (int j = i + 1; j < mas.Length; j++)
                    {
                        if (mas[i] > mas[j])
                        {
                            temp = mas[i];
                            mas[i] = mas[j];
                            mas[j] = temp;
                        }
                    }
                }
                return mas;
            }

            static int Tasr4(ref uint prois, out double srarifm, params uint[] mass)
            {
                double sum = 0;
                for (int i = 0; i < mass.Length; i++)
                {
                    sum += mass[i];
                    prois *= mass[i];
                }
                srarifm = Math.Round(sum / mass.Length, 2);
                Console.WriteLine($"Среднее значение массива: {srarifm}");
                Console.WriteLine($"Произведение массива: {prois}");
                Console.WriteLine($"Сумма массива");
                return (int)sum;
            }

            static void Task5();
            Console.WriteLine("Task5. Красная консоль");
            try
            {
                while (true)
                {
                    string number = Console.ReadLine();
                    if (number == "exit" || number == "закрыть")
                    {
                        Environment.Exit(0);
                    }
                    if (int.Parse(number) < 0 || int.Parse(number) > 9)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ошибка!!!");
                        System.Threading.Thread.Sleep(3000);
                        Console.ResetColor();                      
                        Console.WriteLine(" Введите числа");
                        
                        int number1 = Convert.ToInt32(number);
                        switch (number1)
                        {
                            case 0:
                                Console.WriteLine("###" + "\n" + "# #" + "\n" + "# #" + "\n" + "# #" + "\n" + "###");
                                break;
                            case 1:
                                Console.WriteLine(" # " + "\n" + "## " + "\n" + " # " + "\n" + " # " + "\n" + "###");
                                break;
                            case 2:
                                Console.WriteLine(" # " + "\n" + "# #" + "\n" + "  #" + "\n" + " # " + "\n" + "###");
                                break;
                            case 3:
                                Console.WriteLine("## " + "\n" + "  #" + "\n" + " # " + "\n" + "  #" + "\n" + "## ");
                                break;
                            case 4:
                                Console.WriteLine("# #" + "\n" + "# #" + "\n" + "###" + "\n" + "  #" + "\n" + "###");
                                break;
                            case 5:
                                Console.WriteLine("###" + "\n" + "#  " + "\n" + "###" + "\n" + "  #" + "\n" + "## ");
                                break;
                            case 6:
                                Console.WriteLine(" ##" + "\n" + "#  " + "\n" + "###" + "\n" + "# #" + "\n" + "###");
                                break;
                            case 7:
                                Console.WriteLine("###" + "\n" + "  #" + "\n" + "  #" + "\n" + " # " + "\n" + " # ");
                                break;
                            case 8:
                                Console.WriteLine("###" + "\n" + "# #" + "\n" + " # " + "\n" + "# #" + "\n" + "###");
                                break;
                            case 9:
                                Console.WriteLine("###" + "\n" + "# #" + "\n" + "###" + "\n" + "  #" + "\n" + "###");
                                break;
                        }

                    }
                }
            }
            catch
            {

                Console.WriteLine("Вы ввели не число");
            }
        }
       
    }   
}

    