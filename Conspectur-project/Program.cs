using System;

namespace Conspectur_project
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("тест");
            int a = -18;
            Console.WriteLine(a);
            a = 579;
            bool b = true;
            double s = 1.33;
            char c = '%';
            Console.WriteLine("" + a + b + c + s);
            object d = "тест програмы прошёл успешно\nкак тебя звать?";
            Console.WriteLine(d);
            object h;
            h = Console.ReadLine();
            Console.WriteLine("приятно познакомится " + h + "!\nкакой пунки вас интересует на выбор?");
            Console.WriteLine("доступны пункты: калькулятор");
            string punct;
            h = Console.ReadLine();
            punct = Convert.ToString(h);
            object z = "введите";
            if (punct == "калькулятор")
            {
                Console.WriteLine("Какую тип операции вы желаете провести на выбор: сложение, умножение, вычитание и деление");
                h = Console.ReadLine();
                punct = Convert.ToString(h);
                int i1;
                int i2;
                int rezultat;
                Console.WriteLine(z + " первое число:");
                h = Console.ReadLine();
                i1 = Convert.ToInt32(h);
                Console.WriteLine(z + " второе число:");
                h = Console.ReadLine();
                i2 = Convert.ToInt32(h);
                if (punct == "сложение")
                {
                    rezultat = i1 + i2;
                    Console.WriteLine("Результат: " + rezultat);
                }
                if (punct == "умножение")
                {
                    rezultat = i1 * i2;
                    Console.WriteLine("Результат: " + rezultat);
                }
                if (punct == "вычитание")
                {
                    rezultat = i1 - i2;
                    Console.WriteLine("Результат: " + rezultat);
                }
                if (punct == "деление")
                {
                    rezultat = i1 / i2;
                    Console.WriteLine("Результат: " + rezultat);
                }
                else  {
                    Console.WriteLine("ошибка: отсутствует введёный  тип операции, возможно в названии типа операции ошибка");
                }
            }
        }
    }
}
