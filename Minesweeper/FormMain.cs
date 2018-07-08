using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Minesweeper
{
    public partial class FormMain : Form
    {
        public Game game;
        public FormMain()
        {
            InitializeComponent();
            this.DoubleBuffered = true;//減少圖形重繪閃動
            game = new Game();
            newGameNToolStripMenuItem_Click(new object(), new EventArgs());
        }
        private void FormMain_Paint(object sender, PaintEventArgs e)
        {
            game.DrawBoard(e.Graphics, menuStripMain.Height);
            game.del.Invoke(e.Graphics,this);//呼叫參考方法
        }
        private void newGameNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            beginnerBToolStripMenuItem.Checked = false;
            intermediateIToolStripMenuItem.Checked = false;
            expertEToolStripMenuItem.Checked = false;
            settingtoolStripMenuItem.Checked = false;
            if (sender == beginnerBToolStripMenuItem)
            {
                game.SetGame(9, 9, 10);
                beginnerBToolStripMenuItem.Checked = true;
            }
            else if (sender == intermediateIToolStripMenuItem)
            {
                game.SetGame(16, 16, 40);
                intermediateIToolStripMenuItem.Checked = true;
            }
            else if (sender == expertEToolStripMenuItem)
            {
                game.SetGame(30, 16, 99);
                expertEToolStripMenuItem.Checked = true;
            }
            else if (sender == settingtoolStripMenuItem)
            {
                settingtoolStripMenuItem.Checked = true;
            }
            game.ChangeFormSize(this, menuStripMain.Height, TableLayoutPanelMain.Height);
            game.SetGame();
            labelTime.Text = "0";//時間歸零
            timerMain.Enabled = true;//開始計時
            labelMine.Text = game.mineCount.ToString();//地雷數量
            this.Refresh();//重新繪製
        }
        private void exitXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to quit the game?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        /// <summary>
        /// Windows dialogbox
        /// </summary>
        /// <param name="hWnd"></param>
        /// <param name="szApp">dialogbox標題</param>
        /// <param name="szOtherStuff">dialogbox內文</param>
        /// <param name="hIcon">圖示</param>
        /// <returns></returns>
        [DllImport("shell32.dll")]
        static extern int ShellAbout(IntPtr hWnd, string szApp, string szOtherStuff, IntPtr hIcon);
        private void aboutAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShellAbout(this.Handle, "Minesweeper", "Version 1.0", this.Icon.Handle);
        }
        private void FormMain_MouseMove(object sender, MouseEventArgs e)
        {
            game.mouse.X = e.X / 32;
            game.mouse.Y = (e.Y - menuStripMain.Height) / 32;
            this.Refresh();
        }
        private void FormMain_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    game.mouseLeftRight = (int)MyMouse.left;
                    break;
                case MouseButtons.Right:
                    game.mouseLeftRight = (int)MyMouse.right;
                    break;
            }
        }
        private void FormMain_MouseUp(object sender, MouseEventArgs e)
        {
            game.FuncMouseUp();
            labelMine.Text = Convert.ToString(game.mineCount - game.flagCount);//即時更新地雷數量
            timerMain.Enabled = game.gameStart;
            game.mouseLeftRight = (int)MyMouse.none;//恢復滑鼠不按任一鍵                            
            this.Refresh();
        }
        private void timerMain_Tick(object sender, EventArgs e)
        {
            labelTime.Text = Convert.ToString(Convert.ToInt32(labelTime.Text) + 1);
        }
        private void settingtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSetting formSetting = new FormSetting(this);
            formSetting.ShowDialog();//強制回應表單
            newGameNToolStripMenuItem_Click(settingtoolStripMenuItem, new EventArgs());
        }
    }
}
