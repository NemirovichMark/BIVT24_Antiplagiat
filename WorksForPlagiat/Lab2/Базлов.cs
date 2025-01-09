using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Formats.Asn1;
using System.Net.WebSockets;
using System.Runtime.InteropServices;
using System.Text.Json.Serialization;

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
        //program.Task_2_4(3, 1, 3);
        //program.Task_2_5(6, 25.2);
        //program.Task_2_6(5);
        program.Task_2_7(3);
        //program.Task_2_8(3);
        //program.Task_2_9(6);
        //program.Task_2_10(10);
        //program.Task_2_11(6);
        //program.Task_2_12(0, 2);
        //program.Task_2_13(-0.75, 1, 3);
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

        if (Math.Abs(x*x + y*y - r*r) <= 0.001) {
            answer = true;
        }
        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here

        if (y >= 0 && y + Math.Abs(x) <= 1) answer = true;

        // end

        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;

        // code here

        double max, min;

        if (a > b) max = a;
        else max = b;

        if (a < b) min = a;
        else min = b;

        if (a <= 0) answer = min;
        else answer = max;

        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        // code here
       
        double min_a_b;

        if (a < b) min_a_b = a;
        else min_a_b = b;

        if (min_a_b > c) answer = min_a_b;
        else answer = c;

        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        double d_circle, d_square;

        d_circle = Math.Sqrt(4 * r / Math.PI);
        d_square = Math.Sqrt(2 * s);

        if (d_circle >= d_square) answer = true;
        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        double d_circle, side_square;

        d_circle = Math.Sqrt(4 * r / Math.PI);
        side_square = Math.Sqrt(s);

        if (d_circle <= side_square) answer = true;
        // end

        return answer;
    }
    public double Task_1_7(double x)
    {
        double answer = 0;

        // code here

        if (Math.Abs(x) <= 1) answer = Math.Abs(x);
        else answer = 1;

        // end

        return answer;
    }
    public double Task_1_8(double x)
    {
        double answer = 0;

        // code here

        if (Math.Abs(x) < 1) answer = x * x - 1;

        // end

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        // code here

        if (-1 < x && x <= 0) answer = 1 + x;
        else if (x > 0) answer = 1;

        // end

        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;

        // code here

        if (x <= -1) answer = 1;
        else if (-1 < x && x <= 1) answer = - x;
        else answer = -1;

        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(int n)
    {
        double answer = 0;

        // code here

        double height, summary = 0;

        for (int i = 0; i < n; i++)
        {
            height = double.Parse(Console.ReadLine());

            summary += height;
        }

        answer = summary / n;
        Console.WriteLine(answer);
        // end

        // for test input in console: 168, 147, 174, 154, 180, 149, 166, 160, 175, 161

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        // code here

        double x, y;

        for (int i = 0; i < n; i++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());

            if (Math.Abs(x - a) < r && Math.Abs(y - b) < r) answer++;
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

        for (int i = 0; i < n; i++)
        {
            weight = double.Parse(Console.ReadLine());

            if (weight < 30) answer += 0.2;

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

        double x, y;

        for (int i = 0; i < n; i++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());

            if (x*x + y*y > r1*r1 && x*x + y*y < r2*r2) answer++;
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

        for (int i = 0; i < n; i++)
        {
            result = double.Parse(Console.ReadLine());

            if (result <= norm) answer++;
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

        double x = 0, y = 0;

        for (int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);

            if ((0 <= x && x <= Math.PI) && (0 <= y && y <= Math.Sin(x))) answer++;
            
            
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

        double x, y;

        for (int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);

            if (x > 0 && y > 0) {
                answer1++;
                Console.WriteLine("I");
            }
            if (x < 0 && y > 0) Console.WriteLine("II");
            if (x < 0 && y < 0)
            {
                answer3++;
                Console.WriteLine("III");
            }
            if (x > 0 && y < 0) Console.WriteLine("IV");
        }

        Console.WriteLine($"{answer1} {answer3}");

        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5

        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;

        // code here

        double x, y;

        for (int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);

            double length = Math.Pow(x * x + y * y, 0.5);

            if (i == 0) answerLength = length;
            else if (length < answerLength)
            {
                answerLength = length;
                answer = i + 1; 
            }
        }

        answerLength = Math.Round(answerLength, 2);

        Console.WriteLine($"answer = {answer}, length = {answerLength}");

        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here

        double time;

        for (int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out time);

            if (time < answer) answer = time;
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

        int grade_count = 4;
        int grade;  
        bool is_student_good = true;


        for (int i = 1; i <= n * grade_count; i++)
        {
            int.TryParse(Console.ReadLine(), out grade);

            if (grade == 2 || grade == 3) is_student_good = false;

            if (i % grade_count == 0)
            {
                if (is_student_good) answer++;
                is_student_good = true;
            }
        }

        Console.WriteLine($"answer = {answer}");

        // end

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;

        // code here;

        int grade_count = 4;
        int grade;
        bool is_student_good = true;


        for (int i = 1; i <= n * grade_count; i++)
        {
            int.TryParse(Console.ReadLine(), out grade);

            avg += grade;

            if (grade == 2) is_student_good = false;


            if (i % grade_count == 0)
            {
                if (!is_student_good) answer++;                
                is_student_good = true;
            }
        }

        avg = avg / (n * grade_count);

        Console.WriteLine($"answer = {answer}, avg = {avg}");

        // end

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here;

        if (r <= 0) return 0;

        switch (type)
        {
            case 0: answer = r * r; break;
            case 1: answer = Math.PI * r * r; break;
            case 2: answer = 0.5 * r * r * Math.Sin(Math.PI / 3); break;            
        }

        answer = Math.Round(answer, 2);

        // end

        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;

        if (A <= 0 || B <= 0) return 0;

        switch (type)
        {
            case 0: answer = A * B; break;
            case 1: answer = Math.Abs(Math.PI * A * A - Math.PI * B * B); break;
            case 2:
                double p = (A + 2 * B) * 0.5;
                answer = Math.Pow(p * (p - A) * (p - B) * (p - B), 0.5);
                break;
            
        }

        answer = Math.Round(answer, 2);

        // end

        Console.WriteLine(answer);

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

        double weight;
        bool input = true;

        do
        {
            input = double.TryParse(Console.ReadLine(), out weight);
            if (0 < weight && weight < 30) answer += 0.2;

        } while (input);

        Console.WriteLine(answer);

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

        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5
        // answer should be equal to the task_2_5 answer

        return answer;
    }
    public int Task_3_6()
    {
        int answer = 0, n = 0;

        // code here

        double x = 0, y = 0;
        bool input;

        do
        {        
            input = double.TryParse(Console.ReadLine(), out x);

            if (!input) break;

            input = double.TryParse(Console.ReadLine(), out y);         

            if ((0 <= x && x <= Math.PI) && (y <= Math.Sin(x))) answer++;

        } while (true);

        Console.WriteLine(answer);

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

        double time;
        bool input;

        do
        {
            input = double.TryParse(Console.ReadLine(), out time);
            if (time < answer && time != 0) answer = time;

        } while (input);

        Console.WriteLine(answer);

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
