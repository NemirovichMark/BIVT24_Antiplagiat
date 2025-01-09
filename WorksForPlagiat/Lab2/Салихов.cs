using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;

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
        //program.Task_3_2(3, 2, 1);
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
        int r = 2;
        // code here
        if (Math.Abs(x * x + y * y - r * r) <= 0.001)
            return answer = true;
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
            }
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
            if (a > b) return a;
            else
            {
                return answer = b;
            }
        }
        else
        {
            if (a < b) return a;
            else
            {
                return answer = b;
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
                return answer = a;
            }
            else return answer = c;
        }
        else
        {
            if (b > c)
            {
                return answer = b;
            }
            else return answer = c;
        }



        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here

        if (2 * Math.Sqrt(r / Math.PI) > Math.Sqrt(s) * Math.Sqrt(2))
        {
            return answer = true;
        }




        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        if (2 * Math.Sqrt(r / Math.PI) <= Math.Sqrt(s))
        {
            return answer = true;
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

            return answer = 1;
        }
        else
        {
            return answer = Math.Abs(x);
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
            return answer = 0;
        }
        else
        {
            return answer = x * x - 1;
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
            return answer = 0;
        }
        else if (x <= 0 && x > -1)
        {
            return answer = (1 + x);
        }
        else if (x > 0)
        {
            return answer = 1;
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
            return answer = 1;
        }
        else if (x <= 1 && x > -1)
        {
            return answer = -x;
        }
        else if (x > 1)
        {
            return answer = -1;
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
        for (int i = 1; i <= n; i++)
        {
            answer += int.Parse(Console.ReadLine());
        }
        // end
        answer = Math.Round(answer / n, 2);
        Console.WriteLine(answer);
        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;
        double x1 = 0;
        double x2 = 0;
        double prov = 0;
        // code here
        for (int i = 1; i <= n; i++)
        {
            x1 = double.Parse(Console.ReadLine());
            x2 = double.Parse(Console.ReadLine());
            prov = Math.Sqrt(((x1 - a) * (x1 - a)) + ((x2 - b) * (x2 - b)));
            if (prov < r)
            {
                answer++;
            }
        }
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;
        double child = 0;

        // code here
        for (int i = 1; i <= n; i++)
        {
            child = double.Parse(Console.ReadLine());
            if (child < 30)
            {
                answer += 200;
            }
        }

        // end
        answer = answer / 1000;
        Console.WriteLine(answer);
        return answer;
        
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;
        double x1 = 0;
        double x2 = 0;
        double prov = 0;
        // code here
        for (int i = 1; i <= n; i++)
        {
            x1 = double.Parse(Console.ReadLine());
            x2 = double.Parse(Console.ReadLine());
            prov = Math.Sqrt(((x1) * (x1)) + ((x2) * (x2)));
            if (prov > r1)
            {
                if (prov < r2)
                {
                    answer++;
                }
            }
        }


        // end
        Console.WriteLine(answer);
        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;
        double sport = 0;
        // code here
        for (int i = 1; i <= n; i++)
        {
            sport = double.Parse(Console.ReadLine());
            if (sport <= norm)
            {
                answer++;
            }
        }
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;
        double x1 = 0;
        double x2 = 0;
        // code here
        for (int i = 1; i <= n; i++)
        {
            x1 = double.Parse(Console.ReadLine());
            x2 = double.Parse(Console.ReadLine());
            if ((x1 >= 0) && (x2 >= 0) && (x1 <= Math.PI) && (Math.Sin(x1) >= x2))
                answer++;
        }
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;
        double x1 = 0;
        double x2 = 0;
        // code here
        for (int i = 1; i <= n; i++)
        {
            x1 = double.Parse(Console.ReadLine());
            x2 = double.Parse(Console.ReadLine());
            if (x1 > 0 && x2 > 0)
            {
                Console.WriteLine("Попало в первый квадрант");
                answer1++;
            }
            else if (x1 < 0 && x2 < 0)
            {
                Console.WriteLine("Попало в третий квадрант");
                answer3++;
            }
        }
        // end
        Console.WriteLine(answer1);
        Console.WriteLine(answer3);
        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;

        // code here
        double x1 = 0;
        double x2 = 0;
        for (int i = 1; i <= n; i++)
        {
            x1 = double.Parse(Console.ReadLine());
            x2 = double.Parse(Console.ReadLine());
            if (Math.Round(Math.Sqrt(x1 * x1 + x2 * x2), 2) < answerLength)
            {
                answer = n;
                answerLength = Math.Round(Math.Sqrt(x1 * x1 + x2 * x2), 2);
            }
        }


        // end
        Console.WriteLine(answer);
        Console.WriteLine(answerLength);
        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;
        double sport = 0;
        // code here
        for (int i = 1; i <= n; i++)
        {
            sport = double.Parse(Console.ReadLine());
            if (sport < answer)
            {
                answer = sport;
            }
        }
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;
        double x1 = 0;
        double x2 = 0;
        double x3 = 0;
        double x4 = 0;

        // code here;
        for (int i = 1; i <= n; i++)
        {
            x1 = int.Parse(Console.ReadLine());
            x2 = int.Parse(Console.ReadLine());
            x3 = int.Parse(Console.ReadLine());
            x4 = int.Parse(Console.ReadLine());
            if (x1 > 3 && x2 > 3 && x3 > 3 && x4 > 3)
            {
                answer++;
            }
        }
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;
        double x1 = 0;
        double x2 = 0;
        double x3 = 0;
        double x4 = 0;

        // code here;
        for (int i = 1; i <= n; i++)
        {
            x1 = int.Parse(Console.ReadLine());
            x2 = int.Parse(Console.ReadLine());
            x3 = int.Parse(Console.ReadLine());
            x4 = int.Parse(Console.ReadLine());
            avg = avg + x1 + x2 + x3 + x4;
            if (x1 < 3 || x2 < 3 || x3 < 3 || x4 < 3)
            {
                answer++;
            }
        }
        // end
        avg = avg / (n * 4);
        Console.WriteLine(answer);
        Console.WriteLine(avg);
        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here;
        if (r < 0) return answer = 0;
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
        // end

        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;
        double polu = 0;

        // code here;
        if (A <= 0 || B <= 0)
        {
            return answer = 0;
        }

        switch (type)
        {
            case 0:
                answer = Math.Round((A * B), 2);
                break;
            case 1:
                if (A > B)
                {
                    answer = Math.Round((Math.PI * (A * A - B * B)), 2);
                }
                else if (B > A)
                {
                    answer = Math.Round((Math.PI * (B * B - A * A)), 2);
                }
                if (answer < 0)
                {
                    return answer = 0;
                }
                break;
            case 2:
                polu = (A + B + B) / 2;
                answer = Math.Round((Math.Sqrt(polu * (polu - A) * (polu - B) * (polu - B))), 2);
                if (answer > 0)
                {

                    return answer;
                }
                else
                {

                    return answer = 0;
                }
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

        // end

        // answer should be equal to the task_2_1 answer
        return answer;
    }
    public int Task_3_2(double r, double a, double b)
    {
        int answer = 0, n = 0;

        double x1 = 0;
        double x2 = 0;
        double prov = 0;
        // code here
        while(true)
        {
            n++;
            x1 = double.Parse(Console.ReadLine());
            if (x1 == -100)
            {
                Console.WriteLine(answer);
                break;
            }
            x2 = double.Parse(Console.ReadLine());
            prov = Math.Sqrt(((x1 - a) * (x1 - a)) + ((x2 - b) * (x2 - b)));
            if (prov < r)
            {
                answer++;
            }
        }
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
        double sport = 0;
        // code here
        while(true)
        {
            n++;
            sport = double.Parse(Console.ReadLine());
            if (sport == -100)
            {
                Console.WriteLine(answer);
                break;
            }
            if (sport <= norm)
            {
                answer++;
            }
        }
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
        double x1 = 0;
        double x2 = 0;
        while (true)
        {
            n++;
            x1 = double.Parse(Console.ReadLine());
            if (x1 == -100)
            {
                Console.WriteLine(answer);
                Console.WriteLine(answerLength);
                break;
            }
            x2 = double.Parse(Console.ReadLine());
            if (Math.Round(Math.Sqrt(x1 * x1 + x2 * x2), 2) < answerLength)
            {
                answer = n;
                answerLength = Math.Round(Math.Sqrt(x1 * x1 + x2 * x2), 2);
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
        double x1 = 0;
        double x2 = 0;
        double x3 = 0;
        double x4 = 0;

        // code here;
        while(true)
        {
            x1 = int.Parse(Console.ReadLine());
            if (x1 == -100)
            {
                Console.WriteLine(answer);
                avg = Math.Round(avg / (n * 4),2);
                Console.WriteLine(avg);
                break;
            }
            n++;
            x2 = int.Parse(Console.ReadLine());
            x3 = int.Parse(Console.ReadLine());
            x4 = int.Parse(Console.ReadLine());
            avg = avg + x1 + x2 + x3 + x4;
            if (x1 < 3 || x2 < 3 || x3 < 3 || x4 < 3)
            {
                answer++;
            }
        }
        // end
        return (answer, avg);
    }
    
    #endregion
}