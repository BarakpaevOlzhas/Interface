using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseConstruction
{
    class Program
    {
        static void Main(string[] args)
        {
            House house = new House();

            Worker worker = new Worker();

            TeamLeader teamLeader = new TeamLeader();

            worker.BildOrCheck(house.Basement);
            worker.BildOrCheck(house.Door);
            worker.BildOrCheck(house.Walls);
            worker.BildOrCheck(house.Window);
            worker.BildOrCheck(house.Roof);

            teamLeader.CheckForConstruction(house.Roof);

            Console.WriteLine(teamLeader.ShowStat());

            teamLeader.CheckAll(house);

            Console.WriteLine(teamLeader.ShowStat());

            Console.ReadLine();

            Console.Clear();

            house.Show(0);

            Console.ReadLine();

            house.Show(1);

            Console.ReadLine();

            house.Show(2);

            Console.ReadLine();

            house.Show(3);

            Console.ReadLine();
        }
    }
}
