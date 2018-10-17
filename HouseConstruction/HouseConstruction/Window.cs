using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseConstruction
{
    public class Window : IPart
    {
        public bool IsBuilt { set; get; }

        private List<bool> window;

        public void SetWindow(int index)
        {
            if (index < 4 && index > -1)
            {
                window[index] = true;
            }
        }

        public bool GetWindow(int index)
        {
            if (index < 4 && index > -1)
            {
                return window[index];
            }
            return false;
        }

        public Window()
        {
            window = new List<bool>();
            window.Add(false);
            window.Add(false);
            window.Add(false);
            window.Add(false);
        }
    }
}
