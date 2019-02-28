using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerGame
{
    class StrongInvader : Invader
    {
        protected override int StepSize { get; } = 2;

        public virtual int Health { get; private set; } = 2;

        public FastInvader(Path path) : base(path)
        { }

    }
}
