using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseConstruction
{
    public class Walls : IPart
    {
        public bool IsBuilt { set; get; }

        private List<bool> walls;

        public void SetWalls(int index)
        {
            if (index < 4 && index > -1)
            {
                walls[index] = true;
            }            
        }

        public Walls()
        {
            IsBuilt = false;
            walls = new List<bool>();
            walls.Add(false);
            walls.Add(false);
            walls.Add(false);
            walls.Add(false);
        }
    }
}
