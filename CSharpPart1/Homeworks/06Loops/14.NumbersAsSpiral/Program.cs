using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Program
    {
        static void Main()
        {
            int[,] matrix = new int[20, 20];
            byte positionX = 0;
            byte positionY = 0;
            byte positionCheckX = 0;
            byte positionCheckY = 0;
            int number = 0;

            //matrix[0, 2] = 5;
            //Console.WriteLine(matrix[0,2]);

            //Console.WriteLine(matrix.GetLength(0));
            while (number <= 400)
            {
                
          
            while ((positionX <= matrix.GetLength(1)) && (matrix[positionCheckY, positionCheckX] == 0))
            {

                number++;
                matrix[positionY, positionX] = number;
                if (positionX < (matrix.GetLength(1) - 1))
                {
                    positionX++;   
                }

                if ((positionX < (matrix.GetLength(1) - 1)) && (matrix[positionCheckY, positionCheckX + 1] == 0))
                {
                    positionCheckX = (byte)(positionX + 1); 
                }
                else
                {
                    number++;
                    matrix[positionY, positionX] = number;
                    break;
                }
            }
            if (matrix[positionY + 1, positionX] == 0)
            {
                positionY = (byte)(positionY + 1);
                positionCheckY = (byte)(positionCheckY + 1);
            }
            else
            {
                break;
            }
            

            while ((positionY <= matrix.GetLength(0)) && (matrix[positionCheckY, positionCheckX] == 0))
            {

                number++;
                matrix[positionY, positionX] = number;
                
                if (positionY < (matrix.GetLength(0) - 1))
                {
                    positionY++;
                }
                if ((positionY < (matrix.GetLength(0) - 1)) && (matrix[positionCheckY + 1, positionCheckX] == 0))
                {
                    positionCheckY = (byte)(positionY + 1);
                }
                else
                {
                    number++;
                    matrix[positionY, positionX] = number;
                    break;
                }
            }
            if (matrix[positionY, positionX - 1] == 0)
            {
                positionX = (byte)(positionX - 1);
                positionCheckX = (byte)(positionCheckX - 1); 
            }
            else
            {
                break;
            }

            while ((positionX >= 0) && (matrix[positionCheckY, positionCheckX] == 0))
            {

                number++;
                matrix[positionY, positionX] = number;
                if (positionX > 0)
                {
                    positionX--;
                }

                if ((positionX > 0) && (matrix[positionCheckY, positionCheckX - 1] == 0))
                {
                    positionCheckX = (byte)(positionX - 1);
                }
                else
                {
                    number++;
                    matrix[positionY, positionX] = number;
                    break;
                }
            }

            if (matrix[positionY - 1, positionX] == 0)
            {
                positionY = (byte)(positionY - 1);
                positionCheckY = (byte)(positionCheckY - 2);  
            }
            else
            {
                break;
            }
           

            while ((positionY >= 0) && (matrix[positionCheckY, positionCheckX] == 0))
            {

                number++;
                matrix[positionY, positionX] = number;

                if (positionY > 0 )
                {
                    positionY--;
                }
                if ((positionY > 0) && (matrix[positionCheckY - 1, positionCheckX] == 0))
                {

                    positionCheckY = (byte)(positionY - 1); 
                }
                else
                {
                    number++;
                    matrix[positionY, positionX] = number;
                    break;
                }
            }
            if (matrix[positionY, positionX + 1] == 0)
            {
                positionX = (byte)(positionX + 1);
                positionCheckX = (byte)(positionCheckX + 1); 
            }
            
            }


            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    Console.Write("{0, 3} ", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
