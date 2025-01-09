using Microsoft.VisualBasic;
using System;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;

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
        //program.Task_2_6(3);
        //program.Task_2_7(3);
        //program.Task_2_8(5);
        //program.Task_2_9(6);
        //program.Task_2_10(10);
        //program.Task_2_11(8);
        //program.Task_2_12(10, 0);
        //program.Task_2_13(10, 5, 0);
        //program.Task_3_1();
        //program.Task_3_2(3, 2, 1);
        //program.Task_3_2(1.5, 1.5, 1);
        //program.Task_3_2(1, 3, 1);
        //program.Task_3_3();
        //program.Task_3_4(1, 2);
        //program.Task_3_5(30);
        program.Task_3_6();
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
        if (Math.Abs(x * x + y * y - 4) <= Math.Pow(10, -3))
        {
            answer = true;
        }
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
        // end

        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;

        // code here
        if(a > 0)
        {
            if (a > b)
            {
                answer = a;
            } 
            else
            {
                answer = b;
            }
        }
        else
        {
            if(a < b)
            {
                answer = a;
            }
            else
            {
                answer = b;
            }
        }
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        // code here
        double d = 0, e = 0;
        if (a > b)
        {
            d = b;
        }
        else
        {
            d = a;
        }
        if (c > d)
        {
            answer = c;
        }
        else
        {
            answer = d;
        }
            // end

            return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        double d = (Math.Sqrt(s) * Math.Sqrt(2)) / 2;
        double R = Math.Sqrt(r / Math.PI);
        if(d <= R)
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
        double d = Math.Sqrt(s) / 2;
        double R = Math.Sqrt(r / Math.PI);
        if (R <= d)
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
        if (Math.Abs(x) > 1)
        {
            answer = 1;
        }
        else
        {
            answer = Math.Abs(x);
        }
        // end

        return answer;
    }
    public double Task_1_8(double x)
    {
        double answer = 0;

        // code here
        if (Math.Abs(x) >= 1)
        {
            answer = 0;
        }
        else
        {
            answer = x*x - 1;
        }
        // end

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1)
        {
            answer = 0;
        }
        if (-1 < x && x <= 0)
        {
            answer = x + 1;
        }
        if (x > 0)
        {
            answer = 1;
        }
        // end

        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1)
        {
            answer = 1;
        }
        if (x > -1 && x <= 1)
        {
            answer = -x;
        }
        if (x > 1)
        {
            answer = -1;
        }
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(int n)
    {
        double answer = 0;

        // code here
        double k = n;
        double s = 0, r; 
        for (double i = 0; i < k; i++)
        {
            //Console.WriteLine("Введите рост ученика");
            double.TryParse(Console.ReadLine(), out r);
            s += r;
        }
        answer = s / k;
        Console.WriteLine(answer);

        // end

        // for test input in console: 168, 147, 174, 154, 180, 149, 166, 160, 175, 161

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        // code here
        double k = n, x0 = a, y0 = b, x, y;
        int klv = 0;
        for (double i = 0; i < k; i++)
        {
            Console.WriteLine("Введите x");
            double.TryParse(Console.ReadLine(), out x);
            Console.WriteLine("Введите y");
            double.TryParse(Console.ReadLine(), out y);
            if ((x - x0) * (x - x0) + (y - y0) * (y - y0) <= r * r) klv++;
        }
        Console.WriteLine("В круг попало {0} точек из {1} ", klv, n);
        answer = klv;
        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -2.5 -0.5

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0, v = 0, stakan = 0, ltr = 0;

        // code here
        for(int i = 0; i < n; i++)
        {
            Console.WriteLine("Введите вес ученика");
            double.TryParse(Console.ReadLine(), out v);
            if (v < 30) stakan += 1;
        }
        ltr = stakan * 200 / 1000;
        Console.WriteLine("Потребуется {0} литров молока", ltr);
        answer = ltr;
        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here
        double k = n, x = 0, y = 0;
        int klv = 0;
        for (double i = 0; i < k; i++)
        {
            Console.WriteLine("Введите x");
            double.TryParse(Console.ReadLine(), out x);
            Console.WriteLine("Введите y");
            double.TryParse(Console.ReadLine(), out y);
            if ((x*x + y*y <= r2 * r2) && (x * x + y * y >= r1 * r1))  klv++;
        }
        Console.WriteLine("В кольцо попало {0} точек из {1} ", klv, n);
        answer = klv;
        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -0.5 -0.5

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;
        double rslt = 0;

        // code here
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Введите результат участника");
            double.TryParse(Console.ReadLine(), out rslt);
            if (rslt >= norm) answer++;
        }
        Console.WriteLine("Нормотив выполнили {0} участников из {1}", answer, n);
        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;
        double x, y;
        // code here
        for(int i = 0; i < n; i++)
        {
            Console.WriteLine("Введите x");
            double.TryParse(Console.ReadLine(), out x);
            Console.WriteLine("Введите y");
            double.TryParse(Console.ReadLine(), out y);
            if(x >= 0 && x <= Math.PI && y <= Math.Sin(x)) answer++;
        }
        // end
        Console.WriteLine(answer);
        // for test input in console: 1.2 0.7, 2 0.2, 0.5 0.9, -1 1.5, 0.5 0.1

        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;
        double x, y;
        // code here
        for(int i = 0; i < n; i++)
        {
            Console.WriteLine("Введите x");
            double.TryParse(Console.ReadLine(), out x);
            Console.WriteLine("Введите y");
            double.TryParse(Console.ReadLine(), out y);
            if(x > 0 && y > 0)
            {
                answer1++;
                Console.WriteLine("Точка находится в 1 квадранте");
            }
            if (x < 0 && y > 0)
            {
                Console.WriteLine("Точка находится во 2 квадранте");
            }
            if (x < 0 && y < 0)
            {
                answer3++;
                Console.WriteLine("Точка находится в 3 квадранте");
            }
            if (x > 0 && y < 0)
            {
                Console.WriteLine("Точка находится в 4 квадранте");
            }
        }
        Console.WriteLine("Количство точек в 1 квадранте - {0}, количство точек в 3 квадранте - {1}", answer1, answer3);
        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5

        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;
        double x, y;
        // code here
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("Введите координату x");
            double.TryParse((Console.ReadLine()), out x);
            Console.WriteLine("Введите координату y");
            double.TryParse((Console.ReadLine()), out y);
            if (Math.Sqrt(x * x + y * y) <= answerLength)
            {
                answerLength = (Math.Sqrt(x * x + y * y));
                answer = i;
            }
        }
        Console.WriteLine("Точка {0} находится ближе всего к началу координат, расстояние от неё до начала координат - {1}", answer, Math.Round(answerLength, 2));
        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -0.5

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;
        double x = 0;
        // code here
        for(int i = 1; i <= n; i++)
        {
            Console.WriteLine("Введите результат {0} спортсмена", i);
            double.TryParse((Console.ReadLine()), out x);
            if(x <= answer)
            {
                answer = x;
            }
        }
        Console.WriteLine("Лучший результат среди участников - {0}", answer);
        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;
        double a, b, c, d;
        // code here;
        for(int i = 1; i <= n; i++)
        {
            Console.WriteLine("Введите 1 оценку");
            double.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Введите 2 оценку");
            double.TryParse(Console.ReadLine(), out b);
            Console.WriteLine("Введите 3 оценку");
            double.TryParse(Console.ReadLine(), out c);
            Console.WriteLine("Введите 4 оценку");
            double.TryParse(Console.ReadLine(), out d);
            if (a >= 4 && b >= 4 && c >= 4 && d >= 4) answer++;
        }
        Console.WriteLine("Число студентов, не имеющих 2 и 3 - {0}", answer);
        // end

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;
        double a, b, c, d;
        // code here;
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("Введите 1 оценку");
            double.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Введите 2 оценку");
            double.TryParse(Console.ReadLine(), out b);
            Console.WriteLine("Введите 3 оценку");
            double.TryParse(Console.ReadLine(), out c);
            Console.WriteLine("Введите 4 оценку");
            double.TryParse(Console.ReadLine(), out d);
            if (a == 2 || b == 2 || c == 2 || d == 2) answer++;
            avg += (a + b + c + d)/4;
        }
        avg /= n;
        Console.WriteLine("Число неуспевающих студентов - {0}, средний балл группы - {1}", answer, avg);
        // end

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;
        // code here;
        //Console.WriteLine("Введите значение r");
        //double.TryParse(Console.ReadLine(), out r);
        //Console.WriteLine("Выберите вариант: 1 - площадь квадрата, 2 - площадь круга, 3 - площадь р/с треугольника: ");
        //int.TryParse(Console.ReadLine(), out type);
        if (r <= 0)
        {
            answer = 0;
        }
        else
        {
            switch (type)
            {

                case 0:
                    answer = r * r;
                    Console.WriteLine("Площадь квадрата = {0}", answer);
                    break;
                case 1:
                    answer = Math.PI * r * r;
                    Console.WriteLine("Площадь круга = {0}", answer);
                    break;
                case 2:
                    answer = r * r * Math.Sqrt(3) / 4;
                    Console.WriteLine("Площадь р/с треугольника = {0}", answer);
                    break;
                default:
                    Console.WriteLine("Некорректный выбор");
                    break;
            }
        }
        // end
        answer = Math.Round(answer, 2);
        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;
        if (A <= 0 || B <= 0)
        {
            answer = 0;
        }
        else
        {
            switch (type)
            {

                case 0:
                    answer = A*B;
                    Console.WriteLine("Площадь прямоугольника = {0}", answer);
                    break;
                case 1:
                    answer = Math.Abs((Math.PI * A*A) - (Math.PI * B * B));
                    Console.WriteLine("Площадь кольца = {0}", answer);
                    break;
                case 2:
                    answer = A * Math.Sqrt(B*B - (A*A/4)) / 2;
                    Console.WriteLine("Площадь р/б треугольника = {0}", answer);
                    break;
                default:
                    Console.WriteLine("Некорректный выбор");
                    break;
            }
        }
        // end
        answer = Math.Round(answer, 2);
        return answer;
    }
    #endregion

    #region Level 3
    public double Task_3_1()
    {
        double answer = 0;
        int n = 0;
        
        // code here

        // end

        // for test input in console: 168, 147, 174, 154, 180, 149, 166, 160, 175, 161
        // answer should be equal to the task_2_1 answer

        return answer;
    }
    public int Task_3_2(double r, double a, double b)
    {
        int answer = 0, n = 0;

        // code here

        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -2.5 -0.5
        // answer should be equal to the task_2_2 answer

        return answer;
    }
    public double Task_3_3()
    {
        double answer = 0, v = 0, stakan = 0, ltr = 0;
        int n = 0;
        // code here
        while (true)
        {
            Console.WriteLine("Введите вес ученика (или число <= 0 для прекращения операции)");
            double.TryParse(Console.ReadLine(), out v);
            if (v <= 0) break;
            if (v < 30)
            {
                stakan += 1;
                ltr = stakan * 200 / 1000;
            }

        }
        Console.WriteLine("Потребуется {0} литров молока", ltr);
        answer = ltr;
        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5
        // answer should be equal to the task_2_3 answer

        return answer;
    }
    public int Task_3_4(double r1, double r2)
    {
        int answer = 0, n = 0;

        // code here

        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -0.5 -0.5
        // answer should be equal to the task_2_4 answer

        return answer;
    }
    public int Task_3_5(double norm)
    {
        int answer = 0, n = 0;

        // code here

        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5
        // answer should be equal to the task_2_5 answer

        return answer;
    }
    public int Task_3_6()
    {
        int answer = 0;
        // code here
        while (true)
        {
            Console.WriteLine("Введите x (или 'стоп' для прекращения операции)");
            string a = Console.ReadLine();

            if (a == "стоп") break;
            Console.WriteLine("Введите y (или 'стоп' для прекращения операции)");
            string b = Console.ReadLine();
            if (b == "стоп") break;
            else
            {
                double x = double.Parse(a);
                double y = double.Parse(b);
                if (x <= 0) continue;
                else
                {
                    if (x >= 0 && x <= Math.PI && y <= Math.Sin(x)) answer++;
                }
            }

        }
        Console.WriteLine(answer);
        // end

        // for test input in console: 1.2 0.7, 2 0.2, 0.5 0.9, -1 1.5, 0.5 0.1
        // answer should be equal to the task_2_6 answer

        return answer;
    }
    public (int, int) Task_3_7()
    {
        int answer1 = 0, answer3 = 0, n = 0;

        // code here

        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5
        // answer should be equal to the task_2_7 answer

        return (answer1, answer3);
    }
    public (int, double) Task_3_8()
    {
        int answer = 0, n = 0;
        double answerLength = double.MaxValue;

        // code here

        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -0.5
        // answer should be equal to the task_2_8 answer

        return (answer, answerLength);
    }
    public double Task_3_9()
    {
        double answer = double.MaxValue;
        int n = 0;
        double x = 0;
        // code here
        while(true)
        {
            Console.WriteLine("Введите результат спортсмена (или число <= 0 для прекращения операции)");
            double.TryParse((Console.ReadLine()), out x);
            if (x <= 0) break;
            else
            {
                if (x <= answer)
                {
                    answer = x;
                }
            }
        }
        Console.WriteLine("Лучший результат среди участников - {0}", answer);
        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5
        // answer should be equal to the task_2_9 answer

        return answer;
    }
    public int Task_3_10()
    {
        int answer = 0, n = 0;

        // code here;

        // end

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4
        // answer should be equal to the task_2_10 answer

        return answer;
    }
    public (int, double) Task_3_11()
    {
        int answer = 0, n = 0;
        double avg = 0.0;

        // code here;

        // end

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4
        // answer should be equal to the task_2_11 answer

        return (answer, avg);
    }
    public double Task_3_12(double r, int type)
    {
        double answer = 0;

        // code here;

        // end
        // answer should be equal to the task_2_12 answer

        return answer;
    }
    public double Task_3_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;

        // end
        // answer should be equal to the task_2_13 answer

        return answer;
    }
    #endregion
}
