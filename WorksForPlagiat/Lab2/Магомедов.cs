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
        // Console.WriteLine(program.Task_2_1(6));
        // Console.WriteLine(program.Task_2_2(5, 3, 2, 1));
        // program.Task_2_2(5, 1.5, 1.5, 1);
        // program.Task_2_2(5, 1, 3, 1);
        //program.Task_2_3(10);
        // Console.WriteLine(program.Task_2_4(5, 1, 2));
        // Console.WriteLine(program.Task_2_5(10, 30));
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
        double radius = 2;

        // code here
        answer = (Math.Abs(Math.Pow(x, 2) + Math.Pow(y, 2) - Math.Pow(radius, 2)) < Math.Pow(10, -3)) ? true : false;
        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;
        // code here
        answer = (y >= 0 && (y + Math.Abs(x) <= 1)) ? true : false;
        // end

        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;

        // code here
        answer = (a > 0) ? (a > b) ? a: b : (a < b) ? a : b; 
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        // code here
        double MinAB = (a > b) ? b: a;
        answer = (MinAB > c) ? MinAB : c;
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        answer = (2 * Math.Sqrt(r / Math.PI) >= Math.Sqrt(s) * Math.Sqrt(2)) ? true : false;

        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        answer = (2 * Math.Sqrt(r / Math.PI) < Math.Sqrt(s)) ? true : false;
        // end

        return answer;
    }
    public double Task_1_7(double x)
    {
        double answer = 0;

        // code here
        answer = (Math.Abs(x) >= 1) ? 1: Math.Abs(x);
        // end

        return answer;
    }
    public double Task_1_8(double x)
    {
        double answer = 0;

        // code here
        answer = (Math.Abs(x) >= 1) ? 0: Math.Pow(x, 2) - 1;
        // end

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1) {
            answer = 0;
        } else if (x > 0) {
            answer = 1;
        } else {
            answer = 1 + x;
        }
        // end

        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1) {
            answer = 1;
        } else if (x > 1) {
            answer = -1;
        } else {
            answer = -x;
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
        for (int i = 1; i <= n; i++) {
            answer += Convert.ToDouble(Console.ReadLine());
        }
        // end

        return answer / n;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        // code here
        for (int i = 1; i <= n; i++) {
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            answer += (Math.Abs(Math.Pow(x, 2) + Math.Pow(y, 2) - Math.Pow(r, 2)) < Math.Pow(10, -3)) ? 1 : 0;
        }
        // end

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        // code here
        for (int i = 1; i <= n; i++) {
            answer += (Convert.ToDouble(Console.ReadLine()) < 30) ? 200: 0;
        }
        // end

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here
        for (int i = 1; i <= n; i++) {
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            bool firstCondition = (Math.Abs(Math.Pow(x, 2) + Math.Pow(y, 2) - Math.Pow(r2, 2)) <= Math.Pow(10, -3));
            bool secondCondition = (Math.Abs(Math.Pow(x, 2) + Math.Pow(y, 2) - Math.Pow(r1, 2)) >= Math.Pow(10, -3));
            answer += firstCondition && secondCondition ? 1 : 0;
        }
        // end

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;
        double sportsmens = 0;

        // code here
        for (int i = 0; i < n; i++){
            sportsmens = Convert.ToDouble(Console.ReadLine());
            if (sportsmens <= norm){
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
        double x = 0;
        double y = 0;
        for (int i = 0; i < n; i++){
            x = Convert.ToDouble(Console.ReadLine());
            y = Convert.ToDouble(Console.ReadLine());
            if (y >= 0 && x >= 0 && x <= Math.PI && Math.Sin(x) >= y){
                answer++;
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
        for (int i = 1; i <= n; i++) {
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            if (x > 0 && y > 0){
                Console.WriteLine("Точка попала в первый квадрант");
                answer1++;
            }
            else if (x < 0 && y < 0){
                Console.WriteLine("Точка попала в третий квадрант");
                answer3++;
            } else if (x > 0 && y < 0){
                Console.WriteLine("Точка попала в четвертый квадрант");
            } else if (x < 0 && y > 0){
                Console.WriteLine("Точка попала во второй квадрант");
            }
        }
        // end

        return (answer1, answer3);
    }


    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double result = double.MaxValue;

        // code here
        for (int i = 1; i <= n; i++){
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            double lenght = Math.Sqrt(x * x + y * y);
            if (lenght < result) {
                answer = i;
                result = lenght;
            }
        }
        Console.WriteLine();
        Console.WriteLine(answer);
        Console.WriteLine(Math.Round(result, 2));
        // end

        return (answer, result);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        for (int i = 1; i <= n; i++){
            double result = Convert.ToDouble(Console.ReadLine());
            if (result < answer) {
                answer = result;
            }
        }
        Console.WriteLine();
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;
        for (int i = 0; i < n; i++) {
            bool twoOrThree = false;

            for (int j = 0; j < 4; j++) {
                int grade = Convert.ToInt32(Console.ReadLine());

                if (grade == 2 || grade == 3) {
                    twoOrThree = true;
                }
            }
            if (!twoOrThree) {
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
        for (int i = 1; i <= n; i++){
            bool isFailed = false;

            for (int j = 1;j <= 4; j++){
                double result = Convert.ToDouble((Console.ReadLine()));
                avg += result;

                if (result == 2){
                    isFailed = true;
                }; 
            }
            if (isFailed == true){
                answer++;
            };
        }
        avg /= n * 4;
        // end

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here;
        if (r < 0) {
            return 0;
        };
        switch (type) {
            case 0:
                answer = r * r;
                break;
            case 1:
                answer = Math.PI * r * r;
                break;
            case 2:
                answer = (r * r * Math.Sqrt(3)) / 4;
                break;
            default:
                break;
        }
        // end;

        return Math.Round(answer, 2);
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;
        if (A <= 0 || B <= 0) {
            return 0;
        }
        switch (type){
            case 0:
                answer = A * B; 
                break;
            case 1:
                answer = Math.Abs(Math.PI * A * A - Math.PI * B * B);
                break; 
            case 2:
                answer = (A * Math.Sqrt(4*B*B-A*A))/4; 
                break;
            default:
                break;
        }
        // end

        return Math.Round(answer, 2);
    }
    #endregion

    #region Level 3
    public double Task_3_1()
    {
        double answer = 0, stopWord = 6969, inputNumber = 0;
        int n = 0;

        // code here
        while(true){
            inputNumber = Convert.ToDouble(Console.ReadLine());
            if (inputNumber == stopWord){
                break;
            } 
            answer += inputNumber;
            n++;
        }
        // end

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
        while (true){
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());

            if (x == 69) {
                break;
            }

            bool firstCondition = (Math.Abs(Math.Pow(x, 2) + Math.Pow(y, 2) - Math.Pow(r2, 2)) <= Math.Pow(10, -3));
            bool secondCondition = (Math.Abs(Math.Pow(x, 2) + Math.Pow(y, 2) - Math.Pow(r1, 2)) >= Math.Pow(10, -3));
            answer += firstCondition && secondCondition ? 1 : 0;
            n++;
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
        int answer1 = 0, answer3 = 0;
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
        while (true) {
            bool twoOrThree = false;
            int grade = 0;
            for (int j = 0; j < 4; j++) {
                grade = Convert.ToInt32(Console.ReadLine());
                if (grade == 1) {
                    break;
                }
                if (grade == 2 || grade == 3) {
                    twoOrThree = true;
                }
            }
            if (grade == 1) {
                break;
            }
            if (!twoOrThree) {
                answer++;
            }
            n++;
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