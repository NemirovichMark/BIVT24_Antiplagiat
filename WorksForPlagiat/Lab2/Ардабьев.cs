using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Diagnostics.Tracing;
using System.Runtime.InteropServices;
using System.Xml.Linq;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        //program.Task_1_1(0.9, 1.23);
        //program.Task_1_2(0.9, 1.23);
        //program.Task_1_3(0.9, 1.23);
        //program.Task_1_4(0.9, 1.23, -0.1);
        //program.Task_1_5(0.9, 1.23);
        //program.Task_1_6(0.9, 1.23);
        //program.Task_1_7(0.9);
        //program.Task_1_8(0.9);
        //program.Task_1_9(0.9);
        //program.Task_1_10(0.9);
        //program.Task_2_1(10);
        //program.Task_2_2(5, 3, 2, 1);
        //program.Task_2_2(5, 1.5, 1.5, 1);
        //program.Task_2_2(5, 1, 3, 1);
        //program.Task_2_3(10);
        //program.Task_2_4(5, 1, 2);
        //program.Task_2_5(10, 30);
        //program.Task_2_6(5);
        //program.Task_2_7(5);
        //program.Task_2_8(5);
        //program.Task_2_9(10);
        //program.Task_2_10(10);
        //program.Task_2_11(10);
        //program.Task_2_12(10, 0);
        //program.Task_2_13(10, 5, 0);
        //program.Task_3_1();
        //program.Task_3_2(3, 2, 1);
        //program.Task_3_2(1.5, 1.5, 1);
        //program.Task_3_2(1, 3, 1);
        //program.Task_3_3();
        //program.Task_3_4(1, 2);
        //program.Task_3_5(30);
        //program.Task_3_6();
        //program.Task_3_7();
        //program.Task_3_8();
        //program.Task_3_9();
        //program.Task_3_10();
        //program.Task_3_11();
        //program.Task_3_12(10, 0);
        //program.Task_3_13(10, 5, 0);
    }
    #region Level 1
    public bool Task_1_1(double x, double y)
    {
        bool answer = false;

        // code here
        double r = 2;
        
        if (Math.Abs(x*x + y*y - r * r) <= Math.Pow(10,-3))
        {
            answer = true;
        }
        Console.WriteLine(x);
        Console.WriteLine(y);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        if (y >= 0 && y + Math.Abs(x) <= 1)
        {
            answer = true;
        }
        Console.WriteLine(x);
        Console.WriteLine(y);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;

        // code here
        double c;
        if (a > 0)
        {
            if (a > b)
            {
                c = a;
            }
            else
            {
                c = b;
            }
        }
        else
        {
            if (a < b)
            {
                c = a;
            }
            else
            {
                c = b;
            }
        }
        answer = c;
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        // code here
        double z;
        if (a < b)
        {
            z = a;
        }
        else
        {
            z = b;
        }
        if (z > c)
        {
            z = z;
        }
        else
        {
            z = c;
        }
        answer = z;
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        double wtf, sqDiag, cirDiam; // квадрат поместится в круге, если диагональ квадрата меньше или равна диаметру круга
        sqDiag = Math.Sqrt(2) * Math.Sqrt(s);
        cirDiam = Math.Sqrt(r/Math.PI) * 2;
        if (sqDiag <= cirDiam)
        {
            answer = true;
        }
        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        double cirDiam, a; // Круг поместится в квадрате, если его диаметр меньше или равен длине стороны квадрата.
        cirDiam = Math.Sqrt(r / Math.PI) * 2;
        a = Math.Sqrt(s); // Сторона квадрата
        if (cirDiam <= a)
        {
            answer = true;
        }
        // end

        return answer;
    }
    public double Task_1_7(double x)
    {
        double answer = 0;

        // code here
        double y;
        if (Math.Abs(x) > 1)
        {
            y = 1;
        }
        else
        {
            y = Math.Abs(x);
        }

        answer = y;
        // end

        return answer;
    }
    public double Task_1_8(double x)
    {
        double answer = 0;

        // code here
        double y;
        if (Math.Abs(x) >= 1)
        {
            y = 0;
        }
        else
        {
            y = Math.Pow(x, 2) - 1;
        }
        answer = y;
        // end

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        // code here
        double y;
        if (x <= -1)
        {
            y = 0;
        }
        else if (x > -1 && x <= 0)
        {
            y = 1 + x;
        }
        else
        {
            y = 1;
        }
        answer = y;
        // end

        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;

        // code here
        double y;
        if (x <= -1)
        {
            y = 1;
        }
        else if (x > -1 && x <= 1)
        {
            y = -x;
        }
        else
        {
            y = -1;
        }
        answer = y;
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(int n)
    {
        double answer = 0;

        // code here
        double summ = 0;
        double[] height = new double[] { 168, 147, 174, 154, 180, 149, 166, 160, 175, 161 };
        for (int i = 0; i <= 9; i++)
        {
            summ += height[i];
        }
        answer = summ / n;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        // code here
        double x, y;
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("Введите x");
            x = double.Parse(Console.ReadLine()) - a;
            Console.WriteLine("Введите y");
            y = double.Parse(Console.ReadLine()) - b;

            if (x * x + y * y <= r * r)
            {
                answer += 1;
            }
            Console.WriteLine(answer);
        }

        // end

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        // code here
        double milk = 0;
        double[] weight = new double[] {27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5};
        for(int i = 0; i <= n-1; i++)
        {
            if (weight[i] < 30)
            {
                milk += 0.2;
            }
        }
        Console.WriteLine(milk);
        answer = milk;
        // end

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here
        for (int i = 1; i <= n; i++)
        {
            double x, y;
            Console.WriteLine("Введите x");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите y");
            y = double.Parse(Console.ReadLine());

            if ((x * x + y * y >= r1 * r1) && (x * x + y * y <= r2 * r2))
            {
                answer += 1;
            }
            Console.WriteLine(answer);
        }
        // end

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

        // code here
        double result;
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("Введите результат спортсмена:");
            result = double.Parse(Console.ReadLine());
            if (result <= norm)
            {
                answer++;
            }
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;

        // code here
        double x, y;
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("Координаты x");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Координаты y");
            y = double.Parse(Console.ReadLine());
            if ( y >= 0 && y <= Math.Sin(x) && x >= 0 && x <= Math.PI )
            {
                answer++;
            }
        }
        Console.WriteLine("количество точек: " + answer);
        // end

        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;

        // code here
        double x, y;
        bool q1, q2, q3, q4;
        for (int i = 1; i <= n; i++)
        {
            q1 = false; q2 = false; q3 = false; q4 = false;

            Console.WriteLine("Координаты x");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Координаты y");
            y = double.Parse(Console.ReadLine());
            
            if ( x >= 0 && y >= 0 )
            {
                Console.WriteLine("Номер квадранта: " + 1);
                q1 = true;
            }
            if ( x <= 0 && y >= 0 )
            {
                Console.WriteLine("Номер квадранта: " + 2);
                q2 = true;
            }
            if ( x <= 0 && y <= 0 )
            {
                Console.WriteLine("Номер квадранта: " + 3);
                q3 = true;
            }
            if ( x >= 0 && y <= 0 )
            {
                Console.WriteLine("Номер квадранта: " + 4);
                q4 = true;
            }

            if (q1 == true && q2 == false && q3 == false && q4 == false)
            {
                answer1++;
            }
            if (q1 == false && q2 == false && q3 == true && q4 == false)
            {
                answer3++;
            }
        }
        Console.WriteLine($"в квадранте 1: ({answer1})      в квадранте 2: ({answer3})");
        // end

        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;

        // code here
        for (int i = 1; i <= n; i++)
        {
            double x, y, D = 0; // D - расстояние от точки до начала координат

            Console.WriteLine("Координаты x");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Координаты y");
            y = double.Parse(Console.ReadLine());

            double maxD = D;
            D = Math.Sqrt(x * x + y * y);
            if ( D >= maxD )
            {
                maxD = D;
                answer = i;
            }
            answerLength = Math.Round(maxD,2);
        }
        Console.WriteLine("Номер точки: " + answer + "    длина: " + answerLength);
        // end

            return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        double result, minResult = 0;
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"Введите результат спортсмена №{i}");
            result = double.Parse(Console.ReadLine());
            if (result <= minResult || minResult == 0)
            {
                minResult = result;
            }
        }
        answer = minResult;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;
        int mark;
        for (int i = 1; i <= n; i++)
        {
            bool isGoodBoy = true; // не имеет оценок "2" или "3"
            Console.WriteLine($"Введите 4 оценки ученика №{i}:");

            for (int j = 0; j <= 3; j++)  // проверка введенного ряда чисел на наличие "2" или "3"
            {
                mark = int.Parse(Console.ReadLine());
                if (mark == 2 || mark == 3)
                {
                    isGoodBoy = false;
                }
            }

            if (isGoodBoy == true)
            {
                Console.WriteLine("You are good boy!");
                answer++;
            }
        }
        Console.WriteLine($"Количество хороших мальчиков: {answer}");
        // end

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;     // количество неуспевающих учеников
        double avg = 0.0;   // средний балл

        // code here;
        int summary = 0;    // сумма оценок для подсчёта среднего балла
        for (int i = 1; i <= n; i++)
        {
            bool isLoser = false;

            Console.WriteLine($"Введите 4 балла студента №{i}");
            for (int j = 0; j <= 3; j++)
            {
                int mark = int.Parse(Console.ReadLine());

                summary += mark;
                if (mark == 2)
                {
                    isLoser = true;
                }
            }

            if (isLoser == true)
            {
                answer++;
            }

            avg = (double)summary / (i * 4);
        }
        Console.WriteLine("Количство неуспевающих: " + answer);
        Console.WriteLine("Средний балл: " + Math.Round(avg,9));
        // end

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here;

        if (r <= 0)
        {
            return 0;
        }

        switch (type)
        {
            case 0:     // площадь квадрата стороной r
                answer = r * r;
                break;
            case 1:     // площадь круга радиусом r
                answer = Math.PI * r * r;
                break;
            case 2:     // площадь равностороннего треугольника стороной r
                answer = (Math.Sqrt(3) / 4) * r * r;
                break;
        }
        answer = Math.Round(answer, 2);

        //if (r <= 0)
        //{
        //    answer = 0;
        //}
        //else
        //{
        //    if (type == 0)      // площадь квадрата стороной r
        //    {
        //        answer = r * r;
        //    }
        //    else if (type == 1)      // площадь круга радиусом r
        //    {
        //        answer = Math.PI * r * r;
        //    }
        //    else if (type == 2)      // площадь равностороннего треугольника стороной r
        //    {
        //        answer = (Math.Sqrt(3) / 4) * r * r;
        //    }
        //    else
        //    {
        //        answer = 0;
        //    }
        //}

        // end

        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        // code here

        if (A <= 0 || B <= 0)
        {
            return 0;
        }

        switch (type)
        {
            case 0:     // площадь прямоугольника со сторонами A и B
                answer = A * B;
                break;
            case 1:     // площадь кольца, заключенного между двумя окружностями с радиусами А и В
                answer = Math.Abs(Math.PI * A * A - Math.PI * B * B);
                break;
            case 2:     // площадь равнобедренного треугольника со сторонами А, B, В
                double h = Math.Sqrt(B * B - (A / 2) * (A / 2));
                answer = (0.5) * A * h;
                break;
        }

        //if (A <= 0 || B <= 0)
        //{
        //    answer = 0;
        //}
        //else
        //{
        //    if (type == 0)          // площадь прямоугольника со сторонами A и B
        //    {
        //        answer = A * B;
        //    }
        //    else if (type == 1)     // площадь кольца, заключенного между двумя окружностями с радиусами А и В
        //    {
        //        answer = Math.Abs(Math.PI * A * A - Math.PI * B * B);
        //    }
        //    else if (type == 2)     // площадь равнобедренного треугольника со сторонами А, B, В
        //    {
        //        double h = Math.Sqrt(B * B - (A / 2) * (A / 2));
        //        answer = (0.5) * A * h;
        //    }
        //    else
        //    {
        //        answer = 0;
        //    }
        //}
        answer = Math.Round(answer, 2);
        Console.WriteLine($"ответ {answer},                 А: {A},  В: {B}      тип:{type} ");
        // end

        return answer;
    }
    #endregion

    #region Level 3
    public double Task_3_1()
    {
        double answer = 0;
        int n = 0;

        // code here
        double height, total = 0, mean = 0;
        int i = 0;
        string input;

        Console.WriteLine("Вводите данные, до тех пор, пока не нажмёте Enter...");

        while ( (input = Console.ReadLine()) != "" )
        {
            i++;
            height = double.Parse(input);
            total += height;
            mean = total / i;
        }

        Console.WriteLine("Средний рост: " + mean);
        // end

        // answer should be equal to the task_2_1 answer
        return answer;
    }
    public int Task_3_2(double r, double a, double b)
    {
        int answer = 0, n = 0;

        // code here

        // end

        return answer;
    }
    public double Task_3_3()
    {
        double answer = 0;
        int n = 0;

        // code here
        double weight, milk = 0;
        string input;
        while (true)
        {
            Console.WriteLine("Введите вес ученика в килограммах (или нажмите Enter для остановки программы)");
            if ((input = Console.ReadLine()) == "")
            {
                Console.WriteLine("Литров молока потребуется на класс: " + milk);
                break;
            }
            weight = double.Parse(input);
            if (weight < 30)
            {
                milk += 0.2;
            }
            
        }
        answer = milk;
        // end

        return answer;
    }
    public int Task_3_4(double r1, double r2)
    {
        int answer = 0, n = 0;

        // code here
        double x, y;
        string input;
        while (true)
        {
            Console.WriteLine("Введите x (или нажмите Enter для остановки программы)");
            if ( (input = Console.ReadLine()) == "")
            {
                Console.WriteLine("Точек попадет в кольцо: " + answer);
                break;
            }
            x = double.Parse(input);

            Console.WriteLine("Введите y");
            y = double.Parse(Console.ReadLine());

            if ((x * x + y * y >= r1 * r1) && (x * x + y * y <= r2 * r2))
            {
                answer += 1;
            }
        }

        // end

        return answer;
    }
    public int Task_3_5(double norm)
    {
        int answer = 0, n = 0;

        // code here

        // end

        return answer;
    }
    public int Task_3_6()
    {
        int answer = 0, n = 0;

        // code here
        double x, y;
        string input;
        while (true)
        {
            Console.WriteLine("Введите x (или нажмите Enter для остановки программы)");
            if ((input = Console.ReadLine()) == "")
            {
                Console.WriteLine("Количество точек: " + answer);
                break;
            }
            x = double.Parse(input);

            Console.WriteLine("Введите y");
            y = double.Parse(Console.ReadLine());

            if (y <= Math.Sin(x) && x >= 0 && x <= Math.PI)
            {
                answer++;
            }
        }
        // end

        return answer;
    }
    public (int, int) Task_3_7()
    {
        int answer1 = 0, answer3 = 0, n = 0;

        // code here
        double x, y;
        string input;
        bool q1, q2, q3, q4;
        while (true)
        {
            q1 = false; q2 = false; q3 = false; q4 = false;

            Console.WriteLine("Введите x (или нажмите Enter для остановки программы)");
            if ((input = Console.ReadLine()) == "")
            {
                Console.WriteLine("Точек в квадранте (I): " + answer1 + "     " + "Точек в квадранте (III): " + answer3);
                break;
            }
            x = double.Parse(input);

            Console.WriteLine("Введите y");
            y = double.Parse(Console.ReadLine());



            if (x >= 0 && y >= 0)
            {
                Console.WriteLine("Номер квадранта: " + 1);
                q1 = true;
            }
            if (x <= 0 && y >= 0)
            {
                Console.WriteLine("Номер квадранта: " + 2);
                q2 = true;
            }
            if (x <= 0 && y <= 0)
            {
                Console.WriteLine("Номер квадранта: " + 3);
                q3 = true;
            }
            if (x >= 0 && y <= 0)
            {
                Console.WriteLine("Номер квадранта: " + 4);
                q4 = true;
            }

            if (q1 == true && q2 == false && q3 == false && q4 == false)
            {
                answer1++;
            }
            if (q1 == false && q2 == false && q3 == true && q4 == false)
            {
                answer3++;
            }
        }
        // end

        return (answer1, answer3);
    }
    public (int, double) Task_3_8()
    {
        int answer = 0, n = 0;
        double answerLength = double.MaxValue;

        // code here

        // end

        return (answer, answerLength);
    }
    public double Task_3_9()
    {
        double answer = double.MaxValue;
        int n = 0;

        // code here
        double result, minResult = 0;
        string input;
        while (true)
        {
            Console.WriteLine("Введите результат спортсмена (или нажмите Enter для остановки программы)");
            if ((input = Console.ReadLine()) == "")
            {
                Console.WriteLine("Лучший результат: " + minResult);
                break;
            }
            result = double.Parse(input);
            if (result <= minResult || minResult == 0)
            {
                minResult = result;
            }
        }
        // end

        return answer;
    }
    public int Task_3_10()
    {
        int answer = 0, n = 0;

        // code here;
        
        // end

        return answer;
    }
    public (int, double) Task_3_11()
    {
        int answer = 0, n = 0;
        double avg = 0.0;

        // code here;

        // end

        return (answer, avg);
    }
    #endregion
}