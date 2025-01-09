using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;

public class Program
{
    enum typeOfSomth : int {

    }
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
        //program.Task_1_10(-0.5);
        //program.Task_2_1(10);
        //program.Task_2_2(5, 3);
        //program.Task_2_3(10);
        //program.Task_2_4(5, 1, 3);
        //program.Task_2_5(10, 25.2);
        //program.Task_2_6(5);
        //program.Task_2_7(3);
        //program.Task_2_8(5);
        //program.Task_2_9(10);
        //program.Task_2_10(10);
        //program.Task_2_11(6);
        //program.Task_2_12(10, 0);
        //program.Task_2_13(10, 5, 0);
        //program.Task_3_1(10);
        //program.Task_3_2(5, 2);
        //program.Task_3_3(10);
        //program.Task_3_4(5, 1, 3);
        //program.Task_3_5(10, 30);
        //program.Task_3_6(5);
        //program.Task_3_7(5);
        //program.Task_3_8(10);
        //program.Task_3_9(10);
        //program.Task_3_10(10);
        program.Task_3_11(10);
        //program.Task_3_12(10, 0);
        //program.Task_3_13(10, 5, 0);
    }
    #region Level 1
    public bool Task_1_1(double x, double y)
    {
        bool answer = false;
        double r = 2;
        //code here
        if( Math.Abs( (x*x + y*y - r*r)) <= (1/(10*10*10) ) ) {
        //if (x * x + y * y  <= r*r ) {
            answer = true;
        }
        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        /*double ab_1 = 2;
        double ab_2 = 0;
        double bc_1 = -1;
        double bc_2 = 1;
        double ca_1 = 1;
        double ca_2 = 0;
        double ap_1 = x + 1;
        double ap_2 = y;
        double bp_1 = x - 1;
        double bp_2 = y;
        double cp_1 = x;
        double cp_2 = y - 1;
        double p = 2 * ap_2 - 0 * ap_1;
        double q = -bp_2 - bp_1;
        double r = cp_2 - cp_1 * 0;
        if ((p >= 0 && q >= 0 && r >= 0) ) {
            answer = true;
        }
        if (p <= 0 && q <= 0 && r <= 0) {
            answer = true;
        }*/
        if (y >= 0 && y + Math.Abs(x) <= 1) {
            answer = true;
        }
        // end

        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;

        // code here
        if (a > 0) {
            if (a > b) {
                answer = a;
            }
            else {
                answer = b;
            }
        }
        else {
            if (a < b) {
                answer = a;
            }
            else {
                answer = b;
            }
            
        }
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;
        double y = 0;
        // code here
        if (a > b) {
            y = b;
        }
        else {
            y = a;
        }
        if (y > c) {
            answer = y;
        }
        else {
            answer = c;
        }
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s) {
        bool answer = false;

        // code here
        double a = Math.Sqrt(s);
        double d = Math.Sqrt(2) * a;
        double y = Math.Sqrt(r / Math.PI);
        if (d <= 2 * y) { 
        answer = true; 
        }
        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        double a = Math.Sqrt(s);
        double y = Math.Sqrt(r / Math.PI);
        if (a >= 2 * y) {
            answer = true;
        }
        // end

        return answer;
    }
    public double Task_1_7(double x)
    {
        double answer = 0;

        // code here
        if ((Math.Abs(x)) > 1) {
            answer = 1;
        }
        else {
            answer = Math.Abs(x);
        }
        // end

        return answer;
    }
    public double Task_1_8(double x)
    {
        double answer = 0;

        // code here
       if (Math.Abs(x) >= 1) {
            answer = 0;
        }
       else {
            answer = x * x - 1;
        }
        // end

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1) {
            answer = 0;
        }
        if (-1 < x && x <= 0) {
            answer = 1 + x;
        }
        if (x > 0) { 
            answer = 1;
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
        }
        if (-1 < x && x <= 1) {
            answer = -1*x;
        }
        if (x > 1) {       
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
        int i = 1;
        double sum = 0;
        // code here
        while (i <= n) {
            string s = Console.ReadLine();
            if (s == "") {
                break;
            }            

            else {
                sum = sum + Convert.ToDouble(s);
            }
            i++;
        }

        answer = sum / n;
        Console.WriteLine(answer);
        // end

        // for test input in console: 168, 147, 174, 154, 180, 149, 166, 160, 175, 161

        return answer;
    }
    public int Task_2_2(int n, double r) 
    { //5, 3

        int answer = 0;
        int i = 0;
        // code here
        double a = 2;
        double b = 1;
        double x = 0;
        double y = 0;    
        while (i <= n) {
            i++;
            string x_1 = Console.ReadLine();
            string y_1 = Console.ReadLine();
            if (x_1 == "" || y_1 == "") {
                break;
            }
            else {
                x = Convert.ToDouble(x_1);
                y = Convert.ToDouble(y_1);
            }
        if ( (x - a)*(x - a) + (y - b)*(y - b) <= r * r) {
                answer++;
            }
        }
        Console.Write(answer);
        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -2.5 -0.5

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;
        double moloko = 0;
        // code here
        double weight = 0;
        int i = 0;
        while (i <= n) {
            i++;
            string s = Console.ReadLine();
            if ( s == "") {
                break;
            }
            else {
                weight = Convert.ToDouble(s);
            }
            if (weight < 30) {
                moloko = moloko + 200;
            }
        }
        answer = moloko / 1000;
        // end
        Console.Write(answer);
        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;
        int i = 0;
        // code here
        double x = 0;
        double y = 0;
        while (i <= n) {
            i++;
            string x_1 = Console.ReadLine();
            string y_1 = Console.ReadLine();
            if (x_1 == "" || y_1 == "") {
                break;
            }
            else {
                x = Convert.ToDouble(x_1);
                y = Convert.ToDouble(y_1);
            }
            if ((x*x + y*y <= r2 * r2) && (x*x + y*y >= r1*r1) ) {
                answer++;
            }
        }
        Console.Write(answer);
        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -0.5 -0.5

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

        // code here
        int i = 0;
        while (i < n) {
            i++;
            string rez_1 = Console.ReadLine();
            if (rez_1 == "") {
                break;
            }
            double rez = Convert.ToDouble(rez_1);
            if (rez <= norm) {
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
        int i = 0;
        while (i < n) {
            i++;
            string x_1 = Console.ReadLine();
            string y_1 = Console.ReadLine();
            if (x_1 == "" || y_1 == "") {
                break;
            }
            double x = Convert.ToDouble(x_1);
            double y = Convert.ToDouble(y_1);
            if (Math.Sin(x) >= y && x >= 0 && x < Math.PI) {
                answer++;
            }
            
        }
        Console.WriteLine(answer);
        // end

        // for test input in console: -1.2 0.7, 2 2, 0.5 0.9, -1 1.5, 0.5 1.5

        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;

        // code here
        int i = 0;
        while (i < n) {
            i++;
            string x_1 = Console.ReadLine();
            string y_1 = Console.ReadLine();
            if (x_1 == "" || y_1 == "") {
                break;
            }
            double x = Convert.ToDouble(x_1);
            double y = Convert.ToDouble(y_1);
            if (x > 0 && y > 0) {
                answer1++;
            }
            if (x < 0 && y < 0) {
                answer3++; 
            }
        }
        Console.WriteLine(answer1);
        Console.WriteLine(answer3);
            // end

            // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5

            return (answer1, answer3);
    }
    public (double, double) Task_2_8(int n)
    {
        double answer = 0;
        double answerLength = double.MaxValue;

        // code here
        int i = 0;        
        double min = Double.MaxValue;
        while (i < n) {
            i++;
                        
            if (Double.TryParse(Console.ReadLine(),out double x) && Double.TryParse(Console.ReadLine(), out double y)) {
                if (x * x + y * y < min) {
                    min = x * x + y * y;
                }               
            }
            else {               
                break;
            }                                                                                                                           
        }
        
        answer = Math.Round(Math.Sqrt(min),2);
        Console.WriteLine(answer);
        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        int i = 0;
        double min = Double.MaxValue;
        while (i < n) {
            i++;
            string rez_1 = Console.ReadLine();
            if (rez_1 == "") {
                break;
            }
            double rez = Convert.ToDouble(rez_1);
            if (rez < min) {
                min = rez;
            }
        }
        answer = min;
        Console.WriteLine("    " +  answer);
        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;
        int i = 0;
        while (i < n) {
            i++;
            string a_1 = Console.ReadLine();
            string b_1 = Console.ReadLine();
            string c_1 = Console.ReadLine();
            string d_1 = Console.ReadLine();
            if (a_1 == "" || b_1 == "" || c_1 == "" || d_1 == "") {
                break;
            }
            double a = Convert.ToDouble(a_1);
            double b = Convert.ToDouble(b_1);
            double c = Convert.ToDouble(c_1);
            double d = Convert.ToDouble(d_1);
            /*if (a == 2 || b == 2 || c == 2 || d == 2) {
                continue;
            }
            if (a == 3 || b == 3 || c == 3 || d == 3) {
                continue;
            }*/
            if (a > 3 && b > 3 && c > 3 && d > 3) {
                answer++;
            }
        }
        Console.WriteLine("    " + answer);
        // end

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;

        // code here;
        double sum = 0;
        int i = 0;
        while (i < n) {
            i++;
            string a_1 = Console.ReadLine();
            string b_1 = Console.ReadLine();
            string c_1 = Console.ReadLine();
            string d_1 = Console.ReadLine();
            if (a_1 == "" || b_1 == "" || c_1 == "" || d_1 == "") {
                break;
            }
            double a = Convert.ToDouble(a_1);
            double b = Convert.ToDouble(b_1);
            double c = Convert.ToDouble(c_1);
            double d = Convert.ToDouble(d_1);
            if (a == 2 || b == 2 || c == 2 || d == 2) {
                answer++;
            }
            sum = sum + a + b + c + d;
        }
        avg = sum / (n * 4);
        Console.WriteLine("   " + answer + "   " + avg);

        // end

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4

        return (answer, avg);
    }
    public double Task_2_12(double r, int type) {
        double answer = 0;

        // code here;

        if (r < 0)
            return 0;

        if (type == 0) {
            answer = Math.Round(r * r, 2);  
        }
        else if (type == 1) {
            answer = Math.Round(r * r * Math.PI, 2);
        }
        else if (type == 2) {
            answer = Math.Round((r * r * Math.Sqrt(3)) / 4, 2);
        }
        else {
            return answer;
        }

        

               
        // end

        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;
        if (A <= 0 || B <= 0)
            return 0;

        if (type == 0) {
            answer = Math.Round(A * B, 2);
        }
        if (type == 1) {
            if (A > B) {
                answer = Math.Round( A * A * Math.PI - B * B * Math.PI, 2);
            }
            else {
                answer = Math.Round( B * B * Math.PI - A * A * Math.PI, 2);
            }
        }
        if (type == 2) {
            answer = Math.Round((A*Math.Sqrt(B*B - (A*A)/4)) / 2, 2);
        }
        else {
            return answer;
        }
        // end

        return answer;
    }
    #endregion

    #region Level 3
    public double Task_3_1(int n)
    {
        double answer = 0;

        // code here

        // end

        // for test input in console: 168, 147, 174, 154, 180, 149, 166, 160, 175, 161
        // answer should be equal to the task_2_1 answer

        return answer;
    }

    public int Task_3_2(int n, double r)
    {        
        int answer = 0;
        Console.WriteLine("Введите радиус");
        r = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите a");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите b");
        double b = Convert.ToDouble(Console.ReadLine());

        // code here       
        double x = 0;
        double y = 0;
        while (true) {
                       
            Console.WriteLine("Введите x, для остановки введите #");
            string x_1 = Console.ReadLine();

            /*for(int i = 0; i < 2; i++) {
                Console.WriteLine("Введите {0}, для остановки введите #",i%2==0?"x":"y");
                string input = Console.ReadLine();
                if (input == "#")
                    break;
                if (i % 2 == 0) x = Convert.ToDouble(input);
                else y = Convert.ToDouble(input);
            }*/

            if (x_1 == "#") {
                break;
            }     

            x = Convert.ToDouble(x_1);
            Console.WriteLine("Введите y");
            y = Convert.ToDouble(Console.ReadLine());
            
            if ((x - a) * (x - a) + (y - b) * (y - b) <= r * r) {
                answer++;
            }
        }
        Console.Write(answer);
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
        Console.WriteLine("Введите норму");
        norm = Convert.ToDouble(Console.ReadLine());

        // code here
        while (true) {

            Console.WriteLine("Введите результат, для остановки введите #");
            string rez_1 = Console.ReadLine();
            if (rez_1 == "#") {
                break;
            }
            double rez = Convert.ToDouble(rez_1);
            if (rez <= norm) {
                answer++;
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
    public (double, double) Task_3_8(int n)
    {
        double answer = 0;
        double answerLength = double.MaxValue;

        // code here
        double min = Double.MaxValue;
        while (true) {
            Console.WriteLine("Введите x, для остановки введите #");
            string x_1 = Console.ReadLine();
            if (x_1 == "#") {
                break;
            }
            double x = Convert.ToDouble(x_1);
            Console.WriteLine("Введите y");
            double y = Convert.ToDouble(Console.ReadLine());

            if (x * x + y * y < min) {
                min = x * x + y * y;
            }
        }

        answer = Math.Round(Math.Sqrt(min), 2);
        Console.WriteLine(answer);
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
        double avg = 0;
        int i = 0;
        double sum = 0;
        while (true) {
            Console.WriteLine("Введите оценки, для остановки введите #");
            string a_1 = Console.ReadLine();
            if (a_1 == "#") {
                break;
            }
            double a = Convert.ToDouble(a_1);
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            double d = Convert.ToDouble(Console.ReadLine());
            i = i + 4;
            if (a == 2 || b == 2 || c == 2 || d == 2) {
                answer++;
            }
            sum = sum + a + b + c + d;
        }
        avg = sum / i;
        Console.WriteLine("   " + answer + "   " + avg);
    
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