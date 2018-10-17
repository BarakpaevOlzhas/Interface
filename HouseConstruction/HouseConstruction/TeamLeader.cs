using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseConstruction
{
    public class TeamLeader : IWorker
    {
        private Basement basement = new Basement();

        private Door door = new Door();

        private Roof roof = new Roof();

        private Walls walls = new Walls();

        private Window window = new Window();

        public TeamLeader()
        {
            
        }

        public string ShowStat()
        {
            return $"basement: {basement.IsBuilt} \n door: {door.IsBuilt} \n roof: {roof.IsBuilt} \n walls: {walls.IsBuilt} \n window: {window.IsBuilt}";
        }

        public void CheckAll(House house)
        {
            if (house.Basement.IsBuilt)
                basement.IsBuilt = true;

            if (house.Door.IsBuilt)
                door.IsBuilt = true;

            if (house.Walls.IsBuilt)
                walls.IsBuilt = true;

            if (house.Window.IsBuilt)
                window.IsBuilt = true;

            if (house.Roof.IsBuilt)
                roof.IsBuilt = true;
        }

        public bool CheckForConstruction(IPart part)
        {
            if (part.IsBuilt)
            {
                if (part.GetType() == basement.GetType())
                {
                    basement.IsBuilt = true;
                }
                else if (part.GetType() == door.GetType())
                {
                    door.IsBuilt = true;
                }
                else if (part.GetType() == roof.GetType())
                {
                    roof.IsBuilt = true;
                }
                else if (part.GetType() == walls.GetType())
                {
                    walls.IsBuilt = true;
                }                
                else if (part.GetType() == window.GetType())
                {
                    window.IsBuilt = true;
                }

                return true;
            }
            return false;
        }

        public void СonstructionPart(IPart part)
        {
            
        }
    }
}
