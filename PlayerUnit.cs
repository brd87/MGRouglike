using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGrouglike
{
    internal class PlayerUnit : UnitBase
    {
        public string[] Name = new string[3]; //ability names
        public string[] Desc = new string[3]; //ability descriptions
        public int[,] RangeAoeSpeed = new int[3,3]; //ability ranges and aoe (example: 10,5,3 - 10 range, 5 aoe, 3 projectile speed)
        public int[,] ModeValueFaction = new int[3,3]; //ability mode, value, faction (example: 2,10,1 - 2 is for movement mode, 10 decrease speed, 1 enemy units)

        public PlayerUnit(int id, int hp, int speed, int sRow, int sCol, int lRow, int lCol, int gRow, int gCol) : base(id, hp, speed, sRow, sCol, lRow, lCol, gRow, gCol)
        {
        }

    }
}
