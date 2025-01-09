using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
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

        double r = 2;
        if (Math.Abs(x * x + y * y - r * r) <= 0.001)
            answer = true;

        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here

        if ((y >= 0) && (y + Math.Abs(x) <= 1))
            answer = true;

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
        else
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

        if (a > b)
        {
            if (b > c)
                answer = b;
            else
                answer = c;
        }

        else
        {
            if (a < c)
                answer = c;
            else
                answer = a;
        }

        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here

        double radius = Math.Sqrt(r / Math.PI);
        double side = Math.Sqrt(s);
        double diagonal = side * Math.Sqrt(2);

        if (radius >= diagonal / 2)
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

        double radius = Math.Sqrt(r / Math.PI);
        double side = Math.Sqrt(s);

        if (radius <= side / 2)
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
        {
            answer = 1;
        }
        else
        {
            answer= Math.Abs(x);
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
        else if (x > -1 && x <= 0)
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

        if (x <= -1)
        {
            answer = 1;
        }
        else if (x > -1 && x <= 1)
        {
            answer = -x;
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

        for (int i = 1; i <= n; i++)
        {
            answer += Convert.ToDouble(Console.ReadLine());
        }
        answer /= 10;
        Console.WriteLine(answer);

        // end
        // for test input in console: 168, 147, 174, 154, 180, 149, 166, 160, 175, 161

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        // code here

        double x;
        double y;

        for (int i = 0; i <= n; i++)
        {
            x = Convert.ToDouble(Console.ReadLine());
            y = Convert.ToDouble(Console.ReadLine());
            if ((x - a) * (x - a) + (y - b) * (y - b) <= r * r);
            answer ++;
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

        double weight;
        for (int i = 1; i <= n; i++)
        {
            weight = Convert.ToDouble(Console.ReadLine());
            if (weight < 30)
            {
                answer += 0.2;
            }
        }
        Console.WriteLine(answer);

        // end
        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here

        double x;
        double y;
        for (int i = 1; i <= n; i++)
        {
            x = Convert.ToDouble(Console.ReadLine());
            y = Convert.ToDouble(Console.ReadLine());
            if (((x * x + y * y) >= r1 * r1) && ((x * x + y * y) <= r2 * r2))
            {
                answer++;
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
        double result;
        for (int i = 1; i <= n; i++)
        {
            result = Convert.ToDouble(Console.ReadLine());
            if (result <= norm)
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

        double x;
        double y;
        for (int i = 1; i <= n; i++)
        {
            x = Convert.ToDouble(Console.ReadLine());
            y = Convert.ToDouble(Console.ReadLine());
            if (((x >= 0) & (x <= Math.PI)) & ((y >= 0) & (y <= Math.Sin(x))))
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
        double x;
        double y;
        for (int i = 1; i <= n; i++)
        {
            x = Convert.ToDouble(Console.ReadLine());
            y = Convert.ToDouble(Console.ReadLine());
            if (x >= 0 && y >= 0)
            {
                answer1++;

            }
            else if (x < 0 && y < 0)
            {
                answer3++;

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

        double x;
        double y;
        for (int i = 1; i <= n; i++)
        {
            x = Convert.ToDouble(Console.ReadLine());
            y = Convert.ToDouble(Console.ReadLine());
            double distance = Math.Sqrt(x * x + y * y);
            if (distance < answerLength)
            {
                answer = i;
                answerLength = distance;
            }
        }
        Console.WriteLine(answer);
        Console.WriteLine(Math.Round(answerLength, 2));

        // end

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here

        double result;
        for (int i = 1; i <= n; i++)
        {
            result = Convert.ToDouble(Console.ReadLine());
            if (result < answer)
            {
                answer = result;
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

        for (int i = 1; i <= n; i++)
        {
            bool correct = true;
            for (int k = 1; k <= 4; k++)
            {
                double grade = Convert.ToDouble(Console.ReadLine());
                if (grade < 4) correct = false;
            }
            if (correct) answer++;
        }
        Console.WriteLine($"�����:{answer}");

        // end

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;

        // code here;

        for (int i = 1; i <= n; i++)
        {
            bool correct = false;
            for (int k = 1; k <= 4; k++)
            {
                double exam = Convert.ToDouble(Console.ReadLine());
                avg += exam;
                if (exam < 3) correct = true;
            }
            if (correct) answer++;
        }
        Console.WriteLine($"answer:{answer} \navg:{avg / (4 * n)}");

        // end

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here;

        if (r <= 0)
        {
            return 0;
        }

        switch (type)
        {
            case 0:
                {
                    answer = r * r;
                    break;
                }
            case 1:
                {
                    answer = Math.PI * r * r;
                    break;
                }
            case 2:
                {
                    answer = r * r * Math.Sqrt(3) / 4;
                    break;
                }

        }
        
        // end

        return Math.Round(answer, 2);
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;

        switch (type)
        {
            case 0:
                {
                    answer = A * B;
                    break;
                }
            case 1:
                {
                    answer = Math.Abs(Math.PI * (A * A - B * B));
                    break;
                }
            case 2:
                {
                    double p = (A + B + B) / 2;
                    answer = Math.Sqrt(p * (p - A) * (p - B) * (p - B));
                    break;
                }
        }
        
        // end

        return Math.Round(answer, 2);
    }
    #endregion

    #region Level 3
    public double Task_3_1()
    {
        double answer = 0;
        int n = 0;

        // code here
        string height;
        double sum = 0;
        while (true)
        {
            height = Console.ReadLine();
            if (height == "stop")
            {
                break;
            }
            sum += int.Parse(height);
            n++;
        }
        answer = sum / n;
        
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

        double x;
        double y;
        string stop;

        while (true)
        {
            stop = Console.ReadLine();
            if (stop == "stop")
            {
                break;
            }
            else
            {
                x = double.Parse(stop);
                y = double.Parse(Console.ReadLine());
                if (((x * x + y * y) >= r1 * r1) && ((x * x + y * y) <= r2 * r2))
                {
                    answer++;
                }
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

        double x;
        double y;
        string stop;

        while (true)
        {
            stop = Console.ReadLine();
            if (stop == "stop")
            {
                break;
            }
            else
            {
                x = double.Parse(stop);
                string inputY = Console.ReadLine();
                if (inputY == "stop")
                {
                    break;
                }
                y = double.Parse(inputY);

                if (x >= 0 & y >= 0)
                {
                    answer1++;

                }
                else if (x < 0 & y < 0)
                {
                    answer3++;

                }

            }
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

        string stop;
        int grade1, grade2, grade3, grade4;
        while (true)
        {
            stop = Console.ReadLine();
            if (stop == "stop")
            {
                break;
            }
            else
            {
                grade1 = int.Parse(Console.ReadLine());
                grade2 = int.Parse(Console.ReadLine());
                grade3 = int.Parse(Console.ReadLine());
                grade4 = int.Parse(Console.ReadLine());
                if ((grade1 + grade2 + grade3 + grade4) >= 16)
                {
                    answer++;
                }
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
