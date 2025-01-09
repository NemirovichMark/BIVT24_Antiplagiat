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
        if (Math.Abs(x * x + y * y - r * r) <= 0.001) {
            answer = true;
        }
        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        if (y >= 0 && y+Math.Abs(x)<=1) { answer = true; }
        // end

        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;

        // code here
        if (a > 0 && a > b)
        {
            answer = a;
        }
        else if (a>0)
        {
            answer = b;
        }
        else if (a<b)
        {
            answer = a;
        }
        else
        {
            answer = b;
        }
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        // code here
        double m = a;
        if (b < m)
        {
            m = b;
        }
        if (m > c)
        {
            answer = m;
        }
        else
        {
            answer = c;
        }
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        if (s <= 2*r/Math.PI)
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
        if (4*r/Math.PI <= s)
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
        if (Math.Abs(x) >=1)
        {
            answer = 0;
        }
        else
        {
            answer = x * x - 1;
        }
        // end

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        // code here
        if (x<=-1)
        {
            answer = 0;
        }
        else if (x>0)
        {
            answer = 1;
        }
        else
        {
            answer = 1 + x;
        }
        // end

        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;

        // code here
        if (x<= -1)
        {
            answer = 1;
        }
        else if (x>1)
        {
            answer = -1;
        }
        else
        {
            answer = -x;
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
        double s = 0;
        double r = 0;
        Console.WriteLine("Введите рост ученика: ");
        for (int i = 1; i<= n; i++)
        {   
            double.TryParse(Console.ReadLine(), out r);
            s = s + r;
        }
        answer = s / n;
        Console.WriteLine("Средний рост: {0}", answer);
        // end

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        // code here
        double x = 0, y = 0;
        Console.WriteLine("Введите координаты точек: ");
        for (int i = 1; i<=n;i++)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if ((x-a)*(x-a) + (y-b)*(y-b) <= r*r)
            {
                answer += 1;
            }
        }
        Console.WriteLine("В окружность попали {0} из {1} точек", answer, n);
        // end

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        // code here
        Console.WriteLine("Введите вес:");
        double w = 0;
        for (int i = 1; i<=n; i++)
        {
            double.TryParse(Console.ReadLine(), out w);
            if (w < 30)
            {
                answer += 200;
            }
        }
        answer = answer / 1000;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here
        double x = 0, y = 0;
        Console.WriteLine("Введите координаты точек: ");
        for (int i = 1; i <= n; i++)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if (x*x + y*y <= r2 * r2 && x*x+y*y >= r1*r1)
            {
                answer += 1;
            }
        }
        Console.WriteLine("В кольцо попали {0} из {1} точек", answer, n);
        // end

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

        // code here
        Console.WriteLine("Введите результаты:");
        for (int i = 1; i<= n; i++)
        {

            double.TryParse(Console.ReadLine(), out double res);
            if (res <= norm)
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
        double x = 0, y = 0;
        Console.WriteLine("Введите координаты точек");
        for (int i = 1;i<=n;i++)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if (!(x <0 || x > Math.PI) && y <= Math.Sin(x) && y >= 0)
            {
                answer ++;
            }
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
        double x = 0, y = 0;
        Console.WriteLine("Введите координаты точек: ");
        for (int i = 1; i <= n; i++)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if (x > 0 && y > 0)
            {
                answer1++;
                Console.WriteLine("1-й квадрант");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("2-й квадрант");
            }
            else if (x< 0 && y < 0)
            {
                answer3++;
                Console.WriteLine("3-й квадрант");
            }
            else
            {
                Console.WriteLine("4-й квадрант");
            }
        }
        Console.WriteLine("1 квадрант: {0} точек", answer1);
        Console.WriteLine("3 квадрант: {0} точек", answer3);
        // end

        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;

        // code here
        Console.WriteLine("Введите координаты точек:");
        for (int i = 1; i<=n;i++)
        {
            double.TryParse(Console.ReadLine(), out double x);
            double.TryParse(Console.ReadLine(), out double y);
            if (Math.Sqrt(x * x + y * y) < answerLength)
            {
                answerLength = Math.Round(Math.Sqrt(x * x + y * y),2);
                answer = i;
            }
        }
        Console.WriteLine("Номер точки: {0}, расстояние до начала координат: {1}", answer, answerLength);
        // end

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        Console.WriteLine("Введите результаты спортсменов:");
        for (int i = 1; i<= n; i++)
        {
            double.TryParse(Console.ReadLine(), out double res);
            if (res < answer)
            {
                answer = res;
            }
        }
        Console.WriteLine("Лучший результат: {0}", answer);
        // end

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;
        Console.WriteLine("Введите 4 оценки каждого ученика:");
        for (int i = 1; i <= n; i++)
        {
            int.TryParse(Console.ReadLine(), out int g1);
            int.TryParse(Console.ReadLine(), out int g2);
            int.TryParse(Console.ReadLine(), out int g3);
            int.TryParse(Console.ReadLine(), out int g4);
            if (g1 > 3 && g2 > 3 && g3 > 3 && g4 > 3)
            {
                answer++;
            }

        }
        Console.WriteLine("Количество учеников: {0}", answer);
        // end

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;

        // code here;
        double s = 0;
        Console.WriteLine("Введите 4 оценки каждого ученика:");
        for (int i = 1; i <= n; i++)
        {
            int.TryParse(Console.ReadLine(), out int g1);
            int.TryParse(Console.ReadLine(), out int g2);
            int.TryParse(Console.ReadLine(), out int g3);
            int.TryParse(Console.ReadLine(), out int g4);
            s += g1;
            s += g2;
            s += g3;
            s += g4;
            if (g1 < 3 || g2 < 3 || g3 < 3 || g4 < 3)
            {
                answer++;
            }

        }
        avg = s / (n*4);
        Console.WriteLine("Количество неуспевающих: {0}, средний балл: {1}", answer, avg);
        // end

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here;
        if (r<0)
        {
            return 0;
        }
        switch (type)
        {
            case 0:

                answer = Math.Round(r * r,2);
                break;
            case 1:
                answer = Math.Round(Math.PI*r*r,2);
                break;
            case 2:
                answer = Math.Round((r * r * Math.Sqrt(3)) / 4, 2);
                break;
            default:
                return 0;
        }
        // end

        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;
        if (A < 0 || B < 0)
        {
            return 0;
        }
        switch (type)
        {
            case 0:
                answer = Math.Round(A * B, 2);
                break;
            case 1:
                answer = Math.Round(Math.Abs(Math.PI * A * A - Math.PI * B * B), 2);
                break;
            case 2:
                if (B*B >= (A*A/4))
                {
                    answer = Math.Round((A / 2) * Math.Sqrt(B * B - (A * A / 4)), 2);
                }
                else
                {
                    return 0;
                }
                break;
            default:
                return 0;
        }
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

        // end

        return answer;
    }
    public double Task_3_3()
    {
        double answer = 0;
        int n = 0;

        // code here
        double w = 0;
        Console.WriteLine("Введите вес, для окончания 0:");
        do
        {
            double.TryParse(Console.ReadLine(), out w);

            if (w == 0) {
                break;
            }
            if (w < 30)
            {
                answer += 200;
            }

        } while (w > 0);
        
        answer = answer / 1000;
        Console.WriteLine(answer);
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

        // end

        return answer;
    }
    public int Task_3_6()
    {
        int answer = 0, n = 0;

        // code here
        double x = 0, y = 0;
        Console.WriteLine("Введите координаты точек, для окончания 1000:");
        do
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if (x==1000 || y==1000)
            {
                break;
            }
            if (!(x < 0 || x > Math.PI) && y <= Math.Sin(x) && y >= 0)
            {
                answer++;
            }
        } while (x < 1000 && y < 1000);
        Console.WriteLine("Количество точек: {0}", answer);

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

        // end

        return (answer, answerLength);
    }
    public double Task_3_9()
    {
        double answer = double.MaxValue;
        int n = 0;

        // code here
        double res = 0;
        Console.WriteLine("Введите результаты спортсменов, для окончания - '0':");
        do
        {
            double.TryParse(Console.ReadLine(), out res);
            if (res == 0)
            {
                break;
            }
            if (res < answer)
            {
                answer = res;
            }
        } while (res > 0);
        Console.WriteLine("Лучший результат: {0}", answer);
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