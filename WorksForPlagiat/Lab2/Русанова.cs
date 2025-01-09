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
        if (Math.Abs((x * x) + (y * y) - (r * r)) <= 0.001)
        {

            answer = true; //входит
        }
        else
        {
            answer = false; //не входит
        }
        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        if (y >= 0 && Math.Abs(x) + y <= 1)
        {
            answer = true;
        }
        else
        {
            answer = false;
        }
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
            if (a > b) //большее
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
            if (a < b) //меньшее
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
        double d; //min
        if (a < b) //меньшее
        {
            d = a;
        }
        else
        {
            d = b;
        }

        if (d > c) //большее
        {
            answer = d;
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
        double c = 2 * Math.Sqrt(r / Math.PI); //диаметр круга
        double d = Math.Sqrt(2 * s); //диагональ квадрата
        if (c >= d)
        {
            answer = true;
        }
        else
        {
            answer = false;
        }
        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        double c = 2 * Math.Sqrt(r / Math.PI); //диаметр круга
        double d = Math.Sqrt(s); //сторона квадрата
        if (c <= d)
        {
            answer = true;
        }
        else
        {
            answer = false;
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
            answer = x * x - 1;
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
        else if (x > 0)
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
        if (x <= -1)
        {
            answer = 1;
        }
        else if (x > 1)
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
        double h, s = 0; //рост и сумма
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("¬ведите рост ученика");
            h = double.Parse(Console.ReadLine());
            s += h;
        }
        answer = s / n; //среднее ариф
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;
        double x = 0, y = 0;
        // code here
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("¬ведите x");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("¬ведите y");
            y = double.Parse(Console.ReadLine());
            if ((x-a) * (x-a) + (y-b) * (y-b) <= r * r)
            {
                answer++;
            }
        }
        Console.WriteLine("¬ круг попало {0} точек из {1} ", answer, n);
        // end

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        // code here
        double w;
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("¬ведите вес");
            w = double.Parse(Console.ReadLine());
            if (w < 30)
            {
                answer += 0.2;
            }
        }
        answer = Math.Round(answer, 1);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here
        double a, b;
        Console.WriteLine("¬ведите количество точек");
        n = int.Parse(Console.ReadLine());
        Console.WriteLine("¬ведите радиусы");
        r1 = double.Parse(Console.ReadLine());
        r2 = double.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("¬ведите a");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("¬ведите b");
            b = double.Parse(Console.ReadLine());
            if (Math.Abs(a * a + b * b) >= r1 * r1 && Math.Abs(a * a + b * b) <= r2 * r2)
            {
                answer++;
            }
        }
        Console.WriteLine("¬ круг попало {0} точек из {1} ", answer, n);
        // end

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

        // code here
        double res;
        Console.WriteLine("¬ведите количество человек");
        n = int.Parse(Console.ReadLine());
        Console.WriteLine("¬ведите норматив");
        norm = double.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("¬ведите результат");
            res = double.Parse(Console.ReadLine());
            if (res <= norm)
            {
                answer++;
            }
        }
        Console.WriteLine("–езультат: ");
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;

        // code here
        double x, y;
        Console.WriteLine("¬ведите количество точек");
        n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("¬ведите x");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("¬ведите y");
            y = double.Parse(Console.ReadLine());
            if ((x >= 0) && (x <= Math.PI) && (y <= Math.Sin(x)))
            {
                answer++;
            }
        }
        Console.WriteLine("–езультат: ");
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;

        // code here
        double x, y;
        Console.WriteLine("¬ведите количество точек");
        n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("¬ведите x");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("¬ведите y");
            y = double.Parse(Console.ReadLine());
            if ((x > 0) && (y > 0))
            {
                answer1++;
            }
            if ((x < 0) && (y < 0))
            {
                answer3++;
            }
        }
        Console.WriteLine("–езультаты: ");
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
        double x, y, l;
        Console.WriteLine("¬ведите количество точек");
        n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("¬ведите x");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("¬ведите y");
            y = double.Parse(Console.ReadLine());
            l = Math.Sqrt(x * x + y * y);
            if (l < answerLength)
            {
                answer = i;
                answerLength = l;
            }
        }
        Console.WriteLine("–езультаты: ");
        Console.WriteLine(answer);
        Console.WriteLine(Math.Round(answerLength, 2));
        // end

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        double res;
        Console.WriteLine("¬ведите количество спортсменов");
        n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("¬ведите результат");
            res = double.Parse(Console.ReadLine());
            if (res < answer)
            {
                answer = res;
            }
        }
        Console.WriteLine("Ћучший результат: ");
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;
        double m1, m2, m3, m4;
        Console.WriteLine("¬ведите количество студенов");
        n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("¬ведите оценки");
            m1 = double.Parse(Console.ReadLine());
            m2 = double.Parse(Console.ReadLine());
            m3 = double.Parse(Console.ReadLine());
            m4 = double.Parse(Console.ReadLine());
            if (m1 > 3 && m2 > 3 && m3 > 3 && m4 > 3)
            {
                answer++;
            }
        }
        Console.WriteLine("–езультат: ");
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;

        // code here;
        double m1, m2, m3, m4, summ = 0, kol = 0;
        Console.WriteLine("¬ведите количество студенов");
        n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("¬ведите оценки");
            m1 = double.Parse(Console.ReadLine());
            m2 = double.Parse(Console.ReadLine());
            m3 = double.Parse(Console.ReadLine());
            m4 = double.Parse(Console.ReadLine());
            if (m1 < 3 || m2 < 3 || m3 < 3 || m4 < 3)
            {
                answer++;
            }
            summ += m1 + m2 + m3 + m4;
            kol += 4;
        }
        avg = summ / kol;
        Console.WriteLine("–езультаты: ");
        Console.WriteLine(answer);
        Console.WriteLine(avg);
        // end

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
                    answer = Math.Round((r * r), 2);
                    break;
                case 1:
                    answer = Math.Round((Math.PI * r * r), 2);
                    break;
                case 2:
                    answer = Math.Round(((r * r * Math.Sqrt(3)) / 4), 2);
                    break;
            }
        }
        else
        {
            answer = 0;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;
        if ((A <= 0) || (B <= 0))
        {
            return 0;
        }
        else
        {
            switch (type)
            {
                case 0:
                    answer = A * B;
                    break;
                case 1:
                    answer = Math.Abs(Math.PI * A * A - Math.PI * B * B);
                    break;
                case 2:
                    answer = Math.Sqrt(B * B - A * A / 4) * A / 2;
                    break;
            }
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
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
        bool stop = false;
        double x, y;
        for (int i = 1; ; i++)
        {
            Console.WriteLine("¬ведите x");
            stop = !double.TryParse(Console.ReadLine(), out x);
            if (stop)
            {
                break;
            }
            Console.WriteLine("¬ведите y");
            stop = !double.TryParse(Console.ReadLine(), out y);
            
            if (stop)
            {
                break;
            }
            if ((x - a) * (x - a) + (y - b) * (y - b) <= r * r)
            {
                answer++;
            }
        }
        Console.WriteLine("¬ круг попало {0} точек", answer);
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
        bool stop = false;
        double res;
        for (int i = 1; ; i++)
        {
            Console.WriteLine("¬ведите результат");
            stop = !double.TryParse(Console.ReadLine(), out res);
            if (stop)
            {
                break;
            }
            if (res <= norm)
            {
                answer++;
            }
        }
        Console.WriteLine("—только участников выполнило норматив: ");
        Console.WriteLine(answer);
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
        double x, y, l;
        bool stop = false;
        for (int i = 1; ; i++)
        {
            Console.WriteLine("¬ведите x");
            stop = !double.TryParse(Console.ReadLine(), out x);
            if (stop)
            {
                break;
            }
            Console.WriteLine("¬ведите y");
            stop = !double.TryParse(Console.ReadLine(), out y);
            if (stop)
            {
                break;
            }
            l = Math.Sqrt(x * x + y * y);
            if (l < answerLength)
            {
                answer = i;
                answerLength = l;
            }
        }
        Console.WriteLine("–езультаты: ");
        Console.WriteLine(answer);
        Console.WriteLine(Math.Round(answerLength, 2));
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
        bool stop = false;
        double m1, m2, m3, m4, summ = 0, kol = 0;
        for (int i = 1; ; i++)
        {
            Console.WriteLine("¬ведите оценки:");
            stop = !double.TryParse(Console.ReadLine(), out m1);
            if (stop)
            {
                break;
            }
            m2 = double.Parse(Console.ReadLine());
            m3 = double.Parse(Console.ReadLine());
            m4 = double.Parse(Console.ReadLine());
            if (m1 < 3 || m2 < 3 || m3 < 3 || m4 < 3)
            {
                answer++;
            }
            summ += m1 + m2 + m3 + m4;
            kol += 4;
        }
        avg = summ / kol;
        Console.WriteLine("–езультаты:");
        Console.WriteLine(answer);
        Console.WriteLine(avg);
        // end

        return (answer, avg);
    }
    #endregion
}