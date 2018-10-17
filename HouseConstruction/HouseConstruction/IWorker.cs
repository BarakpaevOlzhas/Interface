using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseConstruction
{
    interface IWorker
    {
        void СonstructionPart(IPart part);

        bool CheckForConstruction(IPart part);
    }
}
