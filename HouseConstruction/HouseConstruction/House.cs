using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseConstruction
{
    public class House
    {
        public Basement Basement { get; }

        public Door Door { get; }

        public Roof Roof { get; }

        public Walls Walls { get; set; }

        public Window Window { get; set; }

        public House()
        {
            Basement = new Basement();
            Door = new Door();
            Roof = new Roof();
            Walls = new Walls();
            Window = new Window();
        }

        public void Show(int side)
        {
            Console.SetCursorPosition(6, 2); Console.WriteLine(Roof.IsBuilt ? "   ^^^^^^^^^^^^^   " : "");
            Console.SetCursorPosition(6, 3); Console.WriteLine(Roof.IsBuilt ? "  ^^^^^^^^^^^^^^^  " : "");
            Console.SetCursorPosition(6,4); Console.WriteLine(Roof.IsBuilt ? " ^^^^^^^^^^^^^^^^^ " : "");
            if (side == 0)
            {
                Console.SetCursorPosition(5,5); Console.WriteLine(Walls.IsBuilt ? "####################" : "");
                Console.SetCursorPosition(5,6); Console.WriteLine(Walls.IsBuilt ? "####################" : "");
                Console.SetCursorPosition(5,7); Console.WriteLine(Walls.IsBuilt ? "####################" : "");
                Console.SetCursorPosition(5,8); Console.WriteLine(Walls.IsBuilt ? "####################" : "");
                Console.SetCursorPosition(5,9); Console.WriteLine(Walls.IsBuilt ? "####################" : "");
                Console.SetCursorPosition(5,10); Console.WriteLine(Basement.IsBuilt?     "MMMMMMMMMMMMMMMMMMMM" : "");

                Console.SetCursorPosition(7, 7); Console.WriteLine(Window.IsBuilt ? "      " : "");
                Console.SetCursorPosition(7, 8); Console.WriteLine(Window.IsBuilt ? "      " : "");

                Console.SetCursorPosition(17, 7); Console.WriteLine(Door.IsBuilt ? "|====|":"");
                Console.SetCursorPosition(17, 8); Console.WriteLine(Door.IsBuilt ? "|   *|":"");
                Console.SetCursorPosition(17, 9); Console.WriteLine(Door.IsBuilt ? "|====|":"");

                Console.SetCursorPosition(5, 11); Console.WriteLine("Front");
            }
            else if (side == 1)
            {
                Console.SetCursorPosition(5, 5); Console.WriteLine(Walls.IsBuilt ? "####################" : "");
                Console.SetCursorPosition(5, 6); Console.WriteLine(Walls.IsBuilt ? "####################" : "");
                Console.SetCursorPosition(5, 7); Console.WriteLine(Walls.IsBuilt ? "####################" : "");
                Console.SetCursorPosition(5, 8); Console.WriteLine(Walls.IsBuilt ? "####################" : "");
                Console.SetCursorPosition(5, 9); Console.WriteLine(Walls.IsBuilt ? "####################" : "");
                Console.SetCursorPosition(5, 10); Console.WriteLine(Basement.IsBuilt ? "MMMMMMMMMMMMMMMMMMMM" : "");

                Console.SetCursorPosition(7, 7); Console.WriteLine(Window.IsBuilt ? "      " : "");
                Console.SetCursorPosition(7, 8); Console.WriteLine(Window.IsBuilt ? "      " : "");

                Console.SetCursorPosition(5, 11); Console.WriteLine("Left");
            }
            else if (side == 2)
            {
                Console.SetCursorPosition(5, 5); Console.WriteLine(Walls.IsBuilt ? "####################" : "");
                Console.SetCursorPosition(5, 6); Console.WriteLine(Walls.IsBuilt ? "####################" : "");
                Console.SetCursorPosition(5, 7); Console.WriteLine(Walls.IsBuilt ? "####################" : "");
                Console.SetCursorPosition(5, 8); Console.WriteLine(Walls.IsBuilt ? "####################" : "");
                Console.SetCursorPosition(5, 9); Console.WriteLine(Walls.IsBuilt ? "####################" : "");
                Console.SetCursorPosition(5, 10); Console.WriteLine(Basement.IsBuilt ? "MMMMMMMMMMMMMMMMMMMM" : "");

                Console.SetCursorPosition(7, 7); Console.WriteLine(Window.IsBuilt ? "      " : "");
                Console.SetCursorPosition(7, 8); Console.WriteLine(Window.IsBuilt ? "      " : "");

                Console.SetCursorPosition(5, 11); Console.WriteLine("Back");
            }
            else if (side == 3)
            {
                Console.SetCursorPosition(5, 5); Console.WriteLine(Walls.IsBuilt ? "####################" : "");
                Console.SetCursorPosition(5, 6); Console.WriteLine(Walls.IsBuilt ? "####################" : "");
                Console.SetCursorPosition(5, 7); Console.WriteLine(Walls.IsBuilt ? "####################" : "");
                Console.SetCursorPosition(5, 8); Console.WriteLine(Walls.IsBuilt ? "####################" : "");
                Console.SetCursorPosition(5, 9); Console.WriteLine(Walls.IsBuilt ? "####################" : "");
                Console.SetCursorPosition(5, 10); Console.WriteLine(Basement.IsBuilt ? "MMMMMMMMMMMMMMMMMMMM" : "");

                Console.SetCursorPosition(7, 7); Console.WriteLine(Window.IsBuilt ? "      " : "");
                Console.SetCursorPosition(7, 8); Console.WriteLine(Window.IsBuilt ? "      " : "");

                Console.SetCursorPosition(5, 11); Console.WriteLine("Right");
            }
        }

    }
}
