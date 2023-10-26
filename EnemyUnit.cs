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
        Abilities AbilitieList;
        public EnemyUnit(Abilities abilitieList, int id, int hp, int speed, int sRow, int sCol, int lRow, int lCol, int gRow, int gCol) : base(id, hp, speed, sRow, sCol, lRow, lCol, gRow, gCol)
        {
            Abilities AbilitieList = abilitieList;
        }

        public void UseAbilitie()
        {

        }

        public override void Move(Vector2 location)
        {

        }
    }
}
