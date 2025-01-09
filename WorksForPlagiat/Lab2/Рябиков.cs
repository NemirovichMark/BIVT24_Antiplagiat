using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Net.Http.Headers;
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

        // code here
        double r = 2;
        if (Math.Abs((x * x) + (y * y) - (r * r)) <= 0.001)
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
            return answer = true;
        }
        else
        {
            return answer = false;
        }

        // end

        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;

        // code here
        double c;
        if (a > 0)
        {
            c = a;
            if (b > c)
            {
                c = b;
            }
            answer = c;
        }
        else
        {
            c = a;
            if (b < c)
            {
                c = b;
            }
            answer = c;
        }
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        // code here
        double min, max;
        if ( a < b)
        {
            min = a;
        }
        else
        {
            min = b;
        }
        if (min > c)
        {
            max = min;
        }
        else
        {
            max = c;
        }
        answer = max;
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        double radius = Math.Sqrt(r / Math.PI);
        double diametr = 2 * radius;
        double diagonalkv = Math.Sqrt(2) * Math.Sqrt(s);
        if (diametr >= diagonalkv)
        {
            return answer = true ;
        }
        else
        {
            return answer = false;
        }

        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        double radius = Math.Sqrt(r / Math.PI);
        double diametr = 2 * radius;
        double storonakv = Math.Sqrt(s);
        if (diametr <= storonakv)
        {
            return answer = true;
        }
        else
        {
            return answer = false;
        }
        // end

        return answer;
    }
    public double Task_1_7(double x)
    {
        double answer = 0;

        // code here
        double y;
        if (Math.Abs(x) > 1)
        {
            y = 1;
            answer = y;
        }
        else if(Math.Abs(x) <= 1)
        {
            y = Math.Abs(x);
            answer = y;
        }
        // end

        return answer;
    }
    public double Task_1_8(double x)
    {
        double answer = 0;

        // code here
        double y;
        if (Math.Abs(x) >= 1)
        {
            y = 0;
            answer = y;
        }
        else if (Math.Abs(x) < 1)
        {
            y = x * x - 1;
            answer = y;
        }
        // end

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        // code here
        double y;
        if (x <= -1)
        {
            y = 0;
            answer = y;
        }
        else if (-1 < x && x <= 0)
        {
            y = 1 + x;
            answer = y;
        }
        else if(x >0)
        {
            y = 1;
            answer = y;
        }
        // end

        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;

        // code here
        double y;
        if (x <= -1)
        {
            y = 1;
            answer = y;
        }
        else if (-1 < x && x <= 1)
        {
            y = -x;
            answer = y;
        }
        else if (x > 1)
        {
            y = -1;
            answer = y;
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
        n = 10;
        double sr, r, s = 0;
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("168 147 174 154 180 149 166 160 175 161");
            r = double.Parse(Console.ReadLine());
            s += r;
        }
        sr = s / n;
        answer = sr;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;
        // code here
        for (int i = 0; i < n; i += 1)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double distance = Math.Sqrt(Math.Pow(x - a, 2) + Math.Pow(y - b, 2));
            if (distance <= r)
            {
                answer += 1;
            }
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        // code here
        n = 6;
        double milk = 0, weight;
        for (int i = 0; i < n; i ++)
        {
            weight = double.Parse(Console.ReadLine());
            if (weight < 30)
            {
                milk += 0.2;
            }
        }
        answer += milk;
        Console.WriteLine(answer);

        // end

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here
        for(int i = 0; i < n; i++)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double distance = Math.Sqrt(x * x + y * y);
            if(distance >= r1 && distance <= r2)
            {
                answer += 1;
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
        for(int i = 0; i < n; i++)
        {
            double result = double.Parse(Console.ReadLine());
            if (result  <= norm)
            {
                answer += 1;
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
        for(int i = 0; i < n; i++)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if (x >= 0 && x <= Math.PI && y >= 0 && y <= Math.Sin(x))
            {
                answer += 1;
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

        // code here
        for(int i = 0; i < n; i++)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if (x > 0 && y > 0)
            {
                answer1 += 1;
                Console.WriteLine("1 quadrant");
            }
            else if (x < 0 && y < 0)
            {
                answer3 += 1;
                Console.WriteLine("3 quadrant");
            }
            else if (x > 0 && y < 0)
            {
                answer3 += 1;
                Console.WriteLine("4 quadrant");
            }
            else if(x < 0 && y > 0)
            {
                answer3 += 1;
                Console.WriteLine("2 quadrant");
            }
        }
        Console.WriteLine($"{answer1} \n {answer3}");
        // end

        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;

        // code here
        n = 4;
        for(int i = 0; i < n; i++)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double dlina = Math.Sqrt(x * x + y * y);
            if (dlina < answerLength)
            {
                answer = i + 1;
                answerLength = dlina;
            }
        }
        answerLength = Math.Round(answerLength, 2);
        Console.WriteLine($"{answer} \n{answerLength}");
        // end

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        for(int i = 0;i < n;i++)
        {
            double bestResult = double.Parse(Console.ReadLine());
            if (answer > bestResult)
            {
                answer = bestResult;
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
        for(int i = 0;i < n;i++)
        {
            int mark1 = int.Parse(Console.ReadLine());
            int mark2 = int.Parse(Console.ReadLine());
            int mark3 = int.Parse(Console.ReadLine());
            int mark4 = int.Parse(Console.ReadLine());
            if (mark1 > 3 && mark2> 3 && mark3 > 3 && mark4 > 3)
            {
                answer += 1;
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
        double sum = 0;
        int cnt = 0;

        // code here;
        for (int i = 0; i < n; i++)
        {
            int mark1 = int.Parse(Console.ReadLine());
            int mark2 = int.Parse(Console.ReadLine());
            int mark3 = int.Parse(Console.ReadLine());
            int mark4 = int.Parse(Console.ReadLine());
            sum += mark1 + mark2 + mark3 + mark4;
            cnt += 4;
            if (mark1 < 3 || mark2 < 3 || mark3 < 3 || mark4 < 3)
            {
                answer += 1;
            }
        }
        avg = sum / cnt;
        avg = Math.Round(avg);
        Console.WriteLine($"{answer} \n{avg}");
        // end

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here;
        if (r < 0 || type < 0 || type > 2) return 0;
        switch (type)
        {
            case 0:
                answer = r * r; break;
            case 1:
                answer = Math.PI * r * r; break;
            case 2:
                answer = ( r * r * Math.Sqrt(3)) / 4; break;
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;
        if (type < 0 || type > 2 || A <= 0 || B <= 0) return 0;
        switch (type)
        {
            case 0:
                answer = A * B; break;
            case 1:
                answer =  Math.Abs(Math.PI * A * A - Math.PI * B * B); break;
            case 2:
                answer = Math.Sqrt( B * B - A * A /4 ) * A/2; break;
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
        while (true) 
        {
            Console.WriteLine("¬ведите start чтобы найти точку или stop чтобы получить результат ");
            string start = Console.ReadLine();
            if (start == "stop") break;
            else if (start == "start")
            {
                double x = double.Parse(Console.ReadLine());
                double y = double.Parse(Console.ReadLine());
                double distance = Math.Sqrt(Math.Pow(x - a, 2) + Math.Pow(y - b, 2));
                if (distance <= r)
                {
                    answer += 1;
                }
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
        while(true)
        {
            Console.WriteLine("¬ведите start чтобы записать результат или stop чтобы получить результат ");
            string start = Console.ReadLine();
            if (start == "stop") break;
            else if (start == "start")
            {
                double result = double.Parse(Console.ReadLine());
                if (result <= norm)
                {
                    answer += 1;
                }
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
        int i = 0;
        // code here
        while(true)
        {
            Console.WriteLine("¬ведите start чтобы ввести точки или stop чтобы получить результат ");
            string start = Console.ReadLine();
            if (start == "stop") break;
            else if (start == "start")
            {
                i++;
                double x = double.Parse(Console.ReadLine());
                double y = double.Parse(Console.ReadLine());
                double dlina = Math.Sqrt(x * x + y * y);
                if (dlina < answerLength)
                {
                    answer = i;
                    answerLength = dlina;
                }
            }
        }
        answerLength = Math.Round(answerLength, 2);
        Console.WriteLine($"{answer} \n{answerLength}");
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
        double sum = 0;
        int cnt = 0;
        // code here;
        while(true)
        {
            Console.WriteLine("¬ведите start чтобы ввести оценки студентов или stop чтобы получить результат ");
            string start = Console.ReadLine();
            if (start == "stop") break;
            else if (start == "start")
            {
                int mark1 = int.Parse(Console.ReadLine());
                int mark2 = int.Parse(Console.ReadLine());
                int mark3 = int.Parse(Console.ReadLine());
                int mark4 = int.Parse(Console.ReadLine());
                sum += mark1 + mark2 + mark3 + mark4;
                cnt += 4;
                if (mark1 < 3 || mark2 < 3 || mark3 < 3 || mark4 < 3)
                {
                    answer += 1;
                }
            }
        }
        avg = sum / cnt;
        avg = Math.Round(avg);
        Console.WriteLine($"{answer} \n{avg}");
        // end

        return (answer, avg);
    }
    #endregion
}