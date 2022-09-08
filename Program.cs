// Задача № 54


// int n = 4;
// int[,] RandomArray = new int[n, n];
// int[,] SortedArray = new int[n, n]; 


// Random ran = new Random();
// for (int i = 0; i < n; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         RandomArray[i, j] = ran.Next(-1, 5);
//         SortedArray[i, j] = RandomArray[i, j];
//         Console.Write("{0}\t", RandomArray[i, j]);
//     }
//     Console.WriteLine();
// }
// int[] temp = new int[n];

// Console.WriteLine("\nСортировка по строкам: ");
// for (int i = 0; i < n; i++)
// {
//     for (int j = 0; j < n; j++)
//         temp[j] = SortedArray[i, j];
//     Array.Sort(temp);
//     for (int k = 0; k < n; k++)
//     {
//         SortedArray[i, k] = temp[k];
//         Console.Write("{0}\t", SortedArray[i, k]);
//     }
//     Console.WriteLine();
// }



// Задача № 56
// Console.Write("Input size rows: ");
// int SizeRows = int.Parse(Console.ReadLine()!);
// Console.Write("Input size columns: ");
// int SizeColumns = int.Parse(Console.ReadLine()!);
// Console.Write("Input minimal value: ");
// int MinimalValue = int.Parse(Console.ReadLine()!);
// Console.Write("Input maximal value: ");
// int MaximalValue = int.Parse(Console.ReadLine()!);
// int[,] RectangularArray = new int[SizeRows, SizeColumns];
// Random ran = new Random();int LargestAmount = 0;
// for (int i = 0; i < RectangularArray.GetLength(0); i++)
// {
//     int Amount = 0;
//     for (int j = 0; j < RectangularArray.GetLength(1); j++)
//     {
//         RectangularArray[i, j] = ran.Next(MinimalValue, MaximalValue);
//         Amount += RectangularArray[i, j];
//         if (Amount > LargestAmount)
//             LargestAmount = Amount;


//         Console.Write("{0}\t", RectangularArray[i, j]);

//     }

//     Console.WriteLine("Sum in {0} row: {1}", i, Amount);
//     Console.Write(LargestAmount);
// }


// Задача № 58

// Console.WriteLine($"\ninput matriсes sizes and range from accidentals values:");
// int m = InputNumbers("enter the number of the first matrix: ");
// int n = InputNumbers(" input the number of columns of the 1st matrix (and rows of the 2nd): ");
// int p = InputNumbers("input the number of columns of the 1st matrix: ");
// int Range = InputNumbers("input the range accidentals numbers: from 1 to ");

// int[,] FirstMartrix = new int[m, n];
// CreateArray(FirstMartrix);
// Console.WriteLine($"\n1st matrix:");
// WriteArray(FirstMartrix);

// int[,] SecomdMartrix = new int[n, p];
// CreateArray(SecomdMartrix);
// Console.WriteLine($"\n2nd matrix:");
// WriteArray(SecomdMartrix);

// int[,] ResultMatrix = new int[m,p];

// MultiplyMatrix(FirstMartrix, SecomdMartrix, ResultMatrix);
// Console.WriteLine($"\nThe product of the first and second matrices:");
// WriteArray(ResultMatrix);

// void MultiplyMatrix(int[,] FirstMartrix, int[,] SecomdMartrix, int[,] ResultMatrix)
// {
//   for (int i = 0; i < ResultMatrix.GetLength(0); i++)
//   {
//     for (int j = 0; j < ResultMatrix.GetLength(1); j++)
//     {
//       int Amount = 0;
//       for (int k = 0; k < FirstMartrix.GetLength(1); k++)
//       {
//         Amount += FirstMartrix[i,k] * SecomdMartrix[k,j];
//       }
//       ResultMatrix[i,j] = Amount;
//     }
//   }
// }

// int InputNumbers(string Input)
// {
//   Console.Write(Input);
//   int Output = Convert.ToInt32(Console.ReadLine());
//   return Output;
// }

// void CreateArray(int[,] Array)
// {
//   for (int i = 0; i < Array.GetLength(0); i++)
//   {
//     for (int j = 0; j < Array.GetLength(1); j++)
//     {
//       Array[i, j] = new Random().Next(Range);
//     }
//   }
// }

// void WriteArray (int[,] Array)
// {
//   for (int i = 0; i < Array.GetLength(0); i++)
//   {
//     for (int j = 0; j < Array.GetLength(1); j++)
//     {
//       Console.Write(Array[i,j] + " ");
//     }
//     Console.WriteLine();
//   }
// }


// Задача № 60 

// Console.WriteLine($"\nenter array size  X x Y x Z:");
// int x = InputNumbers("enter X: ");
// int y = InputNumbers("enter Y: ");
// int z = InputNumbers("enter Z: ");
// Console.WriteLine($"");

// int[,,] Array3D = new int[x, y, z];
// CreateArray(Array3D);
// WriteArray(Array3D);

// int InputNumbers(string Input)
// {
//   Console.Write(Input);
//   int Output = Convert.ToInt32(Console.ReadLine());
//   return Output;
// }

// void WriteArray (int[,,] Array3D)
// {
//   for (int i = 0; i < Array3D.GetLength(0); i++)
//   {
//     for (int j = 0; j < Array3D.GetLength(1); j++)
//     {
//       Console.Write($"X({i}) Y({j}) ");
//       for (int k = 0; k < Array3D.GetLength(2); k++)
//       {
//         Console.Write( $"Z({k})={Array3D[i,j,k]}; ");
//       }
//       Console.WriteLine();
//     }
//     Console.WriteLine();
//   }
// }

// void CreateArray(int[,,] Array3D)
// {
//   int[] Temp = new int[Array3D.GetLength(0) * Array3D.GetLength(1) * Array3D.GetLength(2)];
//   int  Number;
//   for (int i = 0; i < Temp.GetLength(0); i++)
//   {
//     Temp[i] = new Random().Next(10, 100);
//     Number = Temp[i];
//     if (i >= 1)
//     {
//       for (int j = 0; j < i; j++)
//       {
//         while (Temp[i] == Temp[j])
//         {
//           Temp[i] = new Random().Next(10, 100);
//           j = 0;
//           Number = Temp[i];
//         }
//           Number = Temp[i];
//       }
//     }
//   }
//   int Count = 0; 
//   for (int x = 0; x < Array3D.GetLength(0); x++)
//   {
//     for (int y = 0; y < Array3D.GetLength(1); y++)
//     {
//       for (int z = 0; z < Array3D.GetLength(2); z++)
//       {
//         Array3D[x, y, z] = Temp[Count];
//         Count++;
//       }
//     }
//   }
// }


// Задача № 62


// int n = 4;
// int[,] SqareMatrix = new int[n, n];

// int Temp = 1;
// int i = 0;
// int j = 0;

// while (Temp <= SqareMatrix.GetLength(0) * SqareMatrix.GetLength(1))
// {
//     SqareMatrix[i, j] = Temp;
//     Temp++;
//     if (i <= j + 1 && i + j < SqareMatrix.GetLength(1) - 1)
//         j++;
//     else if (i < j && i + j >= SqareMatrix.GetLength(0) - 1)
//         i++;
//     else if (i >= j && i + j > SqareMatrix.GetLength(1) - 1)
//         j--;
//     else
//         i--;
// }

// WriteArray(SqareMatrix);

// void WriteArray(int[,] Array)
// {
//     for (int i = 0; i < Array.GetLength(0); i++)
//     {
//         for (int j = 0; j < Array.GetLength(1); j++)
//         {
//             if (Array[i, j] / 10 <= 0)
//                 Console.Write($" {Array[i, j]} ");

//             else Console.Write($"{Array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }