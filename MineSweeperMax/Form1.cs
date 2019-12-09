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
        int numberOfFieldsOpen = 0;
        Button[] fieldButtonArray = new Button[Field.numberOfFields];
        public Form1()
        {
            InitializeComponent();
            fieldButtonArray[0] = button1;
            fieldButtonArray[1] = button2;
            fieldButtonArray[2] = button3;
            fieldButtonArray[3] = button4;
            fieldButtonArray[4] = button5;
            fieldButtonArray[5] = button6;
            fieldButtonArray[6] = button7;
            fieldButtonArray[7] = button8;
            fieldButtonArray[8] = button9;
            fieldButtonArray[9] = button10;
            fieldButtonArray[10] = button11;
            fieldButtonArray[11] = button12;
            fieldButtonArray[12] = button13;
            fieldButtonArray[13] = button14;
            fieldButtonArray[14] = button15;
            fieldButtonArray[15] = button16;
            fieldButtonArray[16] = button17;
            fieldButtonArray[17] = button18;
            fieldButtonArray[18] = button19;
            fieldButtonArray[19] = button20;
            fieldButtonArray[20] = button21;
            fieldButtonArray[21] = button22;
            fieldButtonArray[22] = button23;
            fieldButtonArray[23] = button24;
            fieldButtonArray[24] = button25;
            fieldButtonArray[25] = button26;
            fieldButtonArray[26] = button27;
            fieldButtonArray[27] = button28;
            fieldButtonArray[28] = button29;
            fieldButtonArray[29] = button30;
            fieldButtonArray[30] = button31;
            fieldButtonArray[31] = button32;
            fieldButtonArray[32] = button33;
            fieldButtonArray[33] = button34;
            fieldButtonArray[34] = button35;
            fieldButtonArray[35] = button36;
            fieldButtonArray[36] = button37;
            fieldButtonArray[37] = button38;
            fieldButtonArray[38] = button39;
            fieldButtonArray[39] = button40;
            fieldButtonArray[40] = button41;
            fieldButtonArray[41] = button42;
            fieldButtonArray[42] = button43;
            fieldButtonArray[43] = button44;
            fieldButtonArray[44] = button45;
            fieldButtonArray[45] = button46;
            fieldButtonArray[46] = button47;
            fieldButtonArray[47] = button48;
            fieldButtonArray[48] = button49;
            fieldButtonArray[49] = button50;
            fieldButtonArray[50] = button51;
            fieldButtonArray[51] = button52;
            fieldButtonArray[52] = button53;
            fieldButtonArray[53] = button54;
            fieldButtonArray[54] = button55;
            fieldButtonArray[55] = button56;
            fieldButtonArray[56] = button57;
            fieldButtonArray[57] = button58;
            fieldButtonArray[58] = button59;
            fieldButtonArray[59] = button60;
            fieldButtonArray[60] = button61;
            fieldButtonArray[61] = button62;
            fieldButtonArray[62] = button63;
            fieldButtonArray[63] = button64;
        }
        private void FieldButton_Click(object sender, EventArgs e)
        {

            //TODO EXTRA how to change the button. make the program more pretty.
            Button b = (Button) sender;
            int number = int.Parse(b.Name.Remove(0, 6));
            if (flag && b.Text == "")
            {
                b.Text = "F";
                b.ForeColor = Color.Red;
            }
            else if (flag && b.Text == "F")
            {
                b.Text = "";
                b.ForeColor = default(Color);
            }
            else
            {
                if (b.Text != "")
                {

                }
                else
                {
                    b.Text = Field.field[number - 1];
                    numberOfFieldsOpen++;
                }
                
            }
            if (GameOverCheck(b.Text))
            {
                GameOverScreen();
            }
            else if (numberOfFieldsOpen == (Field.numberOfFields - Field.numberOFBoms))
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
            /*
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
            button64.Text = "";*/
            foreach(Button a in fieldButtonArray)
            {
                a.Text = "";
                a.ForeColor = default(Color);
            }
            firstField.FieldCreator();
            numberOfFieldsOpen = 0;
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Are you sure you want to start a new game ?", "New game?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                NewGame();
            }
        }
    }
}
