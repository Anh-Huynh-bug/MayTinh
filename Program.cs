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
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập phép tính cần để tính toán.(Lưu ý: Nhấn enter để tính toán");
            Console.WriteLine("Ví dụ: 5 [Enter] + [Enter] 3 [Enter]");
            double numberA, numberB; char math_Operation;
            while (true)
            {
                try
                {
                    numberA = double.Parse(Console.ReadLine());
                    math_Operation = char.Parse(Console.ReadLine());
                    numberB = double.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Chỉ chấp nhận chữ số và dấu + - * /!");
                }
            }
            switch (math_Operation)
            {
                case '+' :
                    double result_Plus = Cong_Plus(numberA, numberB);
                    Console.WriteLine(result_Plus);
                    break;
                case '-':
                    double result_Minus = Tru_Minus(numberA, numberB);
                    Console.WriteLine(result_Minus);
                    break ;
                case '*':
                    double result_Multiply = Nhan_Multiply(numberA, numberB);
                    Console.WriteLine(result_Multiply);
                    break;
                case '/':
                    double result_Divide = Chia_divide(numberA, numberB);
                    Console.WriteLine(result_Divide);
                    break;
                default :
                    Console.WriteLine("Phép tính không hợp lệ!");
                    break;
            }

            Console.ReadLine();
            
        }
    }
}
