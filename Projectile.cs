using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGrouglike
{
    public struct Projectile
    {
        public Vector2 Position;
        public Vector2 Trajectory;
        public Vector2 Target;
        public int Speed;

        public int IdSource;
        public int Mode;
        public int PlayerAbID;

        public Projectile(Vector2 position, Vector2 trajectory, Vector2 target, int speed, int idSource, int mode, int playerAbID = -1)
        {
            Position = position;
            Trajectory = trajectory;
            Target = target;
            Speed = speed;

            IdSource = idSource;
            Mode = mode;
            PlayerAbID = playerAbID;
        }
    }
}
