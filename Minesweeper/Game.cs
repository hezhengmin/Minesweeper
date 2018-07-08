using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    public class Game : GameParent
    {
        public delegate void myDelegate(Graphics g, FormMain formMain);
        public myDelegate del;
        public Game() : base(9, 9, 10)
        {
            SetMine();
        }
        public override void SetGame(int width, int height, int mineCount)
        {
            this.width = width;
            this.height = height;
            this.mineCount = mineCount;
            SetMine();
        }
        public void SetGame()
        {
            this.width = width;
            this.height = height;
            this.mineCount = mineCount;
            SetMine();
        }
        /// <summary>
        /// 設定地雷，統計周圍地雷數量
        /// </summary>
        protected override void SetMine()
        {
            del = new myDelegate(GameWinDrawBoardFunction);//宣告委派物件
            this.status = true;
            this.flagCount = 0;
            mouse.X = -10;
            mouse.Y = -10;
            mouseLeftRight = (int)MyMouse.none;
            this.gameStart = true;
            this.gameResult = (int)MyGame.none;
            music = new Music();
            Array.Clear(nGrids, 0, mMines.Length);
            Array.Clear(mMines, 0, mMines.Length);
            Array.Clear(mGrids, 0, mGrids.Length);
            list.Clear();
            var count = this.mineCount;
            while (count > 0)
            {
                int c = random.Next(this.width);
                int r = random.Next(this.height);
                if (mMines[r, c] == (int)MyMine.no)
                {
                    mMines[r, c] = (int)MyMine.yes;
                    count--;
                    list.Add(new MyStruct(r, c));
                }
            }
            foreach (var item in list)
            {
                for (int i = 0; i < dir.GetLength(0); i++)
                {
                    int x = dir[i, 0] + item.row;
                    int y = dir[i, 1] + item.col;
                    if (x < 0 || y < 0) continue;
                    if (mMines[x, y] == (int)MyMine.yes) continue;
                    nGrids[x, y]++;//格子地雷數
                }
            }
        }
        /// <summary>
        /// 更改Form視窗大小
        /// </summary>
        /// <param name="formMain"></param>
        /// <param name="menuStripMainHeight"></param>
        /// <param name="TableLayoutPanelMainHeight"></param>
        public void ChangeFormSize(FormMain formMain, int menuStripMainHeight, int TableLayoutPanelMainHeight)
        {
            formMain.Width = formMain.Width - formMain.ClientSize.Width + this.width * 32;
            formMain.Height = formMain.Height - formMain.ClientSize.Height + this.height * 32 + menuStripMainHeight + TableLayoutPanelMainHeight;
        }
        /// <summary>
        /// 繪畫踩地雷的格子
        /// </summary>
        /// <param name="g"></param>
        /// <param name="offset">C#功能表控制項(MenuStrip)高度的誤差</param>
        public void DrawBoard(Graphics g, int offset)
        {
            for (int i = 0; i < height; i++)//列
            {
                for (int j = 0; j < width; j++)//行
                {
                    switch (mGrids[i, j])
                    {
                        case (int)MyGrid.none:
                        case (int)MyGrid.flag:
                        case (int)MyGrid.questionMark:
                            if (mouse.X == j && mouse.Y == i)//滑鼠移動到的未按方格
                            {
                                g.FillRectangle(Brushes.MistyRose, new Rectangle(j * 32, offset + i * 32, 31, 31));
                            }
                            else
                            {
                                g.FillRectangle(Brushes.Pink, new Rectangle(j * 32, offset + i * 32, 31, 31));//畫方格
                            }
                            if (mGrids[i, j] == (int)MyGrid.flag)//旗子
                            {
                                g.DrawImage(Properties.Resources.flag, j * 32, offset + i * 32);//size 30x30
                            }
                            if (mGrids[i, j] == (int)MyGrid.questionMark)//問號
                            {
                                g.DrawImage(Properties.Resources.question, j * 32, offset + i * 32);//size 30x30
                            }
                            break;
                        case (int)MyGrid.press:
                            if (mouse.X == j && mouse.Y == i)//滑鼠移動到的已按方格
                            {
                                g.FillRectangle(Brushes.MistyRose, new Rectangle(j * 32, offset + i * 32, 31, 31));
                            }
                            else
                            {
                                g.FillRectangle(Brushes.LightBlue, new Rectangle(j * 32, offset + i * 32, 31, 31));
                            }
                            if (nGrids[i, j] >= 1)//填格子內的數字
                            {
                                Font font = new Font("Consolas", 18, FontStyle.Bold);
                                SizeF sizeF = g.MeasureString(Convert.ToString(nGrids[i, j]), font);
                                g.DrawString(Convert.ToString(nGrids[i, j]), font, GetBrushNumberColor(nGrids[i, j]), j * 32 + (32 - sizeF.Width) / 2, offset + i * 32 + (32 - sizeF.Height) / 2);
                            }
                            if (mMines[i, j] == (int)MyMine.yes)//地雷
                            {
                                g.DrawImage(Properties.Resources.mine_, j * 32, offset + i * 32);//size 30x30
                            }
                            break;
                        default:
                            break;
                    }
                }
            }
        }
        /// <summary>
        /// 深度優先搜尋法
        /// </summary>
        /// <param name="x">列</param>
        /// <param name="y">行</param>
        private void dfs(int x, int y)
        {
            mGrids[x, y] = (int)MyGrid.press;
            for (int i = 0; i < 8; i++)
            {
                int a = x + dir[i, 0];
                int b = y + dir[i, 1];
                if (a >= 0 && b >= 0 && a < height && b < width
                    && mGrids[a, b] == (int)MyGrid.none//未點開
                    && mMines[a, b] == (int)MyMine.no//不是地雷
                    && nGrids[x, y] == 0)//之前格子數字要是0
                {
                    dfs(a, b);
                }
            }
        }
        private SolidBrush GetBrushNumberColor(int n)
        {
            switch (n)
            {
                case 1: return new SolidBrush(Color.Blue);
                case 2: return new SolidBrush(Color.Green);
                case 3: return new SolidBrush(Color.Red);
                case 4: return new SolidBrush(Color.DarkBlue);
                case 5: return new SolidBrush(Color.Maroon);
                case 6: return new SolidBrush(Color.DarkBlue);
                case 7: return new SolidBrush(Color.BlueViolet);
                case 8: return new SolidBrush(Color.MidnightBlue);
                default: return new SolidBrush(Color.White);
            }
        }
        public void FuncMouseUp()
        {
            music.playAudioSlipSound();
            if (!gameStart && mouseLeftRight == (int)MyMouse.right) status = false;
            if (!gameStart) return;
            if (mouse.Y < 0 || mouse.X < 0) return;
            switch (mouseLeftRight)
            {
                case (int)MyMouse.left:
                    if (mGrids[mouse.Y, mouse.X] == (int)MyGrid.none ||
                        mGrids[mouse.Y, mouse.X] == (int)MyGrid.questionMark)
                    {
                        mGrids[mouse.Y, mouse.X] = (int)MyGrid.press;
                        if (mMines[mouse.Y, mouse.X] == (int)MyMine.no)
                        {
                            dfs(mouse.Y, mouse.X);
                        }
                        else
                        {
                            OpenAllMinesGrids();//引爆全部地雷
                            return;
                        }
                    }
                    else if (mGrids[mouse.Y, mouse.X] == (int)MyGrid.press)
                    {
                        OpenAroundGrids(mouse.Y, mouse.X);
                    }
                    break;
                case (int)MyMouse.right:
                    if (mGrids[mouse.Y, mouse.X] != (int)MyGrid.press)
                    {
                        this.flagCount = (mGrids[mouse.Y, mouse.X] == (int)MyGrid.flag) ? --this.flagCount : this.flagCount;
                        mGrids[mouse.Y, mouse.X] = (mGrids[mouse.Y, mouse.X] + 1) % 3;
                        this.flagCount = (mGrids[mouse.Y, mouse.X] == (int)MyGrid.flag) ? ++this.flagCount : this.flagCount;
                    }
                    break;
                default:
                    break;
            }
            GameWin();
        }
        /// <summary>
        /// 引爆全部地雷
        /// </summary>
        private void OpenAllMinesGrids()
        {
            gameResult = (int)MyGame.Lose;
            music.playAudiobombSound();
            foreach (var item in list)
            {
                mGrids[item.row, item.col] = (int)MyGrid.press;
            }
            this.gameStart = false;
        }
        /// <summary>
        /// 引爆周圍格子(九宮格內)
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        private void OpenAroundGrids(int x, int y)
        {
            int flagCount = 0;
            for (int i = 0; i < 8; i++)
            {
                int a = x + dir[i, 0];
                int b = y + dir[i, 1];
                if (a >= 0 && b >= 0 && a < height && b < width &&
                    mGrids[a, b] == (int)MyGrid.flag)
                {
                    flagCount++;
                }
            }
            if (flagCount != nGrids[x, y]) return;//計算數字和棋子符合
            for (int i = 0; i < 8; i++)
            {
                int a = x + dir[i, 0];
                int b = y + dir[i, 1];
                if (a >= 0 && b >= 0 && a < height && b < width
                    && mGrids[a, b] != (int)MyGrid.flag)
                {
                    if (mMines[a, b] == (int)MyMine.yes)
                    {
                        OpenAllMinesGrids();
                    }
                    else
                    {
                        dfs(a, b);
                    }
                }
            }
        }
        /// <summary>
        /// 遊戲獲勝
        /// </summary>
        private void GameWin()
        {
            int count = 0;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (mGrids[i, j] == (int)MyGrid.none ||
                        mGrids[i, j] == (int)MyGrid.flag ||
                        mGrids[i, j] == (int)MyGrid.questionMark)
                    {
                        count++;
                    }
                }
            }
            if (count == mineCount)//剩下的格子等於地雷總數
            {
                gameStart = false;
                gameResult = (int)MyGame.Win;
            }
        }
        /// <summary>
        /// 遊戲獲勝時，畫面變暗 Win Game ! 字幕
        /// </summary>
        /// <param name="g"></param>
        /// <param name="formMain"></param>
        public void GameWinDrawBoardFunction(Graphics g, FormMain formMain)
        {
            if (gameResult == (int)MyGame.Win && status)
            {
                Brush overLay = new SolidBrush(Color.FromArgb(127, Color.Black));
                g.FillRectangle(overLay, new Rectangle(0, 0, formMain.Width, formMain.Height));
                Font f = new Font("Arial", formMain.ClientSize.Width / 10);
                string text = "Win Game !";
                SizeF sizeF = g.MeasureString(text, f);
                g.DrawString(text, f, GetBrushNumberColor(0), (formMain.Width - sizeF.Width) / 2, (formMain.Height - sizeF.Height) / 2 - 74 / 2);
            }
        }
    }
}
