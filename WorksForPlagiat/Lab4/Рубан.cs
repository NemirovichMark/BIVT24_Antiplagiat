using Microsoft.VisualBasic.FileIO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text;
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
        double s = 0;
        int n = 0;
        for (int i = 0; i < A.GetLength(0); i++) for (int j = 0; j < A.GetLength(1); j++)
        {
                if (A[i, j] > 0)
                {
                    s += A[i, j];
                    n++;
                }
        }
        if (n != 0) answer = s / n;
        // end

        return answer;
    }
    public int Task_1_3(int[,] A)
    {
        int answer = 0;
        // code here

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
        int value = 0, rowIndex = 0;
        // code here
        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (A[i, colIndex] < 0)
            {
                value = A[i, colIndex];
                rowIndex = i;
                break;
            }
        }
        // end

        return (value, rowIndex);
    }
    public int[] Task_1_6(int[,] A)
    {
        int[] answer = default(int[]);
        // code here

        // end

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
        bool isNotNull = false;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] != 0)
                {
                    isNotNull = true;
                    break;
                }
            }
            if (isNotNull) break;
        }
        if (!isNotNull) return answer;
        answer = new double[A.GetLength(0)];
        for (int i = 0; i < A.GetLength(0); i++)
        {
            double s = 0, n = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > 0)
                {
                    s += A[i, j];
                    n++;
                }
            }
            if (n != 0) { answer[i] = s / n; } else { answer[i] = 0; };
        }
        // end

        return answer;
    }
    public int[,] Task_1_9(int[,] A)
    {
        // code here

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
        int[,] B = default(int[,]);
        bool isNotNull = false;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] != 0)
                {
                    isNotNull = true;
                    break;
                }
            }
            if (isNotNull) break;
        }
        if (!isNotNull) return B;
        int mn = int.MaxValue;
        for (int i = 0; i < A.GetLength(0); i++) if (mn > A[i, 0]) mn = A[i, 0];
        B = new int[A.GetLength(0) - 1, A.GetLength(1)];
        int k = 0;
        bool deleted = false;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            if ((A[i, 0] == mn) && (!deleted)){
                deleted = true;
                continue;
            }
            for (int j = 0; j < A.GetLength(1); j++)
            {
                B[k, j] = A[i, j];
            }
            k++;
        }
        // end

        return B;
    }
    public int[,] Task_1_12(int[,] A)
    {
        // code here

        // end

        return A;
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
        bool isNotNull = false;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] != 0)
                {
                    isNotNull = true;
                    break;
                }
            }
            if (isNotNull) break;
        }
        if (!isNotNull) return answer;
        answer = new int[A.GetLength(1)];
        for (int i = 0; i < A.GetLength(1); i++)
        {
            int count = 0;
            for (int j = 0; j < A.GetLength(0); j++) if (A[j, i] < 0) count++;
            answer[i] = count;
        }
        // end

        return answer;
    }
    public int[,] Task_1_15(int[,] A)
    {
        // code here

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
        int[,] A = new int[n, m];
        for (int i = 0; i < n; i++)
        {
            int k = 0;
            int mn = int.MaxValue;
            for (int j = 0; j < m; j++) if (mn > B[i, j]) mn = B[i, j];
            A[i, 0] = mn;
            for (int j = 0; j < m; j++)
            {
                if (B[i, j] == mn) continue;
                A[i, k + 1] = B[i, j];
                k++;
            }
        }
        // end

        return A;
    }
    public int[,] Task_1_18(int[,] D, int n, int m)
    {
        // code here

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
        double[,] A = new double[n, m];
        for (int i = 0; i < n; i++)
        {
            bool fmin = false;
            double firstmin = 0, lastmin = 0, mx = double.MinValue;
            for (int j = 0; j < m; j++)
            {
                if (F[i, j] > mx) mx = F[i, j];
                if ((F[i, j] < 0))
                {
                    lastmin = F[i, j];
                    if (!fmin)
                    {
                        firstmin = F[i, j];
                        fmin = true;
                    }
                }
            }
            for (int j = 0; j < m; j++) if ((F[i, j] == mx) && (firstmin + lastmin != 0)) { A[i, j] = (firstmin + lastmin) / 2; } else { A[i, j] = F[i, j]; }
            // end
        }
        return A;
    }
    public int[,] Task_1_21(int[,] H)
    {
        // code here

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
        int[,] A = default(int[,]);
        bool isNotNull = false;
        for (int i = 0; i < G.GetLength(0); i++)
        {
            for (int j = 0; j < G.GetLength(1); j++)
            {
                if (G[i, j] != 0)
                {
                    isNotNull = true;
                    break;
                }
            }
            if (isNotNull) break;
        }
        if (!isNotNull) return A;
        A = new int[G.GetLength(0), G.GetLength(1)];
        for (int i = 0; i < G.GetLength(0); i++)
        {
            int mx = int.MinValue;
            int k = 0;
            for (int j = 0; j < G.GetLength(1); j++) if (G[i, j] > mx) mx = G[i, j];
            for (int j = 0; j < G.GetLength(1) - 1; j++)
            {
                A[i, k] = G[i, j];
                k++;
                if (G[i, j] == mx) {
                    A[i, k] = mx;
                    k++;
                }
            }
        }
        // end

        return A;
    }
    public double[,] Task_1_24(double[,] Y)
    {
        // code here

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
        int[,] C = default(int[,]);
        bool isNotNull = false;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] != 0)
                {
                    isNotNull = true;
                    break;
                }
            }
            if (isNotNull) break;
        }
        if (!isNotNull) return C;
        isNotNull = false;
        for (int i = 0; i < B.Length; i++)
        {
            if (B[i] != 0)
            {
                isNotNull = true;
                break;
            }
        }
        if (!isNotNull) return C;
        int mx = int.MinValue;
        C = new int[A.GetLength(0), A.GetLength(1)];
        for (int i = 0; i < A.GetLength(0); i++) if (A[i, 5] > mx) mx = A[i, 5];
        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (A[i, 5] == mx)
            {
                for (int j = 0; j < A.GetLength(1); j++) C[i, j] = B[j];
            } else
            {
                for (int j = 0; j < A.GetLength(1); j++) C[i, j] = A[i, j];
            }
        }
        // end

        return C;
    }
    public int[,] Task_1_27(int[,] B)
    {
        // code here

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
        int[,] A = default(int[,]);
        bool isNotNull = false;
        for (int i = 0; i < F.GetLength(0); i++)
        {
            for (int j = 0; j < F.GetLength(1); j++)
            {
                if (F[i, j] != 0)
                {
                    isNotNull = true;
                    break;
                }
            }
            if (isNotNull) break;
        }
        if (!isNotNull) return A;
        A = new int[F.GetLength(0), F.GetLength(1) - 1];
        int mn = int.MaxValue;
        int k = 0;
        bool skip = false;
        for (int i = 0; i < F.GetLength(1); i++) if (Math.Abs(F[1, i]) < Math.Abs(mn)) mn = F[1, i];
        for (int j = 0; j < F.GetLength(1); j++)
        {
            if (skip)
            {
                skip = false;
                continue;
            }
            for (int i = 0; i < F.GetLength(0); i++)
            {
                A[i, k] = F[i, j];
            }
            for (int i = 0; i < F.GetLength(0); i++) if (A[i, k] == mn) skip = true;
            k++;
        }
        // end

        return A;
    }
    public int[,] Task_1_30(int[,] B)
    {
        // code here

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
        double[,] B = default(double[,]);
        bool isNotNull = false;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] != 0)
                {
                    isNotNull = true;
                    break;
                }
            }
            if (isNotNull) break;
        }
        if (!isNotNull) return B;
        B = new double[A.GetLength(0), A.GetLength(1)];
        for (int i = 0; i < A.GetLength(0); i++)
        {
            bool fix = false;
            double s = 0, mx = int.MinValue;
            int n = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] > 0)
                {
                    s += A[i, j];
                    n++;
                }
                if (A[i, j] > mx) mx = A[i, j];
            }
            if (n != 0) s /= n;
            for (int j = 0; j < A.GetLength(1); j++) {
                if ((A[i, j] == mx) && (!fix))
                {
                    B[i, j] = s;
                    fix = true;
                } else {
                    B[i, j] = A[i, j];
                }
            }
        }
        // end

        return B;
    }
    public int[] Task_1_33(int[,] A)
    {
        int[] answer = default(int[]);
        // code here
        
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double[,] Task_2_1(double[,] A)
    {
        // code here
        double[,] B = default(double[,]);
        bool isNotNull = false;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] != 0)
                {
                    isNotNull = true;
                    break;
                }
            }
            if (isNotNull) break;
        }
        if (!isNotNull) return B;
        B = new double [A.GetLength(0), A.GetLength(1)];
        for (int i = 0; i < A.GetLength(0); i++)
        {
            double mx = double.MinValue;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (mx < A[i, j]) mx = A[i, j];
                B[i, j] = A[i, j];
            }
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if ((j == 0) && (B[i, j] == mx))
                {
                    if (B[i, j + 1] > 0) { B[i, j + 1] *= 2; } else { B[i, j + 1] /= 2; };
                    break;
                }
                else if ((j == A.GetLength(1) - 1) && (B[i, j] == mx))
                {
                    if (B[i, j - 1] > 0) { B[i, j - 1] *= 2; } else { B[i, j - 1] /= 2; };
                    break;
                }
                else if (B[i, j] == mx)
                {
                    if (B[i, j - 1] < B[i, j + 1])
                    {
                        if (B[i, j - 1] > 0) { B[i, j - 1] *= 2; } else { B[i, j - 1] /= 2; };
                        break;
                    }
                    else
                    {
                        if (B[i, j + 1] > 0) { B[i, j + 1] *= 2; } else { B[i, j + 1] /= 2; };
                        break;
                    }
                }
            }
        }
        // end

        return B;
    }
    #endregion
    public int[,] Task_2_2(int[,] A)
    {
        // code here
        int[,] B = default(int[,]);
        bool isNotNull = false;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] != 0)
                {
                    isNotNull = true;
                    break;
                }
            }
            if (isNotNull) break;
        }
        if (!isNotNull) return B;
        B = new int[A.GetLength(0), A.GetLength(1)];
        for (int j = 0; j < A.GetLength(1); j++)
        {
            int pos = 0, neg = 0, mx = int.MinValue;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if ((A[i, j] > 0)) pos++;
                if ((A[i, j] < 0)) neg++;
                if (A[i, j] > mx) mx = A[i, j];
                B[i, j] = A[i, j];
            }
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (B[i, j] == mx)
                {
                    if (pos > neg)
                    {
                        B[i, j] = 0;
                    } else
                    {
                        B[i, j] = i + 1;
                    }
                    break;
                }
            }
        }
        // end

        return B;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        int[,] B = default(int[,]);
        bool isNotNull = false;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] != 0)
                {
                    isNotNull = true;
                    break;
                }
            }
            if (isNotNull) break;
        }
        if (!isNotNull) return B;
        B = new int[A.GetLength(0), A.GetLength(1)];
        for (int j = 0; j < A.GetLength(1); j++)
        {
            int s = 0;
            int mx = int.MinValue, mxdex = 11;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                B[i, j] = A[i, j];
                if (A[i, j] > mx)
                {
                    mx = A[i, j];
                    mxdex = i;
                }
            }
            if (mxdex < 5)
            {
                for (int i = mxdex + 1; i < A.GetLength(0); i++) s += A[i, j];
                B[0, j] = s;
            }
        }
        // end

        return B;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
        int[,] C = default(int[,]);
        bool isNotNull = false;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] != 0)
                {
                    isNotNull = true;
                    break;
                }
            }
            if (isNotNull) break;
        }
        if (!isNotNull) return C;
        isNotNull = false;
        for (int i = 0; i < B.Length; i++)
        {
            if (B[i] != 0)
            {
                isNotNull = true;
                break;
            }
        }
        if (!isNotNull) return C;
        C = new int[A.GetLength(0), A.GetLength(1)];
        for (int j = 0; j < A.GetLength(1); j++)
        {
            int mx = int.MinValue;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                C[i, j] = A[i, j];
                if (A[i, j] > mx) mx = A[i, j];
            }
            for (int i = 0; i < A.GetLength(1); i++)
            {
                if (A[i, j] == mx)
                {
                    if (A[i, j] < B[j]) C[i, j] = B[j];
                    break;
                }
            }
        }
        // end

        return C;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        double[,] B = default(double[,]);
        bool isNotNull = false;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] != 0)
                {
                    isNotNull = true;
                    break;
                }
            }
            if (isNotNull) break;
        }
        if (!isNotNull) return B;
        B = new double[A.GetLength(0), A.GetLength(1)];
        for (int j = 0; j < A.GetLength(1); j++)
        {
            double mx = double.MinValue;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                B[i, j] = A[i, j];
                if (A[i, j] > mx) mx = A[i, j];
            }
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] == mx)
                {
                    if (mx < (A[0, j] + A[A.GetLength(0) - 1, j]) / 2)
                    {
                        B[i, j] = (A[0, j] + A[A.GetLength(0) - 1, j]) / 2;
                    } else
                    {
                        B[i, j] = i + 1;
                    }
                    break;
                }
            }
        }
        // end

        return B;
    }
    public int[,] Task_2_6(int n)
    {
        int[,] answer = default(int[,]);
        // code here
        if (n <= 0) return answer;
        answer = new int[n, n * 3];
        for (int i = 0; i < n; i++) for (int j = 0; j < n * 3; j++) if (i == j % 3) answer[i, j] = 1;
        // end
        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        int[,] B = default(int[,]);
        bool isNotNull = false;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] != 0)
                {
                    isNotNull = true;
                    break;
                }
            }
            if (isNotNull) break;
        }
        if (!isNotNull) return B;
        B = new int[A.GetLength(0), A.GetLength(1)];
        int mx = int.MinValue, mxdex = 0;
        for (int i = 0; i < A.GetLength(0); i++) {
                if (A[i, i] > mx)
                {
                    mx = A[i, i];
                    mxdex = i;
                }
                for (int j = 0; j < A.GetLength(1); j++) B[i, j] = A[i, j];
            }
        for (int i = 0; i < A.GetLength(0) - 1; i++)
        {
            if (i == mxdex) break;
            for (int j = i + 1; j < A.GetLength(1); j++) B[i, j] = 0;
        }
        // end
        return B;
    }
    public int[,] Task_2_8(int[,] B)
    {
        // code here
        int[,] A = default(int[,]);
        bool isNotNull = false;
        for (int i = 0; i < B.GetLength(0); i++)
        {
            for (int j = 0; j < B.GetLength(1); j++)
            {
                if (B[i, j] != 0)
                {
                    isNotNull = true;
                    break;
                }
            }
            if (isNotNull) break;
        }
        if (!isNotNull) return A;
        A = new int[B.GetLength(0), B.GetLength(1)];
        for (int i = 0; i < B.GetLength(0); i++) for (int j = 0; j < B.GetLength(1); j++) A[i, j] = B[i, j];
        for (int i = 0; i < B.GetLength(0); i += 2)
        {
            int fmx = int.MinValue, smx = int.MinValue, fmxdex = 0, smxdex = 0;
            for (int j = 0; j < B.GetLength(1); j++)
            {
                if (A[i, j] > fmx)
                {
                    fmx = A[i, j];
                    fmxdex = j;
                }
                if (A[i + 1, j] > smx)
                {
                    smx = A[i + 1, j];
                    smxdex = j;
                }
            }
            A[i, fmxdex] = smx;
            A[i + 1, smxdex] = fmx;
        }
        // end

        return A;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        int[,] B = default(int[,]);
        bool isNotNull = false;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] != 0)
                {
                    isNotNull = true;
                    break;
                }
            }
            if (isNotNull) break;
        }
        if (!isNotNull) return B;
        B = new int[A.GetLength(0), A.GetLength(1)];
        for (int i = 0; i < A.GetLength(0); i++) for (int j = 0; j < A.GetLength(1); j++) B[i, j] = A[i, A.GetLength(1) - j - 1];
        // end

        return B;
    }

    #region Level 3
    public int[,] Task_3_1(int[,] matrix)
    {
        // code here
        int[,] A = default(int[,]);
        bool isNotNull = false;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] != 0)
                {
                    isNotNull = true;
                    break;
                }
            }
            if (isNotNull) break;
        }
        if (!isNotNull) return A;
        A = new int[matrix.GetLength(0), matrix.GetLength(1)];
        int[] mn = new int[matrix.GetLength(0)], mndex = new int[matrix.GetLength(0)];
        for (int i = 0; i < A.GetLength(0); i++)
        {
            mn[i] = int.MaxValue;
            mndex[i] = i;
        }
        for (int i = 0; i < A.GetLength(0); i++) for (int j = 0; j < A.GetLength(1); j++) if (mn[i] > matrix[i, j]) mn[i] = matrix[i, j];
        for (int i = 1; i <= A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(0) - i; j++)
            {
                if (mn[j] < mn[j + 1])
                {
                    int a = mn[j], b = mndex[j];
                    mn[j] = mn[j + 1];
                    mndex[j] = mndex[j + 1];
                    mn[j + 1] = a;
                    mndex[j + 1] = b;
                }
            }
        }
        for (int i = 0; i < A.GetLength(0); i++) for (int j = 0; j < A.GetLength(1); j++) A[i, j] = matrix[mndex[i], j];
        // end

        return A;
    }
    public int[,] Task_3_2(int[,] matrix)
    {
        // code here

        // end

        return matrix;
    }
    public int[] Task_3_3(int[,] matrix)
    {
        int[] answer = default(int[]);
        // code here
        bool isNotNull = false;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] != 0)
                {
                    isNotNull = true;
                    break;
                }
            }
            if (isNotNull) break;
        }
        if (!isNotNull) return answer;
        answer = new int[matrix.GetLength(0) * 2 - 1];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                answer[matrix.GetLength(0) - 1 + j - i] += matrix[i, j];
            }
        }
        // end

        return answer;
    }
    public int[,] Task_3_4(int[,] matrix)
    {
        // code here

        // end

        return matrix;
    }
    public int[,] Task_3_5(int[,] matrix, int k)
    {
        // code here
        int[,] A = default(int[,]);
        bool isNotNull = false;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] != 0)
                {
                    isNotNull = true;
                    break;
                }
            }
            if (isNotNull) break;
        }
        if (!isNotNull) return A;
        if (k <= 0) return A;
        A = new int[matrix.GetLength(0), matrix.GetLength(1)];
        int mx = 0, mxi = 0, mxj = 0, ki = k - 1, kj = k - 1;
        for (int i = 0; i < matrix.GetLength(0); i++) for (int j = 0; j < matrix.GetLength(1); j++) if (Math.Abs(matrix[i, j]) > mx)
                {
                    mx = matrix[i, j];
                    mxi = i - 1;
                    mxj = j - 1;
                }
        int ai = ki, aj = kj;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (i == ki)
                {
                    if (j == kj)
                    {
                        A[i, j] = matrix[mxi, mxj];
                    } else if (j == mxj)
                    {
                        A[i, j] = matrix[mxi, kj];
                    }
                    else
                    {
                        A[i, j] = matrix[mxi, j];
                    }
                } else if (i == mxi)
                {
                    if (j == kj)
                    {
                        A[i, j] = matrix[ki, mxj];
                    }
                    else if (j == mxj)
                    {
                        A[i, j] = matrix[ki, kj];
                    }
                    else
                    {
                        A[i, j] = matrix[ki, j];
                    }
                } else
                {
                    if (j == kj)
                    {
                        A[i, j] = matrix[i, mxj];
                    } else if (j == mxj)
                    {
                        A[i, j] = matrix[i, kj];
                    } else
                    {
                        A[i, j] = matrix[i, j];
                    }
                }
            }
        }
        // end
        return A;
    }
    public (int[], int[]) Task_3_6(int[,] matrix)
    {
        int[] upper = default(int[]);
        int[] lower = default(int[]);
        // code here

        // end

        return (upper, lower);
    }
    public int[] Task_3_7(int[] A, int[] B, int n)
    {
        int[] answer = default(int[]);

        // code here
        bool isNotNullA = false;
        bool isNotNullB = false;
        for (int i = 0; i < A.Length; i++)
        {
            if (A[i] != 0) isNotNullA = true;
            if (B[i] != 0) isNotNullB = true;
            if ((isNotNullA) && (isNotNullB)) break;
        }
        if (!((isNotNullA) && (isNotNullB))) return answer;
        int a = 0;
        int[,] AM = new int[n, n], BM = new int[n, n], answerM = new int[n, n];
        answer = new int[n * n];
        for (int i = 0; i < n; i++)
        {
            for (int j = i; j < n; j++)
            {
                AM[i, j] = A[a];
                if (j > i) AM[j, i] = A[a];
                BM[i, j] = B[a];
                if (j > i) BM[j, i] = B[a];
                a++;
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                for (int k = 0; k < n; k++)
                {
                    answerM[i, k] += (AM[i, j] * BM[j, k]);
                }
            }
        }
        a = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                answer[a] = answerM[i, j];
                a++;
            }
        }
        // end
        return answer;
    }
    public int[,] Task_3_8(int[,] matrix)
    {
        // code here

        // end

        return matrix;
    }
    public int[,] Task_3_9(int[,] matrix)
    {
        // code here
        int[,] A = default(int[,]);
        bool isNotNull = false;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] != 0)
                {
                    isNotNull = true;
                    break;
                }
            }
            if (isNotNull) break;
        }
        if (!isNotNull) return A;
        A = new int[matrix.GetLength(0), matrix.GetLength(1)];
        int[] minuscount = new int[matrix.GetLength(1)], minusdex = new int[matrix.GetLength(1)];
        for (int j = 0; j < A.GetLength(1); j++)
        {
            int minus = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (matrix[i, j] < 0) minus++;
            }
            minuscount[j] = minus;
            minusdex[j] = j;
        }
        for (int i = 1; i <= minuscount.Length; i++)
        {
            for (int j = 0; j < minuscount.Length - 1; j++)
            {
                if (minuscount[j] > minuscount[j + 1])
                {
                    int a = minuscount[j], b = minusdex[j];
                    minuscount[j] = minuscount[j + 1];
                    minusdex[j] = minusdex[j + 1];
                    minuscount[j + 1] = a;
                    minusdex[j + 1] = b;
                }
            }
        }
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                A[i, j] = matrix[i, minusdex[j]];
            }
        }
        // end

        return A;
    }
    public int[,] Task_3_10(int[,] matrix)
    {
        // code here

        // end

        return matrix;
    }
    public int[,] Task_3_11(int[,] matrix)
    {
        // code here
        int[,] A = default(int[,]);
        bool isNotNull = false;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] != 0)
                {
                    isNotNull = true;
                    break;
                }
            }
            if (isNotNull) break;
        }
        if (!isNotNull) return A;
        int a = matrix.GetLength(0);
        bool[] to_delete = new bool[matrix.GetLength(0)];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == 0)
                {
                    to_delete[i] = true;
                    a--;
                    break;
                }
            }
        }
        A = new int[a, matrix.GetLength(1)];
        a = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            if (to_delete[i]) continue;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                A[a, j] = matrix[i, j];
            }
            a++;
        }
        // end

        return A;
    }
    #endregion
}
