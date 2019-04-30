using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveMgmt
{
       class NectarStinger : Worker, INectarCollecter, IStingPatrol
    {
        public int AlertLevel
        { get; private set; }

        public int StingerLength
        { get; set;}

        public int Nectar
        { get; set; }

        public bool LookForEnemies() { }

        public int SharpenStinger(int length) { }

        public void FindFlowers()
        { }

        public void GatherNectar()
        { }

        public void ReturnToHive()
        { }

    }
}
