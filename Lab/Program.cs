using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            ////TASK 1

            //// А

            //Console.WriteLine("Введите true/false :");
            //bool A_bool = Convert.ToBoolean(Console.ReadLine());
            //Console.WriteLine("A_bool = " + A_bool + "\n");

            //Console.WriteLine("Введите число от 0 до 255 :");
            //byte B_byte = Convert.ToByte(Console.ReadLine());
            //Console.WriteLine("B_byte = " + B_byte + "\n");

            //Console.WriteLine("Введите число от -128 до 127 :");
            //sbyte C_sbyte = Convert.ToSByte(Console.ReadLine());
            //Console.WriteLine("C_sbyte = " + C_sbyte + "\n");

            //Console.WriteLine("Введите число от от -32768 до 32767 :");
            //short D_short = Convert.ToInt16(Console.ReadLine());
            //Console.WriteLine("D_short = " + D_short + "\n");

            //Console.WriteLine("Введите число от 0 до 65535 :");
            //ushort E_ushort = Convert.ToUInt16(Console.ReadLine());
            //Console.WriteLine("E_ushort = " + E_ushort + "\n");

            //Console.WriteLine("Введите число от -2147483648 до 2147483647 :");
            //int F_int = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("F_int = " + F_int + "\n");

            //Console.WriteLine("Введите число от 0 до 4294967295 :");
            //uint G_uint = Convert.ToUInt32(Console.ReadLine());
            //Console.WriteLine("G_uint = " + G_uint + "\n");

            //Console.WriteLine("Введите число от от –9 223 372 036 854 775 808 до 9 223 372 036 854 775 807 :");
            //long H_long = Convert.ToInt64(Console.ReadLine());
            //Console.WriteLine("H_long = " + H_long + "\n");

            //Console.WriteLine("Введите число от 0 до 18 446 744 073 709 551 615  :");
            //ulong I_ulong = Convert.ToUInt64(Console.ReadLine());
            //Console.WriteLine("I_ulong = " + I_ulong + "\n");

            //Console.WriteLine("Введите число с плавающей точкой от -3.4*1038 до 3.4*1038 : ");
            //float J_float = Convert.ToSingle(Console.ReadLine());
            //Console.WriteLine("J_float = " + J_float + "\n");

            //Console.WriteLine("Введите число с плавающей точкой от ±5.0*10-324 до ±1.7*10308 :");
            //double K_double = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("K_double = " + K_double + "\n");

            //Console.WriteLine("Введите 1 символ : ");
            //char L_char = Convert.ToChar(Console.ReadLine());
            //Console.WriteLine("L_char = " + L_char + "\n");

            //Console.WriteLine("Введите строку : ");
            //string M_string = Console.ReadLine();
            //Console.WriteLine("M_string = " + M_string + "\n");

            //Console.WriteLine("Введите любой элемент для object :");
            //object N_object = Console.ReadLine();
            //Console.WriteLine("N_object = " + N_object + "\n");


            ////B

            ////Явное преобразование
            //int a = 33, b = 600; byte c = (byte)(a + b);
            //Console.WriteLine("int a = 4, b = 6;   byte c = (byte)(a + b) = " + c + "\n");

            //short d = -115; float e = (float)(d * 2);
            //Console.WriteLine("short d = -115;     float e = (float)(d * 2) = " + e + "\n");

            //char f = 'q'; a = (int)f;
            //Console.WriteLine("char f = 'q';       a = (int)f = " + a + "\n");

            //float g = 1.567F; double h = (double)g;
            //Console.WriteLine("float g = 1.567F;    double h = (double)g = " + h + "\n");

            //uint i = 22; g = (float)i;
            //Console.WriteLine("uint i = 22;        g = (float)i = " + g + "\n");

            ////Неявное преобразование 
            //byte aa = 4; ushort bb = aa;
            //Console.WriteLine("byte aa = 4;     ushort bb = aa = " + bb + "\n");

            //sbyte cc = 4; short dd = cc;
            //Console.WriteLine("sbyte cc = 4;   short dd = cc = " + dd + "\n");

            //char ee = 'w'; int ff = ee;
            //Console.WriteLine("char ee = 'w';    int ff = ee = " + ff + "\n");

            //float gg = 1.78F; h = gg;
            //Console.WriteLine("float gg = 1.78F;   h = gg = " + h + "\n");

            //d = -120; gg = d;
            //Console.WriteLine("d = -120;      gg = d = " + gg + "\n");


            ////C

            ////Boxing
            //a = 199;    object o = a;
            ////Unboxing
            //o = 121;    a = (int)o; 


            ////D

            //var V1 = 5;
            //Console.WriteLine("Тип переменной var V1 = 5 - " + V1.GetType());
            //var V2 = "Hello world!";
            //Console.WriteLine("Тип переменной var V2 = \"Hello world!\" - " + V2.GetType());
            //var V3 = 10.389;
            //Console.WriteLine("Тип переменной var V3 = 10.389 - " + V3.GetType() + "\n");


            ////E

            //bool? nullable = null;
            //int? nullable2 = null;
            //int? nullable3 = 2;
            //if (!nullable.HasValue)
            //    Console.WriteLine("Переменная nullable равна null!");
            //else Console.WriteLine("Переменная nullable НЕ равна null!");
            ////?? возвращает операнд1 в случае если тот не равен значению null, иначе возвращает операнд2.
            //Console.WriteLine("nullable2 ?? 4 = " + (nullable2 ?? 4));
            //Console.WriteLine("nullable3 ?? 4 = " + (nullable3 ?? 4) + "\n");


            ////F

            //var check = 55;
            ////mistake!!
            ////check = "John";


            //TASK 2

            //A
            string s1 = "First C# string!", s2 = "HI";
            if (Equals(s1, s2))
                Console.WriteLine("Strings s1 = \"First C# string!\" and s2 = \"HI\" are the same!!!\n");
            else Console.WriteLine("Strings s1 = \"First C# string!\" and s2 = \"HI\" are NOT the same!!!\n");

            //B

            string s3 = "New line", s4;
            //Конкатенация=объединение=сцепление
            s4 = s2 + " " + s3;
            Console.WriteLine("s4 = " + s4);
            s4 = String.Concat(s1," ", s3);
            Console.WriteLine("s4 = "+ s4);
            //копирование
            s4 = String.Copy(s2);
            Console.WriteLine("s4 = " + s4);
            //выделение подстроки
            s4 = s1.Substring(6, 2);
            Console.WriteLine("s4 = " + s4);
            //разделение строки на слова
            string[] words = s1.Split(' ');
            Console.Write("s1 words are : ");
            for (int ii = 0; ii < words.Length; ii++)
                Console.Write(words[ii] + " ");
            //вставка подстроки в заданную позицию
            s4 = s1.Insert(2, " "+s2+" ");
            Console.WriteLine("\ns4 = " + s4);
            //удаление заданной подстроки
            s4 = s4.Remove(2, s2.Length + 2);
            Console.WriteLine("s4 = " + s4);
            //интерполирование строк
            Console.WriteLine($"Строка 1 - это \"{s1}\"\n");

            //C
            string s5 = "", s6 = null;
            if (string.IsNullOrEmpty(s5))
                Console.WriteLine("Строка s5 null or empty");
            else Console.WriteLine($"Строка s5 {s5} не null и не empty");
            if (string.IsNullOrEmpty(s6))
                Console.WriteLine("Строка s6 null or empty");
            else Console.WriteLine($"Строка s6 {s6} не null и не empty");

            //D
            StringBuilder s7 = new StringBuilder ("qwerty");
            s7.Remove(1, 1); s7.Remove(2, 2);
            Console.WriteLine("\n" + s7);
            s7.Insert(0, "hahaha"); s7.Insert(s7.Length, "hahaha");
            Console.WriteLine(s7);


            ////TASK 3

            ////A
            //int[,] numbers = { { 0, 1, 2, 3 }, { 4, 5, 6, 7 }, { 8, 9, 10, 11 } };
            //int rows = 3, cols = numbers.Length / rows;
            //Console.WriteLine("\nМассив numbers");
            //for (int i1 = 0; i1 < rows; i1++ )
            //{
            //    for (int j1 = 0; j1 < cols; j1++)
            //        Console.Write($"{numbers[i1, j1]}\t");
            //    Console.WriteLine();
            //}

            ////B
            //string[] arrString = { "Mon", "Tue", "Wen", "Thurs", "Fri", "Sat", "Sun" };
            //Console.WriteLine("\narrString : ");
            //int i3;
            //for (i3 = 0; i3 < arrString.Length; i3++)
            //    Console.Write($"{arrString[i3]}\t");
            //Console.WriteLine($"\narrString lenght is {arrString.Length}");
            //Console.Write("Введите позицию элемента массива, который хотите изменить : "); i3 = Convert.ToInt32(Console.ReadLine()); 
            //Console.Write("Введите слово для замены : ");  arrString[i3-1] = Console.ReadLine();
            //for (i3 = 0; i3 < arrString.Length; i3++)
            //    Console.Write($"{arrString[i3]}\t");

            ////C
            //int[][] arr = new int[3][];
            //arr[0] = new int[2];
            //arr[1] = new int[3];
            //arr[2] = new int[4];
            //Console.WriteLine("\n\nВведите элементы массива - целые числа : ");
            //for (i3 = 0; i3 < 3; i3++)
            //{
            //    //Console.WriteLine(arr[i3].Length);
            //    for (int j = 0; j < arr[i3].Length; j++)
            //        arr[i3][j] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine("\nЭлементы массива : ");
            //for (i3 = 0; i3 < 3; i3++)
            //{
            //    for (int j = 0; j < arr[i3].Length; j++)
            //        Console.Write($"{arr[i3][j]}\t");
            //    Console.WriteLine();
            //}

            ////D
            //var ss = "It's an implicitly typed variable.";
            //var aaa = new[] { 1, 2, 3 };


            ////TASK 4

            ////A
            //(int, string, char, string, ulong) tuple = (10, "sunny", 'q', "day", 5672912);

            ////B
            //Console.WriteLine($"{tuple.Item1}\t{tuple.Item2}\t{tuple.Item3}\t{tuple.Item4}\t{tuple.Item5}");
            //Console.WriteLine($"{tuple.Item1}\t{tuple.Item3}\t{tuple.Item4}\t");

            ////C
            //int num1 = tuple.Item1;
            //string str1 = tuple.Item2, str2 = tuple.Item4;
            //char ch1 = tuple.Item3;
            //ulong ul1 = tuple.Item5;

            //(int num11, string str11, char char11, string str22, ulong ul11) = tuple;

            //(int, string, char, string, ulong) tuple2 = (5, "cold", 'o', "water", 43561);
            //(int22, str33, _, _, ul22) = tuple2;

            ////D
            //if (tuple.Equals(tuple2))
            //    Console.WriteLine("The tuples are equal");
            //else Console.WriteLine("The tuples are NOT equal");


            ////TASK 5

            //(int, int, int, char) function_tuple ()
            //{                
            //    (int , int , int , char ) tuple;
            //    int[] array = { 0, 1, -3, 578, -21, 2, 654 };
            //    string line = "It's my first C# function.";
            //    tuple.Item1 = array[0]; tuple.Item2 = array[0]; tuple.Item3 = 0;
            //    for (int i = 0; i < array.Length; i++)
            //    {
            //        if (array[i] > tuple.Item1)
            //            tuple.Item1 = array[i];
            //        if (array[i] < tuple.Item2)
            //            tuple.Item2 = array[i];
            //        tuple.Item3 += array[i];
            //    }
            //    tuple.Item4 = line[0];
            //    return tuple;
            //}


            //TASK 6

            void func1()
            {
                int ten = 10;
                checked
                {
                    int max_int = int.MaxValue + ten;
                    Console.WriteLine(max_int);
                }
            }

            void func2()
            {
                int max_int;
                unchecked
                {
                    max_int = int.MaxValue + 10;
                    Console.WriteLine(max_int);
                }
            }

            func1(); func2();
        }
    }
}
