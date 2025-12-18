namespace Lab6
{
    public class Blue
    {
        public int FindDiagonalMaxIndex(int[,] matrix)
        {
            if (matrix.GetLength(0) != matrix.GetLength(1) || matrix.GetLength(0) == 0)
                return -1;
            int max = matrix[0, 0];
            int idx = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (matrix[row, row] > max)
                {
                    max = matrix[row, row];
                    idx = row;
                }
            }
            return idx;
        }
        public void RemoveRow(ref int[,] matrix, int rowIndex)
        {
            if (matrix.GetLength(0) <= 1)
            {
                matrix = new int[0, matrix.GetLength(1)];
                return;
            }
            int[,] new_m = new int[matrix.GetLength(0) - 1, matrix.GetLength(1)];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (row < rowIndex)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                        new_m[row, col] = matrix[row, col];
                }
                else if (row > rowIndex)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                        new_m[row - 1, col] = matrix[row, col];
                }
            }
            matrix = new_m;
        }
        public void Task1(ref int[,] matrix)
        {
            // code here
            if (matrix.GetLength(0) != matrix.GetLength(1)) return;
            int idx = FindDiagonalMaxIndex(matrix);
            if (idx != -1) RemoveRow(ref matrix, idx);
            // end
        }
        public double GetAverageExceptEdges(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            if (rows == 0 || cols == 0) return 0;
            int min = matrix[0, 0];
            int max = matrix[0, 0];
            int sum = 0;
            int count = rows * cols;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    int val = matrix[i, j];
                    sum += val;
                    if (val < min) min = val;
                    if (val > max) max = val;
                }
            }
            if (count <= 2) return 0;
            return (sum - min - max) / (double)(count - 2);
        }
        public int Task2(int[,] A, int[,] B, int[,] C)
        {
            int answer = 0;
            // code here
            double avgA = GetAverageExceptEdges(A);
            double avgB = GetAverageExceptEdges(B);
            double avgC = GetAverageExceptEdges(C);

            if (avgA < avgB && avgB < avgC) answer = 1;
            else if (avgA > avgB && avgB > avgC) answer = -1;
            else answer = 0;
            // end
            return answer;
        }
        public int FindUpperColIndex(int[,] matrix)
        {
            if (matrix.GetLength(0) != matrix.GetLength(1) || matrix.GetLength(0) == 0)
                return -1;
            int max = int.MinValue;
            int maxCol = -1;
            int n = matrix.GetLength(0);
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (matrix[i, j] > max)
                    {
                        max = matrix[i, j];
                        maxCol = j;
                    }
                }
            }
            return maxCol;
        }
        public int FindLowerColIndex(int[,] matrix)
        {
            if (matrix.GetLength(0) != matrix.GetLength(1) || matrix.GetLength(0) == 0)
                return -1;
            int max = int.MinValue;
            int maxCol = -1;
            int n = matrix.GetLength(0);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (matrix[i, j] > max)
                    {
                        max = matrix[i, j];
                        maxCol = j;
                    }
                }
            }
            return maxCol;
        }
        public void RemoveCol(ref int[,] matrix, int col)
        {
            if (matrix.GetLength(1) <= 1 || col < 0 || col >= matrix.GetLength(1))
            {
                matrix = new int[matrix.GetLength(0), 0];
                return;
            }
            int[,] new_m = new int[matrix.GetLength(0), matrix.GetLength(1) - 1];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j < col) new_m[row, j] = matrix[row, j];
                    else if (j > col) new_m[row, j - 1] = matrix[row, j];
                }
            }
            matrix = new_m;
        }
        public void Task3(ref int[,] matrix, Func<int[,], int> method)
        {
            // code here
            if (matrix.GetLength(0) != matrix.GetLength(1)) return;
            int col = method(matrix);
            if (col != -1) RemoveCol(ref matrix, col);
            // end
        }
        public bool CheckZerosInColumn(int[,] matrix, int col)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
                if (matrix[row, col] == 0) return true;
            return false;
        }
        public void Task4(ref int[,] matrix)
        {
            // code here
            int cols = matrix.GetLength(1);
            for (int col = cols - 1; col >= 0; col--)
            {
                if (!CheckZerosInColumn(matrix, col))
                    RemoveCol(ref matrix, col);
            }
            // end
        }
        public delegate int Finder(int[,] matrix, out int row, out int col);
        public int FindMax(int[,] matrix, out int row, out int col)
        {
            row = 0;
            col = 0;
            int max = matrix[0, 0];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > max)
                    {
                        max = matrix[i, j];
                        row = i;
                        col = j;
                    }
                }
            }
            return max;
        }
        public int FindMin(int[,] matrix, out int row, out int col)
        {
            row = 0;
            col = 0;
            int min = matrix[0, 0];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] < min)
                    {
                        min = matrix[i, j];
                        row = i;
                        col = j;
                    }
                }
            }
            return min;
        }
        public void Task5(ref int[,] matrix, Finder find)
        {
            // code here
            int value = find(matrix, out int targetRow, out int targetCol);

            for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
            {
                bool containsValue = false;
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == value)
                    {
                        containsValue = true;
                        break;
                    }
                }
                if (containsValue) RemoveRow(ref matrix, row);
            }
            // end
        }
        public delegate void SortRowsStyle(int[,] matrix, int row);
        public void SortRowAscending(int[,] matrix, int row)
        {
            int cols = matrix.GetLength(1);
            for (int i = 0; i < cols - 1; i++)
            {
                for (int j = 0; j < cols - i - 1; j++)
                {
                    if (matrix[row, j] > matrix[row, j + 1])
                    {
                        int temp = matrix[row, j];
                        matrix[row, j] = matrix[row, j + 1];
                        matrix[row, j + 1] = temp;
                    }
                }
            }
        }
        public void SortRowDescending(int[,] matrix, int row)
        {
            int cols = matrix.GetLength(1);
            for (int i = 0; i < cols - 1; i++)
            {
                for (int j = 0; j < cols - i - 1; j++)
                {
                    if (matrix[row, j] < matrix[row, j + 1])
                    {
                        int temp = matrix[row, j];
                        matrix[row, j] = matrix[row, j + 1];
                        matrix[row, j + 1] = temp;
                    }
                }
            }
        }
        public void Task6(int[,] matrix, SortRowsStyle sort)
        {
            // code here
            for (int row = 2; row < matrix.GetLength(0); row += 3)
                sort(matrix, row);
            // end
        }
        public delegate void ReplaceMaxElements(int[,] matrix, int row, int maxValue);

        public int FindMaxInRow(int[,] matrix, int row)
        {
            int max = matrix[row, 0];
            for (int col = 1; col < matrix.GetLength(1); col++)
                if (matrix[row, col] > max) max = matrix[row, col];
            return max;
        }
        public void ReplaceByZero(int[,] matrix, int row, int maxValue)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
                if (matrix[row, col] == maxValue) matrix[row, col] = 0;
        }
        public void MultiplyByColumn(int[,] matrix, int row, int maxValue)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
                if (matrix[row, col] == maxValue) matrix[row, col] *= col;
        }
        public void Task7(int[,] matrix, ReplaceMaxElements transform)
        {
            // code here
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int max = FindMaxInRow(matrix, row);
                transform(matrix, row, max);
            }
            // end
        }
        public double SumA(double x)
        {
            double sum = 1.0;
            double term;
            int i = 1;
            do
            {
                term = Math.Cos(i * x) / (i * Math.PI);
                sum += term;
                i++;
            } while (Math.Abs(term) > 1e-10 && i <= 1000);

            return sum;
        }
        public double YA(double x)
        {
            return Math.Exp(Math.Cos(x)) * Math.Cos(Math.Sin(x));
        }
        public double SumB(double x)
        {
            double sum = 0.0;
            double term;
            int i = 1;
            do
            {
                term = Math.Pow(-1, i) * Math.Cos(i * x) / (i * i);
                sum += term;
                i++;
            } while (Math.Abs(term) > 1e-10 && i <= 1000);

            return sum;
        }
        public double YB(double x)
        {
            return (x * x) / 4.0 - (Math.PI * Math.PI) / 12.0;
        }
        public double[,] GetSumAndY(double a, double b, double h, Func<double, double> sumFunc, Func<double, double> yFunc)
        {
            int count = (int)Math.Ceiling((b - a) / h) + 1;
            double[,] result = new double[2, count];
            int index = 0;
            for (double x = a; x <= b + 1e-10; x += h, index++)
            {
                result[0, index] = sumFunc(x);
                result[1, index] = yFunc(x);
            }
            return result;
        }
        public double[,] Task8(double a, double b, double h, Func<double, double> getSum, Func<double, double> getY)
        {
            double[,] answer = null;
            // code here
            answer = GetSumAndY(a, b, h, getSum, getY);
            // end
            return answer;
        }
        public delegate int[] GetTriangle(int[,] matrix);

        public int Sum(int[] array)
        {
            int sum = 0;
            foreach (int val in array) sum += val * val;
            return sum;
        }
        public int[] GetUpperTriangle(int[,] matrix)
        {
            if (matrix.GetLength(0) != matrix.GetLength(1) || matrix.GetLength(0) == 0)
                return new int[0];

            int n = matrix.GetLength(0);
            int totalElements = n * (n + 1) / 2;
            int[] result = new int[totalElements];
            int index = 0;
            for (int i = 0; i < n; i++)
                for (int j = i; j < n; j++)
                    result[index++] = matrix[i, j];

            return result;
        }
        public int[] GetLowerTriangle(int[,] matrix)
        {
            if (matrix.GetLength(0) != matrix.GetLength(1) || matrix.GetLength(0) == 0)
                return new int[0];

            int n = matrix.GetLength(0);
            int totalElements = n * (n + 1) / 2;
            int[] result = new int[totalElements];
            int index = 0;

            for (int i = 0; i < n; i++)
                for (int j = 0; j <= i; j++)
                    result[index++] = matrix[i, j];

            return result;
        }

        public int GetSum(GetTriangle transformer, int[,] matrix)
        {
            int[] triangle = transformer(matrix);
            return Sum(triangle);
        }

        public int Task9(int[,] matrix, GetTriangle triangle)
        {
            int answer = 0;
            // code here
            answer = GetSum(triangle, matrix);
            // end
            return answer;
        }
        public bool CheckTransformAbility(int[][] array)
        {
            if (array == null || array.Length == 0) return false;

            int rows = array.Length;
            int minCols = int.MaxValue;
            int maxCols = 0;
            int totalElements = 0;

            foreach (var row in array)
            {
                if (row == null) return false;
                int cols = row.Length;
                totalElements += cols;
                if (cols < minCols) minCols = cols;
                if (cols > maxCols) maxCols = cols;
            }

            return totalElements >= rows * minCols && maxCols >= rows;
        }
        public bool CheckSumOrder(int[][] array)
        {
            if (array == null || array.Length <= 1) return false;

            int[] sums = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                int sum = 0;
                foreach (int val in array[i]) sum += val;
                sums[i] = sum;
            }
            bool ascending = true;
            bool descending = true;
            for (int i = 1; i < sums.Length; i++)
            {
                if (sums[i] <= sums[i - 1]) ascending = false;
                if (sums[i] >= sums[i - 1]) descending = false;
            }
            return ascending || descending;
        }
        public bool CheckArraysOrder(int[][] array)
        {
            if (array == null) return false;

            foreach (var row in array)
            {
                if (row == null || row.Length <= 1) continue;
                bool ascending = true;
                bool descending = true;
                for (int i = 1; i < row.Length; i++)
                {
                    if (row[i] <= row[i - 1]) ascending = false;
                    if (row[i] >= row[i - 1]) descending = false;
                }

                if (ascending || descending) return true;
            }
            return false;
        }
        public bool Task10(int[][] array, Predicate<int[][]> func)
        {
            bool res = false;
            // code here
            res = func(array);
            // end
            return res;
        }
    }
}
