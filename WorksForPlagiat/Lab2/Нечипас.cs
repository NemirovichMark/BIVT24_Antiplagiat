public class Program
{
    public static void Main()
    {
        Program program = new Program();
        //program.Task_1_1(3, 0);
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
        //program.Task_2_8(3);
        //program.Task_2_9(6);
        //program.Task_2_10(6);
        //program.Task_2_11(6);
        //program.Task_2_12(1.5, 0);
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
        program.Task_3_9();
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
        if (Math.Abs(x*x+y*y-r*r)<=0.001)
            answer = true;  
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        if((y>=0)&&  ((y+Math.Abs(x))<=1))
            answer = true;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;

        // code here
        double c = 0;
        if (a > 0)
        {
            if (a > b)
                c = a;
            else if (b > a)
                c = b;
        }
        else if (a <= 0) 
        {
            if (a < b)
                c = a;
            else if (b < a)
                c = b;
        }
        answer = c; 
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        // code here
        double z = 0, minn=0;
        if (a < b)
            minn = a;
        else if (b < a)
            minn = b;
        if (minn > c)
            z = minn;
        else if (c > minn)
            z = c;
        answer = z;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        double diametr=2*Math.Sqrt(r/Math.PI);
        double diagonal = Math.Sqrt(2*s);
        if (diagonal<=diametr)
            answer = true;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        double diametr = 2 * Math.Sqrt(r / Math.PI);
        double side= Math.Sqrt( s);
        if (diametr <= side)
            answer = true;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_7(double x)
    {
        double answer = 0;

        // code here
        double y = 0;
        if (Math.Abs(x) > 1)
            y = 1;
        else if (Math.Abs(x) <= 1)
            y = Math.Abs(x);
        answer = y;
        Console.WriteLine(answer);
            // end

            return answer;
    }
    public double Task_1_8(double x)
    {
        double answer = 0;

        // code here
        double y = 0;
        if (Math.Abs(x) >= 1)
            y = 0;
        else if (Math.Abs(x) < 1)
            y = x*x-1;
        answer = y;
        Console.WriteLine(answer);

        // end

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        // code here
        double y = 0;
        if (x<= -1)
            y = 0;
        else if ((x>-1)&&(x<=0))
            y =1+x;
        else if (x>0)
            y =1;
        answer = y;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;

        // code here
        double y = 0;
        if (x <= -1)
            y = 1;
        else if ((x > -1) && (x <= 1))
            y =-x;
        else if (x > 1)
            y = -1;
        answer = y;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(int n)
    {
        double answer = 0;

        // code here
        double s=0,sr;
        int i = 1,r;
        while (i <= n)
        {
            int.TryParse(Console.ReadLine(), out r);
            s += r;
            i++;
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
        double x, y;
        int i = 1;
        while (i <= n)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if ((x - a) * (x - a) + (y - b) * (y - b) <= r * r)
                answer++;
            i++;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        // code here
        double litr = 0,weight=0;
        int i = 1;
        while (i <= n)
        {
            double.TryParse(Console.ReadLine(),out weight);
            if (weight<30)
                litr += 0.2;
            i++;
        }
        answer = litr;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here
        double x, y;
        int count = 0,i=1;
        while (i <= n)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if ((x * x + y * y >= r1 * r1) && (x * x + y * y <= r2 * r2))
                count++;
            i++;
        }
        answer = count;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

        // code here
        double result;
        int i = 1;
        while (i <= n)
        {
            double.TryParse(Console.ReadLine(), out result);
            if (result <= norm)
                answer++;
            i++;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;

        // code here
        int i = 1;
        double x, y;
        while (i <= n)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if ((x >= 0 && x <= Math.PI) && (y <= Math.Sin(x)))
                answer++;
            i++;
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
        int i = 1;
        double x, y;
        while (i <= n)
        {
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            if ((x >= 0) && (y >= 0))
            {
                Console.WriteLine("1 квадрант");
                answer1++;
            }
            else if ((x <= 0 )&& (y >= 0))
                Console.WriteLine("2 квадрант");
            else if ((x <= 0) && (y <= 0))
            {
                Console.WriteLine("3 квадрант");
                answer3++;
            }
            else if ((x >= 0) && (y <= 0))
                Console.WriteLine("4 квадрант");
            i++;
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
        double x, y;
        int i = 0;
        while (i < n)
        {
            i++;
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            double r = Math.Sqrt(y*y + x * x);
            if (r <= answerLength)
            {
                answerLength = r;
                answer = i;
            }
            
        }
        
        Console.WriteLine(answer);
        Console.WriteLine(Math.Round(answerLength,2));


        // end

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        double result;
        for (int i = 1; i <= n; i++) 
        {
            double.TryParse(Console.ReadLine(), out result);
            if (result<answer)
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
        int r1, r2, r3, r4;
        for (int i = 1; i <= n; i++)
        {
            int.TryParse(Console.ReadLine(), out r1);
            int.TryParse(Console.ReadLine(), out r2);
            int.TryParse(Console.ReadLine(), out r3);
            int.TryParse(Console.ReadLine(), out r4);
            if (r1 > 3 && r2 > 3 && r3 > 3 && r4 > 3)
                answer++;
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
        int r1,r2,r3,r4;
        int summ = 0;
        for (int i = 1; i <= n; i++)
        {
            int.TryParse(Console.ReadLine(), out r1);
            int.TryParse(Console.ReadLine(), out r2);
            int.TryParse(Console.ReadLine(), out r3);
            int.TryParse(Console.ReadLine(), out r4);
            summ += r1 + r2 + r3 + r4;
            if (r1 == 2 || r2 == 2 || r3 == 2 || r4 == 2)
                answer++;

        }
        avg = summ / (n*4.0);
        Console.WriteLine(answer);
        Console.WriteLine(avg);
        // end

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here
        if (r <= 0) return 0;
        switch (type)
        {
            case 0:
                answer = r * r;
                answer = Math.Round(answer, 2);
                break;

            case 1:
                answer = Math.PI * r * r;
                answer = Math.Round(answer, 2);
                break;

            case 2:
                answer = (r * r * Math.Sqrt(3)) / 4;
                answer = Math.Round(answer, 2);
                break;

            default:
                Console.WriteLine("Ќеверный выбор, выберите 0, 1 или 2:");
                break;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;
        if (A<=0 || B <=0) return 0;
        switch (type)
        {
            case 0:
                answer = A*B;
                answer = Math.Round(answer, 2);
                break;

            case 1:
                answer = Math.Abs((Math.PI * B * B) - (Math.PI * A * A));
                answer = Math.Round(answer, 2);
                if (answer <= 0) return 0;
                break;

            case 2:
                double p=(A+B+B)/2;
                answer = Math.Sqrt(p * (p - A) * (p - B) * (p - B));
                if (answer <= 0) return 0;
                answer = Math.Round(answer, 2);
                break;

            default:
                Console.WriteLine("Ќеверный выбор, выберите 0, 1 или 2:");
                break;
        }
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

        // end

        return answer;
    }
    public double Task_3_3()
    {
        double answer = 0;
        int n = 0;

        // code here
        string input;
        double weight;
        while (true)
        { 
            input = Console.ReadLine();
            if (input == "stop")
                break;
            double.TryParse(input, out weight);
            if (weight < 30)
                answer+= 200;
            n++;
        }
        Console.WriteLine(answer/1000);
        Console.WriteLine(n);
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

        // end

        return answer;
    }
    public int Task_3_6()
    {
        int answer = 0, n = 0;

        // code here
        string input;
        double x, y;
        while (true)
        {
            input= Console.ReadLine();
            if (input == "stop")
                break;
            double.TryParse(input, out x);
            input = Console.ReadLine();
            if (input == "stop")
                break;
            double.TryParse(input, out y);
            n++;
            if ((x >= 0 && x <= Math.PI) && (y <= Math.Sin(x)))
                answer++;
            
        }
        Console.WriteLine(answer);
        Console.WriteLine(n);
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

        // end

        return (answer, answerLength);
    }
    public double Task_3_9()
    {
        double answer = double.MaxValue;
        int n = 0;

        // code here
        string input;
        double x, y,result;
        while (true)
        {
            input = Console.ReadLine();
            if (input == "stop")
                break;
            double.TryParse(input, out result);
            n++;
            if (result < answer)
                answer = result;
        } 
        Console.WriteLine(answer);
        Console.WriteLine(n);
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

        // end

        return (answer, avg);
    }
    #endregion
}