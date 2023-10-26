using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace MGrouglike
{
    internal class Abilities //luźny zaryz bo nie mam do końca pomysłu jak to ma działać
    {
        bool CanUseH; //boole stwierdzające które abilitie można użyć
        bool CanUseM;
        bool CanUseA;
        enum AbType
        {
            HealthManip,
            MovementManip,
            AbilitieManip
        }
        int HealthM; //zmiany nanoszone na hp
        int HealthT; //czas zmian w hp (np możemy osłabić kogoś o 50hp, ale tylko na 5sec, potem mu wraca te zdrowie), -1 jeśli permanentne/brak
        int MovementM; //i adekwatnie dla ruchu
        int MovementT; //tak samo jak z HealthT tylko dla poruszania się
        int AbilitieT; //tak samo jak z HealthT tylko dla czasu na jaki wyłączamy umiejętność/ci

        public Abilities(int healthM, int healthT, int movementM, int movementT) 
        {
            HealthM = healthM;
            HealthT = healthT;
            MovementM = movementM;
            MovementT = movementT;
        }

        public void Execute(AbType mode, UnitBase target, int abilitie = -1) //trzeba wykombinować jak się podpiąć do entitie i zmieniać jego parametry
        {
            //abilitie = -1 domyślnie oznacza że wyłączamy wszystkie umiejętności
            switch (mode)
            {
                case AbType.HealthManip:
                    //robi coś
                    break;
                case AbType.MovementManip:
                    //robi coś
                    break;
                case AbType.AbilitieManip:
                    //robi coś
                    break;
            }
        }
    }
}
