using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
//arena jest tworzona na i tylko na czas walki (potem usuwamy aż do następnej potyczki),
//tutaj są handlowane wszystkie obiekty, wywoływane umiejętności i generalnie funkcje zarządzające
namespace MGrouglike
{
    internal class ArenaBase
    {
        //baza
        public int[,] Grid; //trzymamy w nim id wszystkich pierduł by wiedzieć gdzie co jest
        public List<List<PlayerUnit>> PlayerUnits = new List<List<PlayerUnit>>();
        public List<List<EnemyUnit>> EnemyUnits = new List<List<EnemyUnit>>();
        public ArenaBase(int sizeY, int sizeX) //deklaracja Grida i init entites
        {
            Grid = new int[sizeY, sizeX];
            //jakiś init entities dla areny
        }
        public void KillEnt(int id) //zabijamy via id (usuwamy id z gird i listy)
        {

        }
        public void AddPlayerUnit(PlayerUnit unit) //dodajemy jednostke dla gracza
        {

        }
        public void AddEnemyUnit(EnemyUnit unit) //dodajemy jednostke dla enemy
        {

        }

    }
}
