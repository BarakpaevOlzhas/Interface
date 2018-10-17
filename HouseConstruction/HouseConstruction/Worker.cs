using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseConstruction
{
    class Worker : IWorker
    {
        public bool CheckForConstruction(IPart part)
        {
            if (part.IsBuilt)
            {
                return true;
            }
            return false;
        }

        public void BildOrCheck(IPart part)
        {
            Window window = new Window();
            Walls walls = new Walls();
            if (!part.IsBuilt)
            {         
                СonstructionPart(part);
            }
        }

        public void СonstructionPart(IPart part)
        {
            part.IsBuilt = true;           
        }
    }
}
