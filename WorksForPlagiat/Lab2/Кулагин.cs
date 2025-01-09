using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Runtime.InteropServices;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        // program.Task_1_1(0.9, 1.23);
        // program.Task_1_2(0.9, 1.23);
        // program.Task_1_3(0.9, 1.23);
        // program.Task_1_4(0.9, 1.23, -0.1);
        //program.Task_1_5(0.9, 1.23);
        //program.Task_1_6(0.9, 1.23);
        // program.Task_1_7(0.9);
        // program.Task_1_8(0.9);
        // program.Task_1_9(0.9);
        // program.Task_1_10(0.9);
        // program.Task_2_1(10);
        // program.Task_2_2(5, 3, 2, 1);
        // program.Task_2_2(5, 1.5, 1.5, 1);
        // program.Task_2_2(5, 1, 3, 1);
        // program.Task_2_3(10);
        // program.Task_2_4(3, 1, 3);
        //program.Task_2_5(10, 30);
        //program.Task_2_6(5);
        // program.Task_2_7(5);
        // program.Task_2_8(4);
        //program.Task_2_9(10);
        // program.Task_2_10(10);
        // program.Task_2_11(10);
        //program.Task_2_12(-0.75, 0);
        // program.Task_2_13(-0.75, 1, 0);
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
        
        program.Task_3_9();
        
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
        // (double, double) first = (0, 2);
        // (double, double) second = (1.5, 0.7);
        // (double, double) third = (1, 1);
        // (double, double) fourth = (3, 0);

        if (x * x + y * y == r * r && Math.Abs(x * x + y * y - r * r) <= Math.Pow(10, -3)) answer = true;
        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        if (y >= 0 && y + Math.Abs(x) <= 1.0) answer = true;
        // end

        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;

        // code here
        double c = 0;
        double maxFoo = a > b ? a : b;
        double minFoo = a < b ? a : b;
        if (a > 0) c = maxFoo;
        else c = minFoo;

        answer = c;
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        // code here
        double minFoo = a < b ? a : b;
        double maxFoo = minFoo > c ? minFoo : c;

        answer = maxFoo;
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        double radius = Math.Sqrt(r / Math.PI);
        double sideSquare = Math.Sqrt(s);
        double diagonalSquare = Math.Sqrt(2) * sideSquare;
        if (diagonalSquare <= 2 * radius) answer = true;
        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        double radius = Math.Sqrt(r / Math.PI);
        double sideSquare = Math.Sqrt(s);
        double diameterCircle = 2 * radius;
        if (diameterCircle <= sideSquare) answer = true;
        // end

        return answer;
    }
    public double Task_1_7(double x)
    {
        double answer = 0;

        // code here
        double y = 0;
        if (Math.Abs(x) > 1) y = 1;
        else y = Math.Abs(x);

        answer = y;
        // end

        return answer;
    }
    public double Task_1_8(double x)
    {
        double answer = 0;

        // code here
        double y = 0;
        if (Math.Abs(x) >= 1) y = 0;
        else y = x * x - 1;

        answer = y;
        // end

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        // code here
        double y = 0;
        if (x <= -1) y = 0;
        else if (-1 <= x && x <= 0) y = x + 1;
        else y = 1;
        answer = y;
        // end

        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;

        // code here
        double y = 0;
        if (x <= -1) y = 1;
        else if (-1 < x && x <= 1) y = -1.0 * x;
        else if (x > 1) y = -1;
        
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
        double ages = 0;
        for (int i = 0; i < n; i++)
        {
            string result = Console.ReadLine();
            ages += double.Parse(result, new CultureInfo("en-US"));
        }

        answer = ages / n;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        // code here
        for (int i = 0; i < n; i++)
        {
            string result = Console.ReadLine();
            string result2 = Console.ReadLine();
            double x = double.Parse(result, new CultureInfo("en-US"));
            double y = double.Parse(result2, new CultureInfo("en-US"));
            
            if ((x - a) * (x - a) + (y - b) * (y - b) <= r * r)
            {
                Console.WriteLine("______ {0}", Math.Pow(x - a, 2) + Math.Pow(y - b, 2) - Math.Pow(r, 2));
                answer++;
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
        for (int i = 0; i < n; i++)
        {
            string result = Console.ReadLine();
            double foo = double.Parse(result, new CultureInfo("en-US"));
            
            if (foo < 30)
            {
                answer += 0.2;
            }
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here
        for (int i = 0; i < n; i++)
        {
            string result = Console.ReadLine();
            string result2 = Console.ReadLine();
            double x = double.Parse(result, new CultureInfo("en-US"));
            double y = double.Parse(result2, new CultureInfo("en-US"));
            
            if (x * x + y * y > r1 * r1 && x * x + y * y < r2 * r2)
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
        for (int i = 0; i < n; i++)
        {
            string result = Console.ReadLine();
            double foo = double.Parse(result, new CultureInfo("en-US"));
            
            if (foo <= norm)
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
        for (int i = 0; i < n; i++)
        {
            string result = Console.ReadLine();
            string result2 = Console.ReadLine();
            double x = double.Parse(result, new CultureInfo("en-US"));
            double y = double.Parse(result2, new CultureInfo("en-US"));

            if ((x >= 0 && y >= 0) && (x <= Math.PI) && (Math.Sin(x) >= y))
            {
                answer++;
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
        for (int i = 0; i < n; i++)
        {
            string result = Console.ReadLine();
            string result2 = Console.ReadLine();
            double x = double.Parse(result, new CultureInfo("en-US"));
            double y = double.Parse(result2, new CultureInfo("en-US"));

            if (x >= 0 && y >= 0)
            {
                answer1++;
            } else if (x < 0 && y < 0)
            {
                answer3++;
            }
        }
        Console.WriteLine("{0}", answer1);
        Console.WriteLine("{0}", answer3);
        // end

        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;

        // code here
        for (int i = 0; i < n; i++)
        {
            string result = Console.ReadLine();
            string result2 = Console.ReadLine();
            double x = double.Parse(result, new CultureInfo("en-US"));
            double y = double.Parse(result2, new CultureInfo("en-US"));

            double foo = Math.Sqrt(x * x + y * y);
            if (foo < answerLength)
            {
                answerLength = foo;
                answer = i + 1;
            }
        }
        Console.WriteLine("{0}", answer);
        Console.WriteLine("{0}", Math.Round(answerLength, 2));
        // end

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        for (int i = 0; i < n; i++)
        {
            string result = Console.ReadLine();
            double foo = double.Parse(result, new CultureInfo("en-US"));

            if (foo < answer)
            {
                answer = foo;
            }
        }
        Console.WriteLine("{0}", answer);
        // end

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;
        for (int i = 0; i < n; i++)
        {
            string result1 = Console.ReadLine();
            string result2 = Console.ReadLine();
            string result3 = Console.ReadLine();
            string result4 = Console.ReadLine();
            double mark1 = double.Parse(result1, new CultureInfo("en-US"));
            double mark2 = double.Parse(result2, new CultureInfo("en-US"));
            double mark3 = double.Parse(result3, new CultureInfo("en-US"));
            double mark4 = double.Parse(result4, new CultureInfo("en-US"));

            if (mark1 != 2 && mark1 != 3 && mark2 != 2 && mark2 != 3 && mark3 != 2 && mark3 != 3 && mark4 != 2 && mark4 != 3)
            {
                answer++;
            }
        }
        Console.WriteLine("{0}", answer);
        // end

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;

        // code here;
        for (int i = 0; i < n; i++)
        {
            string result1 = Console.ReadLine();
            string result2 = Console.ReadLine();
            string result3 = Console.ReadLine();
            string result4 = Console.ReadLine();
            double mark1 = double.Parse(result1, new CultureInfo("en-US"));
            double mark2 = double.Parse(result2, new CultureInfo("en-US"));
            double mark3 = double.Parse(result3, new CultureInfo("en-US"));
            double mark4 = double.Parse(result4, new CultureInfo("en-US"));

            if (mark1 == 2 || mark2 == 2 || mark3 == 2 || mark4 == 2)
            {
                answer++;
            }
            
            avg += mark1 + mark2 + mark3 + mark4;
        }

        avg /= 4 * n;
        Console.WriteLine("{0}", answer);
        Console.WriteLine("{0}", avg);
        // end

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here;
        if (r < 0) answer = 0;
        else
        {
            switch (type)
            {
                case 0: answer = Math.Round(r * r, 2);
                    break;
                case 1: answer = Math.Round(Math.PI * r * r, 2);
                    break;
                case 2: answer = Math.Round(r * r * Math.Sqrt(3) / 4, 2);
                    break;
                default:
                    break;
            }
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;
        if (A >= 0 && B >= 0)
        {
            switch (type)
            {
               case 0: answer = Math.Round(A * B, 2);
                   break;
               case 1: answer = Math.Round(Math.PI * Math.Abs((Math.Pow(A, 2) - Math.Pow(B, 2))), 2);
                   break;
               case 2: 
                   if (A >= B)
                   {
                       double height = Math.Sqrt(A * A - (B * B) / 4); 
                       answer = Math.Round(0.5 * B * height);   
                   }
                   else
                   {
                       double height = Math.Sqrt(B * B - (A * A) / 4); 
                       answer = Math.Round(0.5 * A * height, 2);     
                   }

                   break;
               default:
                   break;
            }
        }

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

        // end

        return answer;
    }
    public double Task_3_3()
    {
        double answer = 0;
        int n = 0;

        // code here
        while (true)
        {
            string result = Console.ReadLine();
            if (string.IsNullOrEmpty(result)) break;
            
            double foo = double.Parse(result, new CultureInfo("en-US"));
            
            if (foo < 30)
            {
                answer += 0.2;
            }

            n++;
        }
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
        while (true)
        {
            string result = Console.ReadLine();
            if (string.IsNullOrEmpty(result)) break;
            string result2 = Console.ReadLine();
            if (string.IsNullOrEmpty(result2)) break;
            
            double x = double.Parse(result, new CultureInfo("en-US"));
            double y = double.Parse(result2, new CultureInfo("en-US"));

            if ((x >= 0 && y >= 0) && (x <= Math.PI) && (Math.Sin(x) >= y))
            {
                answer++;
            }

            n++;
        }
        Console.WriteLine(answer);
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
        while (true)
        {
            string result = Console.ReadLine();
            if (string.IsNullOrEmpty(result)) break;
            double foo = double.Parse(result, new CultureInfo("en-US"));

            if (foo < answer)
            {
                answer = foo;
            }
        }
        Console.WriteLine("{0}", answer);
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