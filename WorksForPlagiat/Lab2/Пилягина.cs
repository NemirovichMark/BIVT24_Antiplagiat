using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        //program.Task_1_1(3, 0);
        //program.Task_1_2(0.9, 1.23);
        //program.Task_1_3(0.9, 1.23);
        //program.Task_1_4(0.9, 1.23, -0.1);
        //program.Task_1_5(0.86, 0.74);
        //program.Task_1_6(6, 9);
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
        //program.Task_2_5(6, 25.1);
        //program.Task_2_6(3);
        //program.Task_2_7(4);
        //program.Task_2_8(3);
        //program.Task_2_9(6);
        //program.Task_2_10(6);
        //program.Task_2_11(6);
        //program.Task_2_12(10, 0);
        //program.Task_2_13(10, 5, 0);
        //program.Task_3_1();
        //program.Task_3_2(3, 2, 1);
        //program.Task_3_2(1.5, 1.5, 1);
        //program.Task_3_2(3, 2, 1);
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
        if (Math.Abs(x * x + y * y - r * r) <= Math.Pow(10, -3))
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
        if (y >= 0 && y + Math.Abs(x) <= 1){
            answer = true;
        }
        // end

        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;

        // code here
        double c = 0;
        c = a;
        if (b > c && a > 0)
        {
            c = b;
        }
        answer = c;
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        // code here
        double min = 0;
        min = a;
        if (b < min)
        {
            min = b;
        }
        double max = 0;
        max = min;
        if (c > max)
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
        double diag = 0, diam = 0;
        diag = Math.Sqrt(2 * Math.Sqrt(s));
        diam = 2 * Math.Sqrt(r / Math.PI);
        if (diag <= diam)
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
        double diam = 0, a=0;
        diam = 2 * Math.Sqrt(r / Math.PI);
        a = Math.Sqrt(s);
        if (diam <= a)
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
        if ( x > -1 && x <= 0)
        {
            answer = 1 + x;
        }
        if (x > 0)
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
        if (x > -1 && x <= 1)
        {
            answer = -x;
        }
        if (x > 1)
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
        double r = 0;
        for (int i = 0 ; i < 10; i++)
        {
            r = Convert.ToDouble(Console.ReadLine());
            answer += r;
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
        int k = 0, i = 0;
        double x, y;
        for (i = 1; i <= n; i++)
        {
            x = Convert.ToDouble(Console.ReadLine());
            y = Convert.ToDouble(Console.ReadLine());
            if ((x - a) * (x - a) + (y - b) * (y - b) <= r * r)
            {
                k++;
            }
        }
        answer = k;
        Console.WriteLine("� ���� ������ {0} ����� �� {1}", k, n);
        // end

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        // code here
        double a;
        for (int i = 1; i<=n; i++)
        {
            a = Convert.ToDouble(Console.ReadLine());
            if (a < 30)
            {
                answer += 0.2;
            }
        }
        Console.WriteLine("����������� {0} ������", Math.Round(answer, 2));
        // end

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here
        double x, y;
        for (int i = 1; i <= n; i++)
        {
            x = Convert.ToDouble(Console.ReadLine());
            y = Convert.ToDouble(Console.ReadLine());
            if (x*x + y*y <= r2 * r2 && x * x + y * y >= r1 * r1)
            {
                answer++;
            }
        }
        Console.WriteLine("���������� ����� ������ {0}",answer);
        // end

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

        // code here
        double r;
        for (int i = 1; i<=n; i++)
        {
            r = Convert.ToDouble(Console.ReadLine());
            if (r <= norm)
            {
                answer++;
            }
        }
        Console.WriteLine("�������� ��������� {0} �����������",answer);
        // end

        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;

        // code here
        double x, y;
        for (int i = 1; i<=n; i++)
        {
            x = Convert.ToDouble(Console.ReadLine());
            y = Convert.ToDouble(Console.ReadLine());
            if (x>=0 && x<=Math.PI && y <= Math.Sin(x))
            {
                answer++;
            }
        }
        Console.WriteLine("{0} �����",answer);
        // end

        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;

        // code here
        double x, y;
        for (int i = 1; i<=n; i++)
        {
            Console.WriteLine("������� �:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("������� �: ");
            y = Convert.ToDouble(Console.ReadLine());
            if (x>0 && y > 0)
            {
                Console.WriteLine("1 ��������");
                answer1++;
            }
            if (x < 0 && y > 0)
            {
                Console.WriteLine("2 ��������");
            }
            if (x < 0 && y < 0)
            {
                Console.WriteLine("3 ��������");
                answer3++;
            }
            if (x > 0 && y < 0)
            {
                Console.WriteLine("4 ��������");
            }
        }
        Console.WriteLine("���������� ����� � 1 ���������: {0}, � 3 ���������: {1}", answer1, answer3);
        // end

        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;

        // code here
        double x, y;
        for (int i = 1; i<=n; i++)
        {
            x= Convert.ToDouble(Console.ReadLine());
            y = Convert.ToDouble(Console.ReadLine());
            if (x * x + y * y < answerLength*answerLength)
            {
                answerLength = Math.Sqrt(x*x + y*y);
                answer = i;
            }
        }
        Console.WriteLine("����� �����: {0}, ����������: {1}",answer, Math.Round(answerLength,2));
        // end

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        double r;
        for (int i = 1; i<=n; i++)
        {
            r= Convert.ToDouble(Console.ReadLine());
            if (r < answer)
            {
                answer = r;
            }
        }
        Console.WriteLine("������ ��������� {0}", answer);
        // end

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;
        int n1, n2, n3, n4;
        for (int i = 1; i<=n; i++)
        {
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());
            n3 = Convert.ToInt32(Console.ReadLine());
            n4 = Convert.ToInt32(Console.ReadLine());
            if (n1==2 ||  n2==2 || n3==2 || n4==2 || n1 == 3 || n2 == 3 || n3 == 3 || n4 == 3)
            {
                answer = answer;
            }
            else
            {
                answer++;
            }
        }
        Console.WriteLine("���������� ��������: {0}", answer);
        // end

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;

        // code here;
        int n1, n2, n3, n4, sum = 0;
        for (int i = 1; i <= n; i++)
        {
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());
            n3 = Convert.ToInt32(Console.ReadLine());
            n4 = Convert.ToInt32(Console.ReadLine());
            sum = sum + n1 + n2 + n3 + n4;
            if (n1<3 || n2<3 || n3<3 || n4<3)
            {
                answer++;
            }
        }
        avg = (double)sum / 4 / (double)n;
        Console.WriteLine("���������� ������������ ���������: {0}, ������� ���� ������: {1}", answer, Math.Round(avg,9));
        // end

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;
        // code here;
        if (r <= 0) return 0;
        //Console.WriteLine("0 = ������� ��������, 1 = ������� �����, 2 = ������� ��������������� ������������ ");
        switch (type)
        {
            case 0:
                answer = Math.Round(r * r, 2);
                Console.WriteLine("������� �������� {0:f}", answer);
                break;
            case 1:
                answer = Math.Round(r * r * Math.PI, 2);
                Console.WriteLine("������� ����� {0:f}", answer);
                break;
            case 2:
                answer = Math.Round(r * r * Math.Sqrt(3) / 4, 2);
                Console.WriteLine("������� ��������������� ������������ {0:f}", answer);
                break;
            default:
                answer = 0;
                Console.WriteLine("�������� �����");
                break;
        }
        //Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;
        if (A<=0 || B <= 0) return 0;
        switch (type)
        {
            case 0:
                answer = Math.Round(A*B,2);
                Console.WriteLine("������� �������������� {0:f}", answer);
                break;
            case 1:
                answer = Math.Round(Math.Abs(Math.PI*(A*A-B*B)),2);
                Console.WriteLine("������� ������ {0:f}", answer);
                break;
            case 2:
                answer = Math.Round( (A * Math.Sqrt(B * B - (A * A) / 4)) / 2, 2);
                Console.WriteLine("������� ������������ {0:f}", answer);
                break;
            default:
                //answer = 0;
                Console.WriteLine("�������� �����. �������� 1, 2 ��� 3: ");
                break;

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

        // end

        // answer should be equal to the task_2_1 answer
        return answer;
    }
    public int Task_3_2(double r, double a, double b)
    {
        int answer = 0;

        // code here
        string input;
        int k = 0, i = 0;
        double x, y;
        while (true)
        {
            Console.WriteLine("��� ���������� ����� ������� 'stop', ����� ���������� ���� ������� enter");
            input = Console.ReadLine();
            if (input == "stop")
                break;

            Console.WriteLine("������� x: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("������� y: ");
            y = Convert.ToDouble(Console.ReadLine());

            if ((x - a) * (x - a) + (y - b) * (y - b) <= r * r)
            {
                k++;
            }
        }
        answer = k;
        Console.WriteLine("� ���� ������ {0} �����", k);
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
        double r;
        string input;
        while (true)
        {
            Console.WriteLine("��� ���������� ����� ������� 'stop', ����� ���������� ���� ������� enter");
            input = Console.ReadLine();
            if (input == "stop")
                break;

            Console.WriteLine("������� ��������� ���������: ");
            r = Convert.ToDouble(Console.ReadLine());

            if (r <= norm)
            {
                answer++;
            }
        }
        Console.WriteLine("�������� ��������� {0} �����������", answer);
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
        double x, y;
        string input;
        for (int i = 1; ; i++)
        {
            Console.WriteLine("��� ���������� ����� ������� 'stop', ����� ���������� ���� ������� enter");
            input = Console.ReadLine();
            if (input == "stop")
                break;

            Console.WriteLine("������� x");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("������� y");
            y = Convert.ToDouble(Console.ReadLine());

            if (x * x + y * y < answerLength * answerLength)
            {
                answerLength = Math.Sqrt(x * x + y * y);
                answer = i;
            }
        }
        Console.WriteLine("����� �����: {0}, ����������: {1}", answer, Math.Round(answerLength, 2));
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
        string input;
        int n1, n2, n3, n4, sum = 0;
        while (true)
        {
            Console.WriteLine("��� ���������� ����� ������� 'stop', ����� ���������� ���� ������� enter");
            input = Console.ReadLine();
            if (input == "stop")
                break;

            Console.WriteLine("�� ������� ������� 4 ������: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());
            n3 = Convert.ToInt32(Console.ReadLine());
            n4 = Convert.ToInt32(Console.ReadLine());
            sum = sum + n1 + n2 + n3 + n4;
            if (n1 < 3 || n2 < 3 || n3 < 3 || n4 < 3)
            {
                answer++;
            }
        }
        avg = (double)sum / 4 / (double)n;
        Console.WriteLine("���������� ������������ ���������: {0}, ������� ���� ������: {1}", answer, Math.Round(avg, 9));
        // end

        return (answer, avg);
    }
    #endregion
}