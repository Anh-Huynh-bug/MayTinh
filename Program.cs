using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayTinh
{
    internal class Program
    {
        /// <summary>
        /// Cộng hai số.
        /// </summary>
        /// <param name="a">Tham số a</param>
        /// <param name="b">Tham số b</param>
        /// <returns>Trả về giá trị a + b</returns>
        static double Cong_Plus(double a, double b)
        {
            return a + b;
        }
        /// <summary>
        /// Trừ hai số
        /// </summary>
        /// <param name="a">Tham số a</param>
        /// <param name="b">Tham số b</param>
        /// <returns>Trả về giá trị a - b</returns>
        static double Tru_Minus(double a, double b)
        {
            return a - b;
        }

        static double Chia_divide(double a, double b)
        {
            return a / b;
        }
        static double Nhan_Multiply(double a, double b)
        {
            return a * b;
        }
        static void Main(string[] args)
        {
            //Console.BackgroundColor = ConsoleColor.Cyan;
            Console.OutputEncoding = Encoding.UTF8;
            while (true)
            {
               
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("MÁY TÍNH CƠ BẢN");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Nhập phép tính cần để tính toán.(Lưu ý: Nhấn enter để tính toán)");
                Console.WriteLine("Ví dụ: 5 [Enter] + [Enter] 3 [Enter]");
                double numberA, numberB; char math_Operation;
                while (true)
                {
                    try
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        numberA = double.Parse(Console.ReadLine());
                        math_Operation = char.Parse(Console.ReadLine());
                        numberB = double.Parse(Console.ReadLine());
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.ForegroundColor= ConsoleColor.Red;
                        Console.WriteLine("Chỉ chấp nhận chữ số và dấu + - * /!");
                        Console.WriteLine("Ví dụ: 5 [Enter] + [Enter] 3 [Enter]");
                    }
                }
                switch (math_Operation)
                {
                    case '+':
                        Console.ForegroundColor = ConsoleColor.Blue;
                        double result_Plus = Cong_Plus(numberA, numberB);
                        Console.WriteLine(result_Plus);
                        break;
                    case '-':
                        Console.ForegroundColor = ConsoleColor.Blue;
                        double result_Minus = Tru_Minus(numberA, numberB);
                        Console.WriteLine(result_Minus);
                        break;
                    case '*':
                        Console.ForegroundColor = ConsoleColor.Blue;
                        double result_Multiply = Nhan_Multiply(numberA, numberB);
                        Console.WriteLine(result_Multiply);
                        break;
                    case '/':
                        Console.ForegroundColor = ConsoleColor.Blue;
                        double result_Divide = Chia_divide(numberA, numberB);
                        Console.WriteLine(result_Divide);
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Phép tính không hợp lệ!");
                        break;
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Để thoát ấn AC/ac hoặc ấn Enter để tiếp tục");
                string Exit = Console.ReadLine();
                if (Exit == "AC" || Exit == "ac")
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Tạm biệt bạn!");
                    break;
                }
                Console.Clear();
            }
            Console.ReadLine();
            
        }
    }
}
