using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeperMax
{    
    public partial class Form1 : Form
    {
        //TODO: 1.create field behind screens
        //TODO: 2.create numbers and bombs
        //TODO: 3.attach field to cells
        //TODO: 4.flag command
        //TODO: 5. new game command
        public Form1()
        {
            InitializeComponent();
            int numberOFBoms = 10;
            int numberOfFields = 64;
            int[] placeOfBomb = new int[numberOFBoms];
            string[] field = new string[numberOfFields];
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

            //TODO add +1's around the bombs

            for (int i = 0; i< field; i++)
            {
                if (field[i] == "*")
                {
                    //TODO top
                    if (i < 8)
                    {

                    }
                    //TODO bottom
                    if (i >)
                    //TODO left
                    //TODO right
                    //TODO Center
                    field[i] = int.Parse()
                }
            }

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
        




    }
}
