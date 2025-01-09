using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Formats.Asn1;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;

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
        //program.Task_2_2(5, 1, 3, 1);
        //program.Task_2_2(5, 1.5, 1.5, 1);
        //program.Task_2_2(5, 1, 3, 1);
        //program.Task_2_3(10);
        //program.Task_2_4(3, 1, 3);
        //program.Task_2_5(6, 25.2);
        //program.Task_2_6(3);
        //program.Task_2_7(3);
        //program.Task_2_8(3);
        //program.Task_2_9(6);
        //program.Task_2_10(6);
        //program.Task_2_11(6);
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
        program.Task_3_11();
        //program.Task_3_12(10, 0);
        //program.Task_3_13(10, 5, 0);
    }
    #region Level 1
    public bool Task_1_1(double x, double y)
    {
        bool answer = false;

        // code here
        if (Math.Abs(x * x + y * y - 2 * 2) <= 0.001)
        {
            answer = true;
            Console.WriteLine("Точка лежит внутри окружности");
        }
        else
        {
            answer = false;
            Console.WriteLine("Точка лежит вне окружности");
        }
        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        if (y >= 0)
        {
            if (y + Math.Abs(x) <= 1)
            {
                answer = true;
                Console.WriteLine("Точка лежит внутри треугольника");
            }
            else
            {
                answer = false;
                Console.WriteLine("Точка лежит вне треугольника");
            }
        }
        else
        {
            answer = false;
            Console.WriteLine("Точка лежит вне треугольника");
        }
        // end

        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;

        // code here
        double c = 0;
        if (a > 0)
        {
            if (a > b)
                c = a;
            else
                c = b;
        }
        if (a <= 0)
        {
            if (a < b)
                c = a;
            else
                c = b;
        }
        answer = c;
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        // code here
        if (a > b)
            answer = b;
        else
            answer = a;
        if (answer < c)
            answer = c;
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        double d, c;
        c = Math.Sqrt(s);
        d = (c * Math.Sqrt(2));
        if (d <= r)
        {
            answer = true;
            Console.WriteLine("Поместится");
        }
        else
        {
            answer = false;
            Console.WriteLine("Не поместится");
        }
        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        double d, c;
        double pi = Math.Round(Math.PI, 5);
        c = Math.Sqrt(s);
        d = 2 * Math.Sqrt(r / pi);
        if (d <= c)
        {
            answer = true;
            Console.WriteLine("Поместится");
        }
        else
        {
            answer = false;
            Console.WriteLine("Не поместится");
        }
        // end

        return answer;
    }
    public double Task_1_7(double x)
    {
        double answer = 0;

        // code here
        if (Math.Abs(x) > 1)
            answer = 1;
        else
            answer = Math.Abs(x);
        // end

        return answer;
    }
    public double Task_1_8(double x)
    {
        double answer = 0;

        // code here
        if (Math.Abs(x) >= 1)
            answer = 0;
        else
            answer = x * x - 1;
        // end

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1)
            answer = 0;
        else if (x > -1 && x <= 0)
            answer = 1 + x;
        else
            answer = 1;
        // end

        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1)
            answer = 1;
        else if (x > -1 && x < 1)
            answer = -x;
        else 
            answer = -1;
        if (x == 0)
            answer = 0;
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(int n)
    {
        double answer = 0;

        // code here
        double totalheight = 0;
        double height = 0;
        for (int i = 1; i <= n; i++)
        {
            double.TryParse(Console.ReadLine(), out height );
            totalheight += height;
        }
        answer = totalheight / n;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        // code here
        double x = 0;
        double y = 0;
        for (int i = 1; i <= n ; i++)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if (Math.Sqrt(Math.Pow((x - a), 2) + Math.Pow((y - b), 2)) <= r) 
                answer++;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;
        double weight = 0;
        // code here
        //int.TryParse(Console.ReadLine(), out n);
        for (int i = 1; i <= n; i++)
        {
            double.TryParse((Console.ReadLine()), out weight);
            if (weight < 30)
                answer += 0.2;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;
        double x = 0;
        double y = 0;
        // code here
        //int.TryParse(Console.ReadLine(), out n);
        for (int i = 1; i <= n; i++)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if(Math.Sqrt(x * x + y * y) >= r1 && Math.Sqrt(x * x + y * y) <= r2)
            {
                answer++;
            }
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;
        double res = 0;
        // code here
        //int.TryParse(Console.ReadLine(), out n);
        for (int i = 1; i <= n; i++)
        {
            double.TryParse(Console.ReadLine(), out res);
            if (res <= norm)
                answer++;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;
        double x = 0;
        double y = 0;
        double pi = Math.PI;
        // code here
        //int.TryParse(Console.ReadLine(), out n);
        for (int i = 1; i <= n; i++)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if (y >= 0 && y <= Math.Sin(x) && x >=0 && x <= pi)
                answer++;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;
        double x = 0;
        double y = 0;
        //int.TryParse(Console.ReadLine(), out n);
        // code here
        for (int i = 1; i <= n; i++)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if (x > 0 && y > 0)
                answer1++;
            if (x < 0 && y < 0)
                answer3++;
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
        double x = 0;
        double y = 0;
        double a = 0;
        // code here
        for (int i = 1; i <= n; i++)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            a = Math.Sqrt(x * x + y * y);
            if (a <= answerLength)
            {
                answerLength = a;
                answer = i;
            }
        }
        Console.WriteLine(answer);
        Console.WriteLine(answerLength);
        // end

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;
        double res = 0;
        // code here
        for (int i = 1; i <= n; i++)
        {
            double.TryParse(Console.ReadLine(), out res);
            if (res <= answer)
                answer = res;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;
        int res1 = 0;
        int res2 = 0;
        int res3 = 0;
        int res4 = 0;
        // code here;
        for (int i = 1; i <= n; i++)
        {
            int.TryParse(Console.ReadLine(), out res1);
            int.TryParse(Console.ReadLine(), out res2);
            int.TryParse(Console.ReadLine(), out res3);
            int.TryParse(Console.ReadLine(), out res4);
            if (res1 >= 4 && res2 >= 4 && res3 >= 4 && res4 >= 4)
                answer++;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;
        int res1 = 0;
        int res2 = 0;
        int res3 = 0;
        int res4 = 0;
        double s = 0;
        //int.TryParse(Console.ReadLine(), out n);
        // code here;
        for (int i = 1; i <= n; i++)
        {
            int.TryParse(Console.ReadLine(), out res1);
            int.TryParse(Console.ReadLine(), out res2);
            int.TryParse(Console.ReadLine(), out res3);
            int.TryParse(Console.ReadLine(), out res4);
            if (res1 == 2 || res2 == 2 || res3 == 2 || res4 == 2)
                answer++;
            s += res1 + res2 + res3 + res4;
        }
        avg = s / (n * 4);
        Console.WriteLine(answer);
        Console.WriteLine(avg);
        // end

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;
        // code here;
        if (r <= 0) return 0;
        switch (type)
        {
            case 0:
                answer = r * r; break;
            case 1:
                answer = r * r * Math.PI; break;
            case 2:
                answer = r * r * Math.Sqrt(3) / 4; break;
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(r);
        Console.WriteLine(type);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;
        // code here;
        if (A <= 0 || B <= 0) 
            return 0;
        switch (type)
        {
            case 0:
                answer = A * B;
                break;
            case 1:
                //if (B < A)
                //    return 0;
                answer = Math.Abs(Math.PI * B * B - Math.PI * A * A);
                break;
            case 2:
                if (B < 0.5 * A)
                    return 0;
                double h = Math.Sqrt(B * B - (0.5 * A) * (0.5 * A));
                answer = 0.5 * A * h;
                break;
        }
        answer = Math.Round(answer, 2);
        // end
        Console.WriteLine(A);
        Console.WriteLine(B);
        Console.WriteLine(type);
        Console.WriteLine(answer);
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
        double x = 0;
        double y = 0;
        // code here
        while (true)
        {
            Console.WriteLine("Введите значение x, для окончания введите 9302184:");
            double.TryParse(Console.ReadLine(), out x);
            if (x == 9302184) break;
            Console.WriteLine("Введите значение y:");
            double.TryParse(Console.ReadLine(), out y);
            if (Math.Sqrt(Math.Pow((x - a), 2) + Math.Pow((y - b), 2)) <= r)
                answer++;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }

    // code here
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
        double res = 0;
        // code here
        while (true)
        {
            Console.WriteLine("Введите результат спортсмена, для выхода нажмите 123456789:");
            double.TryParse(Console.ReadLine(), out res);
            if (res == 123456789) break;
            if (res <= norm)
                answer++;
        }
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
        double a = 0;
        double x = 0;
        double y = 0;
        int i = 1;
        while (true)
        {
            Console.WriteLine("Введите значение x, для завершения работы нажмите 555:");
            double.TryParse(Console.ReadLine(), out x);
            if (x == 555) break;
            Console.WriteLine("Введите значение y:");
            double.TryParse(Console.ReadLine(), out y);
            a = Math.Sqrt(x * x + y * y);
            if (a <= answerLength)
            {
                answerLength = a;
                answer = i;
            }
            i++;
        }
        answerLength = Math.Round(answerLength, 2);
        Console.WriteLine(answer);
        Console.WriteLine(answerLength);
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
        int res1 = 0;
        int res2 = 0;
        int res3 = 0;
        int res4 = 0;
        double s = 0;
        while (true)
        {
            Console.WriteLine("Введите результаты 1-го экзамена, для завершения нажмите 1234");
            int.TryParse(Console.ReadLine(), out res1);
            if (res1 == 1234) break;
            Console.WriteLine("Введите результаты 2-го экзамена:");
            int.TryParse(Console.ReadLine(), out res2);
            Console.WriteLine("Введите результаты 3-го экзамена:");
            int.TryParse(Console.ReadLine(), out res3);
            Console.WriteLine("Введите результаты 4-го экзамена:");
            int.TryParse(Console.ReadLine(), out res4);
            n++;
            if (res1 == 2 || res2 == 2 || res3 == 2 || res4 == 2)
                answer++;
            s += res1 + res2 + res3 + res4;
        }
        avg = s / (n * 4);
        Console.WriteLine(answer);
        Console.WriteLine(avg);
        // end

        return (answer, avg);
    }
    #endregion
}