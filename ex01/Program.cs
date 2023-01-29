// See https://aka.ms/new-console-template for more information
string[,] table = new string[2,5];

table[1,2] = "слово";

for (int rows = 0; rows < 2; rows++)
{
    for (int columns = 0; columns <5; columns++)
    {
        Console.WriteLine($"-{table[rows, columns]}-");
    }
}

int[,] matrix = new int[3,4];
void PrintMatrix(int[,] arg)
{
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j = 0; j < arg.GetLength(1); j++)
        {
            Console.Write($" {arg[i, j]} ");
        }
        Console.WriteLine();
    }
}


void FillMatrix(int[,] arg)
{
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j = 0; j < arg.GetLength(1); j++)
        {
            arg[i,j] = new Random().Next(1,10);
        }
    }
}

FillMatrix(matrix);

PrintMatrix(matrix);
