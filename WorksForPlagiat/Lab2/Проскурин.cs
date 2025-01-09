using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        program.Task_1_1(0.9, 1.23);
        program.Task_1_2(0.9, 1.23);
        program.Task_1_3(0.9, 1.23);
        program.Task_1_4(0.9, 1.23, -0.1);
        program.Task_1_5(0.9, 1.23);
        program.Task_1_6(0.9, 1.23);
        program.Task_1_7(0.9);
        program.Task_1_8(0.9);
        program.Task_1_9(0.9);
        program.Task_1_10(0.9);
        //program.Task_2_1(10);
        //program.Task_2_2(5, 3, 2, 1);
        //program.Task_2_2(5, 1.5, 1.5, 1);
        //program.Task_2_2(5, 1, 3, 1);
        //program.Task_2_3(10);
        //program.Task_2_3(8); 
        //program.Task_2_3(6);
        //program.Task_2_4(5, 1, 2);
        //program.Task_2_4(5, 1, 3);
        //program.Task_2_4(4, 1, 2);
        //program.Task_2_4(4, 1, 3);
        //program.Task_2_4(3, 1, 2);
        //program.Task_2_4(3, 1, 3);
        //program.Task_2_5(10, 30);
        //program.Task_2_5(10, 25.2); 
        //program.Task_2_5(8, 30);
        //program.Task_2_5(8, 25.2);
        //program.Task_2_5(6, 30);
        //program.Task_2_5(6, 25.2);
        //program.Task_2_6(5);
        //program.Task_2_6(4);
        //program.Task_2_6(3);
        //program.Task_2_7(5);
        //program.Task_2_7(4);
        //program.Task_2_7(3);
        //program.Task_2_8(5);
        //program.Task_2_8(4);
        //program.Task_2_8(3);
        //program.Task_2_9(10);
        //program.Task_2_9(8);
        //program.Task_2_9(6);
        //program.Task_2_10(10);
        //program.Task_2_10(8);
        //program.Task_2_10(6);
        //program.Task_2_11(10);
        //program.Task_2_11(8);
        //program.Task_2_11(6);
        program.Task_2_12(10, 0);
        program.Task_2_13(10, 5, 0);
        //program.Task_3_1();
        //program.Task_3_2(3, 2, 1);
        //program.Task_3_2(1.5, 1.5, 1);
        //program.Task_3_2(1, 3, 1);
        ///program.Task_3_3();
        //program.Task_3_4(1, 2);
        //program.Task_3_5(30);
        ///program.Task_3_6();
        //program.Task_3_7();
        //program.Task_3_8();
        ///program.Task_3_9();
        //program.Task_3_10();
        //program.Task_3_11();
        //program.Task_3_12(10, 0);
        //program.Task_3_13(10, 5, 0);
    }
    #region Level 1
    public bool Task_1_1(double x, double y)
    {
        //bool answer = false;

        // code here
        int r = 2;
        if (Math.Abs(x * x + y * y - r * r) <= 0.001)
        {
            return true;
        }
        else
        {
            return false;
        }
        // end

        //return answer;
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
        // double answer = 0;

        // code here
        if (a > 0)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        else
        {
            if (a > b)
            {
                return b;
            }
            else
            {
                return a;
            }
        }
        // end

        //return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        //double answer = 0;

        // code here
        double cashe_MIN;
        if (a > b)
        {
            cashe_MIN = b;
        }
        else if (b != a)
        {
            cashe_MIN = a;
        }
        else
        {
            cashe_MIN = a;
        }
        if (c > cashe_MIN)
        {
            return c;
        }
        else
        {
            return cashe_MIN;
        }
        // end

        //return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        //bool answer = false;

        // code here
        double diagonal = Math.Sqrt(2 * s);
        if (r != 0 && Math.Sqrt(r / Math.PI) * 2 >= diagonal)
        {
            return true;
        }
        else
        {
            return false;
        }
        //return answer;
        // end

    }
    public bool Task_1_6(double r, double s)
    {
        //bool answer = false;

        // code here
        double dm = 2 * Math.Sqrt(r / Math.PI);
        if (dm <= Math.Sqrt(s))
        {
            return true;
        }
        else
        {
            return false;
        }
        // end

        //return answer;
    }
    public double Task_1_7(double x)
    {
        //double answer = 0;

        // code here
        if (Math.Abs(x) > 1)
        {
            return 1;
        }
        else
        {
            return Math.Abs(x);
        }
        // end

        //return answer;
    }
    public double Task_1_8(double x)
    {
        //double answer = 0;

        // code here
        if (Math.Abs(x) >= 1)
        {
            return 0;
        }
        else
        {
            return x * x - 1;
        }
        // end

        //return answer;
    }
    public double Task_1_9(double x)
    {
        //double answer = 0;

        // code here
        if (x <= -1)
        {
            return 0;
        }
        else if (x > -1 && x <= 0)
        {
            return 1 + x;
        }
        else
        {
            return 1;
        }
        // end

        //return answer;
    }
    public double Task_1_10(double x)
    {
        //double answer = 0;

        // code here
        if (x <= -1)
        {
            return 1;
        }
        else if (x > -1 && x <= 1)
        {
            return -x;
        }
        else
        {
            return -1;
        }
        // end

        //return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(int n)
    {
        double answer = 0;
        // code here
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"Введите рост {i} ученика");
            double.TryParse(Console.ReadLine(), out double input);
            answer += input;

        }
        answer /= n;
        Console.WriteLine($"ответ = {answer}");
        // end

        // for test input in console: 168, 147, 174, 154, 180, 149, 166, 160, 175, 161

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        // code here
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"Введите координату x {i} точки");
            double.TryParse(Console.ReadLine(), out double x);
            Console.WriteLine($"Введите координату y {i} точки");
            double.TryParse(Console.ReadLine(), out double y);
            if ((x - a) * (x - a) + (y - b) * (y - b) <= r * r)
            {
                answer += 1;
            }

        }
        Console.WriteLine($"ответ = {answer}");
        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -2.5 -0.5

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        // code here
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("Введите вес : ");
            double.TryParse(Console.ReadLine(), out double input);
            if (input < 30 && input > 0)
            {
                answer += 0.2;
            }
            else if (input < 0)
            {
                Console.WriteLine("Некорректный ввод");
            }
        }
        Console.WriteLine($"ответ = {answer}");
        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"Введите координату x {i} точки");
            double.TryParse(Console.ReadLine(), out double x);
            Console.WriteLine($"Введите координату y {i} точки");
            double.TryParse(Console.ReadLine(), out double y);
            if (x * x + y * y <= r2 * r2 && x * x + y * y >= r1 * r1)
            {
                answer += 1;
            }

        }
        Console.WriteLine($"ответ = {answer}");
        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -0.5 -0.5

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

        // code here
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"Введите результат {i} спортсмена");
            double.TryParse(Console.ReadLine(), out double res);
            if (res <= norm)
            {
                answer += 1;
            }
        }
        Console.WriteLine(answer);
        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;

        // code here
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"Введите координату x {i} точки");
            double.TryParse(Console.ReadLine(), out double x);
            Console.WriteLine($"Введите координату y {i} точки");
            double.TryParse(Console.ReadLine(), out double y);
            if (x >= 0 && x <= Math.PI && Math.Sin(x) >= y && y >= 0)
            {
                Console.WriteLine("Точка принадлежит фигуре");
                answer += 1;
            }

        }
        Console.WriteLine(answer);
        // end

        // for test input in console: 1.2 0.7, 2 0.2, 0.5 0.9, -1 1.5, 0.5 0.1

        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;

        // code here
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"Введите координату x {i} точки");
            double.TryParse(Console.ReadLine(), out double x);
            Console.WriteLine($"Введите координату y {i} точки");
            double.TryParse(Console.ReadLine(), out double y);
            if (x * y > 0)
            {
                if (x > 0)
                {
                    answer1 += 1;
                }
                else
                {
                    answer3 += 1;
                }
            }
        }
        Console.WriteLine($"1 = {answer1}, 3 = {answer3}");
        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5

        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;

        // code here
        double cashe_length = 0;
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"Введите координату x {i} точки");
            double.TryParse(Console.ReadLine(), out double x);
            Console.WriteLine($"Введите координату y {i} точки");
            double.TryParse(Console.ReadLine(), out double y);
            cashe_length = Math.Sqrt(x * x + y * y);
            if (cashe_length < answerLength)
            {
                answer = i;
                answerLength = cashe_length;
            }

        }

        Console.WriteLine(answer + " = " + Math.Round(answerLength, 2));
        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -0.5

        return (answer, Math.Round(answerLength));
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        for (int i = 1; i <= n; i++)
        {

            Console.Write($"Введите результат {i} участника : ");
            double.TryParse(Console.ReadLine(), out double input);
            Console.WriteLine(input);
            if (input < answer)
            {
                answer = input;
            }
        }
        Console.WriteLine($"ответ = {answer}");
        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;
        int check = 1;
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= 4; j++)
            {
                Console.Write($"Введите {j} оценку {i} ученика : ");
                double.TryParse(Console.ReadLine(), out double input);
                if (input == 2 || input == 3)
                {
                    check = 0;
                }
            }
            answer += check;
            check = 1;
        }
        Console.WriteLine($"ответ = {answer}");


        // end

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;

        // code here;
        int check = 0;
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= 4; j++)
            {
                Console.Write($"Введите {j} оценку {i} ученика : ");
                double.TryParse(Console.ReadLine(), out double input);
                if (input == 2)
                {
                    check = 1;
                }
                avg += input;
            }
            answer += check;
            check = 0;
        }
        avg /= n * 4;
        Console.WriteLine($"Неуcпевающие ученики: {answer}");
        Console.WriteLine($"Средний балл: {avg}");
        // end

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here;
        if (r > 0)
        {
            switch (type)
            {
                case 0:
                    answer = r * r;
                    break;
                case 1:
                    answer = Math.PI * r * r;
                    break;
                case 2:
                    answer = r * r * Math.Sqrt(3) / 4;
                    break;
            }
        }
        else
        {
            answer = 0;
        }
        // end
        Console.WriteLine($"ответ = {answer}");
        return Math.Round(answer, 2);
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;
        if (A > 0 && B > 0)
        {
            switch (type)
            {
                case 0:
                    answer = A * B;
                    break;
                case 1:
                    if (A != B)
                    {
                        answer = Math.Abs(Math.PI * (A * A - B * B));
                    }
                    else
                    {
                        answer = 0;
                    }
                    break;
                case 2:
                    if (A < 2 * B)
                    {
                        answer = A * Math.Sqrt(B * B - A * A / 4) / 2;
                    }
                    else
                    {
                        answer = 0;
                    }
                    break;
            }
        }
        else
        {
            answer = 0;
        }
        // end
        Console.WriteLine($"ответ = {answer}");
        return Math.Round(answer, 2);
    }
    #endregion

    #region Level 3
    public double Task_3_1()
    {
        double answer = 0;

        // code here

        // end

        // for test input in console: 168, 147, 174, 154, 180, 149, 166, 160, 175, 161
        // answer should be equal to the task_2_1 answer

        return answer;
    }
    public int Task_3_2(double r, double a, double b)
    {

        int answer = 0;

        // code here

        // end


        return answer;
    }
    public double Task_3_3()
    {
        double answer = 0;
        int n = 0;

        // code here
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("Введите вес : ");
            double.TryParse(Console.ReadLine(), out double input);
            if (input != 0)
            {
                if (input < 30 && input > 0)
                {
                    answer += 0.2;
                }
                else if (input < 0)
                {
                    Console.WriteLine("Некорректный ввод");
                }
                else
                {
                    break;
                }
            }
        }
        // end
        Console.WriteLine($"ответ = {answer}");
        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5
        // answer should be equal to the task_2_3 answer

        return answer;
    }
    public int Task_3_4(double r1, double r2)
    {
        int answer = 0;

        // code here

        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -0.5 -0.5
        // answer should be equal to the task_2_4 answer

        return answer;
    }
    public int Task_3_5(double norm)
    {
        int answer = 0; //n = 0;

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
        for (int i = 1; ; i++)
        {
            Console.WriteLine($"Введите координату x {i} точки. (введите стоп для прекращения)");
            string input_x = Console.ReadLine();
            if (input_x == "stop")
            {
                break;
            }
            double.TryParse(input_x, out double x);
            Console.WriteLine($"Введите координату y {i} точки");
            double.TryParse(Console.ReadLine(), out double y);
            if (x >= 0 && x <= Math.PI && Math.Sin(x) >= y)
            {
                Console.WriteLine("Точка принадлежит фигуре");
                answer += 1;
            }

        }
        Console.WriteLine($"ответ: {answer}");
        // end

        // for test input in console: 1.2 0.7, 2 0.2, 0.5 0.9, -1 1.5, 0.5 0.1
        // answer should be equal to the task_2_6 answer

        return answer;
    }
    public (int, int) Task_3_7()
    {
        int answer1 = 0, answer3 = 0; //n = 0;

        // code here

        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5
        // answer should be equal to the task_2_7 answer

        return (answer1, answer3);
    }
    public (int, double) Task_3_8()
    {
        int answer = 0; //n = 0;
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
        //int n = 0;

        // code here
        for (int i = 1; ; i++)
        {

            Console.Write($"Введите результат {i} участника : ");
            string input = Console.ReadLine();
            if (input == "stop")
            {
                Console.WriteLine("цикл завершен");
                break;
            }
            double.TryParse(input, out double res);
            if (res < answer)
            {
                answer = res;

            }
        }
        Console.WriteLine($"ответ = {answer}");
        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5
        // answer should be equal to the task_2_9 answer

        return answer;
    }
    public int Task_3_10()
    {
        int answer = 0; // n = 0;

        // code here;

        // end

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4
        // answer should be equal to the task_2_10 answer

        return answer;
    }
    public (int, double) Task_3_11()
    {
        int answer = 0; //n = 0;
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