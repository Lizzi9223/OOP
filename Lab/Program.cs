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
            //ЗАДАНИЕ 1

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


            //B

            //Явное преобразование
            int a = 33, b = 600;   byte c = (byte)(a + b);
            Console.WriteLine("int a = 4, b = 6;   byte c = (byte)(a + b) = " + c + "\n");

            short d = -115;     float e = (float)(d * 2);
            Console.WriteLine("short d = -115;     float e = (float)(d * 2) = " + e + "\n");

            char f = 'q';       a = (int)f;
            Console.WriteLine("char f = 'q';       a = (int)f = " + a + "\n");

            float g = 1.567F;    double h = (double)g;
            Console.WriteLine("float g = 1.567F;    double h = (double)g = " + h + "\n");

            uint i = 22;        g = (float)i;
            Console.WriteLine("uint i = 22;        g = (float)i = " + g + "\n");

            //Неявное преобразование 
            byte aa = 4;     ushort bb = aa;
            Console.WriteLine("byte aa = 4;     ushort bb = aa = " + bb + "\n");

            sbyte cc = 4;   short dd = cc;
            Console.WriteLine("sbyte cc = 4;   short dd = cc = " + dd + "\n");

            char ee = 'w';    int ff = ee;
            Console.WriteLine("char ee = 'w';    int ff = ee = " + ff + "\n");

            float gg = 1.78F;   h = gg;
            Console.WriteLine("float gg = 1.78F;   h = gg = " + h + "\n");

            d = -120;      gg = d;
            Console.WriteLine("d = -120;      gg = d = " + gg + "\n");


            //C

        }
    }
}
