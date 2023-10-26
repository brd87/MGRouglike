using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGrouglike
{
    internal class UnitBase
    {   
        int ID; //ID.
        int HP; //HP.
        int Speed; //prędkość przemieszczania (może być 0 [gracz puki co się nie rusza więc będzie miał 0])

        int SRow; //jeśli będziemy używać atlasu textur to oto nam daje pozycje gdzie szukać spirte
        int SCol;

        int LRow; //pozycja na ekranie
        int LCol;

        int GRow; //pozycja na grid
        int GCol;

        public UnitBase(int id, int hp, int speed, int sRow, int sCol, int lRow, int lCol, int gRow, int gCol)
        {
            ID = id;
            HP = hp;
            Speed = speed;
            SRow = sRow;
            SCol = sCol;
            LRow = lRow;
            LCol = lCol;
            GRow = gRow;
            GCol = gCol;
        }

        public void Draw(Texture2D texture, SpriteBatch spriteBatch, Vector2 location) //rysowańsko, ten Vector2 daje informacje gdzie ma być narysowany spirite, ale możemy też użyć do tego LRow/Col
        {
            int size = 50; //pamiętam że go czegoś to było potrzebne, ale nie pamiętam do czego dokładnie
            Texture2D Texture = texture;
            Rectangle sourceRectangle = new Rectangle(size * SCol, size * SRow, size, size);
            Rectangle target = new Rectangle((int)location.X, (int)location.Y, size, size);
            spriteBatch.Draw(Texture, target, sourceRectangle, Microsoft.Xna.Framework.Color.White);
        }

        public virtual void Move(Vector2 location) //porusza się w kierunku wskazanego cleu (puki co w lini prostej), nie koniecznie musi to być void, to tylko zarys poki co (wszystko jest zarysem)
        {

        }

        public void UpdateScreen((int y, int x) newLoc)
        {
            LCol = newLoc.y; LRow = newLoc.x;
        }
        public void UpdateGrid((int y, int x) newLoc)
        {
            GCol = newLoc.y; GRow = newLoc.x;
        }

        public (int y, int x) ReturnScreen()
        {
            return (LCol, LRow);
        }

        public (int y, int x) ReturnGrid()
        {
            return (GCol, GRow);
        }
    }
}
