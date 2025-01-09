using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Formats.Asn1;
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
            answer = Math.Max(a, b);
        }
        else
        {
            answer = Math.Min(a, b);
        }
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        // code here
        answer = Math.Max(Math.Min(a, b), c);
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        double a = Math.Sqrt(r / Math.PI);
        double b = Math.Sqrt(s);
        b = b / Math.Sqrt(2);
        if (b < a)
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
		double a = Math.Sqrt(r / Math.PI) * 2;
		double b = Math.Sqrt(s);
		if (b > a)
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
		else if (x <= 0)
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
		else if (x <= 1)
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
        double s = 0;
        for (int i = 1; i <= n; ++i)
        {
            int x = int.Parse(Console.ReadLine());
            s += x;
        }
        answer = s / n;
        // end

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

		// code here
		for (int i = 1; i <= n; ++i)
		{
			double x = double.Parse(Console.ReadLine()), y = double.Parse(Console.ReadLine());
			if (Math.Sqrt((x - a) * (x - a) + (y - b) * (y - b)) <= r)
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
        for (int i = 1; i <= n; ++i)
        {
            double x = double.Parse(Console.ReadLine());
            if (x < 30)
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
        for (int i = 1; i <= n; ++i)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double d = Math.Sqrt(x * x + y * y);
            if (d >= r1 && d <= r2)
            {
                answer++;
            }
        }
		// end

		return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

        // code here
        for (int i = 1; i <= n; ++i)
        {
            double y = double.Parse(Console.ReadLine());
            if (y <= norm)
            {
                answer++;
            }
        }
		// end

		return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;

        // code here
        for (int i = 1; i <= n; ++i)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if (x >= 0 && x <= Math.PI && y >= 0 && y <= Math.Sin(x))
            {
                answer++;
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
        for (int i = 1; i <= n; ++i)
        {
			double x = double.Parse(Console.ReadLine());
			double y = double.Parse(Console.ReadLine());
			if (x < 0 && y < 0)
			{
				answer3++;
			}
			if (x > 0 && y > 0)
			{
				answer1++;
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
        for (int i = 1; i <= n; ++i)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double r = Math.Sqrt(x * x + y * y);
            if (r < answerLength)
            {
                answerLength = r;
                answer = i;
            }
        }
		// end

		return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        for (int i = 1; i <= n; ++i)
        {
            double x = double.Parse(Console.ReadLine());
            if (x < answer)
            {
                answer = x;
            }
        }
		// end

		return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;
        for (int i = 1; i <= n; ++i)
        {
            int x1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int x3 = int.Parse(Console.ReadLine());
            int x4 = int.Parse(Console.ReadLine());
            if (x1 > 3 && x2 > 3 && x3 > 3 && x4 > 3)
            {
                answer++;
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
        double sum = 0.0;
		for (int i = 1; i <= n; ++i)
		{
			int x1 = int.Parse(Console.ReadLine());
			int x2 = int.Parse(Console.ReadLine());
			int x3 = int.Parse(Console.ReadLine());
			int x4 = int.Parse(Console.ReadLine());
			if (x1 == 2 || x2 == 2 || x3 == 2 || x4 == 2)
			{
				answer++;
			}
            sum += x1 + x2 + x3 + x4;
		}
        avg = sum / (n * 4);
		// end
		return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here;
        if (r < 0)
        {
            answer = 0;
        }
        else
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
			}
			answer = Math.Round(answer, 2);
		}
		// end
		return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;
        if (A < 0 || B < 0)
        {
            answer = 0;
        }
        else
        {
			switch (type)
			{
				case 0:
					answer = A * B;
					break;
				case 1:
					if (A > B)
					{
						double C = A;
						A = B;
						B = C;
					}
					answer = Math.PI * B * B - Math.PI * A * A;
					break;
				case 2:
					if (A > B + B)
					{
						answer = 0;
					}
					else
					{
						double h = Math.Sqrt(B * B - A * A / 4);
						answer = A * h / 2;
					}
					break;
			}
			answer = Math.Round(answer, 2);
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
        double x = 1;
		double s = 0;
		while (double.TryParse(Console.ReadLine(), out x) && x > 0)
		{
			s += x;
		}
		answer = s / n;
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
        double x = 0;
		while (double.TryParse(Console.ReadLine(), out x))
		{
			double y = double.Parse(Console.ReadLine());
			double d = Math.Sqrt(x * x + y * y);
			if (d >= r1 && d <= r2)
			{
				answer++;
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
		while (double.TryParse(Console.ReadLine(), out x))
		{
			double y = double.Parse(Console.ReadLine());
			if (x < 0 && y < 0)
			{
				answer3++;
			}
			if (x > 0 && y > 0)
			{
				answer1++;
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
        int x1 = 0;
		while (int.TryParse(Console.ReadLine(), out x1) && x1 > 0)
		{
			int x2 = int.Parse(Console.ReadLine());
			int x3 = int.Parse(Console.ReadLine());
			int x4 = int.Parse(Console.ReadLine());
			if (x1 > 3 && x2 > 3 && x3 > 3 && x4 > 3)
			{
				answer++;
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