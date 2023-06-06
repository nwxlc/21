using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21
{
    class Program
    {
        static void Main()
        {
            int m = 5, n = 5, counter = 1, i = 0, j = 0, direction = 0;
            int[,] matrix = new int[m, n];
            for (int k = 0; k < m * n; k++)
            {
                matrix[i, j] = counter;
                counter++;
                switch (direction)
                {
                    case 0:
                        if (j == n - 1 || matrix[i, j + 1] != 0)
                        {
                            direction = 1;
                            i++;
                        }
                        else j++;
                        break;

                    case 1:
                        if (i == m - 1 || matrix[i + 1, j] != 0)
                        {
                            direction = 2;
                            j--;
                        }
                        else i++;
                        break;

                    case 2:
                        if (j == 0 || matrix[i, j - 1] != 0)
                        {
                            direction = 3;
                            i--;
                        }
                        else j--;
                        break;

                    case 3:
                        if (i == 0 || matrix[i - 1, j] != 0)
                        {
                            direction = 0;
                            j++;
                        }
                        else i--;
                        break;
                }
            }
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("{0}\t", matrix[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Хотите повторить задачу? Если да, нажмите Enter");
            if (Console.ReadKey().Key == ConsoleKey.Enter) Main();
        }
    }
}
