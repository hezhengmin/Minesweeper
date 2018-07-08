using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class FormSetting : Form
    {
        FormMain formParent;
        public FormSetting(FormMain formMain)
        {
            InitializeComponent();
            formParent = formMain;
            slipSoundCheckBox.Checked = Music.slipSoundBool;
            bombSoundCheckBox.Checked = Music.bombSoundBool;
            widthNumericUpDown.Value = formParent.game.width;
            heightNumericUpDown.Value = formParent.game.height;
            minesNumericUpDown.Value = formParent.game.mineCount;
        }
        private void okButton_Click(object sender, EventArgs e)
        {
            int width = Convert.ToInt32(widthNumericUpDown.Value);
            int height = Convert.ToInt32(heightNumericUpDown.Value);
            int mines = Convert.ToInt32(minesNumericUpDown.Value);
            formParent.game.SetGame(width, height, mines);
            this.Close();
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void slipSoundCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (slipSoundCheckBox.Checked == true)
            {
                Music.slipSoundBool = true;
            }
            else if(slipSoundCheckBox.Checked == false)
            {
                Music.slipSoundBool = false;
            }
        }
        private void bombSoundCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (bombSoundCheckBox.Checked == true)
            {
                Music.bombSoundBool = true;
            }
            else if (bombSoundCheckBox.Checked == false)
            {
                Music.bombSoundBool = false;
            }
        }
    }
}
