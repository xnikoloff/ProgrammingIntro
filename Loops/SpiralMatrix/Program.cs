using System;

namespace SpiralMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            // print spiral matrix by n number
            int MAX = 100;

            static void fillMatrix(int m, int n, int[,] array)
            {
                int val = 1;
                int k = 0;
                int l = 0;

                while (k < m && l < n)
                {
                    for (int i = l; i < n; ++i)
                    {
                        array[k, i] = val++;
                    }

                    k++;

                    for (int i = k; i < m; ++i)
                    {
                        array[i, n - 1] = val++;
                    }

                    n--;

                    if (k < n)
                    {
                        for (int i = n - 1; i >= l; --i)
                        {
                            array[m - 1, i] = val++;
                        }

                        m--;
                    }


                    if (l < n)
                    {
                        for (int i = m - 1; i >= k; --i)
                        {
                            array[i, l] = val++;
                        }

                        l++;
                    }
                }
            }

            int m = 4;
            int n = 4;
            int[,] array = new int[MAX, MAX];

            fillMatrix(m, n, array);
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(array[i, j] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
