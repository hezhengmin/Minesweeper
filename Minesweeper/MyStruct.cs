using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    public struct MyStruct
    {
        public int row { get; private set; }
        public int col { get; private set; }
        public MyStruct(int row, int col)
        {
            this.row = row;
            this.col = col;
        }
    }
}
