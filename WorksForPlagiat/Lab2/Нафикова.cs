using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static System.Formats.Asn1.AsnWriter;

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
        //program.Task_2_6(4);
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
        if (Math.Abs(x * x + y * y - r * r) <= 0.001)
        {
            answer = !answer;
            Console.WriteLine(answer);
        }
        
        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        if (y>=0 && y+Math.Abs(x)<=1)
        {
            answer = !answer;
            Console.WriteLine(answer);
        }
        // end

        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;

        // code here
        if (a>0)
        {
            if (a>b)
            {
                answer = a;
                Console.WriteLine(answer);
            }
            else
            {
                answer = b;
                Console.WriteLine(answer);
            }
        }
        else
        {
            if (a<b)
            {
                answer = a;
                Console.WriteLine(answer);
            }
            else
            {
                answer = b;
                Console.WriteLine(answer);
            }
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
            if (a > c)
                answer = a;
            else
                answer = c;
        }
        else
        {
            if (b > c)
                answer = b;
            else
                answer = c;
        }
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        if (Math.Sqrt(r/Math.PI)>=Math.Sqrt(s/2))
        {
            answer = true;
            Console.WriteLine(answer);
        }
      

        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        if (Math.Sqrt(r / Math.PI) <= Math.Sqrt(s )/2)
        {
            answer = true;
            Console.WriteLine(answer);
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
        if (Math.Abs(x) <= 1)
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
        if (Math.Abs(x) < 1)
            answer = x*x-1;
        // end

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1)
            answer = 0;
        if (-1 < x && x <= 0)
            answer = 1 + x;
        if (x > 0)
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
        if (-1 < x && x <= 1)
            answer = -x;
        if (x > 1)
            answer = -1;

        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(int n)
    {
        double answer = 0;

        // code here
        double  r, s = 0;
        for (int i=1; i<=n;i++)
        {
            double.TryParse(Console.ReadLine(), out r);
            s = s + r;
        }
        answer = s / n;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        // code here
       double x, y;
        int i;
        for (i = 1; i <= n; i++)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if ((x - a)*(x - a) + (y - b)*(y - b) <= (r*r))
                answer++;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        // code here
        double ves, s=0;
        for (int i = 1; i <= 30; i++)
        {
            double.TryParse(Console.ReadLine(), out ves);
            if (ves < 30)
            {
                s += 200;
            }
        }answer = s / 1000;
        Console.WriteLine(answer);

        // end

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here
        double x, y;
        for (int i = 1; i <= n; i++)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if (x * x + y * y >= r1 * r1 && x * x + y * y <= r2 * r2)
                answer++;
        }
        Console.WriteLine(answer);   

        // end

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

        // code here
        double res;
        for (int i = 1;i <= n; i++) 
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

        // code here
        double x, y;
        for (int i = 1; i <= n; i++)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if (y >= 0 && y <= Math.Abs(Math.Sin(x))) 
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

        // code here
        double x, y;
        for (int i = 1; i <= n; i++)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if (x > 0 && y > 0)
            {
                answer1++;
                Console.WriteLine("1");
            }
            if (x > 0 && y < 0)
                Console.WriteLine("2");
            if (x < 0 && y < 0)
            {
                Console.WriteLine("3");
                answer3++;
            }
            else
                Console.WriteLine("4");
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
        double x, y;
        for (int i = 1; i <= n; i++)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if (Math.Sqrt(x * x + y * y) <= answerLength)
            {
                answer = i;
                answerLength = Math.Round(Math.Sqrt(x * x + y * y),2);
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

            // code here
            double res;
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

        // code here;
        double mark1, mark2, mark3, mark4;
        for (int i =1;i<=n; i++)
        {
            double.TryParse(Console.ReadLine(), out mark1);
            double.TryParse(Console.ReadLine(), out mark2);
            double.TryParse(Console.ReadLine(), out mark3);
            double.TryParse(Console.ReadLine(), out mark4);
            if (mark1>=4 && mark2 >= 4 && mark3 >= 4 && mark4 >= 4 )
            {
                answer++;
            }
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
        double mark1, mark2, mark3, mark4, s=0;
        for (int i = 1; i <= n; i++)
        {
            double.TryParse(Console.ReadLine(), out mark1);
            double.TryParse(Console.ReadLine(), out mark2);
            double.TryParse(Console.ReadLine(), out mark3);
            double.TryParse(Console.ReadLine(), out mark4);
            s = s+ (mark1 + mark2 + mark3 + mark4);
            if (mark1 <3 || mark2 <3 || mark3 <3 || mark4 <3)
            {
                answer++;
            }
        }
        avg = s/n/4;
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
                    answer = r * r;
                    Console.WriteLine(answer);
                    break;
                case 1:
                    answer = r * r * Math.PI;
                    Console.WriteLine(answer);
                    break;
                case 2:
                    answer = r * r * Math.Sqrt(3) / 4;
                    Console.WriteLine(answer);
                    break;
                default:
                    Console.WriteLine();
                    break;
            }
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
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
                    answer = A * B;
                    Console.WriteLine(answer);
                    break;
                case 1:
                    answer = Math.Abs(Math.PI * A * A - Math.PI * B * B);
                    Console.WriteLine(answer);
                    break;
                case 2:
                    answer = (A * Math.Sqrt(B * B - A * A / 4)) / 2;
                    Console.WriteLine(answer);
                    break;
                default :
                    Console.WriteLine();
                    break;

            }
        }answer = Math.Round(answer, 2);
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
        double r, s = 0;
        string stop1;
        int k = 0;
        for (int i = 1; ; i++)
        {
            stop1= Console.ReadLine();
            double.TryParse(stop1, out r);
            if (stop1 == "stop")
                break;
            else 
                s = s + r;
                k++;
        }
        answer = s /k;
        Console.WriteLine(answer);
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

        // end

        return answer;
    }
    public int Task_3_4(double r1, double r2)
    {
        int answer = 0;

        // code here
        double x, y;
        string stop1, stop2;
        for (int i = 1; ; i++)
        {
            stop1 = Console.ReadLine();
            double.TryParse(stop1, out x);
            stop2 = Console.ReadLine();
            double.TryParse(stop1, out y);
            if (stop1 == "stop")
                break;
            if (x * x + y * y >= r1 * r1 && x * x + y * y <= r2 * r2)
                answer++;
        }
        Console.WriteLine(answer);
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

        // end

        return answer;
    }
    public (int, int) Task_3_7()
    {
        int answer1 = 0, answer3 = 0;

        // code here
        double x, y, k = 0;
        int i = 0;
        for (; ; i++)
        {
            double.TryParse(Console.ReadLine(), out x);
            if (x == 100000)
                break;
            double.TryParse(Console.ReadLine(), out y);
            if (x > 0 && y > 0)
            {
                k = 1;
                answer1++;
            }
            if (x > 0 && y < 0)
                k = 2;
            if (x < 0 && y < 0)
            {
                k = 3;
                answer3++;
            }
            else
                k = 4;
        }
        Console.WriteLine(answer1);
        Console.WriteLine(answer3);
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

        // end

        return answer;
    }
    public int Task_3_10()
    {
        int answer = 0, n = 0;

        // code here;
        double mark1, mark2, mark3, mark4;
        int i = 0;
        string stop1;
        for (;; i++)
        {
            double.TryParse(Console.ReadLine(), out mark1);
            if (mark1 == 6)
                break;
            double.TryParse(Console.ReadLine(), out mark2);
            double.TryParse(Console.ReadLine(), out mark3);
            double.TryParse(Console.ReadLine(), out mark4);
            if (mark1 >= 4 && mark2 >= 4 && mark3 >= 4 && mark4 >= 4)
            {
                answer++;
            }
        }
        Console.WriteLine(answer);
        
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