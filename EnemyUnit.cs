using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGrouglike
{
    internal class EnemyUnit : UnitBase
    {
        public int[] RangeAoe = new int[2];
        public int[] ModeValueFaction = new int[3];

        public EnemyUnit(int id, int hp, int speed, int sRow, int sCol, int lRow, int lCol, int gRow, int gCol) : base(id, hp, speed, sRow, sCol, lRow, lCol, gRow, gCol)
        {
        }

        public override void Move(Vector2 location)
        {

        }
    }
}
