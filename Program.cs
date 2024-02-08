using System;
using System.Runtime.Intrinsics.Arm;

namespace project{
    class Program{
        static void Main(){
            // float user_input;
            // Console.WriteLine("Введите цифру с точкой");
            // user_input = Convert.ToDouble(Console.ReadLine());
            // user_input = float.Parse(Console.ReadLine());

            // float result;
            // result = user_input + 10f;
            // result = user_input - 10f;
            // result = user_input * 2f;
            // result = user_input / 5f;
            // result = user_input % 10f;
            // result = result + 5f;
            // result += 5f;
            // result++;
            // result--;

            // int a = 2, b=3;
            // int res=a%b;
            
            // Console.WriteLine("Переменнаая: " + result);

            // int num = 1; //обыяная переменная 
            // const int number = 21; // константа, его нельзя переопределить 

            // System.Console.WriteLine(Math.PI); //выводит число PI
            // System.Console.WriteLine(Math.Abs(-50)); // возвращает число по модулю
            // System.Console.WriteLine(Math.Ceiling(4.11f)); //округляет число к большему
            // System.Console.WriteLine(Math.Floor(4.12f)); // окргуляет в меньшую сторону
            // System.Console.WriteLine(Math.Round(4.50f)); // окргуляет либо к большему, либо к меньшему в зависимости от числа 
            // System.Console.WriteLine(Math.Min(5, 0)); // выводит наименьшее число из двух
            // System.Console.WriteLine(Math.Max(5, 0)); //выводит наибольшее число из двух
            // System.Console.WriteLine(Math.Pow(5, 2)); //возвести в определенную степень, указываем число и указываем степень для возведения

            System.Console.WriteLine("Введите радиус круга!");
            double radius = Convert.ToDouble(Console.ReadLine());
            double area = Math.PI * Math.Pow(radius, 2);

            System.Console.WriteLine("Площадь круга с радиусом {0} равна {1} ", radius, area);
            System.Console.WriteLine($"Площадь круга с радиусом {radius} равна {area} ");
        }
    }
}
