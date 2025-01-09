using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;

public class Program
{
    public static void Main()
    {
        System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
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
        //program.Task_2_3(8);
        //program.Task_2_3(6);
        //program.Task_2_4(5, 1, 2);
        //program.Task_2_4(5, 1, 3);
        //program.Task_2_4(4, 1, 2);
        //program.Task_2_4(4, 1, 3);
        //program.Task_2_4(3, 1, 2);
        //program.Task_2_4(3, 1, 3);
        //program.Task_2_5(10, 30);
        //program.Task_2_5(10, 25.2);
        //program.Task_2_5(8, 30);
        //program.Task_2_5(8, 25.2);
        //program.Task_2_5(6, 30);
        //program.Task_2_5(6, 25.2);
        //program.Task_2_6(5);
        //program.Task_2_6(4);
        //program.Task_2_6(3);
        program.Task_2_7(5);
        //program.Task_2_7(4);
        //program.Task_2_7(3);
        //program.Task_2_8(5);
        //program.Task_2_8(4);
        //program.Task_2_8(3);
        //program.Task_2_9(10);
        //program.Task_2_9(8);
        //program.Task_2_9(6);
        //program.Task_2_10(10);
        //program.Task_2_10(8);
        //program.Task_2_10(6);
        //program.Task_2_11(10);
        //program.Task_2_11(8);
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
        if (Math.Abs(x * x + y * y - r * r) <= 1 / (10 * 10 * 10))
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
        if (y >= 0 && y + Math.Abs(x) <= 1)
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
            if (a > b)
            {
                answer = b;
            }
            else
            {
                answer = a;
            }
        }
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        // code here
        double z = 0;
        if (a > b)
        {
            z = b;
            if (z > c)
            {
                answer = z;
            }
            else
            {
                answer = c;
            }
        }
        else
        {
            z = a;
            if (z < c)
            {
                answer = c;
            }
            else
            {
                answer = z;
            }
        }
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        if ((Math.Sqrt(r / Math.PI)) * 2 >= Math.Sqrt(s + s))
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
        if ((Math.Sqrt(r / Math.PI)) * 2 <= Math.Sqrt(s))
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
            answer = 1;
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
            answer = 0;
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

        // code here
        double r, s = 0;
        for (int i = 0; i < n; i++)
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
        for (int i=1; i<=n; i++)
        {
            
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            double c = Math.Sqrt(Math.Pow(x - a, 2) + Math.Pow(y - b, 2));
            if (c <= r )
            {
                answer++;
            }

        }
        
        Console.WriteLine(answer);
        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -2.5 -0.5

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        // code here
        
        for (int i=1; i<=n; i++)
        {
            double ves = Convert.ToDouble(Console.ReadLine());
            if (ves < 30)
            {
                
                answer += 0.2;
            }
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here
        
        for (int i = 1; i<=n; i++)
        {
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            double k = Math.Sqrt(x * x + y * y);
            if (r1<=k && k <= r2)
            {
               answer += 1;
            }
        }
        
        Console.WriteLine(answer);
        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -0.5 -0.5

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

        // code here
        for (int i = 1; i<=n; i++)
        {
            double res = Convert.ToDouble(Console.ReadLine());
            if (res <= norm)
            {
                answer++;
            }
        }
        Console.WriteLine(answer);
        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;

        // code here
        for (int i = 1; i<= n; i++)
        {
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            if (Math.PI>= x && x >= 0 && y<= Math.Sin(x) && y>=0)
            {
                answer++;
            }
        }
        Console.WriteLine(answer);
        // end

        // for test input in console: 1.2 0.7, 2 0.2, 0.5 0.9, -1 1.5, 0.5 0.1

        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;

        // code here
        int answer2 = 0;
        int answer4 = 0;
        for (int i = 1; i<=n; i++)
        {
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            if (x>0 && y > 0)
            {
                answer1++;
                Console.WriteLine("1 quadrant\n");
            }
            if (x>0 && y < 0)
            {
                answer2++;
                Console.WriteLine("2 quadrant\n");
            }
            if (x < 0 && y < 0)
            {
                answer3++;
                Console.WriteLine("3 quadrant\n");
            }
            if (x < 0 && y > 0)
            {
                answer4++;
                Console.WriteLine("4 quadrant\n");
            }
            
        }
        Console.WriteLine(answer1);
        Console.WriteLine(answer3);
        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5

        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;

        // code here
        for (int i = 1; i<=n; i++)
        {
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            double k = Math.Sqrt(x * x + y * y);
            if (k < answerLength)
            {
                answer = i;
                answerLength = k;
            }


        }
        answerLength = Math.Round(answerLength, 2);
        Console.WriteLine(answer);
        Console.WriteLine(answerLength);

        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -0.5

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        for (int i = n; i > 0; i--)
        {
            double rez = Convert.ToDouble(Console.ReadLine());
            if (rez < answer)
            {
                answer = rez;
            }
        }
        Console.WriteLine(answer);
        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;
        for (int i = n; i > 0; i--)
        {
            double k1 = Convert.ToDouble(Console.ReadLine());
            double k2 = Convert.ToDouble(Console.ReadLine());
            double k3 = Convert.ToDouble(Console.ReadLine());
            double k4 = Convert.ToDouble(Console.ReadLine());
            if (k1 != 2 && k1 != 3 && k2 != 2 && k2 != 3 && k3 != 2 && k3 != 3 && k4 != 2 && k4 != 3)
            {
                answer ++;
            }
            Console.WriteLine(answer);
        }
        // end

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;

        // code here;
        double sum1 = 0,sum2 = 0;
        for (int i = n; i > 0; i--)
        {
            double ex1 = Convert.ToDouble(Console.ReadLine());
            double ex2 = Convert.ToDouble(Console.ReadLine());
            double ex3 = Convert.ToDouble(Console.ReadLine());
            double ex4 = Convert.ToDouble(Console.ReadLine());
            sum2++;
            if (ex1 == 2 || ex2 == 2 || ex3 == 2 || ex4 == 2)
            {
                answer++;
            }
            sum1 += ex1 + ex2 + ex3 + ex4;
        }
        avg = sum1 / (sum2 * 4);
        Console.WriteLine(answer);
        Console.WriteLine(avg);
        
        
        // end

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4

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
                    answer = Math.PI * r * r;
                    break;
                case 2:
                    answer = r * r * Math.Sqrt(3) / 4;
                    break;
                default:
                    answer = 0;
                    break;

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
                    answer = A * B;
                   break;

                case 1:
                    answer = Math.Abs(Math.PI * A * A - Math.PI * B * B);
                    break;

                case 2:
                    answer = Math.Sqrt(B * B - A * A / 4) * A / 2;
                    break;

                default:
                    answer = 0;
                    break;

            }

        }
        answer = Math.Round(answer, 2);
        
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
        int i = 0;
        for (;;i++)
        {
            string input = Console.ReadLine();
            if (input != "")
            {
                r = Convert.ToDouble(input);
                s = s + r;
            }
            else break;
        }
        answer = s / i;
        Console.WriteLine(answer);
        // end

        // for test input in console: 168, 147, 174, 154, 180, 149, 166, 160, 175, 161
        // answer should be equal to the task_2_1 answer

        return answer;
    }
    public int Task_3_2(double r, double a, double b)
    {
        int answer = 0, n = 0;

        // code here

        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -2.5 -0.5
        // answer should be equal to the task_2_2 answer

        return answer;
    }
    public double Task_3_3()
    {
        double answer = 0;
        int n = 0;

        // code here
        
        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5
        // answer should be equal to the task_2_3 answer

        return answer;
    }
    public int Task_3_4(double r1, double r2)
    {
        int answer = 0, n = 0;

        // code here

        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -0.5 -0.5
        // answer should be equal to the task_2_4 answer

        return answer;
    }
    public int Task_3_5(double norm)
    {
        int answer = 0, n = 0;

        // code here
        for (; ;)
        {
            string input = Console.ReadLine();
            if (input != "")
            {
                double res = Convert.ToDouble(input);
                if (res <= norm)
                {
                    answer++;
                }
            }
            else break;
            
        }
        Console.WriteLine(answer);

        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5
        // answer should be equal to the task_2_5 answer

        return answer;
    }
    public int Task_3_6()
    {
        int answer = 0, n = 0;

        // code here

        // end

        // for test input in console: 1.2 0.7, 2 0.2, 0.5 0.9, -1 1.5, 0.5 0.1
        // answer should be equal to the task_2_6 answer

        return answer;
    }
    public (int, int) Task_3_7()
    {
        int answer1 = 0, answer3 = 0, n = 0;

        // code here

        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5
        // answer should be equal to the task_2_7 answer

        return (answer1, answer3);
    }
    public (int, double) Task_3_8()
    {
        int answer = 0, n = 0;
        double answerLength = double.MaxValue;

        // code here
        for (int i=1; ;i++)
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            if (input1 != "" && input2 != "")
            {
                double x = Convert.ToDouble(input1);
                double y = Convert.ToDouble(input2);
                double k = Math.Sqrt(x * x + y * y);
                
                if (k < answerLength)
                {
                    answer = i;
                    answerLength = k;
                }
            
            }
            else break;

        }
        answerLength = Math.Round(answerLength, 2);
        Console.WriteLine(answer);
        Console.WriteLine(answerLength);
        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -0.5
        // answer should be equal to the task_2_8 answer

        return (answer, answerLength);
    }
    public double Task_3_9()
    {
        double answer = double.MaxValue;
        int n = 0;

        // code here

        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5
        // answer should be equal to the task_2_9 answer

        return answer;
    }
    public int Task_3_10()
    {
        int answer = 0, n = 0;

        // code here;

        // end

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4
        // answer should be equal to the task_2_10 answer

        return answer;
    }
    public (int, double) Task_3_11()
    {
        int answer = 0, n = 0;
        double avg = 0.0;

        // code here;
        double sum1 = 0, sum2 = 0;
        for (; ;)
        {
            string input1 = Console.ReadLine();
            
            if (input1 != "")
            {
                string input2 = Console.ReadLine();
                string input3 = Console.ReadLine();
                string input4 = Console.ReadLine();
                double ex1 = Convert.ToDouble(input1);
                double ex2 = Convert.ToDouble(input2);
                double ex3 = Convert.ToDouble(input3);
                double ex4 = Convert.ToDouble(input4);
                sum2++;
                if (ex1 == 2 || ex2 == 2 || ex3 == 2 || ex4 == 2)
                {
                    answer++;
                }
                sum1 += ex1 + ex2 + ex3 + ex4;
            }
            else break;
        }
        avg = sum1 / (sum2 * 4);
        Console.WriteLine(answer);
        Console.WriteLine(avg);
        // end

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4
        // answer should be equal to the task_2_11 answer

        return (answer, avg);
    }
    public double Task_3_12(double r, int type)
    {
        double answer = 0;

        // code here;

        // end
        // answer should be equal to the task_2_12 answer

        return answer;
    }
    public double Task_3_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;

        // end
        // answer should be equal to the task_2_13 answer

        return answer;
    }
    #endregion
}
