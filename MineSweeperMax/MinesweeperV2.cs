using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MineSweeperMax
{
    public partial class MineSweeperV2 : Form
    {
        public static int x, y, numberOFBoms, numberOfFields;
        public static bool Flag = false;
        public static string[,] field;

        public MineSweeperV2(int xn, int yn)
        {

            x = xn;
            y = yn;
            InitializeComponent();
            this.LoadGame_Click(null, null);

        }
        public void LoadGame_Click(object sender, EventArgs e)
        {
            //FieldV2 newField = new FieldV2();
            //newField.FieldCreator();
            this.tileGrid.LoadGrid(new Size(x, y));
            // size of the form
            this.MaximumSize = this.MinimumSize = new Size(this.tileGrid.Width + 36, this.tileGrid.Height + 110);
            FieldCreator();


        }

        private void btnFlagV2_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (Flag)
            {
                b.BackColor = default(Color);
                Flag = false;
            }

            else
            {
                b.BackColor = Color.Aqua;
                Flag = true;
            }
        }
        void FieldCreator()
        {
            field = new string[x, y];
            numberOfFields = x * y;

            // Setting the number of bombs in the field 20%
            numberOFBoms = x * y / 5;
            if (x * y % 5 != 0)
            {
                numberOFBoms++;
            }

            int[] placeOfBomb = new int[numberOFBoms];

            for (int i = 0; i < x; i++) // the whole field turns to zero's
            {
                for (int j = 0; j < y; j++)
                {
                    field[i, j] = "0";
                }
            }

            Random rnd = new Random();// choses places for the bombs
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

            foreach (int i in placeOfBomb) // places the bombs in the field
            {
                field[i / y, i % y] = "*";
            }
            BombChecking(field);
        }
        private static void BombChecking(string[,] field)// Adding Numbers arround the bombs.
        {
            for (int i = 0; i < x; i++)
            {
                for (int k = 0; k < y; k++) // this goes through the whole grid
                {
                    if (field[i, k] == "*") // if it finds a bomb it will add +1 to all surrounding tiles
                    {
                        if (i == 0)// top row
                        {
                            if (k == 0)// top left
                            {
                                if (field[i, k + 1] != "*")
                                    field[i, k + 1] = (int.Parse(field[i, k + 1]) + 1).ToString(); // spot 6
                                if (field[i + 1, k] != "*")
                                    field[i + 1, k] = (int.Parse(field[i + 1, k]) + 1).ToString();// spot 2
                                if (field[i + 1, k + 1] != "*")
                                    field[i + 1, k + 1] = (int.Parse(field[i + 1, k + 1]) + 1).ToString();// spot 3
                            }
                            else if (k == y - 1)//top right
                            {

                                if (field[i, k - 1] != "*")
                                    field[i, k - 1] = (int.Parse(field[i, k - 1]) + 1).ToString(); // spot 4
                                if (field[i + 1, k - 1] != "*")
                                    field[i + 1, k - 1] = (int.Parse(field[i + 1, k - 1]) + 1).ToString(); // spot 1
                                if (field[i + 1, k] != "*")
                                    field[i + 1, k] = (int.Parse(field[i + 1, k]) + 1).ToString();// spot 2
                            }
                            else// middle of the top row
                            {
                                if (field[i, k - 1] != "*")
                                    field[i, k - 1] = (int.Parse(field[i, k - 1]) + 1).ToString(); // spot 4
                                if (field[i, k + 1] != "*")
                                    field[i, k + 1] = (int.Parse(field[i, k + 1]) + 1).ToString(); // spot 6
                                if (field[i + 1, k - 1] != "*")
                                    field[i + 1, k - 1] = (int.Parse(field[i + 1, k - 1]) + 1).ToString(); // spot 1
                                if (field[i + 1, k] != "*")
                                    field[i + 1, k] = (int.Parse(field[i + 1, k]) + 1).ToString();// spot 2
                                if (field[i + 1, k + 1] != "*")
                                    field[i + 1, k + 1] = (int.Parse(field[i + 1, k + 1]) + 1).ToString();// spot 3
                            }
                        }
                        else if (i == x - 1)// bottom row
                        {
                            if (k == 0)// bottom left 
                            {
                                if (field[i - 1, k] != "*")
                                    field[i - 1, k] = (int.Parse(field[i - 1, k]) + 1).ToString(); // spot 8
                                if (field[i - 1, k + 1] != "*")
                                    field[i - 1, k + 1] = (int.Parse(field[i - 1, k + 1]) + 1).ToString(); // spot 9
                                if (field[i, k + 1] != "*")
                                    field[i, k + 1] = (int.Parse(field[i, k + 1]) + 1).ToString(); // spot 6
                            }
                            else if (k == y - 1)// bottom right
                            {
                                if (field[i - 1, k - 1] != "*")
                                    field[i - 1, k - 1] = (int.Parse(field[i - 1, k - 1]) + 1).ToString();// spot 7
                                if (field[i - 1, k] != "*")
                                    field[i - 1, k] = (int.Parse(field[i - 1, k]) + 1).ToString(); // spot 8
                                if (field[i, k - 1] != "*")
                                    field[i, k - 1] = (int.Parse(field[i, k - 1]) + 1).ToString(); // spot 4
                            }
                            else// bottom middle
                            {
                                if (field[i - 1, k - 1] != "*")
                                    field[i - 1, k - 1] = (int.Parse(field[i - 1, k - 1]) + 1).ToString();// spot 7
                                if (field[i - 1, k] != "*")
                                    field[i - 1, k] = (int.Parse(field[i - 1, k]) + 1).ToString(); // spot 8
                                if (field[i - 1, k + 1] != "*")
                                    field[i - 1, k + 1] = (int.Parse(field[i - 1, k + 1]) + 1).ToString(); // spot 9
                                if (field[i, k - 1] != "*")
                                    field[i, k - 1] = (int.Parse(field[i, k - 1]) + 1).ToString(); // spot 4
                                if (field[i, k + 1] != "*")
                                    field[i, k + 1] = (int.Parse(field[i, k + 1]) + 1).ToString(); // spot 6
                            }
                        }
                        else if (k == 0) // left middle
                        {
                            if (field[i - 1, k] != "*")
                                field[i - 1, k] = (int.Parse(field[i - 1, k]) + 1).ToString(); // spot 8
                            if (field[i - 1, k + 1] != "*")
                                field[i - 1, k + 1] = (int.Parse(field[i - 1, k + 1]) + 1).ToString(); // spot 9
                            if (field[i, k + 1] != "*")
                                field[i, k + 1] = (int.Parse(field[i, k + 1]) + 1).ToString(); // spot 6
                            if (field[i + 1, k] != "*")
                                field[i + 1, k] = (int.Parse(field[i + 1, k]) + 1).ToString();// spot 2
                            if (field[i + 1, k + 1] != "*")
                                field[i + 1, k + 1] = (int.Parse(field[i + 1, k + 1]) + 1).ToString();// spot 3
                        }
                        else if (k == y - 1) // right middle
                        {
                            if (field[i - 1, k - 1] != "*")
                                field[i - 1, k - 1] = (int.Parse(field[i - 1, k - 1]) + 1).ToString();// spot 7
                            if (field[i - 1, k] != "*")
                                field[i - 1, k] = (int.Parse(field[i - 1, k]) + 1).ToString(); // spot 8
                            if (field[i, k - 1] != "*")
                                field[i, k - 1] = (int.Parse(field[i, k - 1]) + 1).ToString(); // spot 4
                            if (field[i + 1, k - 1] != "*")
                                field[i + 1, k - 1] = (int.Parse(field[i + 1, k - 1]) + 1).ToString(); // spot 1
                            if (field[i + 1, k] != "*")
                                field[i + 1, k] = (int.Parse(field[i + 1, k]) + 1).ToString();// spot 2
                        }
                        else // middle of the field
                        {
                            if (field[i - 1, k - 1] != "*")
                                field[i - 1, k - 1] = (int.Parse(field[i - 1, k - 1]) + 1).ToString();// spot 7
                            if (field[i - 1, k] != "*")
                                field[i - 1, k] = (int.Parse(field[i - 1, k]) + 1).ToString(); // spot 8
                            if (field[i - 1, k + 1] != "*")
                                field[i - 1, k + 1] = (int.Parse(field[i - 1, k + 1]) + 1).ToString(); // spot 9
                            if (field[i, k - 1] != "*")
                                field[i, k - 1] = (int.Parse(field[i, k - 1]) + 1).ToString(); // spot 4
                            if (field[i, k + 1] != "*")
                                field[i, k + 1] = (int.Parse(field[i, k + 1]) + 1).ToString(); // spot 6
                            if (field[i + 1, k - 1] != "*")
                                field[i + 1, k - 1] = (int.Parse(field[i + 1, k - 1]) + 1).ToString(); // spot 1
                            if (field[i + 1, k] != "*")
                                field[i + 1, k] = (int.Parse(field[i + 1, k]) + 1).ToString();// spot 2
                            if (field[i + 1, k + 1] != "*")
                                field[i + 1, k + 1] = (int.Parse(field[i + 1, k + 1]) + 1).ToString();// spot 3
                        }
                    }
                }
            }
        }
        private class TileGrid : Panel
        {
            private Size gridSize;
            private int numberOfFieldsOpen = 0;

            private void Tile_MouseDown(object sender, MouseEventArgs e)
            {
                Tile tile = (Tile)sender;

                string[] splitUpTileName = tile.Name.Split('_'); // Tilename = Tile_**_**.... ** = number == X & Y

                int tileX = int.Parse(splitUpTileName[1]);
                int tileY = int.Parse(splitUpTileName[2]);
                if (MineSweeperV2.Flag && tile.Text == "")
                {
                    tile.Text = "F";
                    tile.ForeColor = Color.Red;
                }
                else if (MineSweeperV2.Flag && tile.Text == "F")
                {
                    tile.Text = "";
                    tile.ForeColor = default(Color);
                }
                else
                {
                    if (tile.Text != "")
                    {

                    }
                    else
                    {
                        tile.Text = MineSweeperV2.field[tileX, tileY];
                        numberOfFieldsOpen++;
                    }

                }
                if (GameOverCheck(tile.Text))
                {
                    GameOverScreen();
                }
                else if (numberOfFieldsOpen == (MineSweeperV2.numberOfFields - MineSweeperV2.numberOFBoms))
                    WinningScreen();


            }
            private bool GameOverCheck(string fieldResult)
            {
                if (fieldResult == "*")
                    return true;
                else
                    return false;
            }
            private void GameOverScreen()
            {
                DialogResult result;
                result = MessageBox.Show("You Lose!\nNew game ?", "Game Over!", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    Form1.newForm.LoadGame_Click(null, null);
                }
                else
                    Form1.newForm.Close();
            }
            private void WinningScreen()
            {
                DialogResult result;
                result = MessageBox.Show("You Win, congratulations!\nNew game ?", "Game won!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Form1.newForm.LoadGame_Click(null, null);
                }
                else
                {
                    //Application.Exit();
                    Form1.newForm.Close();
                }

            }
            internal void LoadGrid(Size gridSize)
            {
                numberOfFieldsOpen = 0;
                this.Controls.Clear();
                this.gridSize = gridSize;
                this.Size = new Size(gridSize.Width * Tile.LENGTH, gridSize.Height * Tile.LENGTH);
                for (int x = 0; x < gridSize.Width; x++)
                {
                    for (int y = 0; y < gridSize.Height; y++)
                    {
                        Tile tile = new Tile(x, y);
                        tile.MouseDown += Tile_MouseDown;
                        this.Controls.Add(tile);
                    }
                }
            }
            private class Tile : Button
            {
                internal const int LENGTH = 25;

                internal Tile(int x, int y)
                {
                    this.Name = $"Tile_{x}_{y}";
                    this.Size = new Size(LENGTH, LENGTH);
                    this.Location = new Point(x * LENGTH, y * LENGTH);
                    this.TabIndex = 10 + x * LENGTH + y;
                }
            }
        }
    }
}

