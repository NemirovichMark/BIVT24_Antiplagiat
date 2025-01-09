using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

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
        if(Math.Abs(x * x + y * y - r * r) <= 0.001){
            answer = true;
        }


        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        if(y >= 0 && (y + Math.Abs(x) <= 1))
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
        if(a > 0)
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
        if((2 * Math.Sqrt(r / Math.PI)) >= Math.Sqrt(s) * Math.Sqrt(2))
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
        if((2 * Math.Sqrt(r / Math.PI)) <= Math.Sqrt(s))
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
        if(Math.Abs(x) > 1)
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
        if(Math.Abs(x) >= 1)
        {
            answer = 0;
        }
        else
        {
            answer = x*x-1;
        }
        // end

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        // code here
        if(x <= -1)
        {
            answer = 0;
        }

        if(x > 0)
        {
            answer = 1;
        }

        if(x <= 0 && x > -1)
        {
            answer = x + 1;
        }

        // end

        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;

        // code here
        if(x <= -1)
        {
            answer = 1;
        }
        if(-1 < x && x <= 1)
        {
            answer = -x;
        }
        if(x > 1)
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
        double height;
        string gender;
        double boys_height = 0, girls_height = 0;
        for(int i = 0; i < n; i++)
        {
            height = double.Parse(Console.ReadLine());
            gender = Console.ReadLine();

            if (gender == "M")
                boys_height += height;
            
            if (gender == "F")
                girls_height += height;
            
        }
        answer = girls_height/n + boys_height / n;
        // end

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        // code here
        double x, y;
        for(int i = 0; i < n; i++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            if(Math.Pow(a-x, 2) + Math.Pow(b-y, 2) < r * r)
                answer++;
        }

        // end

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        // code here
        double weight;
        for(int i = 0; i < n; i++)
        {
            weight = double.Parse(Console.ReadLine());
            if(weight < 30)
                answer += 0.2;
        }

        // end

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here
        double x, y;
        for(int i = 0; i < n; i++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            if ((Math.Pow(x, 2) + Math.Pow(y, 2)) < Math.Pow(r2, 2) && ((Math.Pow(x, 2) + Math.Pow(y, 2)) > Math.Pow(r1, 2)))
                answer++;
        }

        // end

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

        // code here
        double result;
        for(int i = 0; i < 30; i++)
        {
            result = double.Parse(Console.ReadLine());
            if(result <= norm)
                answer++;
        }

        // end

        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;

        // code here
        double x, y;

        for(int i = 0; i < n; i++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            if (x >= 0 && x <= Math.PI && Math.Sin(x) >= y)
                answer++;
        }

        // end

        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;

        // code here
        double x, y;
        for(int i = 0; i < n; i++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            if ((x * y > 0))
            {
                if(x > 0 && y > 0)
                {
                    Console.WriteLine("I");
                    answer1++;
                }
                else
                {
                    Console.WriteLine("III");
                    answer3++;
                }
            }
            else
            {
                if(x > 0 && y < 0)
                {
                    Console.WriteLine("IV");
                }
                else
                {
                    Console.WriteLine("II");
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
        double x, y, distance = 0;

        for(int i = 0; i < n; i++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            distance = Math.Sqrt(x * x + y * y);
            if(distance < answerLength)
                answerLength = distance;
                answer = i + 1;
        }
        answerLength = Math.Round(answerLength, 2);
        Console.WriteLine(answer);
        Console.WriteLine(answerLength);

        // end

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        double result;
        for(int i = 0; i < n; i++)
        {
            result = double.Parse(Console.ReadLine());
            if(result < answer)
                answer = result;
        }
        Console.WriteLine(answer);

        // end

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;
        double mark1, mark2, mark3, mark4;
        for(int i = 0; i < n; i++)
        {
            mark1 = double.Parse(Console.ReadLine());
            mark2 = double.Parse(Console.ReadLine());
            mark3 = double.Parse(Console.ReadLine());
            mark4 = double.Parse(Console.ReadLine());
            if(mark1 >= 4 && mark2 >= 4 && mark3 >= 4 && mark4 >= 4)
                answer++;
        }


        // end

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;

        // code here;
        double mark1, mark2, mark3, mark4;
        for(int i = 0; i < n; i++)
        {
            mark1 = double.Parse(Console.ReadLine());
            mark2 = double.Parse(Console.ReadLine());
            mark3 = double.Parse(Console.ReadLine());
            mark4 = double.Parse(Console.ReadLine());
            if(mark1 == 2 || mark2 == 2 || mark3 == 2 || mark4 == 2)
                answer++;
            avg += mark1 + mark2 + mark3 + mark4;
        }
        avg /= n;
        // end

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here;
        switch (type)
        {
            case 0: answer = r * r; break;
            case 1: answer = Math.PI * r * r; break;
            case 2: answer = (r * r * Math.Sqrt(3)) / 4; break; 
        }
        answer = Math.Round(answer, 2);
        if(r<0)
            answer = 0;
        // end

        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;
        int n = 3;
        for(int i = 0; i<n; i++)
        {
            switch (type)
            {
                case 0: answer = A * B; break;
                case 1: 
                if(A > B)
                    answer = Math.PI * (A * A - B * B); 
                if(A < B)
                    answer = Math.PI * (B * B - A * A); 
                break;
                case 2: answer = A / 4 * Math.Sqrt(4 * B * B - A * A); break; 
            }
        }
        answer = Math.Round(answer, 2);
        if(A <= 0 || B <= 0)
            answer = 0;

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
        double x, y;
        bool flag;

        do
        {
            flag = double.TryParse(Console.ReadLine(), out x);
            if (!flag) break;
            flag = double.TryParse(Console.ReadLine(), out y);
            if (flag)
            {
                if (Math.Pow(a-x, 2) + Math.Pow(b-y, 2) < r * r)
                            answer++;    
            }
            
        } while (true);

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
        bool flag;
        double result; 

        do
        {
            flag = double.TryParse(Console.ReadLine(), out result);
            if(flag)
            {
                if (result <= norm)
                    answer++;
            }
        } while(flag);
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

        // code here
        int i = 1;
        double x, y, distance = 0;
        bool flag;

        do
        {
            flag = double.TryParse(Console.ReadLine(), out x);
            if (!flag) break;
            flag = double.TryParse(Console.ReadLine(), out y);
            if (flag)
            {
                distance = Math.Sqrt(x * x + y * y);
                if (distance < answerLength)
                    answerLength = distance;
                    answer = i;
                i++;
            }
        } while (true);

        answerLength = Math.Round(answerLength, 2);
        Console.WriteLine(answer);
        Console.WriteLine(answerLength);

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

        // code here;
        bool flag;
        double mark1, mark2, mark3, mark4;
        do
        {
            flag = double.TryParse(Console.ReadLine(), out mark1);
            if (!flag) break;
            flag = double.TryParse(Console.ReadLine(), out mark2);
            if (!flag) break;
            flag = double.TryParse(Console.ReadLine(), out mark3);
            if (!flag) break;
            flag = double.TryParse(Console.ReadLine(), out mark4);
            if (flag)
            {
                n++;
                if (mark1 == 2 || mark2 == 2 || mark3 == 2 || mark4 == 2)
                    answer++;
                avg += mark1 + mark2 + mark3 + mark4;
                
            }
            
        } while (true);
        avg /= n * 4;
        Console.WriteLine(answer);
        Console.WriteLine(avg);

        // end

        return (answer, avg);
    }
    #endregion
}