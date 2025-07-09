// See https://aka.ms/new-console-template for more information

using MatrixArrayProcessor.LogicClasses;
using System.Text;

int RANDOM_NUMBER_UPPER_EXCLUSIVE_LIMIT = 13;

int REPETITIONS_NUMBER_RULE = 5;

RandomNumberCreator RandomNumberCreator = new RandomNumberCreator(RANDOM_NUMBER_UPPER_EXCLUSIVE_LIMIT);

MatrixCreator MatrixCreator = new MatrixCreator(RandomNumberCreator);

MatrixProcessor MatrixProcessor = new MatrixProcessor();

int i; int j;

bool isToStayInFirstDo=false;

string strConsoleRead;

StringBuilder StringBuild = new StringBuilder();

int arrayDimension = 8;

// The outer do-while loop is used to keep the game running until the user decides to quit.
do
{
    //The inner do -while loop is used to handle user input for the stake amount or initial amount.

    //It ensures that the user enters a valid amount before proceeding with the game or quitting.
    do
    {
        Console.WriteLine("Enter valid whole number between 6 and 25 or Q to quit");

        strConsoleRead = Console.ReadLine();

        if ((strConsoleRead == "Q") || (strConsoleRead == "q"))
        {
            Console.WriteLine("You have chosen to quit the game. Goodbye!");
            return;
        }

        if (int.TryParse(strConsoleRead, out int num))
        {
            isToStayInFirstDo = false;

            arrayDimension = num;
        }
        else {

            isToStayInFirstDo = true;
            Console.WriteLine("Invalid number");
            //throw new CustomException("Conversion from string to int failed.");
        }

        if (arrayDimension>25) {

            Console.WriteLine("Number exceeds 25");
            isToStayInFirstDo = true;
        }
    } while (isToStayInFirstDo);
    // ============

    int[,] theMatrix = MatrixCreator.Create(arrayDimension);

        List<ResultDTO> ResultDTOs = MatrixProcessor.Process(theMatrix, arrayDimension, REPETITIONS_NUMBER_RULE);

        if (ResultDTOs.Count > 0)
        {

            Console.WriteLine("There were " + ResultDTOs.Count + " sequences found");

            foreach (var resultDTO in ResultDTOs)
            {
                Console.WriteLine("Repeated number {0}. Repeated {1} times in {2} number {3}",
                    resultDTO.RepeatedNumber, resultDTO.Repetitions, resultDTO.DimensionName,
                    resultDTO.DimensionNumber);
            }
        }
        else
        {

            Console.WriteLine("There were no sequences found");
        }

        Console.WriteLine();

        for (i = 0; i < arrayDimension; i++)
        {

            StringBuild.Clear();

            for (j = 0; j < arrayDimension; j++)
            {

                StringBuild.Append(theMatrix[i, j].ToString());

                if (theMatrix[i, j] < 10)
                {

                    StringBuild.Append("  ");
                }
                else
                {

                    StringBuild.Append(" ");
                }
            }

            Console.WriteLine(StringBuild.ToString());
        }
        // ============

} while (true);