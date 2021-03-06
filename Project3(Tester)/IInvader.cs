﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreehouseDefense
{
   interface IInvader 
    {

        public MapLocation Location =>  { get; };

        // True if the invader has reached the end of the path
         bool HasScored { get; }

         virtual int Health { get; }

         bool IsNeutralized  { get; }

         bool IsActive { get; }

    

         void Move();

         void DecreaseHealth(int factor);
        



    }
}
