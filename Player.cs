﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    public class Player:Chara
    {
        public Player(int level)
        {
            Level = level;
            HP = level * 10 + 100;
            Attack = level + 10;
            Defense = 10;
        }

        
    }
}
