using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    public abstract class GameParent
    {
        private const int maxCol = 105;
        private const int maxRow = 105;
        public int width { get; set; }
        public int height { get; set; }
        /// <summary>
        /// 地雷數量
        /// </summary>
        public int mineCount { get; set; }
        /// <summary>
        /// 旗子數量
        /// </summary>
        public int flagCount { get; set; }
        /// <summary>
        /// 滑鼠座標(X,Y)
        /// </summary>
        public Point mouse;
        /// <summary>
        /// 滑鼠按左鍵或右鍵
        /// </summary>
        public int mouseLeftRight { get; set; }
        /// <summary>
        /// mMines[ , ] =1 是地雷 =0 不是地雷
        /// </summary>
        public int[,] mMines = new int[maxRow, maxCol];
        /// <summary>
        /// 格子的狀態(未按格子/已按格子/標記旗子/標記問號)
        /// </summary>
        public int[,] mGrids = new int[maxRow, maxCol];
        /// <summary>
        /// nGrids[ , ] 統計每格地雷數量
        /// </summary>
        public int[,] nGrids = new int[maxRow, maxCol];
        /// <summary>
        /// 遊戲音效
        /// </summary>
        protected Music music;
        protected Random random = new Random();
        public List<MyStruct> list = new List<MyStruct>();
        protected int[,] dir = new int[8, 2] { { 1, -1 }, { 1, 0 }, { 1, 1 }, { 0, -1 }, { 0, 1 }, { -1, -1 }, { -1, 0 }, { -1, 1 } };
        /// <summary>
        /// 遊戲是否結束
        /// </summary>
        public bool gameStart;
        /// <summary>
        /// 遊戲結果
        /// </summary>
        public int gameResult;
        /// <summary>
        /// 
        /// </summary>
        public bool status;
        public GameParent()
        {

        }
        /// <summary>
        /// 遊戲參數設定
        /// </summary>
        /// <param name="width">格子(列)數量</param>
        /// <param name="height">格子(行)數量</param>
        /// <param name="mineCount">地雷數量</param>
        public GameParent(int width, int height, int mineCount)
        {
            this.width = width;
            this.height = height;
            this.mineCount = mineCount;
        }
        public virtual void SetGame(int width, int height, int mineCount)
        {
            this.width = width;
            this.height = height;
            this.mineCount = mineCount;
        }
        protected abstract void SetMine();
    }
}
