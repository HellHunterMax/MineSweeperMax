using System;
using System.Collections.Generic;
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
            this.tileGrid.LoadGrid(new Size(x, y));
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

            // Setting the number of bombs in the field 14,3%
            numberOFBoms = x * y / 7;
            if (x * y % 7 != 0)
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
                int n = rnd.Next(0, numberOfFields);
                while (placeOfBomb.Contains<int>(n))
                    n = rnd.Next(0, numberOfFields);
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

            private static readonly HashSet<Tile> gridSearchBlackList = new HashSet<Tile>();
            private Size gridSize;
            private static int numberOfFieldsOpen = 0;

            private Tile this[Point point] =>(Tile)this.Controls[$"Tile_{point.X}_{point.Y}"];

            private void Tile_MouseDown(object sender, MouseEventArgs e)
            {
                Tile tile = (Tile)sender;

                string[] splitUpTileName = tile.Name.Split('_'); // TileName = Tile_**_**.... ** = number == X & Y

                int tileX = int.Parse(splitUpTileName[1]);
                int tileY = int.Parse(splitUpTileName[2]);
                if ((MineSweeperV2.Flag || e.Button == MouseButtons.Right) && tile.Text == "")
                {
                    tile.Text = "F";
                    tile.ForeColor = Color.Red;
                }
                else if ((MineSweeperV2.Flag || e.Button == MouseButtons.Right) && tile.Text == "F")
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
                else if (tile.Text == "0")
                {
                    tile.TestAdjacentTiles();
                    gridSearchBlackList.Clear();

                    if (numberOfFieldsOpen == (MineSweeperV2.numberOfFields - MineSweeperV2.numberOFBoms))
                        WinningScreen();
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
                    MineSweeperSetup.newForm.LoadGame_Click(null, null);
                }
                else
                    MineSweeperSetup.newForm.Close();
            }
            private void WinningScreen()
            {
                DialogResult result;
                result = MessageBox.Show("You Win, congratulations!\nNew game ?", "Game won!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    MineSweeperSetup.newForm.LoadGame_Click(null, null);
                }
                else
                {
                    MineSweeperSetup.newForm.Close();
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
                foreach (Tile tile in this.Controls)
                {
                    tile.SetAdjacentTiles();
                }
            }
            private class Tile : Button
            {
                internal const int LENGTH = 25;
                private static readonly int[][] adjecentCoords =
                {
                    new[] {-1, -1}, new[] {0, -1}, new[] {1, -1}, new[] {1, 0}, new[] {1, 1}, new[] {0, 1}, new[] {-1, 1}, new[] {-1, 0}
                };

                internal Tile(int x, int y)
                {
                    this.Name = $"Tile_{x}_{y}";
                    this.Size = new Size(LENGTH, LENGTH);
                    this.Location = new Point(x * LENGTH, y * LENGTH);
                    this.TabIndex = 10 + x * LENGTH + y;
                    this.GridPosition = new Point(x, y);
                }
                internal Tile[] AdjecentTiles { get; private set; }
                internal Point GridPosition { get; }

                internal void SetAdjacentTiles()
                {
                    TileGrid tileGrid = (TileGrid)this.Parent;
                    List<Tile> adjecentTiles = new List<Tile>(8);
                    foreach (int[] adjecentCoord in adjecentCoords)
                    {
                        Tile tile = tileGrid[new Point(this.GridPosition.X + adjecentCoord[0], this.GridPosition.Y + adjecentCoord[1])];
                        if (tile != null)
                        {
                            adjecentTiles.Add(tile);
                        }
                    }
                    this.AdjecentTiles = adjecentTiles.ToArray();
                }
                
                internal void TestAdjacentTiles()
                {
                    
                    if (gridSearchBlackList.Contains(this))
                    {
                        return;
                    }
                    gridSearchBlackList.Add(this);
                    if (this.Text == "")
                    {
                        string[] splitUpTileName = this.Name.Split('_'); // Tilename = Tile_**_**.... ** = number == X & Y

                        int tileX = int.Parse(splitUpTileName[1]);
                        int tileY = int.Parse(splitUpTileName[2]);
                        this.Text = MineSweeperV2.field[tileX, tileY];
                        numberOfFieldsOpen++;
                    }
                    if (this.Text == "0")
                    {
                        foreach (Tile tile in this.AdjecentTiles)
                        {
                            tile.TestAdjacentTiles();
                        }
                    }


                }
            }
        }
    }
}

