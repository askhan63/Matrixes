class Program
{
   static int col1, col2, col3, col4;
   static int row1, row2, row3, row4;
   static int q1, q2, q3, q4;
    static void Main()
    {
        /*
        int[,] matrix =
        {
            { 112,42,83,119},
            { 56,125,56,49},
            { 15,78,101,43 },
            { 62,98,114,108 }
        };
        */

     int[,] matrix = new int[4, 4];
        Console.WriteLine("Enter Value is Matrix Integers Only:");
        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            for(int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.WriteLine("Enter at [" + i + "," + j + "]");
                matrix[i, j] =Convert.ToInt32(Console.ReadLine());
            }
        }
      


        SumAll(matrix);
        PrintMatrix(matrix);
        while (q1 < q2 || q1 < q3 || q1 < q4)
        {
          CheckCol(matrix);
            SumAll(matrix);
            PrintMatrix(matrix);

            CheckRow(matrix);
            SumAll(matrix);
            PrintMatrix(matrix);

        }

        Console.WriteLine("\n\n---------------\n\nAll the Quadrents sums are:\nQ1:"+q1+" Q2: "+q2+" Q3: "+q3+" Q4: "+q4);
        Console.WriteLine("\n---------------\n");
        PrintMatrix(matrix);



    }
    static void CheckRow(int[,] matrix)
    {
        //when 2nd quadrint has max sum
        if (q2 > q3 && q2 > q1 && q2 > q4)
            //check whather which col has max sum is that quadrent
            if (row1 > row2)
            {
                //changing row 1
                Console.WriteLine("Changing Row " + 1);
                ChangeRow(matrix, 0);
            }
            else
            {
                //changing row 2
                Console.WriteLine("Changing Row " + 1);
                ChangeRow(matrix, 1);

            }
        //when 3rd quadrint has max sum
        if (q3 > q2 && q3 > q1 && q3 > q4)
            //check whather which col has max sum is that quadrent
            if (row3 > row4)
            {
                //changing row3
                Console.WriteLine("Changing row " + 3);

                ChangeRow(matrix, 2);
            }
            else
            {
                //changing row4
                Console.WriteLine("Changing Row " + 4);
                ChangeRow(matrix, 3);

            }
        //when 4rd quadrint has max sum

        if (q4 > q2 && q4 > q1 && q4 > q3)
            //check whather which col has max sum is that quadrent
            if (row3 > row4)
            {
                //changing Row3
                Console.WriteLine("Changing Row " + 2);

                ChangeRow(matrix, 1);
            }
            else
            {
                //changing Row4
                Console.WriteLine("Changing Row " + 4);

                ChangeRow(matrix, 3);

            }
    }
        static void CheckCol(int[,] matrix)
    {
        //when 2nd quadrint has max sum
        if (q2 > q3 && q2 > q1 && q2 > q4)
            //check whather which col has max sum is that quadrent
            if (col3 > col4)
            {
                //changing col3
                Console.WriteLine("Changing Col " + 3);
                ChangeCol(matrix, 2);
            }
            else
            {
                //changing col4
                Console.WriteLine("Changing Col " + 4);
                ChangeCol(matrix, 3);

            }
        //when 3rd quadrint has max sum
        if (q3 > q2 && q3 > q1 && q3 > q4)
            //check whather which col has max sum is that quadrent
            if (col1 > col2)
            {
                //changing col1
                Console.WriteLine("Changing Col " + 1);

                ChangeCol(matrix, 0);
            }
            else
            {
                //changing col2
                Console.WriteLine("Changing Col " + 2);

                ChangeCol(matrix, 1);

            }
        //when 4rd quadrint has max sum

        if (q4 > q2 && q4 > q1 && q4 > q3)
            //check whather which col has max sum is that quadrent
            if (col3 > col4)
            {
                //changing col3
                Console.WriteLine("Changing Col " + 3);

                ChangeCol(matrix, 2);
            }
            else
            {
                //changing col4
                Console.WriteLine("Changing Col " + 4);

                ChangeCol(matrix, 3);

            }
    }
    static void ChangeCol(int[,] matrix, int col)
    {
        int temp = matrix[0, col];
        matrix[0, col] = matrix[3, col];
        matrix[3, col] = temp;
        int temp1 = matrix[1, col];
        matrix[1, col] = matrix[2, col];
        matrix[2, col] = temp1;
    }
    static void ChangeRow(int[,] matrix, int row)
    {
        int temp = matrix[row, 0];
        matrix[row, 0] = matrix[row, 3];
        matrix[row, 3] = temp;
        int temp1 = matrix[row, 1];
        matrix[row, 1] = matrix[row, 2];
        matrix[row, 2] = temp1;
    }
    static void PrintMatrix(int[,] matrix)
    {
        Console.WriteLine("\n The matrix is: \n");
        for (int row = 0; row < matrix.GetLength(0); row++)
        {

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write(matrix[row, col] + " ");
            }
            Console.WriteLine();

        }
    }
    static void SumAll(int[,] matrix)
    {
        col1 = col2 = col3 = col4 = 0;
        row1 = row2 = row3 = row4 = 0;
        q1 = q2 = q3 = q4 = 0;
        for (int row = 0; row < matrix.GetLength(0); row++)
        {

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (row == 0) row1 += matrix[row, col];
                if (row == 1) row2 += matrix[row, col];
                if (row == 2) row3 += matrix[row, col];
                if (row == 3) row4 += matrix[row, col];
                if (col == 0) col1 += matrix[row, col];
                if (col == 1) col2 += matrix[row, col];
                if (col == 2) col3 += matrix[row, col];
                if (col == 3) col4 += matrix[row, col];
                if (row < 2 && col < 2) q1 += matrix[row, col];
                if (row < 2 && col >= 2) q2 += matrix[row, col];
                if (row >= 2 && col < 2) q3 += matrix[row, col];
                if (row >= 2 && col >= 2) q4 += matrix[row, col];

            }

        }
    }
}