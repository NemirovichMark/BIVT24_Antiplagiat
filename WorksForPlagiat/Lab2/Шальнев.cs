using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
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
        //program.Task_2_3(8);
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
        program.Task_3_11();
        //program.Task_3_12(10, 0);
        //program.Task_3_13(10, 5, 0);
    }
    #region Level 1
    public bool Task_1_1(double x, double y)
    {
        bool answer = false;

        // code here
        double r = 2;
        double a = Math.Abs(x*x+y*y-r*r);
        if (a <= 0.001) answer = true;
        else answer = false;

        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        if (y >= 0 && y + Math.Abs(x)<=1) answer = true;
        // end

        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;

        // code here
        if (a>0)
        {
            if (a > b) answer = a;
            else answer = b;
        }
        else 
        {
            if (a < b) answer = a;
            else answer = b;
        }

        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        // code here
        if (a < b) {answer = a;}
            else answer = b;
        if (answer < c) {answer = c;}
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        if (Math.Sqrt(s)*Math.Sqrt(2)<=2*Math.Sqrt(r/Math.PI)) answer = true;
        else answer = false;
        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        if (Math.Sqrt(s)>=2*Math.Sqrt(r/Math.PI)) answer = true;
        else answer = false;
        // end

        return answer;
    }
    public double Task_1_7(double x)
    {
        double answer = 0;

        // code here
        if (Math.Abs(x) > 1) answer = 1;
        else answer = Math.Abs(x);
        // end

        return answer;
    }
    public double Task_1_8(double x)
    {
        double answer = 0;

        // code here
        if (Math.Abs(x) >= 1) answer = 0;
        else answer = x*x-1;
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
        else if (x > -1 && x <= 1) answer = x * -1;
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
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            bool check = int.TryParse(Console.ReadLine(), out int a);
            if (check) sum+=a;
            else Console.WriteLine("error");
        }
        answer = sum/Convert.ToDouble(n);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;
        NumberFormatInfo dot = new CultureInfo( "ru-RU", false ).NumberFormat;
        dot.NumberDecimalSeparator = ".";
        // code here
        for (int i = 1; i <= n; i++)
        {
            bool check = double.TryParse(Console.ReadLine(), dot, out double c);
            bool check2 = double.TryParse(Console.ReadLine(), dot, out double d);
            if (check && check2) 
            {
                if(Math.Pow(c - a,2) + Math.Pow(d - b,2) <= Math.Pow(r,2))  answer+= 1;
            }
        }
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;
        NumberFormatInfo dot = new CultureInfo( "ru-RU", false ).NumberFormat;
        dot.NumberDecimalSeparator = ".";
        // code here
        for (int i = 1; i <= n; i++)
        {
            bool check = double.TryParse(Console.ReadLine(), dot, out double a);
            if (check && a < 30)  answer += 0.2;
        }
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;
        // code here
        NumberFormatInfo dot = new CultureInfo( "ru-RU", false ).NumberFormat;
        dot.NumberDecimalSeparator = ".";
        for (int i = 1; i <= n; i++)
        {
            bool check = double.TryParse(Console.ReadLine(), dot, out double a);
            bool check2 = double.TryParse(Console.ReadLine(), dot, out double b);
            if (check && check2) 
            {
                if(((a*a + b*b) <= (r2*r2)) && !((a*a + b*b) < (r1*r1))) 
                {
                    answer += 1;
                }
            }
        }
        Console.WriteLine(answer);
        // end
        
        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;
        NumberFormatInfo dot = new CultureInfo( "ru-RU", false ).NumberFormat;
        dot.NumberDecimalSeparator = ".";
        // code here
        for (int i = 1; i <= n; i++)
        {
            if (double.TryParse(Console.ReadLine(),  dot, out double a)) if (a <= norm) answer++;
        }
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;
        NumberFormatInfo dot = new CultureInfo( "ru-RU", false ).NumberFormat;
        dot.NumberDecimalSeparator = ".";
        // code here
        for (int i = 1; i <= n; i++)
        {
            bool check = double.TryParse(Console.ReadLine(), dot, out double a);
            bool check2 = double.TryParse(Console.ReadLine(), dot, out double b);
            if (check && check2) 
            {
                if ((a >= 0) && (b >= 0) && (a <= Math.PI) && (b <= Math.Sin(a))) answer++;
            }
        }
        // end
        System.Console.WriteLine(answer);
        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;
        // code here
        NumberFormatInfo dot = new CultureInfo( "ru-RU", false ).NumberFormat;
        dot.NumberDecimalSeparator = ".";
        for (int i = 1; i <= n; i++)
        {
            bool check = double.TryParse(Console.ReadLine(), dot, out double a);
            bool check2 = double.TryParse(Console.ReadLine(), dot, out double b);
            if (check && check2) 
            {
                if (a == 0 || b == 0) System.Console.WriteLine("none");
                else if (a > 0 && b > 0) {System.Console.WriteLine(1); answer1++;}
                else if (a < 0 && b > 0) System.Console.WriteLine(2);
                else if (a < 0 && b < 0) {System.Console.WriteLine(3); answer3++;}
                else System.Console.WriteLine(4);
            }
        }
        // end
        // Switch-case version (cringe) (uncomment to test)
        /*
        for (int i = 1; i <= n; i++)
        {
            bool check = double.TryParse(Console.ReadLine(), dot, out double a);
            bool check2 = double.TryParse(Console.ReadLine(), dot, out double b);
            if (check && check2) 
            {   
                if (a == 0 || b == 0) System.Console.WriteLine("none");
                else
                    switch (a > 0)
                    {
                        case true:
                            switch (b > 0)
                            {
                                case true:
                                    System.Console.WriteLine(1);
                                    answer1++;
                                    break;
                                case false:
                                    System.Console.WriteLine(4);
                                    break;
                            }
                        break;
                        case false:
                            switch (b > 0)
                            {
                                case true:
                                System.Console.WriteLine(2);
                                break;
                                case false:
                                    System.Console.WriteLine(3);
                                    answer3++;
                                    break;
                            }
                        break;
                    }
            }
        }*/
        System.Console.WriteLine(answer1);
        System.Console.WriteLine(answer3);
        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;
        NumberFormatInfo dot = new CultureInfo( "ru-RU", false ).NumberFormat;
        dot.NumberDecimalSeparator = ".";
        // code here
        for (int i = 1; i <= n; i++)
        {
            bool check = double.TryParse(Console.ReadLine(), dot, out double a);
            bool check2 = double.TryParse(Console.ReadLine(), dot, out double b);
            if (check && check2)
            {
                if (Math.Sqrt(a*a + b*b) < answerLength) {answerLength = Math.Sqrt(a*a + b*b); answer = i;}
            }
        }
        answerLength = Math.Round(answerLength, 2);
        // end
        System.Console.WriteLine(answer.ToString() + " " + answerLength.ToString());
        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;
        NumberFormatInfo dot = new CultureInfo( "ru-RU", false ).NumberFormat;
        dot.NumberDecimalSeparator = ".";
        // code here
        for (int i = 1; i <= n; i++)
        {
            bool check = double.TryParse(Console.ReadLine(), dot, out double a);
            if (check) if (a < answer) answer = a;
        }
        // end
        System.Console.WriteLine(answer);
        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;
        // code here;
        int counter = 0;
        int scounter = 0;
        for (int i = 1; i <= n*4; i++)
        {
            bool check = int.TryParse(Console.ReadLine(), out int a);
            if (counter == 4) {counter = 0; scounter = 0;}
            if (check)
            {
                counter++;
                if (a == 2 || a == 3) scounter++;
                if (counter == 4 && scounter == 0) answer++;
            }

        }
        System.Console.WriteLine(answer);
        // end

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;

        // code here;
        double ball = 0;
        int counter = 0;
        int scounter = 0;
        for (int i = 1; i <= n*4; i++)
        {
            bool check = int.TryParse(Console.ReadLine(), out int a);
            if (counter == 4) {counter = 0; scounter = 0;}
            if (check)
            {
                ball += a;
                counter++;
                if (a <= 2) scounter++;
                if (counter == 4 && scounter != 0) answer++;
            }

        }
        avg = ball / n / 4.0;
        System.Console.WriteLine(answer);
        System.Console.WriteLine(avg);
        // end

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here;
        if (r<= 0){answer = 0; return answer;}
        switch (type)
            {
                case 0:
                    answer = r*r;
                    break;
                case 1:
                    answer = Math.PI * (r * r);
                    break;
                case 2:
                    answer = Math.Sqrt(3)/4*(r*r);
                    break;
                default:
                    answer = 0;
                    break;
            }
        answer = Math.Round(answer, 2);
        System.Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;
        if (A<= 0 || B <= 0){answer = 0;}
        else switch (type)
                {
                    case 0:
                        answer = A * B;
                        break;
                    case 1:
                        if (A >= B) answer = Math.PI * (A * A) - Math.PI * (B*B);
                        else answer = Math.PI * (B * B) - Math.PI * (A * A);
                        break;
                    case 2:
                        answer = A/4*Math.Sqrt(4*(B*B)-A*A);
                        break;
                    default:
                        answer = 0;
                        break;
                }
            answer = Math.Round(answer, 2);
        System.Console.WriteLine(answer);
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
        int sum = 0;
        for (int i = 1; ; i++)
        {
            bool check = int.TryParse(Console.ReadLine(), out int a);
            if (check) {sum+=a; n++;}
            else break;
        }
        answer = sum/Convert.ToDouble(n);
        Console.WriteLine(answer);
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
        NumberFormatInfo dot = new CultureInfo( "ru-RU", false ).NumberFormat;
        dot.NumberDecimalSeparator = ".";
        for (int i = 1; ; i++)
        {
            bool check = double.TryParse(Console.ReadLine(), dot, out double a);
            if (!check) break;
            bool check2 = double.TryParse(Console.ReadLine(), dot, out double b);
            if (check2) 
            {
                if(((a*a + b*b) <= (r2*r2)) && !((a*a + b*b) < (r1*r1))) 
                {
                    answer += 1;
                }
            }
            else break;
        }
        Console.WriteLine(answer);
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
        NumberFormatInfo dot = new CultureInfo( "ru-RU", false ).NumberFormat;
        dot.NumberDecimalSeparator = ".";
        for (int i = 1; ; i++)
        {
            bool check = double.TryParse(Console.ReadLine(), dot, out double a);
            if (!check) break;
            bool check2 = double.TryParse(Console.ReadLine(), dot, out double b);
            if (check2) 
            {
                if (a == 0 && b == 0) System.Console.WriteLine("none");
                else if (a >= 0 && b >= 0) {System.Console.WriteLine(1); answer1++;}
                else if (a <= 0 && b >= 0) System.Console.WriteLine(2);
                else if (a <= 0 && b <= 0) {System.Console.WriteLine(3); answer3++;}
                else System.Console.WriteLine(4);
            }
            else break;
        }
        System.Console.WriteLine(answer1);
        System.Console.WriteLine(answer3);
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
        int counter = 0;
        int scounter = 0;
        for (int i = 1; ; i++)
        {
            bool check = int.TryParse(Console.ReadLine(), out int a);
            if (counter == 4) {counter = 0; scounter = 0;}
            if (check)
            {
                counter++;
                if (a == 2 || a == 3) scounter++;
                if (counter == 4 && scounter == 0) answer++;
            }
            else break;

        }
        System.Console.WriteLine(answer);
        // end

        return answer;
    }
    public (int, double) Task_3_11()
    {
        int answer = 0, n = 0;
        double avg = 0.0;

        // code here;
        double ball = 0;
        int counter = 0;
        int scounter = 0;
        for (int i = 1; ; i++)
        {
            bool check = int.TryParse(Console.ReadLine(), out int a);
            if (counter == 4) {counter = 0; scounter = 0; n++;}
            if (check)
            {
                ball += a;
                counter++;
                if (a <= 2) scounter++;
                if (counter == 4 && scounter != 0) answer++;
            }
            else break;

        }
        avg = ball / n / 4.0;
        System.Console.WriteLine(answer);
        System.Console.WriteLine(avg);
        // end

        return (answer, avg);
    }
    #endregion
}