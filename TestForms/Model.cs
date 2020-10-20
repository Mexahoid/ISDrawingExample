using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForms
{
    class Model
    {
        public static int DIM = 40;

        public List<int[]> Coords
        {
            get;
            private set;
        }

        public Model()
        {
            Coords = new List<int[]>();
        }

        public void AddBlockAt(int x, int y)
        {
            var arr = new[] { x, y };
            Coords.Add(arr);
        }

        public void DeleteBlockAt(int x, int y)
        {
            for (int i = 0; i < Coords.Count; i++)
            {
                var arr = Coords[i];
                int x1 = arr[0];
                int y1 = arr[1];
                int x2 = x1 + DIM;
                int y2 = y1 + DIM;

                if (x >= x1 && x <= x2 && y >= y1 && y <= y2)
                {
                    Coords.RemoveAt(i);
                    return;
                }
            }
        }
    }
}
