using System;
namespace BetterPath
{
    public class Bussiness
    {
        // Instacia de clase Cardinalidad
        public Cardinal Cardinality = new Cardinal();


        /**
         * Method Buscar ruta
         * Params Mountain[int]
         */
        public void FindPath(int [,] Mountain)
        {
            int StartPoint = 0;
            for(int i = 0; i < Mountain.GetLength(0); i++)
            {
                for( int j = 0; j < Mountain.GetLength(1); j++)
                {
                    FindStartPoint(Mountain[j, i], ref StartPoint);
                    GetPath(Mountain, j, i);
                }
            }
        }

        /**
         * Method FindStartPoint
         * Param: int value, ref int StartPoint
         * Description: Get the largest number
         */
        public void  FindStartPoint(int value, ref int StartPoint)
        {
            if(StartPoint < value)
            {
                StartPoint = value;
            }
        }

        /**
         * Method: GetPath
         * Params: int Mountain, int x , int y
         */

        public void GetPath(int[,] Mountain, int x , int y )
        {

            int XCount = 1;
            int YCount = 1;
            int XPosition, YPosition;
            int[] path = new int[0];


            bool West = Cardinality.GoToWest(Mountain, x, y);
            while (West)
            {
                West = Cardinality.GoToWest(Mountain, x - XCount, y);
                if (West)
                {
                    XPosition = x - XCount;
                    YPosition = y;
                    path.Append(Mountain[XPosition, YPosition]);
                    Console.WriteLine("------------");
                    Console.WriteLine("Posicion x: " + XPosition + " y: " + YPosition + " MountainWest: " + Mountain[XPosition, YPosition]);
                    Console.WriteLine("------------");
                }
                XCount++;
            }

            bool South = Cardinality.GoToSouth(Mountain, x, y);
            while (South)
            {
                South = Cardinality.GoToEast(Mountain, x, y + YCount);
                if (South)
                {
                    XPosition = x;
                    YPosition = y + YCount;
                    path.Append(Mountain[XPosition, YPosition]);
                    Console.WriteLine("------------");
                    Console.WriteLine("Posicion x: " + XPosition + " y: " + YPosition + " MountainSouth: " + Mountain[XPosition, YPosition]);
                    Console.WriteLine("------------");

                }
                YCount++;
            }

            bool East = Cardinality.GoToEast(Mountain, x, y);
            while (East)
            {
                East = Cardinality.GoToEast(Mountain, x + XCount, y);
                if (East)
                {
                    XPosition = x + XCount;
                    YPosition = y;
                    path.Append(Mountain[XPosition, YPosition]);
                    Console.WriteLine("------------");
                    Console.WriteLine("Posicion x: " + XPosition + " y: " + YPosition + " MountainEast: " + Mountain[XPosition, YPosition]);
                    Console.WriteLine("------------");
                }
                XCount++;
            }


        }

    }
}

