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
        //program.Task_1_4(0.1 ,0.3,0.05);
        string s = "4567";
        Console.WriteLine(s.IndexOf("g"));
       // program.Task_1_4_var3(0.1, 0.3, 0.05);
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


        // program.Task_2_13(1.5, 3, 1);
        //program.Task_2_13(0.2, 2.8, 1);
        //program.Task_2_13(3, 2.5, 1);



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
        double r = 2;

        if (Math.Abs(x * x + y * y - r * r) <= 1e-4)
        {
            return true;
        }
        return false;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        if (y > 0 && y + Math.Abs(x) <= 1)
        {
            return true;
        }

        return false;
    }
    public int Task_1_4_var3(double a, double b, double h)
    {
        for (double x = a; x < b; x+=h)
        {
            int j = 1;
            double sumT = 0;
            double temp = 1 * (2 * j - 1)*x*x / (2 *j + 1);


            double fT = 1;
            double sT = x;



            while (Math.Abs(temp) > 0.0001)
            {
                sumT += temp;

                fT = fT * -1;
                sT = sT * x * x;

                temp = fT * (2 * j - 1) * sT/ (2 * j + 1);


                j += 1;
            }
            Console.WriteLine(j -1);
            



        }
        return -1;

    }

    public double Task_1_4(double a, double b, double h)
    {
        for(double x = a; x <= b; x += h)
        {
            

            int j = 1;
            double s = 0;
            double fT = -1;
            double sT = x * x;

            double temp = fT * (2 * j) * sT / (2 * j + 1);
           //
            while (Math.Abs(temp) >= 0.0001)
            {


               // Console.WriteLine("Temp");
               // Console.WriteLine(temp);


                s += temp;

                fT = fT * -1;
                sT = sT * x * x;
                j += 1;
                temp = fT * (2 * j) * sT / (2 * j + 1);

                
            }
           //Console.WriteLine("j");
            Console.WriteLine(j-1);
           // Console.WriteLine("-------------");
        }



        

        return 0.1;
    }
    public bool Task_1_5(double Sr, double Ss)
    {
        bool answer = false;

        double Dr = Math.Sqrt(Sr / Math.PI) * 2;
        double Ds = Math.Sqrt(Ss) * Math.Sqrt(2);

        if (Dr >= Ds)
        {
            return true;
        }


        return false;
    }
    public bool Task_1_6(double r, double s)
    {
        int x = Convert.ToInt32(Console.ReadLine());
        int N = Convert.ToInt32(Console.ReadLine());
        if (N <= 0 || x <= 0)
        {
            Console.WriteLine(0);
        }
        else
        {
            if (N > 18)
            {
                Console.WriteLine(8 * x + 6 * x + 4 * x);
            }
            if (N > 0 && N <= 4)
            {
                Console.WriteLine(2 * N * x);
            }
            if (N > 4 && N <= 10)
            {
                Console.WriteLine(8 * x + (N - 4) * x);
            }
            if (N > 10 && N <= 18)
            {
                Console.WriteLine(8 * x + 6 * x + ((N - 10) / 2 * x));
            }
        }
        return true;
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
            return Math.Abs(x);
        }

        return answer;
    }
    public double Task_1_8(double x)
    {
        double answer = 0;

        if (Math.Abs(x) >= 1)
        {
            return 0;
        }
        else
        {
            return x * x - 1;
        }


        return 0;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        if (x <= -1)
        {
            return 0;
        }
        else if (-1 < x && x <= 0)
        {
            return 1 + x;
        }
        else
        {
            return 1;
        }


    }
    public double Task_1_10(double x)
    {
        double answer = 0;

        if (x <= -1)
        {
            return 1;
        }
        else if (-1 < x && x <= 1)
        {
            return -x;
        }
        else
        {
            return -1;
        }


    }
    #endregion

    #region Level 2
    public double Task_2_1(int n)
    {
        double answer = 0;
        if (n == 0)
        {
            Console.WriteLine(answer);
            return 0;
        }
        for (int i = 0; i < n; i++)
        {
            answer = answer + int.Parse(Console.ReadLine());
        }

        answer = answer / n;
        


        Console.WriteLine(answer);

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        for (int i = 0; i < n; i++)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            if (Math.Pow(x - a, 2) + Math.Pow(y - b, 2) <= Math.Pow(r, 2))
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

        for (int i = 0; i < n; i++)
        {
            double weight = double.Parse(Console.ReadLine());

            if (weight < 30)
            {
                answer += 0.2;
            }
        }


        Console.WriteLine(answer);

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        for (int i = 0; i < n; i++)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            if (((r1 * r1) <= (x * x + y * y)) && ((r2 * r2) >= (x * x + y * y)))
            {
                answer++;
            }
        }

        Console.WriteLine(answer);

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

        for (int i = 0; i < n; i++)
        {
            double res = double.Parse(Console.ReadLine());

            if (res < norm)
            {
                answer++;
            }
        }

        Console.WriteLine(answer);

        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;

        for (int i = 0; i < n; i++)
        {

            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            if ((0 <= x && x <= Math.PI) && (0 <= y && y <= Math.Sin(x)))
            {
                answer++;
            }
        }

        Console.WriteLine(answer);

        return 0;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;

        for (int i = 0; i < n; i++)
        {
            double x = double.Parse(Console.ReadLine()), y = double.Parse(Console.ReadLine());

            if (x > 0)
            {
                if (y > 0)
                {
                    answer1++;
                }
            }
            else
            {
                if (y < 0)
                {
                    answer3++;
                }
            }
        }

        Console.WriteLine(answer1);
        Console.WriteLine(answer3);

        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = 9999999;

        if (n == 0)
        {
            answerLength = 0;
            Console.WriteLine(answer);
            Console.WriteLine(answerLength);

            return (answer, answerLength);
        }

        for (int i = 1; i <= n; i++)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            double length = Math.Sqrt(x * x + y * y);

            if (answerLength > length)
            {
                answer = i;
                answerLength = length;
            }
        }



        Console.WriteLine(answer);
        Console.WriteLine(answerLength);

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = 99999999;
        if (n == 0)
        {
            answer = 0; 
            Console.WriteLine(answer);

            return 0;
        }

        for (int i = 0; i < n; i++)
        {
            double res = double.Parse(Console.ReadLine());

            if (res < answer)
            {
                answer = res;
            }
        }

       

        Console.WriteLine(answer);

        return 0;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        for (int i = 0; i < n; i++)
        {
            bool fl = true;
            for (int j = 0; j < 4; j++)
            {
                int point = int.Parse(Console.ReadLine());
                if (point == 2 || point == 3)
                {
                    fl = false;
                }
            }

            if (fl)
            {
                answer++;
            }
        }



        return 0;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;
        if (n == 0)
        {
            avg = 0;
            Console.WriteLine(0);
            Console.WriteLine(0);
            return (answer, avg);
        }
        for (int i = 0; i < n; i++)
        {
            bool fl = true;

            for (int j = 0; j < 4; j++)
            {
                int mark = int.Parse(Console.ReadLine());
                if (mark == 2)
                {
                    fl = false;
                }

                avg += mark;
            }

            if (!fl)
            {
                answer++;
            }
        }

        avg = avg / n * 4;

        


        Console.WriteLine(answer);
        Console.WriteLine(avg);

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

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



        if (r <= 0)
        {
            answer = 0;
        }
        answer = Math.Round(answer, 2);
        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer;

        switch (type)
        {
            case 0:
                answer = A * B;
                break;
            case 1:
                answer = Math.Abs(A*A*Math.PI - B*B*Math.PI);
                break;
            case 2:
                double p = (A + B + B) / 2;
                answer = Math.Sqrt(p * (p - B) * (p - B) * (p - A));
                break;
            default:
                answer = 0;
                break;
        }



        if (A <= 0 || B <= 0)
        {
            answer = 0;
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
        int nS = 0;

        string tryN = Console.ReadLine();

        while (tryN != "-1")
        {
            


           
                double weight = double.Parse(tryN);

                if (weight < 30)
                {
                    answer += 0.2;
                }
                nS+=1;


            
            tryN = Console.ReadLine();
        }
        Console.WriteLine(answer);
        return 0;

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

        // end

        return answer;
    }
    public int Task_3_6()
    {
        int answer = 0;

        // code here
        string tryN1 = Console.ReadLine();
        if (tryN1 == "-1") {
            Console.WriteLine(0);
            return 0;
        }
        string tryN2 = Console.ReadLine();
        while (tryN1 != "-1" && tryN2 != "-1")
        {
            

                double x = double.Parse(tryN1);
                double y = double.Parse(tryN2);

                if ((0 <= x && x <= Math.PI) && (0 <= y && y <= Math.Sin(x)))
                {
                    answer++;
                }
            

           
             tryN1 = Console.ReadLine();
            if (tryN1 == "-1")
            {
                break;
            }
            tryN2 = Console.ReadLine();
        }
        Console.WriteLine(answer);
        return 0;
        // end


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

        // end

        return (answer, answerLength);
    }
    public double Task_3_9()
    {
        string tryN = Console.ReadLine();
        double answer = 99999999;
        while (tryN != "-1")
        {
          
            

           
                double res = double.Parse(tryN);

                if (res < answer)
                {
                    answer = res;
                }
            

            

            
            tryN = Console.ReadLine();

        }
        Console.WriteLine(answer);
        return 0;
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

        // end

        return (answer, avg);
    }
    #endregion
}