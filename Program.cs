using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практичесая__2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  Задание 1
            
            Console.WriteLine("a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("b");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"{a}+{b} = {a + b} \n {a}*{b}={a * b}");
            Console.ReadLine();
            */

            /*  Задание 2
            Console.WriteLine("a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("b");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"{a} + {b} = {b} + {a} \n {a}*{b}={b} * {a}");
            Console.ReadLine();
            */

            /*  Задане 3
            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());
            Console.Write("c=");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine($"{a} + {b} + {c} = {a + b + c}");
            Console.ReadLine();
            */

            /* Задача 4
            Console.WriteLine("a=");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("b=");
            double b = double.Parse(Console.ReadLine());
            double result = Math.Round(a * b, 1);

            Console.WriteLine($"{a} * {b} = {result}");
            Console.ReadLine();
            Console.ReadLine();
            */

            /*  Задача 5
            Console.WriteLine("a=");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("b=");
            double b = double.Parse(Console.ReadLine());
            double result = Math.Round(a * b, 3);

            Console.WriteLine($"{a} / {b} = {result}");
            Console.ReadLine();
            Console.ReadLine();
            */

            /*  Задача 6
            Console.WriteLine("a=");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("b=");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("с=");
            double c = double.Parse(Console.ReadLine());
            double result = Math.Round(a * b, 2);

            Console.WriteLine($"({a} + {b}) + {c} = {a} + ({b} + {c}) {result}");
            Console.ReadLine();
            */

            /*   Задача 7
            Console.WriteLine("a=");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("b=");
            double b = double.Parse(Console.ReadLine());
            double result = Math.Round(a * b, 2);

            Console.WriteLine($"a + b = {a} + {b} = {a + b}");
            Console.WriteLine($"a - b = {a} - {b} = {a - b}");
            Console.WriteLine($"a * b = {a} * {b} = {a * b}");

            Console.ReadLine();
            */

            /*  Задача 8
            Console.WriteLine("Номинал купюры =");
            decimal nominal = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Количество купюр =");
            decimal quantity = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Сумма денег");
            decimal total = nominal * quantity;

            Console.WriteLine($"Сумма денег = {total:N2}р.");
            Console.ReadLine();
            */

            /*  Задание 2 
            
            Задача 1 

            Console.WriteLine("Введите радиус окружности:");
            double R = double.Parse(Console.ReadLine());

            double l = 2 * Math.PI * R;

            double S = Math.PI * Math.Pow(R, 2);

            Console.WriteLine($"Длина окружности: {l :F2}");
            Console.WriteLine($"Площадь круга: {S:F2}");
            Console.ReadLine();
            */

            /* Задание 2
            Console.WriteLine("Введите количество жителей в государстве:");
            long population = long.Parse(Console.ReadLine());

            Console.WriteLine("Введите площадь территории государства (в км):");
            double area = double.Parse(Console.ReadLine());

            double populationDensity = population / area;

            Console.WriteLine($"Плотность населения: {populationDensity:F2} чел./км");

            Console.ReadLine();
            */

            /*  Задание 3
            Console.WriteLine("Введите длину первого катета:");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите длину второго катета:");
            double b = double.Parse(Console.ReadLine());

            double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

            double perimeter = a + b + c;

            Console.WriteLine($"Периметр прямоугольного треугольника: {perimeter:F2}");
            Console.ReadLine();
            */

            /*  Задание 4
            Console.WriteLine("Введите длину первой стороны прямоугольника:");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите длину второй стороны прямоугольника:");
            double b = double.Parse(Console.ReadLine());

            double perimeter = 2 * (a + b);

            double diagonal = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

            Console.WriteLine($"Периметр прямоугольника: {perimeter:F2}");
            Console.WriteLine($"Длина диагонали прямоугольника: {diagonal:F2}");

            Console.ReadLine();
            */

            /*  Задание 5
            Console.WriteLine("Введите координату x1:");
            double x1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите координату y1:");
            double y1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите координату x2:");
            double x2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите координату y2:");
            double y2 = double.Parse(Console.ReadLine());

            double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine($"Расстояние между точками: {distance:F2}");

            Console.ReadLine();
            */

            /*  Задание 6
            Console.WriteLine("Введите стоимость 1 кг конфет:");
            double candy = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите стоимость 1 кг печенья:");
            double cookie = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите стоимость 1 кг яблок:");
            double apple = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите количество кг конфет (x):");
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите количество кг печенья (u):");
            double u = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите количество кг яблок (z):");
            double z = double.Parse(Console.ReadLine());

            double totalCost = (candy * x) + (cookie * u) + (apple * z);

            Console.WriteLine($"Общая стоимость покупки: {totalCost:F2} руб.");

            Console.ReadLine();
            */

            /* Задание 7
            Console.WriteLine("Введите двузначное число:");
            int number = int.Parse(Console.ReadLine());

            if (number < 10 || number > 99)
            {
                Console.WriteLine("Ошибка: число должно быть двузначным.");
                return;
            }

            int tens = number / 10;
            int units = number % 10;

            int sum = tens + units;   
            int product = tens * units; 

            Console.WriteLine($"Число десятков: {tens}");
            Console.WriteLine($"Число единиц: {units}");
            Console.WriteLine($"Сумма цифр: {sum}");
            Console.WriteLine($"Произведение цифр: {product}");

            Console.ReadLine();

            */


        }
    }
}
