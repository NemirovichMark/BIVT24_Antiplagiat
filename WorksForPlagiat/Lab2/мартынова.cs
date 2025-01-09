using Microsoft.VisualBasic;
using System;
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
        //program.Task_2_3(6);
        //program.Task_2_4(3, 1, 3);
        //program.Task_2_5(10, 30);
        //program.Task_2_6(3);
        //program.Task_2_7(3);
        //program.Task_2_8(3);
        //program.Task_2_9(6);
        //program.Task_2_10(6);
        //program.Task_2_11(6);
        //program.Task_2_12(0, 2);
        program.Task_2_13(10, 5, 0);
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
        program.Task_3_11();
        //program.Task_3_12(10, 0);
        //program.Task_3_13(10, 5, 0);
    }
    #region Level 1
    public bool Task_1_1(double x, double y)
    {
        bool answer = false;

        // code here
        double r = 2;


        if (Math.Abs(x * x + y * y - r * r) < 0.001)
            return true;
        else
        {
            return false;
        }
        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        if (y >= 0 && y + Math.Abs(x) < 1)
            return true;
        else
            return false;
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
                return a;
            }
            else return b;
        }
        else
        {
            if (a < b) return a;
            else return b;
        }
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        // code here
        if (a < b)
        {
            if (c > a) return c;
            else return a;
        }
        else
        {
            if (c > b) return c;
            else return b;
        }
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        if (2 * Math.Sqrt(r / Math.PI) >= Math.Sqrt(s + s))
            answer = true;
        else
            answer = false;
        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        if (2 * Math.Sqrt(r / Math.PI) <= Math.Sqrt(s))
            answer = true;
        else
            answer = false;
        // end

        return answer;
    }
    public double Task_1_7(double x)
    {
        double answer = 0;

        // code here
        if (Math.Abs(x) > 1) 
            return 1;
        else
            return Math.Abs(x);
        // end

        return answer;
    }
    public double Task_1_8(double x)
    {
        double answer = 0;

        // code here
        if (Math.Abs(x) >= 1) 
            return 0;
        else
            return x * x - 1;
        // end

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1) 
            return 0;
        else if (x > 0) 
            return 1;
        else
            return x + 1;
        // end

        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1) return 1;
        else if (-1 < x && x <= 1) return -x;
        else if (x > 1) return -1;
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(int n)
    {
        double answer = 0;

        // code here
        for (int i = 1; i <= n; i++)
        {
            answer += double.Parse(Console.ReadLine());
        }
        answer /= n;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        // code here
        for (int i = 1; i <= n; i++)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double s = Math.Sqrt((a - x) * (a - x) + (b - y) * (b - y));
            if (s <= r) answer += 1;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }

    public double Task_2_3(int n)
        
    {
        double answer = 0;

        // code here
        for (int i = 1; i <= n; i++)
        {
            double weight = double.Parse(Console.ReadLine());
            if (weight < 30) answer += 1;
        }
        answer *= 0.2;
        Console.WriteLine(Math.Round(answer,1));
        // end
    
    return answer;
}

public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here
        for (int i = 1; i <= n; i++)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double s = Math.Sqrt((x) * (x) + (y) * (y));
            if (s >= r1 && s <= r2) answer += 1;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

        // code here
        for (int i = 1; i <= n; i++)
        {
            double result = double.Parse(Console.ReadLine());
            if (result <= norm) answer += 1;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;

        // code here
        for (int i = 1; i <= n; i++)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if (x >= 0 && x <= Math.PI && y <= Math.Sin(x) && y >= 0) answer += 1;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;

        // code here
        for (int i = 1; i <= n; i++)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if (x > 0 && y > 0) answer1 += 1;
            else if (x < 0 && y < 0) answer3 += 1;
        }
        Console.WriteLine(answer1);
        Console.WriteLine(answer3);
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
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double s = Math.Sqrt(x*x + y*y);
            if (s < answerLength)
            {
                answer = i;
                answerLength = s;
            }
        }
        Console.WriteLine(answer);
        Console.WriteLine(Math.Round(answerLength, 2));
        // end

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        for (int i = 1; i <= n; i++)
        {
            double result = double.Parse(Console.ReadLine());
            if (result < answer) answer = result;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;
        for (int i = 1; i <= n; i++)
        {
            int count_23 = 0;
            for (int j = 1; j <= 4; j++)
            {
                int mark = int.Parse(Console.ReadLine());
                if (mark == 2 || mark == 3) count_23++;
            }
            if (count_23 == 0) answer++;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;

        // code here;
        for (int i = 1; i <= n; i++)
        {
            int count_2 = 0;
            for (int j = 1; j <= 4; j++)
            {
                int mark = int.Parse(Console.ReadLine());
                if (mark == 2) count_2++;
                avg += mark;
            }
            if (count_2 != 0) answer++;
        }
        avg /= (n * 4);
        Console.WriteLine(answer);
        Console.WriteLine(Math.Round(avg, 2));
        // end

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here;
        if (r < 0) return 0;
        switch (type)
        {
            case 0:
                answer = r * r;
                break;
            case 1:
                answer = r * r * Math.PI;
                break;
            case 2:
                answer = (r * r * Math.Sin(Math.PI / 3)) / 2;
                break;
            default:
                answer = 0;
                break;
        }
        
        answer = Math.Round(answer,2);
        
        // end

        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        // code here:
        if (A <= 0 || B <= 0) return 0;
        switch (type)
        {
            case 0:
                answer = A * B;
                break;
            case 1:
                answer = Math.Abs(Math.PI * A * A - Math.PI * B * B);
                break;
            case 2:
                double p = (A + B + B) / 2;
                answer = Math.Sqrt(p * (p - A) * (p - B) * (p - B));
                break;
            default:
                answer = 0;
                break;
        }
        answer = Math.Round(answer,2);
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

        // end

        // answer should be equal to the task_2_1 answer
        return answer;
    }
    public int Task_3_2(double r, double a, double b)
    {
        int answer = 0, n = 0;

        // code here
        Console.WriteLine("Чтобы остановить ввод данных, введите любой символ кроме цифр");
        while (true)
        {
            bool x_exists = double.TryParse(Console.ReadLine(), out double x);
            if (x_exists)
            {
                bool y_exists = double.TryParse(Console.ReadLine(), out double y);
                if (y_exists)
                {
                    double s = Math.Sqrt((a - x) * (a - x) + (b - y) * (b - y));
                    if (s <= r) answer += 1;
                }
                else
                {
                    Console.WriteLine("Ввод окончен");
                    break;
                }
            }
            else
            {
                Console.WriteLine("Ввод окончен");
                break;
            }
            
        }
        Console.WriteLine($"Ответ - {answer}");
        // end

        return answer;
    }
    public double Task_3_3()
    {
        double answer = 0;
        int n = 0;

        // code here

        // end

        return answer;
    }
    public int Task_3_4(double r1, double r2)
    {
        int answer = 0, n = 0;

        // code here

        // end

        return answer;
    }
    public int Task_3_5(double norm)
    {
        int answer = 0, n = 0;

        // code here
        Console.WriteLine("Чтобы остановить ввод данных, введите любой символ кроме цифр");
        while (true)
        {
            bool result_exists = double.TryParse(Console.ReadLine(), out double result);
            if (result_exists)
            {
                if (result <= norm && result > 0) answer += 1;
            }
            else
            {
                Console.WriteLine("Ввод окончен");
                break;
            }
        }
        Console.WriteLine($"Ответ - {answer}");
        // end

        return answer;
    }
    public int Task_3_6()
    {
        int answer = 0, n = 0;

        // code here

        // end

        return answer;
    }
    public (int, int) Task_3_7()
    {
        int answer1 = 0, answer3 = 0, n = 0;

        // code here

        // end

        return (answer1, answer3);
    }
    public (int, double) Task_3_8()
    {
        int answer = 0, n = 0;
        double answerLength = double.MaxValue;

        // code here
        int i = 0;
        Console.WriteLine("Чтобы остановить ввод данных, введите любой символ кроме цифр");
        while (true)
        {
            bool x_exists = double.TryParse(Console.ReadLine(), out double x);
            if (x_exists)
            {
                bool y_exists = double.TryParse(Console.ReadLine(), out double y);

                if (y_exists)
                {
                    i++;
                    double s = Math.Sqrt(x * x + y * y);
                    if (s < answerLength)
                    {
                        answer = i;
                        answerLength = s;
                    }
                }
                else
                {
                    Console.WriteLine("Ввод окончен");
                    break;
                }
            }
            else
            {
                Console.WriteLine("Ввод окончен");
                break;
            }
            
            
        }
        Console.WriteLine($"Номер точки - {answer}");
        Console.WriteLine($"Расстояние до начала координат - {Math.Round(answerLength, 2)}");
        // end

        return (answer, answerLength);
    }
    public double Task_3_9()
    {
        double answer = double.MaxValue;
        int n = 0;

        // code here

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
        bool f = true;
        Console.WriteLine("Чтобы остановить ввод данных, введите любой символ кроме цифр или число меньше 0 или больше 5");
        while (true)
        {
            int count_2 = 0;
            for (int j = 1; j <= 4; j++)
            {
                bool mark_exists = int.TryParse(Console.ReadLine(), out int mark);
                if (mark < 0 || mark > 5 || !mark_exists)
                {
                    Console.WriteLine("Ввод окончен");
                    f = false;
                    break;
                }
                else if (mark == 2) count_2++;
                avg += mark;
                n++;

            }
            if (count_2 != 0) answer++;
            if (!f) break;
            
        }
        avg /= n;
        Console.WriteLine($"Неуспевающие студенты - {answer}");
        Console.WriteLine($"Средний балл - {Math.Round(avg, 2)}");
        // end

        return (answer, avg);
    }
    #endregion
}