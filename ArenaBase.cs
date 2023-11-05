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
        public List<PlayerUnit> PlayerUnits = new List<PlayerUnit>();
        public List<EnemyUnit> EnemyUnits = new List<EnemyUnit>();
        public List<Projectile> Projectiles = new List<Projectile>();
        public ArenaBase(int sizeY, int sizeX) //deklaracja Grida i init entites
        {
            Grid = new int[sizeY, sizeX];
            //jakiś init entities dla areny
        }

        public void KillEnt(int id) //zabijamy via id (usuwamy id z gird i listy)
        {

        }

        public void KillPRojectile(int id) 
        {
            Projectiles.RemoveAt(id);
        }

        public void AddProjectile(Projectile projectile)
        {
            Projectiles.Add(projectile);
        }

        public void AddPlayerUnit(PlayerUnit unit)
        {
            PlayerUnits.Add(unit);
        }

        public void AddEnemyUnit(EnemyUnit unit)
        {
            EnemyUnits.Add(unit);
        }

        public void AbilityContact(int idProjectile)
        {
            int idSource = Projectiles[idProjectile].IdSource;
            int mode;
            int value;
            int faction;
            if (Projectiles[idProjectile].PlayerAbID != -1)
            {
                int abID = Projectiles[idProjectile].PlayerAbID;
                mode = PlayerUnits[idSource].ModeValueFaction[abID, 0];
                value = PlayerUnits[idSource].ModeValueFaction[abID, 1];
                faction = PlayerUnits[idSource].ModeValueFaction[abID, 2];
            }
            else
            {
                mode = EnemyUnits[Projectiles[idProjectile].IdSource].ModeValueFaction[0];
                value = EnemyUnits[Projectiles[idProjectile].IdSource].ModeValueFaction[1];
                faction = EnemyUnits[Projectiles[idProjectile].IdSource].ModeValueFaction[2];
            }
            switch (mode)
            {
                case 0: //health heal/attack

                    break;
                case 1: //dmg buff/nerf

                    break;
                case 2: //movement buff/nerf

                    break;
                case 3: //shield gain/take

                    break;
                    //add more cases if needed
            }
        }

    }
}
