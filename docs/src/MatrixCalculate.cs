using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudiesPractice.Core
{
    public class MatrixCalculate
    {
        public decimal CalculateDeterminant(decimal[,] matrix)
        {
            int n = matrix.GetLength(0);

            if (n == 1)
                return matrix[0, 0];

            if (n == 2)
                return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];

            decimal det = 0;

            for (int p = 0; p < n; p++)
            {
                decimal[,] subMatrix = new decimal[n - 1, n - 1];

                for (int i = 1; i < n; i++)
                {
                    int colIndex = 0;
                    for (int j = 0; j < n; j++)
                    {
                        if (j == p) continue;
                        subMatrix[i - 1, colIndex++] = matrix[i, j];
                    }
                }

                det += matrix[0, p] * CalculateDeterminant(subMatrix) * (p % 2 == 0 ? 1 : -1);
            }

            return det;
        }
    }
}
