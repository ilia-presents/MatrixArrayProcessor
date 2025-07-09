// See https://aka.ms/new-console-template for more information

using MatrixArrayProcessor.LogicClasses;
using System.Text;

int RANDOM_NUMBER_UPPER_EXCLUSIVE_LIMIT = 13;

RandomNumberCreator RandomNumberCreator = new RandomNumberCreator(RANDOM_NUMBER_UPPER_EXCLUSIVE_LIMIT);

MatrixCreator matrixCreator = new MatrixCreator(RandomNumberCreator);

int i; int j; string str = "";

StringBuilder StringBuild = new StringBuilder();

int ArrayDimension = 8;

int[,] someNumbers = matrixCreator.Create(ArrayDimension);

for (i = 0; i < ArrayDimension; i++)
{

    StringBuild.Clear();

    for (j = 0; j < ArrayDimension; j++)
    {

        StringBuild.Append(someNumbers[i, j].ToString());

        if (someNumbers[i, j] < 10)
        {

            StringBuild.Append("  ");
        }
        else {

            StringBuild.Append(" ");       
        }
    }

    Console.WriteLine(StringBuild.ToString());
}

//someNumbers[0, 1] = 34;

//int tempArrayDimesnion = ArrayDimension - 1;

//Console.WriteLine(someNumbers[0, 1] + " " + someNumbers[0, 0] + " " + someNumbers[0, tempArrayDimesnion]);


//int[,] someNumbers;

//someNumbers = new int[10, 10];

//someNumbers[0, 2] = 34;

//int i = 7;

//someNumbers[0, i] = 44;

//Console.WriteLine(someNumbers[0, 2] + " " + someNumbers[0, i]);