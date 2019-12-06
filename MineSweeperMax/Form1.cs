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
        //TODO: 3.attach field to cells
        //TODO: 4.flag command
        //TODO: 5. new game command
        public Form1()
        {
            InitializeComponent();
            
        }
        private void button33_Click(object sender, EventArgs e)
        {

            //TODO how to change the button.
            Button b = (Button) sender;
            int number = int.Parse(b.Name.Remove(0, 6));
            Button a = button1;
            b.Text = Field.field[number - 1];
        }
    }
}
