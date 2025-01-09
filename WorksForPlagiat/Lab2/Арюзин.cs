using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.IO.Pipes;
using System.Net.WebSockets;
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
        //program.Task_2_2(5, 2);
        //program.Task_2_3(10);
        //program.Task_2_4(5, 1, 3);
        //program.Task_2_5(10, 30);
        //program.Task_2_6(3);
        //program.Task_2_7(5);
        //program.Task_2_8(5);
        //program.Task_2_9(10);
        //program.Task_2_10(10);
        //program.Task_2_11(10);
        //program.Task_2_12(10, 0);
        //program.Task_2_13(10, 5, 0);
        //program.Task_3_1();
        //program.Task_3_2(5, 3);
        //program.Task_3_3(10);
        //program.Task_3_4(5, 1, 3);
        //program.Task_3_5(10, 30);
        //program.Task_3_6(5);
        //program.Task_3_7(5);
        //program.Task_3_8(10);
        //program.Task_3_9(10);
        //program.Task_3_10(10);
        //program.Task_3_11(10);
        //program.Task_3_12(10, 0);
        //program.Task_3_13(10, 5, 0);
    }
    #region Level 1
    public bool Task_1_1(double x, double y)
    {
        bool answer = false;

        // code here
        double rasst = 0;
        rasst = Math.Sqrt((x*x)+(y*y));
        if(rasst == 2)
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
        if (y >= 0 && (y+Math.Abs(x))<= 1)
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
            if(a > b)
            {
                answer = a;
            } else
            {
                answer = b;
            }
        } else if(a <= 0)
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
        double prom = 0;
        if(a > b)
        {
            prom = b;
        } else
        {
            prom = a;
        }
        if (prom > c)
        {
            answer = prom;
        } else
        {
            answer = c;
        }
        
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        double rcirc = 0, rsqr = 0;
        rcirc = Math.Sqrt((r / Math.PI));
        rsqr  = Math.Sqrt(s);
        if(2*rcirc >= Math.Sqrt(2*rsqr))
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
        double rcirc = 0, rsqr = 0;
        rcirc = Math.Sqrt((r / Math.PI));
        rsqr = Math.Sqrt(s);
        if (2 * rcirc <= rsqr )
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
        if(Math.Abs(x)> 1)
        {
            answer = 1;
        } else if (Math.Abs(x)<= 1)
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
        } else if(Math.Abs(x)< 1)
        {
            answer = x*x - 1;
        }
        // end

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        // code here
        if(x<= -1)
        {
            answer = 0;
        } else if(x > -1 && x<= 0)
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
        } else if((x> -1) && (x<= 1))
        {
            answer = -1 * x;
        } else
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
        int data = 0;
        double sum= 0;
        string input;
        for(int i = 0; i < n; ++i)
        {
            input = Console.ReadLine();
            int.TryParse(input, out data );
            sum += data;
        }
        answer = sum / n;
        answer=  Math.Round(answer,1);
        Console.WriteLine(answer);

        // end

        // for test input in console: 168, 147, 174, 154, 180, 149, 166, 160, 175, 161

        return answer;
    }
    public int Task_2_2(int n, double r)
    {
        int answer = 0;

        // code here
        double x, y;
        for(int i = 0; i < n; ++i)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if ( Math.Sqrt(x*x + y * y) < r)
            {
                answer += 1;
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
        double weg;
        string input;
        for(int i = 0; i < n; i++)
        {
            double.TryParse((string)Console.ReadLine(), out weg);
            if(weg < 30)
            {
                answer += 0.2;
            }
            weg = 0;
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
        string input;
        double x, y;
        for (int i = 0; i < n; ++i)
        {
            double.TryParse((string)Console.ReadLine(), out x);
            double.TryParse((string)Console.ReadLine(), out y);
            if (Math.Sqrt(x * x + y * y) >= r1 && Math.Sqrt(x * x + y * y) <= r2)
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
        double data;
        for(int i = 0; i < n; ++i)
        {
            double.TryParse((string)Console.ReadLine(), out data);

            if(data <= norm)
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
        double x, y; 
        for(int i = 0; i < n; ++i)
        {
            double.TryParse((string)Console.ReadLine(), out x);
            double.TryParse((string)Console.ReadLine(), out y);
            if((y >= 0) && (y <= Math.Sin(x)) && (x >= 0) && (x <= Math.PI))
            {
                answer ++;
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
        double x, y;
        for(int i = 0; i<n; ++i)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if(x > 0 && y > 0)
            {
                Console.WriteLine("1");
                answer1++;
            } else if (x < 0 && y > 0)
            {
                Console.WriteLine("2");
            } else if (x < 0 && y < 0)
            {
                Console.WriteLine("3");
                answer3++;
            } else if (x > 0 && y < 0)
            {
                Console.WriteLine("4");
            }
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
        for (int i  = 0; i < n; ++i)
        {
            double.TryParse((Console.ReadLine()), out x);
            double.TryParse((Console.ReadLine()), out y);
            if(Math.Sqrt(x*x+y*y) < answerLength)
            {
                answerLength = Math.Sqrt(x * x + y * y);
                answer = i + 1;
            }

        }
        answerLength = Math.Round(answerLength,2);
        Console.WriteLine($"{answerLength} {answer}");
        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -0.5

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        double res;
        for( int i = 0; i < n; ++i)
        {
            double.TryParse(Console.ReadLine(), out res);
            if( res < answer)
            {
                answer = res;
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
        int m1,m2,m3,m4;
        for(int i = 0; i < n; ++i)
        {
            int.TryParse(Console.ReadLine(), out m1);
            int.TryParse(Console.ReadLine(), out m2);
            int.TryParse(Console.ReadLine(), out m3);
            int.TryParse(Console.ReadLine(), out m4);
            if(((m1 != 2)&&(m1 != 3))&& ((m2 != 2) && (m2 != 3))&& ((m3 != 2) && (m3 != 3)) && ((m4 != 2) && (m4 != 3)))
            {
                answer++;
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

        // code here;
        int m1, m2, m3, m4;
        for (int i = 0; i < n; ++i)
        {
            int.TryParse(Console.ReadLine(), out m1);
            int.TryParse(Console.ReadLine(), out m2);
            int.TryParse(Console.ReadLine(), out m3);
            int.TryParse(Console.ReadLine(), out m4);
            if ( m1 == 2 || m2 == 2 || m3 == 2 || m4 == 2)
            {
                answer++;
            }
            avg += (m1 + m2 + m3 + m4);
        }
        avg = Math.Round(avg/(4*n),2);
        Console.WriteLine($"{answer} {avg}");

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
                    answer = Math.Sqrt(3) * (r * r) / 4;
                    break;
                default:
                    return 0;
            }
        }
        answer = Math.Round(answer,2);

        // end
        Console.WriteLine(answer);
        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;
        if(A <= 0 || B<=0) return 0;
        switch (type)
        {
            case 0:
                answer = A * B;
                break;
            case 1:
                answer = Math.Abs(Math.PI*A*A - Math.PI*B*B);
                break;
            case 2:
                double h = Math.Sqrt(B*B- A*A/4);
                answer = A * h / 2;
                break;
            default:
                return 0;
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

        // code here
        int chisl, amnt =0;
        double sm = 0;
        string input;
        for (int i = 0; i < int.MaxValue; ++i)
        {
            input = Console.ReadLine();
            if (input == "STOP") {
                break;
            }else
            {
                int.TryParse(input, out chisl);
                sm += chisl;
                amnt += 1;
            }
        }
        if(amnt != 0)
        {
            answer = sm/ amnt;
            answer = Math.Round(answer,2);
        }
        
        Console.WriteLine(answer);
        // end

        // for test input in console: 168, 147, 174, 154, 180, 149, 166, 160, 175, 161
        // answer should be equal to the task_2_1 answer

        return answer;
    }
    public int Task_3_2(int n, double r)
    {
        int answer = 0;

        // code here
        string input1, input2;
        double x, y,a,b;
        double.TryParse(Console.ReadLine(), out a);
        double.TryParse(Console.ReadLine(), out b);
        for (int i = 0; i < int.MaxValue; ++i)
        {
            input1 = Console.ReadLine();
            
            if (input1 != "STOP")
            {
                input2 = Console.ReadLine();
                double.TryParse(input1, out x);
                double.TryParse(input2, out y);
                if (Math.Sqrt((x-a) * (x-a) + (y-b) * (y-b)) < r)
                {
                    answer++;
                }

            } else
            {
                break;
            }
        }
        Console.WriteLine(answer);

        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -2.5 -0.5
        // answer should be equal to the task_2_2 answer

        return answer;
    }
    public double Task_3_3(int n)
    {
        double answer = 0;

        // code here

        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5
        // answer should be equal to the task_2_3 answer

        return answer;
    }
    public int Task_3_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here

        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -0.5 -0.5
        // answer should be equal to the task_2_4 answer

        return answer;
    }
    public int Task_3_5(int n, double norm)
    {
        int answer = 0;

        // code here
        string input;
        double data;
        for(int i = 0; i< int.MaxValue; ++i)
        {
            input = Console.ReadLine();
            if (input != "STOP")
            {
                double.TryParse(input, out data);
                if(data < norm)
                {
                    answer++;
                }
            } else
            {
                break;
            }
        }
        Console.WriteLine(answer);
        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5
        // answer should be equal to the task_2_5 answer

        return answer;
    }
    public int Task_3_6(int n)
    {
        int answer = 0;

        // code here

        // end

        // for test input in console: -1.2 0.7, 2 2, 0.5 0.9, -1 1.5, 0.5 1.5
        // answer should be equal to the task_2_6 answer

        return answer;
    }
    public (int, int) Task_3_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;

        // code here

        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5
        // answer should be equal to the task_2_7 answer

        return (answer1, answer3);
    }
    public (int, double) Task_3_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;

        // code here
        double x, y;
        string input1, input2;
        for( int  i = 0; i < int.MaxValue; ++i)
        {
            input1 = Console.ReadLine();
            if(input1 == "STOP")
            {
                break;
            }
            input2  = Console.ReadLine();
            double.TryParse(input1, out x);
            double.TryParse(input2, out y);
            if (Math.Sqrt(x * x + y * y) < answerLength)
            {
                answerLength = Math.Sqrt(x * x + y * y);
                answer = i + 1;
            }
        }
        answerLength = Math.Round(answerLength, 2);
        Console.WriteLine($"{answer} {answerLength}");

        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5
        // answer should be equal to the task_2_8 answer

        return (answer, answerLength);
    }
    public double Task_3_9(int n)
    {
        double answer = double.MaxValue;

        // code here

        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5
        // answer should be equal to the task_2_9 answer

        return answer;
    }
    public int Task_3_10(int n)
    {
        int answer = 0;

        // code here;

        // end

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4
        // answer should be equal to the task_2_10 answer

        return answer;
    }
    public (int, double) Task_3_11(int n)
    {
        int answer = 0;
        double avg = 0.0;

        // code here;
        int m1, m2, m3, m4, amnt = 0;
        string input1;
        for(int i = 0; i < int.MaxValue; ++i)
        {
            input1 = Console.ReadLine();
            if (input1 == "STOP")
            {
                break;
            }
            int.TryParse(input1, out m1);
            input1 = Console.ReadLine();
            int.TryParse(input1, out m2);
            input1 = Console.ReadLine();
            int.TryParse(input1, out m3);
            input1 = Console.ReadLine();
            int.TryParse(input1, out m4);
            if (m1 == 2 || m2 == 2 || m3 == 2 || m4 == 2)
            {
                answer++;
            }
            avg += (m1 + m2 + m3 + m4);
            amnt++;
        }
        if(amnt != 0)
        {
            avg = Math.Round(avg / (4 * amnt), 2);
        }
        Console.WriteLine($"{answer} {avg}");
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