using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Timers;
using System.Xml.Linq;

public class Program
{
    public static void Main()
    {
        Program program = new Program();

    }
    #region Level 1
    public int Task_1_1(int[,] A)
    {
        int answer = 0;
        // code here

        // end

        return answer;
    }
    public double Task_1_2(int[,] A)
    {
        double answer = 0;
        // code here

        // end

        return answer;
    }
    public int Task_1_3(int[,] A)
    {
        int rows = A.GetLength(0); 
        int cols = A.GetLength(1); 

        int answer = 0;

        if (rows != cols)
        {
            return 0; 
        }

        
        for (int i = 0; i < rows; i++)
        {
            answer += A[i, i];           
        }
         

        // end

        return answer;
    }
    public (int, int) Task_1_4(int[,] A)
    {
        int row = 0, col = 0;
        // code here

        // end

        return (row, col);
    }
    public (int, int) Task_1_5(int[,] A, int colIndex)
    {
        int value = 0, rowIndex = -1;
        // code here

        // end

        return (value, rowIndex);
    }
    public int[] Task_1_6(int[,] A)
    {
        // Проверка на null
        if (A == null)
        {
            return null;
        }

        // Проверка размерности
        int rows = A.GetLength(0);
        int cols = A.GetLength(1);
        if (rows != 4 || cols != 7)
        {
            return null;
        }

        // Инициализация массива для ответа
        int[] answer = new int[rows];

        // Нахождение минимальных индексов
        for (int i = 0; i < rows; i++)
        {
            int minIndex = 0;
            for (int j = 1; j < cols; j++)
            {
                if (A[i, j] < A[i, minIndex])
                {
                    minIndex = j;
                }
            }
            answer[i] = minIndex;
        }

        return answer;
    }
    public int[] Task_1_7(int[,] A)
    {
        int[] answer = default(int[]);
        // code here

        // end

        return answer;
    }
    public double[] Task_1_8(int[,] A)
    {
        double[] answer = default(double[]);
        // code here

        // end

        return answer;
    }
    public int[,] Task_1_9(int[,] A)
    {
        // code here
        if (A == null)
        {
            return null;
        }

        int rows = A.GetLength(0);
        int cols = A.GetLength(1);
        if (rows != 5 || cols != 7)
        {
            return null;
        }

        for (int i = 0; i < rows; i++)
        {
            int maxIndex = 0; 
            for (int j = 1; j < cols; j++)
            {
                if (A[i, j] > A[i, maxIndex])
                {
                    maxIndex = j;
                }
            }

            int tmp = A[i, 0];
            A[i, 0] = A[i, maxIndex];
            A[i, maxIndex] = tmp;
        }
        // end

        return A;
    }
    public int[,] Task_1_10(int[,] A)
    {
        // code here

        // end

        return A;
    }
    public int[,] Task_1_11(int[,] A)
    {
        // code here

        // end

        return A;
    }
    public int[,] Task_1_12(int[,] A)
    {
        // Проверка на null
        if (A == null)
        {
            return null; // Исправлено: "retunr 0" -> "return null;"
        }

        int rows = A.GetLength(0);
        int cols = A.GetLength(1);

        // Проверка размерности
        if (rows != 6 || cols != 7)
        {
            return null; // Исправлено: "return 0;" -> "return null;"
        }

        // Поиск максимального элемента и его индексов
        int maxRow = 0;
        int maxCol = 0;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (A[i, j] > A[maxRow, maxCol])
                {
                    maxRow = i;
                    maxCol = j;
                }
            }
        }

        // Создание новой матрицы
        int[,] result = new int[rows - 1, cols - 1];
        int newRow = 0, newCol;

        for (int i = 0; i < rows; i++)
        {
            if (i == maxRow)
            {
                continue;
            }

            newCol = 0;
            for (int j = 0; j < cols; j++)
            {
                if (j == maxCol)
                {
                    continue;
                }

                result[newRow, newCol] = A[i, j];
                newCol++;
            }
            newRow++;
        }

        return result;
    }

    public int[,] Task_1_13(int[,] A)
    {
        // code here

        // end

        return A;
    }
    public int[] Task_1_14(int[,] A)
    {
        int[] answer = default(int[]);
        // code here

        // end

        return answer;
    }
    public int[,] Task_1_15(int[,] A)
    {
        // code here
        if (A == null) {
            return null;
        }


        int rows = A.GetLength(0);
        int cols = A.GetLength(1);

        if (rows!=5 || cols!=7) {
            return null;
        }

        for (int i = 0; i < rows; i++) {
            int maxRow = 0;
            for (int j = 0; j < cols; j++) {
                if (A[i, j] > A[i, maxRow]) {
                    maxRow = j;
                }
            }
            A[i, maxRow] *= (i+1);
        }
        // end

        return A;
    }
    public int[,] Task_1_16(int[,] A, int n, int m)
    {
        // code here

        // end

        return A;
    }
    public int[,] Task_1_17(int[,] B, int n, int m)
    {
        // code here

        // end

        return B;
    }
    public int[,] Task_1_18(int[,] D, int n, int m)
    {
        // code here
        if (D == null || n <= 0 || m <=0) {
            return null;
        }

        
        for (int i = 0; i < n; i++)
        {
            int maxInRow = -1; 
            int lastNeg = -1;  
            int maxValue = int.MinValue;

            for (int j = 0; j < m; j++)
            {
                if (D[i, j] < 0)
                {                    
                    break;
                } 
                if (D[i, j] > maxValue)
                {
                    maxValue = D[i, j];
                    maxInRow = j; 
                }
            }

            for (int k = 0; k < m; k++) {
                if (D[i, k] < 0) {
                    lastNeg = k;
                }
            }

            if (maxInRow != -1 && lastNeg != -1)
            {
                int tmp = D[i, maxInRow];
                D[i, maxInRow] = D[i, lastNeg];
                D[i, lastNeg] = tmp;
            }
        }
        // end
                return D;

        }
    public double[,] Task_1_19(double[,] C, int n, int m)
    {
        // code here

        // end

        return C;
    }
    public double[,] Task_1_20(double[,] F, int n, int m)
    {
        // code here

        // end

        return F;
    }
    public int[,] Task_1_21(int[,] H)
    {
        // code here
        // code here
        if (H == null) {
            return null;
        }

        int rows = H.GetLength(0);
        int cols = H.GetLength(1);

        if (rows!=5 || cols!=7) {
            return null;
        }

        for (int i = 0; i < rows; i++) {
            int maxInRow = 0;
            for (int j = 0; j < cols; j++) {
                if (H[i, j] > H[i, maxInRow]) {
                    maxInRow = j;
                }
            }
            H[i, cols-1] = H[i, cols-2];
            H[i, cols - 2] = H[i, maxInRow];
        }
        // end

        return H;
    }
    public double[,] Task_1_22(double[,] Z)
    {
        // code here

        // end

        return Z;
    }
    public int[,] Task_1_23(int[,] G)
    {
        // code here

        // end

        return G;
    }
    public double[,] Task_1_24(double[,] Y)
    {
        // code here
        if (Y == null) {
            return null;
        }

        int rows = Y.GetLength(0);
        int cols = Y.GetLength(1);

        if (rows!=6 || cols!=5) {
            return null;
        }
        for (int i = 0; i < rows; i++) {
            int maxInd = 0;
            for (int j = 0; j < cols; j++) {
                if (Y[i, j] > Y[i, maxInd]) {
                    maxInd = j;
                }
            }
            double sum = 0;
            double count = 0;
            for (int k = maxInd+1; k < cols; k++) {
                if (Y[i, k] > 0) {
                    count++;
                    sum+=Y[i, k];
                }
            }
            double aver = 0;
            if (count!=0) {
                aver = sum/count;
            }
            for (int l = 0; l < maxInd; l++) {
                if (Y[i, l] < 0) {
                    Y[i, l] = aver;
                }
            }
        }        
        // end

        return Y;
    }
    public int[,] Task_1_25(int[,] X)
    {
        // code here

        // end

        return X;
    }
    public int[,] Task_1_26(int[,] A, int[] B)
    {
        // code here

        // end

        return A;
    }
    public int[,] Task_1_27(int[,] B)
    {
        // code here
        if (B == null) {
            return null;
        }

        int rows = B.GetLength(0);
        int cols = B.GetLength(1);

        if (rows!=5 || cols!=7) {
            return null;
        }
        int[] maxs = new int[rows];
        for (int i = rows-1; i >= 0; i--) {
            int maxInd = 0;
            for (int j = 0; j < cols; j++) {
                if (B[i, j] > B[i, maxInd]) {
                    maxInd = j;
                }
            }
            maxs[i] = B[i, maxInd];
        }

        for (int k = 0; k < rows; k++) {
            B[k, 3] = maxs[rows - k - 1];
        }
        // end

        return B;
    }
    public int[,] Task_1_28(int[,] A)
    {
        // code here

        // end

        return A;
    }
    public int[,] Task_1_29(int[,] F)
    {
        // code here

        // end

        return F;
    }
    public int[,] Task_1_30(int[,] B)
    {
        // code here
        if (B == null) {
            return null;
        }

        int rows = B.GetLength(0);
        int cols = B.GetLength(1);

        if (rows!=5 || cols!=5) {
            return null;
        }
        
        int maxInd = 0;
        for (int i = 0; i < rows; i++) {
            if (B[i, i] > B[maxInd, maxInd]) {
                maxInd = i;
            }
        }

        int firstNeg = 0;
        for (int i = 0; i < rows; i++) {
            if (B[i, 2] < 0) {
                firstNeg = i;
                break;
            }
        }
        int[] tmp = new int[cols];
        for (int i = 0; i < cols; i++) {
            tmp[i] = B[maxInd, i];
        }
        for (int i = 0; i < cols; i++) {
            B[maxInd, i] = B[firstNeg, i];
            B[firstNeg, i] = tmp[i];
        }
        // end

        return B;
    }
    public int[,] Task_1_31(int[,] A, int[] B)
    {
        // code here

        // end

        return A;
    }
    public double[,] Task_1_32(double[,] A)
    {
        // code here

        // end

        return A;
    }
    public int[] Task_1_33(int[,] A)
    {
        int[] answer = default(int[]);
        // code here
        if (A == null) {
            return null;
        }

        int rows = A.GetLength(0);
        int cols = A.GetLength(1);

        if (rows!=5 || cols!=7) {
            return null;
        }
        int index = 0;

        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                if (A[i, j] < 0) {
                    // answer[index] = A[i, j];
                    index++;
                }
            }
        }
        answer = new int[index];
        index = 0;
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                if (A[i, j] < 0) {
                    answer[index] = A[i, j];
                    index++;
                }
            }
        }
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double[,] Task_2_1(double[,] A)
    {
        // code here
        if (A == null) {
            return null;
        }

        int rows = A.GetLength(0);
        int cols = A.GetLength(1);

        if (rows!=5 || cols!=7) {
            return null;
        }

        for (int i = 0; i < rows; i++) {
            int maxInd = 0;
            for (int j = 0; j < cols; j++) {
                if (A[i, j] > A[i, maxInd]) {
                    maxInd = j;
                }
            }
            double times = 2;
            if (maxInd == 0) {
                if (A[i, maxInd +1] < 0) {
                    times = 0.5;
                }
                A[i, maxInd+1] = times * A[i, maxInd+1]; 
            } else if (maxInd == cols-1) {
                if (A[i, maxInd -1] < 0) {
                    times = 0.5;
                }
                A[i, maxInd-1] = times * A[i, maxInd-1]; 
            } else if (A[i, maxInd-1] < A[i, maxInd+1]) {
                if (A[i, maxInd -1] < 0) {
                    times = 0.5;
                }
                A[i, maxInd-1] = times * A[i, maxInd-1];
            } else {
                if (A[i, maxInd +1] < 0) {
                    times = 0.5;
                }
                A[i, maxInd+1] = times * A[i, maxInd+1];
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_2(int[,] A)
    {
        // code here
        if (A == null) {
            return null;
        }

        int rows = A.GetLength(0);
        int cols = A.GetLength(1);

        if (rows!=7 || cols!=5) {
            return null;
        }
        for (int j = 0; j < cols; j++) {
            int countPos = 0;
            int countNeg = 0;
            int maxInd = 0;
            for (int i = 0; i < rows; i++) {
                if (A[i, j] > 0) {
                    countPos++;
                }
                else if (A[i, j] < 0) {
                    countNeg++;
                }

                if (A[i, j] > A[maxInd, j]) {
                    maxInd = i;
                }
            }
            int countMax = 0;
            for (int k = 0; k < rows; k++) {
                if (A[k, j] == A[maxInd, j]) {
                    countMax++;
                }
            }

            if (countPos > countNeg) {
                    A[maxInd, j] = 0;
            } else {
                A[maxInd, j] = maxInd+1;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        if (A == null) {
            return null;
        }

        int rows = A.GetLength(0);
        int cols = A.GetLength(1);

        if (rows!=10 || cols!=5) {
            return null;
        }

        for (int j = 0; j < cols; j++) {
            int maxInd = 0;
            for (int i = 0; i < rows; i++) {
                if (A[i, j] > A[maxInd, j]) {
                    maxInd = i;
                }
            }

            if (maxInd <= rows/2) {
                int sum = 0;
                for (int k = maxInd+1; k < rows; k++) {
                    sum+=A[k, j];
                }
                A[0, j] = sum;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
        if (A == null) {
            return null;
        }
        if (B == null) {
            return null;
        }
        if (B.Length != 5) {
            return null;
        }

        int rows = A.GetLength(0);
        int cols = A.GetLength(1);

        if (rows!=7 || cols!=5) {
            return null;
        }


        for (int j = 0; j < cols; j++) {
            int maxInd = 0;
            for (int i = 0; i < rows; i++) {
                if (A[i, j]> A[maxInd, j]) {
                    maxInd = i;
                }
            }
            if (A[maxInd, j] < B[j]) {
                A[maxInd, j] = B[j];
            }
        }
        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        if (A == null) {
            return null;
        }

        int rows = A.GetLength(0);
        int cols = A.GetLength(1);

        if (rows!=7 || cols!=5) {
            return null;
        }

        for (int j = 0; j < cols; j++) {
            int maxInd = 0;
            for (int i = 0; i < rows; i++) {
                if (A[i, j]> A[maxInd, j]) {
                    maxInd = i;
                }
            }

            double sum = (A[0, j] + A[rows-1, j]) / 2;
            if (A[maxInd, j] < sum) {
                A[maxInd, j] = sum;
            } else {
                A[maxInd, j] = maxInd+1;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        int[,] answer = default(int[,]);
        // code here
        if (n < 1){
            return null;
        }
        answer = new int[n,3*n];
        int rows = answer.GetLength(0);
        int cols = answer.GetLength(1);
        // code here
        // end
        for (int i = 0; i < rows; i++){
            for (int j = i; j < cols; j+=(n)){
                answer[i, j] = 1;
            }
        }
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        if (A == null) {
            return null;
        }

        int rows = A.GetLength(0);
        int cols = A.GetLength(1);

        if (rows!=6 || cols!=6) {
            return null;
        }
        int maxInd = 0;

        for (int i = 0; i < rows; i++) {
            if (A[i, i] > A[maxInd, maxInd]) {
                maxInd = i;
            }
        }

        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                if (i - j < 0 && i<maxInd) {
                    A[i, j] = 0;
                }
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        // code here
        if (B == null) {
            return null;
        }

        int rows = B.GetLength(0);
        int cols = B.GetLength(1);

        if (rows!=6 || cols!=6) {
            return null;
        }
        int[] maxs = new int[rows];
        int[] maxInds = new int[rows];
        for (int i = 0; i < rows; i++) {
            int maxInd = 0;
            for (int j = 0; j < cols; j++) {
                if (B[i, j] > B[i, maxInd]) {
                    maxInd = j;
                }
            }
            maxs[i] = B[i, maxInd];
            maxInds[i] = maxInd;
        }
        for (int i = 0; i < rows; i++) {
            if (i%2==0) {
                B[i, maxInds[i]] = maxs[i+1];
            } else {
                B[i, maxInds[i]] = maxs[i-1];
            }
        }
        
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        if (A == null) {
            return null;
        }

        int rows = A.GetLength(0);
        int cols = A.GetLength(1);

        if (rows!=6 || cols!=7) {
            return null;
        }

        int[,] B = new int[rows, cols];

        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                B[i, j] = A[i, cols-j-1];
            }
        }
        A=B;

        // end

        return A;
    }
    #endregion

    #region Level 3
    public int[,] Task_3_1(int[,] matrix)
    {
        // code here

        // end

        return matrix;
    }
    public int[,] Task_3_2(int[,] matrix)
    {
        // code here
        if (matrix == null) {
            return null;
        }

        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        if (rows!=cols) {
            return null;
        }
        
        for (int i = 0; i < rows; i++) {
            matrix[rows-1, i] = 0;
            matrix[i, rows-1] = 0;
            matrix[rows-1 - i, 0] = 0;
            matrix[0, rows-1 - i] = 0;
        }

        // end

        return matrix;
    }
    public int[] Task_3_3(int[,] matrix)
    {
        int[] answer = default(int[]);
        // code here

        // end

        return answer;
    }
    public int[,] Task_3_4(int[,] matrix)
    {
        // code here
        if (matrix == null) {
            return null;
        }

        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        if (rows!=cols) {
            return null;
        }

        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                if (i - j >= 0 && i > (rows/2 -rows%2)) {
                    matrix[i, j] = 1;
                }
            }
        }
        // end

        return matrix;
    }
    public int[,] Task_3_5(int[,] matrix, int k)
    {
        // code here

        // end

        return matrix;
    }
    public (int[], int[]) Task_3_6(int[,] matrix)
    {
        int[] upper = default(int[]);
        int[] lower = default(int[]);
        // code here
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        upper = new int[(rows*rows-rows)/2 + rows];
        lower = new int[(rows*rows-rows) / 2];

        if (matrix == null) {
            return (null, null);
        }

        if (rows!=cols) {
            return (null, null);
        }
        int indexUp = 0;
        int indexLow = 0;
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                if (j - i >= 0) {
                    upper[indexUp] = matrix[i, j];
                    indexUp++;
                } else {
                    lower[indexLow] = matrix[i, j];
                    indexLow++;
                }
            }
        }



        // end

        return (upper, lower);
    }
    public int[] Task_3_7(int[] A, int[] B, int n)
    {
        int[] answer = default(int[]);

        // code here

        // end

        return answer;
    }
    public int[,] Task_3_8(int[,] matrix)
{
    if (matrix == null) {
        return null;
    }

    int rows = matrix.GetLength(0);
    int cols = matrix.GetLength(1);

    if (rows != 7 || cols != 5) {
        return null;
    }
    int[] countPos = new int[rows];
    for (int i = 0; i < rows; i++){
        int count = 0;
        for (int j = 0; j < cols; j++){
            if(matrix[i, j] > 0){
                count++;
            }
        }
        countPos[i] = count;
    }
    for (int i = 0; i < rows-1; i++){
        for (int j = 0; j < rows-i-1; j++){
            if (countPos[j] < countPos[j+1]){
                int temp = countPos[j];
                countPos[j] = countPos[j + 1];
                countPos[j + 1] = temp;

                for (int index = 0; index < cols; index++){
                    int tmpMat = matrix[j, index];
                    matrix[j, index] = matrix[j+1, index];
                    matrix[j+1, index] = tmpMat;
                }
            }
        }
    }
    return matrix;
}

    public int[,] Task_3_9(int[,] matrix)
    {
        // code here

        // end

        return matrix;
    }
    public int[,] Task_3_10(int[,] matrix)
    {
        if (matrix == null) {
            return null;
        }

        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        if (rows < 1 || cols < 1) {
            return null;
        }
        // code here
        for (int i = 0; i < rows; i+=2){
            for (int j = 0; j < cols - 1; j++){
                for (int k = 0; k < cols - j - 1; k++){
                    if (matrix[i, k] < matrix[i, k+1]){
                        int tmpMat = matrix[i, k];
                        matrix[i, k] = matrix[i, k+1];
                        matrix[i, k+1] = tmpMat;
                    }
                }
            }
        }
        for (int i = 1; i < rows; i+=2){
            for (int j = 0; j < cols - 1; j++){
                for (int k = 0; k < cols - j - 1; k++){
                    if (matrix[i, k] > matrix[i, k+1]){
                        int tmpMat = matrix[i, k];
                        matrix[i, k] = matrix[i, k+1];
                        matrix[i, k+1] = tmpMat;
                    }
                }
            }
        }
        // end

        return matrix;
    }
    public int[,] Task_3_11(int[,] matrix)
    {
        // code here
        if (matrix == null) {
            return null;
        }

        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        if (rows < 1 || cols < 1) {
            return null;
        }
        int countZeroRows = 0;
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                if (matrix[i, j] == 0) {
                    countZeroRows++;
                    break;
                }
            }
        }
        int[] noZeroRows = new int[rows-countZeroRows];
        int indexNoZeroRows = 0;
        for (int i = 0; i < rows; i++) {
            int countZeros = 0;
            for (int j = 0; j < cols; j++) {
                if (matrix[i, j] == 0) {
                    countZeros++;
                }
            }
            if (countZeros == 0) {
                noZeroRows[indexNoZeroRows] = i;
                indexNoZeroRows++;
            }
        }
        int[,] newMatrix = new int[noZeroRows.Length, cols];
        int ind = 0;
        foreach(int index in noZeroRows) {
            for (int j = 0; j < cols; j++) {
                newMatrix[ind, j] = matrix[index, j];
            }
            ind++;
        }
        // end

        return newMatrix;
    }
    #endregion
}
