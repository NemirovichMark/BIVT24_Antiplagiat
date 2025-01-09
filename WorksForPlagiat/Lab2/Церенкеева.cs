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
        bool answer = false;

        // code here
        int r = 2;
        if (Math.Abs(x * x + y * y - r * r) <= 0.001)
        {
            answer = true;
        }
        

        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        if ((y >= 0) && (y + Math.Abs(x) <= 1))
        {
            answer = true;

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
            if (a < b)
            {
                answer = a;
            }
            else
            {
                answer = b;
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
            answer = a;
            if (a > c)
            {
                answer = a;
            }
            else
            {
                answer = c;
            }
        }
        else
        {
            answer = b;
            if (b > c)
            {
                answer = b;
            }
            else
            {
                answer = c;
            }
        }
        

        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        if (r / Math.PI > Math.Sqrt(s) * Math.Sqrt(2))
        {
            answer = true;
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
        else if(x > -1 && x <= 0)
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
        else if ((-1 < x) && (x <= 1))
        {
            
            answer = -1 * x;
        }
        else if (x > 1)
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
        for (int i = 0; i <= n; i++)
        {
            double.TryParse(Console.ReadLine(), out double s);
            answer += s;
        }
        answer /= n;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        // code here
        double x;
        double y;
        for (int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if (Math.Sqrt((x - a) * (x - a) + (y - b) * (y - b)) <= r) answer++;
        }
        // end
        Console.WriteLine(answer);

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        // code here
        double s = 0;
        double ves;
        for (int i = 0; i < n; i++)
        {

            double.TryParse(Console.ReadLine(), out ves);
            if (ves < 30) 
            {
                s += 1;
            }
        }
        // end
        answer = s * 200 / 1000;
        Console.WriteLine(answer);

        

        // end

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here
        double a;
        double b;
        for (int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out a);
            double.TryParse(Console.ReadLine(), out b);
            if ((a * a + b * b < r2 * r2) && (a * a + b * b > r1 * r1))
            {
                answer += 1 ;
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
        for (int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out double r);
            if (r <= norm)
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
        for (int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out double x);
            double.TryParse(Console.ReadLine(), out double y);
            if (x >= 0 && x <= Math.PI && y <= Math.Sin(x) && y >= 0)
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
        for (int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out double x);
            double.TryParse(Console.ReadLine(), out double y);
            if (x > 0)
            {
                if (y > 0)
                {
                    answer1 += 1;
                    Console.WriteLine(1);
                }
                else
                {
                    Console.WriteLine(4);
                }
            }
            else
            {
                if (y > 0)
                {
                    Console.WriteLine(2);
                }
                else
                {
                    answer3 += 1;
                    Console.WriteLine(3);
                }
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
        for (int i = 0; i < n; i++)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            
            if (answerLength > Math.Sqrt(a * a + b * b))
            {
                answerLength = Math.Sqrt(a * a + b * b);
                answer = i + 1;
            }
        }
        
        // end

        
        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        for (int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(),out double r);
            if (r < answer)
            {
                answer = r;
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
        for (int i = 0; i < n; i++)
        {
            int.TryParse(Console.ReadLine(),out int n1);
            int.TryParse(Console.ReadLine(),out int n2);
            int.TryParse(Console.ReadLine(),out int n3);
            int.TryParse(Console.ReadLine(),out int n4);
            if (n1 >= 4 && n2 >= 4 && n3 >= 4 && n4 >=4)
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

        // code here;
        double sum = 0;
        for (int i = 0; i < n; i++)
        {
            double.TryParse(Console.ReadLine(), out double n1);
            double.TryParse(Console.ReadLine(), out double n2);
            double.TryParse(Console.ReadLine(), out double n3);
            double.TryParse(Console.ReadLine(), out double n4);
            if ( n1 == 2 || n2 == 2 || n3 == 2 || n4 == 2 )
            {
                sum = sum + (n1 + n2 + n3 + n4) / 4;
                answer++;
            }
            else
            {
                sum += (n1 + n2 + n3 + n4)/4;
            }
        }
        avg = sum / n;
        Console.WriteLine(answer);
        Console.WriteLine(avg);

        // end

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here;
        if (r <= 0)
        {
            answer = 0;
        }
        else
        {
            switch(type)
            {
                case 0:
                    answer = r * r;
                    Console.WriteLine(answer);
                    break;
                case 1:
                    answer = Math.PI * r * r;
                    Console.WriteLine(answer);
                    break;
                case 2:
                    answer = r * r * Math.Sqrt(3) / 4;
                    Console.WriteLine(answer);
                    break;
                default:
                    Console.WriteLine("введите число 0,1 или 2");
                    break;
            }
        }

        // end
        answer = Math.Round(answer,2);

        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;
        if (A <= 0 || B <= 0)
        {
            answer = 0;
        }
        else
        {
            switch(type)
            {
                case 0:
                    answer = A * B;
                    Console.WriteLine(answer);
                    break;
                case 1:
                    answer=Math.Abs((Math.PI * A * A) - (Math.PI * B * B));
                    Console.WriteLine(answer);
                    break;
                case 2:
                    answer=(A * Math.Sqrt(B * B - ( A * A / 4))) / 2;
                    Console.WriteLine(answer);
                    break;
                default:
                    Console.WriteLine("Введите число 0,1 или 2");
                    break;
            }
        }
        answer = Math.Round(answer,2);

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
        while (double.TryParse(Console.ReadLine(), out double s))
        {
            answer += s;
            n += 1;
        }
        answer = answer / n;

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
        while (double.TryParse(Console.ReadLine(), out double x) && (double.TryParse(Console.ReadLine(), out double y)))
        {
            if (((x * x) + (y * y) >= r1 * r1) && ((x * x) + (y * y) <= r2 * r2))
            {
                answer += 1;
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
        while(double.TryParse(Console.ReadLine(), out double n1) &&  (double.TryParse(Console.ReadLine(), out double n2)))
        {
            if (n1 > 0)
            {
                if (n2 > 0)
                {
                    answer1 += 1;
                    Console.WriteLine(1);
                }
                else
                {
                    Console.WriteLine(4);
                }
            }
            else
            {
                if (n2 > 0)
                {
                    Console.WriteLine(2);
                }
                else
                {
                    answer3 += 1;
                    Console.WriteLine(3);
                }
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
        while (double.TryParse(Console.ReadLine(), out double n1) && double.TryParse(Console.ReadLine(), out double n2) && double.TryParse(Console.ReadLine(), out double n3) && double.TryParse(Console.ReadLine(), out double n4))
        {
            if (((n1 != 2) && (n1 != 3)) && ((n2 != 2) && (n2 != 3)) && ((n3 != 2) && (n3 != 3)) && ((n4 != 2) && (n4 != 3)))
            {
                answer += 1;
            }
        }
        // end
        Console.WriteLine(answer);
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