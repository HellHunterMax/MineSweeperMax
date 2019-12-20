using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeperMax
{
    class Field
    {
        public static int numberOFBoms = 10;
        public static int numberOfFields = 64;
        private static int[] placeOfBomb = new int[numberOFBoms];
        public static string[] field = new string[numberOfFields];

        public Field()
        {
            FieldCreator();

        }
        public void FieldCreator()
        {
            for (int i = 0; i < numberOfFields; i++)
            {
                field[i] = "0";
            }
            Random rnd = new Random();
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
                field[i] = "*";
            }
            Bombchecking(field);

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

        private static void Bombchecking(string[] field)
        {
            for (int i = 0; i < field.Length; i++)
            {
                if (field[i] == "*")
                {
                    if (i < 8)
                    {
                        if (i == 0)
                        {
                            if (field[i + 1] != "*")
                                field[i + 1] = (int.Parse(field[i + 1]) + 1).ToString();
                            if (field[i + 8] != "*")
                                field[i + 8] = (int.Parse(field[i + 8]) + 1).ToString();
                            if (field[i + 9] != "*")
                                field[i + 9] = (int.Parse(field[i + 9]) + 1).ToString();
                        }
                        else if (i == 7)
                        {
                            if (field[i + 8] != "*")
                                field[i + 8] = (int.Parse(field[i + 8]) + 1).ToString();
                            if (field[i + 7] != "*")
                                field[i + 7] = (int.Parse(field[i + 7]) + 1).ToString();
                            if (field[i - 1] != "*")
                                field[i - 1] = (int.Parse(field[i - 1]) + 1).ToString();
                        }
                        else
                        {
                            if (field[i - 1] != "*")
                                field[i - 1] = (int.Parse(field[i - 1]) + 1).ToString();
                            if (field[i + 1] != "*")
                                field[i + 1] = (int.Parse(field[i + 1]) + 1).ToString();
                            if (field[i + 7] != "*")
                                field[i + 7] = (int.Parse(field[i + 7]) + 1).ToString();
                            if (field[i + 8] != "*")
                                field[i + 8] = (int.Parse(field[i + 8]) + 1).ToString();
                            if (field[i + 9] != "*")
                                field[i + 9] = (int.Parse(field[i + 9]) + 1).ToString();
                        }
                    }
                    else if (i > 55)
                    {
                        if (i == 56)
                        {
                            if (field[i - 8] != "*")
                                field[i - 8] = (int.Parse(field[i - 8]) + 1).ToString();
                            if (field[i - 7] != "*")
                                field[i - 7] = (int.Parse(field[i - 7]) + 1).ToString();
                            if (field[i + 1] != "*")
                                field[i + 1] = (int.Parse(field[i + 1]) + 1).ToString();
                        }
                        else if (i == 63)
                        {
                            if (field[i - 9] != "*")
                                field[i - 9] = (int.Parse(field[i - 9]) + 1).ToString();
                            if (field[i - 8] != "*")
                                field[i - 8] = (int.Parse(field[i - 8]) + 1).ToString();
                            if (field[i - 1] != "*")
                                field[i - 1] = (int.Parse(field[i - 1]) + 1).ToString();
                        }
                        else
                        {
                            if (field[i - 9] != "*")
                                field[i - 9] = (int.Parse(field[i - 9]) + 1).ToString();
                            if (field[i - 8] != "*")
                                field[i - 8] = (int.Parse(field[i - 8]) + 1).ToString();
                            if (field[i - 7] != "*")
                                field[i - 7] = (int.Parse(field[i - 7]) + 1).ToString();
                            if (field[i - 1] != "*")
                                field[i - 1] = (int.Parse(field[i - 1]) + 1).ToString();
                            if (field[i + 1] != "*")
                                field[i + 1] = (int.Parse(field[i + 1]) + 1).ToString();
                        }
                    }
                    else if (i == 8 || i == 16 || i == 24 || i == 32 || i == 40 || i == 48)
                    {
                        if (field[i - 8] != "*")
                            field[i - 8] = (int.Parse(field[i - 8]) + 1).ToString();
                        if (field[i - 7] != "*")
                            field[i - 7] = (int.Parse(field[i - 7]) + 1).ToString();
                        if (field[i + 1] != "*")
                            field[i + 1] = (int.Parse(field[i + 1]) + 1).ToString();
                        if (field[i + 8] != "*")
                            field[i + 8] = (int.Parse(field[i + 8]) + 1).ToString();
                        if (field[i + 9] != "*")
                            field[i + 9] = (int.Parse(field[i + 9]) + 1).ToString();
                    }
                    else if ((i == 15 || i == 23 || i == 31 || i == 39 || i == 47 || i == 55))
                    {
                        if (field[i - 9] != "*")
                            field[i - 9] = (int.Parse(field[i - 9]) + 1).ToString();
                        if (field[i - 8] != "*")
                            field[i - 8] = (int.Parse(field[i - 8]) + 1).ToString();
                        if (field[i - 1] != "*")
                            field[i - 1] = (int.Parse(field[i - 1]) + 1).ToString();
                        if (field[i + 7] != "*")
                            field[i + 7] = (int.Parse(field[i + 7]) + 1).ToString();
                        if (field[i + 8] != "*")
                            field[i + 8] = (int.Parse(field[i + 8]) + 1).ToString();
                    }
                    else
                    {
                        if (field[i - 9] != "*")
                            field[i - 9] = (int.Parse(field[i - 9]) + 1).ToString();
                        if (field[i - 8] != "*")
                            field[i - 8] = (int.Parse(field[i - 8]) + 1).ToString();
                        if (field[i - 7] != "*")
                            field[i - 7] = (int.Parse(field[i - 7]) + 1).ToString();
                        if (field[i - 1] != "*")
                            field[i - 1] = (int.Parse(field[i - 1]) + 1).ToString();
                        if (field[i + 1] != "*")
                            field[i + 1] = (int.Parse(field[i + 1]) + 1).ToString();
                        if (field[i + 7] != "*")
                            field[i + 7] = (int.Parse(field[i + 7]) + 1).ToString();
                        if (field[i + 8] != "*")
                            field[i + 8] = (int.Parse(field[i + 8]) + 1).ToString();
                        if (field[i + 9] != "*")
                            field[i + 9] = (int.Parse(field[i + 9]) + 1).ToString();
                    }
                }
            }
        }
    }
}
