using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
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
        program.Task_2_6(4);
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

        int r = 2;

        // code here
        if (Math.Abs(x * x + y * y - r * r) <= 0.001)
             return answer = true;
        Console.WriteLine(answer);

        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here

        if (y >= 0 && y + Math.Abs(x) <= 1) answer = true;
        Console.WriteLine(answer);


        // end

        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;

        // code here

        if (a > 0)
            if (a > b)
                answer = a;
            else answer = b;
        else
            if (a < b)
                answer = a;
            else
                answer = b;



        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        // code here

        if (a < b)
            if (a > c)
                answer = a;
            else answer = c;
        else
            if (b > c)
                answer = b;
            else answer = c;

        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here

        if (2 * Math.Sqrt(r / Math.PI) > Math.Sqrt(s) * Math.Sqrt(2)) return answer = true;
        Console.WriteLine(answer);

        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here

        if (2 * Math.Sqrt(r / Math.PI) <= Math.Sqrt(s)) return answer = true;


        // end

        return answer;
    }
    public double Task_1_7(double x)
    {
        double answer = 0;

        // code here

        if (Math.Abs(x) > 1) return answer = 1;
        else return answer = Math.Abs(x);


        // end

        return answer;
    }
    public double Task_1_8(double x)
    {
        double answer = 0;

        // code here

        if (Math.Abs(x) >= 1) return answer = 0;
        else return answer = x * x - 1;

        // end

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1) return answer = 0;
        if (x <= 0 && x > -1) return answer = (1 + x);
        if (x > 0) return answer = 1;

        // end

        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;

        // code here

        if (x <= -1) return answer = 1;
        if (x <= 1 && x > -1) return answer = -x;
        if (x > 1) return answer = -1;
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(int n)
    {
        double answer = 0;

        // code here
        double temp = 0;
        for (int step = 0; step < n; step++)
        {
            temp += int.Parse(Console.ReadLine());
            answer = temp / n * 1.0;
        }
        // end
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // for test input in console: 168, 147, 174, 154, 180, 149, 166, 160, 175, 161

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0; double temp1 = 0; double temp2 = 0; double uslovie = 0;

        // code here

        for (int step = 0; step < n; step++)
        {
            temp1 = double.Parse(Console.ReadLine());
            temp2 = double.Parse(Console.ReadLine());
            uslovie = Math.Sqrt(((temp1 - a) * (temp1 - a)) + ((temp2 - b) * (temp2 - b)));
            if (uslovie<r)
                    answer++;
        }
        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -2.5 -0.5
        Console.WriteLine(answer);
        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0; double rebenok = 0;

        // code here
        for (int step = 0; step < n; step ++)
        {
            rebenok = double.Parse(Console.ReadLine());
            if (rebenok < 30)
                answer += 200;
        
        }
        answer /= 1000;
        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5
        Console.WriteLine(answer);
        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0; double temp1 = 0; double temp2 = 0; double rast = 0;

        // code here
        for (int step = 0; step < n; step++)
        {
            temp1 = double.Parse(Console.ReadLine());
            temp2 = double.Parse(Console.ReadLine());
            rast = Math.Sqrt(((temp1) * (temp1)) + ((temp2) * (temp2)));
            if (rast > r1 && rast < r2)
                answer++;
        }
        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -0.5 -0.5
        Console.WriteLine(answer);
        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0; double temp = 0;

        // code here

        for (int step = 0; step < n; step++)
        {
            temp = double.Parse(Console.ReadLine());
            if (temp < norm)
                answer++;
        }
        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5
        Console.WriteLine(answer);
        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0; double temp1, temp2 = 0;

        // code here
        for (int step = 0; step < n; step++)
        {
            temp1 = double.Parse(Console.ReadLine());
            temp2 = double.Parse(Console.ReadLine());
            if ((temp1 >= 0) && (temp1 <= Math.PI) && (Math.Sin(temp1) >= temp2))
                    answer++;
        } 
        // end
        Console.WriteLine(answer);
        // for test input in console: 1.2 0.7, 2 0.2, 0.5 0.9, -1 1.5, 0.5 0.1

        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;
        double temp1, temp2 = 0;

        // code here
        for (int step = 0; step < n; step++)
        {
            temp1 = double.Parse(Console.ReadLine());
            temp2 = double.Parse(Console.ReadLine());
            if (temp1 > 0 && temp2 > 0)
                answer1++;
            else if (temp1 < 0 && temp2 < 0)
                answer3++;


        }
        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5
        Console.WriteLine($"{answer1} and {answer3}");
        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;
        double temp1, temp2 = 0; double uslovie = 0;
        // code here
        for (int step = 1; step <= n; step++)
        {
            temp1 = double.Parse(Console.ReadLine());
            temp2 = double.Parse(Console.ReadLine());
            uslovie = Math.Round(Math.Sqrt(temp1 * temp1 + temp2 * temp2),2);
            if (uslovie < answerLength)
            { 
                answer = step;
                answerLength = uslovie;
            }
        }
        // end
        Console.WriteLine($"{answer} and {answerLength}");
        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;
        double temp = 0;
        // code here

        for (int step = 0; step < n; step ++)
        { 
            temp = double.Parse(Console.ReadLine());
            if (temp < answer)
                answer = temp;
        }
        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5
        Console.WriteLine(answer);
        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;
        int temp1,temp2,temp3,temp4 = 0;
        // code here;
        for (int step = 0; step < n; step++)
        {
            temp1 = int.Parse(Console.ReadLine());
            temp2 = int.Parse(Console.ReadLine());
            temp3 = int.Parse(Console.ReadLine());
            temp4 = int.Parse(Console.ReadLine());

            if (temp1 > 3 && temp2 > 3 && temp3 > 3 && temp4 > 3) answer++;

        }
        // end
        Console.WriteLine(answer);
        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;
        int temp1, temp2, temp3, temp4 = 0;
        // code here;
        for (int step = 0; step < n; step++)
        {
            temp1 = int.Parse(Console.ReadLine());
            temp2 = int.Parse(Console.ReadLine());
            temp3 = int.Parse(Console.ReadLine());
            temp4 = int.Parse(Console.ReadLine());

            avg += (temp1 + temp2 + temp3 + temp4);
            if (temp1 < 3 || temp2 < 3 || temp3 < 3 || temp4 < 3)
                answer++;
                
        }
        // end

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4
        avg = avg / (n * 4);
        Console.WriteLine($"{answer} and {avg}");
        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;
        if (r < 0) return answer = 0;
        switch (type)
        {
            case 0:
                answer = Math.Round((r * r),2);
                break;
            case 1:
                answer = Math.Round((Math.PI * r * r),2);
                break;
            case 2:
                answer = Math.Round(((r * r * Math.Sqrt(3)) / 4),2);
                break;
            default:
                break;
        }
        // end

        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0; double polu = 0;

        if (A <= 0 || B <= 0) return answer = 0;
        switch (type)
        {
            case 0:
                answer = Math.Round((A * B),2);
                break;
            case 1:
                if (A > B)
                {
                    answer = Math.Round((Math.PI * (A * A - B * B)), 2);
                }
                else if (B>A)
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
                answer = Math.Round((Math.Sqrt(polu*(polu-A)*(polu-B)*(polu-B))),2);
                if (answer > 0) return answer;
                else return answer = 0;
                break;
            default:
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
        int n = 0; double temp = 0;

        // code here
        while (true)
        {
            n++;
            temp = double.Parse(Console.ReadLine());
            if (temp == -1)
                break;
            answer += temp;
        }
        // end
        // for test input in console: 168, 147, 174, 154, 180, 149, 166, 160, 175, 161
        // answer should be equal to the task_2_1 answer
        answer = Math.Round((answer / (n-1)), 2);
        Console.WriteLine($"{answer} and {n-1}");
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
        int answer = 0, n = 0; double temp1 = 0; double temp2 = 0; double rast = 0;

        // code here

        while (true)
        {
            temp1 = double.Parse(Console.ReadLine());
            if (temp1 == -1)
                break;
            n++;
            temp2 = double.Parse(Console.ReadLine());
            rast = Math.Sqrt(((temp1) * (temp1)) + ((temp2) * (temp2)));
            if (rast > r1 && rast < r2)
                answer++;
        }
        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -0.5 -0.5
        // answer should be equal to the task_2_4 answer
        Console.WriteLine($"{answer} dot from {n} dots");

        return answer;
    }
    public int Task_3_5(double norm)
    {
        int answer = 0, n = 0;

        // code here

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
        double temp1, temp2 = 0;

        // code here
        while(true)
        {
            temp1 = double.Parse(Console.ReadLine());
            if (temp1 == -1)
                break;
            temp2 = double.Parse(Console.ReadLine());
            n++;
            if (temp1 > 0 && temp2 > 0)
                answer1++;
            else if (temp1 < 0 && temp2 < 0)
                answer3++;
        }
        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5
        // answer should be equal to the task_2_7 answer
        Console.WriteLine($"{answer1} and {answer3} and {n}");
        return (answer1, answer3);
    }
    public (int, double) Task_3_8()
    {
        int answer = 0, n = 0;
        double answerLength = double.MaxValue;

        // code here

        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5
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
        int temp1, temp2, temp3, temp4 = 0;
        while (true)
        {
            temp1 = int.Parse(Console.ReadLine());
            if (temp1 == -1)
                break;
            temp2 = int.Parse(Console.ReadLine());
            temp3 = int.Parse(Console.ReadLine());
            temp4 = int.Parse(Console.ReadLine());
            n++;

            if (temp1 > 3 && temp2 > 3 && temp3 > 3 && temp4 > 3) answer++;

        }
        // end
        Console.WriteLine($"{answer} and {n}");
        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4
        // answer should be equal to the task_2_10 answer

        return answer;
    }
    public (int, double) Task_3_11()
    {
        int answer = 0, n = 0;
        double avg = 0.0;

        // code here;

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
