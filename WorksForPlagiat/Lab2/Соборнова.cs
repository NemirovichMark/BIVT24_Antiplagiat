using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        double r = 2;

        bool answer = false;

        if (Math.Abs(x * x + y * y - r * r) <= 0.001)
        {
            answer = true;
        }

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        if (y >= 0 & Math.Abs(x) + y <=1)
        {
            answer = true;
        }

        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;

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

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        answer = b;
        if (a < b)
            answer = a;
        if (c > answer)
            answer = c;

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false; 

        double d = 0;
        double k = 0;
        d = Math.Sqrt(r / Math.PI) * 2;
        k = Math.Sqrt(s)*Math.Sqrt(2);
        if (d >= k)
        {
            answer = true;
        }

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {

        bool answer = false;

        if (Math.Sqrt(r / Math.PI) * 2 <= Math.Sqrt(s))
        {
            answer = true;
        }

        return answer;
    }
    public double Task_1_7(double x)
    {
        double answer = 0;

        if (Math.Abs(x) > 1)
        {
            answer = 1;
        }
        else
        {
            answer = Math.Abs(x);
        }


        return answer;
    }
    public double Task_1_8(double x)
    {
        double answer = 0;
        if (Math.Abs(x) >=1)
        {
            answer = 0;
        }
        else
        {
            answer = x * x - 1;
        }

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;
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
        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;
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
        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(int n)
    {
        double answer = 0;

        // code here
        double summr = 0;
        Console.WriteLine("введите рост школьников");
        for (int i = 1; i<=n;i++)
        {
            Console.WriteLine("рост {0} школьника:", i);
            int heigh = int.Parse(Console.ReadLine());
            summr += heigh;

        }
        answer = summr / n;
        Console.WriteLine(answer);
        // end

        // for test input in console: 168, 147, 174, 154, 180, 149, 166, 160, 175, 161

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        for (int i = 0; i < n; i++)
        {
            Console.Write($"введите координаты точки {i + 1} (x y): ");
            string[] input = Console.ReadLine().Split(' ');
            double x = Convert.ToDouble(input[0]);
            double y = Convert.ToDouble(input[1]);
            if ((a - x) * (a - x) + (b - y) * (b - y) < r * r)
            {
                answer++;
            }
        }

        Console.WriteLine(answer);
        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        // code here
        double summr = 0;
        Console.WriteLine("введите вес школьников");
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("вес {0} школьника:", i);
            double weight = double.Parse(Console.ReadLine());
            if (weight < 30)
            {
                summr += 200;
            }
            
        }
        answer = summr/1000;
        Console.WriteLine(answer);

        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here
        int count = 0;

        for (int i = 0; i < n; i++)
        {
            Console.Write($"введите координаты точки {i + 1} (x y): ");
            string[] input = Console.ReadLine().Split(' ');
            double x = Convert.ToDouble(input[0]);
            double y = Convert.ToDouble(input[1]);

            double dist = Math.Sqrt(x * x + y * y);
            if (dist >= r1 && dist <= r2)
            {
                count++;
            }
        }

        answer = count;
        Console.WriteLine(answer);

        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -0.5 -0.5

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

        // code here
        int count = 0;
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("результат {0} спортсмена:", i);
            double res = double.Parse(Console.ReadLine());
            if (res <= norm)
            {
                count++;
            }
            

        }
        answer = count;
        Console.WriteLine(answer);
        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;

        // code here
        int count = 0;

        for (int i = 0; i < n; i++)
        {
            Console.Write($"введите координаты точки {i + 1} (x y): ");
            string[] input = Console.ReadLine().Split(' ');
            double x = Convert.ToDouble(input[0]);
            double y = Convert.ToDouble(input[1]);

            if (x > 0 && x < Math.PI && Math.Sin(x) > y && y > 0)
            {
                count += 1;
            }
        }

        answer = count;
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
        for (int i = 0; i < n; i++)
        {
            Console.Write($"введите координаты точки {i + 1} (x y): ");
            string[] input = Console.ReadLine().Split(' ');
            double x = Convert.ToDouble(input[0]);
            double y = Convert.ToDouble(input[1]);

            if (x >= 0 && y >= 0)
            {
                answer1 += 1;
            }
            else if ( x < 0 && y < 0)
            {
                answer3 += 1;
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
        for (int i = 0; i < n; i++)
        {
            Console.Write($"введите координаты точки {i + 1} (x y): ");
            string[] input = Console.ReadLine().Split(' ');
            double x = Convert.ToDouble(input[0]);
            double y = Convert.ToDouble(input[1]);

            double length1 = Math.Sqrt(x * x + y * y);
            if (answerLength > length1)
            {
                answerLength = length1;
                answer = i + 1;
            }

        }
    
        Console.WriteLine(answer);
        Console.WriteLine(answerLength);
        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -0.5

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;
        double best = 100830809380;
        // code here
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("результат {0} спортсмена:", i);
            double res = double.Parse(Console.ReadLine());
            if (res < best)
            {
                best = res;
            }
        }
        answer = best;
        Console.WriteLine(answer);

        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;

        for (int i = 0; i < n; i++)
        {
            Console.Write($"введите 4 оценки {i + 1} (x y z w): ");
            string[] input = Console.ReadLine().Split(' ');
            double x = Convert.ToDouble(input[0]);
            double y = Convert.ToDouble(input[1]);
            double z = Convert.ToDouble(input[2]);
            double w = Convert.ToDouble(input[3]);

            if (x !=  2 && y != 2 && z != 2 && w != 2 && x != 3 && y != 3 && z != 3 && w != 3)
            {
                answer += 1;
            }
        

        }
        Console.WriteLine(answer);
        // end

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;
        double sum = 0.0;
        // code here;
        for (int i = 0; i < n; i++)
        {
            Console.Write($"введите 4 оценки {i + 1} (x y z w): ");
            string[] input = Console.ReadLine().Split(' ');
            double x = Convert.ToDouble(input[0]);
            double y = Convert.ToDouble(input[1]);
            double z = Convert.ToDouble(input[2]);
            double w = Convert.ToDouble(input[3]);
            sum += x;
            sum += y;
            sum += z;
            sum += w;

            if (x == 2 || y == 2 || z == 2 || w == 2)
            {
                answer += 1;
            }
        }
        avg = sum / (n * 4);
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
        if (r < 0)
        {
            return 0;
        }
            
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
                break;
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
        if (A <= 0 || B <= 0)
        {
            return 0;
        }

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

        answer = Math.Round(answer, 2);

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
       

        string[] line = Console.ReadLine().Split(' ');
        while (line[0] != "end")
        {

            double x = Convert.ToDouble(line[0]);
            if (line[0] == "end") break;
            double y = Convert.ToDouble(line[1]);

            if ((a - x) * (a - x) + (b - y) * (b - y) < r * r)
            {
                answer++;
                
            }
            line = Console.ReadLine().Split(' ');
            
        }

        Console.WriteLine(answer);
        
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
        string line = Console.ReadLine();
        while (line != "end")
        {
            double res = double.Parse(line);
            if (res <= norm)
            {
                answer += 1;
            }
            line = Console.ReadLine();
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

        int answer = 0, num = 0; double x = 0, y = 0;
        double answerLength = double.MaxValue;


        while (double.TryParse(Console.ReadLine(), out x) && double.TryParse(Console.ReadLine(), out y))
        {
            num++;

            if (answerLength > Math.Sqrt(x * x + y * y))
            {
                answerLength = Math.Sqrt(x * x + y * y);
                answer = num;
            }
        }

        Console.WriteLine(answer);
        Console.WriteLine(answerLength);

        return (answer, answerLength);
       
        //// for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -0.5
        //// answer should be equal to the task_2_8 answer

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
        string[] line = Console.ReadLine().Split(' ');

        while (line[0] != "end")
        {
            
            double x = double.Parse(line[0]);
            
            if (line[0] == "end") break;
            double y = double.Parse(line[1]);
            
            double z = double.Parse(line[2]);
            
            
            double w = double.Parse(line[3]);
            avg += (x + y + z + w) / 4;

            if (x == 2 || y == 2 || z == 2 || w == 2)
            {
                answer++;
            }
            
            
            n++;
            line = Console.ReadLine().Split(' ');
        }
        avg /= n;
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
