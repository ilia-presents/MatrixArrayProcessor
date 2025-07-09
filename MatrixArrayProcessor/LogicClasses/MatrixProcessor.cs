using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixArrayProcessor.LogicClasses
{
    internal class MatrixProcessor
    {

        List<ResultDTO> ResultDTOs;

        int i; 
        int j; 
        int prevValue; 
        int numberOfRepetitions;
        int tmpRepetitionNumber;

        bool isSequence=false;

        public MatrixProcessor()
        {
            ResultDTOs= new List<ResultDTO>();  
        }

        public List<ResultDTO> Process(int[,] matrix, int arrayDimension, int repetitionsNumberRule)
        {
            ResultDTOs.Clear();

            ResultDTO resultDTO = new ResultDTO();

            // Checking row by row fisrt

            // In the very last moment I realized that I am not sure what matrix.Length
            // would bring so I use the value from the user input everywhere.
            // C# rearly use arrays. Mostly lists
            for (i = 0; i < arrayDimension; i++)
            {
                for (j = 0; j < arrayDimension; j++)
                {
                    if (j > 0)
                    {
                        prevValue = j - 1;

                        if (matrix[i, prevValue] == matrix[i, j])
                        {
                            numberOfRepetitions++;

                            if (numberOfRepetitions > repetitionsNumberRule)
                            {

                                isSequence = true;
                                tmpRepetitionNumber = matrix[i, j];

                            }
                        }
                        else if (matrix[i, prevValue] != matrix[i, j])
                        {
                            // Should I compare boolean to true or false ??
                            // If it was a sequence so it is time to insert it.
                            if (isSequence == true)
                            {
                                resultDTO.RepeatedNumber = tmpRepetitionNumber;

                                resultDTO.Repetitions = numberOfRepetitions;

                                resultDTO.DimensionName = "Row";

                                resultDTO.DimensionNumber = i;

                                ResultDTOs.Add(resultDTO);
                            }

                            isSequence = false;

                            numberOfRepetitions= 0; 

                        }
                    }
                }
            }

            // Checking column by column next

            // In the very last moment I realized that I am not sure what matrix.Length
            // would bring so I use the value from the user input everywhere.
            // C# rearly use arrays. Mostly lists
            for (j = 0; j < arrayDimension; j++)
            {
                for (i = 0; i < arrayDimension; i++)
                {
                    if (i > 0)
                    {
                        prevValue = i - 1;

                        if (matrix[prevValue, j] == matrix[i, j])
                        {
                            numberOfRepetitions++;

                            if (numberOfRepetitions > repetitionsNumberRule)
                            {
                                isSequence = true;
                                tmpRepetitionNumber = matrix[i, j];
                            }
                        }
                        else if (matrix[prevValue, j] != matrix[i, j])
                        {

                            // Should I compare boolean to true or false ??
                            // If it was a sequence so it is time to insert it.
                            if (isSequence == true)
                            {
                                resultDTO.RepeatedNumber = tmpRepetitionNumber;

                                resultDTO.Repetitions = numberOfRepetitions;

                                resultDTO.DimensionName = "Column";

                                resultDTO.DimensionNumber = j;

                                ResultDTOs.Add(resultDTO);
                            }

                            isSequence = false;

                            numberOfRepetitions = 0;

                        }
                    }
                }
            }


            return ResultDTOs;
        }
    }
}
