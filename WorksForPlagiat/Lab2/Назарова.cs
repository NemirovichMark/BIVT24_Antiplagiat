using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

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
        if (Math.Abs((x * x)+(y*y)-(r*r))<= 0.001)
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
        if (y>=0 && y + Math.Abs(x) <=1)
        {
            answer=true;
        }
        else
        {
            answer=false;
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
            if (b > a)
            {
                answer = b;
            }
        }
        if (a <= 0)
        {
            if (a < b)
            {
                answer = a;
            }
            if (b < a)
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
            if (c < a)
            {
                answer = a;
            }
            else
            {
                answer = c;
            }
        }
        if (b < a)
        {
            if ( c < b)
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
        double d_r,d_s;
        d_r = 2 * (Math.Sqrt(r / Math.PI));
        d_s = (Math.Sqrt(s) * Math.Sqrt(2));
        if (d_s <= d_r)
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
        double d_r, d_s;
        d_r = 2 * (Math.Sqrt(r / Math.PI));
        d_s = (Math.Sqrt(s));
        if (d_r <= d_s)
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
        if (Math.Abs(x)> 1)
        {
            answer = 1;
        }
        if (Math.Abs(x)<=1)
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
        if (Math.Abs(x) < 1)
        {
            answer = (x * x) -1;
        }
        // end

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        // code here
        if (x <= - 1)
        {
            answer = 0;
        }
        if (x > -1 && x <= 0 )
        {
            answer = 1 + x;
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
        if (x <= - 1)
        {
            answer = 1;
        }
        else
        {
            answer = - x;
        }
        if (x > 1)
        {
            answer = - 1;
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
        double sr = 0;
        for (int i = 1; i <= n; i++)
        {
            string s = Console.ReadLine();
            double s1 = Convert.ToDouble(s);
            sr += s1;
        }
        answer = sr / n;
        answer = Math.Round(answer, 5);
        // end

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        // code here
        for (int i = 1; i <= n; i++)
        {
            double s = Convert.ToDouble(Console.ReadLine());
            double z = Convert.ToDouble(Console.ReadLine());
            if ((a - s)*(a - s) + (b - z)*(b - z) <= (r * r))
            {
                answer++;
            }
        }
        // end

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        // code here
        for (int i = 1; i <= n; i++)
        {
            double v = Convert.ToDouble(Console.ReadLine());
            if (v < 30)
            {
                answer += 0.2;
            }
        }
        // end

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here
        for (int i = 1; i <= n; i++)
        {
            double s = Convert.ToDouble(Console.ReadLine());
            double z = Convert.ToDouble(Console.ReadLine());
            if ((s * s + z * z >= r1 * r1) && (s * s + z * z <= r2 * r2))
            {
                answer += 1;
            }
        }
            // end

            return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

        // code here
        int count = 0;
        for (int i = 0; i < n; i++)
        {
            double result = Convert.ToDouble(Console.ReadLine());
            if (result <= norm)
            {
                count++;
            }
        }
        answer = count;
        return answer;
        // end
    }
    public int Task_2_6(int n)
    {
        int answer = 0;

        // code here
        for (int i = 1; i <= n; i++)
        {
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            if ((x >= 0) && (y >= 0) && (x <= Math.PI) && (Math.Sin(x) >= y))
            {
                answer += 1;
            }
        }
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
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            if (x > 0 && y > 0)
            {
                answer1 += 1;
                Console.WriteLine("Первый квадрант");
            }
            if (x < 0 && y < 0)
            {
                answer3 += 1;
                Console.WriteLine("Третий квадрант");
            }
            if (x < 0 && y > 0)
            {
                Console.WriteLine("Второй квадрант");
            }
            if (x > 0 && y < 0)
            {
                Console.WriteLine("Четвертый квадрант");
            }
        }
        // end

            return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;

        // code here
        double r;
        for (int i = 1; i <= n; i++)
        {
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            r = Math.Sqrt((x * x) + (y * y));
            if (r > answerLength)
            {
                answerLength = r;
                answer++;
            }
        }
        // end

            return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
  
        for (int i = 0; i < n - 1; i++)
        {
            double result = Convert.ToDouble(Console.ReadLine());
            if (result > answer)
            {
                answer = result;
            }
        }
            // end

            return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;
        for (int i = 1; i < n; i++)
        {
            double evaluation1 = Convert.ToDouble(Console.ReadLine());
            double evaluation2 = Convert.ToDouble(Console.ReadLine());
            double evaluation3 = Convert.ToDouble(Console.ReadLine());
            double evaluation4 = Convert.ToDouble(Console.ReadLine());
            if (evaluation1 > 3 && evaluation2 > 3 && evaluation3 > 3 && evaluation4 > 3)
            {
                answer += 1;
            }
        }
        // end

            return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;

        // code here;
        for (int i = 1; i < n; i++)
        {
            double evaluation1 = Convert.ToDouble(Console.ReadLine());
            double evaluation2 = Convert.ToDouble(Console.ReadLine());
            double evaluation3 = Convert.ToDouble(Console.ReadLine());
            double evaluation4 = Convert.ToDouble(Console.ReadLine());
            if (evaluation1 > 2 && evaluation2 > 2 && evaluation3 > 2 && evaluation4 > 2)
            {
                answer += 1;
                avg = ((evaluation1 + evaluation2 + evaluation3 + evaluation4) / 4);
            }
        }
        // end

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here
        if (r <= 0) return answer;
        Console.WriteLine("Выберте 0, 1 или 2");
        switch (type)
        {
            case 0:
                answer = r * r;
                answer = Math.Round(answer, 2);                
                break;
            case 1:
                answer = Math.PI * (r * r);
                answer = Math.Round(answer, 2);               
                break;
            case 2:
                answer = (Math.Sqrt(3) * (r*r)) / 4;
                answer = Math.Round(answer, 2);          
                break;
            default:
                Console.WriteLine("Неверный ввод");                
                break;
        }
        // end

        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;
        if (A <= 0) return answer;
        if (B <= 0) return answer;       
        switch (type)
        {
            case 0:
                answer = A * B;
                
                answer = Math.Round(answer, 2);
                break;
            case 1:

                if (A >= B)
                {
                    answer = Math.PI * ((A * A) - (B * B));
                    answer = Math.Round(answer, 2);
                    break;
                }
                else
                {
                    answer = Math.PI * ((B * B) - (A * A));
                    answer = Math.Round(answer, 2);
                    break;
                }                    
            case 2:
                answer = (A/4 * Math.Sqrt((4*B*B)-(A*A)));                
                answer = Math.Round(answer, 2);
                break;
            default:
                Console.WriteLine("Неверный ввод");
                break;
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
        bool stop = false;
        double sr = 0;
        while (stop == false)
        {
            string s = Console.ReadLine();
            double s1 = Convert.ToDouble(s);
            sr += s1;
            n++;
            Console.WriteLine("Нужно ли продолжать?(Да или нет)");
            string s2 = Console.ReadLine();
            if (s2 == "Нет")
            {
                stop = true;
            }
        }
        answer = sr / n;
        answer = Math.Round(answer, 5);
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
        bool stop = false;
        while (stop == false)
        {
            double s = Convert.ToDouble(Console.ReadLine());
            double z = Convert.ToDouble(Console.ReadLine());
            if ((s * s + z * z >= r1 * r1) && (s * s + z * z <= r2 * r2))
            {
                answer += 1;
            }
            Console.WriteLine("Нужно ли продолжать?(Да или нет)");
            string s2 = Console.ReadLine();
            if (s2 == "Нет")
            {
                stop = true;
            }
        }
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
        bool stop = false;
        while (stop == false)
        {
            for (int i = 1; i <= n; i++)
            {
                double x = Convert.ToDouble(Console.ReadLine());
                double y = Convert.ToDouble(Console.ReadLine());
                if (x > 0 && y > 0)
                {
                    answer1 += 1;
                    Console.WriteLine("Первый квадрант");
                }
                if (x < 0 && y < 0)
                {
                    answer3 += 1;
                    Console.WriteLine("Третий квадрант");
                }
                if (x < 0 && y > 0)
                {
                    Console.WriteLine("Второй квадрант");
                }
                if (x > 0 && y < 0)
                {
                    Console.WriteLine("Четвертый квадрант");
                }
            }
            Console.WriteLine("Нужно ли продолжать?(Да или нет)");
            string s2 = Console.ReadLine();
            if (s2 == "Нет")
            {
                stop = true;
            }
        }
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
        bool stop = false;
        while(stop == false) 
        {
            double evaluation1 = Convert.ToDouble(Console.ReadLine());
            double evaluation2 = Convert.ToDouble(Console.ReadLine());
            double evaluation3 = Convert.ToDouble(Console.ReadLine());
            double evaluation4 = Convert.ToDouble(Console.ReadLine());
            if (evaluation1 > 3 && evaluation2 > 3 && evaluation3 > 3 && evaluation4 > 3)
            {
                answer += 1;
            }
            Console.WriteLine("Нужно ли продолжать?(Да или нет)");
            string s2 = Console.ReadLine();
            if (s2 == "Нет")
            {
                stop = true;
            }
        }
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