using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerGame
{
    class MapLocation : Point
    {
        public MapLocation(int x, int y, Map map) : base(x, y)
        {
            if (map.OnMap(this))
            {
                throw new System.Exception(x + "," + y + " is outside the boundaries of the map.");
            }
        }
    }
}
