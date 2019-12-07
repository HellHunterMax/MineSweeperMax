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
        Field firstField = new Field();
        bool flag = false;
        //TODO check for all fields opened.
        bool allFieldsOpen = false;
        public Form1()
        {
            InitializeComponent();
            
        }
        private void FieldButton_Click(object sender, EventArgs e)
        {

            //TODO EXTRA how to change the button. make the program more pretty.
            Button b = (Button) sender;
            int number = int.Parse(b.Name.Remove(0, 6));
            if (flag && b.Text == "")
            {
                b.Text = "F";
            }
            else if (flag && b.Text == "F")
            {
                b.Text = "";
            }
            else
            {
                if (b.Text != "")
                {

                }
                else
                {
                    b.Text = Field.field[number - 1];
                }
                
            }
            if (GameOverCheck(b.Text))
            {
                GameOverScreen();
            }
            else if (allFieldsOpen)
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
                NewGame();
            }
            else
                this.Close();


        }
        private void WinningScreen()
        {
            DialogResult result;
            result = MessageBox.Show("You Win, congratulations!\nNew game ?", "Game won!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                NewGame();
            }
            else
                this.Close();
        }

        private void btnFlag_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (flag)
            {
                b.BackColor = default(Color);
                flag = false;
            }
                
            else
            {
                b.BackColor = Color.Aqua;
                flag = true;
            }
                
        }
        private void NewGame()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            button10.Text = "";
            button11.Text = "";
            button12.Text = "";
            button13.Text = "";
            button14.Text = "";
            button15.Text = "";
            button16.Text = "";
            button17.Text = "";
            button18.Text = "";
            button19.Text = "";
            button20.Text = "";
            button21.Text = "";
            button22.Text = "";
            button23.Text = "";
            button24.Text = "";
            button25.Text = "";
            button26.Text = "";
            button27.Text = "";
            button28.Text = "";
            button29.Text = "";
            button30.Text = "";
            button31.Text = "";
            button32.Text = "";
            button33.Text = "";
            button34.Text = "";
            button35.Text = "";
            button36.Text = "";
            button37.Text = "";
            button38.Text = "";
            button39.Text = "";
            button40.Text = "";
            button41.Text = "";
            button42.Text = "";
            button43.Text = "";
            button44.Text = "";
            button45.Text = "";
            button46.Text = "";
            button47.Text = "";
            button48.Text = "";
            button49.Text = "";
            button50.Text = "";
            button51.Text = "";
            button52.Text = "";
            button53.Text = "";
            button54.Text = "";
            button55.Text = "";
            button56.Text = "";
            button57.Text = "";
            button58.Text = "";
            button59.Text = "";
            button60.Text = "";
            button61.Text = "";
            button62.Text = "";
            button63.Text = "";
            button64.Text = "";
            firstField.FieldCreator();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            NewGame();
        }
    }
}
