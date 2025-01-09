using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Numerics;
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
        if (Math.Abs(x * x + y * y - r * r) <= Math.Pow(10, -3))
        {
            answer = true;
        }
        else
        {
            answer = false;
        }
        
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        if (y >= 0 && y + Math.Abs(x) <=1)
        {
            answer = true;
        }
        // end
        Console.WriteLine(answer);
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
            if (a < b)
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
        Console.WriteLine(answer);
        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        // code here
        double z;
        if (a>b)
        {
            z = b;
        }
        else
        {
            z = a;
        }
        if (z>c)
        {
            answer = z;
        }
        else
        {
            answer = c;
        }
        
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        if (s <= 2 * r/Math.PI)
        {
            answer = true;
        }
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        if (2 * Math.Sqrt(r / Math.PI) <= Math.Sqrt(s))
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
        Console.WriteLine(answer);
        
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
            answer = -(1 - x * x);
        }
        // end
        Console.WriteLine(answer);
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
        else if (x <= 0)
        {
            answer = 1 + x;
        }
        else
        {
            answer = 1;
        }
        // end
        Console.WriteLine(answer);
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
        else if (x <= 1)
        {
            answer = 0 - x;
        }
        else
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
        double s = 0;
        for (int i = 1; i <= n; i++)
        {
            bool a = double.TryParse(Console.ReadLine(), out double b);
            if (a)
            {
                s = s+b;
            }
        }
        answer = s/n;
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;
        int count = 0;
        // code here
        for (int i = 1; i <= n; i++)
        {
            bool g1 = double.TryParse(Console.ReadLine(), out double x);
            bool g2 = double.TryParse(Console.ReadLine(), out double y);
            if (g1&&g2) 
            {
               if (Math.Pow((x - a), 2) + Math.Pow((y - b), 2) <= Math.Pow(r, 2))
                {
                    count++;
                }
            }
        }
        answer = count;
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        // code here
        double s =0;
        for (int i = 1; i <= n; i++)
        {
            bool k = double.TryParse(Console.ReadLine(), out double v);
            if (k==true)
            {
                if (v < 30)
                {
                    s = s + 0.2;
                }

            }
        }
        answer = s;
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here
        for (int i=1; i<=n; i++)
        {
            bool t = double.TryParse(Console.ReadLine(), out double x);
            bool t1 = double.TryParse(Console.ReadLine(), out double y);
            if (t==true && t1==true)
            {
                if ((Math.Pow(x, 2) + Math.Pow(y, 2) <= Math.Pow(r2, 2)) && (Math.Pow(x, 2) + Math.Pow(y, 2) > Math.Pow(r1, 2)))
                {
                    answer += 1;
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

        // code here
        for (int i = 1; i<=n; i++)
        {
            bool j = double.TryParse(Console.ReadLine(),out double p);
            if (j == true && p <= norm)
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

        // code here
        for (int i = 1; i <= n; i++)
        {
            bool t = double.TryParse(Console.ReadLine(), out double x);
            bool t1 = double.TryParse(Console.ReadLine(), out double y);
            if (t == true && t1 == true)
            {
                if (x <= Math.PI && x > 0 && y >= 0 && y <= Math.Sin(x))
                {
                    answer += 1;
                }
            }

        }
        // end
        Console.Write(answer);
        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;

        // code here
        for (int i = 1; i <= n; i++)
        {
            bool g1 = double.TryParse(Console.ReadLine(), out double x);
            bool g2 = double.TryParse(Console.ReadLine(), out double y);
            if (g1 && g2 && x != 0 && y != 0)
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine(1);
                    answer1 += 1;
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine(2);
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine(3);
                    answer3 += 1;
                }
                else
                {
                    Console.WriteLine(4);
                }
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
        for (int i = 1; i <= n; i++)
        {
            bool g1 = double.TryParse(Console.ReadLine(), out double x);
            bool g2 = double.TryParse(Console.ReadLine(), out double y);
            if (g1 == true && g2 == true)
            {
                if (Math.Sqrt(x * x + y * y) < answerLength)
                {
                    answerLength = Math.Sqrt(x * x + y * y);
                    answer = i;
                }
                    
            } 
        }
        // end
        Console.WriteLine(answer);
        answerLength = Math.Round(answerLength, 2);
        Console.WriteLine(answerLength);
        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        for (int i = 1; i <= n; i++)
        {
            bool g1 = double.TryParse(Console.ReadLine(), out double c);
            if (g1 == true)
            {
                if (c < answer)
                {
                    answer = c;
                }
            }
        }
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;
        int count = 0;
        for (int i = 1; i <= n; i++)
        {
            bool g1 = double.TryParse(Console.ReadLine(), out double o1);
            bool g2 = double.TryParse(Console.ReadLine(), out double o2);
            bool g3 = double.TryParse(Console.ReadLine(), out double o3);
            bool g4 = double.TryParse(Console.ReadLine(), out double o4);
            if (g1 && g2 && g3 && g4)
            {
                if (o1 >3 && o2>3 &&  o3>3 && o4>3)
                {
                    answer++;
                }
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
        int count = 0;

        // code here;
        for (int i = 1; i <= n; i++)
        {
            bool g1 = double.TryParse(Console.ReadLine(), out double o1);
            bool g2 = double.TryParse(Console.ReadLine(), out double o2);
            bool g3 = double.TryParse(Console.ReadLine(), out double o3);
            bool g4 = double.TryParse(Console.ReadLine(), out double o4);
            if (g1 && g2 && g3 && g4) 
            {
                avg += o1 + o2 + o3 + o4;
               if (o1==2 || o2 ==2 || o3==2 || o4==2)
                {
                    answer++;
                }
            }
        }
        avg = avg / n / 4;
        // end
        Console.WriteLine(answer);
        Console.WriteLine(avg);
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
                    break;
                case 1:
                    answer = r * r * Math.PI;
                    break;
                case 2:
                    answer = Math.Sqrt(3) / 4 * (r * r);
                    break;
                default:
                    answer = 0;
                    break;
                
            }
        }
        // end
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
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
                answer = Math.Abs(Math.PI * A * A - Math.PI * B * B);
                break;
            case 2:
                answer = Math.Sqrt(B * B - A * A / 4) * A / 2;
                break;
            default: return 0;
        }
        // end
        answer = Math.Round(answer, 2);
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
        for (int i = 1; ; i++)
        {
            bool g1 = double.TryParse(Console.ReadLine(), out double x);
            bool g2 = double.TryParse(Console.ReadLine(), out double y);
            if (g1 && g2)
            {
                if (Math.Pow((x - a), 2) + Math.Pow((y - b), 2) <= Math.Pow(r, 2))
                {
                    answer += 1;
                }
            }
            else
            {
                break;
            }
        }

        // end
        Console.WriteLine(answer);
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
        for (int i = 1; ; i++)
        {
            bool j = double.TryParse(Console.ReadLine(), out double p);
            if (j == true)
            {
                if (p <= norm)
                {
                    answer += 1;
                }
            }
            else
            {
                break;
            }
        }

        // end
        Console.WriteLine(answer);
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
        for (int i = 1; ; i++)
        {
            bool g1 = double.TryParse(Console.ReadLine(), out double x);
            bool g2 = double.TryParse(Console.ReadLine(), out double y);

            if (g1 && g2)
            {
                if (Math.Sqrt(x * x + y * y) < answerLength)
                {
                    answerLength = Math.Sqrt(x * x + y * y);
                    answer = i;
                }

            }
            else
            {
                break;
            }
        }
        answerLength = Math.Round(answerLength, 2);
        // end
        Console.WriteLine(answer);
        Console.WriteLine(answerLength);
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
        int Count = 0;

        double sum = 0;
        for (int i = 1; ; i++)
        {
            bool g1 = double.TryParse(Console.ReadLine(), out double o1);
            bool g2 = double.TryParse(Console.ReadLine(), out double o2);
            bool g3 = double.TryParse(Console.ReadLine(), out double o3);
            bool g4 = double.TryParse(Console.ReadLine(), out double o4);


            if (g1 && g2 && g3 && g4)
            {

                if (o1 == 2 || o2 == 2 || o4 == 2 || o3 == 2)
                {
                    Count += 1;
                }
                sum += o1 + o2 + o3 + o4;
                n += 1;
            }
            else
            {
                break;
            }
        }
        answer = Count;
        avg = sum / n / 4;
        Console.WriteLine(answer);
        Console.WriteLine(avg);
        // end
        return (answer, avg);
    }
    #endregion
}