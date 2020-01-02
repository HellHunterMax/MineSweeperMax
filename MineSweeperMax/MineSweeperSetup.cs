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
    public partial class MineSweeperSetup : Form
    {
        public static MineSweeperV2 newForm;
        public MineSweeperSetup()
        {
            InitializeComponent();
        }
        
        public int widthOfField, hightOfField;
        private void NewGameCustom_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxWidth.Text, out widthOfField)
                || !int.TryParse(textBoxHight.Text, out hightOfField)
                || hightOfField < 5
                || hightOfField > 25
                || widthOfField < 5
                || widthOfField > 25)
            {
                MessageBox.Show("Invalid imput, Please fill in a number from 5 to 25.");
                return;
            }
            newForm = new MineSweeperV2(widthOfField, hightOfField);

            newForm.ShowDialog();

        }
        public void NewGameV2()
        {
            NewGameCustom_Click(null, null);
        }
    }
}
