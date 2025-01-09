
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Net;
using System.Runtime.InteropServices;

public class Program
{
    public static void Main()
    {
        CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
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
        //program.Task_2_6(3);
        program.Task_2_7(5);
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
        double r = 2;
        double S = x * x + y * y - r * r;

        // code here

        if (Math.Abs(S) <= Math.Pow(10, -3))
            answer = true;
        else
            answer = false;

        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        if ((y >= 0) && (y + Math.Abs(x) <= 1))
            answer = true;
        else
            answer = false;
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
                answer = a;
            else
                answer = b;
        }
        if (a <= 0)
        {
            if (a < b)
                answer = a;
            else
                answer = b;
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
        if (a > b)
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

        double dgn = Math.Sqrt(2) * Math.Sqrt(s);
        double diametr = 2 * Math.Sqrt(r / Math.PI);

        // code here
        
        if (dgn <= diametr)
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
        double storona = Math.Sqrt(s);
        double diametr= 2 * Math.Sqrt(r / Math.PI);
        if (diametr <= storona)
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
        if ((Math.Abs(x)) > 1)
        {
            answer = 1;
        }
        if ((Math.Abs(x)) <= 1)
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
            answer = Math.Pow(x, 2) - 1;
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
        if (-1 < x && x <= 0)
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
        if (x <= -1)
        {
            answer = 1;
        }
        if (-1 < x && x <= 1)
        {
            answer = -x;
        }
        if (x > 1)
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
        double sum = 0;
        double rost= 0;
        
        for(int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out rost);
            sum += rost;
        }
        answer = sum / n;
        Console.WriteLine(answer);

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;
        double x = 0, y = 0;

        for (int i = 0; i < n; i++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            if (Math.Sqrt((x - a) * (x - a) + (y - b) * (y - b)) <= r) answer++;
        }
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public double Task_2_3(int n)
    {
        // code here
        double ves = 0;
        double moloko= 0;   
        for (int i = 1; i <= n; i++)
        {        
            ves = double.Parse(Console.ReadLine());

            if (ves < 30) moloko += 0.2;

        }    
        // end
        Console.WriteLine(moloko);

        return moloko;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here
        double y = 0;
        double x = 0;
        for (int i = 1; i <= n; i++)
        {
            x = double.Parse((Console.ReadLine()));
            y = double.Parse((Console.ReadLine()));
            if ((Math.Pow(x, 2) + Math.Pow(y, 2) >= Math.Pow(r1, 2)) && (Math.Pow(x, 2) + Math.Pow(y, 2) <= Math.Pow(r2, 2))) {
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
        double res = 0;
        int i = 0;
        while(i < n)
        {
            res = double.Parse(Console.ReadLine());
            if (res <= norm) answer++;
            i++;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;

        // code here
        double x = 0;
        double y = 0;
        for (int i = 0; i < n; i++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse((Console.ReadLine()));
            if ((x >= 0) && (y >= 0) && (Math.Sin(x) >= y) && (x <= Math.PI) )
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
        double x = 0;
        double y = 0;
        // code here
        
        for (int i = 0; i < n; i++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse((Console.ReadLine()));
            if (x > 0 && y > 0)
            {
                answer1++;
                Console.WriteLine("1 квадрант");
            }
            if (x < 0 && y < 0)
            {
                answer3++;
                Console.WriteLine("3 квадрант");
            }
            if (x < 0 && y > 0)
            {
                Console.WriteLine("2 квадрант");
            }
            if (x > 0 && y < 0)
            {
                Console.WriteLine("4 квадрант");
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
        double m = double.MaxValue, x = 0, y = 0;
        int z = 0;
        for (int i = 1; i <= n; i++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            double d = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            if (d < m)
            {
                m = d;
                z = i;
            }
        }
        answer = z;
        answerLength = Math.Round(m, 2);
        Console.WriteLine(answer);
        Console.WriteLine(answerLength);
        // end

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        double rastSport = 0;
        double maxRast = 525252;

        for (int i = 0; i < n; i++)
        {
            rastSport = double.Parse(Console.ReadLine());
            if (rastSport < maxRast) maxRast = rastSport;
        }

        answer = maxRast;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;
        double mark1 = 0;
        double mark2 = 0;
        double mark3 = 0;
        double mark4 = 0;
        for (int i = 0; i < n; i++)
        {
            mark1 = double.Parse(Console.ReadLine());
            mark2 = double.Parse(Console.ReadLine());
            mark3 = double.Parse(Console.ReadLine());
            mark4 = double.Parse(Console.ReadLine());
            if (mark1 == 2 || mark1 == 3 || mark2 == 2 || mark2 == 3 || mark3 == 2 || mark3 == 3 || mark4 == 2 || mark4 == 3)
            {
                continue;
            }
            else
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
        int counter = n * 4;

        // code here;
        int mark1 = 0, mark2 = 0, mark3 = 0, mark4 = 0;                                                  
        for (int i = 0; i < n; i++)
        {
            mark1 = int.Parse(Console.ReadLine());
            mark2 = int.Parse(Console.ReadLine());
            mark3 = int.Parse(Console.ReadLine());
            mark4 = int.Parse(Console.ReadLine());
            if (mark1 == 2 || mark2 == 2 || mark3 == 2 || mark4 == 2)
            {
                answer++;
            }
            avg += mark1 + mark2 + mark3  + mark4;
        }
        avg = avg / counter;
        Console.WriteLine(answer);
        Console.WriteLine(avg);
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
                answer = Math.Pow(r, 2);
                break;
            case 1:
                answer = Math.PI * Math.Pow(r, 2);
                break;
            case 2:
                answer = (Math.Pow(r, 2) * Math.Sqrt(3)) / 4;
                break;
            default:
                break;
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
                    answer = A * B;
                    break;
                case 1:
                    answer = Math.Abs(Math.PI * A * A - Math.PI * B * B);
                    break;
                case 2:
                    answer = (A * Math.Sqrt(B * B - A * A / 4)) / 2;
                    break;
                default:
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
        double x = 0;
        double y = 0;
        while (true)
        {
            string f = Console.ReadLine();
            if (f == "-")
            {
                break;
            }
            else
            {
                double.TryParse(f, out x);
                y = double.Parse(Console.ReadLine());
                if (Math.Sqrt((x - a) * (x - a) + (y - b) * (y - b)) <= r) answer++;
            }
        }
        Console.WriteLine(answer);
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
        double sport = 0;
        while (true)
        {
            string f = Console.ReadLine();
            if (f == "-")
            {
                break;
            }
            else
            {
                double.TryParse(f, out sport);
                if (sport <= norm) answer++;
            }
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
        double m = double.MaxValue;
        double x = 0, y = 0;
        int z = 0, i = 0;
        while (true)
        {
            string f = Console.ReadLine();
            if (f == "-")
            {
                if (i == 0)
                {
                    Console.WriteLine();
                }
                else
                {
                    m = Math.Round(m, 2);
                    answerLength = m;
                    answer = i;
                    Console.WriteLine(answer);
                    Console.WriteLine(answerLength);
                }
                break;
            }
            else
            {
                double.TryParse(f, out x);
                f = Console.ReadLine();
                double.TryParse(f, out y);

                double d = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
                i++;
                if (d < m)
                {
                    m = d;
                    z = i;
                }
            }
        }
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
        double mark1 = 0, mark2 = 0, mark3 = 0, mark4 = 0;

        while (true)
        {
            string f = Console.ReadLine();
            if (f == "-")
            {
                if (n > 0)
                {
                    avg = avg / (n * 4);
                    Console.WriteLine(answer);
                    Console.WriteLine(avg);
                    break;
                }
            }
            mark1 = double.Parse(f);
            mark2 = double.Parse(Console.ReadLine());
            mark3 = double.Parse(Console.ReadLine());
            mark4 = double.Parse(Console.ReadLine());

            n++;

            if (mark1 == 2 || mark2 == 2 || mark3 == 2 || mark4 == 2) answer++;
            avg += mark4 + mark1 + mark3 + mark2;
        }



        // end

        return (answer, avg);
    }
    #endregion
}