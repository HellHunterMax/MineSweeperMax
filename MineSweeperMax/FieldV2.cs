using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeperMax
{
    class FieldV2
    {
        public static int numberOFBoms = 125;
        public static int numberOfFields = 25;
        public static int x, y; 
        private static int[] placeOfBomb = new int[numberOFBoms];
        public static string[,] field;

        public FieldV2()
        {
            FieldCreator();

        }
        public void FieldCreator()
        {
            x = MineSweeperV2.x;
            y = MineSweeperV2.y;
            numberOfFields = x * y;
            numberOFBoms = x * y / 5;
            if (x * y % 5 != 0)
                numberOFBoms++;

            field = new string[x, y];
            for (int i = 0; i < x; i ++)
            {
                for (int j = 0; j < y; j++)
                {
                    field[i,j] = "0";
                }
            }
            /*
            for (int i = 0; i < numberOfFields; i++)
            {
                field[i] = "0";
            }*/
            Random rnd = new Random();
            for (int i = 0; i < numberOFBoms; i++)
            {
                placeOfBomb[i] = -1;
            }
            for (int i = 0; i < numberOFBoms; i++)
            {
                int n = rnd.Next(1, numberOfFields);
                while (placeOfBomb.Contains<int>(n))
                    n = rnd.Next(1, numberOfFields);
                placeOfBomb[i] = n;
            }

            foreach (int i in placeOfBomb)
            {
                //Console.WriteLine(i);
                field[i / y, i % y] = "*";
            }
            //TODO adding +1 to place arround the bomb without going out of bounds.
            BombChecking(field);

            /*int place = 0;
            for (int i = 0; i < 8; i++)
            {
                for (int k = 0; k < 8; k++)
                {
                    Console.Write(field[place]);
                    place++;
                }
                Console.WriteLine();
            }
            */
        }
        private static void BombChecking(string[,] field)
        {
            for (int i = 0; i < x; i++)
            {
                for (int k = 0; k < y; k++)
                {
                    if (field[i,k] == "*")
                    {
                        if (i == 0 )// top row
                        {
                            if (k == 0)// top left
                            {
                                if (field[i,k + 1] != "*")
                                    field[i,k + 1] = (int.Parse(field[i,k + 1]) + 1).ToString(); // spot 6
                                if (field[i + 1,k] != "*")
                                    field[i + 1,k] = (int.Parse(field[i + 1,k]) + 1).ToString();// spot 2
                                if (field[i + 1,k + 1] != "*")
                                    field[i + 1,k + 1] = (int.Parse(field[i + 1,k + 1]) + 1).ToString();// spot 3
                            }
                            else if (k == y - 1)//top right
                            {
                                
                                if (field[i,k - 1] != "*")
                                    field[i,k - 1] = (int.Parse(field[i,k - 1]) + 1).ToString(); // spot 4
                                if (field[i + 1,k - 1] != "*")
                                    field[i + 1,k - 1] = (int.Parse(field[i + 1,k - 1]) + 1).ToString(); // spot 1
                                if (field[i + 1,k] != "*")
                                    field[i + 1,k] = (int.Parse(field[i + 1,k]) + 1).ToString();// spot 2
                            }
                            else// middle of the top row
                            {
                                if (field[i,k - 1] != "*")
                                    field[i,k - 1] = (int.Parse(field[i,k - 1]) + 1).ToString(); // spot 4
                                if (field[i,k + 1] != "*")
                                    field[i,k + 1] = (int.Parse(field[i,k + 1]) + 1).ToString(); // spot 6
                                if (field[i + 1,k - 1] != "*")
                                    field[i + 1,k - 1] = (int.Parse(field[i + 1,k - 1]) + 1).ToString(); // spot 1
                                if (field[i + 1,k] != "*")
                                    field[i + 1,k] = (int.Parse(field[i + 1,k]) + 1).ToString();// spot 2
                                if (field[i + 1,k + 1] != "*")
                                    field[i + 1,k + 1] = (int.Parse(field[i + 1,k + 1]) + 1).ToString();// spot 3
                            }
                        }
                        else if (i == x - 1)// bottom row
                        {
                            if (k == 0)// bottom left 
                            {
                                if (field[i - 1,k] != "*")
                                    field[i - 1,k] = (int.Parse(field[i - 1,k]) + 1).ToString(); // spot 8
                                if (field[i - 1,k + 1] != "*")
                                    field[i - 1,k + 1] = (int.Parse(field[i - 1,k + 1]) + 1).ToString(); // spot 9
                                if (field[i,k + 1] != "*")
                                    field[i,k + 1] = (int.Parse(field[i,k + 1]) + 1).ToString(); // spot 6
                            }
                            else if (k == y -1)// bottom right
                            {
                                if (field[i - 1,k - 1] != "*")
                                    field[i - 1,k - 1] = (int.Parse(field[i - 1,k - 1]) + 1).ToString();// spot 7
                                if (field[i - 1,k] != "*")
                                    field[i - 1,k] = (int.Parse(field[i - 1,k]) + 1).ToString(); // spot 8
                                if (field[i,k - 1] != "*")
                                    field[i,k - 1] = (int.Parse(field[i,k - 1]) + 1).ToString(); // spot 4
                            }
                            else// bottom middle
                            {
                                if (field[i - 1,k - 1] != "*")
                                    field[i - 1,k - 1] = (int.Parse(field[i - 1,k - 1]) + 1).ToString();// spot 7
                                if (field[i - 1,k] != "*")
                                    field[i - 1,k] = (int.Parse(field[i - 1,k]) + 1).ToString(); // spot 8
                                if (field[i - 1,k + 1] != "*")
                                    field[i - 1,k + 1] = (int.Parse(field[i - 1,k + 1]) + 1).ToString(); // spot 9
                                if (field[i,k - 1] != "*")
                                    field[i,k - 1] = (int.Parse(field[i,k - 1]) + 1).ToString(); // spot 4
                                if (field[i,k + 1] != "*")
                                    field[i,k + 1] = (int.Parse(field[i,k + 1]) + 1).ToString(); // spot 6
                            }
                        }
                        else if (k == 0) // left middle
                        {
                            if (field[i - 1,k] != "*")
                                field[i - 1,k] = (int.Parse(field[i - 1,k]) + 1).ToString(); // spot 8
                            if (field[i - 1,k + 1] != "*")
                                field[i - 1,k + 1] = (int.Parse(field[i - 1,k + 1]) + 1).ToString(); // spot 9
                            if (field[i,k + 1] != "*")
                                field[i,k + 1] = (int.Parse(field[i,k + 1]) + 1).ToString(); // spot 6
                            if (field[i + 1,k] != "*")
                                field[i + 1,k] = (int.Parse(field[i + 1,k]) + 1).ToString();// spot 2
                            if (field[i + 1,k + 1] != "*")
                                field[i + 1,k + 1] = (int.Parse(field[i + 1,k + 1]) + 1).ToString();// spot 3
                        }
                        else if (k == y -1) // right middle
                        {
                            if (field[i - 1,k - 1] != "*")
                                field[i - 1,k - 1] = (int.Parse(field[i - 1,k - 1]) + 1).ToString();// spot 7
                            if (field[i - 1,k] != "*")
                                field[i - 1,k] = (int.Parse(field[i - 1,k]) + 1).ToString(); // spot 8
                            if (field[i,k - 1] != "*")
                                field[i,k - 1] = (int.Parse(field[i,k - 1]) + 1).ToString(); // spot 4
                            if (field[i + 1,k - 1] != "*")
                                field[i + 1,k - 1] = (int.Parse(field[i + 1,k - 1]) + 1).ToString(); // spot 1
                            if (field[i + 1,k] != "*")
                                field[i + 1,k] = (int.Parse(field[i + 1,k]) + 1).ToString();// spot 2
                        }
                        else // middle of the field
                        {
                            if (field[i - 1,k - 1] != "*")
                                field[i - 1,k - 1] = (int.Parse(field[i - 1,k - 1]) + 1).ToString();// spot 7
                            if (field[i - 1,k] != "*")
                                field[i - 1,k] = (int.Parse(field[i - 1,k]) + 1).ToString(); // spot 8
                            if (field[i - 1,k + 1] != "*")
                                field[i - 1,k + 1] = (int.Parse(field[i - 1,k + 1]) + 1).ToString(); // spot 9
                            if (field[i,k - 1] != "*")
                                field[i,k - 1] = (int.Parse(field[i,k - 1]) + 1).ToString(); // spot 4
                            if (field[i,k + 1] != "*")
                                field[i,k + 1] = (int.Parse(field[i,k + 1]) + 1).ToString(); // spot 6
                            if (field[i + 1,k - 1] != "*")
                                field[i + 1,k - 1] = (int.Parse(field[i + 1,k - 1]) + 1).ToString(); // spot 1
                            if (field[i + 1,k] != "*")
                                field[i + 1,k] = (int.Parse(field[i + 1,k]) + 1).ToString();// spot 2
                            if (field[i + 1,k + 1] != "*")
                                field[i + 1,k + 1] = (int.Parse(field[i + 1,k + 1]) + 1).ToString();// spot 3
                        }
                    }
                }
            }
        }
    }
}
