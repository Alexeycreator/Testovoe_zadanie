using System;

namespace PrakticheskoeZadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Тестовое задание для стажировки." + "\n");

            Console.WriteLine("Выберите задание:" + "\n" + "1 - Определение площади треугольника, по его сторонам." + "\n" + "2 - Определение площади окружности, по его радиусу.");
            int chek = Convert.ToInt32(Console.ReadLine());
            switch (chek)
            {
                case 1: { treugolnik();break; }
                case 2: { krug();break; }
            }

            Console.ReadKey();
        }

        static void treugolnik()
        {
            Console.WriteLine("Введите первую сторону треугольника: ");
            double storona1 = Convert.ToDouble(Console.ReadLine());
            double a = storona1 * storona1;
            Console.WriteLine("Введите вторую сторону треугольника: ");
            double storona2 = Convert.ToDouble(Console.ReadLine());
            double b = storona2 * storona2;
            Console.WriteLine("Введите третью сторону треугольника: ");
            double storona3 = Convert.ToDouble(Console.ReadLine());
            double c = storona3 * storona3;

            if (c == a + b)
            {
                Console.WriteLine("Треугольник - прямоугольный");
                double ploshad_treugol = (storona1 * storona2) / 2;
                Console.WriteLine("Площадь треугольника = " + ploshad_treugol);
            }
            else 
            {
                double p = (storona1 + storona2 + storona3) / 2;
                double ploshad_treugol = Math.Sqrt(p * (p - storona1) * (p - storona2) * (p - storona3));
                Console.WriteLine("Площадь треугольника = " + ploshad_treugol);
            }
        }

        static void krug()
        {
            Console.WriteLine("Введите радиус окружности: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double s_kruga = Math.PI * (radius * radius);
            Console.WriteLine("Площадь круга = " + s_kruga);
        }
    }
}
