using System;
namespace CW1
{
    public class Program
    {
        public static void Main()
        {
            var program = new Program();

            int input1 = 10;
            double input2 = 5;
            double input3_1 = 14;
            double input3_2 = 47;
            double input4_1 = 0.1;
            double input4_2 = 0.9;
            double input4_3 = 0.5;
            double input5_1 = 200;
            double input5_2 = 100;

            double answer1 = program.Task_1(input1);
            double answer2 = program.Task_2(input2);
            double answer3 = program.Task_3(input3_1, input3_2);
            double answer4 = program.Task_4(input4_1, input4_2, input4_3);
            double answer5 = program.Task_5(input5_1, input5_2);
            double[] answer = { answer1, answer2, answer3, answer4, answer5 };
            double[] test = new double[5] { 7.306399156399156, 1.0936832, 17, 2, 2527 };

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Task {i + 1} run with a {answer[i] == test[i]} result\n" +
                    $"your answer is: {answer[i]}\n" +
                    $"expected answer is: {test[i]}\n");
            }
        }

        public double Task_1(int n)
        {
            // code here
            double S = 0;
            int a = 2, b = 4;
            for (int i = 1; i <= n; i++)
            {
                S += (double)a/b;
                a++;
                b++;
            }
            return S;
        }
        public double Task_2(double x)
        {
            // code here
            if (x >= -1 && x <= 1) return 0;
            double S = 0;
            int n = 1;
            double num = n * (n + 2), denum = x;
            while (Math.Abs((double)num / denum) >= 0.0001)
            {
                S += (double)num/denum;
                n++;
                num = n * (n + 2);
                denum *= x;
            }
            return Math.Round(S, 8);
        }
        public double Task_3(double N, double S)
        {
            int i = 0;
            int Alex = 0, Maria = 0, Pavel = 0; 
            while (i <= N || (
                (100.0 * Alex / i < S) &&
                (100.0 * Maria / i < S) &&
                (100.0 * Pavel / i < S)))
            {
                i++;
                if (i % 5 == 0) Alex++;
                else if (i % 3 == 0) Maria++;
                else if (i % 2 == 0) Pavel++;
                else Alex++;
            }
            Console.WriteLine($"{i}\t{100.0 * Alex / i}\t{100.0 * Maria / i}\t{100.0 * Pavel / i}");
            return i;
        }
        public double Task_4(double a, double b, double h)
        {
            double min = double.MaxValue;
            if (a <= 0 || b >= 1) return 0;
            for (double x = a; x <= b; x += h)
            {
                int n = 0;
                double i = 1;
                double y = x * x;
                double elem = 3.0;
                while (Math.Abs(elem*y) >= 0.0001)
                {
                    n++;
                    i++;
                    elem = (2.0 * i + 1) / (2.0 * i - 1);
                    y *= -x * x;
                }
                if (n < min) { min = n; }
            }
            return min;
        }
        public double Task_5(double first, double second)
        {
            // code here
            double third = (first + second)/2;
            double score = 0;
            for (int game = 1; game <= 10; game++)
            {
                if (first <= second && first <= third)
                {
                    score += first;
                    first *= 1.5;
                }
                else if (second <=first && second <= third)
                {
                    score += second;
                    second += (first + third)/4;
                }
                else
                {
                    score += third;
                    third += (first + second + third) / 10;
                }
                if (first % 2 == 1) first--;
                second = Math.Floor(second);
                third = (int)third;
            }
            return score;
        }
    }
}