using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;

public class Program
{
    static double Min(double a, double b) {
        double result = (a <= b) ? a : b;
        return result;
    }

    static double Max(double a, double b) {
        double result = (a >= b) ? a : b;
        return result;
    }
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
        //program.Task_2_2(5, 1, 3, 1);
        //program.Task_2_3(10);
        //program.Task_2_4(5, 1, 2); 
        //program.Task_2_5(10, 25.2);
        //program.Task_2_6(5);
        //program.Task_2_7(5);
        Console.WriteLine(program.Task_2_8(5));
        //program.Task_2_9(10);
        //program.Task_2_10(10);
        //program.Task_2_11(10);
        //program.Task_2_12(10, 0);
        //program.Task_2_13(10, 5, 0);
        //program.Task_3_1(10);
        // program.Task_3_2(3, 2, 1);
        // program.Task_3_3(10);
        // program.Task_3_4(1, 2);
        // program.Task_3_5(10, 30);
        // program.Task_3_6();
        // program.Task_3_7(5);
        // program.Task_3_8();
        // program.Task_3_9(10);
        // program.Task_3_10();
        // program.Task_3_11(10);
        // program.Task_3_12(1.5, 0);
        // program.Task_3_13(10, 5, 0);
    }
    #region Level 1
    public bool Task_1_1(double x, double y)
    {
        bool answer = false;

        // code here
        int R = 2;

        answer = Math.Abs(x * x + y * y - R * R) <= 0.001;
        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        answer = (y <= x + 1) && (y <= -x + 1) && (y >= 0);

        // end

        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;

        // code here
        answer = (a > 0) ? Max(a, b) : Min(a, b);
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        // code here
        answer = Max(Min(a, b), c);
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        double squareSide = Math.Sqrt(s);
        double squareDiagonal = squareSide * Math.Sqrt(2);

        double circleRadius = Math.Sqrt(r / Math.PI);
        double circleDiameter = 2 * circleRadius;

        answer = squareDiagonal <= circleDiameter;
        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        double squareSide = Math.Sqrt(s);

        double circleRadius = Math.Sqrt(r / Math.PI);
        double circleDiameter = 2 * circleRadius;

        answer = circleDiameter <= squareSide;
        // end

        return answer;
    }
    public double Task_1_7(double x)
    {
        double answer = 0;

        // code here
        answer = (Math.Abs(x) > 1) ? 1 : Math.Abs(x);
        // end

        return answer;
    }
    public double Task_1_8(double x)
    {
        double answer = 0;

        // code here
        answer = (Math.Abs(x) >= 1) ? 0 : (x * x - 1);

        // end

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1) answer = 0;
        else if (x > -1 && x <= 0) answer = 1 + x;
        else answer = 1;

        // end

        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1) answer = 1;
        else if (x > -1 && x <= 1) answer = -x;
        else answer = -1;

        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(int n)
    {
        double answer = 0, sum = 0, height;
        // code here
        for (int i = 0; i < n; i++) {
            height = double.Parse(Console.ReadLine());
            sum += height;
        }

        answer = sum / n;
        // end

        // for test input in console: 168, 147, 174, 154, 180, 149, 166, 160, 175, 161

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;
        double x, y;

        // code here
        for (int i = 0; i < n; i++)
        {   
            string[] nums = Console.ReadLine().Split();
            x = double.Parse(nums[0]);
            y = double.Parse(nums[1]);

            if ((x - a) * (x - a) + (y - b) * (y - b) <= r * r) answer++;
        }

        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -2.5 -0.5

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        double baseAmount = 0, weight; 
        // code here
        for (int i = 0; i < n; i++) {

            weight = double.Parse(Console.ReadLine());
            answer += baseAmount;

            if (weight < 30) answer += 0.2;

        }

        
        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;
        double x, y;
        // code here
        for (int i = 0; i < n; i++) {
            string[] nums = Console.ReadLine().Split();
            x = double.Parse(nums[0]);
            y = double.Parse(nums[1]);

            if (
                (x * x + y * y >= r1 * r1)
                &&
                (x * x + y * y <= r2 * r2)
            ) answer++;

        }

        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -0.5 -0.5

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;
        double result;

        // code here
        for (int i = 0; i < n; i++) {
            result = double.Parse(Console.ReadLine());
            if (result < norm) answer++;
        }
        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;
        double x, y;
        // code here
        for (int i = 0; i < n; i++) {
            string[] nums = Console.ReadLine().Split();
            x = double.Parse(nums[0]);
            y = double.Parse(nums[1]);

            if ((x >= 0 && x <= Math.PI) && (y >= 0 && y <= Math.Sin(x))) answer++;
        }
        // end

        // for test input in console: 1.2 0.7, 2 0.2, 0.5 0.9, -1 1.5, 0.5 0.1

        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;
        double x, y;
        // code here
        for (int i = 0; i < n; i++) {
            string[] nums = Console.ReadLine().Split();
            x = double.Parse(nums[0]);
            y = double.Parse(nums[1]);

            int quadrant = 1;
            if (x < 0 && y > 0) quadrant = 2;
            else if (x < 0 && y < 0) quadrant = 3;
            else if (x > 0 && y < 0) quadrant = 4;

            Console.WriteLine("Квадрант: " + quadrant);

            if (quadrant == 1) answer1++;
            else if (quadrant == 3) answer3++;
        }
        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5

        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue, x, y;


        // code here
        for (int i = 1; i <= n; i++) {
            string[] nums = Console.ReadLine().Split();
            x = double.Parse(nums[0]);
            y = double.Parse(nums[1]);

            double distance = Math.Sqrt(x * x + y * y);

            if (distance < answerLength) {
                answerLength = distance;
                answer = i;
            }
        }
        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -0.5

        return (answer, Math.Round(answerLength, 2));
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue, result;

        // code here
        for (int i = 0; i < n; i++)
        {
            result = double.Parse(Console.ReadLine());

            if (result < answer) answer = result;
        }

        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0, a, b, c, d;
        bool aValid, bValid, cValid, dValid;
        // code here;
        for (int i = 0; i < n; i++) {
            
            string[] nums = Console.ReadLine().Split();
            a = int.Parse(nums[0]);
            b = int.Parse(nums[1]);
            c = int.Parse(nums[2]);
            d = int.Parse(nums[3]);
 
            aValid = a != 2 && a != 3;
            bValid = b != 2 && b != 3;
            cValid = c != 2 && c != 3;
            dValid = d != 2 && d != 3;

            if (aValid && bValid && cValid && dValid) answer++;
        }

        // end

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0, sum = 0;

        double a, b, c, d;
        // code here;
        for (int i = 0; i < n; i++) {

            string[] nums = Console.ReadLine().Split();
            a = int.Parse(nums[0]);
            b = int.Parse(nums[1]);
            c = int.Parse(nums[2]);
            d = int.Parse(nums[3]);
 

            if (a == 2 || b == 2 || c == 2 || d == 2) answer++;

            sum += a + b + c + d;

        }

        avg = sum / (4 * n);
        // end

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        if (r <= 0 || type < 0 || type > 2) return 0;

        double answer = 0;

        // code here;
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
        }

        // end

        return Math.Round(answer, 2);
    }
    public double Task_2_13(double A, double B, int type)
    {
        if (A <= 0 || B <= 0 || type < 0 || type > 2) return 0;

        double answer = 0;

        // code here;
        switch (type) {
            case 0:
                answer = A * B;
                break;
            case 1:
                answer = Math.PI * (B * B - A * A);
                break;
            case 2:
                double p = (A + B + B) / 2;


                answer = Math.Sqrt(p * (p - A) * (p - B) * (p - B)); 
                break;

        }

        if (answer < 0) answer = 0;
        // end
        return Math.Round(answer, 2);
    }
    #endregion

    #region Level 3
    public double Task_3_1()
    {
        double answer = 0;

        // code here

        // end

        // for test input in console: 168, 147, 174, 154, 180, 149, 166, 160, 175, 161
        // answer should be equal to the task_2_1 answer

        return answer;
    }
    public int Task_3_2(double r, double a, double b)
    {
        int answer = 0;

        // code here
        string s = Console.ReadLine();

        double x, y;

        while (s != "#") {
            string[] nums = s.Split();
            x = double.Parse(nums[0]);
            y = double.Parse(nums[1]);

            if ((x - a) * (x - a) + (y - b) * (y - b) <= r * r) answer++;

            s = Console.ReadLine();

        }
        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -2.5 -0.5
        // answer should be equal to the task_2_2 answer

        return answer;
    }
    public double Task_3_3()
    {
        double answer = 0;

        // code here

        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5
        // answer should be equal to the task_2_3 answer

        return answer;
    }
    public int Task_3_4(double r1, double r2)
    {
        int answer = 0;

        // code here
        string s = Console.ReadLine();

        double x, y;

        while (s != "#") {
            string[] nums = s.Split();
            x = double.Parse(nums[0]);
            y = double.Parse(nums[1]);

            if (
                (x * x + y * y >= r1 * r1)
                &&
                (x * x + y * y <= r2 * r2)
            ) answer++;

            s = Console.ReadLine();

        }
        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -0.5 -0.5
        // answer should be equal to the task_2_4 answer

        return answer;
    }
    public int Task_3_5(double norm)
    {
        int answer = 0;

        // code here

        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5
        // answer should be equal to the task_2_5 answer

        return answer;
    }
    public int Task_3_6()
    {
        int answer = 0;

        // code here
        string s = Console.ReadLine();

        double x, y;

        while (s != "#") {
            string[] nums = s.Split();
            x = double.Parse(nums[0]);
            y = double.Parse(nums[1]);

            if ((x >= 0 && x <= Math.PI) && (y >= 0 && y <= Math.Sin(x))) answer++;

            s = Console.ReadLine();

        }
        // end

        // for test input in console: -1.2 0.7, 2 2, 0.5 0.9, -1 1.5, 0.5 1.5
        // answer should be equal to the task_2_6 answer

        return answer;
    }
    public (int, int) Task_3_7()
    {
        int answer1 = 0;
        int answer3 = 0;

        // code here

        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5
        // answer should be equal to the task_2_7 answer

        return (answer1, answer3);
    }
    public (int, double) Task_3_8()
    {
        int answer = 0, i = 1;
        double answerLength = double.MaxValue;

        // code here
        string s = Console.ReadLine();

        double x, y;


        while (s != "#") {
            string[] nums = s.Split();
            x = double.Parse(nums[0]);
            y = double.Parse(nums[1]);

            double distance = Math.Sqrt(x * x + y * y);

            if (distance < answerLength) {
                answerLength = distance;
                answer = i;
            }

            s = Console.ReadLine();
            
            i++;
        }
        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5
        // answer should be equal to the task_2_8 answer

        return (answer, Math.Round(answerLength, 2));
    }
    public double Task_3_9()
    {
        double answer = double.MaxValue;

        // code here

        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5
        // answer should be equal to the task_2_9 answer

        return answer;
    }
    public int Task_3_10()
    {
        int answer = 0, a, b, c, d;

        // code here;
        string s = Console.ReadLine();
        bool aValid, bValid, cValid, dValid;

        while (s != "#") {
            string[] nums = s.Split();
            a = int.Parse(nums[0]);
            b = int.Parse(nums[1]);
            c = int.Parse(nums[2]);
            d = int.Parse(nums[3]);
 
            aValid = a != 2 && a != 3;
            bValid = b != 2 && b != 3;
            cValid = c != 2 && c != 3;
            dValid = d != 2 && d != 3;

            if (aValid && bValid && cValid && dValid) answer++;

            s = Console.ReadLine();

        }
        // end

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4
        // answer should be equal to the task_2_10 answer

        return answer;
    }
    public (int, double) Task_3_11()
    {
        int answer = 0;
        double avg = 0.0;

        // code here;

        // end

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4
        // answer should be equal to the task_2_11 answer

        return (answer, avg);
    }
    public double Task_3_12(double r, int type)
    {
        if (r <= 0 || type < 0 || type > 2) return 0;

        double answer = 0;

        // code here;
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
        }

        // end

        return Math.Round(answer, 2);
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
