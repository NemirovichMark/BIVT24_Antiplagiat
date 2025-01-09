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
        int r = 2;

        if (Math.Abs(x * x + y * y - r * r) <= 0.001)
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
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        
        if ((y >= 0) && (y + Math.Abs(x) <= 1))
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

         if (a > 0)
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
            if (a < b)
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

        if (a < b)
        {
            if (a > c)
            {
                answer = a;
            }
            else
            {
                answer = c;
            }
        }
        else 
        {
            if (b > c)
            {
                answer = b;
            } 
            else 
            {
                answer = c;
            }
        }

        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here

        if (Math.Sqrt(s)*Math.Sqrt(2)<=2*Math.Sqrt(r/Math.PI))
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

        if (Math.Sqrt(s)>=2*Math.Sqrt(r/Math.PI))
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

        if (Math.Abs(x)> 1)
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

        if (Math.Abs(x) >= 1) { answer = 0;  }
        else { answer = x * x - 1; }

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
        else if ((x > -1) && (x <= 0))
        {
            answer = 1 + x;
        }
        else
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

        if (x <=-1)
        {
            answer = 1;
        }
        else if (-1 < x && x<= 1)
        {
            answer = -1*x;
        }
        else if (x > 1)
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
        double sum= 0;
        for (int i = 1; i<=n; i++)
        {
            string str = Console.ReadLine();
            double height = double.Parse(str);
            sum += height;
        }
        answer = sum/n;
        Console.WriteLine(answer);

        // end

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        // code here
        for (int i = 0; i < n; i += 1)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double s = Math.Sqrt(Math.Pow(x - a, 2) + Math.Pow(y - b, 2));
            if (s <= r)
            {
                answer += 1;
            }
        }
        Console.WriteLine(answer);

        // end

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        // code here

        double weight = 0, col = 0;
        for (int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out weight);

            if (weight < 30)
            {
                col += 200;
            }
        }
        answer = col / 1000;
        Console.WriteLine(answer);

        // end

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here

        double x = 0, y = 0;
        for (int t = 0; t < n; t++)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if (((x * x + y * y) >= r1 * r1) && ((x * x + y * y) <= r2 * r2))
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

        // code here

        for(int i = 0; i < n; i++)
        {
            double res = double.Parse(Console.ReadLine());
            if (res  <= norm)
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
        for (int i = 0; i < n; i++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            if (x >= 0 && x <= Math.PI && y >= 0 && y <= Math.Sin(x))
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

        double x = 0, y = 0;
        for (int i = 0; i < n; i++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            if (x>0 && y > 0)
            {
                answer1++;
                Console.WriteLine("1");
            }
            if (x < 0 && y > 0)
            {
                Console.WriteLine("2");
            }
            if (x < 0 && y < 0)
            {
                answer3++;
                Console.WriteLine("3");
            }
            if (x > 0 && y < 0)
            {
                Console.WriteLine("4");
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

        double x = 0, y = 0;
        x = double.Parse(Console.ReadLine());
        y = double.Parse(Console.ReadLine());
        answer = 1;
        answerLength = Math.Sqrt(x*x + y*y);

        for (int i = 2; i <= n; i++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            if (Math.Sqrt(x * x + y * y) <= answerLength)
            {
                answer = i;
                answerLength = Math.Sqrt(x * x + y * y);
            }

        }
        answerLength = Math.Round(answerLength, 2);
        Console.WriteLine(answer);
        Console.WriteLine(answerLength);

        // end

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here

        for(int i = 0;i < n;i++)
        {
            double res = double.Parse(Console.ReadLine());
            if (answer > res)
            {
                answer = res;
            }
        }
        Console.WriteLine(answer);

        // end

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;

        for(int i = 0;i < n;i++)
        {
            int o1 = int.Parse(Console.ReadLine());
            int o2 = int.Parse(Console.ReadLine());
            int o3 = int.Parse(Console.ReadLine());
            int o4 = int.Parse(Console.ReadLine());
            if (o1 > 3 && o2> 3 &&o3 > 3 && o4 > 3)
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

        double o1, o2, o3, o4;
        for (int i = 1; i <= n; i++)
        {
            o1 = double.Parse(Console.ReadLine());
            o2 = double.Parse(Console.ReadLine());
            o3 = double.Parse(Console.ReadLine());
            o4 = double.Parse(Console.ReadLine());
            if (o1 == 2 || o2 == 2 || o3 == 2 || o4 == 2)
                answer++;
            avg += (o1 + o2 + o3 + o4) / 4;
        }
        avg /= n;

        // end

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here;

        if (r > 0)
        {
            switch(type)
            {
                case 0:
                    answer = r * r;
                    break;
                case 1:
                    answer = Math.PI * r * r;
                    break;
                case 2:
                    answer = (Math.Sqrt(3) * r * r) / 4;
                    break;
                default:
                    answer = 0; break;

            }
        }
        answer = Math.Round(answer, 2);

        // end

        return answer;
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
                    answer = Math.Round(A * B, 2);
                    break;
                case 1:
                    if (B > A)
                        answer = Math.Round(Math.PI * (B * B - A * A), 2);
                    else
                        answer = Math.Round(Math.PI * (A * A - B * B), 2);
                    break;
                case 2:
                    answer = Math.Round(0.5 * Math.Sqrt(B * B - A * A / 4) * A, 2);
                    break;
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

        while (true)
        {
            double height = double.Parse(Console.ReadLine());
            if (height == 0) break;
            n++;
            answer += height;
        }
        answer /= n;
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
        int answer = 0, n = 0;

        // code here

        while (true)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if (y == 1000) break;
            if (((x * x + y * y) >= r1 * r1) && ((x * x + y * y) <= r2 * r2)) answer++;
        }
        Console.Write(answer);

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

        // end

        return answer;
    }
    public int Task_3_10()
    {
        int answer = 0, n = 0;

        // code here;

        int o1, o2, o3, o4 = 0;
        while (true)
        {
            o1 = int.Parse(Console.ReadLine());
            o2 = int.Parse(Console.ReadLine());
            o3 = int.Parse(Console.ReadLine());
            o4 = int.Parse(Console.ReadLine());
            n++;

            if (o1 > 3 && o2 > 3 && o3 > 3 && o4 > 3) answer++;

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