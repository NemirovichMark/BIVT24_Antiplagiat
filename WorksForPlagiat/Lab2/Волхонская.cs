using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Runtime.InteropServices;
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
        //program.Task_2_2(5, 3, 2, 1);
        //program.Task_2_2(5, 1.5, 1.5, 1);
        //program.Task_2_2(5, 1, 3, 1);
        //program.Task_2_3(6);
        //program.Task_2_4(5, 1, 3);
        //program.Task_2_5(10, 30);
        //program.Task_2_6(5);
        //program.Task_2_7(5);
        //program.Task_2_8(5);
        //program.Task_2_9(6);
        //program.Task_2_10(8);
        //program.Task_2_11(8);
        //program.Task_2_12(10, 0);
        //program.Task_2_13(10, 5, 0);
        //program.Task_3_1();
        //program.Task_3_2(3, 2, 1);
        //program.Task_3_2(1.5, 1.5, 1);
        //program.Task_3_2(1, 3, 1);
        program.Task_3_3();
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
        if ((x * x + y * y) <= r * r && Math.Abs(x * x + y * y - r * r) <= 0.001)
           answer = true;
        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        if (y >= 0 && y + Math.Abs(x) <= 1)  answer = true;
        
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
            c = a;
            if (c < b) c = b;
        }
        if (a<=0)
        {
            c = a;
            if (c > b) c = b;
        }
        answer = c;
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        // code here
        double z = a;
        if (z > b) z = b;
        if (z < c) z = c;
        answer = z;
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        if (r <= 0 && s <= 0) answer = false;
        double sc = Math.Sqrt(r / (Math.PI));
        double sv = Math.Sqrt(s/2);
        Console.WriteLine(sc);
        Console.WriteLine(sv);

        if (sc >= sv) answer = true;
        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        if (r <= 0 && s <= 0) answer = false;
        double sc = Math.Sqrt(r / (Math.PI));
        double sv = Math.Sqrt(s) / 2;
        Console.WriteLine(sc);
        Console.WriteLine(sv);

        if (sc <= sv) answer = true;
        // end

        return answer;
    }
    public double Task_1_7(double x)
    {
        double answer = 0;

        // code here
        if (Math.Abs(x) <= 1) answer = Math.Abs(x);
        else answer = 1;
        // end

        return answer;
    }
    public double Task_1_8(double x)
    {
        double answer = 0;

        // code here
        if (Math.Abs(x) >= 1) answer = 0;
        else if (Math.Abs(x) < 1) answer = x*x-1; 
         // end

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1) answer = 0;
        else if (x > 0) answer = 1;
        else answer = 1 + x;
        // end

        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1) answer = 1;
        else if (x > 1) answer = -1;
        else answer = -x;
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
        for (int i=0; i < n; i++)
        {
            Console.WriteLine("¬ведите рост ученика");
            double.TryParse(Console.ReadLine(), out double r);
            s += r;
        }
        answer = s / n;
        Console.WriteLine(answer);
        //answer = 163,4
        // end

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        // code here
        int j = 0;
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("¬ведите x");
            double.TryParse(Console.ReadLine(), out double x);
            Console.WriteLine("¬ведите y");
            double.TryParse(Console.ReadLine(), out double y);
            if (((x - a) * (x - a) + (y - b) * (y - b)) <= r * r) j++;
        }
        Console.WriteLine(j);
 
         // end

            return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        // code here
        double s = 0;
        for (int i=0; i < n; i++)
        {
            Console.WriteLine("введите вес");
            double.TryParse(Console.ReadLine(), out double x);
            if (x < 30.0) s += 0.2;
        }
        Console.WriteLine(Math.Round(s));
        // end

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here
        int j = 0;
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("введите координаты x");
            double.TryParse(Console.ReadLine(), out double x);
            Console.WriteLine("введите координаты y");
            double.TryParse(Console.ReadLine(), out double y);
            if (x * x + y * y <= r2 * r2 && x * x + y * y >= r1 * r1) j++;
        }
        Console.WriteLine(j);
            // end

            return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

        // code here
        int j = 0;
        for (int i=0;i<n;i++)
        {
            Console.WriteLine("введите результат");
            double.TryParse(Console.ReadLine(), out double x);
            if (x <= norm) j++;
        }
        Console.WriteLine(j);
        // end

        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;

        // code here
        int j = 0;
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("введите координаты x");
            double.TryParse(Console.ReadLine(), out double x);
            Console.WriteLine("введите координаты y");
            double.TryParse(Console.ReadLine(), out double y);
            if (x >= 0 && x <= Math.PI && y >= 0 && y <= Math.Sin(x)) j++;
        }
        Console.WriteLine(j);
            // end

            return answer;
    }
    public (int, int) Task_2_7 (int n)
    {
        int answer1 = 0;
        int answer3 = 0;

        // code here
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("введите координаты x");
            double.TryParse(Console.ReadLine(), out double x);
            Console.WriteLine("введите координаты y");
            double.TryParse(Console.ReadLine(), out double y);
            if (x > 0 && y > 0)
            {
                Console.WriteLine("квадрант 1");
                answer1++;
            }
            if (x > 0 && y < 0) Console.WriteLine("квадрант 2");
            if (x < 0 && y > 0)
            {
                Console.WriteLine("квадрант 3");
                answer3++;
                if (x < 0 && y < 0) Console.WriteLine("квадрант 4");
            }
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
        answerLength = 12000000;
        answer = 0;
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("введите координаты x");
            double.TryParse(Console.ReadLine(), out double x);
            Console.WriteLine("введите координаты y");
            double.TryParse(Console.ReadLine(), out double y);
            if (Math.Sqrt(x * x + y * y) < answerLength)
            {
                answer = i+1;
                answerLength = Math.Sqrt(x * x + y * y);
            }
        }
        Console.WriteLine( (answer,Math.Round(answerLength,2)));
            // end

            return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        double j = 1000000;
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("введите результаты");
            double.TryParse(Console.ReadLine(), out double x);
            if (x < j) j = x;
        }
        Console.WriteLine(j);
        // end
        
            return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;
        int j = 0;
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("введите оценку 1");
            double.TryParse(Console.ReadLine(), out double x);
            Console.WriteLine("введите оценку 2");
            double.TryParse(Console.ReadLine(), out double y);
            Console.WriteLine("введите оценку 3");
            double.TryParse(Console.ReadLine(), out double a);
            Console.WriteLine("введите оценку 4");
            double.TryParse(Console.ReadLine(), out double b);
            if (x > 3 && y > 3 && a > 3 && b > 3) j++;
        }
        Console.WriteLine(j);
        // end

            return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;

        // code here;
        int j = 0;
        double srz = 0;
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("введите оценку 1");
            double.TryParse(Console.ReadLine(), out double x);
            Console.WriteLine("введите оценку 2");
            double.TryParse(Console.ReadLine(), out double y);
            Console.WriteLine("введите оценку 3");
            double.TryParse(Console.ReadLine(), out double a);
            Console.WriteLine("введите оценку 4");
            double.TryParse(Console.ReadLine(), out double b);
            if (x == 2 || y == 2 || a ==2 || b == 2) j++;
            srz += x + y + a + b;
        }
        avg = srz/(4*n);
        Console.WriteLine(j);
        Console.WriteLine(avg);
        // end

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here;
        if (r < 0)
        {
            answer = 0;
        }
        else
        {
            switch (type)
            {
                case 0:
                    answer = Math.Round(r * r, 2); break;
                case 1:
                    answer = Math.Round(Math.PI * r * r, 2); break;
                case 2:
                    answer = Math.Round(r * r * Math.Sqrt(3) / 4, 2); break;
                defailt:
                    answer = 0; break;

            }
        }
            // end

            return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;
        if (A > 0 && B>0)
        {
            switch (type)
            {
                case 0:
                    answer = Math.Round((A*B),2); break;
                case 1:
                    answer = Math.Round(Math.Abs(Math.PI*A*A- Math.PI * B *B), 2); break;
                case 2:
                    answer = answer = Math.Round(A / 2 * Math.Sqrt(B * B - A * A / 4),2); break;
                defailt:
                    answer = 0; break;

            }
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
        double x;
        double s = -0.2;
        do
        {
            Console.WriteLine("введите вес (нажмите два раза Enter, чтобы закончить ввод данных)");
            x = double.Parse(Console.ReadLine());
              if (x < 30.0) s += 0.2;
            
        } while (x > 0);
        Console.WriteLine(Math.Round(s,2));
        // ещЄ вариант, который € использовала в 3.6 и 3.9
        // в этом способе в конце надо прописать 0, а в следующем написать что угодно кроме чисел
        // double x;
        //double s= 0;
        //{
        // Console.WriteLine("введите вес (нажмите два раза Enter, чтобы закончить ввод данных)");
        //while (double.TryParse(Console.Readline(), out x))
        //{ if (x<30.0) s+=0.2;
        //}
        //Console.WriteLine(Math.Round(s,2));
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
        int j = 0;
        {
            Console.WriteLine("введите координаты x и y (нажмите два раза Enter, чтобы закончить ввод данных)");
            while(double.TryParse(Console.ReadLine(), out double x) && (double.TryParse(Console.ReadLine(), out double y)))
            {
                if (x >= 0 && x <= Math.PI && y >= 0 && y <= Math.Sin(x)) j++;
            }
            
            
        }
        Console.WriteLine(j);
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
        double j = 1000000;
        {
            Console.WriteLine("введите результаты");
            while(double.TryParse(Console.ReadLine(), out double x))
            {
                if (x < j) j = x;
            }
            
        }
        Console.WriteLine(j);
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