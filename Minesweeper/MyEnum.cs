using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    enum MyMouse 
    {
        none,
        left,
        right,
    }
    enum MyGrid
    {
        none,//未按格子
        flag,//標記旗子
        questionMark,//標記問號
        press,//已按格子
    }
    enum MyMine
    {
       no,
       yes
    }
    enum MyGame
    {
        none,
        Win,
        Lose
    }
}
