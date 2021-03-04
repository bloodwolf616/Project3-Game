using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreehouseDefense
{
    class PowerfulTower : Tower
    {
        protected override int Power { get; } = 3;

        protected override int Range { get; } = 3;
        public PowerfulTower(MapLocation location) : base(location)
        { }


    }
}
